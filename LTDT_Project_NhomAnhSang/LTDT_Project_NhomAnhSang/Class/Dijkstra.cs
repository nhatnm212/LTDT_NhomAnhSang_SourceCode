using System;
using System.Collections.Generic;
using System.Text;

namespace LTDT_Project_NhomAnhSang
{
    public class Dijkstra
    {
        public struct GRAPH
        {
            public int soDinh;
            public int[,] maTran;

            public GRAPH(int soDinh)
            {
                this.soDinh = soDinh;
                this.maTran = new int[100, 100];
            }
        }

        public bool[] ThuocT = new bool[100]; // mảng này dùng để đánh dấu các đỉnh đã được xét. 
        public int[] Length = new int[100]; // mảng này dùng để lưu trữ độ dài ngắn nhất từ đỉnh xuất phát đến các đỉnh còn lại. 
        public int[] LastV = new int[100]; // mảng này dùng để lưu trữ đỉnh trước đỉnh hiện tại trên đường đi ngắn nhất từ đỉnh xuất phát đến đỉnh đó. 

        public void DuyetDijkstra(GRAPH g, int x, int y)
        {
            for (int i = 0; i < g.soDinh; i++)
            {
                // khởi tạo giá trị ban đầu 
                ThuocT[i] = false;
                Length[i] = int.MaxValue;
                LastV[i] = -1;
            }
            Length[x] = 0;

            int v = x; // để lưu trữ đỉnh hiện tại đang xét 
            while (v != -1)
            {
                ThuocT[v] = true; // Đánh dấu đỉnh hiện tại v là đã xét 
                for (int k = 0; k < g.soDinh; k++) // xét các đỉnh kề của đỉnh v 
                {
                    // Nếu có cạnh nối từ đỉnh v đến đỉnh k, và đỉnh k chưa được xét và có thể tìm được đường đi ngắn hơn từ đỉnh xuất phát đến đỉnh k thông qua đỉnh v 
                    if (g.maTran[v, k] != 0 && !ThuocT[k] && (Length[k] == -1 || Length[k] > Length[v] + g.maTran[v, k]))
                    {
                        // cập nhật độ dài từ đỉnh xuất phát đến đỉnh k và lưu trữ đỉnh trước đỉnh k là v 
                        Length[k] = Length[v] + g.maTran[v, k];
                        LastV[k] = v;
                    }
                }
                v = -1; // để lưu trữ đỉnh chưa được xét có độ dài ngắn nhất 
                for (int i = 0; i < g.soDinh; i++)
                {
                    // kiểm tra xem đỉnh i chưa được xét và có độ dài khác vô cùng 
                    if (!ThuocT[i] && Length[i] != int.MaxValue)
                    {
                        // Nếu đỉnh v chưa được gán giá trị (v == -1) hoặc độ dài từ đỉnh v đến đỉnh đang xét (Length[v]) lớn hơn độ dài từ đỉnh xuất phát đến đỉnh i (Length[i]) 
                        if (v == -1 || Length[v] > Length[i])
                        {
                            v = i;
                        }
                    }
                }
            }
        }

        public string ketQuaChay(GRAPH g, int x, int y)
        {
            DuyetDijkstra(g, x, y);

            int[] DuongDi = new int[100]; // để lưu trữ các đỉnh trên đường đi ngắn nhất từ y về x 
            int v = y; // được sử dụng để duyệt từ y về x 
            int i;
            int id = 0; // để lưu trữ chỉ số của mảng DuongDi 
            while (v != x) // thực hiện việc lưu trữ các đỉnh trên đường đi ngắn nhất từ y về x vào mảng DuongDi 
            {
                DuongDi[id] = v;
                v = LastV[v]; // Gán giá trị của LastV[v] (đỉnh trước v trên đường đi ngắn nhất) cho v để duyệt ngược lên đỉnh trước đó 
                id++;
            }
            DuongDi[id] = x; // đây là đỉnh xuất phát 
            string tmp = "";
            string kq = "";
            // Trả kết quả đi ngược 
            for (i = id; i > 0; i--)
                tmp = tmp + Convert.ToString(DuongDi[i] + 1) + " -> ";
            kq = tmp + Convert.ToString(DuongDi[i] + 1); 
            return kq;
        }

        // Tương tự như trên, nhưng kết quả trả về chỉ là tên đỉnh 
        public string luuv(GRAPH g, int x, int y)
        {
            DuyetDijkstra(g, x, y);

            int[] DuongDi = new int[100];
            int v = y;
            int i;
            int id = 0;
            while (v != x)
            {
                DuongDi[id] = v;
                v = LastV[v];
                id++;
            }
            DuongDi[id] = x;
            string tmp = "";
            string kq = "";
            for (i = id; i > 0; i--)
                tmp = tmp + Convert.ToString(DuongDi[i]) + "\r\n"; 
            kq = tmp + Convert.ToString(DuongDi[i]); 
            return kq;
        }
        // Tương tự như trên, nhưng kết quả trả về chỉ là tên đỉnh + 1 
        public string luuu(GRAPH g, int x, int y)
        {
            DuyetDijkstra(g, x, y);

            int[] DuongDi = new int[100];
            int v = y;
            int i;
            int id = 0;
            while (v != x)
            {
                DuongDi[id] = v;
                v = LastV[v];
                id++;
            }
            DuongDi[id] = x;
            string tmp = "";
            string kq = "";
            for (i = id; i > 0; i--)
                tmp = tmp + Convert.ToString(DuongDi[i+1]) + "\r\n"; 
            kq = tmp + Convert.ToString(DuongDi[i+1]); 
            return kq;
        }

        // Trả về tổng độ dài đường đi 
        public string tongDuongDi(GRAPH g, int x, int y)
        {
            DuyetDijkstra(g, x, y);
            return Convert.ToString(Length[y]); 
        }
    }
}
