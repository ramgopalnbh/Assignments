using Assignment2.Entities;
using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tWelcome to Product-Catalog, Please Select Option\n");
            Console.WriteLine("\t\ta. Category");
            Console.WriteLine("\t\tb. Product");
            Console.WriteLine("\t\tc. Exit App!");

            char ch = Convert.ToChar(Console.ReadLine());

            switch(ch)
            {
                case 'a':
                    CategoryOperation.CategoryOperationMenu();
                    break;
                case 'b':
                    ProductOperation.ProductOperationMenu();
                    break;
                case 'c':
                    break;
                default:
                    Console.WriteLine("Sorry!!, Invalid Selection");
                    break;
            }
        }
    }
}
