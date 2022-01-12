using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Lab_8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "Lab_8.2/Lab_VIII.txt";

            StreamWriter sw = new StreamWriter(path);
            double[] array = new double[10];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                sw.Write(random.Next(0, 10));

            }
            sw.Close();
            int s = 0;
            using (StreamReader sr = new StreamReader(path))
                for (int i = 0; i < 10; i++)
                {

                    s += Convert.ToInt32(sr.ReadLine());
                }
            


        }













    }
}
