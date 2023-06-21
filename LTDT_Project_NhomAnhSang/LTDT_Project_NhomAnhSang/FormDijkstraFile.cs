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

namespace LTDT_Project_NhomAnhSang
{
    public partial class FormDijkstraFile : Form
    {
        // Khởi tạo ban đầu 
        public List<Point> listDiem = new List<Point>();
        public List<Point> listDiem1 = new List<Point>();
        public int[,] MaTran = new int[100, 100];
        public Dijkstra dijk = new Dijkstra();
        string textLuuV = "0", textLuuU = "0";

        // Khai báo bảng màu color 
        Pen penDen = new Pen(Color.Black, 1);
        Pen penTrang = new Pen(Color.White, 2);
        Pen penDo = new Pen(Color.Red, 3);
        SolidBrush slbrTrang = new SolidBrush(Color.White);
        SolidBrush slbrDen = new SolidBrush(Color.Black);
        SolidBrush slbrDarkCyan = new SolidBrush(Color.DarkCyan);
        SolidBrush slbrPaleTurquoise = new SolidBrush(Color.PaleTurquoise);
        SolidBrush slbrBlue = new SolidBrush(Color.Blue);
        SolidBrush slbrRed = new SolidBrush(Color.Red);

        public FormDijkstraFile()
        {
            InitializeComponent();
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

            StartDrawing();
            pictureBox2.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // Bật chế độ này để làm mượt đường vẽ, giảm thiểu hiện tượng răng cưa 
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int soDinh = listBoxDinh.Items.Count; // để lưu số lượng điểm trong đồ thị 
            int banKinh = 20; // để lưu bán kính của đỉnh được vẽ 
            // Tọa độ trung tâm của đồ thị, tức là tọa độ (x, y) của tâm hình tròn 
            int centerX = pictureBox1.Width / 2; 
            int centerY = pictureBox1.Height / 2; 
            int khoangCanh = 110; // Khoảng cách từ tâm đồ thị đến các điểm trên đường tròn, cũng là bán kính của đồ thị 

            // Thao tác với cạnh 
            for (int i = 0; i < soDinh; i++)
            {
                for (int j = 0; j < soDinh; j++)
                {
                    // Nếu có cạnh nối giữa hai đỉnh i và j 
                    if (MaTran[i, j] != 0)
                    {
                        // để tính toán giá trị x và y dựa trên góc quay i trong khoảng từ 0 đến 2π (hoặc từ 0 đến 360 độ) 
                        // cho phép các điểm được phân bố đều trên đường tròn 
                        int x1 = centerX + (int)(khoangCanh * Math.Cos(2 * Math.PI * i / soDinh));
                        int y1 = centerY + (int)(khoangCanh * Math.Sin(2 * Math.PI * i / soDinh));
                        int x2 = centerX + (int)(khoangCanh * Math.Cos(2 * Math.PI * j / soDinh));
                        int y2 = centerY + (int)(khoangCanh * Math.Sin(2 * Math.PI * j / soDinh));

                        // Vẽ đường nối giữa 2 điểm (x1,y1) và (x2,y2) 
                        g.DrawLine(penDen, x1, y1, x2, y2);

                        // Tọa độ của điểm trung điểm nằm giữa hai điểm (x1, y1) và (x2, y2) 
                        int midX = (x1 + x2) / 2; 
                        int midY = (y1 + y2) / 2;

                        // tính toán kích thước của chuỗi trọng số MaTran[i, j] khi được hiển thị trên đồ thị. Kích thước này sẽ được sử dụng để căn chỉnh vị trí của chuỗi trọng số 
                        SizeF distanceSize = g.MeasureString(MaTran[i, j].ToString(), Font);
                        Font font = new Font("Tahoma", 9, FontStyle.Bold);
                        // Ghi trọng số của cạnh MaTran[i, j] tại điểm trung điểm 
                        g.DrawString(MaTran[i, j].ToString(), font, slbrBlue, midX - distanceSize.Width / 2, midY - distanceSize.Height / 2);
                    }
                }
            }

            // Thao tác với đỉnh 
            for (int i = 0; i < soDinh; i++)
            {
                // Tính toán tọa độ (x, y) của đỉnh thứ i dựa trên công thức hình tròn 
                int x = centerX + (int)(khoangCanh * Math.Cos(2 * Math.PI * i / soDinh)) - banKinh;
                int y = centerY + (int)(khoangCanh * Math.Sin(2 * Math.PI * i / soDinh)) - banKinh;

                // Vẽ hình elip (đỉnh) tại tọa độ (x, y) 
                g.FillEllipse(slbrDarkCyan, x, y, banKinh * 2, banKinh * 2);
                g.DrawEllipse(penTrang, x, y, banKinh * 2, banKinh * 2);

                // Ghi tên đỉnh 
                SizeF labelSize = g.MeasureString((i + 1).ToString(), Font); 
                Font font = new Font("UTM Aptima", 12, FontStyle.Bold); 
                g.DrawString((i + 1).ToString(), font, slbrTrang, x + banKinh - labelSize.Width / 2 - 3, y + banKinh - labelSize.Height / 2 - 6);
            }
        }
        private int drawCounter = 0; // là một biến đếm được tăng lên mỗi khi một đỉnh hoặc một cạnh được vẽ 
        private void pictureBox2_Paint(object sender, PaintEventArgs e)
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

            
            int banKinh = 20; // để lưu bán kính của đỉnh được vẽ 
            int centerX = pictureBox1.Width / 2; // nửa chiều rộng pictureBox1 
            int centerY = pictureBox1.Height / 2; // nửa chiều cao pictureBox1 
            int khoangCanh = 110; // để lưu khoảng cách từ tâm đồ thị đến các đỉnh             int khoangCanh = 110;

