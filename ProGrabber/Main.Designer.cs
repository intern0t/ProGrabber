namespace ProGrabber
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnClearFields = new MetroFramework.Controls.MetroButton();
            this.btnGrabThem = new MetroFramework.Controls.MetroButton();
            this.cmProxyType = new MetroFramework.Controls.MetroComboBox();
            this.lblProxyType = new MetroFramework.Controls.MetroLabel();
            this.btnBrowseSD = new MetroFramework.Controls.MetroButton();
            this.txtStoreDirectory = new MetroFramework.Controls.MetroTextBox();
            this.lblStoreDirectory = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.txtAbout = new MetroFramework.Controls.MetroLabel();
            this.lnkCopyright = new MetroFramework.Controls.MetroLink();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(498, 162);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btnClearFields);
            this.metroTabPage1.Controls.Add(this.btnGrabThem);
            this.metroTabPage1.Controls.Add(this.cmProxyType);
            this.metroTabPage1.Controls.Add(this.lblProxyType);
            this.metroTabPage1.Controls.Add(this.btnBrowseSD);
            this.metroTabPage1.Controls.Add(this.txtStoreDirectory);
            this.metroTabPage1.Controls.Add(this.lblStoreDirectory);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(490, 120);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "General";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // btnClearFields
            // 
            this.btnClearFields.Location = new System.Drawing.Point(286, 89);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(83, 23);
            this.btnClearFields.Style = MetroFramework.MetroColorStyle.Red;
            this.btnClearFields.TabIndex = 9;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnClearFields.UseSelectable = true;
            // 
            // btnGrabThem
            // 
            this.btnGrabThem.Location = new System.Drawing.Point(375, 89);
            this.btnGrabThem.Name = "btnGrabThem";
            this.btnGrabThem.Size = new System.Drawing.Size(102, 23);
            this.btnGrabThem.Style = MetroFramework.MetroColorStyle.Red;
            this.btnGrabThem.TabIndex = 8;
            this.btnGrabThem.Text = "Grab \'em!";
            this.btnGrabThem.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnGrabThem.UseSelectable = true;
            this.btnGrabThem.Click += new System.EventHandler(this.btnGrabThem_Click);
            // 
            // cmProxyType
            // 
            this.cmProxyType.FormattingEnabled = true;
            this.cmProxyType.ItemHeight = 23;
            this.cmProxyType.Items.AddRange(new object[] {
            "Sock Proxies",
            "SSL Proxies",
            "Google Proxies",
            "Server Proxies"});
            this.cmProxyType.Location = new System.Drawing.Point(119, 48);
            this.cmProxyType.Name = "cmProxyType";
            this.cmProxyType.Size = new System.Drawing.Size(358, 29);
            this.cmProxyType.Style = MetroFramework.MetroColorStyle.Red;
            this.cmProxyType.TabIndex = 7;
            this.cmProxyType.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmProxyType.UseSelectable = true;
            // 
            // lblProxyType
            // 
            this.lblProxyType.AutoSize = true;
            this.lblProxyType.Location = new System.Drawing.Point(40, 52);
            this.lblProxyType.Name = "lblProxyType";
            this.lblProxyType.Size = new System.Drawing.Size(73, 19);
            this.lblProxyType.Style = MetroFramework.MetroColorStyle.Red;
            this.lblProxyType.TabIndex = 6;
            this.lblProxyType.Text = "Proxy Type";
            this.lblProxyType.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnBrowseSD
            // 
            this.btnBrowseSD.Location = new System.Drawing.Point(454, 15);
            this.btnBrowseSD.Name = "btnBrowseSD";
            this.btnBrowseSD.Size = new System.Drawing.Size(23, 23);
            this.btnBrowseSD.Style = MetroFramework.MetroColorStyle.Red;
            this.btnBrowseSD.TabIndex = 4;
            this.btnBrowseSD.Text = "..";
            this.btnBrowseSD.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnBrowseSD.UseSelectable = true;
            this.btnBrowseSD.Click += new System.EventHandler(this.btnBrowseSD_Click);
            // 
            // txtStoreDirectory
            // 
            this.txtStoreDirectory.Lines = new string[] {
        "Default path is your application start path. Browse to edit."};
            this.txtStoreDirectory.Location = new System.Drawing.Point(119, 15);
            this.txtStoreDirectory.MaxLength = 32767;
            this.txtStoreDirectory.Name = "txtStoreDirectory";
            this.txtStoreDirectory.PasswordChar = '\0';
            this.txtStoreDirectory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStoreDirectory.SelectedText = "";
            this.txtStoreDirectory.Size = new System.Drawing.Size(327, 23);
            this.txtStoreDirectory.Style = MetroFramework.MetroColorStyle.Red;
            this.txtStoreDirectory.TabIndex = 3;
            this.txtStoreDirectory.Text = "Default path is your application start path. Browse to edit.";
            this.txtStoreDirectory.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtStoreDirectory.UseSelectable = true;
            // 
            // lblStoreDirectory
            // 
            this.lblStoreDirectory.AutoSize = true;
            this.lblStoreDirectory.Location = new System.Drawing.Point(15, 16);
            this.lblStoreDirectory.Name = "lblStoreDirectory";
            this.lblStoreDirectory.Size = new System.Drawing.Size(98, 19);
            this.lblStoreDirectory.Style = MetroFramework.MetroColorStyle.Red;
            this.lblStoreDirectory.TabIndex = 2;
            this.lblStoreDirectory.Text = "Store Directory";
            this.lblStoreDirectory.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.txtAbout);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(490, 120);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "About";
            this.metroTabPage3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // txtAbout
            // 
            this.txtAbout.AutoSize = true;
            this.txtAbout.FontSize = MetroFramework.MetroLabelSize.Small;
            this.txtAbout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAbout.Location = new System.Drawing.Point(3, 12);
            this.txtAbout.Name = "txtAbout";
            this.txtAbout.Size = new System.Drawing.Size(481, 90);
            this.txtAbout.TabIndex = 2;
            this.txtAbout.Text = resources.GetString("txtAbout.Text");
            this.txtAbout.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lnkCopyright
            // 
            this.lnkCopyright.Location = new System.Drawing.Point(23, 227);
            this.lnkCopyright.Name = "lnkCopyright";
            this.lnkCopyright.Size = new System.Drawing.Size(197, 23);
            this.lnkCopyright.TabIndex = 1;
            this.lnkCopyright.Text = "Copyright © 2015, Scarecrow [CK]";
            this.lnkCopyright.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lnkCopyright.UseSelectable = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 260);
            this.Controls.Add(this.lnkCopyright);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Main";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "ProGrabber : Powered by Cracking King";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Main_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroLink lnkCopyright;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroButton btnBrowseSD;
        private MetroFramework.Controls.MetroTextBox txtStoreDirectory;
        private MetroFramework.Controls.MetroLabel lblStoreDirectory;
        private MetroFramework.Controls.MetroButton btnClearFields;
        private MetroFramework.Controls.MetroButton btnGrabThem;
        private MetroFramework.Controls.MetroComboBox cmProxyType;
        private MetroFramework.Controls.MetroLabel lblProxyType;
        private MetroFramework.Controls.MetroLabel txtAbout;
    }
}

