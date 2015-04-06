namespace Farm
{
    partial class FromBarn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromBarn));
            this.BtnShowHayPrice = new System.Windows.Forms.Button();
            this.LblShowPrice = new System.Windows.Forms.Label();
            this.tabFarm = new System.Windows.Forms.TabControl();
            this.tabBarn = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabStable = new System.Windows.Forms.TabPage();
            this.tabCowshed = new System.Windows.Forms.TabPage();
            this.gbxCowStatistics = new System.Windows.Forms.GroupBox();
            this.lblMilkPricePerDay = new System.Windows.Forms.Label();
            this.txtTotalMeetPrice = new System.Windows.Forms.TextBox();
            this.lblTotalMeetPrice = new System.Windows.Forms.Label();
            this.txtMilkPricePerDay = new System.Windows.Forms.TextBox();
            this.gbxCows = new System.Windows.Forms.GroupBox();
            this.lblMilkPricePerLiter = new System.Windows.Forms.Label();
            this.txtMilkPricePerLiter = new System.Windows.Forms.TextBox();
            this.lblMeetPricePerKg = new System.Windows.Forms.Label();
            this.txtMeetPricePerKg = new System.Windows.Forms.TextBox();
            this.gbxAddEditCow = new System.Windows.Forms.GroupBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblMilkPerDay = new System.Windows.Forms.Label();
            this.txtMilkPerDay = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.cmbRace = new System.Windows.Forms.ComboBox();
            this.lblRace = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDelActive = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.lstCows = new System.Windows.Forms.ListBox();
            this.dsCows = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dcID = new System.Data.DataColumn();
            this.dcName = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.tabFarm.SuspendLayout();
            this.tabBarn.SuspendLayout();
            this.tabStable.SuspendLayout();
            this.tabCowshed.SuspendLayout();
            this.gbxCowStatistics.SuspendLayout();
            this.gbxCows.SuspendLayout();
            this.gbxAddEditCow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnShowHayPrice
            // 
            this.BtnShowHayPrice.Location = new System.Drawing.Point(-4, 0);
            this.BtnShowHayPrice.Name = "BtnShowHayPrice";
            this.BtnShowHayPrice.Size = new System.Drawing.Size(75, 23);
            this.BtnShowHayPrice.TabIndex = 0;
            this.BtnShowHayPrice.Text = "showPrice";
            this.BtnShowHayPrice.UseVisualStyleBackColor = true;
            this.BtnShowHayPrice.Click += new System.EventHandler(this.BtnShowHayPrice_Click);
            // 
            // LblShowPrice
            // 
            this.LblShowPrice.AutoSize = true;
            this.LblShowPrice.Location = new System.Drawing.Point(6, 26);
            this.LblShowPrice.Name = "LblShowPrice";
            this.LblShowPrice.Size = new System.Drawing.Size(137, 13);
            this.LblShowPrice.TabIndex = 1;
            this.LblShowPrice.Text = "Here will be showed price...";
            // 
            // tabFarm
            // 
            this.tabFarm.Controls.Add(this.tabBarn);
            this.tabFarm.Controls.Add(this.tabStable);
            this.tabFarm.Controls.Add(this.tabCowshed);
            this.tabFarm.Location = new System.Drawing.Point(1, 1);
            this.tabFarm.Name = "tabFarm";
            this.tabFarm.SelectedIndex = 0;
            this.tabFarm.Size = new System.Drawing.Size(721, 447);
            this.tabFarm.TabIndex = 3;
            // 
            // tabBarn
            // 
            this.tabBarn.Controls.Add(this.textBox1);
            this.tabBarn.Location = new System.Drawing.Point(4, 22);
            this.tabBarn.Name = "tabBarn";
            this.tabBarn.Padding = new System.Windows.Forms.Padding(3);
            this.tabBarn.Size = new System.Drawing.Size(713, 421);
            this.tabBarn.TabIndex = 0;
            this.tabBarn.Text = "Barn";
            this.tabBarn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(13, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(685, 310);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // tabStable
            // 
            this.tabStable.Controls.Add(this.BtnShowHayPrice);
            this.tabStable.Controls.Add(this.LblShowPrice);
            this.tabStable.Location = new System.Drawing.Point(4, 22);
            this.tabStable.Name = "tabStable";
            this.tabStable.Padding = new System.Windows.Forms.Padding(3);
            this.tabStable.Size = new System.Drawing.Size(713, 421);
            this.tabStable.TabIndex = 1;
            this.tabStable.Text = "Stable";
            this.tabStable.UseVisualStyleBackColor = true;
            // 
            // tabCowshed
            // 
            this.tabCowshed.Controls.Add(this.gbxCowStatistics);
            this.tabCowshed.Controls.Add(this.gbxCows);
            this.tabCowshed.Controls.Add(this.gbxAddEditCow);
            this.tabCowshed.Controls.Add(this.btnDelActive);
            this.tabCowshed.Controls.Add(this.btnAddNew);
            this.tabCowshed.Controls.Add(this.lstCows);
            this.tabCowshed.Location = new System.Drawing.Point(4, 22);
            this.tabCowshed.Name = "tabCowshed";
            this.tabCowshed.Padding = new System.Windows.Forms.Padding(3);
            this.tabCowshed.Size = new System.Drawing.Size(713, 421);
            this.tabCowshed.TabIndex = 2;
            this.tabCowshed.Text = "cowshed";
            this.tabCowshed.UseVisualStyleBackColor = true;
            // 
            // gbxCowStatistics
            // 
            this.gbxCowStatistics.Controls.Add(this.lblMilkPricePerDay);
            this.gbxCowStatistics.Controls.Add(this.txtTotalMeetPrice);
            this.gbxCowStatistics.Controls.Add(this.lblTotalMeetPrice);
            this.gbxCowStatistics.Controls.Add(this.txtMilkPricePerDay);
            this.gbxCowStatistics.Location = new System.Drawing.Point(170, 277);
            this.gbxCowStatistics.Name = "gbxCowStatistics";
            this.gbxCowStatistics.Size = new System.Drawing.Size(270, 85);
            this.gbxCowStatistics.TabIndex = 5;
            this.gbxCowStatistics.TabStop = false;
            this.gbxCowStatistics.Text = "Cow Statistics";
            // 
            // lblMilkPricePerDay
            // 
            this.lblMilkPricePerDay.AutoSize = true;
            this.lblMilkPricePerDay.Location = new System.Drawing.Point(6, 48);
            this.lblMilkPricePerDay.Name = "lblMilkPricePerDay";
            this.lblMilkPricePerDay.Size = new System.Drawing.Size(83, 13);
            this.lblMilkPricePerDay.TabIndex = 20;
            this.lblMilkPricePerDay.Text = "Milk value / day";
            // 
            // txtTotalMeetPrice
            // 
            this.txtTotalMeetPrice.Location = new System.Drawing.Point(107, 19);
            this.txtTotalMeetPrice.Name = "txtTotalMeetPrice";
            this.txtTotalMeetPrice.ReadOnly = true;
            this.txtTotalMeetPrice.Size = new System.Drawing.Size(147, 20);
            this.txtTotalMeetPrice.TabIndex = 17;
            // 
            // lblTotalMeetPrice
            // 
            this.lblTotalMeetPrice.AutoSize = true;
            this.lblTotalMeetPrice.Location = new System.Drawing.Point(6, 22);
            this.lblTotalMeetPrice.Name = "lblTotalMeetPrice";
            this.lblTotalMeetPrice.Size = new System.Drawing.Size(57, 13);
            this.lblTotalMeetPrice.TabIndex = 19;
            this.lblTotalMeetPrice.Text = "Cow value";
            // 
            // txtMilkPricePerDay
            // 
            this.txtMilkPricePerDay.Location = new System.Drawing.Point(107, 45);
            this.txtMilkPricePerDay.Name = "txtMilkPricePerDay";
            this.txtMilkPricePerDay.ReadOnly = true;
            this.txtMilkPricePerDay.Size = new System.Drawing.Size(147, 20);
            this.txtMilkPricePerDay.TabIndex = 18;
            // 
            // gbxCows
            // 
            this.gbxCows.Controls.Add(this.lblMilkPricePerLiter);
            this.gbxCows.Controls.Add(this.txtMilkPricePerLiter);
            this.gbxCows.Controls.Add(this.lblMeetPricePerKg);
            this.gbxCows.Controls.Add(this.txtMeetPricePerKg);
            this.gbxCows.Location = new System.Drawing.Point(447, 16);
            this.gbxCows.Name = "gbxCows";
            this.gbxCows.Size = new System.Drawing.Size(243, 347);
            this.gbxCows.TabIndex = 4;
            this.gbxCows.TabStop = false;
            this.gbxCows.Text = "Cows";
            // 
            // lblMilkPricePerLiter
            // 
            this.lblMilkPricePerLiter.AutoSize = true;
            this.lblMilkPricePerLiter.Location = new System.Drawing.Point(6, 67);
            this.lblMilkPricePerLiter.Name = "lblMilkPricePerLiter";
            this.lblMilkPricePerLiter.Size = new System.Drawing.Size(69, 13);
            this.lblMilkPricePerLiter.TabIndex = 10;
            this.lblMilkPricePerLiter.Text = "Milk price [1l]";
            // 
            // txtMilkPricePerLiter
            // 
            this.txtMilkPricePerLiter.Location = new System.Drawing.Point(110, 64);
            this.txtMilkPricePerLiter.Name = "txtMilkPricePerLiter";
            this.txtMilkPricePerLiter.Size = new System.Drawing.Size(108, 20);
            this.txtMilkPricePerLiter.TabIndex = 9;
            // 
            // lblMeetPricePerKg
            // 
            this.lblMeetPricePerKg.AutoSize = true;
            this.lblMeetPricePerKg.Location = new System.Drawing.Point(6, 44);
            this.lblMeetPricePerKg.Name = "lblMeetPricePerKg";
            this.lblMeetPricePerKg.Size = new System.Drawing.Size(84, 13);
            this.lblMeetPricePerKg.TabIndex = 8;
            this.lblMeetPricePerKg.Text = "Meet price [1kg]";
            // 
            // txtMeetPricePerKg
            // 
            this.txtMeetPricePerKg.Location = new System.Drawing.Point(110, 41);
            this.txtMeetPricePerKg.Name = "txtMeetPricePerKg";
            this.txtMeetPricePerKg.Size = new System.Drawing.Size(108, 20);
            this.txtMeetPricePerKg.TabIndex = 7;
            // 
            // gbxAddEditCow
            // 
            this.gbxAddEditCow.Controls.Add(this.dtpBirthDate);
            this.gbxAddEditCow.Controls.Add(this.lblMilkPerDay);
            this.gbxAddEditCow.Controls.Add(this.txtMilkPerDay);
            this.gbxAddEditCow.Controls.Add(this.lblWeight);
            this.gbxAddEditCow.Controls.Add(this.cmbRace);
            this.gbxAddEditCow.Controls.Add(this.lblRace);
            this.gbxAddEditCow.Controls.Add(this.lblType);
            this.gbxAddEditCow.Controls.Add(this.cmbType);
            this.gbxAddEditCow.Controls.Add(this.cmbSex);
            this.gbxAddEditCow.Controls.Add(this.label2);
            this.gbxAddEditCow.Controls.Add(this.lblBirthDate);
            this.gbxAddEditCow.Controls.Add(this.lblName);
            this.gbxAddEditCow.Controls.Add(this.label1);
            this.gbxAddEditCow.Controls.Add(this.txtWeight);
            this.gbxAddEditCow.Controls.Add(this.txtName);
            this.gbxAddEditCow.Location = new System.Drawing.Point(170, 16);
            this.gbxAddEditCow.Name = "gbxAddEditCow";
            this.gbxAddEditCow.Size = new System.Drawing.Size(271, 255);
            this.gbxAddEditCow.TabIndex = 3;
            this.gbxAddEditCow.TabStop = false;
            this.gbxAddEditCow.Text = "EditCow";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(107, 67);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(147, 20);
            this.dtpBirthDate.TabIndex = 1;
            // 
            // lblMilkPerDay
            // 
            this.lblMilkPerDay.AutoSize = true;
            this.lblMilkPerDay.Location = new System.Drawing.Point(6, 201);
            this.lblMilkPerDay.Name = "lblMilkPerDay";
            this.lblMilkPerDay.Size = new System.Drawing.Size(64, 13);
            this.lblMilkPerDay.TabIndex = 16;
            this.lblMilkPerDay.Text = "Milk per day";
            // 
            // txtMilkPerDay
            // 
            this.txtMilkPerDay.Location = new System.Drawing.Point(107, 198);
            this.txtMilkPerDay.Name = "txtMilkPerDay";
            this.txtMilkPerDay.Size = new System.Drawing.Size(147, 20);
            this.txtMilkPerDay.TabIndex = 6;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(6, 175);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(41, 13);
            this.lblWeight.TabIndex = 14;
            this.lblWeight.Text = "Weight";
            // 
            // cmbRace
            // 
            this.cmbRace.FormattingEnabled = true;
            this.cmbRace.Location = new System.Drawing.Point(107, 145);
            this.cmbRace.Name = "cmbRace";
            this.cmbRace.Size = new System.Drawing.Size(147, 21);
            this.cmbRace.TabIndex = 4;
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Location = new System.Drawing.Point(6, 148);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(33, 13);
            this.lblRace.TabIndex = 12;
            this.lblRace.Text = "Race";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(6, 122);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 11;
            this.lblType.Text = "Type";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(107, 119);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(147, 21);
            this.cmbType.TabIndex = 3;
            // 
            // cmbSex
            // 
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Location = new System.Drawing.Point(107, 93);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(147, 21);
            this.cmbSex.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sex";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(6, 71);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(52, 13);
            this.lblBirthDate.TabIndex = 7;
            this.lblBirthDate.Text = "Birth date";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(107, 172);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(147, 20);
            this.txtWeight.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(107, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(147, 20);
            this.txtName.TabIndex = 0;
            // 
            // btnDelActive
            // 
            this.btnDelActive.Location = new System.Drawing.Point(17, 340);
            this.btnDelActive.Name = "btnDelActive";
            this.btnDelActive.Size = new System.Drawing.Size(133, 23);
            this.btnDelActive.TabIndex = 2;
            this.btnDelActive.Text = "Delete Active";
            this.btnDelActive.UseVisualStyleBackColor = true;
            this.btnDelActive.Click += new System.EventHandler(this.btnDelActive_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(17, 311);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(133, 23);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "Add new";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // lstCows
            // 
            this.lstCows.DataBindings.Add(new System.Windows.Forms.Binding("SelectedIndex", this.dsCows, "tblCows.dcName", true));
            this.lstCows.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.dsCows, "tblCows.dcName", true));
            this.lstCows.DataSource = this.dsCows;
            this.lstCows.DisplayMember = "tblCows.dcID";
            this.lstCows.FormattingEnabled = true;
            this.lstCows.Location = new System.Drawing.Point(17, 15);
            this.lstCows.Name = "lstCows";
            this.lstCows.Size = new System.Drawing.Size(133, 290);
            this.lstCows.TabIndex = 0;
            this.lstCows.ValueMember = "tblCows.dcID";
            this.lstCows.SelectedIndexChanged += new System.EventHandler(this.lstCows_SelectedIndexChanged);
            // 
            // dsCows
            // 
            this.dsCows.DataSetName = "NewDataSet";
            this.dsCows.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dcID,
            this.dcName,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7});
            this.dataTable1.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "dcID"}, true)});
            this.dataTable1.PrimaryKey = new System.Data.DataColumn[] {
        this.dcID};
            this.dataTable1.TableName = "tblCows";
            // 
            // dcID
            // 
            this.dcID.AllowDBNull = false;
            this.dcID.AutoIncrement = true;
            this.dcID.ColumnName = "dcID";
            this.dcID.DataType = typeof(int);
            // 
            // dcName
            // 
            this.dcName.AllowDBNull = false;
            this.dcName.ColumnName = "dcName";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "dcBirthDate";
            this.dataColumn2.DataType = typeof(System.DateTime);
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "dcSex";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "dcType";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "dcRace";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "dcWeight";
            this.dataColumn6.DataType = typeof(double);
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "dcMilkPerDay";
            this.dataColumn7.DataType = typeof(double);
            // 
            // FromBarn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 449);
            this.Controls.Add(this.tabFarm);
            this.Name = "FromBarn";
            this.Text = "Farm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FromBarn_FormClosed);
            this.Load += new System.EventHandler(this.FromBarn_Load);
            this.tabFarm.ResumeLayout(false);
            this.tabBarn.ResumeLayout(false);
            this.tabBarn.PerformLayout();
            this.tabStable.ResumeLayout(false);
            this.tabStable.PerformLayout();
            this.tabCowshed.ResumeLayout(false);
            this.gbxCowStatistics.ResumeLayout(false);
            this.gbxCowStatistics.PerformLayout();
            this.gbxCows.ResumeLayout(false);
            this.gbxCows.PerformLayout();
            this.gbxAddEditCow.ResumeLayout(false);
            this.gbxAddEditCow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnShowHayPrice;
        private System.Windows.Forms.Label LblShowPrice;
        private System.Windows.Forms.TabControl tabFarm;
        private System.Windows.Forms.TabPage tabBarn;
        private System.Windows.Forms.TabPage tabStable;
        private System.Windows.Forms.TabPage tabCowshed;
        private System.Windows.Forms.Button btnDelActive;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.ListBox lstCows;
        private System.Windows.Forms.GroupBox gbxAddEditCow;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.ComboBox cmbRace;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblMilkPerDay;
        private System.Windows.Forms.TextBox txtMilkPerDay;
        private System.Data.DataSet dsCows;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dcID;
        private System.Data.DataColumn dcName;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.GroupBox gbxCows;
        private System.Windows.Forms.Label lblMilkPricePerLiter;
        private System.Windows.Forms.TextBox txtMilkPricePerLiter;
        private System.Windows.Forms.Label lblMeetPricePerKg;
        private System.Windows.Forms.TextBox txtMeetPricePerKg;
        private System.Windows.Forms.Label lblMilkPricePerDay;
        private System.Windows.Forms.TextBox txtMilkPricePerDay;
        private System.Windows.Forms.Label lblTotalMeetPrice;
        private System.Windows.Forms.TextBox txtTotalMeetPrice;
        private System.Windows.Forms.GroupBox gbxCowStatistics;
    }
}

