using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Linq;
using System.IO;
using System.Numerics; 

namespace LTDT_Project_NhomAnhSang
{
    public partial class FormDijkstra : Form
    {
        // Khởi tạo ban đầu 
        public List<Point> listDiem = new List<Point>(); 
        public List<Point> listDiem1 = new List<Point>(); 
        public int[,] MaTran = new int[100, 100]; 
        public Dijkstra dijk = new Dijkstra();
        string textLuuV, textLuuU;

        // Khai báo bảng màu color 
        Pen penDen = new Pen(Color.Black, 3);
        Pen penTrang = new Pen(Color.White, 2);
        Pen penDo = new Pen(Color.Red, 3);
        SolidBrush slbrTrang = new SolidBrush(Color.White);
        SolidBrush slbrDen = new SolidBrush(Color.Black);
        SolidBrush slbrDarkCyan = new SolidBrush(Color.DarkCyan);
        SolidBrush slbrPaleTurquoise = new SolidBrush(Color.PaleTurquoise);
        SolidBrush slbrBlue = new SolidBrush(Color.Blue);
        SolidBrush slbrRed = new SolidBrush(Color.Red);

        public FormDijkstra()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // Bật chế độ này để làm mượt đường vẽ, giảm thiểu hiện tượng răng cưa 
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Thao tác trên listBoxCanh 
            listBoxCanh.Items.Clear();
            for (int i = 0; i < listDiem.Count; i++)
            {
                for (int j = 0; j < listDiem.Count; j++)
                {
                    // Nếu trọng số từ đỉnh i đến đỉnh j khác 0 và bằng trọng số từ đỉnh j đến đỉnh i và j > i 
                    if (MaTran[i, j] != 0 && MaTran[i, j] == MaTran[j, i] && j > i)
                    {
                        // Vẽ đường nối từ đỉnh i đến đỉnh j (vẽ cạnh) 
                        g.DrawLine(penDen, listDiem[i], listDiem[j]);
                        g.FillEllipse(slbrPaleTurquoise, (listDiem[i].X + listDiem[j].X) / 2 - 10, (listDiem[i].Y + listDiem[j].Y) / 2 - 10, 30, 30);

                        // Ghi trọng số vào giữa cạnh 
                        Font font = new Font("Tahoma", 11, FontStyle.Bold);
                        g.DrawString(MaTran[i, j].ToString(), font, slbrBlue, (listDiem[i].X + listDiem[j].X) / 2 - 5, (listDiem[i].Y + listDiem[j].Y) / 2 - 5);

                        // Thêm cạnh vừa nối vào listBoxCanh (cạnh đó là 1 items của listBoxCanh) 
                        listBoxCanh.Items.Add((i + 1).ToString() + "-" + (j + 1).ToString() + ": " + MaTran[i, j].ToString());
                    }
                }
            }

            // Thao tác trên listBoxDinh 
            listBoxDinh.Items.Clear();
            for (int i = 0; i < listDiem.Count; i++) // Vẽ đỉnh 
            {
                // Vẽ 1 hình tròn có viền màu DarkCyan và nền màu White 
                g.FillEllipse(slbrDarkCyan, listDiem[i].X - 5, listDiem[i].Y - 5, 40, 40);
                g.DrawEllipse(penTrang, listDiem[i].X - 5, listDiem[i].Y - 5, 40, 40);

                // Ghi tên đỉnh vào giữa hình tròn 
                Font font = new Font("UTM Aptima", 12, FontStyle.Bold);
                g.DrawString((i + 1).ToString(), font, slbrTrang, listDiem[i].X + 5, listDiem[i].Y - 3);

                // Thêm đỉnh vừa tạo vào listBoxDinh (đỉnh đó là 1 items của listBoxDinh) 
                listBoxDinh.Items.Add("Đỉnh " + (i + 1).ToString());
            }

