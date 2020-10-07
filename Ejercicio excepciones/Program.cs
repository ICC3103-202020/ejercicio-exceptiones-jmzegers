using System;

namespace Ejercicio_excepciones
{
    class Program
    {
        private static void ValidateRad()
        {
            Brain b = new Brain();

            double r = b.WrongInput();

            Console.WriteLine(r);

            if (r < 0)
            {
                throw new InvalidRadException();
            }
            else
            {
                double vol = b.SphereVol(r);
                Console.WriteLine(" ");
                Console.WriteLine("The volume is:", vol);
            }
        }

        static void Main(string[] args)
        {
            Brain b = new Brain();

            Console.WriteLine("Welcome to the best sphere volume calculator!");

            Console.WriteLine("Please write the radius of the sphere");

            ValidateRad();
        }
    }
}
