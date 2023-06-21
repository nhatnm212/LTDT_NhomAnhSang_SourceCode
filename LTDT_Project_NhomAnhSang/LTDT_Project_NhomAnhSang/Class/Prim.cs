using System;
using System.Collections.Generic;
using System.Text;

namespace LTDT_Project_NhomAnhSang
{
    public class Prim
    {
        public struct GRAPH
        {
            public int soDinh; 
            public int[,] maTran; 
            public int[] visited; // đánh dấu đỉnh i đã xét hay chưa, nếu 0 là chưa xét 

            public GRAPH(int soDinh)
            {
                this.soDinh = soDinh;
                this.maTran = new int[100, 100];
                this.visited = new int[100]; 
            }
        }
        public struct CANH
        {
            public int u; // Đỉnh thứ nhất 
            public int v; // Đỉnh thứ hai 
            public int trongSo; 
        }
        CANH[] T = new CANH[100]; // Mảng lưu các cạnh trong Prim 
        int nT = 0; // Gán số cạnh của cây khung ban đầu = 0 
        public void DuyetPrim(GRAPH g)
        {
            for (int i = 0; i < g.soDinh; i++)
            {
                g.visited[i] = 0; // Khởi tạo nhãn các đỉnh thứ i là chưa được duyệt = 0 
            }
            g.visited[0] = 1; // Đánh dấu đỉnh 0 là đã duyệt 
            while (nT < g.soDinh - 1) // Nếu đủ n-1 cạnh thì dừng lại 
            {
                // Tạo canhNhoNhat để lưu cạnh nhỏ nhất từ 1 đỉnh đã xét đến đỉnh chưa xét 
                CANH canhNhoNhat = new CANH(); // để lưu trữ cạnh nhỏ nhất từ 1 đỉnh đã xét đến đỉnh chưa xét 
                int min = -1; // đại diện cho cạnh nhỏ nhất 
                for (int i = 0; i < g.soDinh; i++)
                {
                    if (g.visited[i] == 0) // Kiểm tra xem đỉnh thứ i có được xét chưa? 
                    {
                        for (int j = 0; j < g.soDinh; j++)
                        {
                            if (g.visited[j] == 1 && (g.maTran[i, j] != 0)) // Kiểm tra xem đỉnh j đã được xét (nhãn là 1 - đã được duyệt) và có cạnh nối từ i đến j không ?  
                            {
                                if (min == -1 || g.maTran[i, j] < min) // Kiểm tra xem giá trị min hiện tại có là giá trị nhỏ nhất hay không ?  
                                {
                                    min = g.maTran[i, j]; // min = giá trị cạnh từ đỉnh i đến j 
                                    canhNhoNhat.u = i; 
                                    canhNhoNhat.v = j; 
                                    canhNhoNhat.trongSo = g.maTran[i, j]; // giá trị của cạnh từ i đến j 
                                }
                            }
                        }
                    }
                }
                T[nT] = canhNhoNhat; // Thêm cạnh nhỏ nhất vào tập T 
                nT++; // Tăng số cạnh lên 1 
                g.visited[canhNhoNhat.u] = 1; // Đánh dấu đỉnh u của cạnh nhỏ nhất đã được duyệt 
            }
        }

        // Xuất kết quả cây khung nhỏ nhất của đồ thị 
        public string ketQuaChay(GRAPH g)
        {
            DuyetPrim(g); 
            string tmp = "";
            string kq = "";
            for (int i = 0; i < nT; i++)
            {
                int _v = T[i].v + 1;
                int _u = T[i].u + 1;
                tmp = "(" + _v + "," + _u + ")\r\n";
                if (tmp != "(1,1)\r\n")
                    kq += tmp; 
            }
            return kq;
        }
        // Xuất tổng giá trị của cây 
        public string tongGiaTri(GRAPH g)
        {
            DuyetPrim(g);
            int sum = 0;
            for (int i = 0; i < nT; i++)
            {
                sum += T[i].trongSo;
            }
            return Convert.ToString(sum);
        }
        // Trả về kết quả là tập hợp các đỉnh thứ hai 
        public string luuv(GRAPH g)
        {
            DuyetPrim(g);
            string tmp = "";
            string kq = "";
            for (int i = 0; i < nT; i++)
            {
                int _v = T[i].v;
                tmp = _v + "\r\n";
                kq += tmp;
            }
            return kq;
        }
        // Trả về kết quả là tập hợp các đỉnh thứ nhất 
        public string luuu(GRAPH g)
        {
            DuyetPrim(g);
            string tmp = "";
            string kq = "";
            for (int i = 0; i < nT; i++)
            {
                int _u = T[i].u;
                tmp = _u + "\r\n";
                kq += tmp;
            }
            return kq;
        }
    }
}
