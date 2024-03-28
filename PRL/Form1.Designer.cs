namespace PRL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_MaNV = new TextBox();
            txt_HoTen = new TextBox();
            txt_NgSinh = new TextBox();
            txt_Search = new TextBox();
            rbtn_Nam = new RadioButton();
            rbtn_Nu = new RadioButton();
            cmbx_DChi = new ComboBox();
            dtgView = new DataGridView();
            btn_Add = new Button();
            btn_Update = new Button();
            btn_Clear = new Button();
            btn_Remove = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(99, 37);
            label1.TabIndex = 0;
            label1.Text = "Mã NV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(99, 37);
            label2.TabIndex = 1;
            label2.Text = "Họ Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(12, 121);
            label3.Name = "label3";
            label3.Size = new Size(138, 37);
            label3.TabIndex = 2;
            label3.Text = "Ngày Sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(12, 176);
            label4.Name = "label4";
            label4.Size = new Size(124, 37);
            label4.TabIndex = 3;
            label4.Text = "Giới Tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(12, 229);
            label5.Name = "label5";
            label5.Size = new Size(103, 37);
            label5.TabIndex = 4;
            label5.Text = "Địa Chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.Location = new Point(12, 287);
            label6.Name = "label6";
            label6.Size = new Size(128, 37);
            label6.TabIndex = 5;
            label6.Text = "Tìm Kiếm";
            // 
            // txt_MaNV
            // 
            txt_MaNV.Location = new Point(171, 43);
            txt_MaNV.Name = "txt_MaNV";
            txt_MaNV.Size = new Size(385, 23);
            txt_MaNV.TabIndex = 6;
            // 
            // txt_HoTen
            // 
            txt_HoTen.Location = new Point(171, 89);
            txt_HoTen.Name = "txt_HoTen";
            txt_HoTen.Size = new Size(385, 23);
            txt_HoTen.TabIndex = 7;
            // 
            // txt_NgSinh
            // 
            txt_NgSinh.Location = new Point(171, 135);
            txt_NgSinh.Name = "txt_NgSinh";
            txt_NgSinh.Size = new Size(385, 23);
            txt_NgSinh.TabIndex = 8;
            // 
            // txt_Search
            // 
            txt_Search.Location = new Point(171, 301);
            txt_Search.Name = "txt_Search";
            txt_Search.Size = new Size(190, 23);
            txt_Search.TabIndex = 9;
            // 
            // rbtn_Nam
            // 
            rbtn_Nam.AutoSize = true;
            rbtn_Nam.Font = new Font("Segoe UI", 20F);
            rbtn_Nam.Location = new Point(170, 176);
            rbtn_Nam.Name = "rbtn_Nam";
            rbtn_Nam.Size = new Size(92, 41);
            rbtn_Nam.TabIndex = 10;
            rbtn_Nam.TabStop = true;
            rbtn_Nam.Text = "Nam";
            rbtn_Nam.UseVisualStyleBackColor = true;
            // 
            // rbtn_Nu
            // 
            rbtn_Nu.AutoSize = true;
            rbtn_Nu.Font = new Font("Segoe UI", 20F);
            rbtn_Nu.Location = new Point(356, 176);
            rbtn_Nu.Name = "rbtn_Nu";
            rbtn_Nu.Size = new Size(71, 41);
            rbtn_Nu.TabIndex = 11;
            rbtn_Nu.TabStop = true;
            rbtn_Nu.Text = "Nữ";
            rbtn_Nu.UseVisualStyleBackColor = true;
            // 
            // cmbx_DChi
            // 
            cmbx_DChi.FormattingEnabled = true;
            cmbx_DChi.Location = new Point(171, 244);
            cmbx_DChi.Name = "cmbx_DChi";
            cmbx_DChi.Size = new Size(385, 23);
            cmbx_DChi.TabIndex = 12;
            // 
            // dtgView
            // 
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView.Location = new Point(22, 342);
            dtgView.Name = "dtgView";
            dtgView.Size = new Size(766, 169);
            dtgView.TabIndex = 13;
            dtgView.CellClick += dtgView_CellClick;
            // 
            // btn_Add
            // 
            btn_Add.Font = new Font("Segoe UI", 20F);
            btn_Add.Location = new Point(607, 42);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(181, 52);
            btn_Add.TabIndex = 14;
            btn_Add.Text = "Thêm";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Update
            // 
            btn_Update.Font = new Font("Segoe UI", 20F);
            btn_Update.Location = new Point(607, 100);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(181, 52);
            btn_Update.TabIndex = 15;
            btn_Update.Text = "Sửa";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.Font = new Font("Segoe UI", 20F);
            btn_Clear.Location = new Point(607, 214);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(181, 52);
            btn_Clear.TabIndex = 16;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // btn_Remove
            // 
            btn_Remove.Font = new Font("Segoe UI", 20F);
            btn_Remove.Location = new Point(607, 158);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new Size(181, 52);
            btn_Remove.TabIndex = 17;
            btn_Remove.Text = "Xóa";
            btn_Remove.UseVisualStyleBackColor = true;
            btn_Remove.Click += btn_Remove_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 523);
            Controls.Add(btn_Remove);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Update);
            Controls.Add(btn_Add);
            Controls.Add(dtgView);
            Controls.Add(cmbx_DChi);
            Controls.Add(rbtn_Nu);
            Controls.Add(rbtn_Nam);
            Controls.Add(txt_Search);
            Controls.Add(txt_NgSinh);
            Controls.Add(txt_HoTen);
            Controls.Add(txt_MaNV);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_MaNV;
        private TextBox txt_HoTen;
        private TextBox txt_NgSinh;
        private TextBox txt_Search;
        private RadioButton rbtn_Nam;
        private RadioButton rbtn_Nu;
        private ComboBox cmbx_DChi;
        private DataGridView dtgView;
        private Button btn_Add;
        private Button btn_Update;
        private Button btn_Clear;
        private Button btn_Remove;
    }
}
