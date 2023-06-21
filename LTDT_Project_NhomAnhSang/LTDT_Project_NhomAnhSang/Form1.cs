using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTDT_Project_NhomAnhSang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Form FormChild;

        // Hàm để form con mà muốn hiển thị lên form cha 
        public void OpenFormChild(Form childFrom)
        {
            //nếu khởi tạo rồi thì đóng lại
            if (FormChild != null)
            {
                FormChild.Close();
            }
            FormChild = childFrom; // để lưu trữ form con được hiển thị 
            childFrom.TopLevel = false; // cho phép form con được hiển thị trên form cha và không trở thành một cửa sổ độc lập 
            childFrom.FormBorderStyle = FormBorderStyle.None; // không có khung viền ngoài 
            childFrom.Dock = DockStyle.Fill; // cho phép form con lấp đầy toàn bộ không gian trong pictureBox1 
            pictureBox1.Controls.Add(childFrom); // Thêm childForm vào danh sách các control của pictureBox1 
            pictureBox1.Tag = childFrom; // để có thể chuyển dữ liệu giữa các control 
            childFrom.BringToFront(); // form con được hiển thị trên cùng 
            childFrom.Show(); // Hiển thị form con lên màn hình 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFormChild(new FormPrim());
        }
        private void label4_Click(object sender, EventArgs e)
        {
            if (FormChild != null)
            {
                FormChild.Close();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            OpenFormChild(new FormInfo()); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFormChild(new FormDijkstra()); 
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true; 
            }
        }
    }
}
