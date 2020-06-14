using System;
using Core;
using static Core.Function;
using myVector;
using myMatrix;
using LogFile;
namespace FinalDraft
{
    /// <summary>
    /// Класс реализации ньютоновских методов
    /// </summary>
    static class NewtonOptimizationMethods
    {
        /// <summary>
        /// Метод Ньютон-Рафсон
        /// </summary>
        public static Vector NewtonRaphson(Alpha getAlpha)
        {
            int k = 1;
            Vector p = new Vector(x.Size);
            double alpha = 0;
            while (true)
            {
                // Шаг 1
                p = -(Hessian.Inverse * grad(x)); // Находим Ньютоновское направление
                // Наг 2
                alpha = getAlpha(x, p); // Находим альфа
                x = x + alpha * p; // Переходим в новую точку
                // КОП
                if (grad(x).Norma <= eps || k > m)
                {
                    Function.k = k;
                    return x;
                }
                k++;
            }
        }

        /// <summary>
        /// Метод Ньютона с регулировкой шага
        /// </summary>
        public static Vector NewtonControlStep(Alpha getAlpha)
        {
            int k = 1;
            Vector p = new Vector(x.Size);
            double alpha = 0;
            while (true)
            {
                // Шаг 1
                alpha = 1;
                // Шаг 2
                p = -(Hessian.Inverse * grad(x)); // Находим Ньютоновское направление
                // Шаг 3
                while (y(x + alpha * p) > y(x) + eps + alpha * Math.Pow(grad(x).Norma, 2)) alpha /= 2;
                // Шаг 4
                x = x + alpha * p;
                // КОП
                if (grad(x).Norma <= eps || k > m)
                {
                    Function.k = k;
                    return x;
                }
                k++;
            }
        }

        /// <summary>
        /// Метод Ньютона с постоянным Гессианом
        /// </summary>
        public static Vector NewtonConstHessian(Alpha getAlpha)
        {
            int k = 1;
            // Шаг1
            Matrix Hessian = Function.Hessian.Inverse;
            while (true)
            {
                // Шаг 2
                x = x - Hessian * grad(x);
                // КОП
                if (grad(x).Norma <= eps || k > m)
                {
                    Function.k = k;
                    return x;
                }
                k++;
            }
        }
    }
}
