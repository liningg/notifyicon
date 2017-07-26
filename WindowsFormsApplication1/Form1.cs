using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //隐藏窗体
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
                this.notifyIcon1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string StartupPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.CommonStartup);
            //获得文件的当前路径  
            string dir = Directory.GetCurrentDirectory();
            //获取可执行文件的全部路径  
            string exeDir = dir + @"\EcgNetPlug.exe.lnk";
            System.IO.File.Copy(exeDir, StartupPath + @"\EcgNetPlug.exe.lnk", true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string StartupPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.CommonStartup);
            System.IO.File.Delete(StartupPath + @"\EcgNetPlug.exe.lnk");
        }
    }
}
