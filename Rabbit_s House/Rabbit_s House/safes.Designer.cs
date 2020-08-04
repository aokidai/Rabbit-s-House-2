namespace Rabbit_s_House
{
    partial class safes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(safes));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tolSpInsert = new System.Windows.Forms.ToolStripButton();
            this.tolSpEdit = new System.Windows.Forms.ToolStripButton();
            this.tolSpDelete = new System.Windows.Forms.ToolStripButton();
            this.tolSpSave = new System.Windows.Forms.ToolStripButton();
            this.tolSpCannel = new System.Windows.Forms.ToolStripButton();
            this.tolSpPrint = new System.Windows.Forms.ToolStripButton();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cboTenNV = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTenKH = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTenMon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(1348, 47);
            this.toolStrip1.TabIndex = 7;
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
            // dgvHD
            // 
            this.dgvHD.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenMon,
            this.Loai,
            this.TenNV,
            this.TenKH,
            this.SoLuong,
            this.NgayLap,
            this.ThanhTien});
            this.dgvHD.Location = new System.Drawing.Point(28, 331);
            this.dgvHD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.RowHeadersWidth = 51;
            this.dgvHD.Size = new System.Drawing.Size(1306, 298);
            this.dgvHD.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.datetime);
            this.groupBox1.Controls.Add(this.txtTien);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.cboTenNV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboTenKH);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboTenMon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboLoai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(28, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1308, 232);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(911, 115);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(193, 22);
            this.txtSoLuong.TabIndex = 2;
            // 
            // cboTenNV
            // 
            this.cboTenNV.FormattingEnabled = true;
            this.cboTenNV.Location = new System.Drawing.Point(126, 61);
            this.cboTenNV.Name = "cboTenNV";
            this.cboTenNV.Size = new System.Drawing.Size(302, 23);
            this.cboTenNV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhân Viên";
            // 
            // cboTenKH
            // 
            this.cboTenKH.FormattingEnabled = true;
            this.cboTenKH.Location = new System.Drawing.Point(566, 61);
            this.cboTenKH.Name = "cboTenKH";
            this.cboTenKH.Size = new System.Drawing.Size(302, 23);
            this.cboTenKH.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(917, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày bán";
            // 
            // cboTenMon
            // 
            this.cboTenMon.FormattingEnabled = true;
            this.cboTenMon.Location = new System.Drawing.Point(499, 114);
            this.cboTenMon.Name = "cboTenMon";
            this.cboTenMon.Size = new System.Drawing.Size(302, 23);
            this.cboTenMon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(824, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Món";
            // 
            // cboLoai
            // 
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Location = new System.Drawing.Point(100, 109);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(302, 23);
            this.cboLoai.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Khách Hàng";
            // 
            // datetime
            // 
            this.datetime.Location = new System.Drawing.Point(1018, 57);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(273, 22);
            this.datetime.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(824, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Thành Tiền";
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(911, 158);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(193, 22);
            this.txtTien.TabIndex = 2;
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "MaMon";
            this.TenMon.HeaderText = "Tên Món";
            this.TenMon.MinimumWidth = 6;
            this.TenMon.Name = "TenMon";
            this.TenMon.Width = 200;
            // 
            // Loai
            // 
            this.Loai.DataPropertyName = "maLoai";
            this.Loai.HeaderText = "Loại";
            this.Loai.MinimumWidth = 6;
            this.Loai.Name = "Loai";
            this.Loai.Width = 150;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "MaNV";
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.Width = 300;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "MaKH";
            this.TenKH.HeaderText = "Tên K.Hàng";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            this.TenKH.Width = 300;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 150;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày Bán";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Width = 125;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 200;
            // 
            // safes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rabbit_s_House.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1348, 641);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvHD);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "safes";
            this.Text = "Safes";
            this.Load += new System.EventHandler(this.safes_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tolSpInsert;
        private System.Windows.Forms.ToolStripButton tolSpEdit;
        private System.Windows.Forms.ToolStripButton tolSpDelete;
        private System.Windows.Forms.ToolStripButton tolSpSave;
        private System.Windows.Forms.ToolStripButton tolSpCannel;
        private System.Windows.Forms.ToolStripButton tolSpPrint;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cboTenNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTenKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTenMon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}