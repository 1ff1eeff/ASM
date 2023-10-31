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
    public partial class CreateNode : Form
    {
        public CreateNode()
        {
            InitializeComponent();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            textBox2.Text = listBox1.GetItemText(listBox1.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateIP createIP = new CreateIP();
            createIP.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CreateMAC createMAC = new CreateMAC();
            createMAC.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //ОК
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Отмена
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CreateService createService = new CreateService(); 
            createService.ShowDialog();
        }
    }
}
