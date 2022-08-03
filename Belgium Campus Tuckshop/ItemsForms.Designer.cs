namespace Belgium_Campus_Tuckshop
{
    partial class ItemsForms
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
            this.lblItemName = new System.Windows.Forms.Label();
            this.mtbxItemName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblItemDesc = new System.Windows.Forms.Label();
            this.mtbxDescription = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblItemCost = new System.Windows.Forms.Label();
            this.mtbxItemCost = new MetroSet_UI.Controls.MetroSetTextBox();
            this.mbtnUpdate = new MetroSet_UI.Controls.MetroSetButton();
            this.mbtnAddItem = new MetroSet_UI.Controls.MetroSetButton();
            this.mbtnBack = new MetroSet_UI.Controls.MetroSetButton();
            this.mbtnDelete = new MetroSet_UI.Controls.MetroSetButton();
            this.lblItems = new System.Windows.Forms.Label();
            this.lblItemType = new System.Windows.Forms.Label();
            this.lblPopular = new System.Windows.Forms.Label();
            this.mswPopular = new MetroSet_UI.Controls.MetroSetSwitch();
            this.tbcItems = new System.Windows.Forms.TabControl();
            this.tabPopular = new System.Windows.Forms.TabPage();
            this.ListBoxPopular = new MetroSet_UI.Controls.MetroSetListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ListBoxFood = new MetroSet_UI.Controls.MetroSetListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ListBoxColdDrinks = new MetroSet_UI.Controls.MetroSetListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ListBoxHotDrinks = new MetroSet_UI.Controls.MetroSetListBox();
            this.cbxItemType = new MetroSet_UI.Controls.MetroSetComboBox();
            this.tbcItems.SuspendLayout();
            this.tabPopular.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblItemName
            // 
            this.lblItemName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblItemName.AutoSize = true;
            this.lblItemName.BackColor = System.Drawing.Color.Transparent;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.lblItemName.Location = new System.Drawing.Point(467, 142);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(72, 16);
            this.lblItemName.TabIndex = 7;
            this.lblItemName.Text = "Item Name";
            // 
            // mtbxItemName
            // 
            this.mtbxItemName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbxItemName.AutoCompleteCustomSource = null;
            this.mtbxItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.mtbxItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.mtbxItemName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.mtbxItemName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.mtbxItemName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbxItemName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbxItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtbxItemName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mtbxItemName.Image = null;
            this.mtbxItemName.IsDerivedStyle = true;
            this.mtbxItemName.Lines = null;
            this.mtbxItemName.Location = new System.Drawing.Point(469, 161);
            this.mtbxItemName.MaxLength = 32767;
            this.mtbxItemName.Multiline = false;
            this.mtbxItemName.Name = "mtbxItemName";
            this.mtbxItemName.ReadOnly = false;
            this.mtbxItemName.Size = new System.Drawing.Size(250, 33);
            this.mtbxItemName.Style = MetroSet_UI.Enums.Style.Dark;
            this.mtbxItemName.StyleManager = null;
            this.mtbxItemName.TabIndex = 6;
            this.mtbxItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtbxItemName.ThemeAuthor = "Narwin";
            this.mtbxItemName.ThemeName = "MetroDark";
            this.mtbxItemName.UseSystemPasswordChar = false;
            this.mtbxItemName.WatermarkText = "Item Name";
            // 
            // lblItemDesc
            // 
            this.lblItemDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblItemDesc.AutoSize = true;
            this.lblItemDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblItemDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItemDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.lblItemDesc.Location = new System.Drawing.Point(467, 230);
            this.lblItemDesc.Name = "lblItemDesc";
            this.lblItemDesc.Size = new System.Drawing.Size(103, 16);
            this.lblItemDesc.TabIndex = 9;
            this.lblItemDesc.Text = "Item Description";
            // 
            // mtbxDescription
            // 
            this.mtbxDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbxDescription.AutoCompleteCustomSource = null;
            this.mtbxDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.mtbxDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.mtbxDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.mtbxDescription.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.mtbxDescription.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbxDescription.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtbxDescription.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mtbxDescription.Image = null;
            this.mtbxDescription.IsDerivedStyle = true;
            this.mtbxDescription.Lines = null;
            this.mtbxDescription.Location = new System.Drawing.Point(467, 249);
            this.mtbxDescription.MaxLength = 32767;
            this.mtbxDescription.Multiline = true;
            this.mtbxDescription.Name = "mtbxDescription";
            this.mtbxDescription.ReadOnly = false;
            this.mtbxDescription.Size = new System.Drawing.Size(250, 176);
            this.mtbxDescription.Style = MetroSet_UI.Enums.Style.Dark;
            this.mtbxDescription.StyleManager = null;
            this.mtbxDescription.TabIndex = 8;
            this.mtbxDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtbxDescription.ThemeAuthor = "Narwin";
            this.mtbxDescription.ThemeName = "MetroDark";
            this.mtbxDescription.UseSystemPasswordChar = false;
            this.mtbxDescription.WatermarkText = "Item Description";
            // 
            // lblItemCost
            // 
            this.lblItemCost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblItemCost.AutoSize = true;
            this.lblItemCost.BackColor = System.Drawing.Color.Transparent;
            this.lblItemCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItemCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.lblItemCost.Location = new System.Drawing.Point(758, 368);
            this.lblItemCost.Name = "lblItemCost";
            this.lblItemCost.Size = new System.Drawing.Size(62, 16);
            this.lblItemCost.TabIndex = 11;
            this.lblItemCost.Text = "Item Cost";
            // 
            // mtbxItemCost
            // 
            this.mtbxItemCost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbxItemCost.AutoCompleteCustomSource = null;
            this.mtbxItemCost.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.mtbxItemCost.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.mtbxItemCost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.mtbxItemCost.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.mtbxItemCost.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbxItemCost.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbxItemCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtbxItemCost.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mtbxItemCost.Image = null;
            this.mtbxItemCost.IsDerivedStyle = true;
            this.mtbxItemCost.Lines = null;
            this.mtbxItemCost.Location = new System.Drawing.Point(758, 387);
            this.mtbxItemCost.MaxLength = 32767;
            this.mtbxItemCost.Multiline = false;
            this.mtbxItemCost.Name = "mtbxItemCost";
            this.mtbxItemCost.ReadOnly = false;
            this.mtbxItemCost.Size = new System.Drawing.Size(245, 33);
            this.mtbxItemCost.Style = MetroSet_UI.Enums.Style.Dark;
            this.mtbxItemCost.StyleManager = null;
            this.mtbxItemCost.TabIndex = 12;
            this.mtbxItemCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtbxItemCost.ThemeAuthor = "Narwin";
            this.mtbxItemCost.ThemeName = "MetroDark";
            this.mtbxItemCost.UseSystemPasswordChar = false;
            this.mtbxItemCost.WatermarkText = "Item Cost";
            // 
            // mbtnUpdate
            // 
            this.mbtnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbtnUpdate.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mbtnUpdate.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mbtnUpdate.DisabledForeColor = System.Drawing.Color.Gray;
            this.mbtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mbtnUpdate.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.mbtnUpdate.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.mbtnUpdate.HoverTextColor = System.Drawing.Color.White;
            this.mbtnUpdate.IsDerivedStyle = true;
            this.mbtnUpdate.Location = new System.Drawing.Point(687, 505);
            this.mbtnUpdate.Name = "mbtnUpdate";
            this.mbtnUpdate.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mbtnUpdate.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mbtnUpdate.NormalTextColor = System.Drawing.Color.White;
            this.mbtnUpdate.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.mbtnUpdate.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.mbtnUpdate.PressTextColor = System.Drawing.Color.White;
            this.mbtnUpdate.Size = new System.Drawing.Size(105, 53);
            this.mbtnUpdate.Style = MetroSet_UI.Enums.Style.Custom;
            this.mbtnUpdate.StyleManager = null;
            this.mbtnUpdate.TabIndex = 13;
            this.mbtnUpdate.Text = "Update Item";
            this.mbtnUpdate.ThemeAuthor = "Narwin";
            this.mbtnUpdate.ThemeName = "MetroDark";
            this.mbtnUpdate.Click += new System.EventHandler(this.mbtnUpdate_Click);
            // 
            // mbtnAddItem
            // 
            this.mbtnAddItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbtnAddItem.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mbtnAddItem.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mbtnAddItem.DisabledForeColor = System.Drawing.Color.Gray;
            this.mbtnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mbtnAddItem.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.mbtnAddItem.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.mbtnAddItem.HoverTextColor = System.Drawing.Color.White;
            this.mbtnAddItem.IsDerivedStyle = true;
            this.mbtnAddItem.Location = new System.Drawing.Point(898, 505);
            this.mbtnAddItem.Name = "mbtnAddItem";
            this.mbtnAddItem.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mbtnAddItem.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mbtnAddItem.NormalTextColor = System.Drawing.Color.White;
            this.mbtnAddItem.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.mbtnAddItem.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.mbtnAddItem.PressTextColor = System.Drawing.Color.White;
            this.mbtnAddItem.Size = new System.Drawing.Size(105, 53);
            this.mbtnAddItem.Style = MetroSet_UI.Enums.Style.Custom;
            this.mbtnAddItem.StyleManager = null;
            this.mbtnAddItem.TabIndex = 14;
            this.mbtnAddItem.Text = "Add Item";
            this.mbtnAddItem.ThemeAuthor = "Narwin";
            this.mbtnAddItem.ThemeName = "MetroDark";
            this.mbtnAddItem.Click += new System.EventHandler(this.mbtnAddItem_Click);
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
            this.mbtnBack.Location = new System.Drawing.Point(68, 505);
            this.mbtnBack.Name = "mbtnBack";
            this.mbtnBack.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.mbtnBack.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mbtnBack.NormalTextColor = System.Drawing.Color.White;
            this.mbtnBack.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.mbtnBack.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.mbtnBack.PressTextColor = System.Drawing.Color.White;
            this.mbtnBack.Size = new System.Drawing.Size(105, 53);
            this.mbtnBack.Style = MetroSet_UI.Enums.Style.Custom;
            this.mbtnBack.StyleManager = null;
            this.mbtnBack.TabIndex = 15;
            this.mbtnBack.Text = "Back To Menu";
            this.mbtnBack.ThemeAuthor = "Narwin";
            this.mbtnBack.ThemeName = "MetroDark";
            this.mbtnBack.Click += new System.EventHandler(this.mbtnBack_Click);
            // 
            // mbtnDelete
            // 
            this.mbtnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbtnDelete.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mbtnDelete.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mbtnDelete.DisabledForeColor = System.Drawing.Color.Gray;
            this.mbtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mbtnDelete.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.mbtnDelete.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.mbtnDelete.HoverTextColor = System.Drawing.Color.White;
            this.mbtnDelete.IsDerivedStyle = true;
            this.mbtnDelete.Location = new System.Drawing.Point(467, 505);
            this.mbtnDelete.Name = "mbtnDelete";
            this.mbtnDelete.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.mbtnDelete.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mbtnDelete.NormalTextColor = System.Drawing.Color.White;
            this.mbtnDelete.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.mbtnDelete.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.mbtnDelete.PressTextColor = System.Drawing.Color.White;
            this.mbtnDelete.Size = new System.Drawing.Size(105, 53);
            this.mbtnDelete.Style = MetroSet_UI.Enums.Style.Custom;
            this.mbtnDelete.StyleManager = null;
            this.mbtnDelete.TabIndex = 16;
            this.mbtnDelete.Text = "Delete Item";
            this.mbtnDelete.ThemeAuthor = "Narwin";
            this.mbtnDelete.ThemeName = "MetroDark";
            this.mbtnDelete.Click += new System.EventHandler(this.mbtnDelete_Click);
            // 
            // lblItems
            // 
            this.lblItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblItems.AutoSize = true;
            this.lblItems.BackColor = System.Drawing.Color.Transparent;
            this.lblItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.lblItems.Location = new System.Drawing.Point(68, 111);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(76, 16);
            this.lblItems.TabIndex = 5;
            this.lblItems.Text = "List of Items";
            // 
            // lblItemType
            // 
            this.lblItemType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblItemType.AutoSize = true;
            this.lblItemType.BackColor = System.Drawing.Color.Transparent;
            this.lblItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItemType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.lblItemType.Location = new System.Drawing.Point(753, 142);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(67, 16);
            this.lblItemType.TabIndex = 38;
            this.lblItemType.Text = "Item Type";
            // 
            // lblPopular
            // 
            this.lblPopular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPopular.AutoSize = true;
            this.lblPopular.BackColor = System.Drawing.Color.Transparent;
            this.lblPopular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPopular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.lblPopular.Location = new System.Drawing.Point(753, 230);
            this.lblPopular.Name = "lblPopular";
            this.lblPopular.Size = new System.Drawing.Size(54, 16);
            this.lblPopular.TabIndex = 39;
            this.lblPopular.Text = "Popular";
            // 
            // mswPopular
            // 
            this.mswPopular.BackColor = System.Drawing.Color.Transparent;
            this.mswPopular.BackgroundColor = System.Drawing.Color.Empty;
            this.mswPopular.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.mswPopular.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mswPopular.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.mswPopular.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.mswPopular.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mswPopular.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.mswPopular.IsDerivedStyle = true;
            this.mswPopular.Location = new System.Drawing.Point(758, 249);
            this.mswPopular.Name = "mswPopular";
            this.mswPopular.Size = new System.Drawing.Size(58, 22);
            this.mswPopular.Style = MetroSet_UI.Enums.Style.Dark;
            this.mswPopular.StyleManager = null;
            this.mswPopular.Switched = false;
            this.mswPopular.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.mswPopular.TabIndex = 40;
            this.mswPopular.Text = "metroSetSwitch1";
            this.mswPopular.ThemeAuthor = "Narwin";
            this.mswPopular.ThemeName = "MetroDark";
            this.mswPopular.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // tbcItems
            // 
            this.tbcItems.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbcItems.Controls.Add(this.tabPopular);
            this.tbcItems.Controls.Add(this.tabPage2);
            this.tbcItems.Controls.Add(this.tabPage3);
            this.tbcItems.Controls.Add(this.tabPage4);
            this.tbcItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.tbcItems.Location = new System.Drawing.Point(68, 142);
            this.tbcItems.Name = "tbcItems";
            this.tbcItems.SelectedIndex = 0;
            this.tbcItems.Size = new System.Drawing.Size(311, 283);
            this.tbcItems.TabIndex = 41;
            // 
            // tabPopular
            // 
            this.tabPopular.Controls.Add(this.ListBoxPopular);
            this.tabPopular.Location = new System.Drawing.Point(4, 27);
            this.tabPopular.Name = "tabPopular";
            this.tabPopular.Padding = new System.Windows.Forms.Padding(3);
            this.tabPopular.Size = new System.Drawing.Size(303, 252);
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
            this.ListBoxPopular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxPopular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListBoxPopular.HoveredItemBackColor = System.Drawing.Color.LightGray;
            this.ListBoxPopular.HoveredItemColor = System.Drawing.Color.DimGray;
            this.ListBoxPopular.IsDerivedStyle = true;
            this.ListBoxPopular.ItemHeight = 30;
            this.ListBoxPopular.Location = new System.Drawing.Point(3, 3);
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
            this.ListBoxPopular.Size = new System.Drawing.Size(297, 246);
            this.ListBoxPopular.Style = MetroSet_UI.Enums.Style.Dark;
            this.ListBoxPopular.StyleManager = null;
            this.ListBoxPopular.TabIndex = 0;
            this.ListBoxPopular.ThemeAuthor = "Narwin";
            this.ListBoxPopular.ThemeName = "MetroDark";
            this.ListBoxPopular.SelectedIndexChanged += new MetroSet_UI.Controls.MetroSetListBox.SelectedIndexChangedEventHandler(this.ListBoxPopular_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ListBoxFood);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(303, 252);
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
            this.ListBoxFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListBoxFood.HoveredItemBackColor = System.Drawing.Color.LightGray;
            this.ListBoxFood.HoveredItemColor = System.Drawing.Color.DimGray;
            this.ListBoxFood.IsDerivedStyle = true;
            this.ListBoxFood.ItemHeight = 30;
            this.ListBoxFood.Location = new System.Drawing.Point(3, 3);
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
            this.ListBoxFood.Size = new System.Drawing.Size(297, 246);
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
            this.tabPage3.Size = new System.Drawing.Size(303, 252);
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
            this.ListBoxColdDrinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxColdDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListBoxColdDrinks.HoveredItemBackColor = System.Drawing.Color.LightGray;
            this.ListBoxColdDrinks.HoveredItemColor = System.Drawing.Color.DimGray;
            this.ListBoxColdDrinks.IsDerivedStyle = true;
            this.ListBoxColdDrinks.ItemHeight = 30;
            this.ListBoxColdDrinks.Location = new System.Drawing.Point(3, 3);
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
            this.ListBoxColdDrinks.Size = new System.Drawing.Size(297, 246);
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
            this.tabPage4.Size = new System.Drawing.Size(303, 252);
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
            this.ListBoxHotDrinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxHotDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListBoxHotDrinks.HoveredItemBackColor = System.Drawing.Color.LightGray;
            this.ListBoxHotDrinks.HoveredItemColor = System.Drawing.Color.DimGray;
            this.ListBoxHotDrinks.IsDerivedStyle = true;
            this.ListBoxHotDrinks.ItemHeight = 30;
            this.ListBoxHotDrinks.Location = new System.Drawing.Point(3, 3);
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
            this.ListBoxHotDrinks.Size = new System.Drawing.Size(297, 246);
            this.ListBoxHotDrinks.Style = MetroSet_UI.Enums.Style.Dark;
            this.ListBoxHotDrinks.StyleManager = null;
            this.ListBoxHotDrinks.TabIndex = 3;
            this.ListBoxHotDrinks.ThemeAuthor = "Narwin";
            this.ListBoxHotDrinks.ThemeName = "MetroDark";
            this.ListBoxHotDrinks.SelectedIndexChanged += new MetroSet_UI.Controls.MetroSetListBox.SelectedIndexChangedEventHandler(this.ListBoxHotDrinks_SelectedIndexChanged);
            // 
            // cbxItemType
            // 
            this.cbxItemType.AllowDrop = true;
            this.cbxItemType.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.cbxItemType.BackColor = System.Drawing.Color.Transparent;
            this.cbxItemType.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cbxItemType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.cbxItemType.CausesValidation = false;
            this.cbxItemType.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cbxItemType.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbxItemType.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbxItemType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxItemType.FormattingEnabled = true;
            this.cbxItemType.IsDerivedStyle = true;
            this.cbxItemType.ItemHeight = 20;
            this.cbxItemType.Items.AddRange(new object[] {
            "Food",
            "Hot Drink",
            "Cold Drink"});
            this.cbxItemType.Location = new System.Drawing.Point(758, 161);
            this.cbxItemType.Name = "cbxItemType";
            this.cbxItemType.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cbxItemType.SelectedItemForeColor = System.Drawing.Color.White;
            this.cbxItemType.Size = new System.Drawing.Size(245, 26);
            this.cbxItemType.Style = MetroSet_UI.Enums.Style.Dark;
            this.cbxItemType.StyleManager = null;
            this.cbxItemType.TabIndex = 42;
            this.cbxItemType.ThemeAuthor = "Narwin";
            this.cbxItemType.ThemeName = "MetroDark";
            // 
            // ItemsForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1108, 592);
            this.Controls.Add(this.cbxItemType);
            this.Controls.Add(this.tbcItems);
            this.Controls.Add(this.mswPopular);
            this.Controls.Add(this.lblPopular);
            this.Controls.Add(this.lblItemType);
            this.Controls.Add(this.mbtnDelete);
            this.Controls.Add(this.mbtnBack);
            this.Controls.Add(this.mbtnAddItem);
            this.Controls.Add(this.mbtnUpdate);
            this.Controls.Add(this.mtbxItemCost);
            this.Controls.Add(this.lblItemCost);
            this.Controls.Add(this.lblItemDesc);
            this.Controls.Add(this.mtbxDescription);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.mtbxItemName);
            this.Controls.Add(this.lblItems);
            this.Name = "ItemsForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.Text = "EDIT OR ADD ITEMS";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.tbcItems.ResumeLayout(false);
            this.tabPopular.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblItemName;
        private MetroSet_UI.Controls.MetroSetTextBox mtbxItemName;
        private Label lblItemDesc;
        private MetroSet_UI.Controls.MetroSetTextBox mtbxDescription;
        private Label lblItemCost;
        private MetroSet_UI.Controls.MetroSetTextBox mtbxItemCost;
        private MetroSet_UI.Controls.MetroSetButton mbtnUpdate;
        private MetroSet_UI.Controls.MetroSetButton mbtnAddItem;
        private MetroSet_UI.Controls.MetroSetButton mbtnBack;
        private MetroSet_UI.Controls.MetroSetButton mbtnDelete;
        private Label lblItems;
        private Label lblItemType;
        private Label lblPopular;
        private MetroSet_UI.Controls.MetroSetSwitch mswPopular;
        private TabControl tbcItems;
        private TabPage tabPopular;
        private MetroSet_UI.Controls.MetroSetListBox ListBoxPopular;
        private TabPage tabPage2;
        private MetroSet_UI.Controls.MetroSetListBox ListBoxFood;
        private TabPage tabPage3;
        private MetroSet_UI.Controls.MetroSetListBox ListBoxColdDrinks;
        private TabPage tabPage4;
        private MetroSet_UI.Controls.MetroSetListBox ListBoxHotDrinks;
        private MetroSet_UI.Controls.MetroSetComboBox cbxItemType;
    }
}