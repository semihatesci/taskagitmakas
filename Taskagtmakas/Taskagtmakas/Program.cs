using System;

namespace Taskagtmakas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç kişi oynanacağını giriniz");
            int g1 = Convert.ToInt32(Console.ReadLine());
            Game g = new Game(g1);
            g.oyna();

         
        }
    }
}
