namespace DemoQLSV
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtMsv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.dgvHocsinh = new System.Windows.Forms.DataGridView();
            this.Masv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pHinh = new System.Windows.Forms.PictureBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnThem = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnSua = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocsinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(477, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.cbbLop);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.rdbNu);
            this.groupBox1.Controls.Add(this.rdbNam);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.txtMsv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.groupBox1.Location = new System.Drawing.Point(77, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(857, 204);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN SINH VIÊN";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(586, 137);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(243, 27);
            this.txtDiachi.TabIndex = 4;
            // 
            // cbbLop
            // 
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(586, 89);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(243, 27);
            this.cbbLop.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(163, 137);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(271, 27);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(730, 39);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(55, 23);
            this.rdbNu.TabIndex = 2;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "NỮ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(624, 39);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(68, 23);
            this.rdbNam.TabIndex = 2;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "NAM";
            this.rdbNam.UseVisualStyleBackColor = true;
            this.rdbNam.CheckedChanged += new System.EventHandler(this.rdbNam_CheckedChanged);
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(163, 92);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(271, 27);
            this.txtHoten.TabIndex = 1;
            // 
            // txtMsv
            // 
            this.txtMsv.Location = new System.Drawing.Point(163, 44);
            this.txtMsv.Name = "txtMsv";
            this.txtMsv.Size = new System.Drawing.Size(271, 27);
            this.txtMsv.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "NGÀY SINH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "HỌ TÊN:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(507, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "ĐỊA CHỈ:";
            this.label7.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(507, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "LỚP: ";
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "GIỚI TÍNH: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "MÃ SINH VIÊN:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTim);
            this.groupBox2.Controls.Add(this.txtTim);
            this.groupBox2.Location = new System.Drawing.Point(77, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(829, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.btnTim.Location = new System.Drawing.Point(425, 28);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(178, 53);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click_1);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(132, 43);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(275, 22);
            this.txtTim.TabIndex = 0;
            this.txtTim.Text = "Nhập vào tên sinh viên cần tìm....";
            this.txtTim.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtTim_MouseDown);
            // 
            // dgvHocsinh
            // 
            this.dgvHocsinh.AllowUserToOrderColumns = true;
            this.dgvHocsinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocsinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Masv,
            this.Hoten,
            this.Ngaysinh,
            this.Gioitinh,
            this.Diachi,
            this.Malop,
            this.Hinh});
            this.dgvHocsinh.Location = new System.Drawing.Point(116, 401);
            this.dgvHocsinh.Name = "dgvHocsinh";
            this.dgvHocsinh.RowTemplate.Height = 24;
            this.dgvHocsinh.Size = new System.Drawing.Size(744, 281);
            this.dgvHocsinh.TabIndex = 3;
            // 
            // Masv
            // 
            this.Masv.DataPropertyName = "MaSV";
            this.Masv.HeaderText = "Mã sinh viên";
            this.Masv.Name = "Masv";
            // 
            // Hoten
            // 
            this.Hoten.DataPropertyName = "HoTen";
            this.Hoten.HeaderText = "Họ tên";
            this.Hoten.Name = "Hoten";
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.DataPropertyName = "NgaySinh";
            this.Ngaysinh.HeaderText = "Ngày sinh";
            this.Ngaysinh.Name = "Ngaysinh";
            // 
            // Gioitinh
            // 
            this.Gioitinh.DataPropertyName = "GioiTinh";
            this.Gioitinh.HeaderText = "Giới tính";
            this.Gioitinh.Name = "Gioitinh";
            // 
            // Diachi
            // 
            this.Diachi.DataPropertyName = "DiaChi";
            this.Diachi.HeaderText = "Địa chỉ";
            this.Diachi.Name = "Diachi";
            // 
            // Malop
            // 
            this.Malop.DataPropertyName = "MaLop";
            this.Malop.HeaderText = "Mã lớp";
            this.Malop.Name = "Malop";
            // 
            // Hinh
            // 
            this.Hinh.DataPropertyName = "Hinh";
            this.Hinh.HeaderText = "Hình";
            this.Hinh.Name = "Hinh";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pHinh
            // 
            this.pHinh.Location = new System.Drawing.Point(978, 67);
            this.pHinh.Name = "pHinh";
            this.pHinh.Size = new System.Drawing.Size(257, 204);
            this.pHinh.TabIndex = 4;
            this.pHinh.TabStop = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1013, 302);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(192, 62);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Chọn hình";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // sbtnThem
            // 
            this.sbtnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.sbtnThem.Appearance.Options.UseFont = true;
            this.sbtnThem.Image = ((System.Drawing.Image)(resources.GetObject("sbtnThem.Image")));
            this.sbtnThem.Location = new System.Drawing.Point(966, 431);
            this.sbtnThem.Name = "sbtnThem";
            this.sbtnThem.Size = new System.Drawing.Size(148, 55);
            this.sbtnThem.TabIndex = 8;
            this.sbtnThem.Text = "Thêm";
            this.sbtnThem.Click += new System.EventHandler(this.sbtnThem_Click);
            // 
            // sbtnSua
            // 
            this.sbtnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.sbtnSua.Appearance.Options.UseFont = true;
            this.sbtnSua.Image = ((System.Drawing.Image)(resources.GetObject("sbtnSua.Image")));
            this.sbtnSua.Location = new System.Drawing.Point(966, 584);
            this.sbtnSua.Name = "sbtnSua";
            this.sbtnSua.Size = new System.Drawing.Size(148, 55);
            this.sbtnSua.TabIndex = 8;
            this.sbtnSua.Text = "Sửa";
            this.sbtnSua.Click += new System.EventHandler(this.sbtnSua_Click);
            // 
            // sbtnXoa
            // 
            this.sbtnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.sbtnXoa.Appearance.Options.UseFont = true;
            this.sbtnXoa.Image = ((System.Drawing.Image)(resources.GetObject("sbtnXoa.Image")));
            this.sbtnXoa.Location = new System.Drawing.Point(966, 510);
            this.sbtnXoa.Name = "sbtnXoa";
            this.sbtnXoa.Size = new System.Drawing.Size(148, 55);
            this.sbtnXoa.TabIndex = 8;
            this.sbtnXoa.Text = "Xóa";
            this.sbtnXoa.Click += new System.EventHandler(this.sbtnXoa_Click);
            // 
            // sbtnLuu
            // 
            this.sbtnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.sbtnLuu.Appearance.Options.UseFont = true;
            this.sbtnLuu.Image = ((System.Drawing.Image)(resources.GetObject("sbtnLuu.Image")));
            this.sbtnLuu.Location = new System.Drawing.Point(1132, 431);
            this.sbtnLuu.Name = "sbtnLuu";
            this.sbtnLuu.Size = new System.Drawing.Size(148, 55);
            this.sbtnLuu.TabIndex = 8;
            this.sbtnLuu.Text = "Lưu";
            this.sbtnLuu.Click += new System.EventHandler(this.sbtnLuu_Click);
            // 
            // sbtnHuy
            // 
            this.sbtnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.sbtnHuy.Appearance.Options.UseFont = true;
            this.sbtnHuy.Image = ((System.Drawing.Image)(resources.GetObject("sbtnHuy.Image")));
            this.sbtnHuy.Location = new System.Drawing.Point(1132, 510);
            this.sbtnHuy.Name = "sbtnHuy";
            this.sbtnHuy.Size = new System.Drawing.Size(148, 55);
            this.sbtnHuy.TabIndex = 8;
            this.sbtnHuy.Text = "Hủy";
            this.sbtnHuy.Click += new System.EventHandler(this.sbtnHuy_Click);
            // 
            // sbtnThoat
            // 
            this.sbtnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.sbtnThoat.Appearance.Options.UseFont = true;
            this.sbtnThoat.Image = ((System.Drawing.Image)(resources.GetObject("sbtnThoat.Image")));
            this.sbtnThoat.Location = new System.Drawing.Point(1132, 584);
            this.sbtnThoat.Name = "sbtnThoat";
            this.sbtnThoat.Size = new System.Drawing.Size(148, 55);
            this.sbtnThoat.TabIndex = 8;
            this.sbtnThoat.Text = "Thoát";
            this.sbtnThoat.Click += new System.EventHandler(this.sbtnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 694);
            this.Controls.Add(this.sbtnThoat);
            this.Controls.Add(this.sbtnHuy);
            this.Controls.Add(this.sbtnXoa);
            this.Controls.Add(this.sbtnLuu);
            this.Controls.Add(this.sbtnSua);
            this.Controls.Add(this.sbtnThem);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.pHinh);
            this.Controls.Add(this.dgvHocsinh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocsinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtMsv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.DataGridView dgvHocsinh;
        private System.Windows.Forms.PictureBox pHinh;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hinh;
        private System.Windows.Forms.Button btnTim;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton sbtnThem;
        private DevExpress.XtraEditors.SimpleButton sbtnSua;
        private DevExpress.XtraEditors.SimpleButton sbtnXoa;
        private DevExpress.XtraEditors.SimpleButton sbtnLuu;
        private DevExpress.XtraEditors.SimpleButton sbtnHuy;
        private DevExpress.XtraEditors.SimpleButton sbtnThoat;
    }
}