            // Tạo các đỉnh dựa theo Kết quả (giống trên) 
            for (int i = 0; i < listBoxDinh.Items.Count; i++)
            {
                // Tính toán tọa độ (x, y) của đỉnh thứ i dựa trên công thức hình tròn 
                int x = centerX + (int)(khoangCanh * Math.Cos(2 * Math.PI * i / listBoxDinh.Items.Count)) - banKinh;
                int y = centerY + (int)(khoangCanh * Math.Sin(2 * Math.PI * i / listBoxDinh.Items.Count)) - banKinh;

                // Vẽ hình elip (đỉnh) tại tọa độ (x, y) 
                /*
                if (i == Convert.ToInt32(tBox_ChayTuDinh.Text) - 1 || i == Convert.ToInt32(tBox_ChayDenDinh.Text) - 1)
                {
                    g.FillEllipse(slbrBlue, x, y, banKinh * 2, banKinh * 2);
                }
                else
                {
                    g.FillEllipse(slbrDarkCyan, x, y, banKinh * 2, banKinh * 2); 
                }
                */
                g.FillEllipse(slbrDarkCyan, x, y, banKinh * 2, banKinh * 2);
                g.DrawEllipse(penTrang, x, y, banKinh * 2, banKinh * 2);

                // Ghi tên đỉnh 
                SizeF labelSize = g.MeasureString((i + 1).ToString(), Font);
                Font font = new Font("UTM Aptima", 12, FontStyle.Bold);
                g.DrawString((i + 1).ToString(), font, slbrTrang, x + banKinh - labelSize.Width / 2 - 3, y + banKinh - labelSize.Height / 2 - 6);
            }

            // Thao tác với cạnh 
            for (int i = 1; i < intarrayV.Length && i < drawCounter; i++)
            {
                int j = i; // Chỉ duyệt qua phần tử tương ứng trong intarrayU
                if (MaTran[intarrayV[i], intarrayU[j]] != 0)
                {
                    // để tính toán giá trị x và y dựa trên góc quay i trong khoảng từ 0 đến 2π (hoặc từ 0 đến 360 độ) 
                    // cho phép các điểm được phân bố đều trên đường tròn 
                    int x1 = centerX + (int)(khoangCanh * Math.Cos(2 * Math.PI * intarrayV[i] / listBoxDinh.Items.Count));
                    int y1 = centerY + (int)(khoangCanh * Math.Sin(2 * Math.PI * intarrayV[i] / listBoxDinh.Items.Count));
                    int x2 = centerX + (int)(khoangCanh * Math.Cos(2 * Math.PI * intarrayU[j] / listBoxDinh.Items.Count));
                    int y2 = centerY + (int)(khoangCanh * Math.Sin(2 * Math.PI * intarrayU[j] / listBoxDinh.Items.Count));

                    // Vẽ đường nối giữa 2 đỉnh  
                    // Tạo đối tượng mũi tên
                    AdjustableArrowCap arrowCap = new AdjustableArrowCap(5, 5);

                    // Tạo đối tượng Pen với mũi tên
                    penDo.CustomEndCap = arrowCap;

                    // Vẽ đường dẫn với mũi tên
                    g.DrawLine(penDo, x2, y2, x1, y1);
                }
            }

            // Kiểm tra xem đã vẽ đủ các đỉnh và cạnh trong đồ thị hay chưa 
            if (drawCounter >= listBoxDinh.Items.Count && drawCounter >= intarrayV.Length)
            {
                // Dừng quá trình vẽ và hiệu ứng vẽ đã hoàn thành 
                drawTimer.Stop();
            }
        }
        private void drawTimer_Tick(object sender, EventArgs e) // Sự kiện này được kích hoạt theo một khoảng thời gian đã định trước 
        {
            drawCounter++; // Tăng biến đếm thời gian, số lần đã trôi qua trong quá trình vẽ 
            pictureBox2.Invalidate(); // Vẽ lại hình ảnh trên pictureBox2
        }
        private void StartDrawing() // được sử dụng để khởi động quá trình vẽ 
        {
            drawCounter = 0; // đặt lại biến đếm thời gian về trạng thái ban đầu 
            drawTimer.Start(); // Kích hoạt Timer, Khi Timer được kích hoạt, sự kiện Tick sẽ được gọi theo khoảng thời gian đã định, và quá trình vẽ sẽ bắt đầu thông qua sự kiện Tick của Timer và sự kiện Paint của PictureBox 
        }
        private void btn_DocFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Thiết lập các thuộc tính của OpenFileDialog
            openFileDialog.Title = "Open Text File";
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Đọc nội dung của file và hiển thị vào TextBox
                string fileContent = File.ReadAllText(filePath);
                tBox_MaTranKe.Text = fileContent;
            }

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

            // Gán MaTran = arr vừa tạo & Thêm vào listBox Đỉnh và Cạnh 
            for (int i = 0; i < soDinh; i++)
            {
                for (int j = 0; j < soDinh; j++)
                {
                    MaTran[i, j] = arr[i, j];
                    MaTran[j, i] = arr[j, i];
                    listBoxCanh.Items.Add((i + 1).ToString() + "-" + (j + 1).ToString() + ": " + MaTran[i, j].ToString());
                }
                listBoxDinh.Items.Add("Đỉnh " + (i + 1).ToString());
            }

            pictureBox1.Refresh();
        }

    }
}
