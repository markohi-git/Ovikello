using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;

namespace Ovikello2
{
    public partial class Form1 : Form
    {
        private MqttClient client;
        public Form1()
        {
            InitializeComponent();
            client = new MqttClient("127.0.0.1");
            string clientId = Guid.NewGuid().ToString();
            client.Connect(clientId);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.Publish("/ovikello", Encoding.UTF8.GetBytes("ding"), 1, false);
        }
    }
}
