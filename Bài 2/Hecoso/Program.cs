using System;

namespace Hecoso
{
    class Program
    {

        static void Main(string[] args)
        {
            int a, m;
            string n;

            Console.WriteLine("\tHe co so");
            
            Console.Write("Ban muon doi tu he co so nao: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nNhap so: ");
            n = Console.ReadLine();

            Console.Write("\nBan muon doi sang he co so nao: ");
            m = Convert.ToInt32(Console.ReadLine());

            if(a == 16)
            {
                int[] arr = new int[n.Length];
                string[] tmp = new string[n.Length];
                char[] temp = new char[n.Length];

                temp = n.ToCharArray();

                for (int i = 0; i < n.Length; i++)
                    tmp[i] = Convert.ToString(temp[i]);

                for (int i = 0; i < n.Length; i++)
                {
                    if (tmp[i] == "A") tmp[i] = "10";
                    if (tmp[i] == "B") tmp[i] = "11";
                    if (tmp[i] == "C") tmp[i] = "12";
                    if (tmp[i] == "D") tmp[i] = "13";
                    if (tmp[i] == "E") tmp[i] = "14";
                    if (tmp[i] == "F") tmp[i] = "15";
                }

                for (int i = 0; i < n.Length; i++)
                    arr[i] = Convert.ToInt32(tmp[i]);

                if (m == 10)
                {
                    double sum = He10(arr, 16);
                    Console.Write("\nKet qua la: " + sum);
                }

                if(m == 2)
                {
                    int sum = (int) He10(arr, 16);
                    Console.Write("\nKet qua la: ");
                    He2(sum);
                }
            }

            if(a == 10)
            {
                int temp = int.Parse(n);
                if (m == 2)
                {
                    Console.Write("\nKet qua la: ");
                    He2(temp);
                }
                    
                if(m == 16)
                {
                    Console.Write("\nKet qua la: ");
                    He16(temp);
                }    
            }    
            
            if(a == 2)
            {
                int[] arr = new int[n.Length];
                string[] tmp = new string[n.Length];
                char[] temp = new char[n.Length];

                temp = n.ToCharArray();

                for (int i = 0; i < n.Length; i++)
                    tmp[i] = Convert.ToString(temp[i]);

                for (int i = 0; i < n.Length; i++)
                    arr[i] = Convert.ToInt32(tmp[i]);

                if (m == 10)
                {
                    double sum = He10(arr,10);
                    Console.Write("\nKet qua la: " + sum);
                }

                if (m == 16)
                {
                    int sum = (int) He10(arr,10);
                    Console.Write("\nKet qua la: ");
                    He16(sum);
                } 
                    
            }

            Console.ReadLine();

        }

        private static void He2(int n)
        {
            if(n != 0)
            {
                He2(n/2);
                Console.Write(n % 2);
            }
        }


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
