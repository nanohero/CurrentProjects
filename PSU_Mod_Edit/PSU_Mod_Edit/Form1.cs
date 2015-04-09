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
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAcess, bool bInheritHandle, int dwProcessId);
        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, int lpBaseAdress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);
        
        

      
        private void name_Click(object sender, EventArgs e)
        {
        
         
           
                
                Process psu = Process.GetProcessesByName("PsuIlluminus_Clementine")[0];
                IntPtr Handle = OpenProcess(PROCES_WM_READ, false, psu.Id);
                // get number of bytes
                int bytesRead = 0;
                byte[] buffer = new byte[24];
                //reads memory and get's name of player character
                ReadProcessMemory((int)Handle, 0x00B6CA02, buffer, buffer.Length, ref bytesRead);
                //should output charter name in messeage box and label
                //it does not
                namLbl.Text =Encoding.Unicode.GetString(buffer);
                MessageBox.Show(Encoding.Unicode.GetString(buffer));
                MessageBox.Show("test"); //use to test if messeage boxes at all works.This one works.
                
         
            
            
          
            
        }

        

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

    
      
    }
}
