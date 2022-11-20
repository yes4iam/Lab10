using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle angle;
            do
            {
                Console.WriteLine("Введите градусы угла");
                int deg = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите минуты угла");
                int min = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите cекунды угла");
                int sec = Convert.ToInt32(Console.ReadLine());

                angle = new Angle(deg, min, sec);
            }
            while (angle.isCorrect == false);
            int radians = Convert.ToInt32(Math.PI)*angle.toRadians();
            Console.WriteLine("Угол в радианах равен:");
            Console.WriteLine(radians);
            Console.ReadKey();
                

            

            

        }
    }
}
