using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroProject
{
    public partial class Form1 : Form
    {
        KeyboardListener KListener = new KeyboardListener();
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_MOVE = 0x0001;

        public void DoMouseClick()
        {
     
            //move to coordinates


            //perform click            
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            KListener.KeyDown += new RawKeyEventHandler(KListener_KeyDown);

           
        }
                                                                                       
        private void button1_Click(object sender, EventArgs e)
        {
        //    new Thread(() =>
        //    {
        //        Thread.CurrentThread.IsBackground = true;
        //        senderevent();
        //        /* run your code here */
        //        //   turn(10);
        //    }).Start();
        }

        public void turn(int num)
        {

            for (int i = 0; i < num; i++)
            {
                DoMouseClick();
                Thread.Sleep(55);

            }


        }
         public void senderevent()
        {

            //            Thread.Sleep(5000);
           // Thread.Sleep(150);
            VirtualKeyboard.SendKeyDown2(VirtualKeyboard.KeyCode.KEY_D);
            //Thread.Sleep(150);
            //VirtualKeyboard.SendKeyDown2(VirtualKeyboard.KeyCode.KEY_D);
            //Thread.Sleep(150);
            //VirtualKeyboard.SendKeyPress2(VirtualKeyboard.KeyCode.KEY_D);
           


            //SendKeyDown(ConvertKeyToSC(Keys.A), VirtualKeyboard.KeyFlag.KeyDown);
           // Thread.Sleep(150);
            //VirtualKeyboard.SendKeyPress(VirtualKeyboard.KeyCode.KEY_A);//SendKeyDown(ConvertKeyToSC(Keys.A), VirtualKeyboard.KeyFlag.KeyDown);
            //Thread.Sleep(150);
            //VirtualKeyboard.SendKeyPress(VirtualKeyboard.KeyCode.KEY_S);//SendKeyDown(ConvertKeyToSC(Keys.A), VirtualKeyboard.KeyFlag.KeyDown);
            //Thread.Sleep(150); 
            //VirtualKeyboard.SendKeyPress(VirtualKeyboard.KeyCode.KEY_D);//SendKeyDown(ConvertKeyToSC(Keys.A), VirtualKeyboard.KeyFlag.KeyDown);
            //Thread.Sleep(150);
            //VirtualKeyboard.SendKeyPress(VirtualKeyboard.KeyCode.LEFT);//SendKeyDown(ConvertKeyToSC(Keys.A), VirtualKeyboard.KeyFlag.KeyDown);
     
        }


        void KListener_KeyDown(object sender, RawKeyEventArgs args)
        {

            label1.Text = (args.Key.ToString());
            label2.Text = (args.ToString()); // Prints the text of pressed button, takes in account big and small letters. E.g. "Shift+a" => "A"
            if (args.Key==System.Windows.Input.Key.E)
            {
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                  //senderevent();
                    /* run your code here */
                       turn(10);
                }).Start();
             
            }

        }
        [DllImport("User32.dll")]
        private static extern uint MapVirtualKey(uint uCode, uint uMapType);
        private uint ConvertKeyToSC(Keys key)
        {
            uint keyCode = (uint)key;
            uint scanCode = MapVirtualKey(keyCode, 0);
            return scanCode;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
         
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}
