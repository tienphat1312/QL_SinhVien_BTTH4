using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLogic;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace DemoQLSV
{
    public partial class Form1 : Form
    {
        string path = "..\\..\\Hinh";
        XL_SINHVIEN Bang_SINHVIEN;
        XL_LOP Bang_LOP;
        BindingManagerBase DSSV;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bang_SINHVIEN = new XL_SINHVIEN();
            Bang_LOP = new XL_LOP();
            loadCBLop();
            loadDGVHocSinh();

            txtMsv.DataBindings.Add("text", Bang_SINHVIEN, "MaSv", true);
            txtHoten.DataBindings.Add("text", Bang_SINHVIEN, "HoTen", true);
            dateTimePicker1.DataBindings.Add("text", Bang_SINHVIEN, "NgaySinh", true);
            rdbNam.DataBindings.Add("checked", Bang_SINHVIEN, "GioiTinh", true);
            cbbLop.DataBindings.Add("SelectedValue", Bang_SINHVIEN, "MaLop", true);
            txtDiachi.DataBindings.Add("text", Bang_SINHVIEN, "DiaChi", true);
            pHinh.DataBindings.Add("ImageLocation", Bang_SINHVIEN, "Hinh", true);

            DSSV = this.BindingContext[Bang_SINHVIEN];
            enabledNutLenh(false);
        }

        private void loadCBLop()
        {
            cbbLop.DataSource = Bang_LOP;
            cbbLop.DisplayMember = "TenLop";
            cbbLop.ValueMember = "MaLop";
        }

        private void loadDGVHocSinh()
        {
            dgvHocsinh.AutoGenerateColumns = false;
            dgvHocsinh.DataSource = Bang_SINHVIEN;
        }

        private void enabledNutLenh(bool pCapNhat)
        {
            btnThem.Enabled = !pCapNhat;
            btnSua.Enabled = !pCapNhat;
            btnXoa.Enabled = !pCapNhat;
            btnLuu.Enabled = pCapNhat;
            btnHuy.Enabled = pCapNhat;
            btnThoat.Enabled = !pCapNhat;
        }

        private void rdbNam_CheckedChanged(object sender, EventArgs e)
        {
            rdbNu.Checked = !rdbNam.Checked;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DSSV.AddNew();
            enabledNutLenh(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DSSV.EndCurrentEdit();
                Bang_SINHVIEN.Ghi();
                enabledNutLenh(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DSSV.CancelCurrentEdit();
            Bang_SINHVIEN.RejectChanges();
            enabledNutLenh(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DSSV.RemoveAt(DSSV.Position);
            if (!Bang_SINHVIEN.Ghi())
                MessageBox.Show("Xóa thất bại");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DSSV.EndCurrentEdit();
                Bang_SINHVIEN.Ghi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = Bang_SINHVIEN.Select("MaSv = '" + txtTim.Text + "'")[0];
                DSSV.Position = Bang_SINHVIEN.Rows.IndexOf(dr);
            }
            catch 
            {
                MessageBox.Show("Không tìm thấy");
            }
        }

        private void txtTim_MouseDown(object sender, MouseEventArgs e)
        {
            txtTim.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPG Files|*.jpg|PNG Files|*.png|ALL Files|*.*";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.SafeFileName;
                string pathFile = path + "/" + fileName;
                if (!File.Exists(pathFile))
                    File.Copy(openFileDialog1.FileName, pathFile);
                pHinh.ImageLocation = pathFile;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = Bang_SINHVIEN.Select("MaSv = '" + txtTim.Text + "'")[0];
                DSSV.Position = Bang_SINHVIEN.Rows.IndexOf(dr);
            }
            catch
            {
                MessageBox.Show("Không tìm thấy");
            }
        }


    }
}
