
namespace LTDT_Project_NhomAnhSang
{
    partial class FormPrim
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
            components = new System.ComponentModel.Container();
            btn_Them = new System.Windows.Forms.Button();
            tBox_TrongSo = new System.Windows.Forms.TextBox();
            tBox_DenDinh = new System.Windows.Forms.TextBox();
            tBox_TuDinh = new System.Windows.Forms.TextBox();
            lb_TrongSo = new System.Windows.Forms.Label();
            lb_DenDinh = new System.Windows.Forms.Label();
            lb_TuDinh = new System.Windows.Forms.Label();
            groupBox_DauVao = new System.Windows.Forms.GroupBox();
            listBoxCanh = new System.Windows.Forms.ListBox();
            listBoxDinh = new System.Windows.Forms.ListBox();
            labelCanh = new System.Windows.Forms.Label();
            labelDinh = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btn_DocFile = new System.Windows.Forms.Button();
            btn_KetQua = new System.Windows.Forms.Button();
            tBox_TongGiaTri = new System.Windows.Forms.TextBox();
            tBox_KetQuaPrim = new System.Windows.Forms.TextBox();
            tBox_MaTranKe = new System.Windows.Forms.TextBox();
            lb_TongGiaTri = new System.Windows.Forms.Label();
            lb_KetQuaPrim = new System.Windows.Forms.Label();
            lb_MaTranKe = new System.Windows.Forms.Label();
            groupBox_DoThi = new System.Windows.Forms.GroupBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            DrawTimer = new System.Windows.Forms.Timer(components);
            groupBox_DauVao.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox_DoThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Them
            // 
            btn_Them.BackColor = System.Drawing.Color.DarkCyan;
            btn_Them.Font = new System.Drawing.Font("UTM Aptima", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Them.ForeColor = System.Drawing.SystemColors.Info;
            btn_Them.Location = new System.Drawing.Point(28, 208);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new System.Drawing.Size(196, 39);
            btn_Them.TabIndex = 4;
            btn_Them.Text = "NHẬP TRỌNG SỐ";
            btn_Them.UseVisualStyleBackColor = false;
            btn_Them.Click += btn_Them_Click;
            // 
            // tBox_TrongSo
            // 
            tBox_TrongSo.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tBox_TrongSo.Location = new System.Drawing.Point(121, 156);
            tBox_TrongSo.Name = "tBox_TrongSo";
            tBox_TrongSo.Size = new System.Drawing.Size(102, 26);
            tBox_TrongSo.TabIndex = 3;
            tBox_TrongSo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBox_DenDinh
            // 
            tBox_DenDinh.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tBox_DenDinh.Location = new System.Drawing.Point(121, 111);
            tBox_DenDinh.Name = "tBox_DenDinh";
            tBox_DenDinh.Size = new System.Drawing.Size(102, 26);
            tBox_DenDinh.TabIndex = 2;
            tBox_DenDinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBox_TuDinh
            // 
            tBox_TuDinh.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tBox_TuDinh.Location = new System.Drawing.Point(121, 66);
            tBox_TuDinh.Name = "tBox_TuDinh";
            tBox_TuDinh.Size = new System.Drawing.Size(102, 26);
            tBox_TuDinh.TabIndex = 1;
            tBox_TuDinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_TrongSo
            // 
            lb_TrongSo.AutoSize = true;
            lb_TrongSo.Font = new System.Drawing.Font("UTM Times", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_TrongSo.Location = new System.Drawing.Point(29, 157);
            lb_TrongSo.Name = "lb_TrongSo";
            lb_TrongSo.Size = new System.Drawing.Size(86, 25);
            lb_TrongSo.TabIndex = 2;
            lb_TrongSo.Text = "Trọng số";
            // 
            // lb_DenDinh
            // 
            lb_DenDinh.AutoSize = true;
            lb_DenDinh.Font = new System.Drawing.Font("UTM Times", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_DenDinh.Location = new System.Drawing.Point(27, 112);
            lb_DenDinh.Name = "lb_DenDinh";
            lb_DenDinh.Size = new System.Drawing.Size(88, 25);
            lb_DenDinh.TabIndex = 2;
            lb_DenDinh.Text = "Đến đỉnh";
            // 
            // lb_TuDinh
            // 
            lb_TuDinh.AutoSize = true;
            lb_TuDinh.Font = new System.Drawing.Font("UTM Times", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_TuDinh.Location = new System.Drawing.Point(29, 67);
            lb_TuDinh.Name = "lb_TuDinh";
            lb_TuDinh.Size = new System.Drawing.Size(79, 25);
            lb_TuDinh.TabIndex = 1;
            lb_TuDinh.Text = "Từ đỉnh";
            // 
            // groupBox_DauVao
            // 
            groupBox_DauVao.Controls.Add(listBoxCanh);
            groupBox_DauVao.Controls.Add(listBoxDinh);
            groupBox_DauVao.Controls.Add(btn_Them);
            groupBox_DauVao.Controls.Add(tBox_TrongSo);
            groupBox_DauVao.Controls.Add(labelCanh);
            groupBox_DauVao.Controls.Add(labelDinh);
            groupBox_DauVao.Controls.Add(lb_TuDinh);
            groupBox_DauVao.Controls.Add(tBox_DenDinh);
            groupBox_DauVao.Controls.Add(lb_DenDinh);
            groupBox_DauVao.Controls.Add(tBox_TuDinh);
            groupBox_DauVao.Controls.Add(lb_TrongSo);
            groupBox_DauVao.Font = new System.Drawing.Font("UTM Guanine", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox_DauVao.ForeColor = System.Drawing.Color.DarkCyan;
            groupBox_DauVao.Location = new System.Drawing.Point(21, 33);
            groupBox_DauVao.Name = "groupBox_DauVao";
            groupBox_DauVao.Size = new System.Drawing.Size(592, 273);
            groupBox_DauVao.TabIndex = 5;
            groupBox_DauVao.TabStop = false;
            groupBox_DauVao.Text = "THÔNG TIN ĐẦU VÀO";
            // 
            // listBoxCanh
            // 
            listBoxCanh.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            listBoxCanh.FormattingEnabled = true;
            listBoxCanh.ItemHeight = 18;
            listBoxCanh.Location = new System.Drawing.Point(411, 80);
            listBoxCanh.Name = "listBoxCanh";
            listBoxCanh.Size = new System.Drawing.Size(144, 166);
            listBoxCanh.TabIndex = 7;
            // 
            // listBoxDinh
            // 
            listBoxDinh.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            listBoxDinh.FormattingEnabled = true;
            listBoxDinh.ItemHeight = 18;
            listBoxDinh.Location = new System.Drawing.Point(249, 82);
            listBoxDinh.Name = "listBoxDinh";
            listBoxDinh.Size = new System.Drawing.Size(142, 166);
            listBoxDinh.TabIndex = 6;
            // 
            // labelCanh
            // 
            labelCanh.AutoSize = true;
            labelCanh.Font = new System.Drawing.Font("UTM Times", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelCanh.ForeColor = System.Drawing.Color.DarkCyan;
            labelCanh.Location = new System.Drawing.Point(406, 48);
            labelCanh.Name = "labelCanh";
            labelCanh.Size = new System.Drawing.Size(144, 25);
            labelCanh.TabIndex = 1;
            labelCanh.Text = "Danh sách cạnh";
            labelCanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDinh
            // 
            labelDinh.AutoSize = true;
            labelDinh.Font = new System.Drawing.Font("UTM Times", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelDinh.ForeColor = System.Drawing.Color.DarkCyan;
            labelDinh.Location = new System.Drawing.Point(250, 49);
            labelDinh.Name = "labelDinh";
            labelDinh.Size = new System.Drawing.Size(142, 25);
            labelDinh.TabIndex = 1;
            labelDinh.Text = "Danh sách đỉnh";
            labelDinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_DocFile);
            groupBox1.Controls.Add(btn_KetQua);
            groupBox1.Controls.Add(tBox_TongGiaTri);
            groupBox1.Controls.Add(tBox_KetQuaPrim);
            groupBox1.Controls.Add(tBox_MaTranKe);
            groupBox1.Controls.Add(lb_TongGiaTri);
            groupBox1.Controls.Add(lb_KetQuaPrim);
            groupBox1.Controls.Add(lb_MaTranKe);
            groupBox1.Font = new System.Drawing.Font("UTM Guanine", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox1.ForeColor = System.Drawing.Color.Crimson;
            groupBox1.Location = new System.Drawing.Point(21, 328);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(592, 372);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN ĐẦU RA";
            // 
            // btn_DocFile
            // 
            btn_DocFile.BackColor = System.Drawing.Color.Crimson;
            btn_DocFile.Font = new System.Drawing.Font("UTM Aptima", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_DocFile.ForeColor = System.Drawing.SystemColors.Info;
            btn_DocFile.Location = new System.Drawing.Point(32, 298);
            btn_DocFile.Name = "btn_DocFile";
            btn_DocFile.Size = new System.Drawing.Size(262, 39);
            btn_DocFile.TabIndex = 6;
            btn_DocFile.Text = "CHẾ ĐỘ ĐỌC TỪ FILE";
            btn_DocFile.UseVisualStyleBackColor = false;
            btn_DocFile.Click += btn_DocFile_Click;
            // 
            // btn_KetQua
            // 
            btn_KetQua.BackColor = System.Drawing.Color.Crimson;
            btn_KetQua.Font = new System.Drawing.Font("UTM Aptima", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_KetQua.ForeColor = System.Drawing.SystemColors.Info;
            btn_KetQua.Location = new System.Drawing.Point(300, 298);
            btn_KetQua.Name = "btn_KetQua";
            btn_KetQua.Size = new System.Drawing.Size(265, 39);
            btn_KetQua.TabIndex = 5;
            btn_KetQua.Text = "CHẠY THUẬT TOÁN";
            btn_KetQua.UseVisualStyleBackColor = false;
            btn_KetQua.Click += btn_KetQua_Click;
            // 
            // tBox_TongGiaTri
            // 
            tBox_TongGiaTri.Font = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tBox_TongGiaTri.Location = new System.Drawing.Point(434, 89);
            tBox_TongGiaTri.Multiline = true;
            tBox_TongGiaTri.Name = "tBox_TongGiaTri";
            tBox_TongGiaTri.ReadOnly = true;
            tBox_TongGiaTri.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            tBox_TongGiaTri.Size = new System.Drawing.Size(131, 189);
            tBox_TongGiaTri.TabIndex = 1;
            // 
            // tBox_KetQuaPrim
            // 
            tBox_KetQuaPrim.Font = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tBox_KetQuaPrim.Location = new System.Drawing.Point(276, 89);
            tBox_KetQuaPrim.Multiline = true;
            tBox_KetQuaPrim.Name = "tBox_KetQuaPrim";
            tBox_KetQuaPrim.ReadOnly = true;
            tBox_KetQuaPrim.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            tBox_KetQuaPrim.Size = new System.Drawing.Size(142, 189);
            tBox_KetQuaPrim.TabIndex = 1;
            // 
            // tBox_MaTranKe
            // 
            tBox_MaTranKe.Font = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tBox_MaTranKe.Location = new System.Drawing.Point(32, 89);
            tBox_MaTranKe.Multiline = true;
            tBox_MaTranKe.Name = "tBox_MaTranKe";
            tBox_MaTranKe.ReadOnly = true;
            tBox_MaTranKe.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            tBox_MaTranKe.Size = new System.Drawing.Size(229, 189);
            tBox_MaTranKe.TabIndex = 1;
            tBox_MaTranKe.Text = "0";
            // 
            // lb_TongGiaTri
            // 
            lb_TongGiaTri.AutoSize = true;
            lb_TongGiaTri.Font = new System.Drawing.Font("UTM Times", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_TongGiaTri.ForeColor = System.Drawing.Color.Black;
            lb_TongGiaTri.Location = new System.Drawing.Point(434, 53);
            lb_TongGiaTri.Name = "lb_TongGiaTri";
            lb_TongGiaTri.Size = new System.Drawing.Size(110, 25);
            lb_TongGiaTri.TabIndex = 1;
            lb_TongGiaTri.Text = "Tổng giá trị";
            // 
            // lb_KetQuaPrim
            // 
            lb_KetQuaPrim.AutoSize = true;
            lb_KetQuaPrim.Font = new System.Drawing.Font("UTM Times", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_KetQuaPrim.ForeColor = System.Drawing.Color.Black;
            lb_KetQuaPrim.Location = new System.Drawing.Point(298, 53);
            lb_KetQuaPrim.Name = "lb_KetQuaPrim";
            lb_KetQuaPrim.Size = new System.Drawing.Size(78, 25);
            lb_KetQuaPrim.TabIndex = 1;
            lb_KetQuaPrim.Text = "Kết quả";
            // 
            // lb_MaTranKe
            // 
            lb_MaTranKe.AutoSize = true;
            lb_MaTranKe.Font = new System.Drawing.Font("UTM Times", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_MaTranKe.ForeColor = System.Drawing.Color.Black;
            lb_MaTranKe.Location = new System.Drawing.Point(89, 53);
            lb_MaTranKe.Name = "lb_MaTranKe";
            lb_MaTranKe.Size = new System.Drawing.Size(104, 25);
            lb_MaTranKe.TabIndex = 1;
            lb_MaTranKe.Text = "Ma trận kề";
            // 
            // groupBox_DoThi
            // 
            groupBox_DoThi.Controls.Add(label2);
            groupBox_DoThi.Controls.Add(label1);
            groupBox_DoThi.Controls.Add(pictureBox2);
            groupBox_DoThi.Controls.Add(pictureBox1);
            groupBox_DoThi.Font = new System.Drawing.Font("UTM Guanine", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox_DoThi.ForeColor = System.Drawing.Color.DarkCyan;
            groupBox_DoThi.Location = new System.Drawing.Point(637, 33);
            groupBox_DoThi.Name = "groupBox_DoThi";
            groupBox_DoThi.Size = new System.Drawing.Size(761, 667);
            groupBox_DoThi.TabIndex = 10;
            groupBox_DoThi.TabStop = false;
            groupBox_DoThi.Text = "CHẠY THUẬT TOÁN PRIM";
            // 
            // label2
            // 
            label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label2.Font = new System.Drawing.Font("UTM Aptima", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(31, 346);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(115, 50);
            label2.TabIndex = 2;
            label2.Text = "Kết quả";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label1.Font = new System.Drawing.Font("UTM Aptima", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(31, 52);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(115, 50);
            label1.TabIndex = 2;
            label1.Text = "Đề bài";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.LightSalmon;
            pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pictureBox2.Location = new System.Drawing.Point(31, 346);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(710, 297);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Paint += pictureBox2_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pictureBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox1.Location = new System.Drawing.Point(31, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(710, 297);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            // 
            // DrawTimer
            // 
            DrawTimer.Interval = 500;
            DrawTimer.Tick += DrawTimer_Tick;
            // 
            // FormPrim
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.GhostWhite;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1419, 712);
            Controls.Add(groupBox1);
            Controls.Add(groupBox_DauVao);
            Controls.Add(groupBox_DoThi);
            Name = "FormPrim";
            Text = "FromPrim";
            groupBox_DauVao.ResumeLayout(false);
            groupBox_DauVao.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox_DoThi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox tBox_TrongSo;
        private System.Windows.Forms.TextBox tBox_DenDinh;
        private System.Windows.Forms.TextBox tBox_TuDinh;
        private System.Windows.Forms.Label lb_TrongSo;
        private System.Windows.Forms.Label lb_DenDinh;
        private System.Windows.Forms.Label lb_TuDinh;
        private System.Windows.Forms.GroupBox groupBox_DauVao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox_DoThi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_MaTranKe;
        private System.Windows.Forms.ListBox listBoxCanh;
        private System.Windows.Forms.ListBox listBoxDinh;
        private System.Windows.Forms.Label labelCanh;
        private System.Windows.Forms.Label labelDinh;
        private System.Windows.Forms.TextBox tBox_KetQuaPrim;
        private System.Windows.Forms.Label lb_KetQuaPrim;
        private System.Windows.Forms.Button btn_KetQua;
        private System.Windows.Forms.TextBox tBox_TongGiaTri;
        private System.Windows.Forms.Label lb_TongGiaTri;
        public System.Windows.Forms.TextBox tBox_MaTranKe;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DocFile;
        private System.Windows.Forms.Timer DrawTimer;
    }
}