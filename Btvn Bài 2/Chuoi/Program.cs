using System;

namespace Chuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            string str, str1, str2;

            Console.WriteLine("\tChuoi");

            Console.Write("\nNhap chuoi thu nhat: ");
            str = Console.ReadLine();

            char[] arr = str.ToCharArray();
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }


            Console.Write("\nNhap chuoi thu 2: ");
            str1 = Console.ReadLine();
            str1 = str1.Replace(" ","");

            char[] arr1 = str1.ToCharArray();
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            Console.Write("\nNhap chuoi thu 3: ");
            str2 = Console.ReadLine();
            
            char[] arr2 = str2.ToCharArray();
            int[] arr3 = new int[arr2.Length];
            for (int i = 0; i < arr2.Length; i++)
                arr3[i] = -1;

            for (int i = 0; i < arr2.Length; i++)
            {
                int count = 1;
                for(int j = i + 1; j < arr2.Length; j++)
                {
                    if(arr2[i] == arr2[j])
                    {
                        count++;
                        arr3[j] = 0;
                    }
                }

                if(arr3[i] != 0)
                    arr3[i] = count;

            }

            Console.WriteLine("\nSo lan xuat hien cua tung ki tu trong chuoi {0} là :", str2);
            for(int i = 0; i < arr2.Length; i++)
            {
                if(arr3[i] != 0)
                {
                    Console.WriteLine("So lan xuat hien cua ki tu {0} la: {1}", arr2[i], arr3[i]);
                }
            }
            
        }

    }
}
