namespace PSU_Mod_Edit
{
    partial class frmTitle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTitle));
            this.cboClothes = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblParts = new System.Windows.Forms.Label();
            this.cboParts = new System.Windows.Forms.ComboBox();
            this.lblClothes = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.chkMale = new System.Windows.Forms.CheckBox();
            this.chkFemale = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.chkMaleParts = new System.Windows.Forms.CheckBox();
            this.chkFemaleParts = new System.Windows.Forms.CheckBox();
            this.chkAotiColors = new System.Windows.Forms.CheckBox();
            this.picColorWindow = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picColorText = new System.Windows.Forms.PictureBox();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clementineSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picColorWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picColorText)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboClothes
            // 
            this.cboClothes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClothes.FormattingEnabled = true;
            this.cboClothes.Items.AddRange(new object[] {
            resources.GetString("cboClothes.Items")});
            resources.ApplyResources(this.cboClothes, "cboClothes");
            this.cboClothes.Name = "cboClothes";
            this.cboClothes.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = true;
        
            // 
            // lblParts
            // 
            resources.ApplyResources(this.lblParts, "lblParts");
            this.lblParts.Name = "lblParts";
            // 
            // cboParts
            // 
            this.cboParts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParts.FormattingEnabled = true;
            this.cboParts.Items.AddRange(new object[] {
            resources.GetString("cboParts.Items"),
            resources.GetString("cboParts.Items1"),
            resources.GetString("cboParts.Items2"),
            resources.GetString("cboParts.Items3")});
            resources.ApplyResources(this.cboParts, "cboParts");
            this.cboParts.Name = "cboParts";
            // 
            // lblClothes
            // 
            resources.ApplyResources(this.lblClothes, "lblClothes");
            this.lblClothes.Name = "lblClothes";
            // 
            // lblGender
            // 
            resources.ApplyResources(this.lblGender, "lblGender");
            this.lblGender.Name = "lblGender";
            // 
            // chkMale
            // 
            resources.ApplyResources(this.chkMale, "chkMale");
            this.chkMale.Name = "chkMale";
            this.chkMale.UseVisualStyleBackColor = true;
            this.chkMale.CheckedChanged += new System.EventHandler(this.chkMale_CheckedChanged);
            // 
            // chkFemale
            // 
            resources.ApplyResources(this.chkFemale, "chkFemale");
            this.chkFemale.Name = "chkFemale";
            this.chkFemale.UseVisualStyleBackColor = true;
            this.chkFemale.CheckedChanged += new System.EventHandler(this.chkFemale_CheckedChanged);
            // 
            // chkMaleParts
            // 
            resources.ApplyResources(this.chkMaleParts, "chkMaleParts");
            this.chkMaleParts.Name = "chkMaleParts";
            this.chkMaleParts.UseVisualStyleBackColor = true;
            this.chkMaleParts.CheckedChanged += new System.EventHandler(this.chkMaleParts_CheckedChanged);
            // 
            // chkFemaleParts
            // 
            resources.ApplyResources(this.chkFemaleParts, "chkFemaleParts");
            this.chkFemaleParts.Name = "chkFemaleParts";
            this.chkFemaleParts.UseVisualStyleBackColor = true;
            this.chkFemaleParts.CheckedChanged += new System.EventHandler(this.chkFemaleParts_CheckedChanged);
            // 
            // chkAotiColors
            // 
            resources.ApplyResources(this.chkAotiColors, "chkAotiColors");
            this.chkAotiColors.Name = "chkAotiColors";
            this.chkAotiColors.UseVisualStyleBackColor = true;
            this.chkAotiColors.CheckedChanged += new System.EventHandler(this.chkAotiColors_CheckedChanged);
            // 
            // picColorWindow
            // 
            this.picColorWindow.BackColor = System.Drawing.SystemColors.Control;
            this.picColorWindow.Image = global::PSU_Mod_Edit.Properties.Resources.picutre_12;
            resources.ApplyResources(this.picColorWindow, "picColorWindow");
            this.picColorWindow.Name = "picColorWindow";
            this.picColorWindow.TabStop = false;
            this.picColorWindow.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picColorText
            // 
            this.picColorText.BackColor = System.Drawing.SystemColors.Control;
            this.picColorText.Image = global::PSU_Mod_Edit.Properties.Resources.picutre_12;
            resources.ApplyResources(this.picColorText, "picColorText");
            this.picColorText.Name = "picColorText";
            this.picColorText.TabStop = false;
            this.picColorText.Click += new System.EventHandler(this.picColorText_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clementineSiteToolStripMenuItem,
            this.sendReportsToolStripMenuItem});
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            resources.ApplyResources(this.informationToolStripMenuItem, "informationToolStripMenuItem");
            // 
            // clementineSiteToolStripMenuItem
            // 
            this.clementineSiteToolStripMenuItem.Name = "clementineSiteToolStripMenuItem";
            resources.ApplyResources(this.clementineSiteToolStripMenuItem, "clementineSiteToolStripMenuItem");
            this.clementineSiteToolStripMenuItem.Click += new System.EventHandler(this.clementineSiteToolStripMenuItem_Click);
            // 
            // sendReportsToolStripMenuItem
            // 
            this.sendReportsToolStripMenuItem.Name = "sendReportsToolStripMenuItem";
            resources.ApplyResources(this.sendReportsToolStripMenuItem, "sendReportsToolStripMenuItem");
            this.sendReportsToolStripMenuItem.Click += new System.EventHandler(this.sendReportsToolStripMenuItem_Click);
            // 
            // frmTitle
            // 
            this.AcceptButton = this.btnEdit;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.picColorText);
            this.Controls.Add(this.picColorWindow);
            this.Controls.Add(this.chkAotiColors);
            this.Controls.Add(this.chkFemaleParts);
            this.Controls.Add(this.chkMaleParts);
            this.Controls.Add(this.chkFemale);
            this.Controls.Add(this.chkMale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblClothes);
            this.Controls.Add(this.cboParts);
            this.Controls.Add(this.lblParts);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cboClothes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTitle";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmTitle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picColorWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picColorText)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboClothes;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.ComboBox cboParts;
        private System.Windows.Forms.Label lblClothes;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.CheckBox chkMale;
        private System.Windows.Forms.CheckBox chkFemale;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckBox chkMaleParts;
        private System.Windows.Forms.CheckBox chkFemaleParts;
        private System.Windows.Forms.CheckBox chkAotiColors;
        private System.Windows.Forms.PictureBox picColorWindow;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picColorText;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clementineSiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendReportsToolStripMenuItem;
    }
}

