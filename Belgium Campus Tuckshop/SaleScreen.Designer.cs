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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesScreen));
            this.mbtnRemove = new MetroSet_UI.Controls.MetroSetButton();
            this.mbtnBack = new MetroSet_UI.Controls.MetroSetButton();
            this.mbtnNext = new MetroSet_UI.Controls.MetroSetButton();
            this.mbtnPay = new MetroSet_UI.Controls.MetroSetButton();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.mtbxCustomerName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblItems = new System.Windows.Forms.Label();
            this.lbxItemList = new System.Windows.Forms.ListBox();
            this.rtbxReceipt = new MetroSet_UI.Controls.MetroSetRichTextBox();
            this.lblReceipt = new System.Windows.Forms.Label();
            this.lblAmounPaid = new System.Windows.Forms.Label();
            this.mtbxAmountPaid = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.metroSetTabControl1 = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tpPopularItems = new System.Windows.Forms.TabPage();
            this.tpFood = new System.Windows.Forms.TabPage();
            this.tpColdDrinks = new System.Windows.Forms.TabPage();
            this.tpHotDrinks = new System.Windows.Forms.TabPage();
            this.metroSetTabControl1.SuspendLayout();
            this.tpPopularItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // mbtnRemove
            // 
            this.mbtnRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbtnRemove.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mbtnRemove.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mbtnRemove.DisabledForeColor = System.Drawing.Color.Gray;
            this.mbtnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mbtnRemove.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.mbtnRemove.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.mbtnRemove.HoverTextColor = System.Drawing.Color.White;
            this.mbtnRemove.IsDerivedStyle = true;
            this.mbtnRemove.Location = new System.Drawing.Point(207, 650);
            this.mbtnRemove.Name = "mbtnRemove";
            this.mbtnRemove.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.mbtnRemove.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mbtnRemove.NormalTextColor = System.Drawing.Color.White;
            this.mbtnRemove.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.mbtnRemove.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.mbtnRemove.PressTextColor = System.Drawing.Color.White;
            this.mbtnRemove.Size = new System.Drawing.Size(159, 53);
            this.mbtnRemove.Style = MetroSet_UI.Enums.Style.Custom;
            this.mbtnRemove.StyleManager = null;
            this.mbtnRemove.TabIndex = 24;
            this.mbtnRemove.Text = "Remove Item From";
            this.mbtnRemove.ThemeAuthor = "Narwin";
            this.mbtnRemove.ThemeName = "MetroDark";
            // 
            // mbtnBack
            // 
            this.mbtnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbtnBack.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mbtnBack.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mbtnBack.DisabledForeColor = System.Drawing.Color.Gray;
            this.mbtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mbtnBack.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.mbtnBack.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.mbtnBack.HoverTextColor = System.Drawing.Color.White;
            this.mbtnBack.IsDerivedStyle = true;
            this.mbtnBack.Location = new System.Drawing.Point(20, 650);
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
            this.mbtnNext.Location = new System.Drawing.Point(727, 650);
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
            this.mbtnPay.Location = new System.Drawing.Point(478, 650);
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
            this.mtbxCustomerName.WatermarkText = "Customer Name";
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
            // lbxItemList
            // 
            this.lbxItemList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lbxItemList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxItemList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxItemList.ForeColor = System.Drawing.Color.White;
            this.lbxItemList.FormattingEnabled = true;
            this.lbxItemList.ItemHeight = 16;
            this.lbxItemList.Items.AddRange(new object[] {
            "Tramazini",
            "Toasted Cheese",
            "Toasted Chicken Mayo",
            "Buddy Coke",
            "Buddy Cream Soda ",
            "Bar-One"});
            this.lbxItemList.Location = new System.Drawing.Point(0, 0);
            this.lbxItemList.Name = "lbxItemList";
            this.lbxItemList.Size = new System.Drawing.Size(299, 301);
            this.lbxItemList.TabIndex = 25;
            // 
            // rtbxReceipt
            // 
            this.rtbxReceipt.AutoWordSelection = false;
            this.rtbxReceipt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.rtbxReceipt.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.rtbxReceipt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.rtbxReceipt.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.rtbxReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbxReceipt.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.rtbxReceipt.IsDerivedStyle = true;
            this.rtbxReceipt.Lines = new string[] {
        "ITEM NAME\tBASE PRICE\tQTY\tPRICE",
        "---------------------------------------------------------------",
        "Tramazini\t\tR 28.00\t\t2\tR 56.00",
        "Bar-One\t\tR 11.99\t\t2\tR 23.80",
        "Buddy Coke\t\tR 9.80\t\t1\tR 9.80",
        "Buddy Cream Soda\tR 9.80\t\t1\tR 9.80",
        "---------------------------------------------------------------",
        "TOTAL\t\tR 99.40",
        "VAT\t\tR 14.91 "};
            this.rtbxReceipt.Location = new System.Drawing.Point(478, 154);
            this.rtbxReceipt.MaxLength = 32767;
            this.rtbxReceipt.Name = "rtbxReceipt";
            this.rtbxReceipt.ReadOnly = true;
            this.rtbxReceipt.Size = new System.Drawing.Size(408, 210);
            this.rtbxReceipt.Style = MetroSet_UI.Enums.Style.Custom;
            this.rtbxReceipt.StyleManager = null;
            this.rtbxReceipt.TabIndex = 29;
            this.rtbxReceipt.Text = resources.GetString("rtbxReceipt.Text");
            this.rtbxReceipt.ThemeAuthor = "Narwin";
            this.rtbxReceipt.ThemeName = "MetroDark";
            this.rtbxReceipt.WordWrap = true;
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
            this.lblChange.Size = new System.Drawing.Size(156, 16);
            this.lblChange.TabIndex = 33;
            this.lblChange.Text = "Change Required: R 0.60";
            // 
            // metroSetTabControl1
            // 
            this.metroSetTabControl1.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.metroSetTabControl1.AnimateTime = 200;
            this.metroSetTabControl1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetTabControl1.Controls.Add(this.tpPopularItems);
            this.metroSetTabControl1.Controls.Add(this.tpFood);
            this.metroSetTabControl1.Controls.Add(this.tpColdDrinks);
            this.metroSetTabControl1.Controls.Add(this.tpHotDrinks);
            this.metroSetTabControl1.IsDerivedStyle = true;
            this.metroSetTabControl1.ItemSize = new System.Drawing.Size(100, 38);
            this.metroSetTabControl1.Location = new System.Drawing.Point(20, 236);
            this.metroSetTabControl1.Name = "metroSetTabControl1";
            this.metroSetTabControl1.SelectedIndex = 0;
            this.metroSetTabControl1.SelectedTextColor = System.Drawing.Color.White;
            this.metroSetTabControl1.Size = new System.Drawing.Size(307, 347);
            this.metroSetTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroSetTabControl1.Speed = 100;
            this.metroSetTabControl1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetTabControl1.StyleManager = null;
            this.metroSetTabControl1.TabIndex = 35;
            this.metroSetTabControl1.ThemeAuthor = "Narwin";
            this.metroSetTabControl1.ThemeName = "MetroDark";
            this.metroSetTabControl1.UnselectedTextColor = System.Drawing.Color.Gray;
            this.metroSetTabControl1.UseAnimation = false;
            // 
            // tpPopularItems
            // 
            this.tpPopularItems.Controls.Add(this.lbxItemList);
            this.tpPopularItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.tpPopularItems.Location = new System.Drawing.Point(4, 42);
            this.tpPopularItems.Name = "tpPopularItems";
            this.tpPopularItems.Size = new System.Drawing.Size(299, 301);
            this.tpPopularItems.TabIndex = 0;
            this.tpPopularItems.Text = "Popular";
            // 
            // tpFood
            // 
            this.tpFood.Location = new System.Drawing.Point(4, 42);
            this.tpFood.Name = "tpFood";
            this.tpFood.Size = new System.Drawing.Size(299, 301);
            this.tpFood.TabIndex = 1;
            this.tpFood.Text = "Food";
            // 
            // tpColdDrinks
            // 
            this.tpColdDrinks.Location = new System.Drawing.Point(4, 42);
            this.tpColdDrinks.Name = "tpColdDrinks";
            this.tpColdDrinks.Size = new System.Drawing.Size(299, 301);
            this.tpColdDrinks.TabIndex = 2;
            this.tpColdDrinks.Text = "Cold Drinks";
            // 
            // tpHotDrinks
            // 
            this.tpHotDrinks.Location = new System.Drawing.Point(4, 42);
            this.tpHotDrinks.Name = "tpHotDrinks";
            this.tpHotDrinks.Size = new System.Drawing.Size(299, 301);
            this.tpHotDrinks.TabIndex = 3;
            this.tpHotDrinks.Text = "Hot Drinks";
            // 
            // SalesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1014, 718);
            this.Controls.Add(this.metroSetTabControl1);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblAmounPaid);
            this.Controls.Add(this.mtbxAmountPaid);
            this.Controls.Add(this.lblReceipt);
            this.Controls.Add(this.rtbxReceipt);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.mtbxCustomerName);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.mbtnRemove);
            this.Controls.Add(this.mbtnBack);
            this.Controls.Add(this.mbtnNext);
            this.Controls.Add(this.mbtnPay);
            this.Name = "SalesScreen";
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.Text = "SALES MENU";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.metroSetTabControl1.ResumeLayout(false);
            this.tpPopularItems.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetButton mbtnRemove;
        private MetroSet_UI.Controls.MetroSetButton mbtnBack;
        private MetroSet_UI.Controls.MetroSetButton mbtnNext;
        private MetroSet_UI.Controls.MetroSetButton mbtnPay;
        private Label lblCustomerName;
        private MetroSet_UI.Controls.MetroSetTextBox mtbxCustomerName;
        private Label lblItems;
        private ListBox lbxItemList;
        private MetroSet_UI.Controls.MetroSetRichTextBox rtbxReceipt;
        private Label lblReceipt;
        private Label lblAmounPaid;
        private MetroSet_UI.Controls.MetroSetTextBox mtbxAmountPaid;
        private Label lblChange;
        private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl1;
        private TabPage tpPopularItems;
        private TabPage tpFood;
        private TabPage tpColdDrinks;
        private TabPage tpHotDrinks;
    }
}