using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSU_Mod_Edit
{
    class ByteManager : CodesManager
    {
        const int PROCES_WM_READ = 0x0010;
        const int PROCESS_VM_WRITE = 0x0020;
        const int PROCESS_VM_OPERSTION = 0x0008;
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAcess, bool bInheritHandle, int dwProcessId);
        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, int lpBaseAdress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(int hProcess, int lpBaseAdress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);
        protected int byteValue{get;set;}
        protected ComboBox cb { get; set; }
        string process;
        public ByteManager()
        {
            byteValue = 0;
            process = "";
        }
        public void ByteValueChange(string name, string[] codesArray, int length, string[] clothesArray)
        {
            String line;
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
                if (cb.SelectedItem.ToString() == clothesArray[j])
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
        public void WriteBytes()
        {
            Process psu = Process.GetProcessesByName(process)[0];
            IntPtr Handle = OpenProcess(0x0F20E4E5, false, psu.Id);
            //FindAdress();
            byte[] buffer = new byte[1];
            int bytesWritten = 0;
            buffer[0] = (byte)Convert.ToInt32(byteValue);
            WriteProcessMemory((int)Handle, 0x0F2CB4E5, buffer, buffer.Length, ref bytesWritten);
        }
    }

}
