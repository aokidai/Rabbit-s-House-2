namespace Rabbit_s_House
{
    partial class frmThemSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemSP));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tolSpInsert = new System.Windows.Forms.ToolStripButton();
            this.tolSpEdit = new System.Windows.Forms.ToolStripButton();
            this.tolSpDelete = new System.Windows.Forms.ToolStripButton();
            this.tolSpSave = new System.Windows.Forms.ToolStripButton();
            this.tolSpCannel = new System.Windows.Forms.ToolStripButton();
            this.tolSpPrint = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThemAnh = new System.Windows.Forms.Button();
            this.pHinh = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvMon = new System.Windows.Forms.DataGridView();
            this.Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).BeginInit();
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
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cboLoai);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnThemAnh);
            this.groupBox1.Controls.Add(this.pHinh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.txtTenMon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaMon);
            this.groupBox1.Controls.Add(this.label2);
<<<<<<< HEAD
            this.groupBox1.Location = new System.Drawing.Point(16, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(392, 628);
=======
            this.groupBox1.Location = new System.Drawing.Point(16, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(392, 580);
>>>>>>> 35f12f0642c3403e5714b00d2831c37ab6f54d43
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin món";
            // 
            // btnThemAnh
            // 
            this.btnThemAnh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
<<<<<<< HEAD
            this.btnThemAnh.Location = new System.Drawing.Point(130, 379);
            this.btnThemAnh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnThemAnh.Name = "btnThemAnh";
            this.btnThemAnh.Size = new System.Drawing.Size(96, 41);
=======
            this.btnThemAnh.Location = new System.Drawing.Point(130, 398);
            this.btnThemAnh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemAnh.Name = "btnThemAnh";
            this.btnThemAnh.Size = new System.Drawing.Size(96, 38);
>>>>>>> 35f12f0642c3403e5714b00d2831c37ab6f54d43
            this.btnThemAnh.TabIndex = 21;
            this.btnThemAnh.Text = "Thêm ảnh";
            this.btnThemAnh.UseVisualStyleBackColor = true;
            this.btnThemAnh.Click += new System.EventHandler(this.btnThemAnh_Click);
            // 
            // pHinh
            // 
<<<<<<< HEAD
            this.pHinh.Location = new System.Drawing.Point(106, 206);
            this.pHinh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pHinh.Name = "pHinh";
            this.pHinh.Size = new System.Drawing.Size(145, 157);
=======
            this.pHinh.Location = new System.Drawing.Point(106, 238);
            this.pHinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pHinh.Name = "pHinh";
            this.pHinh.Size = new System.Drawing.Size(145, 145);
>>>>>>> 35f12f0642c3403e5714b00d2831c37ab6f54d43
            this.pHinh.TabIndex = 20;
            this.pHinh.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
<<<<<<< HEAD
            this.label1.Location = new System.Drawing.Point(16, 224);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
=======
            this.label1.Location = new System.Drawing.Point(16, 255);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
>>>>>>> 35f12f0642c3403e5714b00d2831c37ab6f54d43
            this.label1.TabIndex = 18;
            this.label1.Text = "Hình Anh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
<<<<<<< HEAD
            this.label7.Location = new System.Drawing.Point(16, 166);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
=======
            this.label7.Location = new System.Drawing.Point(16, 154);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 12);
>>>>>>> 35f12f0642c3403e5714b00d2831c37ab6f54d43
            this.label7.TabIndex = 18;
            this.label7.Text = "Giá";
            // 
            // txtGia
            // 
<<<<<<< HEAD
            this.txtGia.Location = new System.Drawing.Point(106, 164);
            this.txtGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(258, 20);
=======
            this.txtGia.Location = new System.Drawing.Point(106, 151);
            this.txtGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(258, 19);
>>>>>>> 35f12f0642c3403e5714b00d2831c37ab6f54d43
            this.txtGia.TabIndex = 17;
            // 
            // txtTenMon
            // 
<<<<<<< HEAD
            this.txtTenMon.Location = new System.Drawing.Point(106, 118);
            this.txtTenMon.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(258, 20);
=======
            this.txtTenMon.Location = new System.Drawing.Point(106, 109);
            this.txtTenMon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(258, 19);
>>>>>>> 35f12f0642c3403e5714b00d2831c37ab6f54d43
            this.txtTenMon.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
<<<<<<< HEAD
            this.label3.Location = new System.Drawing.Point(17, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
=======
            this.label3.Location = new System.Drawing.Point(17, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 12);
>>>>>>> 35f12f0642c3403e5714b00d2831c37ab6f54d43
            this.label3.TabIndex = 16;
            this.label3.Text = "Tên Món";
            // 
            // txtMaMon
            // 
<<<<<<< HEAD
            this.txtMaMon.Location = new System.Drawing.Point(106, 77);
            this.txtMaMon.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(257, 20);
=======
            this.txtMaMon.Location = new System.Drawing.Point(106, 71);
            this.txtMaMon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(257, 19);
>>>>>>> 35f12f0642c3403e5714b00d2831c37ab6f54d43
            this.txtMaMon.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
<<<<<<< HEAD
            this.label2.Location = new System.Drawing.Point(17, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
=======
            this.label2.Location = new System.Drawing.Point(17, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
>>>>>>> 35f12f0642c3403e5714b00d2831c37ab6f54d43
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã Món";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
<<<<<<< HEAD
            this.btnTimKiem.Location = new System.Drawing.Point(1280, 10);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(61, 19);
=======
            this.btnTimKiem.Location = new System.Drawing.Point(1280, 9);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(61, 18);
>>>>>>> 35f12f0642c3403e5714b00d2831c37ab6f54d43
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
<<<<<<< HEAD
            this.txtTimKiem.Location = new System.Drawing.Point(1052, 10);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(217, 20);
=======
            this.txtTimKiem.Location = new System.Drawing.Point(1052, 9);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(217, 19);
>>>>>>> 35f12f0642c3403e5714b00d2831c37ab6f54d43
            this.txtTimKiem.TabIndex = 12;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimKiem_KeyPress);
            this.txtTimKiem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtTimKiem_MouseDown);
            // 
            // dgvMon
            // 
            this.dgvMon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stt,
            this.MaMon,
            this.TenMon,
            this.Gia});
