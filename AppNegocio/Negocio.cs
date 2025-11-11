using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNegocio
{
    public class Negocio
    {

        public double CalcularY(double x) {
            double a = 2;
            double b = 2;
            double c = 2;
            double y = 0;

            try
            {
                y = ((a) * Math.Pow(x, 2)) + b * (x) + c;
                return y;
            }
            catch (Exception)
            {
                Console.WriteLine("Error obteniendo x");
                return 0;
            }

        }
    }
}
