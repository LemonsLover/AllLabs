using System;

namespace Learn_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var rand = new Random();

            if(rand.Next(0, 2) == 0)
                Console.WriteLine("Макс крутая собака !");
            else
                Console.WriteLine("Арчи крутая собака !");
            

        }
    }
}
