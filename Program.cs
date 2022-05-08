using System;
using System.IO;
using System.Text.RegularExpressions;


namespace SeperatorService
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex rgx3 = new Regex(@"y2mate.com - ");

            //string kelime = "y2mate.com - ";
            //int a = 0;
            string[] targetEntries = Directory.GetFileSystemEntries(@"C:\Users\Fuat\Desktop\deneme\");
            string destfolder = @"C:\Users\Fuat\Desktop\deneme2\", destfolder2 = @"C:\Users\Fuat\Desktop\deneme3\";
            // string[] destfolder = Directory.GetFiles(@"C:\Users\Fuat\Desktop\deneme2");
            //foreach (var files in asd)
            //{

            //    //Console.WriteLine(kelime == "y2mate.com - " ? "olmuş" : "olmamış");
            //   // Console.WriteLine(files);
            //    //Console.WriteLine($"{Path.GetFileName(files)}");
            //}
            //foreach (var files in asd)
            //{

            //    //Console.WriteLine(kelime == "y2mate.com - " ? "olmuş" : "olmamış");
            //    //Console.WriteLine(files);

            //    //if (!(Path.GetFileNameWithoutExtension(files) == "y2mate.com - "))
            //    //{
            //    //    Console.WriteLine($"{Path.GetFileName(files)}");
            //    //}
            //    if (Path.GetFileNameWithoutExtension(files) == kelime)
            //    {
            //        Console.WriteLine($"{Path.GetFileName(files)}");
            //    }
            //    Path.
            //} 
            //.Substring(5, entry.Length)

            foreach (string entry in targetEntries)
            {

                if (entry.Contains("y2mate"))
                {

                    File.Replace(entry, $"{destfolder}{Path.GetFileName(entry)}", $"{destfolder2}{Path.GetFileName(entry)}");
                    //File.Copy(entry, $"{destfolder}{Path.GetFileName(entry)}", true);
                }
                else
                {
                    Console.WriteLine("olmadı");
                }


            }


            Console.ReadLine();
            //public static string Z()
            //{
            //    return "\n";
            //}
        }
    }
}

