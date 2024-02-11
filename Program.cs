using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=6;
            int j = 1000;
            Console.WriteLine("Вы гуль?");
            string n = Convert.ToString(Console.ReadLine()) ;
            if (n == "yes" || n== "YES" || n == "Yes")
            {
              

                while (true)
                {
                    System.Threading.Thread.Sleep(50);
                    Console.WriteLine(j+ "-" +7);
                    j = j - 7;
                    if (i>j)
                    {
                        break;
                    }
                }
                Console.WriteLine("أنت الغول");
            }
            else
            {
                Console.WriteLine("ПОШЕЛ НАХУЙ ПОЗЕР");
            }


        }
    }
    
}
