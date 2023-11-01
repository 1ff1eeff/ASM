using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM
{
    public partial class CreateTest : Form
    {
        public CreateTest()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MAvailability mAvailability = new MAvailability();
            mAvailability.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MResponseTime mResponseTime = new MResponseTime();
            mResponseTime.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MPacketLoss mPacketLoss = new MPacketLoss();
            mPacketLoss.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MServicePerformance mServicePerformance = new MServicePerformance();
            mServicePerformance.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
