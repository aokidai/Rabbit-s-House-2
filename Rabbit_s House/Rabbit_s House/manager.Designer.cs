﻿namespace Rabbit_s_House
{
    partial class frmManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManager));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giamgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tolSpInsert = new System.Windows.Forms.ToolStripButton();
            this.tolSpEdit = new System.Windows.Forms.ToolStripButton();
            this.tolSpDelete = new System.Windows.Forms.ToolStripButton();
            this.tolSpSave = new System.Windows.Forms.ToolStripButton();
            this.tolSpCannel = new System.Windows.Forms.ToolStripButton();
            this.tolSpPrint = new System.Windows.Forms.ToolStripButton();
            this.txtError = new System.Windows.Forms.TextBox();
            this.gKhachHang = new System.Windows.Forms.GroupBox();
            this.cmbGiamGia = new System.Windows.Forms.ComboBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.dav = new System.Windows.Forms.Button();
            this.nn = new System.Windows.Forms.Button();
            this.cf = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.gKhachHang.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "2cf3de1421350014af841348e8a1b0fb.jpg");
            this.imageList1.Images.SetKeyName(1, "440px-Pancake_of_the_phases_of_the_moon.jpg");
            this.imageList1.Images.SetKeyName(2, "640x640_rect_79439140.jpg");
            this.imageList1.Images.SetKeyName(3, "1566702464-5-thumbnail.jpg");
            this.imageList1.Images.SetKeyName(4, "bac_siu.jpg");
            this.imageList1.Images.SetKeyName(5, "cach-lam-sinh-to-bo-ngon-khong-bi-dang-cuc-don-gian-4-1587467278-979-width512heig" +
        "ht512.jpg");
            this.imageList1.Images.SetKeyName(6, "cafe-sua-nong_min.jpg");
            this.imageList1.Images.SetKeyName(7, "caramel-da-xay-1545123727.jpg");
            this.imageList1.Images.SetKeyName(8, "cach-lam-sinh-to-bo-ngon-khong-bi-dang-cuc-don-gian-4-1587467278-979-width512heig" +
        "ht512.jpg");
            this.imageList1.Images.SetKeyName(9, "coca-sleek-330ml-3_grande.png");
            this.imageList1.Images.SetKeyName(10, "den2.jpg");
            this.imageList1.Images.SetKeyName(11, "download.jpg");
            this.imageList1.Images.SetKeyName(12, "green_sbov.jpg");
            this.imageList1.Images.SetKeyName(13, "hhh.jpg");
            this.imageList1.Images.SetKeyName(14, "images (1).jpg");
            this.imageList1.Images.SetKeyName(15, "images.jpg");
            this.imageList1.Images.SetKeyName(16, "Ka2_17-1024x576.jpg");
            this.imageList1.Images.SetKeyName(17, "Nước_Ngọt_Mirinda_Green_Cream_Flavor__330m_.jpg");
            this.imageList1.Images.SetKeyName(18, "nuoc-ngot-7up-thai-lon-330ml.jpg");
            this.imageList1.Images.SetKeyName(19, "nuoc-ngot-sprite-chai-390ml.png");
            this.imageList1.Images.SetKeyName(20, "recipe1615-prepare-step3-636520093053653228.jpg");
            this.imageList1.Images.SetKeyName(21, "recipe9014-prepare-step3-635615012214478617.jpg");
            this.imageList1.Images.SetKeyName(22, "thung-nuoc-ngot-fanta-cam-my-loc-12-lon-1-510x510.jpg");
            this.imageList1.Images.SetKeyName(23, "unnamed.jpg");
            this.imageList1.Images.SetKeyName(24, "yamamoto-mattcha-cafe.jpg");
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenKH,
            this.Sdt,
            this.TenMon,
            this.SoLuong,
            this.Gia,
            this.Giamgia,
            this.NgayBan});
            this.dgvHoaDon.Location = new System.Drawing.Point(317, 49);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.Size = new System.Drawing.Size(754, 602);
            this.dgvHoaDon.TabIndex = 4;
            // 
            // TenKH
            // 
            this.TenKH.HeaderText = "Tên khách Hàng";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            this.TenKH.Width = 150;
            // 
            // Sdt
            // 
            this.Sdt.HeaderText = "Số Điện Thoại";
            this.Sdt.MinimumWidth = 6;
            this.Sdt.Name = "Sdt";
            this.Sdt.Width = 125;
            // 
            // TenMon
            // 
            this.TenMon.HeaderText = "Tên Món";
            this.TenMon.MinimumWidth = 6;
            this.TenMon.Name = "TenMon";
            this.TenMon.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 50;
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Giá Tiền";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.Width = 125;
            // 
            // Giamgia
            // 
            this.Giamgia.HeaderText = "Giảm Giá";
            this.Giamgia.MinimumWidth = 6;
            this.Giamgia.Name = "Giamgia";
            this.Giamgia.Width = 60;
            // 
            // NgayBan
            // 
            this.NgayBan.HeaderText = "Ngày Bán";
            this.NgayBan.MinimumWidth = 6;
            this.NgayBan.Name = "NgayBan";
            this.NgayBan.Width = 125;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tolSpInsert,
            this.tolSpEdit,
            this.tolSpDelete,
            this.tolSpSave,
            this.tolSpCannel,
            this.tolSpPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1370, 47);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tolSpInsert
            // 
            this.tolSpInsert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tolSpInsert.Image = global::Rabbit_s_House.Properties.Resources.icons8_挿入_60;
            this.tolSpInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolSpInsert.Name = "tolSpInsert";
            this.tolSpInsert.Size = new System.Drawing.Size(44, 44);
            this.tolSpInsert.Text = "Insert";
            this.tolSpInsert.Click += new System.EventHandler(this.tolSpInsert_Click);
            // 
            // tolSpEdit
            // 
            this.tolSpEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tolSpEdit.Image = global::Rabbit_s_House.Properties.Resources.icons8_鉛筆_48;
            this.tolSpEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolSpEdit.Name = "tolSpEdit";
            this.tolSpEdit.Size = new System.Drawing.Size(44, 44);
            this.tolSpEdit.Text = "Edit";
            this.tolSpEdit.Click += new System.EventHandler(this.tolSpEdit_Click);
            // 
            // tolSpDelete
            // 
            this.tolSpDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tolSpDelete.Image = global::Rabbit_s_House.Properties.Resources.icons8_削除_52;
            this.tolSpDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolSpDelete.Name = "tolSpDelete";
            this.tolSpDelete.Size = new System.Drawing.Size(44, 44);
            this.tolSpDelete.Text = "Delete";
            this.tolSpDelete.Click += new System.EventHandler(this.tolSpDelete_Click);
            // 
            // tolSpSave
            // 
            this.tolSpSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tolSpSave.Image = global::Rabbit_s_House.Properties.Resources.icons8_セーブ_50;
            this.tolSpSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolSpSave.Name = "tolSpSave";
            this.tolSpSave.Size = new System.Drawing.Size(44, 44);
            this.tolSpSave.Text = "Save";
            this.tolSpSave.Click += new System.EventHandler(this.tolSpSave_Click);
            // 
            // tolSpCannel
            // 
            this.tolSpCannel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tolSpCannel.Image = global::Rabbit_s_House.Properties.Resources.icons8_元に戻す_48;
            this.tolSpCannel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolSpCannel.Name = "tolSpCannel";
            this.tolSpCannel.Size = new System.Drawing.Size(44, 44);
            this.tolSpCannel.Text = "Cannel";
            this.tolSpCannel.Click += new System.EventHandler(this.tolSpCannel_Click);
            // 
            // tolSpPrint
            // 
            this.tolSpPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tolSpPrint.Image = global::Rabbit_s_House.Properties.Resources.icons8_プリント_48;
            this.tolSpPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolSpPrint.Name = "tolSpPrint";
            this.tolSpPrint.Size = new System.Drawing.Size(44, 44);
            this.tolSpPrint.Text = "Print";
            // 
            // txtError
            // 
            this.txtError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtError.Location = new System.Drawing.Point(17, 637);
            this.txtError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(1331, 13);
            this.txtError.TabIndex = 6;
            // 
            // gKhachHang
            // 
            this.gKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.gKhachHang.Controls.Add(this.cmbGiamGia);
            this.gKhachHang.Controls.Add(this.txtSDT);
            this.gKhachHang.Controls.Add(this.label4);
            this.gKhachHang.Controls.Add(this.label3);
            this.gKhachHang.Controls.Add(this.txtHoTen);
            this.gKhachHang.Controls.Add(this.label2);
            this.gKhachHang.Controls.Add(this.txtMaKH);
            this.gKhachHang.Controls.Add(this.label1);
            this.gKhachHang.Location = new System.Drawing.Point(1087, 80);
            this.gKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gKhachHang.Name = "gKhachHang";
            this.gKhachHang.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gKhachHang.Size = new System.Drawing.Size(258, 548);
            this.gKhachHang.TabIndex = 7;
            this.gKhachHang.TabStop = false;
            this.gKhachHang.Text = "Khách Hàng";
            // 
            // cmbGiamGia
            // 
            this.cmbGiamGia.FormattingEnabled = true;
            this.cmbGiamGia.Location = new System.Drawing.Point(63, 144);
            this.cmbGiamGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGiamGia.Name = "cmbGiamGia";
            this.cmbGiamGia.Size = new System.Drawing.Size(171, 21);
            this.cmbGiamGia.TabIndex = 2;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(63, 106);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(183, 20);
            this.txtSDT.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giảm giá";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số ĐT";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(63, 68);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(183, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(63, 31);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(183, 20);
            this.txtMaKH.TabIndex = 1;
            this.txtMaKH.TextChanged += new System.EventHandler(this.txtMaKH_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã KH";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(1150, 13);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(161, 20);
            this.txtTimKiem.TabIndex = 8;
            this.txtTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimKiem_KeyPress);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.dav);
            this.panel1.Controls.Add(this.nn);
            this.panel1.Controls.Add(this.cf);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 602);
            this.panel1.TabIndex = 9;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SidePanel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(19, 37);
            this.SidePanel.TabIndex = 9;
            // 
            // dav
            // 
            this.dav.Location = new System.Drawing.Point(0, 96);
            this.dav.Name = "dav";
            this.dav.Size = new System.Drawing.Size(104, 37);
            this.dav.TabIndex = 6;
            this.dav.Text = "Đồ ăn vặt";
            this.dav.UseVisualStyleBackColor = true;
            this.dav.Click += new System.EventHandler(this.dav_Click);
            // 
            // nn
            // 
            this.nn.Location = new System.Drawing.Point(0, 47);
            this.nn.Name = "nn";
            this.nn.Size = new System.Drawing.Size(104, 37);
            this.nn.TabIndex = 7;
            this.nn.Text = "Nước Ngọt";
            this.nn.UseVisualStyleBackColor = true;
            this.nn.Click += new System.EventHandler(this.nn_Click);
            // 
            // cf
            // 
            this.cf.Location = new System.Drawing.Point(0, 0);
            this.cf.Name = "cf";
            this.cf.Size = new System.Drawing.Size(104, 37);
            this.cf.TabIndex = 8;
            this.cf.Text = "cafe";
            this.cf.UseVisualStyleBackColor = true;
            this.cf.Click += new System.EventHandler(this.cf_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(113, 55);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(198, 499);
            this.listView1.TabIndex = 10;
            this.listView1.TileSize = new System.Drawing.Size(50, 50);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rabbit_s_House.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1370, 629);
            this.ControlBox = false;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.gKhachHang);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvHoaDon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.frmManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gKhachHang.ResumeLayout(false);
            this.gKhachHang.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvHoaDon;

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tolSpInsert;
        private System.Windows.Forms.ToolStripButton tolSpEdit;
        private System.Windows.Forms.ToolStripButton tolSpDelete;
        private System.Windows.Forms.ToolStripButton tolSpSave;
        private System.Windows.Forms.ToolStripButton tolSpCannel;
        private System.Windows.Forms.ToolStripButton tolSpPrint;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.GroupBox gKhachHang;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGiamGia;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giamgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBan;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button dav;
        private System.Windows.Forms.Button nn;
        private System.Windows.Forms.Button cf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
    }
}