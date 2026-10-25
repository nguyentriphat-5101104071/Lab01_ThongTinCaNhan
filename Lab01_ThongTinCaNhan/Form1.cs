using System;
using System.Windows.Forms;

namespace Lab01_ThongTinCaNhan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboKhoa.Items.Add("Công nghệ thông tin");
            cboKhoa.Items.Add("Kinh tế - Quản trị");
            cboKhoa.Items.Add("Ngoại ngữ");
            cboKhoa.Items.Add("Điện tử - Viễn thông");
            cboKhoa.SelectedIndex = -1;
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Họ tên không được rỗng!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                return;
            }

            string strNamSinh = txtNamSinh.Text.Trim();
            if (string.IsNullOrEmpty(strNamSinh))
            {
                MessageBox.Show("Năm sinh không được rỗng!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNamSinh.Focus();
                return;
            }

            if (!int.TryParse(strNamSinh, out int namSinh))
            {
                MessageBox.Show("Năm sinh phải là một số nguyên hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNamSinh.Focus();
                txtNamSinh.SelectAll();
                return;
            }

            int namHienTai = DateTime.Now.Year;
            if (namSinh < 1900 || namSinh > namHienTai)
            {
                MessageBox.Show($"Năm sinh phải nằm trong khoảng từ 1900 đến {namHienTai}!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNamSinh.Focus();
                txtNamSinh.SelectAll();
                return;
            }

            string email = txtEmail.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email không được rỗng!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            string gioiTinh = "";
            if (radNam.Checked)
            {
                gioiTinh = "Nam";
            }
            else if (radNu.Checked)
            {
                gioiTinh = "Nữ";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cboKhoa.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Khoa hoặc Lớp!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboKhoa.DroppedDown = true;
                return;
            }
            string khoaLop = cboKhoa.SelectedItem.ToString();

            int tuoi = namHienTai - namSinh;
            string ketQua = "THÔNG TIN SINH VIÊN\r\n" +
                            $"Họ tên: {hoTen}\r\n" +
                            $"Tuổi: {tuoi}\r\n" +
                            $"Email: {email}\r\n" +
                            $"Giới tính: {gioiTinh}\r\n" +
                            $"Khoa/Lớp: {khoaLop}";

            txtKetQua.Text = ketQua;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtNamSinh.Clear();
            txtEmail.Clear();
            radNam.Checked = false;
            radNu.Checked = false;
            cboKhoa.SelectedIndex = -1;
            txtKetQua.Clear();
            txtHoTen.Focus(); 
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn thoát chương trình không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}