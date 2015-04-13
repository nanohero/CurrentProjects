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
            this.button1 = new System.Windows.Forms.Button();
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
            resources.GetString("cboClothes.Items"),
            resources.GetString("cboClothes.Items1")});
            resources.ApplyResources(this.cboClothes, "cboClothes");
            this.cboClothes.Name = "cboClothes";
            this.cboClothes.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // namLbl
            // 
            resources.ApplyResources(this.namLbl, "namLbl");
            this.namLbl.Name = "namLbl";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // 
            // chkFemale
            // 
            resources.ApplyResources(this.chkFemale, "chkFemale");
            this.chkFemale.Name = "chkFemale";
            this.chkFemale.UseVisualStyleBackColor = true;
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
            // frmTitle
            // 
            this.AcceptButton = this.btnEdit;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.cboColor);
            this.Controls.Add(this.chkFemale);
            this.Controls.Add(this.chkMale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblClothes);
            this.Controls.Add(this.cboParts);
            this.Controls.Add(this.lblParts);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
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
    }
}

