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
       
        int byteValue;
      int byteValue2;
     

        

        private void button1_Click(object sender, EventArgs e)
        {
          
                   
            if (Process.GetProcessesByName("PsuIlluminus_Clementine").Length > 0)
            {
                MessageBox.Show("psu clem is already running");
            }          else
            {
                Process.Start(@"C:\SEGA\PHANTASY STAR UNIVERSE Illuminus\PsuIlluminus_Clementine");
          

           
            }
            
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboClothes.SelectedItem.ToString() == "illuminus coat")
            {
                byteValue = 21;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Process psu = Process.GetProcessesByName("PsuIlluminus_Clementine")[0];
            IntPtr Handle = OpenProcess(0x01F0FFF, false, psu.Id);
            int bytesWritten = 0;
            byte[] buffer = BitConverter.GetBytes(byteValue);
            byte[] buffer2 = BitConverter.GetBytes(byteValue2); 
        
            // get number of bytes



            if (cboParts.SelectedItem.ToString() == "top")
            {

                WriteProcessMemory((int)Handle, 0x05C37B05, buffer, buffer.Length, ref bytesWritten);
           
               
            }
            
            if (cboParts.SelectedItem.ToString() == "bottoms")
            {
                byteValue2 = 1;
                WriteProcessMemory((int)Handle, 0x05C37B09, buffer, buffer.Length, ref bytesWritten);
                WriteProcessMemory((int)Handle, 0x05C37B0B, buffer2, buffer2.Length, ref bytesWritten);
                MessageBox.Show("test");
            }

            if (cboParts.SelectedItem.ToString() == "shoes")
            {
                byteValue2 = 2;
                WriteProcessMemory((int)Handle, 0x05C37B0D, buffer, buffer.Length, ref bytesWritten);
                WriteProcessMemory((int)Handle, 0x05C37B0F, buffer2, buffer2.Length, ref bytesWritten);

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

   

    
      
    }
}
