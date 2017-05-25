using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace UDPClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            string host = txtb_adress.Text;
            int port = Convert.ToInt32(nud_port.Value);
            try
            {
                UdpClient client = new UdpClient(host, port);
                Byte[] dane = Encoding.ASCII.GetBytes(txtb_message.Text);
                client.Send(dane, dane.Length);
                listBox_info.Items.Add("Sending Message");
                client.Close();
            }
            catch(Exception ex)
            {
                listBox_info.Items.Add("ERROR");
                MessageBox.Show(ex.ToString(),"ERROR");
            }
        }
    }
}
