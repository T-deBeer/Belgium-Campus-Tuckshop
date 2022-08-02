namespace Belgium_Campus_Tuckshop
{
    partial class SalesScreen
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
            this.mbtnBack = new MetroSet_UI.Controls.MetroSetButton();
            this.mbtnNext = new MetroSet_UI.Controls.MetroSetButton();
            this.mbtnPay = new MetroSet_UI.Controls.MetroSetButton();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.mtbxCustomerName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblItems = new System.Windows.Forms.Label();
            this.lblReceipt = new System.Windows.Forms.Label();
            this.lblAmounPaid = new System.Windows.Forms.Label();
            this.mtbxAmountPaid = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPopular = new System.Windows.Forms.TabPage();
            this.ListBoxPopular = new MetroSet_UI.Controls.MetroSetListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ListBoxFood = new MetroSet_UI.Controls.MetroSetListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ListBoxColdDrinks = new MetroSet_UI.Controls.MetroSetListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ListBoxHotDrinks = new MetroSet_UI.Controls.MetroSetListBox();
            this.setNumeric = new System.Windows.Forms.NumericUpDown();
            this.lblNumSet = new MetroSet_UI.Controls.MetroSetLabel();
            this.mtxRingUp = new MetroSet_UI.Controls.MetroSetButton();
            this.ListBoxOutput = new MetroSet_UI.Controls.MetroSetListBox();
            this.tabControl1.SuspendLayout();
            this.tabPopular.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // mbtnBack
            // 
            this.mbtnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbtnBack.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mbtnBack.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mbtnBack.DisabledForeColor = System.Drawing.Color.Gray;
            this.mbtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mbtnBack.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.mbtnBack.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.mbtnBack.HoverTextColor = System.Drawing.Color.White;
            this.mbtnBack.IsDerivedStyle = true;
            this.mbtnBack.Location = new System.Drawing.Point(33, 650);
            this.mbtnBack.Name = "mbtnBack";
            this.mbtnBack.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.mbtnBack.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mbtnBack.NormalTextColor = System.Drawing.Color.White;
            this.mbtnBack.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.mbtnBack.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.mbtnBack.PressTextColor = System.Drawing.Color.White;
            this.mbtnBack.Size = new System.Drawing.Size(159, 53);
            this.mbtnBack.Style = MetroSet_UI.Enums.Style.Custom;
            this.mbtnBack.StyleManager = null;
            this.mbtnBack.TabIndex = 23;
            this.mbtnBack.Text = "Back To Menu";
            this.mbtnBack.ThemeAuthor = "Narwin";
            this.mbtnBack.ThemeName = "MetroDark";
            this.mbtnBack.Click += new System.EventHandler(this.mbtnBack_Click);
            // 
            // mbtnNext
            // 
            this.mbtnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbtnNext.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mbtnNext.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mbtnNext.DisabledForeColor = System.Drawing.Color.Gray;
            this.mbtnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mbtnNext.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.mbtnNext.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.mbtnNext.HoverTextColor = System.Drawing.Color.White;
            this.mbtnNext.IsDerivedStyle = true;
            this.mbtnNext.Location = new System.Drawing.Point(818, 650);
            this.mbtnNext.Name = "mbtnNext";
            this.mbtnNext.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mbtnNext.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mbtnNext.NormalTextColor = System.Drawing.Color.White;
            this.mbtnNext.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.mbtnNext.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.mbtnNext.PressTextColor = System.Drawing.Color.White;
            this.mbtnNext.Size = new System.Drawing.Size(159, 53);
            this.mbtnNext.Style = MetroSet_UI.Enums.Style.Custom;
            this.mbtnNext.StyleManager = null;
            this.mbtnNext.TabIndex = 22;
            this.mbtnNext.Text = "Next Transaction";
            this.mbtnNext.ThemeAuthor = "Narwin";
            this.mbtnNext.ThemeName = "MetroDark";
            this.mbtnNext.Click += new System.EventHandler(this.mbtnNext_Click);
            // 
            // mbtnPay
            // 
            this.mbtnPay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbtnPay.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mbtnPay.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mbtnPay.DisabledForeColor = System.Drawing.Color.Gray;
            this.mbtnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mbtnPay.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.mbtnPay.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.mbtnPay.HoverTextColor = System.Drawing.Color.White;
            this.mbtnPay.IsDerivedStyle = true;
            this.mbtnPay.Location = new System.Drawing.Point(623, 650);
            this.mbtnPay.Name = "mbtnPay";
            this.mbtnPay.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mbtnPay.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mbtnPay.NormalTextColor = System.Drawing.Color.White;
            this.mbtnPay.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.mbtnPay.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.mbtnPay.PressTextColor = System.Drawing.Color.White;
            this.mbtnPay.Size = new System.Drawing.Size(159, 53);
            this.mbtnPay.Style = MetroSet_UI.Enums.Style.Custom;
            this.mbtnPay.StyleManager = null;
            this.mbtnPay.TabIndex = 21;
            this.mbtnPay.Text = "Complete Transaction";
            this.mbtnPay.ThemeAuthor = "Narwin";
            this.mbtnPay.ThemeName = "MetroDark";
            this.mbtnPay.Click += new System.EventHandler(this.mbtnPay_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.lblCustomerName.Location = new System.Drawing.Point(20, 135);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(104, 16);
            this.lblCustomerName.TabIndex = 28;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // mtbxCustomerName
            // 
            this.mtbxCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbxCustomerName.AutoCompleteCustomSource = null;
            this.mtbxCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.mtbxCustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.mtbxCustomerName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.mtbxCustomerName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.mtbxCustomerName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbxCustomerName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbxCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtbxCustomerName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mtbxCustomerName.Image = null;
            this.mtbxCustomerName.IsDerivedStyle = true;
            this.mtbxCustomerName.Lines = null;
            this.mtbxCustomerName.Location = new System.Drawing.Point(20, 154);
            this.mtbxCustomerName.MaxLength = 32767;
            this.mtbxCustomerName.Multiline = false;
            this.mtbxCustomerName.Name = "mtbxCustomerName";
            this.mtbxCustomerName.ReadOnly = false;
            this.mtbxCustomerName.Size = new System.Drawing.Size(307, 33);
            this.mtbxCustomerName.Style = MetroSet_UI.Enums.Style.Dark;
            this.mtbxCustomerName.StyleManager = null;
            this.mtbxCustomerName.TabIndex = 27;
            this.mtbxCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtbxCustomerName.ThemeAuthor = "Narwin";
            this.mtbxCustomerName.ThemeName = "MetroDark";
            this.mtbxCustomerName.UseSystemPasswordChar = false;
            this.mtbxCustomerName.WatermarkText = "Enter Name to continue";
            this.mtbxCustomerName.Click += new System.EventHandler(this.mtbxCustomerName_Click);
            // 
            // lblItems
            // 
            this.lblItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblItems.AutoSize = true;
            this.lblItems.BackColor = System.Drawing.Color.Transparent;
            this.lblItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.lblItems.Location = new System.Drawing.Point(20, 217);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(80, 16);
            this.lblItems.TabIndex = 26;
            this.lblItems.Text = "Select Items";
            // 
            // lblReceipt
            // 
            this.lblReceipt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReceipt.AutoSize = true;
            this.lblReceipt.BackColor = System.Drawing.Color.Transparent;
            this.lblReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReceipt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.lblReceipt.Location = new System.Drawing.Point(478, 135);
            this.lblReceipt.Name = "lblReceipt";
            this.lblReceipt.Size = new System.Drawing.Size(54, 16);
            this.lblReceipt.TabIndex = 30;
            this.lblReceipt.Text = "Receipt";
            // 
            // lblAmounPaid
            // 
            this.lblAmounPaid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAmounPaid.AutoSize = true;
            this.lblAmounPaid.BackColor = System.Drawing.Color.Transparent;
            this.lblAmounPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAmounPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.lblAmounPaid.Location = new System.Drawing.Point(478, 381);
            this.lblAmounPaid.Name = "lblAmounPaid";
            this.lblAmounPaid.Size = new System.Drawing.Size(162, 16);
            this.lblAmounPaid.TabIndex = 32;
            this.lblAmounPaid.Text = "Amount Paid By Customer";
            // 
            // mtbxAmountPaid
            // 
            this.mtbxAmountPaid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbxAmountPaid.AutoCompleteCustomSource = null;
            this.mtbxAmountPaid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.mtbxAmountPaid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.mtbxAmountPaid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.mtbxAmountPaid.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.mtbxAmountPaid.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbxAmountPaid.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbxAmountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtbxAmountPaid.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mtbxAmountPaid.Image = null;
            this.mtbxAmountPaid.IsDerivedStyle = true;
            this.mtbxAmountPaid.Lines = null;
            this.mtbxAmountPaid.Location = new System.Drawing.Point(478, 400);
            this.mtbxAmountPaid.MaxLength = 32767;
            this.mtbxAmountPaid.Multiline = false;
            this.mtbxAmountPaid.Name = "mtbxAmountPaid";
            this.mtbxAmountPaid.ReadOnly = false;
            this.mtbxAmountPaid.Size = new System.Drawing.Size(408, 33);
            this.mtbxAmountPaid.Style = MetroSet_UI.Enums.Style.Dark;
            this.mtbxAmountPaid.StyleManager = null;
            this.mtbxAmountPaid.TabIndex = 31;
            this.mtbxAmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtbxAmountPaid.ThemeAuthor = "Narwin";
            this.mtbxAmountPaid.ThemeName = "MetroDark";
            this.mtbxAmountPaid.UseSystemPasswordChar = false;
            this.mtbxAmountPaid.WatermarkText = "100.00";
            this.mtbxAmountPaid.Click += new System.EventHandler(this.mtbxAmountPaid_Click);
            // 
            // lblChange
            // 
            this.lblChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblChange.AutoSize = true;
            this.lblChange.BackColor = System.Drawing.Color.Transparent;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblChange.Location = new System.Drawing.Point(478, 465);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(119, 16);
            this.lblChange.TabIndex = 33;
            this.lblChange.Text = "Change Required: ";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPopular);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(20, 236);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(307, 304);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPopular
            // 
            this.tabPopular.Controls.Add(this.ListBoxPopular);
            this.tabPopular.Location = new System.Drawing.Point(4, 27);
            this.tabPopular.Name = "tabPopular";
            this.tabPopular.Padding = new System.Windows.Forms.Padding(3);
            this.tabPopular.Size = new System.Drawing.Size(299, 273);
            this.tabPopular.TabIndex = 0;
            this.tabPopular.Text = "Popular";
            this.tabPopular.UseVisualStyleBackColor = true;
            // 
            // ListBoxPopular
            // 
            this.ListBoxPopular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ListBoxPopular.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ListBoxPopular.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ListBoxPopular.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ListBoxPopular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListBoxPopular.HoveredItemBackColor = System.Drawing.Color.LightGray;
            this.ListBoxPopular.HoveredItemColor = System.Drawing.Color.DimGray;
            this.ListBoxPopular.IsDerivedStyle = true;
            this.ListBoxPopular.ItemHeight = 30;
            this.ListBoxPopular.Location = new System.Drawing.Point(0, 0);
            this.ListBoxPopular.MultiSelect = false;
            this.ListBoxPopular.Name = "ListBoxPopular";
            this.ListBoxPopular.SelectedIndex = -1;
            this.ListBoxPopular.SelectedItem = null;
            this.ListBoxPopular.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ListBoxPopular.SelectedItemColor = System.Drawing.Color.White;
            this.ListBoxPopular.SelectedText = null;
            this.ListBoxPopular.SelectedValue = null;
            this.ListBoxPopular.ShowBorder = false;
            this.ListBoxPopular.ShowScrollBar = false;
            this.ListBoxPopular.Size = new System.Drawing.Size(299, 276);
            this.ListBoxPopular.Style = MetroSet_UI.Enums.Style.Dark;
            this.ListBoxPopular.StyleManager = null;
            this.ListBoxPopular.TabIndex = 0;
            this.ListBoxPopular.ThemeAuthor = "Narwin";
            this.ListBoxPopular.ThemeName = "MetroDark";
            this.ListBoxPopular.SelectedIndexChanged += new MetroSet_UI.Controls.MetroSetListBox.SelectedIndexChangedEventHandler(this.metroSetListBox1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ListBoxFood);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(299, 273);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Food";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ListBoxFood
            // 
            this.ListBoxFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ListBoxFood.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ListBoxFood.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ListBoxFood.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ListBoxFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListBoxFood.HoveredItemBackColor = System.Drawing.Color.LightGray;
            this.ListBoxFood.HoveredItemColor = System.Drawing.Color.DimGray;
            this.ListBoxFood.IsDerivedStyle = true;
            this.ListBoxFood.ItemHeight = 30;
            this.ListBoxFood.Location = new System.Drawing.Point(0, -2);
            this.ListBoxFood.MultiSelect = false;
            this.ListBoxFood.Name = "ListBoxFood";
            this.ListBoxFood.SelectedIndex = -1;
            this.ListBoxFood.SelectedItem = null;
            this.ListBoxFood.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ListBoxFood.SelectedItemColor = System.Drawing.Color.White;
            this.ListBoxFood.SelectedText = null;
            this.ListBoxFood.SelectedValue = null;
            this.ListBoxFood.ShowBorder = false;
            this.ListBoxFood.ShowScrollBar = false;
            this.ListBoxFood.Size = new System.Drawing.Size(299, 276);
            this.ListBoxFood.Style = MetroSet_UI.Enums.Style.Dark;
            this.ListBoxFood.StyleManager = null;
            this.ListBoxFood.TabIndex = 1;
            this.ListBoxFood.ThemeAuthor = "Narwin";
            this.ListBoxFood.ThemeName = "MetroDark";
            this.ListBoxFood.SelectedIndexChanged += new MetroSet_UI.Controls.MetroSetListBox.SelectedIndexChangedEventHandler(this.ListBoxFood_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ListBoxColdDrinks);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(299, 273);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cold Drinks";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ListBoxColdDrinks
            // 
            this.ListBoxColdDrinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ListBoxColdDrinks.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ListBoxColdDrinks.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ListBoxColdDrinks.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ListBoxColdDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListBoxColdDrinks.HoveredItemBackColor = System.Drawing.Color.LightGray;
            this.ListBoxColdDrinks.HoveredItemColor = System.Drawing.Color.DimGray;
            this.ListBoxColdDrinks.IsDerivedStyle = true;
            this.ListBoxColdDrinks.ItemHeight = 30;
            this.ListBoxColdDrinks.Location = new System.Drawing.Point(0, -5);
            this.ListBoxColdDrinks.MultiSelect = false;
            this.ListBoxColdDrinks.Name = "ListBoxColdDrinks";
            this.ListBoxColdDrinks.SelectedIndex = -1;
            this.ListBoxColdDrinks.SelectedItem = null;
            this.ListBoxColdDrinks.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ListBoxColdDrinks.SelectedItemColor = System.Drawing.Color.White;
            this.ListBoxColdDrinks.SelectedText = null;
            this.ListBoxColdDrinks.SelectedValue = null;
            this.ListBoxColdDrinks.ShowBorder = false;
            this.ListBoxColdDrinks.ShowScrollBar = false;
            this.ListBoxColdDrinks.Size = new System.Drawing.Size(299, 276);
            this.ListBoxColdDrinks.Style = MetroSet_UI.Enums.Style.Dark;
            this.ListBoxColdDrinks.StyleManager = null;
            this.ListBoxColdDrinks.TabIndex = 2;
            this.ListBoxColdDrinks.ThemeAuthor = "Narwin";
            this.ListBoxColdDrinks.ThemeName = "MetroDark";
            this.ListBoxColdDrinks.SelectedIndexChanged += new MetroSet_UI.Controls.MetroSetListBox.SelectedIndexChangedEventHandler(this.ListBoxColdDrinks_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ListBoxHotDrinks);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(299, 273);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Hot Drinks";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ListBoxHotDrinks
            // 
            this.ListBoxHotDrinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ListBoxHotDrinks.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ListBoxHotDrinks.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ListBoxHotDrinks.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ListBoxHotDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListBoxHotDrinks.HoveredItemBackColor = System.Drawing.Color.LightGray;
            this.ListBoxHotDrinks.HoveredItemColor = System.Drawing.Color.DimGray;
            this.ListBoxHotDrinks.IsDerivedStyle = true;
            this.ListBoxHotDrinks.ItemHeight = 30;
            this.ListBoxHotDrinks.Location = new System.Drawing.Point(0, -5);
            this.ListBoxHotDrinks.MultiSelect = false;
            this.ListBoxHotDrinks.Name = "ListBoxHotDrinks";
            this.ListBoxHotDrinks.SelectedIndex = -1;
            this.ListBoxHotDrinks.SelectedItem = null;
            this.ListBoxHotDrinks.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ListBoxHotDrinks.SelectedItemColor = System.Drawing.Color.White;
            this.ListBoxHotDrinks.SelectedText = null;
            this.ListBoxHotDrinks.SelectedValue = null;
            this.ListBoxHotDrinks.ShowBorder = false;
            this.ListBoxHotDrinks.ShowScrollBar = false;
            this.ListBoxHotDrinks.Size = new System.Drawing.Size(303, 276);
            this.ListBoxHotDrinks.Style = MetroSet_UI.Enums.Style.Dark;
            this.ListBoxHotDrinks.StyleManager = null;
            this.ListBoxHotDrinks.TabIndex = 3;
            this.ListBoxHotDrinks.ThemeAuthor = "Narwin";
            this.ListBoxHotDrinks.ThemeName = "MetroDark";
            this.ListBoxHotDrinks.SelectedIndexChanged += new MetroSet_UI.Controls.MetroSetListBox.SelectedIndexChangedEventHandler(this.ListBoxHotDrinks_SelectedIndexChanged);
            // 
            // setNumeric
            // 
            this.setNumeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.setNumeric.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.setNumeric.Location = new System.Drawing.Point(138, 566);
            this.setNumeric.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.setNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.setNumeric.Name = "setNumeric";
            this.setNumeric.Size = new System.Drawing.Size(120, 27);
            this.setNumeric.TabIndex = 35;
            this.setNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNumSet
            // 
            this.lblNumSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumSet.IsDerivedStyle = true;
            this.lblNumSet.Location = new System.Drawing.Point(20, 570);
            this.lblNumSet.Name = "lblNumSet";
            this.lblNumSet.Size = new System.Drawing.Size(100, 23);
            this.lblNumSet.Style = MetroSet_UI.Enums.Style.Light;
            this.lblNumSet.StyleManager = null;
            this.lblNumSet.TabIndex = 36;
            this.lblNumSet.Text = "Quantity";
            this.lblNumSet.ThemeAuthor = "Narwin";
            this.lblNumSet.ThemeName = "MetroLite";
            this.lblNumSet.Click += new System.EventHandler(this.metroSetLabel1_Click);
            // 
            // mtxRingUp
            // 
            this.mtxRingUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxRingUp.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mtxRingUp.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mtxRingUp.DisabledForeColor = System.Drawing.Color.Gray;
            this.mtxRingUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxRingUp.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.mtxRingUp.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.mtxRingUp.HoverTextColor = System.Drawing.Color.White;
            this.mtxRingUp.IsDerivedStyle = true;
            this.mtxRingUp.Location = new System.Drawing.Point(434, 650);
            this.mtxRingUp.Name = "mtxRingUp";
            this.mtxRingUp.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mtxRingUp.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mtxRingUp.NormalTextColor = System.Drawing.Color.White;
            this.mtxRingUp.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.mtxRingUp.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.mtxRingUp.PressTextColor = System.Drawing.Color.White;
            this.mtxRingUp.Size = new System.Drawing.Size(159, 53);
            this.mtxRingUp.Style = MetroSet_UI.Enums.Style.Custom;
            this.mtxRingUp.StyleManager = null;
            this.mtxRingUp.TabIndex = 37;
            this.mtxRingUp.Text = "Ring Up ";
            this.mtxRingUp.ThemeAuthor = "Narwin";
            this.mtxRingUp.ThemeName = "MetroDark";
            this.mtxRingUp.Click += new System.EventHandler(this.metroSetButton1_Click);
            // 
            // ListBoxOutput
            // 
            this.ListBoxOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ListBoxOutput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ListBoxOutput.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ListBoxOutput.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ListBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListBoxOutput.HoveredItemBackColor = System.Drawing.Color.LightGray;
            this.ListBoxOutput.HoveredItemColor = System.Drawing.Color.DimGray;
            this.ListBoxOutput.IsDerivedStyle = true;
            this.ListBoxOutput.ItemHeight = 30;
            this.ListBoxOutput.Location = new System.Drawing.Point(478, 157);
            this.ListBoxOutput.MultiSelect = false;
            this.ListBoxOutput.Name = "ListBoxOutput";
            this.ListBoxOutput.SelectedIndex = -1;
            this.ListBoxOutput.SelectedItem = null;
            this.ListBoxOutput.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ListBoxOutput.SelectedItemColor = System.Drawing.Color.White;
            this.ListBoxOutput.SelectedText = null;
            this.ListBoxOutput.SelectedValue = null;
            this.ListBoxOutput.ShowBorder = false;
            this.ListBoxOutput.ShowScrollBar = false;
            this.ListBoxOutput.Size = new System.Drawing.Size(408, 207);
            this.ListBoxOutput.Style = MetroSet_UI.Enums.Style.Dark;
            this.ListBoxOutput.StyleManager = null;
            this.ListBoxOutput.TabIndex = 38;
            this.ListBoxOutput.ThemeAuthor = "Narwin";
            this.ListBoxOutput.ThemeName = "MetroDark";
            // 
            // SalesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1014, 718);
            this.Controls.Add(this.ListBoxOutput);
            this.Controls.Add(this.mtxRingUp);
            this.Controls.Add(this.lblNumSet);
            this.Controls.Add(this.setNumeric);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblAmounPaid);
            this.Controls.Add(this.mtbxAmountPaid);
            this.Controls.Add(this.lblReceipt);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.mtbxCustomerName);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.mbtnBack);
            this.Controls.Add(this.mbtnNext);
            this.Controls.Add(this.mbtnPay);
            this.Name = "SalesScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.Text = "SALES MENU";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.Load += new System.EventHandler(this.SalesScreen_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPopular.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.setNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetButton mbtnBack;
        private MetroSet_UI.Controls.MetroSetButton mbtnNext;
        private MetroSet_UI.Controls.MetroSetButton mbtnPay;
        private Label lblCustomerName;
        private MetroSet_UI.Controls.MetroSetTextBox mtbxCustomerName;
        private Label lblItems;
        private Label lblReceipt;
        private Label lblAmounPaid;
        private MetroSet_UI.Controls.MetroSetTextBox mtbxAmountPaid;
        private Label lblChange;
        private TabControl tabControl1;
        private TabPage tabPopular;
        private MetroSet_UI.Controls.MetroSetListBox ListBoxPopular;
        private TabPage tabPage2;
        private MetroSet_UI.Controls.MetroSetListBox ListBoxFood;
        private TabPage tabPage3;
        private MetroSet_UI.Controls.MetroSetListBox ListBoxColdDrinks;
        private TabPage tabPage4;
        private MetroSet_UI.Controls.MetroSetListBox ListBoxHotDrinks;
        private NumericUpDown setNumeric;
        private MetroSet_UI.Controls.MetroSetLabel lblNumSet;
        private MetroSet_UI.Controls.MetroSetButton mtxRingUp;
        private MetroSet_UI.Controls.MetroSetListBox ListBoxOutput;
    }
}