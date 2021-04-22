using MathNet.Numerics.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosBlazor.Client.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;

        private void IncrementCount()
        {
            var arreglo = new double[] { 1, 2 };
            var max = arreglo.Maximum();
            var min = arreglo.Minimum();

            Console.WriteLine($"El máximo es: {max} y el minimo es {min}");

            currentCount++;
        }
    }
}
