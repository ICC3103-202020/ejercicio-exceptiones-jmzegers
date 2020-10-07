using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_excepciones
{
    [Serializable]
    class InvalidRadException : Exception
    {
        public InvalidRadException()
        : base()
        {
            Console.WriteLine("Invalid radius value");
        }
    }
}
