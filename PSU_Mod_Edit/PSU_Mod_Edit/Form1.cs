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
    public partial class frmTitle : Form
    {
        public frmTitle()
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
        [DllImport("kernel32.dll",SetLastError = true)]
        static extern bool WriteProcessMemory(int hProcess, int lpBaseAdress, byte[] lpBuffer, int dwSize,ref int lpNumberOfBytesWritten );
        Process psu = Process.GetProcessesByName("PsuIlluminus_Clementine")[0];
        int byteValue=0;
        string line;
     string [] malesClothes=new string[37];
     string[] malesClothes2 = new string[37];
     string []femaleClothes=new string[40];
     string[] maleParts = new string[29];
     string[] femaleParts = new string[36];
     string[] aotiColors = new string[35];
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
            if (chkMale.Checked==true)
            {
                ByteValueChangeMale();
            }
            if (chkFemale.Checked==true)
            {
                
            }
               
        }

        private void ByteValueChangeMale()
        {
            if (cboClothes.SelectedItem.ToString() == malesClothes[0])
            {
                byteValue = 00;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[1])
            {
                byteValue = 0x01;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[2])
            {
                byteValue = 0x02;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[3])
            {
                byteValue = 0x03;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[4])
            {
                byteValue = 0x04;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[5])
            {
                byteValue = 0x05;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[6])
            {
                byteValue = 0x06;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[7])
            {
                byteValue = 0x07;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[8])
            {
                byteValue = 0x08;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[9])
            {
                byteValue = 0x09;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[10])
            {
                byteValue = 0x0A;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[11])
            {
                byteValue = 0x0B;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[12])
            {
                byteValue = 0x0C;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[13])
            {
                byteValue = 0x0D;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[14])
            {
                byteValue = 0x0E;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[15])
            {
                byteValue = 0x0F;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[16])
            {
                byteValue = 0x10;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[17])
            {
                byteValue = 0x11;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[18])
            {
                byteValue = 0x12;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[19])
            {
                byteValue = 0x13;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[20])
            {
                byteValue = 0x14;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[21])
            {
                byteValue = 0x15;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[22])
            {
                byteValue = 0x16;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[23])
            {
                byteValue = 0x17;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[24])
            {
                byteValue = 0x18;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[25])
            {
                byteValue = 0x19;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[26])
            {
                byteValue = 0x1A;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[27])
            {
                byteValue = 0x1B;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[28])
            {
                byteValue = 0x1C;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[29])
            {
                byteValue = 0x1D;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[30])
            {
                byteValue = 0x1E;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[31])
            {
                byteValue = 0x1F;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[32])
            {
                byteValue = 0x20;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[33])
            {
                byteValue = 0x21;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[34])
            {
                byteValue = 0x22;
            }
            if (cboClothes.SelectedItem.ToString() == malesClothes[35])
            {
                byteValue = 0x23;
            }               
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
           
            IntPtr Handle = OpenProcess(0x01F0FFF, false, psu.Id);
            int bytesWritten = 0;
            byte[] buffer = new byte[1];
            buffer[0] =(byte)Convert.ToInt32(byteValue);          

            if (cboParts.SelectedItem.ToString() == "top")
            {
                WriteProcessMemory((int)Handle, 0x057E9B05, buffer, buffer.Length, ref bytesWritten);                       
            }           
            if (cboParts.SelectedItem.ToString() == "bottoms")
            {
                WriteProcessMemory((int)Handle, 0x057E9B09, buffer, buffer.Length, ref bytesWritten);                             
            }
            if (cboParts.SelectedItem.ToString() == "shoes")
            {
                WriteProcessMemory((int)Handle, 0x057E9B0D, buffer, buffer.Length, ref bytesWritten);                             
            }          
        }            
        private void cboColor_MouseClick(object sender, MouseEventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();                
            if (colorDlg.ShowDialog()==DialogResult.OK)
            {
                cboColor.BackColor = colorDlg.Color;
            }
        }
        private void chkMale_CheckedChanged(object sender, EventArgs e)
        {
            AddClothes(@"male_clothes.txt",malesClothes);
        }
        private void AddClothes(string fileName,string[] clothesArray)
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
        private void chkFemale_CheckedChanged(object sender, EventArgs e)
        {
            AddClothes(@"female_clothes.txt",femaleClothes);
        }
        private void chkMaleParts_CheckedChanged(object sender, EventArgs e)
        {
            AddClothes(@"male_parts.txt",maleParts);
        }
        private void chkFemaleParts_CheckedChanged(object sender, EventArgs e)
        {
            AddClothes(@"female_parts.txt",femaleParts); 
        }
        private void chkAotiColors_CheckedChanged(object sender, EventArgs e)
        {
            AddClothes(@"aoti_colors.txt",aotiColors);
        }         
    }
}
