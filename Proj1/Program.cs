using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Proj1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Table t1 = new Table();
            Table t2 = new Table();

            t1.material = "Wood";
            t1.price = 12f;

            t2.material = "Plastic";
            t2.model = "158BERsd13";

            //--------------------
            Bed b1 = new Bed();
            Bed b2 = new Bed();
            Bed b3 = new Bed();

            b1.model = "Sapapa";
            b1.price = 12f;
           

            b2.model = "Aminah";
            b2.price = 40f;
             
            b3.model = "Shuki";
            b3.price = 18f;




            Console.ReadLine();
        }
    }
}
