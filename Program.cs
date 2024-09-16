using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Threading;
using System.IO;
using System.Net;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool p = true;
            Console.Title="Custom Spliter Text";
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            while (2!=0)
            {
                
                try
                {
                    if (p)
                    {
                    Console.WriteLine("YOUR TEXT : ");
                        p = false;
                    }
                    else
                    {
                        Console.WriteLine("-----------------");
                        Console.WriteLine("YOUR TEXT : ");
                    }
                    string a = Console.ReadLine();
                    Console.WriteLine("YOUR SPLIT CHAR : ");
                    char n = Convert.ToChar(Console.ReadLine());
                    string[] b = new string[a.Length];
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (a[i] == n)
                        {
                            b[i] = '\n'.ToString();

                        }
                        else if (a[i] != n)
                        {

                            b[i] = a[i].ToString();
                        }
                    }
                    Console.WriteLine("Result :");
                    foreach (var item in b)
                    {
                        Console.Write(item);

                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
                catch (Exception rrr)
                {

                    Console.WriteLine(rrr.Message);
                }
                 
           
            }
            

            




        }
    }

}