            // Xuất ma trận kề vào ô textBox tBox_MaTranKe 
            tBox_MaTranKe.Text = listDiem.Count.ToString() + "\r\n";
            for (int i = 0; i < listDiem.Count; i++)
            {
                for (int j = 0; j < listDiem.Count; j++)
                {
                    // Nếu không phải cột đầu tiên thì tab 
                    if (j != 0)
                        tBox_MaTranKe.Text += " ";
                    // In trọng số, nếu không có trọng số thì mặc định là 0 
                    tBox_MaTranKe.Text += MaTran[i, j].ToString();
                }
                // Nếu không phải dòng cuối thì xuống hàng 
                if (i != listDiem.Count - 1)
                    tBox_MaTranKe.Text += "\r\n";
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            // Click 1 cái vào pictureBox1 thì sẽ thêm 1 Point vào listDiem và listDiem1 
            listDiem.Add(new Point(e.X, e.Y));
            listDiem1.Add(new Point(e.X, e.Y));
            pictureBox1.Refresh();
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            // Kiểm tra đầu vào nếu thiếu gì sẽ thông báo nhắc điền 
            if (tBox_TuDinh.Text == "")
            {
                MessageBox.Show("Nhập thiếu đỉnh đầu!");
                return;
            }
            if (tBox_DenDinh.Text == "")
            {
                MessageBox.Show("Nhập thiếu đỉnh cuối!");
                return;
            }
            int tmp = -1;
            if (!int.TryParse(tBox_TrongSo.Text, out tmp) || tBox_TrongSo.Text == "")
            {
                MessageBox.Show("Sai trọng số!", "Cảnh báo!");
                return;
            }

            // Gán các biến thành int từ trong 3 textbox 
            int tuDinh = Convert.ToInt32(tBox_TuDinh.Text);
            int denDinh = Convert.ToInt32(tBox_DenDinh.Text);
            int trongSo = Convert.ToInt32(tBox_TrongSo.Text);

            // Gán các phần tử trong ma trận bằng trọng số 
            MaTran[tuDinh - 1, denDinh - 1] = trongSo;
            MaTran[denDinh - 1, tuDinh - 1] = trongSo;
            pictureBox1.Refresh();

            // Reset lại textBox 
            tBox_TuDinh.Text = "";
            tBox_DenDinh.Text = "";
            tBox_TrongSo.Text = "";

            // Đưa dấu nháy về tBox_TuDinh 
            tBox_TuDinh.Focus();
        }

        private void btn_KetQua_Click(object sender, EventArgs e)
        {
            string textMT = tBox_MaTranKe.Text;

            // Dùng split cắt string để lấy dòng đầu tiên là số đỉnh 
            string[] lines1 = textMT.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            string _soDinh = lines1[0];
            // Ép kiểu về số nguyên 
            int soDinh = Convert.ToInt32(_soDinh);

            // Dùng split cắt string để bỏ dòng đầu tiên lấy các dòng sau đó 
            string[] lines2 = textMT.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            // Xoá dòng đầu tiên khỏi mảng lines2 
            lines2 = lines2.Skip(1).ToArray();
            // Kết hợp các chuỗi con lại thành 1 chuỗi đơn 
            string _arr = string.Join(Environment.NewLine, lines2);
            // Tách chuỗi thành từng hàng 
            string[] rows = _arr.Split('\n');
            // Khởi tạo mảng 2 chiều 
            int[,] arr = new int[rows.Length, rows.Length];
            for (int i = 0; i < rows.Length; i++)
            {
                // Tách hàng thành các phần tử 
                string[] columns = rows[i].Split(' ');
                for (int j = 0; j < columns.Length; j++)
                {
                    // Chuyển đổi chuỗi thành giá trị số nguyên 
                    arr[i, j] = Convert.ToInt32(columns[j]);
                }
            }

            // Chạy thuật toán Dijkstra 
            Dijkstra.GRAPH g = new Dijkstra.GRAPH(soDinh);
            g.maTran = arr;

            // kiểm tra xem giá trị nhập vào từ hai ô text có thể chuyển đổi thành số nguyên hay không (kiểm tra tính hợp lệ của đầu vào) 
            int x, y; 
            if (int.TryParse(tBox_ChayTuDinh.Text, out x) && int.TryParse(tBox_ChayDenDinh.Text, out y))
            {
                tBox_KetQuaDijkstra.Text = dijk.ketQuaChay(g, x - 1, y - 1); 
                tBox_TongGiaTri.Text = dijk.tongDuongDi(g, x - 1, y - 1);
                textLuuV = dijk.luuv(g, x - 1, y - 1); 
                textLuuU = dijk.luuu(g, x - 1, y - 1); 
            }

            // 
            StartDrawing(); 
            pictureBox2.Refresh(); 
        }

        // Mở form "FormDijkstraFile" 
        private void btn_DocFile_Click(object sender, EventArgs e)
        {
            Form newForm = new FormDijkstraFile(); 
            newForm.Show(); 
        }

