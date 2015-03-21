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

namespace Farm
{
    public partial class FromBarn : Form
    {
        private static bool _TextBoxesBoundedToDataSet = false;
        public FromBarn()
        {
            InitializeComponent();
        }
        private double GetPrice(double aVolume) {
            var stackOfHay=new Hay(EnumHayColor.yellow,140);
            return stackOfHay.GetTotalPrice(aVolume);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //deserialize list
            DeserializeDataSet(@"D:\Dokumenty\PROJEKTY\OdRafa\OdRafa\db\cows.txt", ref dsCows);//@Properties.Settings.Default.CowsPath
    
            //lstCows.ValueMember = "dcID";
            lstCows.DataSource = dsCows.Tables[0].DefaultView;//new BindingSource(dsCows.Tables[0], null);
            lstCows.DisplayMember = "dcName";

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

            BoundFormToDataSet();
        }
        private void FromBarn_FormClosed(object sender, FormClosedEventArgs e)
        {
            SerializeDataSet("ds", dsCows);
        }

        private void txtBirthDate_TextChanged(object sender, EventArgs e)
        {
            txtBirthDate.Text = (txtBirthDate.Text.Length >= 10) ? txtBirthDate.Text.Substring(0, 10) : txtBirthDate.Text;
        }

        private void BtnShowHayPrice_Click(object sender, EventArgs e)
        {
            
            this.LblShowPrice.Text=GetPrice(20).ToString(CultureInfo.CurrentCulture);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button t1 = new Button();
            t1.Location = new Point(100, 100);
            t1.Size = new Size(50, 10);
            t1.Text = "Cycki";
            t1.Parent = this;
        }


        private void tabCowshed_Enter(object sender, EventArgs e)
        {

        }

        private void tabCowshed_Leave(object sender, EventArgs e)
        {

        }

        private void lstCows_SelectedIndexChanged(object sender, EventArgs e)
        {
            BoundFormToActiveRow(lstCows.SelectedIndex);
        }

        private void btnDelActive_Click(object sender, EventArgs e)
        {
    
            int activeRow = lstCows.SelectedIndex;
            lstCows.DataSource = null;
            dsCows.Tables[0].Rows.RemoveAt(activeRow);

            lstCows.DataSource = dsCows.Tables[0].DefaultView;
            lstCows.DisplayMember = "dcName";
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var newCow =new Cow{Name="New Cow"};
            lstCows.DataSource = null;

            DataRow dt;
            dt=dsCows.Tables[0].NewRow();
            dt["dcName"] = "New name";
            dsCows.Tables[0].Rows.Add(dt);
            int activeRow = dsCows.Tables[0].Rows.Count - 1;//(int)dt[dcID];
            //activeRow = dsCows.Tables[0].Rows.IndexOf(dsCows.Tables[0].AsEnumerable().Last());
            
            lstCows.DataSource = dsCows.Tables[0].DefaultView;
            lstCows.DisplayMember = "dcName";
            lstCows.SelectedIndex = activeRow;
            //BoundFormToActiveRow(activeRow);

        }

        private void gbxAddEditCow_Enter(object sender, EventArgs e)
        {

        }

        private void SerializeDataSet(string filename,DataSet ds)
        {
            XmlSerializer ser = new XmlSerializer(typeof(DataSet));
            TextWriter writer = new StreamWriter(@"D:\Dokumenty\PROJEKTY\OdRafa\OdRafa\db\cows.txt");//@Properties.Settings.Default.CowsPath
            ser.Serialize(writer,ds);
            writer.Close();
        }
        private void DeserializeDataSet(string filename, ref DataSet ds)
        {
            XmlSerializer ser = new XmlSerializer(typeof(DataSet));
            TextReader reader = new StreamReader(@"D:\Dokumenty\PROJEKTY\OdRafa\OdRafa\db\cows.txt");//@"D:\Dokumenty\PROJEKTY\OdRafa\OdRafa\db\cows.txt"
            //reader.ReadToEnd();

            ds=(DataSet)ser.Deserialize(reader);
            reader.Close();
        }

        private void BoundFormToActiveRow(int RowNoInDataTable) 
        {
            //changing position in context can trigger event SelectedIndexChanged
            //disable it to prevent neverending loop
            lstCows.SelectedIndexChanged -= lstCows_SelectedIndexChanged;
            foreach (Control ctrl in gbxAddEditCow.Controls)
            {
                if ((ctrl is TextBox) || (ctrl is ComboBox))
                {
                    ctrl.BindingContext[dsCows.Tables[0]].Position = RowNoInDataTable;
                    System.Diagnostics.Debug.WriteLine(ctrl.Name);
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
                    if ((ctrl is TextBox) || (ctrl is ComboBox))
                    {
                        ctrl.DataBindings.Add("Text", dsCows.Tables[0], "dc" + ctrl.Name.Substring(3));
                    }
                }
                _TextBoxesBoundedToDataSet=true;
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
