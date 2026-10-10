namespace NGUYEN_VU_NHAT_MINH_24810320314_BAI_TAP_5_2
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
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lstAvailableServices = new System.Windows.Forms.ListBox();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lstSelectedServices = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.grpTinhTien = new System.Windows.Forms.GroupBox();
            this.lblTongTienChuaGiamText = new System.Windows.Forms.Label();
            this.lblTongTienChuaGiam = new System.Windows.Forms.Label();
            this.lblChietKhauText = new System.Windows.Forms.Label();
            this.cboChietKhau = new System.Windows.Forms.ComboBox();
            this.lblThanhTienText = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();

            this.grpTinhTien.SuspendLayout();
            this.SuspendLayout();

            // lblCategory
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(15, 15);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(107, 17);
            this.lblCategory.Text = "Chọn loại dịch vụ:";

            // cboCategory
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Items.AddRange(new object[] {
            "Khám bệnh",
            "Xét nghiệm",
            "Chụp X-Quang",
            "Vắc-xin"});
            this.cboCategory.Location = new System.Drawing.Point(130, 12);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(200, 25);
            this.cboCategory.TabIndex = 0;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);

            // lblAvailable
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAvailable.Location = new System.Drawing.Point(15, 50);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(155, 15);
            this.lblAvailable.Text = "Danh sách dịch vụ có sẵn:";

            // lstAvailableServices
            this.lstAvailableServices.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lstAvailableServices.FormattingEnabled = true;
            this.lstAvailableServices.ItemHeight = 17;
            this.lstAvailableServices.Location = new System.Drawing.Point(15, 70);
            this.lstAvailableServices.Name = "lstAvailableServices";
            this.lstAvailableServices.Size = new System.Drawing.Size(220, 208);
            this.lstAvailableServices.TabIndex = 1;
            this.lstAvailableServices.DoubleClick += new System.EventHandler(this.btnSelect_Click);

            // btnSelect (>)
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSelect.Location = new System.Drawing.Point(245, 90);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(50, 35);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = ">";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);

            // btnRemove (<)
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemove.Location = new System.Drawing.Point(245, 140);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(50, 35);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);

            // btnClearAll (<<)
            this.btnClearAll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClearAll.Location = new System.Drawing.Point(245, 190);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(50, 35);
            this.btnClearAll.TabIndex = 4;
            this.btnClearAll.Text = "<<";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);

            // lblSelected
            this.lblSelected.AutoSize = true;
            this.lblSelected.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSelected.Location = new System.Drawing.Point(305, 50);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(155, 15);
            this.lblSelected.Text = "Dịch vụ đã chọn đăng ký:";

            // lstSelectedServices
            this.lstSelectedServices.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lstSelectedServices.FormattingEnabled = true;
            this.lstSelectedServices.ItemHeight = 17;
            this.lstSelectedServices.Location = new System.Drawing.Point(305, 70);
            this.lstSelectedServices.Name = "lstSelectedServices";
            this.lstSelectedServices.Size = new System.Drawing.Size(250, 208);
            this.lstSelectedServices.TabIndex = 5;
            this.lstSelectedServices.DoubleClick += new System.EventHandler(this.btnRemove_Click);

            // grpTinhTien
            this.grpTinhTien.Controls.Add(this.lblThanhTien);
            this.grpTinhTien.Controls.Add(this.lblThanhTienText);
            this.grpTinhTien.Controls.Add(this.cboChietKhau);
            this.grpTinhTien.Controls.Add(this.lblChietKhauText);
            this.grpTinhTien.Controls.Add(this.lblTongTienChuaGiam);
            this.grpTinhTien.Controls.Add(this.lblTongTienChuaGiamText);
            this.grpTinhTien.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpTinhTien.Location = new System.Drawing.Point(15, 290);
            this.grpTinhTien.Name = "grpTinhTien";
            this.grpTinhTien.Size = new System.Drawing.Size(540, 130);
            this.grpTinhTien.TabIndex = 6;
            this.grpTinhTien.TabStop = false;
            this.grpTinhTien.Text = "Tính toán chi phí & Chiết khấu";

            // lblTongTienChuaGiamText
            this.lblTongTienChuaGiamText.AutoSize = true;
            this.lblTongTienChuaGiamText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblTongTienChuaGiamText.Location = new System.Drawing.Point(20, 30);
            this.lblTongTienChuaGiamText.Text = "Tổng tiền chưa giảm:";

            // lblTongTienChuaGiam
            this.lblTongTienChuaGiam.AutoSize = true;
            this.lblTongTienChuaGiam.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongTienChuaGiam.ForeColor = System.Drawing.Color.Black;
            this.lblTongTienChuaGiam.Location = new System.Drawing.Point(160, 28);
            this.lblTongTienChuaGiam.Text = "0 VNĐ";

            // lblChietKhauText
            this.lblChietKhauText.AutoSize = true;
            this.lblChietKhauText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblChietKhauText.Location = new System.Drawing.Point(20, 60);
            this.lblChietKhauText.Text = "Tỷ lệ chiết khấu (%):";

            // cboChietKhau
            this.cboChietKhau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChietKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboChietKhau.FormattingEnabled = true;
            this.cboChietKhau.Items.AddRange(new object[] {
            "0%",
            "5%",
            "10%",
            "15%",
            "20%"});
            this.cboChietKhau.Location = new System.Drawing.Point(160, 57);
            this.cboChietKhau.Name = "cboChietKhau";
            this.cboChietKhau.Size = new System.Drawing.Size(120, 23);
            this.cboChietKhau.TabIndex = 0;
            this.cboChietKhau.SelectedIndexChanged += new System.EventHandler(this.cboChietKhau_SelectedIndexChanged);

            // lblThanhTienText
            this.lblThanhTienText.AutoSize = true;
            this.lblThanhTienText.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblThanhTienText.Location = new System.Drawing.Point(20, 95);
            this.lblThanhTienText.Text = "Thành tiền thanh toán:";

            // lblThanhTien
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblThanhTien.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblThanhTien.Location = new System.Drawing.Point(160, 90);
            this.lblThanhTien.Text = "0 VNĐ";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(572, 435);
            this.Controls.Add(this.grpTinhTien);
            this.Controls.Add(this.lstSelectedServices);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lstAvailableServices);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.lblCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng tính tiền dịch vụ - NGUYỄN VŨ NHẬT MINH";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpTinhTien.ResumeLayout(false);
            this.grpTinhTien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.ListBox lstAvailableServices;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.ListBox lstSelectedServices;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.GroupBox grpTinhTien;
        private System.Windows.Forms.Label lblTongTienChuaGiamText;
        private System.Windows.Forms.Label lblTongTienChuaGiam;
        private System.Windows.Forms.Label lblChietKhauText;
        private System.Windows.Forms.ComboBox cboChietKhau;
        private System.Windows.Forms.Label lblThanhTienText;
        private System.Windows.Forms.Label lblThanhTien;
    }
}