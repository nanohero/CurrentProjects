namespace PSU_Mod_Edit
{
    partial class cboColor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cboColor));
            this.cboClothes = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblParts = new System.Windows.Forms.Label();
            this.cboParts = new System.Windows.Forms.ComboBox();
            this.lblClothes = new System.Windows.Forms.Label();
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkFemaleAoti = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkCast = new System.Windows.Forms.CheckBox();
            this.chkNewman = new System.Windows.Forms.CheckBox();
            this.chkBeast = new System.Windows.Forms.CheckBox();
            this.chkHuman = new System.Windows.Forms.CheckBox();
            this.Color = new System.Windows.Forms.Label();
            this.cboColor1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picColorWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picColorText)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "PVgaR3S.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkFemaleAoti);
            this.groupBox1.Controls.Add(this.chkMale);
            this.groupBox1.Controls.Add(this.chkFemale);
            this.groupBox1.Controls.Add(this.chkAotiColors);
            this.groupBox1.Controls.Add(this.chkMaleParts);
            this.groupBox1.Controls.Add(this.chkFemaleParts);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkFemaleAoti
            // 
            resources.ApplyResources(this.chkFemaleAoti, "chkFemaleAoti");
            this.chkFemaleAoti.Name = "chkFemaleAoti";
            this.chkFemaleAoti.UseVisualStyleBackColor = true;
            this.chkFemaleAoti.CheckedChanged += new System.EventHandler(this.cFemaleAoti_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkCast);
            this.groupBox2.Controls.Add(this.chkNewman);
            this.groupBox2.Controls.Add(this.chkBeast);
            this.groupBox2.Controls.Add(this.chkHuman);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // chkCast
            // 
            resources.ApplyResources(this.chkCast, "chkCast");
            this.chkCast.Name = "chkCast";
            this.chkCast.UseVisualStyleBackColor = true;
            this.chkCast.CheckedChanged += new System.EventHandler(this.chkCast_CheckedChanged);
            // 
            // chkNewman
            // 
            resources.ApplyResources(this.chkNewman, "chkNewman");
            this.chkNewman.Name = "chkNewman";
            this.chkNewman.UseVisualStyleBackColor = true;
            this.chkNewman.CheckedChanged += new System.EventHandler(this.chkNewman_CheckedChanged);
            // 
            // chkBeast
            // 
            resources.ApplyResources(this.chkBeast, "chkBeast");
            this.chkBeast.Name = "chkBeast";
            this.chkBeast.UseVisualStyleBackColor = true;
            this.chkBeast.CheckedChanged += new System.EventHandler(this.chkBeast_CheckedChanged);
            // 
            // chkHuman
            // 
            resources.ApplyResources(this.chkHuman, "chkHuman");
            this.chkHuman.Name = "chkHuman";
            this.chkHuman.UseVisualStyleBackColor = true;
            this.chkHuman.CheckedChanged += new System.EventHandler(this.chkHuman_CheckedChanged);
            // 
            // Color
            // 
            resources.ApplyResources(this.Color, "Color");
            this.Color.Name = "Color";
            // 
            // cboColor1
            // 
            this.cboColor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColor1.FormattingEnabled = true;
            this.cboColor1.Items.AddRange(new object[] {
            resources.GetString("cboColor1.Items")});
            resources.ApplyResources(this.cboColor1, "cboColor1");
            this.cboColor1.Name = "cboColor1";
            this.cboColor1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // cboColor
            // 
            this.AcceptButton = this.btnEdit;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.Color);
            this.Controls.Add(this.cboColor1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picColorText);
            this.Controls.Add(this.picColorWindow);
            this.Controls.Add(this.lblClothes);
            this.Controls.Add(this.cboParts);
            this.Controls.Add(this.lblParts);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cboClothes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "cboColor";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmTitle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picColorWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picColorText)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboClothes;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.ComboBox cboParts;
        private System.Windows.Forms.Label lblClothes;
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
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkNewman;
        private System.Windows.Forms.CheckBox chkBeast;
        private System.Windows.Forms.CheckBox chkHuman;
        private System.Windows.Forms.CheckBox chkFemaleAoti;
        private System.Windows.Forms.CheckBox chkCast;
        private System.Windows.Forms.Label Color;
        private System.Windows.Forms.ComboBox cboColor1;
    }
}

