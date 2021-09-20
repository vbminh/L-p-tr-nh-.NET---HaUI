using System;
using System.IO;

namespace File
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileInfo filename;

            //try
            //{
            //    filename = new FileInfo("D:/Practice/Source/File.txt");

            //    string target = "D:/Practice/HelloWorld/File.txt";

            //    if (!filename.Exists)
            //        Console.WriteLine("File khong ton tai");
            //    else
            //    {
            //        filename.CopyTo(target);
            //        Console.WriteLine("Copy file thanh cong");
            //    }

            //} catch(Exception e)
            //{
            //    Console.WriteLine("\nError");
            //    Console.WriteLine(e.Message);
            //}

            String line = "";

            try
            {
                using (StreamReader str = new StreamReader("D:/Practice/HelloWorld/File.txt"))
                {
                    while ((line = str.ReadLine()) != null)
                    {
                        using (StreamWriter stw = new StreamWriter("D:/Practice/Source/FileMatch.txt"))
                        {
                            stw.WriteLine(line);
                            stw.Close();
                        }

                    }
                    Console.WriteLine("Copy file thanh cong.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nError");
                Console.WriteLine(e.Message);
            }


            }
        }
}
