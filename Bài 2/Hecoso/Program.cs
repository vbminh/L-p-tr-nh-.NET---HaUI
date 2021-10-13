using System;

namespace Hecoso
{
    class Program
    {

        static void Main(string[] args)
        {
            
            
            Boolean flag;

            Console.WriteLine("\tHe Co So");

            Console.WriteLine("\n1. Doi tu he co so 16 sang he co so  10");
            Console.WriteLine("2. Doi tu he co so 16 sang he co so  2");
            Console.WriteLine("3. Doi tu he co so 10 sang he co so  16");
            Console.WriteLine("4. Doi tu he co so 10 sang he co so  2");
            Console.WriteLine("5. Doi tu he co so 2 sang he co so  16");
            Console.WriteLine("6. Doi tu he co so 2 sang he co so  10");
            Console.WriteLine("Nhap so khac de thoat");

            try
            {
               
                do
                {
                    Console.Write("\n\nBan chon: ");
                    int a = Convert.ToInt32(Console.ReadLine());

                    switch (a)
                    {
                        case 1:
                            try
                            {
                                Console.Write("\nNhap so ban muon doi: ");
                                string value1 = Console.ReadLine();

                                int[] arr1 = convert16toArr(value1); //Đổi số sang mảng số nguyên
                                int result1 = (int)He10(arr1, 16); //Đổi sang hệ cơ số 10;

                                Console.WriteLine("\nKet qua la: " + result1);
                            } catch(Exception)
                            {
                                Console.WriteLine("\nGia tri nhap khong hop le");
                            }

                            flag = true;
                            break;

                        case 2:
                            Console.Write("\nNhap so ban muon doi: ");
                            string value2 = Console.ReadLine();

                            int[] arr2 = convert16toArr(value2); //Đổi số sang mảng số nguyên
                            int result2 = (int)He10(arr2, 16); //Đổi từ hệ 16 sang 10;

                            Console.Write("\nKet qua la: ");
                            He2(result2); //Đổi từ hệ 10 sang 2
                            flag = true;
                            break;

                        case 3:
                            Console.Write("\nNhap so ban muon doi: ");
                            int value3 = Convert.ToInt32(Console.ReadLine());

                            Console.Write("\nKet qua la: ");
                            He16(value3);
                            flag = true;
                            break;

                        case 4:
                            Console.Write("\nNhap so ban muon doi: ");
                            int value4 = Convert.ToInt32(Console.ReadLine());

                            Console.Write("\nKet qua la: ");
                            He2(value4);
                            flag = true;
                            break;

                        case 5:
                            int count = 0;
                            Console.Write("\nNhap so ban muon doi: ");
                            string value5 = Console.ReadLine();

                            int[] arr5 = convert2toArr(value5);

                            for(int i = 0; i  < arr5.Length; i ++)
                            {
                                if (arr5[i] == 0 || arr5[i] == 1)
                                    count++;
                            }

                            if (count == arr5.Length)
                            {
                                int result5 = (int)He10(arr5, 2); //Đổi từ hệ 2 sang hệ 10
                                Console.Write("\nKet qua la: ");
                                He16(result5); //Đổi từ hệ 10 sang hệ 16
                            }
                            else Console.WriteLine("Gia tri nhap khong hop le");
                           
                            flag = true;
                            break;

                        case 6:
                            int dem = 0;
                            Console.Write("\nNhap so ban muon doi: ");
                            string value6 = Console.ReadLine();

                            int[] arr6 = convert2toArr(value6);

                            for(int i = 0; i < arr6.Length; i++)
                            {
                                if (arr6[i] == 0 || arr6[i] == 1)
                                    dem++;
                            }

                            if(dem == arr6.Length)
                            {
                                int result6 = (int)He10(arr6, 2); //Đổi từ hệ 2 sang hệ 10
                                Console.WriteLine("\nKet qua la: " + result6);
                            }
                            else Console.WriteLine("Gia tri nhap khong hop le");

                            flag = true;
                            break;

                        default:
                            Console.WriteLine("\nBan chon \"Thoat\". Tam biet!");
                            flag = false;
                            break;
                    }
                } while (flag);

            }
            catch (Exception e)
            {
                Console.WriteLine("\nError: " + e.Message);
            }

           
            Console.ReadLine();

        }

        //Đổi số ở hệ 16 sang mảng số nguyên
        private static int[] convert16toArr(string n)
        {
            int[] arr = new int[n.Length];
            string[] temp = new string[n.Length];
            char[] tmp = new char[n.Length];

            tmp = n.ToCharArray();

            for (int i = 0; i < n.Length; i++)
                temp[i] = Convert.ToString(tmp[i]);

            for(int i = 0; i < n.Length; i++)
            {
                if (temp[i] == "A")
                    temp[i] = "10";

                if (temp[i] == "B")
                    temp[i] = "11";

                if (temp[i] == "C")
                    temp[i] = "12";

                if (temp[i] == "D")
                    temp[i] = "13";

                if (temp[i] == "E")
                    temp[i] = "14";

                if (temp[i] == "F")
                    temp[i] = "15";
            }

            for(int i = 0; i < n.Length; i++)
            {
                arr[i] = Convert.ToInt32(temp[i]);
            }

            return arr;
        }

        //đổi số ở hệ 2 sang mảng số nguyên
        private static int[] convert2toArr(string n)
        {
            int[] arr = new int[n.Length];
            string[] temp = new string[n.Length];
            char[] tmp = new char[n.Length];

            tmp = n.ToCharArray();

            for (int i = 0; i < n.Length; i++)
                temp[i] = Convert.ToString(tmp[i]);

            for (int i = 0; i < n.Length; i++)
            {
                    arr[i] = Convert.ToInt32(temp[i]);
            }    

            return arr;
        }

        //Đổi sang hệ cơ số 2
        private static void He2(int n)
        {
            if(n != 0)
            {
                He2(n/2);
                Console.Write(n % 2);
            }
        }

        //Đổi sang hệ cơ số 16
        private static void He16(int n)
        {
            if(n != 0)
            {
                He16(n / 16);
                int t = n % 16;
                if (t < 10)
                    Console.Write(t);
                else
                {
                    string str = Convert.ToString(t);
                    if (str == "10")
                        str = "A";
                    if (str == "11")
                        str = "B";
                    if (str == "12")
                        str = "C";
                    if (str == "13")
                        str = "D";
                    if (str == "14")
                        str = "E";
                    if (str == "15")
                        str = "F";

                    Console.Write(str);
                }
            }
        }

        //Đổi sang hệ cơ số 10
        private static double He10(int[] a, int coso)
        {
            double sum = 0;
            int t = a.Length;
            
            for (int i = 0; i < t; i++)
                sum += a[i] * Math.Pow(coso, (t - i - 1));

            return sum;
        }
            
    }
}
