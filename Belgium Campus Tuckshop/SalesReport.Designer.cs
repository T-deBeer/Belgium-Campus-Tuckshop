namespace Belgium_Campus_Tuckshop
{
    partial class SalesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReport));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.lbxCustomers = new System.Windows.Forms.ListBox();
            this.lblReceipt = new System.Windows.Forms.Label();
            this.rtbxReceipt = new MetroSet_UI.Controls.MetroSetRichTextBox();
            this.mbtnDelete = new MetroSet_UI.Controls.MetroSetButton();
            this.mbtnBack = new MetroSet_UI.Controls.MetroSetButton();
            this.mbtnAddItem = new MetroSet_UI.Controls.MetroSetButton();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 147);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(307, 22);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblCustomers
            // 
            this.lblCustomers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.lblCustomers.Location = new System.Drawing.Point(15, 199);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(166, 16);
            this.lblCustomers.TabIndex = 28;
            this.lblCustomers.Text = "Customers On July 27 2022";
            // 
            // lbxCustomers
            // 
            this.lbxCustomers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbxCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lbxCustomers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxCustomers.ForeColor = System.Drawing.Color.White;
            this.lbxCustomers.FormattingEnabled = true;
            this.lbxCustomers.ItemHeight = 16;
            this.lbxCustomers.Items.AddRange(new object[] {
            "Tiaan de Beer",
            "Yandre Bekker",
            "Shaedin Govender",
            "Johan Van de Wetering",
            "Roan Palm"});
            this.lbxCustomers.Location = new System.Drawing.Point(15, 218);
            this.lbxCustomers.Name = "lbxCustomers";
            this.lbxCustomers.Size = new System.Drawing.Size(307, 242);
            this.lbxCustomers.TabIndex = 27;
            this.lbxCustomers.SelectedIndexChanged += new System.EventHandler(this.lbxCustomers_SelectedIndexChanged);
            // 
            // lblReceipt
            // 
            this.lblReceipt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReceipt.AutoSize = true;
            this.lblReceipt.BackColor = System.Drawing.Color.Transparent;
            this.lblReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReceipt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.lblReceipt.Location = new System.Drawing.Point(409, 199);
            this.lblReceipt.Name = "lblReceipt";
            this.lblReceipt.Size = new System.Drawing.Size(161, 16);
            this.lblReceipt.TabIndex = 32;
            this.lblReceipt.Text = "Receipt for Tiaan de Beer";
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
            this.rtbxReceipt.Location = new System.Drawing.Point(409, 218);
            this.rtbxReceipt.MaxLength = 32767;
            this.rtbxReceipt.Name = "rtbxReceipt";
            this.rtbxReceipt.ReadOnly = true;
            this.rtbxReceipt.Size = new System.Drawing.Size(408, 242);
            this.rtbxReceipt.Style = MetroSet_UI.Enums.Style.Custom;
            this.rtbxReceipt.StyleManager = null;
            this.rtbxReceipt.TabIndex = 31;
            this.rtbxReceipt.Text = resources.GetString("rtbxReceipt.Text");
            this.rtbxReceipt.ThemeAuthor = "Narwin";
            this.rtbxReceipt.ThemeName = "MetroDark";
            this.rtbxReceipt.WordWrap = true;
            // 
            // mbtnDelete
            // 
            this.mbtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnDelete.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mbtnDelete.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mbtnDelete.DisabledForeColor = System.Drawing.Color.Gray;
            this.mbtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mbtnDelete.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.mbtnDelete.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.mbtnDelete.HoverTextColor = System.Drawing.Color.White;
            this.mbtnDelete.IsDerivedStyle = true;
            this.mbtnDelete.Location = new System.Drawing.Point(177, 494);
            this.mbtnDelete.Name = "mbtnDelete";
            this.mbtnDelete.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.mbtnDelete.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mbtnDelete.NormalTextColor = System.Drawing.Color.White;
            this.mbtnDelete.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.mbtnDelete.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.mbtnDelete.PressTextColor = System.Drawing.Color.White;
            this.mbtnDelete.Size = new System.Drawing.Size(145, 53);
            this.mbtnDelete.Style = MetroSet_UI.Enums.Style.Custom;
            this.mbtnDelete.StyleManager = null;
            this.mbtnDelete.TabIndex = 36;
            this.mbtnDelete.Text = "Delete Customer Sale";
            this.mbtnDelete.ThemeAuthor = "Narwin";
            this.mbtnDelete.ThemeName = "MetroDark";
            this.mbtnDelete.Click += new System.EventHandler(this.mbtnDelete_Click);
            // 
            // mbtnBack
            // 
            this.mbtnBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnBack.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mbtnBack.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mbtnBack.DisabledForeColor = System.Drawing.Color.Gray;
            this.mbtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mbtnBack.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.mbtnBack.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.mbtnBack.HoverTextColor = System.Drawing.Color.White;
            this.mbtnBack.IsDerivedStyle = true;
            this.mbtnBack.Location = new System.Drawing.Point(15, 494);
            this.mbtnBack.Name = "mbtnBack";
            this.mbtnBack.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.mbtnBack.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mbtnBack.NormalTextColor = System.Drawing.Color.White;
            this.mbtnBack.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.mbtnBack.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.mbtnBack.PressTextColor = System.Drawing.Color.White;
            this.mbtnBack.Size = new System.Drawing.Size(145, 53);
            this.mbtnBack.Style = MetroSet_UI.Enums.Style.Custom;
            this.mbtnBack.StyleManager = null;
            this.mbtnBack.TabIndex = 35;
            this.mbtnBack.Text = "Back To Menu";
            this.mbtnBack.ThemeAuthor = "Narwin";
            this.mbtnBack.ThemeName = "MetroDark";
            // 
            // mbtnAddItem
            // 
            this.mbtnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnAddItem.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mbtnAddItem.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mbtnAddItem.DisabledForeColor = System.Drawing.Color.Gray;
            this.mbtnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mbtnAddItem.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.mbtnAddItem.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.mbtnAddItem.HoverTextColor = System.Drawing.Color.White;
            this.mbtnAddItem.IsDerivedStyle = true;
            this.mbtnAddItem.Location = new System.Drawing.Point(540, 494);
            this.mbtnAddItem.Name = "mbtnAddItem";
            this.mbtnAddItem.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mbtnAddItem.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mbtnAddItem.NormalTextColor = System.Drawing.Color.White;
            this.mbtnAddItem.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.mbtnAddItem.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.mbtnAddItem.PressTextColor = System.Drawing.Color.White;
            this.mbtnAddItem.Size = new System.Drawing.Size(145, 53);
            this.mbtnAddItem.Style = MetroSet_UI.Enums.Style.Custom;
            this.mbtnAddItem.StyleManager = null;
            this.mbtnAddItem.TabIndex = 34;
            this.mbtnAddItem.Text = "Create Month Report";
            this.mbtnAddItem.ThemeAuthor = "Narwin";
            this.mbtnAddItem.ThemeName = "MetroDark";
            this.mbtnAddItem.Click += new System.EventHandler(this.mbtnAddItem_Click);
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(847, 581);
            this.Controls.Add(this.mbtnDelete);
            this.Controls.Add(this.mbtnBack);
            this.Controls.Add(this.mbtnAddItem);
            this.Controls.Add(this.lblReceipt);
            this.Controls.Add(this.rtbxReceipt);
            this.Controls.Add(this.lblCustomers);
            this.Controls.Add(this.lbxCustomers);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "SalesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.Text = "SALES REPORTS";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label lblCustomers;
        private ListBox lbxCustomers;
        private Label lblReceipt;
        private MetroSet_UI.Controls.MetroSetRichTextBox rtbxReceipt;
        private MetroSet_UI.Controls.MetroSetButton mbtnDelete;
        private MetroSet_UI.Controls.MetroSetButton mbtnBack;
        private MetroSet_UI.Controls.MetroSetButton mbtnAddItem;
    }
}