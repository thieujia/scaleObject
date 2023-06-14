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

namespace SetDatetime
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\KingSmile");

            //storing the values  
          
            key.SetValue("app2", txt_app.Text);
            key.Close();
        }

        private void Config_Load(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\KingSmile");

            //storing the values  
            
            if (key.GetValue("app2") != null)
            {
                txt_app.Text = key.GetValue("app2").ToString();
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
