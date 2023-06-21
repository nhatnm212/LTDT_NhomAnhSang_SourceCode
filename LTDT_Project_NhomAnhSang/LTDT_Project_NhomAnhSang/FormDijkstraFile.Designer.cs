
namespace LTDT_Project_NhomAnhSang
{
    partial class FormDijkstraFile
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
            lb_TongGiaTri = new System.Windows.Forms.Label();
            lb_MaTranKe = new System.Windows.Forms.Label();
            groupBox_DoThi = new System.Windows.Forms.GroupBox();
            tBox_ChayDenDinh = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            tBox_ChayTuDinh = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btn_DocFile = new System.Windows.Forms.Button();
            btn_KetQua = new System.Windows.Forms.Button();
            tBox_TongGiaTri = new System.Windows.Forms.TextBox();
            tBox_KetQuaDijkstra = new System.Windows.Forms.TextBox();
            tBox_MaTranKe = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            lb_KetQuaPrim = new System.Windows.Forms.Label();
            groupBox_DauVao = new System.Windows.Forms.GroupBox();
            listBoxCanh = new System.Windows.Forms.ListBox();
            listBoxDinh = new System.Windows.Forms.ListBox();
            labelCanh = new System.Windows.Forms.Label();
            labelDinh = new System.Windows.Forms.Label();
            drawTimer = new System.Windows.Forms.Timer(components);
            groupBox_DoThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox_DauVao.SuspendLayout();
            SuspendLayout();
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
            groupBox_DoThi.Controls.Add(tBox_ChayDenDinh);
            groupBox_DoThi.Controls.Add(label2);
            groupBox_DoThi.Controls.Add(tBox_ChayTuDinh);
            groupBox_DoThi.Controls.Add(label1);
            groupBox_DoThi.Controls.Add(pictureBox2);
            groupBox_DoThi.Controls.Add(label4);
            groupBox_DoThi.Controls.Add(label3);
            groupBox_DoThi.Controls.Add(pictureBox1);
            groupBox_DoThi.Font = new System.Drawing.Font("UTM Guanine", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox_DoThi.ForeColor = System.Drawing.Color.DarkCyan;
            groupBox_DoThi.Location = new System.Drawing.Point(637, 23);
            groupBox_DoThi.Name = "groupBox_DoThi";
            groupBox_DoThi.Size = new System.Drawing.Size(761, 667);
            groupBox_DoThi.TabIndex = 16;
            groupBox_DoThi.TabStop = false;
            groupBox_DoThi.Text = "CHẠY THUẬT TOÁN DIJKSTRA";
            // 
            // tBox_ChayDenDinh
            // 
            tBox_ChayDenDinh.Font = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tBox_ChayDenDinh.Location = new System.Drawing.Point(61, 244);
            tBox_ChayDenDinh.Name = "tBox_ChayDenDinh";
            tBox_ChayDenDinh.Size = new System.Drawing.Size(59, 30);
            tBox_ChayDenDinh.TabIndex = 7;
            tBox_ChayDenDinh.Text = "0";
            tBox_ChayDenDinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.LavenderBlush;
            label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label2.Font = new System.Drawing.Font("UTM Aptima", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(31, 346);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(115, 50);
            label2.TabIndex = 2;
            label2.Text = "Kết quả";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBox_ChayTuDinh
            // 
            tBox_ChayTuDinh.Font = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tBox_ChayTuDinh.Location = new System.Drawing.Point(61, 163);
            tBox_ChayTuDinh.Name = "tBox_ChayTuDinh";
            tBox_ChayTuDinh.Size = new System.Drawing.Size(59, 30);
            tBox_ChayTuDinh.TabIndex = 7;
            tBox_ChayTuDinh.Text = "0";
            tBox_ChayTuDinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.LavenderBlush;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.PaleTurquoise;
            label4.Font = new System.Drawing.Font("UTM Times", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(49, 212);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(88, 25);
            label4.TabIndex = 1;
            label4.Text = "Đến đỉnh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.PaleTurquoise;
            label3.Font = new System.Drawing.Font("UTM Times", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(49, 130);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(79, 25);
            label3.TabIndex = 1;
            label3.Text = "Từ đỉnh";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pictureBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pictureBox1.Location = new System.Drawing.Point(31, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(710, 297);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // btn_DocFile
            // 
            btn_DocFile.BackColor = System.Drawing.Color.Crimson;
            btn_DocFile.Font = new System.Drawing.Font("UTM Aptima", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_DocFile.ForeColor = System.Drawing.SystemColors.Info;
            btn_DocFile.Location = new System.Drawing.Point(32, 335);
            btn_DocFile.Name = "btn_DocFile";
            btn_DocFile.Size = new System.Drawing.Size(262, 39);
            btn_DocFile.TabIndex = 6;
            btn_DocFile.Text = "CHỌN FILE TXT";
            btn_DocFile.UseVisualStyleBackColor = false;
            btn_DocFile.Click += btn_DocFile_Click;
            // 
            // btn_KetQua
            // 
            btn_KetQua.BackColor = System.Drawing.Color.Crimson;
            btn_KetQua.Font = new System.Drawing.Font("UTM Aptima", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_KetQua.ForeColor = System.Drawing.SystemColors.Info;
            btn_KetQua.Location = new System.Drawing.Point(300, 335);
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
            tBox_TongGiaTri.Size = new System.Drawing.Size(131, 223);
            tBox_TongGiaTri.TabIndex = 1;
            // 
            // tBox_KetQuaDijkstra
            // 
            tBox_KetQuaDijkstra.Font = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tBox_KetQuaDijkstra.Location = new System.Drawing.Point(276, 89);
            tBox_KetQuaDijkstra.Multiline = true;
            tBox_KetQuaDijkstra.Name = "tBox_KetQuaDijkstra";
            tBox_KetQuaDijkstra.ReadOnly = true;
            tBox_KetQuaDijkstra.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            tBox_KetQuaDijkstra.Size = new System.Drawing.Size(142, 223);
            tBox_KetQuaDijkstra.TabIndex = 1;
            // 
            // tBox_MaTranKe
            // 
            tBox_MaTranKe.Font = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tBox_MaTranKe.Location = new System.Drawing.Point(32, 89);
            tBox_MaTranKe.Multiline = true;
            tBox_MaTranKe.Name = "tBox_MaTranKe";
            tBox_MaTranKe.ReadOnly = true;
            tBox_MaTranKe.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            tBox_MaTranKe.Size = new System.Drawing.Size(229, 223);
            tBox_MaTranKe.TabIndex = 1;
            tBox_MaTranKe.Text = "0";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_DocFile);
            groupBox1.Controls.Add(btn_KetQua);
            groupBox1.Controls.Add(tBox_TongGiaTri);
            groupBox1.Controls.Add(tBox_KetQuaDijkstra);
            groupBox1.Controls.Add(tBox_MaTranKe);
            groupBox1.Controls.Add(lb_TongGiaTri);
            groupBox1.Controls.Add(lb_KetQuaPrim);
            groupBox1.Controls.Add(lb_MaTranKe);
            groupBox1.Font = new System.Drawing.Font("UTM Guanine", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox1.ForeColor = System.Drawing.Color.Crimson;
            groupBox1.Location = new System.Drawing.Point(21, 288);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(592, 402);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN ĐẦU RA";
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
            // groupBox_DauVao
            // 
            groupBox_DauVao.Controls.Add(listBoxCanh);
            groupBox_DauVao.Controls.Add(listBoxDinh);
            groupBox_DauVao.Controls.Add(labelCanh);
            groupBox_DauVao.Controls.Add(labelDinh);
            groupBox_DauVao.Font = new System.Drawing.Font("UTM Guanine", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox_DauVao.ForeColor = System.Drawing.Color.DarkCyan;
            groupBox_DauVao.Location = new System.Drawing.Point(21, 23);
            groupBox_DauVao.Name = "groupBox_DauVao";
            groupBox_DauVao.Size = new System.Drawing.Size(592, 238);
            groupBox_DauVao.TabIndex = 18;
            groupBox_DauVao.TabStop = false;
            groupBox_DauVao.Text = "THÔNG TIN ĐỈNH, CẠNH";
            // 
            // listBoxCanh
            // 
            listBoxCanh.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            listBoxCanh.FormattingEnabled = true;
            listBoxCanh.ItemHeight = 18;
            listBoxCanh.Location = new System.Drawing.Point(312, 84);
            listBoxCanh.Name = "listBoxCanh";
            listBoxCanh.Size = new System.Drawing.Size(259, 130);
            listBoxCanh.TabIndex = 7;
            // 
            // listBoxDinh
            // 
            listBoxDinh.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            listBoxDinh.FormattingEnabled = true;
            listBoxDinh.ItemHeight = 18;
            listBoxDinh.Location = new System.Drawing.Point(30, 83);
            listBoxDinh.Name = "listBoxDinh";
            listBoxDinh.Size = new System.Drawing.Size(264, 130);
            listBoxDinh.TabIndex = 6;
            // 
            // labelCanh
            // 
            labelCanh.AutoSize = true;
            labelCanh.Font = new System.Drawing.Font("UTM Times", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelCanh.ForeColor = System.Drawing.Color.DarkCyan;
            labelCanh.Location = new System.Drawing.Point(312, 52);
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
            labelDinh.Location = new System.Drawing.Point(31, 50);
            labelDinh.Name = "labelDinh";
            labelDinh.Size = new System.Drawing.Size(142, 25);
            labelDinh.TabIndex = 1;
            labelDinh.Text = "Danh sách đỉnh";
            labelDinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drawTimer
            // 
            drawTimer.Interval = 500;
            drawTimer.Tick += drawTimer_Tick;
            // 
            // FormDijkstraFile
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightPink;
            ClientSize = new System.Drawing.Size(1419, 712);
            Controls.Add(groupBox_DauVao);
            Controls.Add(groupBox_DoThi);
            Controls.Add(groupBox1);
            Name = "FormDijkstraFile";
            Text = "Chạy thuật toán Dijkstra từ file";
            groupBox_DoThi.ResumeLayout(false);
            groupBox_DoThi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox_DauVao.ResumeLayout(false);
            groupBox_DauVao.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lb_TongGiaTri;
        private System.Windows.Forms.Label lb_MaTranKe;
        private System.Windows.Forms.GroupBox groupBox_DoThi;
        private System.Windows.Forms.TextBox tBox_ChayDenDinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBox_ChayTuDinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_DocFile;
        private System.Windows.Forms.Button btn_KetQua;
        private System.Windows.Forms.TextBox tBox_TongGiaTri;
        private System.Windows.Forms.TextBox tBox_KetQuaDijkstra;
        public System.Windows.Forms.TextBox tBox_MaTranKe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_KetQuaPrim;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox_DauVao;
        private System.Windows.Forms.ListBox listBoxCanh;
        private System.Windows.Forms.ListBox listBoxDinh;
        private System.Windows.Forms.Label labelCanh;
        private System.Windows.Forms.Label labelDinh;
        private System.Windows.Forms.Timer drawTimer;
    }
}