<<<<<<< HEAD
            this.dgvMon.Location = new System.Drawing.Point(433, 61);
            this.dgvMon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvMon.Name = "dgvMon";
            this.dgvMon.RowHeadersWidth = 51;
            this.dgvMon.RowTemplate.Height = 24;
            this.dgvMon.Size = new System.Drawing.Size(897, 621);
=======
            this.dgvMon.Location = new System.Drawing.Point(433, 56);
            this.dgvMon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMon.Name = "dgvMon";
            this.dgvMon.RowHeadersWidth = 51;
            this.dgvMon.RowTemplate.Height = 24;
            this.dgvMon.Size = new System.Drawing.Size(897, 574);
>>>>>>> 35f12f0642c3403e5714b00d2831c37ab6f54d43
            this.dgvMon.TabIndex = 14;
            this.dgvMon.SelectionChanged += new System.EventHandler(this.dgvMon_SelectionChanged);
            // 
            // Stt
            // 
            this.Stt.HeaderText = "STT";
            this.Stt.MinimumWidth = 6;
            this.Stt.Name = "Stt";
            this.Stt.Width = 50;
            // 
            // MaMon
            // 
            this.MaMon.DataPropertyName = "MaMon";
            this.MaMon.HeaderText = "Mã Món";
            this.MaMon.MinimumWidth = 6;
            this.MaMon.Name = "MaMon";
            this.MaMon.Width = 200;
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "TenMon";
            this.TenMon.HeaderText = "Tên Món";
            this.TenMon.MinimumWidth = 6;
            this.TenMon.Name = "TenMon";
            this.TenMon.Width = 500;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.Width = 200;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(17, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "Loại";
            // 
            // cboLoai
            // 
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Location = new System.Drawing.Point(106, 193);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(175, 20);
            this.cboLoai.TabIndex = 23;
            // 
            // frmThemSP
            // 
<<<<<<< HEAD
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
=======
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
>>>>>>> 35f12f0642c3403e5714b00d2831c37ab6f54d43
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rabbit_s_House.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1350, 649);
            this.Controls.Add(this.dgvMon);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
<<<<<<< HEAD
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
=======
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> 35f12f0642c3403e5714b00d2831c37ab6f54d43
            this.Name = "frmThemSP";
            this.Text = "Foods";
            this.Load += new System.EventHandler(this.frmThemSP_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThemAnh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
<<<<<<< HEAD
        public System.Windows.Forms.PictureBox pHinh;
        public System.Windows.Forms.TextBox txtTenMon;
        public System.Windows.Forms.TextBox txtMaMon;
        public System.Windows.Forms.TextBox txtGia;
=======
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.Label label4;
>>>>>>> 35f12f0642c3403e5714b00d2831c37ab6f54d43
    }
}