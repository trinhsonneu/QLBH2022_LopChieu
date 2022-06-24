using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLBH2022
{
    public partial class frmDMHH : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr;
        int i;
        public frmDMHH()
        {
            InitializeComponent();
        }

        private void frmDMHH_Load(object sender, EventArgs e)
        {
            constr = "Data Source=SONTRINH-HP\\KTQDSERVER;Initial Catalog=QLBH;"+
                      " Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "Select Manhom, MaHH, TenHH, dvt, dgVnd, SanXuat From tblDMHH";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);// đây laF GHI CHÚ
            grdData.DataSource = dt;
            NapCT();
        }

        private void grdData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdData.CurrentCell = grdData[0, 0];
            NapCT();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            grdData.CurrentCell = grdData[0, grdData.RowCount - 1];
            NapCT();
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            i = grdData.CurrentRow.Index;
            if (i>0)
            {
                grdData.CurrentCell = grdData[0, i - 1];
                NapCT();
            }    
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i = grdData.CurrentRow.Index;
            if (i<grdData.RowCount-1)
            {
                grdData.CurrentCell = grdData[0, i + 1];
                NapCT();
            }    
        }

        private void comTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "select Distinct " + comTruong.Text + " From tblDMHH";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comGT.DataSource = comdt;
            comGT.DisplayMember = comTruong.Text;
            
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (comTruong.Text=="")
            {
                MessageBox.Show("Bạn cần thiết lập điều kiện lọc trước đã!");
             }
            else
            {
                sql = "Select Manhom, MaHH, TenHH, dvt, dgVnd, SanXuat From tblDMHH" +
                      " where " + comTruong.Text + "='" + comGT.Text + "'";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);// đây laF GHI CHÚ
                grdData.DataSource = dt;
                grdData.Refresh();
                NapCT();
            }    
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            sql = "Select Manhom, MaHH, TenHH, dvt, dgVnd, SanXuat From tblDMHH";
                    
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);// đây laF GHI CHÚ
            grdData.DataSource = dt;
            grdData.Refresh();
            NapCT();
        }

        private void NapCT()
        {
            i = grdData.CurrentRow.Index;
            txtmanhom.Text = grdData.Rows[i].Cells["manhom"].Value.ToString();
            txtMaHH.Text= grdData.Rows[i].Cells["mahh"].Value.ToString();
            txtTenHH.Text= grdData.Rows[i].Cells["TenHH"].Value.ToString();
            txtDVT.Text = grdData.Rows[i].Cells["dvt"].Value.ToString();
            txtdgVnd.Text= grdData.Rows[i].Cells["dgVnd"].Value.ToString();
            txtSanXuat.Text= grdData.Rows[i].Cells["sanxuat"].Value.ToString();


        }    
    }
}
