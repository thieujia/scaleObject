using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SetDatetime.Error;

namespace SetDatetime
{
    public partial class Error : Form
    {
        string input = "";
        string output = "";
        string app = "";

        public Error()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\KingSmile");
            if (key == null)
            {
                MessageBox.Show("Please contact to administrator!");
                //input = key.GetValue("input").ToString();
                //output = key.GetValue("output").ToString();
                this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            }


            if (key != null)
            {

                if (key.GetValue("app2") != null)
                {
                    app = key.GetValue("app2").ToString();
                }
            }

        }

        private void Form1_Shown(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(app))
            {

                openapp();

            }


        }


        public void openapp()
        {
            if (!string.IsNullOrEmpty(app))
            {


                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.CreateNoWindow = false;
                startInfo.UseShellExecute = false;
                startInfo.FileName = app;
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                currentdate = DateTime.Now;
                if (currentdate>=DateTime.Parse("2025-01-01"))
                {
                    MessageBox.Show("Invalid license");
                    Environment.Exit(1);
                }
                DateTime date2 = DateTime.Parse("2021-12-31");
                setcurrentdate(date2);
                try
                {
                    // Start the process with the info we specified.
                    // Call WaitForExit and then the using statement will close.
                    using (Process exeProcess = Process.Start(startInfo))
                    {
                     
                        Method1(currentdate);

                    }
                }
                catch
                {
                    // Log error.
                }
            }
        }
        public static void setcurrentdate(DateTime date)
        {
            SystemTime st = new SystemTime();
            st.wYear = (short)date.Year; // must be short
            st.wMonth = (short)date.Month;
            st.wDay = (short)date.Day;
            st.wHour = (short)date.Hour;
            st.wMinute = (short)date.Minute;
            st.wSecond = (short)date.Second;

            Win32SetSystemTime(ref st);
        }
        public  DateTime currentdate = DateTime.Now;
        private static async Task Method1(DateTime date)
        {
            var min = 20;
            System.Threading.Thread.Sleep(min*1000);
            setcurrentdate(date.AddSeconds(min));
            Environment.Exit(0);
        }
        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.C)
            {

                Config searchForm = new Config();
                searchForm.ShowDialog();
            }
        }
        [DllImport("kernel32.dll", EntryPoint = "SetSystemTime", SetLastError = true)]
        public extern static bool Win32SetSystemTime(ref SystemTime sysTime);
        [StructLayout(LayoutKind.Sequential)]
        public struct SystemTime
        {
            public short wYear;
            public short wMonth;
            public short wDayOfWeek;
            public short wDay;
            public short wHour;
            public short wMinute;
            public short wSecond;
            public short wMilliseconds;
        }
    }
}
