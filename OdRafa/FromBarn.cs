using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Xml.Serialization;
using System.Reflection;
using System.Collections.ObjectModel;

namespace Farm
{
    public partial class FromBarn : Form
    {
        private static bool _TextBoxesBoundedToDataSet = false;

        public List<Cow> colCows= new List<Cow>();

        public FromBarn()
        {
            InitializeComponent();
        }
        private void FromBarn_Load(object sender, EventArgs e)
        {
            //fill in comboboxes based on enums
            if (cmbRace.Items.Count == 0)
            {
                cmbRace.Items.AddRange(LoadEnumToObjectArr<EnumRace>());
            }
            if (cmbSex.Items.Count == 0)
            {
                cmbSex.Items.AddRange(LoadEnumToObjectArr<EnumSex>());
            }
            if (cmbType.Items.Count == 0)
            {
                cmbType.Items.AddRange(LoadEnumToObjectArr<EnumType>());
            }           
            
            //load data from XML
            DeserializeObject<List<Cow>>("cows.txt", ref colCows);

            lstCows.DataSource = colCows;
            lstCows.DisplayMember = "Name";
            BoundFormToCollection();
        }
        private void FromBarn_FormClosed(object sender, FormClosedEventArgs e)
        {
            //save data in XML file
            //SerializeObject<DataSet>("cows.txt", dsCows);
            SerializeObject<List<Cow>>("cows.txt", colCows);
        }


        //------Tab Stable----------------------------------

        private void BtnShowHayPrice_Click(object sender, EventArgs e)
        {   
            this.LblShowPrice.Text=GetPrice(20).ToString(CultureInfo.CurrentCulture);
        }
        private double GetPrice(double aVolume)
        {
            var stackOfHay = new Hay(EnumHayColor.yellow, 140);
            return stackOfHay.GetTotalPrice(aVolume);
        }



        //------Tab cowsheed----------------------------------

        private void lstCows_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DATASET option
            //BoundFormToActiveRow(lstCows.SelectedIndex);
            if (lstCows.SelectedIndex >= 0) { BoundFormToActiveRowInList(lstCows.SelectedIndex); };
        }

        private void btnDelActive_Click(object sender, EventArgs e)
        {
            int activeRow = lstCows.SelectedIndex;
            //disconnect ListBox from source
            lstCows.DataSource = null;
            //remove item
            colCows.RemoveAt(activeRow);
            //reconnect listBox
            lstCows.DataSource = colCows;
            lstCows.DisplayMember = "Name";
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            //disconnect listBox to add item
            lstCows.DataSource = null;

            //add  new Cow
            colCows.Add(new Cow { Name = "New name" });
            int activeRow = colCows.Count -1;

            //reconnect listBox
            lstCows.Items.Clear();
            lstCows.DataSource = colCows;
            lstCows.DisplayMember = "Name";
            lstCows.SelectedIndex = activeRow;

        }

        private void SerializeObject<T>(string filename,T ds)
        {
            //XmlSerializer ser = new XmlSerializer(typeof(T));
            //TextWriter writer = new StreamWriter(Application.StartupPath + @"\..\..\db\"+filename);
            //ser.Serialize(writer, ds);
            //writer.Close();
            XmlSerializer xs = new XmlSerializer(typeof(T));
            using (StreamWriter wr = new StreamWriter(Application.StartupPath + @"\..\..\db\" + filename))
            {
                xs.Serialize(wr, ds);
            }
        }
        private void DeserializeObject<T>(string filename, ref T ds)
        {
            //XmlSerializer ser = new XmlSerializer(typeof(T));
            //TextReader reader = new StreamReader(Application.StartupPath + @"\..\..\" + filename);
            //ds = (T)ser.Deserialize(reader);
            //reader.Close();
            XmlSerializer ser = new XmlSerializer(typeof(T));
            using (StreamReader rd = new StreamReader(Application.StartupPath + @"\..\..\db\" + filename))
            {
                if (rd.BaseStream.Length>0){ ds = (T)ser.Deserialize(rd);};
            }
        }

        private void BoundFormToActiveRow(int RowNoInDataTable) 
        {
            //changing position in context can trigger event SelectedIndexChanged
            //disable it to prevent neverending loop
            lstCows.SelectedIndexChanged -= lstCows_SelectedIndexChanged;
            foreach (Control ctrl in gbxAddEditCow.Controls)
            {
                if ((ctrl is TextBox) || (ctrl is ComboBox) || (ctrl is DateTimePicker))
                {
                    ctrl.BindingContext[dsCows.Tables[0]].Position = RowNoInDataTable;
                    System.Diagnostics.Debug.WriteLine(ctrl.Name);
                }
            }
            lstCows.SelectedIndexChanged += lstCows_SelectedIndexChanged;
          
        }
        private void BoundFormToActiveRowInList(int RowNoInDataTable)
        {
            //changing position in context can trigger event SelectedIndexChanged
            //disable it to prevent neverending loop
            lstCows.SelectedIndexChanged -= lstCows_SelectedIndexChanged;
            foreach (Control ctrl in gbxAddEditCow.Controls)
            {
                if ((ctrl is TextBox) || (ctrl is ComboBox) || (ctrl is DateTimePicker))
                {
                    ctrl.DataBindings.Clear();
                    ctrl.DataBindings.Add("Text", colCows[RowNoInDataTable], ctrl.Name.Substring(3), true, DataSourceUpdateMode.OnPropertyChanged);
                }
            }
            lstCows.SelectedIndexChanged += lstCows_SelectedIndexChanged;

        }
        private void BoundFormToDataSet()
        { 
            //bind controls to dataset, but only once
            if (!_TextBoxesBoundedToDataSet) 
            {
                foreach (Control ctrl in gbxAddEditCow.Controls)
                {
                    if ((ctrl is TextBox) || (ctrl is ComboBox) || (ctrl is DateTimePicker))
                    {
                        ctrl.DataBindings.Add("Text", dsCows.Tables[0], "dc" + ctrl.Name.Substring(3), 
                            false, DataSourceUpdateMode.OnPropertyChanged);
                    }
                }
                _TextBoxesBoundedToDataSet=true;
            }
        }
        private void BoundFormToCollection()
        {
            //bind controls to dataset, but only once
            if (!_TextBoxesBoundedToDataSet)
            {
                foreach (Control ctrl in gbxAddEditCow.Controls)
                {
                    if ((ctrl is TextBox) || (ctrl is ComboBox) || (ctrl is DateTimePicker))
                    {
                        ctrl.DataBindings.Add("Text", colCows[0], ctrl.Name.Substring(3), false, DataSourceUpdateMode.OnPropertyChanged);
                    }
                }
                _TextBoxesBoundedToDataSet = true;
            }
        }
        private object[] LoadEnumToObjectArr<T>()
        { 
            var objArr = Enum.GetValues(typeof(T));
            object[] arr = new object[objArr.Length];
            Array.Copy(objArr, arr, objArr.Length);
            return arr;
        }

     }
}
