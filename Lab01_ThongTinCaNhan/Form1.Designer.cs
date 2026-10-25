namespace Lab01_ThongTinCaNhan
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblNamSinh = new System.Windows.Forms.Label();
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grpGioiTinh = new System.Windows.Forms.GroupBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpKetQua = new System.Windows.Forms.GroupBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.grpGioiTinh.SuspendLayout();
            this.grpKetQua.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(120, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(275, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÔNG TIN SINH VIÊN";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(30, 65);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(61, 15);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ và tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(120, 62);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(250, 23);
            this.txtHoTen.TabIndex = 2;
            // 
            // lblNamSinh
            // 
            this.lblNamSinh.AutoSize = true;
            this.lblNamSinh.Location = new System.Drawing.Point(30, 105);
            this.lblNamSinh.Name = "lblNamSinh";
            this.lblNamSinh.Size = new System.Drawing.Size(60, 15);
            this.lblNamSinh.TabIndex = 3;
            this.lblNamSinh.Text = "Năm sinh:";
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.Location = new System.Drawing.Point(120, 102);
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(120, 23);
            this.txtNamSinh.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(30, 145);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 142);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 23);
            this.txtEmail.TabIndex = 6;
            // 
            // grpGioiTinh
            // 
            this.grpGioiTinh.Controls.Add(this.radNu);
            this.grpGioiTinh.Controls.Add(this.radNam);
            this.grpGioiTinh.Location = new System.Drawing.Point(120, 180);
            this.grpGioiTinh.Name = "grpGioiTinh";
            this.grpGioiTinh.Size = new System.Drawing.Size(250, 60);
            this.grpGioiTinh.TabIndex = 7;
            this.grpGioiTinh.TabStop = false;
            this.grpGioiTinh.Text = "Giới tính";
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(120, 25);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(41, 19);
            this.radNu.TabIndex = 1;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(20, 25);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(51, 19);
            this.radNam.TabIndex = 0;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(30, 265);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(65, 15);
            this.lblKhoa.TabIndex = 8;
            this.lblKhoa.Text = "Khoa/Lớp:";
            // 
            // cboKhoa
            // 
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(120, 262);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(250, 23);
            this.cboKhoa.TabIndex = 9;
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(60, 310);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(90, 30);
            this.btnHienThi.TabIndex = 10;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(170, 310);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 30);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(280, 310);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 30);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // grpKetQua
            // 
            this.grpKetQua.Controls.Add(this.txtKetQua);
            this.grpKetQua.Location = new System.Drawing.Point(30, 360);
            this.grpKetQua.Name = "grpKetQua";
            this.grpKetQua.Size = new System.Drawing.Size(370, 160);
            this.grpKetQua.TabIndex = 13;
            this.grpKetQua.TabStop = false;
            this.grpKetQua.Text = "Thông tin kết quả";
            // 
            // txtKetQua
            // 
            this.txtKetQua.BackColor = System.Drawing.SystemColors.Info;
            this.txtKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKetQua.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKetQua.Location = new System.Drawing.Point(3, 19);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKetQua.Size = new System.Drawing.Size(364, 138);
            this.txtKetQua.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 541);
            this.Controls.Add(this.grpKetQua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.cboKhoa);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.grpGioiTinh);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtNamSinh);
            this.Controls.Add(this.lblNamSinh);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 01 - Ứng dụng Thông tin Cá nhân";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpGioiTinh.ResumeLayout(false);
            this.grpGioiTinh.PerformLayout();
            this.grpKetQua.ResumeLayout(false);
            this.grpKetQua.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNamSinh;
        private System.Windows.Forms.TextBox txtNamSinh;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox grpGioiTinh;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grpKetQua;
        private System.Windows.Forms.TextBox txtKetQua;
    }
}
