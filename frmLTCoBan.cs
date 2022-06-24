using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH2022
{
    public partial class frmLTCoBan : Form
    {
        int i, n, t;

        private void button4_Click(object sender, EventArgs e){;
            this.Close()
;        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void txtN_KeyDown(object sender, KeyEventArgs e)
        {
            

        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '-') ||
            (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) ==
            13))
                e.Handled = false;
            else e.Handled = true;
        }

        private void frmLTCoBan_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
        }

        public frmLTCoBan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(txtN.Text);
            t = 0;
            for (i=1;i<=n;i++)
            {
                if (i%2==0)
                {
                    t += i;
                }    

            }
            lblKQ.Text = "Tính tổng dùng FOR là:" + Convert.ToString(t);
        }
    }
}
