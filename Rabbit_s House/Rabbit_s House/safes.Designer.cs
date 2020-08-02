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
            this.cboTenNV = new System.Windows.Forms.ComboBox();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grbTTC = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grbTTM = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cboTenMon = new System.Windows.Forms.ComboBox();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboTenKH = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.grbTTC.SuspendLayout();
            this.grbTTM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(1350, 47);
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
            // cboTenNV
            // 
            this.cboTenNV.FormattingEnabled = true;
            this.cboTenNV.Location = new System.Drawing.Point(124, 201);
            this.cboTenNV.Name = "cboTenNV";
            this.cboTenNV.Size = new System.Drawing.Size(246, 21);
            this.cboTenNV.TabIndex = 15;
            // 
            // datetime
            // 
            this.datetime.Location = new System.Drawing.Point(112, 68);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(246, 20);
            this.datetime.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ngày bán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tên Nhân Viên";
            // 
            // grbTTC
            // 
            this.grbTTC.BackColor = System.Drawing.Color.Transparent;
            this.grbTTC.Controls.Add(this.cboTenKH);
            this.grbTTC.Controls.Add(this.label8);
            this.grbTTC.Controls.Add(this.datetime);
            this.grbTTC.Controls.Add(this.label3);
            this.grbTTC.Controls.Add(this.label4);
            this.grbTTC.Location = new System.Drawing.Point(12, 77);
            this.grbTTC.Name = "grbTTC";
            this.grbTTC.Size = new System.Drawing.Size(1315, 221);
            this.grbTTC.TabIndex = 16;
            this.grbTTC.TabStop = false;
            this.grbTTC.Text = "Thông Tin Chung";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(492, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 30);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tên Khách Hàng";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbTTM
            // 
            this.grbTTM.BackColor = System.Drawing.Color.Transparent;
            this.grbTTM.Controls.Add(this.label1);
            this.grbTTM.Controls.Add(this.label2);
            this.grbTTM.Controls.Add(this.label6);
            this.grbTTM.Controls.Add(this.txtSoLuong);
            this.grbTTM.Controls.Add(this.cboTenMon);
            this.grbTTM.Controls.Add(this.cboLoai);
            this.grbTTM.Location = new System.Drawing.Point(12, 319);
            this.grbTTM.Name = "grbTTM";
            this.grbTTM.Size = new System.Drawing.Size(1315, 99);
            this.grbTTM.TabIndex = 16;
            this.grbTTM.TabStop = false;
            this.grbTTM.Text = "Thông Tin Chung";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(802, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Số Lượng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(32, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Loại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(442, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tên món";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(907, 54);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(246, 20);
            this.txtSoLuong.TabIndex = 17;
            // 
            // cboTenMon
            // 
            this.cboTenMon.FormattingEnabled = true;
            this.cboTenMon.Location = new System.Drawing.Point(508, 51);
            this.cboTenMon.Name = "cboTenMon";
            this.cboTenMon.Size = new System.Drawing.Size(246, 21);
            this.cboTenMon.TabIndex = 15;
            // 
            // cboLoai
            // 
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Location = new System.Drawing.Point(126, 51);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(246, 21);
            this.cboLoai.TabIndex = 15;
            this.cboLoai.SelectedIndexChanged += new System.EventHandler(this.cboLoai_SelectedIndexChanged);
            // 
            // dgvHD
            // 
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenMon,
            this.Loai,
            this.TenNV,
            this.TenKH,
            this.SoDT,
            this.SoLuong,
            this.ThanhTien});
            this.dgvHD.Location = new System.Drawing.Point(17, 434);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.Size = new System.Drawing.Size(1310, 203);
            this.dgvHD.TabIndex = 17;
            // 
            // TenMon
            // 
            this.TenMon.HeaderText = "Tên Món";
            this.TenMon.Name = "TenMon";
            // 
            // Loai
            // 
            this.Loai.HeaderText = "Loại";
            this.Loai.Name = "Loai";
            // 
            // TenNV
            // 
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.Name = "TenNV";
            // 
            // TenKH
            // 
            this.TenKH.HeaderText = "Tên K.Hàng";
            this.TenKH.Name = "TenKH";
            // 
            // SoDT
            // 
            this.SoDT.HeaderText = "Số Điện Thoại";
            this.SoDT.Name = "SoDT";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // cboTenKH
            // 
            this.cboTenKH.FormattingEnabled = true;
            this.cboTenKH.Location = new System.Drawing.Point(597, 59);
            this.cboTenKH.Name = "cboTenKH";
            this.cboTenKH.Size = new System.Drawing.Size(246, 21);
            this.cboTenKH.TabIndex = 18;
            // 
            // safes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rabbit_s_House.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1350, 649);
            this.Controls.Add(this.dgvHD);
            this.Controls.Add(this.cboTenNV);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grbTTM);
            this.Controls.Add(this.grbTTC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "safes";
            this.Text = "safes";
            this.Load += new System.EventHandler(this.safes_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grbTTC.ResumeLayout(false);
            this.grbTTC.PerformLayout();
            this.grbTTM.ResumeLayout(false);
            this.grbTTM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
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
        private System.Windows.Forms.ComboBox cboTenNV;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbTTC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grbTTM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTenMon;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.ComboBox cboTenKH;
    }
}