using System;
using myVector;
using Core;
using static Core.Function;


namespace FinalDraft
{
    /// <summary>
    /// Класс реализации методов сопряженных градиентов 
    /// </summary>
    class ConjugateGradientMethods
    {
        /// <summary>
        /// Нахождение минимума с помощью одного из четырех методов сопряженных градиентов 
        /// </summary>
        public Vector getOptimize(Alpha getAlpha, Alpha beta)
        {
            int k = 1;
            int j = 0;
            //Vector X = x;
            Vector p = new Vector(x.Size);
            int N = x.Size;
            double alpha;
            do
            {
                if (k == j * N + 1)
                {
                    j++;
                    p = -grad(x);
                }
                else
                {
                    p = -grad(x) + beta(grad(x), (-p)) * p;
                }
                alpha = getAlpha(x, p);
                x = x + alpha * p;
                k++;
            }
            while (grad(x).Norma > eps && k < m);
            Function.k = k;
            return x;
        }

        /// <summary>
        ///значение бета по формуле Даниела  
        /// </summary>
        public static double betaDaniel(Vector g2, Vector g1)
        {
            Vector gamma = g2 - g1;
            return (g2 * gamma) / ((-g1) * gamma);
        }

        /// <summary>
        ///значение бета по формуле Флетчера-Ривса
        /// </summary>
        public static double betaPhitchersRivers(Vector g2, Vector g1)
        {
            return (Math.Pow(g2.Norma, 2)) / (Math.Pow(g1.Norma, 2));
        }

        /// <summary>
        ///значение бета по формуле Диксона 
        /// </summary>
        public static double betaDikson(Vector g2, Vector g1)
        {
            return -(Math.Pow(g2.Norma, 2) / ((-g1) * g1));
        }

        /// <summary>
        ///значение бета по формуле Полака-Рибьера 
        /// </summary>
        public static double betaPolakRiber(Vector g2, Vector g1)
        {
            return (g2 * (g2 - g1) / (Math.Pow(g1.Norma, 2)));
        }
    }
}
