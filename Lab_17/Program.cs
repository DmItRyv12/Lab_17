using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            print<int>(12);
            print<string>("Hello!");
            Console.ReadKey();

            //Apartament apartament1 = new Apartament();
            //Apartament<int,int> apartament1 = new Apartament<int,int>();
            //apartament1.Num = 1;
            //int next = apartament1.Num;
            //int next = (int)apartament1.Num;

            //Apartament apartament2 = new Apartament();
            //Apartament<string,int> apartament2 = new Apartament<string,int>();
            //apartament2.Num = "01";

        }
        static void print<T>(T value)
        {

        Console.WriteLine(value);
        
        }
    }
    //class Apartament<T,U>
    //{
    //    public U Level { get; set; }
    //    //int Level { get; set; }
    //    // public Object Num { get; set; }
    // public T Num { get; set; }
    //}
}
