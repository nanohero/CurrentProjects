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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTitle));
            this.name = new System.Windows.Forms.Button();
            this.cboClothes = new System.Windows.Forms.ComboBox();
            this.namLbl = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblParts = new System.Windows.Forms.Label();
            this.cboParts = new System.Windows.Forms.ComboBox();
            this.lblClothes = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.chkMale = new System.Windows.Forms.CheckBox();
            this.chkFemale = new System.Windows.Forms.CheckBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTop = new System.Windows.Forms.TextBox();
            this.txtBottom = new System.Windows.Forms.TextBox();
            this.txtShoes = new System.Windows.Forms.TextBox();
            this.chkMaleParts = new System.Windows.Forms.CheckBox();
            this.chkFemaleParts = new System.Windows.Forms.CheckBox();
            this.chkAotiColors = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // name
            // 
            resources.ApplyResources(this.name, "name");
            this.name.Name = "name";
            this.name.UseVisualStyleBackColor = true;
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
            // namLbl
            // 
            resources.ApplyResources(this.namLbl, "namLbl");
            this.namLbl.Name = "namLbl";
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEdit
            // 
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.button2_Click);
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
            // lblColor
            // 
            resources.ApplyResources(this.lblColor, "lblColor");
            this.lblColor.Name = "lblColor";
            // 
            // cboColor
            // 
            this.cboColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboColor.FormattingEnabled = true;
            resources.ApplyResources(this.cboColor, "cboColor");
            this.cboColor.Name = "cboColor";
            this.cboColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboColor_MouseClick);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtTop
            // 
            resources.ApplyResources(this.txtTop, "txtTop");
            this.txtTop.Name = "txtTop";
            // 
            // txtBottom
            // 
            resources.ApplyResources(this.txtBottom, "txtBottom");
            this.txtBottom.Name = "txtBottom";
            // 
            // txtShoes
            // 
            resources.ApplyResources(this.txtShoes, "txtShoes");
            this.txtShoes.Name = "txtShoes";
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
            // frmTitle
            // 
            this.AcceptButton = this.btnEdit;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkAotiColors);
            this.Controls.Add(this.chkFemaleParts);
            this.Controls.Add(this.chkMaleParts);
            this.Controls.Add(this.txtShoes);
            this.Controls.Add(this.txtBottom);
            this.Controls.Add(this.txtTop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.cboColor);
            this.Controls.Add(this.chkFemale);
            this.Controls.Add(this.chkMale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblClothes);
            this.Controls.Add(this.cboParts);
            this.Controls.Add(this.lblParts);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.namLbl);
            this.Controls.Add(this.cboClothes);
            this.Controls.Add(this.name);
            this.Name = "frmTitle";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button name;
        private System.Windows.Forms.ComboBox cboClothes;
        private System.Windows.Forms.Label namLbl;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.ComboBox cboParts;
        private System.Windows.Forms.Label lblClothes;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.CheckBox chkMale;
        private System.Windows.Forms.CheckBox chkFemale;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTop;
        private System.Windows.Forms.TextBox txtBottom;
        private System.Windows.Forms.TextBox txtShoes;
        private System.Windows.Forms.CheckBox chkMaleParts;
        private System.Windows.Forms.CheckBox chkFemaleParts;
        private System.Windows.Forms.CheckBox chkAotiColors;
    }
}

