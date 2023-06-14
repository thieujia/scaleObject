using Aspose.ThreeD;
using Aspose.ThreeD.Entities;
using Aspose.ThreeD.Utilities;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace WindowsFormsApp4
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
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\"+modules.companyname);
            if (key == null)
            {
                MessageBox.Show("Please contact to administrator!");
                //input = key.GetValue("input").ToString();
                //output = key.GetValue("output").ToString();
                this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            }
            else
            {



                if (key.GetValue("input") != null)
                {
                    input = key.GetValue("input").ToString();
                }
                if (key.GetValue("output") != null)
                {
                    output = key.GetValue("output").ToString();
                }
                if (key.GetValue("app") != null)
                {
                    app = key.GetValue("app").ToString();
                }
            }

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            try
            {

         
            if (!string.IsNullOrEmpty(input))
            {
                DirectoryInfo di = new DirectoryInfo(input);
                FileInfo[] files = di.GetFiles("*.stl");
                var n = files.Count();
                progressBar1.Maximum = n+1;
                progressBar1.Value = 1;
                for (int i = 0; i < n; i++)
                {
                    System.Threading.Thread.Sleep(1000);
                        
                    Scene scene = new Scene(files[i].FullName);
                    PolygonModifier.Scale(scene, new Vector3(1.005, 1.005, 1));
                    scene.Save(files[i].FullName.Replace(input, output), FileFormat.STLBinary);
                    File.Delete(files[i].FullName);
                        progressBar1.Value = progressBar1.Value + 1;

                    }
                progressBar1.Value = n;
                openapp();


            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void openapp()
        {
            if (!string.IsNullOrEmpty(app))
            {


                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.CreateNoWindow = false;
                startInfo.UseShellExecute = false;
                startInfo.FileName = app;
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;

                try
                {
                    // Start the process with the info we specified.
                    // Call WaitForExit and then the using statement will close.
                    using (Process exeProcess = Process.Start(startInfo))
                    {
                        exeProcess.Close();
                        Environment.Exit(0);
                    }
                }
                catch  (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.C)
            {

                Config searchForm = new Config();
                searchForm.ShowDialog();
            }
        }
    }
}
