using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СУБД__Теплый_дом_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "Проверка подключения (1/2)";
            if(CheckForInternetConnection())
            {
                label2.Text = "Проверка подключения (2/2)";
                if(true)
                {
                    label2.Text = "Подключение...";
                    Size = new System.Drawing.Size(0,0);
                    Hide();
                }
                
            }
            else
            {
                MessageBox.Show("Этот компьютер не подключен к интернету! Проверте подключение!","",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static bool CheckForInternetConnection()
        {
            var ping = new Ping();
            String host = "google.com";
            byte[] buffer = new byte[32];
            int timeout = 1000;
            var options = new PingOptions();
            try
            {
                var reply = ping.Send(host, timeout, buffer, options);
                return reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                return false;
            }
        }
    }
}
