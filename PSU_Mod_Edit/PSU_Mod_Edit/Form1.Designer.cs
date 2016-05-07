namespace PSU_Mod_Edit
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clementineSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btnTest = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.cboClothes.MouseEnter += new System.EventHandler(this.cboClothes_MouseEnter);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblParts
            // 
            resources.ApplyResources(this.lblParts, "lblParts");
            this.lblParts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
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
            this.lblClothes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
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
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.informationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clementineSiteToolStripMenuItem,
            this.sendReportsToolStripMenuItem});
            this.informationToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            resources.ApplyResources(this.informationToolStripMenuItem, "informationToolStripMenuItem");
            this.informationToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.informationToolStripMenuItem_MouseDown);
            this.informationToolStripMenuItem.MouseHover += new System.EventHandler(this.informationToolStripMenuItem_MouseHover);
            // 
            // clementineSiteToolStripMenuItem
            // 
            this.clementineSiteToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.clementineSiteToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.clementineSiteToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.clementineSiteToolStripMenuItem.Name = "clementineSiteToolStripMenuItem";
            resources.ApplyResources(this.clementineSiteToolStripMenuItem, "clementineSiteToolStripMenuItem");
            this.clementineSiteToolStripMenuItem.Click += new System.EventHandler(this.clementineSiteToolStripMenuItem_Click);
            // 
            // sendReportsToolStripMenuItem
            // 
            this.sendReportsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sendReportsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.sendReportsToolStripMenuItem.Name = "sendReportsToolStripMenuItem";
            resources.ApplyResources(this.sendReportsToolStripMenuItem, "sendReportsToolStripMenuItem");
            this.sendReportsToolStripMenuItem.Click += new System.EventHandler(this.sendReportsToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorSettingsToolStripMenuItem});
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
            // 
            // colorSettingsToolStripMenuItem
            // 
            this.colorSettingsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.colorSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundToolStripMenuItem,
            this.textToolStripMenuItem,
            this.borderToolStripMenuItem});
            this.colorSettingsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.colorSettingsToolStripMenuItem.Name = "colorSettingsToolStripMenuItem";
            resources.ApplyResources(this.colorSettingsToolStripMenuItem, "colorSettingsToolStripMenuItem");
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.backgroundToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            resources.ApplyResources(this.backgroundToolStripMenuItem, "backgroundToolStripMenuItem");
            this.backgroundToolStripMenuItem.Click += new System.EventHandler(this.backgroundToolStripMenuItem_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            resources.ApplyResources(this.textToolStripMenuItem, "textToolStripMenuItem");
            this.textToolStripMenuItem.Click += new System.EventHandler(this.textToolStripMenuItem_Click);
            // 
            // borderToolStripMenuItem
            // 
            this.borderToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.borderToolStripMenuItem.Name = "borderToolStripMenuItem";
            resources.ApplyResources(this.borderToolStripMenuItem, "borderToolStripMenuItem");
            this.borderToolStripMenuItem.Click += new System.EventHandler(this.borderToolStripMenuItem_Click);
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
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
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
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.chkCast);
            this.groupBox2.Controls.Add(this.chkNewman);
            this.groupBox2.Controls.Add(this.chkBeast);
            this.groupBox2.Controls.Add(this.chkHuman);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
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
            this.Color.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
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
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.Transparent;
            this.btnTest.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            resources.ApplyResources(this.btnTest, "btnTest");
            this.btnTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTest.Name = "btnTest";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnMin, "btnMin");
            this.btnMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMin.Name = "btnMin";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            this.btnMin.MouseLeave += new System.EventHandler(this.btnMin_MouseLeave);
            this.btnMin.MouseHover += new System.EventHandler(this.btnMin_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnMin);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Name = "label1";
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnEdit;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.cboColor1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblClothes);
            this.Controls.Add(this.cboParts);
            this.Controls.Add(this.lblParts);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cboClothes);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.ToolTip toolTip1;
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
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem borderToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

