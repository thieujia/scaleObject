using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        private void btn_Input_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txt_input.Text = fbd.SelectedPath;

                }
            }
        }

        private void btn_output_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txt_output.Text = fbd.SelectedPath;

                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {


            try
            {
                var shortcut = "";
                string direc = Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);
                DirectoryInfo di = new DirectoryInfo(direc);
                FileInfo[] files = di.GetFiles("*.lnk");
                foreach (var item in files)
                {
                    if (item.FullName.ToUpper().Contains("Anycubic Photon WorkShop".ToUpper()) || item.FullName.ToUpper().Contains("Anycubic_Photon_WorkShop".ToUpper()))
                    {
                        File.Delete(item.FullName);
                        break;
                    }
                }

                direc = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                di = new DirectoryInfo(direc);
                files = di.GetFiles("*.lnk");
                foreach (var item in files)
                {
                    if (item.FullName.ToUpper().Contains("Anycubic Photon WorkShop".ToUpper()) || item.FullName.ToUpper().Contains("Anycubic_Photon_WorkShop".ToUpper()))
                    {
                        File.Delete(item.FullName);
                    }
                }
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //return;
            }
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\" + modules.companyname);
            //storing the values  
            key.SetValue("input", txt_input.Text);
            key.SetValue("output", txt_output.Text);
            key.SetValue("app", txt_app.Text);
            key.Close();

            Environment.Exit(1);
        }

        private void Config_Load(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\" + modules.companyname);
            if (key != null)
            {
                //storing the values  
                if (key.GetValue("input") != null)
                {
                    txt_input.Text = key.GetValue("input").ToString();
                }
                if (key.GetValue("output") != null)
                {
                    txt_output.Text = key.GetValue("output").ToString();
                }
                if (key.GetValue("app") != null)
                {
                    txt_app.Text = key.GetValue("app").ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_app.Text = openFileDialog1.FileName;
            }
        }
    }
}
