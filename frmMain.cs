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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trangthai1.Text = "Hello World!";
            Form1 f = new Form1();
            f.ShowDialog();
            trangthai1.Text = "Sẵn sàng!";
        }

        private void tínhTổngSốChẵnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLTCoBan f = new frmLTCoBan();
            f.Show();
        }

        private void kếtThúcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýNgườiDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            trangthai1.Text = "Sẵn sàng nhận lệnh!";
            trangthai2.Text = "Người dùng hiện thời: Admin";
        }
        private void uptime()
        {
            trangthai2.Text = System.DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            uptime();
        }

        private void danhMụcHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDMHH f = new frmDMHH();
            f.Show();
        }
    }
}
