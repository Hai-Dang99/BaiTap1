using System;
using System.Collections;

namespace ViDuMangArrayList
{
    class Program
    {
        class PhanSo
        {
            int TS, MS;
            public PhanSo() // ham khoi tao khong tham so
            {
                TS = 0;
                MS = 1;
            }

            public void NhapPS()
            {
                Console.Write("Nhap vao TS: ");
                string TempTS = Console.ReadLine();
                TS = int.Parse(TempTS);
                Console.Write("Nhap vao MS: ");
                string TempMS = Console.ReadLine();
                MS = int.Parse(TempMS);
            }
            public void XuatPS()
            {
                Console.WriteLine("{0}/{1}", ToiGianPS().TS, ToiGianPS().MS);
            }

            public PhanSo(int ts, int ms)
            {
                TS = ts;
                MS = ms;
            }

            public PhanSo CongPS(PhanSo ps1)
            {
                int ts = TS * ps1.MS + MS * ps1.TS;
                int ms = MS * ps1.MS;
                PhanSo Ketqua = new PhanSo(ts, ms);
                return Ketqua;
            }

            public PhanSo TruPS(PhanSo ps1)
            {
                int ts = TS * ps1.MS - MS * ps1.TS;
                int ms = MS * ps1.MS;
                PhanSo Ketqua = new PhanSo(ts, ms);
                return Ketqua;
            }

            public PhanSo NhanPS(PhanSo ps1)
            {
                int ts = TS * ps1.TS;
                int ms = MS * ps1.MS;

                PhanSo Ketqua = new PhanSo(ts, ms);
                return Ketqua;
            }


            public PhanSo ChiaPS(PhanSo ps1)
            {
                int ts = TS * ps1.MS;
                int ms = MS * ps1.TS;

                PhanSo Ketqua = new PhanSo(ts, ms);
                return Ketqua;
            }

            public int UCLN()
            {
                int ts = TS;
                int ms = MS;
                while (ts != ms)
                {
                    if (ts > ms)
                    {
                        ts = ts - ms;
                    }
                    else if (ms > ts)
                    {
                        ms = ms - ts;
                    }
                };

                return ts;
            }

            public PhanSo ToiGianPS() // neu thich co the dung ham void de toi gian truc tiep vao phan so luon
            {
                int ts = TS / UCLN();
                int ms = MS / UCLN();
                PhanSo toigian = new PhanSo(ts, ms);
                return toigian;
            }

            public int LayTS()
            {
                return TS;
            }
            public int LayMS()
            {
                return MS;
            }
        };
        //class Program
        //{
        //    static void Main(string[] args)
        //    {
        //        //Console.WriteLine("Hello World!");
        //        string ten;
        //        Console.Write("Nhap vao ten: ");
        //        ten = Console.ReadLine();
        //        Console.WriteLine("Chao mung {0} den voi ung dung lop Phan So", ten);
        //        Console.WriteLine("Bat dau nao!");

        //        PhanSo a = new PhanSo();
        //        PhanSo b = new PhanSo();
        //        PhanSo c = new PhanSo();
        //        PhanSo d = new PhanSo();
        //        PhanSo e = new PhanSo();
        //        PhanSo f = new PhanSo();
        //        Console.WriteLine("Nhap vao Phan So a:");
        //        a.NhapPS();
        //        //Console.Write("Phan a so vua nhap la: ");
        //        //a.XuatPS();
        //        Console.WriteLine("Nhap vao Phan So b:");
        //        b.NhapPS();
        //        //Console.Write("Phan so b vua nhap la: ");
        //        //b.XuatPS();

        //        //c = a.CongPS(b);
        //        //Console.Write("Ket qua {0}/{1} + {2}/{3} = ",a.LayTS(),a.LayMS(),b.LayTS(),b.LayMS());
        //        //c.XuatPS();

        //        //d = a.TruPS(b);
        //        //Console.Write("Ket qua {0}/{1} - {2}/{3} = ", a.LayTS(), a.LayMS(), b.LayTS(), b.LayMS());
        //        //d.XuatPS();

        //        //e = a.NhanPS(b);
        //        //Console.Write("ket qua {0}/{1} * {2}/{3} = ", a.LayTS(), a.LayMS(), b.LayTS(), b.LayMS());
        //        //e.XuatPS();

        //        f = a.ChiaPS(b);
        //        Console.Write("{0}/{1} : {2}/{3} = ", a.LayTS(), a.LayMS(), b.LayTS(), b.LayMS());
        //        f.XuatPS();

        //        Console.ReadKey();

        //    }
        //}
        static void Main(string[] args)
        {
            Console.WriteLine("Mang Phan So:\n");
            ArrayList dsPhanSo = new ArrayList();
            dsPhanSo.Add(new PhanSo(1, 2));
            dsPhanSo.Add(new PhanSo(3, 4));
            dsPhanSo.Add(new PhanSo(5, 6));
            //dsPhanSo.Clear(); //Xóa tất cả phần tử trong mảng
            for (int j = 0; j < dsPhanSo.Count; j++) // Count đếm số phần tử trong mảng -> dsPhanSo.Cout = số phần tử trong mảng
            {
                PhanSo ps = (PhanSo)dsPhanSo[j];

                //Console.WriteLine(ps.LayTS() + “/” + ps.LayMS());
                Console.WriteLine("{0}/{1}", ps.LayTS(), ps.LayMS());
            }

            Console.WriteLine("\nMang Diem:\n");
            ArrayList dsDiem = new ArrayList();
            dsDiem.Add(1);
            dsDiem.Add(2);
            dsDiem.Add(3);
            
            for (int j = 0; j < dsDiem.Count; j++)
            {
                int item = (int)dsDiem[j];
                Console.WriteLine(item);
            }

            int vitri = dsDiem.IndexOf(1); //Tìm vị trí 1 trong mảng
            Console.WriteLine("Vi tri cua 1 trong mang la: {0}", vitri);
            dsDiem.Insert(1, 10); //dsDiem = {1,10,2}
            dsDiem.RemoveAt(1); //Xóa phần tử tại vị trí 1
            for (int j = 0; j < dsDiem.Count; j++)
            {
                int item = (int)dsDiem[j];
                Console.WriteLine(item);
            }
            //int[] arrDiem = (int[])(dsDiem.ToArray(typeof(string)));
            //Trả về mảng int 
            Console.ReadKey();
        }
    }
}
