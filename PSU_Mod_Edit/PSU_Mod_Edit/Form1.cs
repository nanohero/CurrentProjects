using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PSU_Mod_Edit
{
    public partial class frmMain : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        CodesManager cm = new CodesManager();
        System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#FF760D");
        MenuItemColorscs mic = new MenuItemColorscs();
       
         ByteManager bm =new ByteManager();
        public frmMain()
        {
            InitializeComponent();
            
            FormBorderStyle = FormBorderStyle.None;
            //mic = new MenuItemColorscs(System.Drawing.Color.Pink);
            mic.col = System.Drawing.Color.Red;
            menuStrip1.Renderer = new ToolStripColorManager(mic);
           
        }
      
        protected override void OnPaint(PaintEventArgs e)
        {
            
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(col);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(0, 0, 1,400));
            myBrush.Dispose();
            formGraphics.Dispose();

            System.Drawing.SolidBrush myBrush2 = new System.Drawing.SolidBrush(col);
          
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush2, new Rectangle(0, 384, 600, 1));
            myBrush.Dispose();
            formGraphics.Dispose();

            System.Drawing.SolidBrush myBrush3 = new System.Drawing.SolidBrush(col);

            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush3, new Rectangle(563, 1, 1, 383));
            myBrush.Dispose();
            formGraphics.Dispose();

            System.Drawing.SolidBrush myBrush4 = new System.Drawing.SolidBrush(col);

            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush4, new Rectangle(0, 0, 613, 1));
            myBrush.Dispose();
            formGraphics.Dispose();
        } 
       
        FrmSendReports fsr = new FrmSendReports();

        int adresss = 0;
       

        private void button1_Click(object sender, EventArgs e)
        {
           
           
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            int length = 0;
            if (chkMale.Checked == true)
            {
                length = 37;
                bm.ByteValueChange(@"male_codes.txt", cm.maleClothes, length, cm.maleClothes);
            }
            if (chkAotiColors.Checked == true)
            {
                length = 35;
                bm.ByteValueChange(@"aoti_codes.txt", cm.aotiColorCodes, length, cm.aotiColors);
            }
            if (chkFemale.Checked == true)
            {
                length = 40;
                bm.ByteValueChange(@"female_codes.txt", cm.femaleCodes, length, cm.femaleClothes);
            }
            if (chkFemaleAoti.Checked == true)
            {
                length = 39;
                bm.ByteValueChange(@"aoti_Female_Codes.txt", cm.aotiFemaleCodes, length, cm.aotiFemale);
            }
            if (chkMaleParts.Checked == true)
            {
                length = 29;
                bm.ByteValueChange(@"male_parts_codes.txt", cm.malePartsCodes, length, cm.maleParts);
            }
            if (chkFemaleParts.Checked == true)
            {
                length = 36;
                bm.ByteValueChange(@"female_parts_codes.txt", cm.femalePartCodes, length, cm.femaleParts);
            }
        }
    
        private void button2_Click(object sender, EventArgs e)
        {
            /*
            if (Process.GetProcessesByName("PsuIlluminus_Clementine").Length > 0)
            {
                MessageBox.Show("psu clem is already running");
            }
            else
            {
                Process.Start(@"C:\SEGA\PHANTASY STAR UNIVERSE Illuminus\PsuIlluminus_Clementine");

            }
             * */
        }
        private void chkMale_CheckedChanged(object sender, EventArgs e)
        {
       
          
            cm.AddClothes(@"male_clothes.txt", cm.maleClothes);
          
            if (chkMale.Checked==true)
            {
                chkFemale.Checked = false;
                chkMaleParts.Checked = false;
                chkFemaleParts.Checked = false;
                chkAotiColors.Checked = false;
                chkFemaleAoti.Checked = false;
            }
        }
        private void chkFemale_CheckedChanged(object sender, EventArgs e)
        {
            cm.AddClothes(@"female_clothes.txt", cm.femaleClothes);
            if (chkFemale.Checked==true)
            {              
                chkMale.Checked = false;
                chkMaleParts.Checked = false;
                chkFemaleParts.Checked = false;
                chkAotiColors.Checked = false;            
            }
        }
        private void chkMaleParts_CheckedChanged(object sender, EventArgs e)
        {
            cm.AddClothes(@"male_parts.txt", cm.maleParts);
            if (chkMaleParts.Checked==true)
            {
                chkMale.Checked = false;
                chkFemale.Checked = false;
                chkFemaleParts.Checked = false;
                chkAotiColors.Checked = false;
                chkFemaleAoti.Checked = false;
            }
        }
        private void chkFemaleParts_CheckedChanged(object sender, EventArgs e)
        {
            cm.AddClothes(@"female_parts.txt", cm.femaleParts);
            if (chkFemaleParts.Checked==true)
            {
                chkMale.Checked = false;
                chkFemale.Checked = false;
                chkMaleParts.Checked = false;
                chkAotiColors.Checked = false;
                chkFemaleAoti.Checked = false;
            }
        }
        private void chkAotiColors_CheckedChanged(object sender, EventArgs e)
        {
            cm.AddClothes(@"aoti_colors.txt", cm.aotiColors);
            if (chkAotiColors.Checked==true)
            {
                chkMale.Checked = false;
                chkFemale.Checked = false;
                chkMaleParts.Checked = false;
                chkFemaleParts.Checked = false;
                chkFemaleAoti.Checked = false;
            }
        }
        private void cFemaleAoti_CheckedChanged(object sender, EventArgs e)
        {
            cm.AddClothes(@"aoti_Female.txt", cm.aotiFemale);
            if (chkFemaleAoti.Checked==true)
            {
                chkMale.Checked = false;
                chkFemale.Checked = false;
                chkMaleParts.Checked = false;
                chkFemaleParts.Checked = false;
                chkAotiColors.Checked = false;               
            }
        }
      
     
      
        private void sendReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fsr.Show();
            fsr.TopMost = true;
        }

        private void clementineSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://psu-clementine.net");
        }
        
  


        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            //var adress =  new IntPtr(0x00B64AAC);
            //var offset = new IntPtr(0x0);
           //var buffer = new byte[4];       
           // AdressCalcualtion(buffer);
            //IntPtr baseAdress = (0x00B64AAC);
            //IntPtr offSet = 0x0;                                                        
        }

       
        private void FindAdress()
        {
            //male  human
            //Top
            if (cboParts.SelectedItem.ToString() == "top" && chkHuman.Checked == true && chkMale.Checked == true || chkAotiColors.Checked == true)
            {
                adresss = 0x0592BB04;
            }
            //Bottom
            if (cboParts.SelectedItem.ToString() == "bottoms" && chkHuman.Checked == true && chkMale.Checked == true)
            {
                adresss = 0x0;
            }
            //shoes
            if (cboParts.SelectedItem.ToString() == "shoes" && chkHuman.Checked == true && chkMale.Checked == true)
            {
                adresss = 0x0;
            }
            //male beast
            //Top
            if (cboParts.SelectedItem.ToString() == "top" && chkBeast.Checked == true && chkMale.Checked == true || chkAotiColors.Checked == true)
            {
                adresss = 0x0;
            }
            //Bottom
            if (cboParts.SelectedItem.ToString() == "bottoms" && chkBeast.Checked == true && chkMale.Checked == true)
            {
                adresss = 0x0;
            }
            //shoes
            if (cboParts.SelectedItem.ToString() == "shoes" && chkBeast.Checked == true && chkMale.Checked == true)
            {
                adresss = 0x0;
            }
            //male newman
            //top
            if (cboParts.SelectedItem.ToString() == "top" && chkNewman.Checked == true && chkMale.Checked == true || chkAotiColors.Checked == true)
            {
                adresss = 0x0;
            }
            //Bottom
            if (cboParts.SelectedItem.ToString() == "bottoms" && chkNewman.Checked == true && chkMale.Checked == true)
            {
                adresss = 0x0;
            }
            //shoes
            if (cboParts.SelectedItem.ToString() == "shoes" && chkNewman.Checked == true && chkMale.Checked == true)
            {
                adresss = 0x0;
            }
            //male cast
            //top
            if (cboParts.SelectedItem.ToString() == "top" && chkCast.Checked == true && chkMale.Checked == true || chkAotiColors.Checked == true)
            {
                adresss = 0x0;
            }
            //Bottom
            if (cboParts.SelectedItem.ToString() == "bottoms" && chkCast.Checked == true && chkMale.Checked == true)
            {
                adresss = 0x0;
            }
            //shoes
            if (cboParts.SelectedItem.ToString() == "shoes" && chkCast.Checked == true && chkMale.Checked == true)
            {
                adresss = 0x0;
            }
            //female human
            //top
            if (cboParts.SelectedItem.ToString() == "top" && chkHuman.Checked == true && chkFemale.Checked == true)
            {
                adresss = 0x0;
            }
            //bottom
            if (cboParts.SelectedItem.ToString() == "bottoms" && chkHuman.Checked == true && chkFemale.Checked == true)
            {
                adresss = 0x0;
            }
            //shoes
            if (cboParts.SelectedItem.ToString() == "shoes" && chkHuman.Checked == true && chkFemale.Checked == true)
            {
                adresss = 0x0;
            }

            //female beast
            //top
            if (cboParts.SelectedItem.ToString() == "top" && chkBeast.Checked == true && chkFemale.Checked == true)
            {
                adresss = 0x0;
            }
            //bottom
            if (cboParts.SelectedItem.ToString() == "bottoms" && chkBeast.Checked == true && chkFemale.Checked == true)
            {
                adresss = 0x0;
            }
            //shoes
            if (cboParts.SelectedItem.ToString() == "shoes" && chkBeast.Checked == true && chkFemale.Checked == true)
            {
                adresss = 0x0;
            }
            //female newman
            //top
            if (cboParts.SelectedItem.ToString() == "top" && chkNewman.Checked == true && chkFemale.Checked == true)
            {
                adresss = 0x0;
            }
            //bottom
            if (cboParts.SelectedItem.ToString() == "bottoms" && chkNewman.Checked == true && chkFemale.Checked == true)
            {
                adresss = 0x0;
            }
            //shoes
            if (cboParts.SelectedItem.ToString() == "shoes" && chkNewman.Checked == true && chkFemale.Checked == true)
            {
                adresss = 0x0;
            }
            //female cast
            //top
            if (cboParts.SelectedItem.ToString() == "top" && chkCast.Checked == true && chkFemale.Checked == true)
            {
                adresss = 0x0;
            }
            //bottom
            if (cboParts.SelectedItem.ToString() == "bottoms" && chkCast.Checked == true && chkFemale.Checked == true)
            {
                adresss = 0x0;
            }
            //shoes
            if (cboParts.SelectedItem.ToString() == "shoes" && chkCast.Checked == true && chkFemale.Checked == true)
            {
                adresss = 0x0;
            }
        }
        private void chkHuman_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHuman.Checked==true)
            {
                chkBeast.Checked = false;
                chkNewman.Checked = false;
                chkCast.Checked = false;
            }
           
        }
        private void chkBeast_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBeast.Checked==true)
            {
                chkHuman.Checked = false;
                chkNewman.Checked = false;
                chkCast.Checked = false;
            }           
        }
        private void chkNewman_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNewman.Checked==true)
            {
                chkHuman.Checked = false;
                chkBeast.Checked = false;
                chkCast.Checked = false;
            }
         
        }
        private void chkCast_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCast.Checked==true)
            {
                chkHuman.Checked = false;
                chkBeast.Checked = false;
                chkNewman.Checked = false;
            }
               
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            cboColor1.Items.Clear();
            if (chkAotiColors.Checked == false && chkFemaleAoti.Checked == false)
            {
                cboColor1.Items.Add("Color Combonation 1");
                cboColor1.Items.Add("Color Combonation 2");
                cboColor1.Items.Add("Color Combonation 3");
                cboColor1.Items.Add("Color Combonation 4");
                cboColor1.Items.Add("Color Combonation 5");
            }

             if (chkAotiColors.Checked == true || chkFemaleAoti.Checked == true)
            {
                cboColor1.Items.Add("Color Combonation 6");
                cboColor1.Items.Add("Color Combonation 7");
                cboColor1.Items.Add("Color Combonation 8");
                cboColor1.Items.Add("Color Combonation 9");
                cboColor1.Items.Add("Color Combonation 10");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("OfflinePSU_Mods").Length > 0)
            {
                MessageBox.Show("psu clem is already running");
            }
            else
            {
                Process.Start(@"C:\SEGA\PHANTASY STAR UNIVERSE Illuminus\PsuIlluminus_Clementine");
            }
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDlg.Color;
            }
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                lblClothes.ForeColor = colorDlg.Color;
                lblParts.ForeColor = colorDlg.Color;
                cboClothes.ForeColor = colorDlg.Color;
                cboParts.ForeColor = colorDlg.Color;
                groupBox1.ForeColor = colorDlg.Color;
                groupBox2.ForeColor = colorDlg.Color;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void btnMin_MouseHover(object sender, EventArgs e)
        {
            btnMin.ForeColor = System.Drawing.Color.Transparent;
        }

        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            btnMin.ForeColor = System.Drawing.Color.FromArgb(255, 128, 0);
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
             btnClose.ForeColor = System.Drawing.Color.Transparent;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.ForeColor = System.Drawing.Color.FromArgb(255, 128, 0);
        }

        private void borderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                col = colorDlg.Color;
            }
        }

        private void informationToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void informationToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void cboClothes_MouseEnter(object sender, EventArgs e)
        {

            cboClothes.DataSource = cm.theBindingSource.DataSource;
        }

   

        


     
    }

   
}
