using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NGUYEN_VU_NHAT_MINH_24810320314_BAI_TAP_5_2
{
    public partial class Form1 : Form
    {
        // Lop Doi tuong Dich Vu đe lưu thông tin Ten va Gia
        public class DichVu
        {
            public string TenDichVu { get; set; }
            public long DonGia { get; set; }

            public DichVu(string ten, long gia)
            {
                TenDichVu = ten;
                DonGia = gia;
            }

            public override string ToString()
            {
                return $"{TenDichVu} - {DonGia:N0}đ";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (cboCategory.Items.Count > 0)
                cboCategory.SelectedIndex = 0;

            if (cboChietKhau.Items.Count > 0)
                cboChietKhau.SelectedIndex = 0; // Mặc định 0%
        }

        // 1. Khi thay đổi mục chọn trên ComboBox Category -> Load danh sách tương ứng
        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAvailableServices.Items.Clear();

            string selectedCategory = cboCategory.SelectedItem.ToString();

            switch (selectedCategory)
            {
                case "Khám bệnh":
                    lstAvailableServices.Items.Add(new DichVu("Khám Tổng Quát", 150000));
                    lstAvailableServices.Items.Add(new DichVu("Khám Chuyên Khoa", 250000));
                    lstAvailableServices.Items.Add(new DichVu("Khám Theo Yêu Cầu", 400000));
                    break;

                case "Xét nghiệm":
                    lstAvailableServices.Items.Add(new DichVu("Xét Nghiệm Máu Tổng Phân Tích", 120000));
                    lstAvailableServices.Items.Add(new DichVu("Xét Nghiệm Đường Huyết", 80000));
                    lstAvailableServices.Items.Add(new DichVu("Xét Nghiệm Chức Năng Gan", 200000));
                    break;

                case "Chụp X-Quang":
                    lstAvailableServices.Items.Add(new DichVu("X-Quang Phổi Straight", 180000));
                    lstAvailableServices.Items.Add(new DichVu("X-Quang Cột Sống", 220000));
                    lstAvailableServices.Items.Add(new DichVu("Chụp CT Scanner", 1200000));
                    break;

                case "Vắc-xin":
                    lstAvailableServices.Items.Add(new DichVu("Vắc-xin Cúm Mùa", 350000));
                    lstAvailableServices.Items.Add(new DichVu("Vắc-xin Viêm Gan B", 280000));
                    lstAvailableServices.Items.Add(new DichVu("Vắc-xin Dại", 420000));
                    break;
            }
        }

        // 2. Chuyển chọn item từ Có sẵn (Available) -> Đã chọn (Selected)
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lstAvailableServices.SelectedItem != null)
            {
                DichVu selectedDv = (DichVu)lstAvailableServices.SelectedItem;

                // Kiểm tra xem đã có trong danh sách chọn chưa
                bool exists = false;
                foreach (DichVu item in lstSelectedServices.Items)
                {
                    if (item.TenDichVu == selectedDv.TenDichVu)
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    lstSelectedServices.Items.Add(selectedDv);
                    TinhToanTongTienRealtime();
                }
                else
                {
                    MessageBox.Show("Dịch vụ này đã có trong danh sách chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // 3. Xóa item khỏi danh sách Đã chọn (<)
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSelectedServices.SelectedItem != null)
            {
                lstSelectedServices.Items.Remove(lstSelectedServices.SelectedItem);
                TinhToanTongTienRealtime();
            }
        }

        // 4. Hủy toàn bộ danh sách Đã chọn (<<)
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lstSelectedServices.Items.Clear();
            TinhToanTongTienRealtime();
        }

        private void cboChietKhau_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhToanTongTienRealtime();
        }

        // 5. Tính toán tổng chi phí & thành tiền thanh toán Realtime
        private void TinhToanTongTienRealtime()
        {
            long tongTienChuaGiam = 0;

            foreach (DichVu dv in lstSelectedServices.Items)
            {
                tongTienChuaGiam += dv.DonGia;
            }

            // Lấy % chiết khấu
            int percentage = 0;
            if (cboChietKhau.SelectedItem != null)
            {
                string ckStr = cboChietKhau.SelectedItem.ToString().Replace("%", "");
                int.TryParse(ckStr, out percentage);
            }

            long tienGiam = tongTienChuaGiam * percentage / 100;
            long thanhTien = tongTienChuaGiam - tienGiam;

            lblTongTienChuaGiam.Text = string.Format("{0:N0} VNĐ", tongTienChuaGiam);
            lblThanhTien.Text = string.Format("{0:N0} VNĐ", thanhTien);
        }
    }
}