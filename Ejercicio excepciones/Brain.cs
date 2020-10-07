using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_excepciones
{
    class Brain
    {
        readonly double pi = Math.PI;

        public double SphereVol(double ratio)
        {
            double volume = (4 * pi * ratio * ratio * ratio) / 3;

            return volume;
        }

        public double WrongInput()
        {
            double radius = -1;
            string a = Console.ReadLine();

            try
            {
                radius = Convert.ToDouble(a);
            }
            catch (FormatException e)
            {
                radius = -1;
                Console.WriteLine("Why would you write something other than a number?");
                Console.WriteLine(e.Message);
            }

            return radius;
        }


    }
}
