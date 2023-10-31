using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM
{
    public partial class CreateIP : Form
    {
        public CreateIP()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ValidateIPv4(textBox1.Text))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Некорректный IP адрес!");
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static bool ValidateIPv4(string ip)
        {
            IPAddress address;
            return ip != null && ip.Count(c => c == '.') == 3 &&
                IPAddress.TryParse(ip, out address);
        }



    }
}
