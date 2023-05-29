using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace serial_prog
{
    public partial class SerialProg : Form
    {
        public SerialProg()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void chkboxSerialSpeed_MouseClick(object sender, MouseEventArgs e)
        {
            chkboxSerialPort.Items.Clear();
            string[] ports=SerialPort.GetPortNames();
            chkboxSerialPort.Items.AddRange(ports);
        }

        private void chkboxSerialSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkboxSerialPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
