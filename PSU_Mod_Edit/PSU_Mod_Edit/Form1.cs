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
    public partial class cboColor : Form
    {
        public cboColor()
        {
            InitializeComponent();
        }
        //import win api functions
        const int PROCES_WM_READ = 0x0010;
        const int PROCESS_VM_WRITE = 0x0020;
        const int PROCESS_VM_OPERSTION = 0x0008;
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAcess, bool bInheritHandle, int dwProcessId);
        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, int lpBaseAdress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(int hProcess, int lpBaseAdress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);
        Process psu = Process.GetProcessesByName("PsuIlluminus_Clementine")[0];
        FrmSendReports fsr = new FrmSendReports();
        int byteValue = 1;
        int adresss = 0;
        string line;
        string[] malesClothes = new string[37];
        string[] malesCodes = new string[37];
        string[] femaleClothes = new string[40];
        string[] femaleCodes = new string[40];
        string[] maleParts = new string[29];
        string[] malePartsCodes = new string[29];
        string[] femaleParts = new string[36];
        string[] femalePartsodes = new string[36];
        string[] aotiColors = new string[35];
        string[] aotiColorCodes = new string[35];
        string[] aotiFemale = new string[39];
        string[] aotiFemaleCodes = new string[39];

        private void button1_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("PsuIlluminus_Clementine").Length > 0)
            {
                MessageBox.Show("psu clem is already running");
            }
            else
            {
                Process.Start(@"C:\SEGA\PHANTASY STAR UNIVERSE Illuminus\PsuIlluminus_Clementine");
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int length = 0;
            if (chkMale.Checked == true)
            {
                length = 37;
                ByteValueChange(@"male_codes.txt", malesCodes, length, malesClothes);
            }
            if (chkAotiColors.Checked == true)
            {
                length = 35;
                ByteValueChange(@"aoti_codes.txt", aotiColorCodes, length, aotiColors);
            }
            if (chkFemale.Checked == true)
            {
                length = 40;
                ByteValueChange(@"female_codes.txt", femaleCodes, length, femaleClothes);
            }
            if (chkFemaleAoti.Checked == true)
            {
                length = 39;
                ByteValueChange(@"aoti_Female_Codes.txt", aotiFemaleCodes, length, aotiFemale);
            }
            if (chkMaleParts.Checked == true)
            {
                length = 29;
                ByteValueChange(@"male_parts_codes.txt", malePartsCodes, length, maleParts);
            }
            if (chkFemaleParts.Checked == true)
            {
                length = 36;
                ByteValueChange(@"female_parts_codes.txt", femalePartsodes, length, femaleParts);
            }
        }
        private void ByteValueChange(string name, string[] codesArray, int length, string[] clothesArray)
        {
            int i = 0;
            System.IO.StreamReader file = new System.IO.StreamReader(name);
            while ((line = file.ReadLine()) != null)
            {
                codesArray[i] = line;
                i++;
            }
            file.Close();
            for (int j = 0; j < length; j++)
            {
                if (cboClothes.SelectedItem.ToString() == clothesArray[j])
                {
                    try
                    {
                        byteValue = Convert.ToInt32(codesArray[j]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            //MessageBox.Show(byteValue.ToString());
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
        private void AddClothes(string fileName, string[] clothesArray)
        {
            int i = 0;
            System.IO.StreamReader file = new System.IO.StreamReader(fileName);
            while ((line = file.ReadLine()) != null)
            {
                clothesArray[i] = line;
                i++;
            }
            file.Close();
            BindingSource theBindingSource = new BindingSource();
            theBindingSource.DataSource = clothesArray;
            cboClothes.DataSource = theBindingSource.DataSource;
        }
        private void chkMale_CheckedChanged(object sender, EventArgs e)
        {
            AddClothes(@"male_clothes.txt", malesClothes);
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
            AddClothes(@"female_clothes.txt", femaleClothes);
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
            AddClothes(@"male_parts.txt", maleParts);
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
            AddClothes(@"female_parts.txt", femaleParts);
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
            AddClothes(@"aoti_colors.txt", aotiColors);
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
            AddClothes(@"aoti_Female.txt", aotiFemale);
            if (chkFemaleAoti.Checked==true)
            {
                chkMale.Checked = false;
                chkFemale.Checked = false;
                chkMaleParts.Checked = false;
                chkFemaleParts.Checked = false;
                chkAotiColors.Checked = false;               
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDlg.Color;
            }
        }
        private void frmTitle_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.picColorWindow, "Change window color");
            toolTip2.SetToolTip(this.picColorText, "Change text color");
        }
        private void picColorText_Click(object sender, EventArgs e)
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
            Process psu = Process.GetProcessesByName("PsuIlluminus_Clementine")[0];
            IntPtr Handle = OpenProcess(0x01F0FFF, false, psu.Id);
            int bytesWritten =0;
            byte[] buffer = new byte[1];
            buffer[0] = (byte)Convert.ToInt32(byteValue);
         
            try
            {
                FindAdress();
                WriteProcessMemory((int)Handle, 0x05802B05, buffer, buffer.Length, ref bytesWritten);
            }
            catch (Exception ex)
            {
                MessageBox.Show("You don't have permision to write to the memory");
            }
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
    }
}
