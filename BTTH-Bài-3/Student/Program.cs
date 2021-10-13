using System;
using System.IO;
using System.Collections.Generic;


namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tSTUDENT\n");

           try
            {
                using (StreamReader sr = new StreamReader(@"D:/Practice/Source/student.txt"))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                        Console.WriteLine(line);
                }    
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("\nKhong tim thay file \"student.txt\"");
            }
            catch (Exception e)
            {
                Console.WriteLine("\nError: " + e.Message);
            }

            List<SinhVien> sv = new List<SinhVien>();

            Boolean flag = true;
            int choose;    

            do
            {
                try
                {
                    Console.WriteLine("\n\tMenu");
                    Console.WriteLine("1. Them sinh vien");
                    Console.WriteLine("2. Cap nhat thong tin sinh vien boi ID");
                    Console.WriteLine("3. Xoa sinh vien boi ID");
                    Console.WriteLine("4. Tim kiem danh sach sinh vien");
                    Console.WriteLine("5. Sap xep danh sach sinh vien theo diem trung binh");
                    Console.WriteLine("6. Sap xep danh sach sinh vien theo ten");
                    Console.WriteLine("7. Hien thi danh sach sinh vien");
                    Console.WriteLine("8. Ghi danh sach sinh vien vao file \"student.txt\"");
                    Console.WriteLine("0. Thoat");

                    do
                    {
                        Console.Write("\nMoi ban chon: ");
                        choose = int.Parse(Console.ReadLine());
                        if (choose  > 8 || choose < 0)
                            Console.Write("\nLua chon khong co trong menu. Vui long chon lai.");
                    } while (choose > 8 || choose < 0);

                    switch (choose)
                    {
                        case 1:
                            Console.Write("\nNhap so luong sinh vien ban muon them: ");
                            int num1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Nhap thong tin sinh vien ban muon them: ");
                            for (int i = 0; i < num1; i++)
                            {
                                Console.WriteLine("\nSinh vien {0}: ", (i + 1));
                                SinhVien temp = new SinhVien();

                                temp.input();
                                sv.Add(temp);
                                
                            }

                            flag = true;
                            break;

                        case 2:
                            Console.Write("\nNhap ma sinh vien ban muon cap nhat thong tin: ");
                            int id2 = int.Parse(Console.ReadLine());
                            int check2 = 1;
                            for(int i = 0; i < sv.Count; i++)
                            {
                                int tmp = sv[i].id;
                                if (id2 == tmp)
                                {
                                    SinhVien temp = new SinhVien();
                                    temp.input();
                                    sv.RemoveAt(i);
                                    sv.Insert(i, temp);
                                    Console.WriteLine("\nCap nhat thanh cong");
                                }

                                else
                                    check2++;
                            }

                            if (check2 == sv.Count)
                                Console.WriteLine("\nKhong ton tai sinh vien co ma {0} trong lop.", id2);

                            flag = true;
                            break;

                        case 3:
                            Console.Write("\nNhap ma sinh vien ban muon xoa: ");
                            int id3 = int.Parse(Console.ReadLine());
                            int check3 = 1;
                            for (int i = 0; i < sv.Count; i++)
                            {
                                int tmp = sv[i].id;
                                if (id3 == tmp)
                                {
                                    sv.RemoveAt(i);
                                    Console.WriteLine("\nXoa thanh cong");
                                }
                                else
                                    check3++;
                            }

                            if (check3 == sv.Count)
                                Console.WriteLine("\nKhong ton tai sinh vien co ma {0} trong lop.", id3);

                            flag = true;
                            break;

                        case 4:
                            Console.Write("\nNhap ten sinh vien ban muon tim kiem: ");
                            string name4 = Console.ReadLine();
                            int check4 = 0;
                            for (int i = 0; i < sv.Count; i++)
                            {
                                bool isExist = sv[i].hoTen.Contains(name4);
                                if (isExist == true)
                                {
                                    Console.WriteLine("\nThong tin cac sinh vien co ten {0} la: ", name4);
                                    sv[i].output();
                                }
                                else check4++;
                            }
                                
                            if(check4 == sv.Count)
                                Console.WriteLine("\nKhong tim thay sinh vien co ten {0} trong danh sach",name4);

                            flag = true;
                            break;

                        case 5:
                            for(int i = 0; i < sv.Count; i++)
                            {
                                for(int j = i + 1; j < sv.Count; j++)
                                {
                                    if((sv[i].diemToan + sv[i].diemLy + sv[i].diemHoa) > (sv[j].diemToan + sv[j].diemLy + sv[j].diemHoa))
                                    {
                                        SinhVien temp = new SinhVien();
                                        temp = sv[i];
                                        sv[i] = sv[j];
                                        sv[j] = temp;
                                    }
                                }
                            }
                            Console.WriteLine("\tDanh sach sinh vien sau khi sap xep theo diem trung binh\n");
                            Console.WriteLine($"{"ID",10}  {"Ho Ten",20} {"Gioi Tinh",10} {"Tuoi",10} {"Diem Toan",10} {"Diem Ly",10} {"Diem Hoa",10} {"Diem TB",20} {"Hoc Luc",10}");

                            foreach (SinhVien i in sv)
                            {
                                i.output();
                            }

                            flag = true;
                            break;

                        case 6:
                            for (int i = 0; i < sv.Count; i++)
                            {
                                for (int j = i + 1; j < sv.Count; j++)
                                {
                                    if ((sv[i].hoTen.CompareTo(sv[j].hoTen)) > 0)
                                    {
                                        SinhVien temp = new SinhVien();
                                        temp = sv[i];
                                        sv[i] = sv[j];
                                        sv[j] = temp;
                                    }
                                }
                            }
                            Console.WriteLine("\tDanh sach sinh vien sau khi sap xep theo ten\n");
                            Console.WriteLine($"{"ID",10}  {"Ho Ten",20} {"Gioi Tinh",10} {"Tuoi",10} {"Diem Toan",10} {"Diem Ly",10} {"Diem Hoa",10} {"Diem TB",20} {"Hoc Luc",10}");

                            foreach (SinhVien i in sv)
                            {
                                i.output();
                            }
                            flag = true;
                            break;

                        case 7:
                            Console.WriteLine("\tDanh sach sinh vien\n");
                            Console.WriteLine($"{"ID",10}  {"Ho Ten",20} {"Gioi Tinh",10} {"Tuoi",10} {"Diem Toan",10} {"Diem Ly",10} {"Diem Hoa",10} {"Diem TB",20} {"Hoc Luc",10}");

                            foreach (SinhVien i in sv)
                            {
                                i.output();
                            }
                            flag = true;
                            break;

                        case 8:
                            try
                            {
                                using (StreamWriter sw = new StreamWriter(@"D:/Practice/Source/student.txt"))
                                {
                                    sw.WriteLine($"{"ID",10}  {"Ho Ten",20} {"Gioi Tinh",10} {"Tuoi",10} {"Diem Toan",10} {"Diem Ly",10} {"Diem Hoa",10} {"Diem TB",20} {"Hoc Luc",20}");

                                    foreach (SinhVien i in sv)
                                    {
                                        int id = i.id;
                                        string name = i.hoTen;
                                        string sex = i.gioiTinh;
                                        int age = i.tuoi;
                                        double Mmark = i.diemToan;
                                        double Pmark = i.diemLy;
                                        double Cmark = i.diemHoa;
                                        double average = i.DiemTB(Mmark, Pmark, Cmark);
                                        string type = i.HocLuc(average);

                                        sw.WriteLine($"{id,10} {name,20} {sex,10} {age,10} {Mmark,10} {Pmark,10} {Cmark,10} {Math.Round(average, 2),20} {type,20} ");
                                    }

                                }

                                Console.WriteLine("\nGhi file thanh cong");
                            }
                            catch(FileNotFoundException)
                            {
                                Console.WriteLine("\nKhong tim thay file chi dinh");
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine("\nError: " + e.Message);
                            }
                            flag = true;
                            break;

                        case 0:
                            Console.WriteLine("\nHen gap lai");
                            flag = false;
                            break;
                    }
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("\nError: " + fe.Message);
                }

            } while (flag);

            Console.ReadKey();

        }
    }
   
    struct SinhVien
    {
        public int id;
        public string hoTen;
        public string gioiTinh;
        public int tuoi;
        public double diemToan, diemLy, diemHoa;

        public void input() //Nhap vao sv
        {
            Console.Write("Nhap ma sinh vien: ");
            id = int.Parse(Console.ReadLine());

            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhap gioi tinh: ");
            gioiTinh = Console.ReadLine();

            do
            {
                Console.Write("Nhap tuoi: ");
                tuoi = int.Parse(Console.ReadLine());

                if (tuoi < 0)
                    Console.WriteLine("\nTuoi khong hop le. Hay nhap lai");
            } while (tuoi < 0);

            do
            {
                Console.Write("Nhap diem toan: ");
                diemToan = double.Parse(Console.ReadLine());

                if (diemToan > 10 || diemToan < 0)
                    Console.WriteLine("\nDiem nhap khong hop le. Hay nhap lai");
            } while (diemToan > 10 || diemToan < 0);

            do
            {
                Console.Write("Nhap diem ly: ");
                diemLy = double.Parse(Console.ReadLine());

                if (diemLy > 10 || diemLy < 0)
                    Console.WriteLine("\nDiem nhap khong hop le. Hay nhap lai");
            } while (diemLy > 10 || diemLy < 0);

            do
            {
                Console.Write("Nhap diem hoa: ");
                diemHoa = double.Parse(Console.ReadLine());

                if (diemHoa > 10 || diemHoa < 0)
                    Console.WriteLine("\nDiem nhap khong hop le. Hay nhap lai");
            } while (diemHoa > 10 || diemHoa < 0);
        }

        public void output() //Hien thi sv
        {
            double diemTB = DiemTB(diemToan, diemLy, diemHoa); //tinh diem tb
            string hocLuc = HocLuc(diemTB);

            //hien thi ra man hinh
            Console.WriteLine($"{id,10} {hoTen,20} {gioiTinh,10} {tuoi,10} {diemToan,10} {diemLy,10} {diemHoa,10} {Math.Round(diemTB, 2),20} {hocLuc,10}");
        }

        public double DiemTB(double a, double b, double c)
        {
            return (a + b + c) / 3;
        }

        public string HocLuc(double diem)
        {
            string HL = "";
            if (diem >= 8) HL = "Gioi";
            if (diem < 8 && diem >= 6.5) HL = "Kha";
            if (diem < 6.5 && diem >= 5) HL = "Trung binh";
            if (diem < 5) HL = "Yeu";

            return HL;
        }
    }


}