        // Vẽ đồ thị có thời gian 
        private int drawCounter = 0; // Biến đếm thời gian 
        private void DrawTimer_Tick(object sender, EventArgs e)
        {
            drawCounter++; // Tăng biến đếm thời gian 
            pictureBox2.Invalidate(); // Vẽ lại hình ảnh trên pictureBox2 
        }
        private void StartDrawing()
        {
            drawCounter = 0;
            DrawTimer.Start();
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            if (listDiem1.Count != 0)
            {
                Graphics g = e.Graphics;
                // Bật chế độ này để làm mượt đường vẽ, giảm thiểu hiện tượng răng cưa 
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Lấy dữ liệu số đỉnh từ tBox_MaTranKe 
                string textMT = tBox_MaTranKe.Text;
                string[] lines1 = textMT.Split(new string[] { "\r\n" }, StringSplitOptions.None);
                string _soDinh = lines1[0];
                int soDinh = Convert.ToInt32(_soDinh);

                // Khai báo 1 graph từ class Prim 
                Dijkstra.GRAPH graph = new Dijkstra.GRAPH(soDinh);

                // Đưa textLuuV thành mảng 1 chiều số nguyên 
                string[] strarrayV = textLuuV.Split(new[] { "\r\n" }, StringSplitOptions.None);
                int[] intarrayV = new int[strarrayV.Length];
                for (int i = 0; i < strarrayV.Length; i++)
                {
                    intarrayV[i] = Convert.ToInt32(strarrayV[i]); 
                }

                // Đưa textLuuU thành mảng 1 chiều số nguyên 
                string[] strarrayU = textLuuU.Split(new[] { "\r\n" }, StringSplitOptions.None);
                int[] intarrayU = new int[strarrayU.Length];
                for (int i = 0; i < strarrayV.Length; i++)
                {
                    intarrayU[i] = Convert.ToInt32(strarrayU[i]); 
                }

                // Gộp 2 mảng lại 
                int[] intarr = intarrayV.Union(intarrayU).ToArray();

                // Khai báo mảng Point 
                Point[] diem = new Point[listDiem1.Count()];

                // Tạo các đỉnh dựa theo Kết quả
                for (int i = 0; i < intarrayV.Length; i++)
                {
                    for (int d = 0; d < listDiem1.Count(); d++)
                    {
                        // Tạo các đỉnh có toạ độ
                        diem[d] = new Point(listDiem1[intarr[i]].X, listDiem1[intarr[i]].Y);

                        // Định dạng đỉnh
                        /*
                         if (i == Convert.ToInt32(tBox_ChayTuDinh.Text) - 1 || i == Convert.ToInt32(tBox_ChayDenDinh.Text) - 1)
                        {
                            g.FillEllipse(slbrBlue, diem[d].X - 5, diem[d].Y - 5, 40, 40);
                        }
                        else
                        {
                            g.FillEllipse(slbrDarkCyan, diem[d].X - 5, diem[d].Y - 5, 40, 40);
                        }
                        */
                        g.FillEllipse(slbrDarkCyan, diem[d].X - 5, diem[d].Y - 5, 40, 40); 
                        g.DrawEllipse(penTrang, diem[d].X - 5, diem[d].Y - 5, 40, 40);
                        Font font = new Font("UTM Aptima", 12, FontStyle.Bold);
                        g.DrawString(Convert.ToString(intarr[i] + 1), font, slbrTrang, diem[d].X + 5, diem[d].Y - 3);
                    }
                }

                // Vẽ đường nối giữa 2 đỉnh dựa theo Kết quả 
                for (int i = 1; i < intarrayV.Length && i < drawCounter; i++) // nếu i = 0 thì sẽ bị dư đường nối ban đầu 
                {
                    // Tạo đối tượng mũi tên
                    AdjustableArrowCap arrowCap = new AdjustableArrowCap(5, 5);

                    // Tạo đối tượng Pen với mũi tên
                    penDo.CustomEndCap = arrowCap;

                    // Vẽ đường dẫn với mũi tên
                    g.DrawLine(penDo, listDiem1[intarrayU[i]], listDiem1[intarrayV[i]]);
                }

                if (drawCounter >= listBoxDinh.Items.Count && drawCounter >= intarrayV.Length)
                {
                    // Hiệu ứng vẽ đã hoàn thành, dừng Timer
                    DrawTimer.Stop();
                }
            }
        }
    }
}
