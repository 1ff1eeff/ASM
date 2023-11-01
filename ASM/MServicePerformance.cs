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
    public partial class MServicePerformance : Form
    {
        public MServicePerformance()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //CheckBox checkBox1 = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            //if (checkBox1.Checked == true)
            //{
            //    label4.Enabled = true;
            //    label5.Enabled = true;
            //    textBox2.Enabled = true;
            //    textBox3.Enabled = true;
            //    button5.Enabled = true;
            //}
            //else
            //{
            //    label4.Enabled = false;
            //    label5.Enabled = false;
            //    textBox2.Enabled = false;
            //    textBox3.Enabled = false;
            //    button5.Enabled = false;
            //}

            panel1.Enabled = checkBox1.Checked;
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
