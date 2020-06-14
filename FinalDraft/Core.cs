using myVector;
using myMatrix;
using System;

namespace Core
{
    /// <summary>
    /// Шаблон для метода поиска альфа  
    /// </summary>
    public delegate double Alpha(Vector x, Vector p);

    /// <summary>
    /// Делегат для методов многомерного поиска
    /// </summary>
    public delegate Vector Method(Alpha getAlpha);

    /// <summary>
    /// Делегат для метода значения функции в точке
    /// </summary>
    public delegate double Value(double[] x);

    /// <summary>
    /// Шаблон для метода переменной метрики  
    /// </summary>
    public delegate Matrix MetricMethod(Vector x2, Vector x1);

    /// <summary>
    /// Функция нахождения  якобиана
    /// </summary>
    public delegate Vector Gradient(Vector x);

    static class Function
    {

        /// <summary>
        /// Исходная функция  
        /// </summary>
        public static Delegate function { get; set; }

        /// <summary>
        /// Количство итераций
        /// </summary>
        public static int k = 0;

        /// <summary>
        /// Ограничение количества итераций в одномерном поиске
        /// </summary>
        public static int maxK = 150;

        /// <summary>
        /// Ограничение количества итераций
        /// </summary>
        public static int m = 20;

        /// <summary>
        /// Точность локализации минимума для многомерного поиска
        /// </summary>
        public static double eps = 1e-4;

        /// <summary>
        /// Точность локализации минимума для одномерного поиска
        /// </summary>
        public static double mineps = 1e-15;

        /// <summary>
        /// Текущая точка 
        /// </summary>
        public static Vector x { get; set; }

        /// <summary>
        /// Значение производной в текущей точке
        /// </summary>
        public static Gradient grad = grad_2;

        /// <summary>
        /// Функция 33 из методических указаний
        /// </summary>
        public static Value f33 = x => Math.Pow((1.5 - 1 * x[0] + x[0] * x[1]), 2) + Math.Pow((2.25 - 1 * x[0] + x[0] * Math.Pow(x[1], 2)), 2) + Math.Pow((2.625 - 1 * x[0] + x[0] * Math.Pow(x[1], 3)), 2);
        /// <summary>
        /// Функция 34 из методических указаний
        /// </summary>
        public static Value f34 = x => Math.Pow((x[0] + 10 * x[1]), 2) + 5 * Math.Pow((x[2] - x[3]), 2) + Math.Pow((x[1] - 2 * x[2]), 4) + 10 * Math.Pow((x[0] - x[3]), 4);
        /// <summary>
        /// Функция 35 из методических указаний
        /// </summary>
        public static Value f35 = x => 100 * Math.Pow((x[1] - Math.Pow(x[0], 2)), 2) + Math.Pow((1 - x[0]), 2) + 90 * Math.Pow((x[3] - Math.Pow(x[2], 2)), 2) + Math.Pow((1 - x[2]), 3) + 10.1 * (Math.Pow((x[1] - 1), 2) + Math.Pow((x[3] - 1), 2)) + 19.8 * (x[1] - 1) * (x[3] - 1);
        /// <summary>
        /// Функция 36 из методических указаний
        /// </summary>
        public static Value f36 = x => (2 * Math.Pow(x[0], 2) + 3 * Math.Pow(x[1], 2)) * Math.Exp(Math.Pow(x[0], 2) - Math.Pow(x[1], 2));
        /// <summary>
        /// Функция 37 из методических указаний
        /// </summary>
        public static Value f37 = x => 0.1 * (12 + Math.Pow(x[0], 2) + (1 + Math.Pow(x[1], 2)) / (Math.Pow(x[0], 2)) + (Math.Pow(x[0], 2) * Math.Pow(x[1], 2) + 100) / (Math.Pow(x[0], 4) * Math.Pow(x[1], 4)));
        /// <summary>
        /// Функция 38 из методических указаний
        /// </summary>
        public static Value f38 = x => 100 * Math.Pow((x[2] - 0.25 * (Math.Pow(x[0] + x[1],2))), 2) + Math.Pow((1 - x[0]), 2) + Math.Pow((1 - x[1]), 2);

        /// <summary>
        ///Текущее значение функции  
        /// </summary>
        public static double y(Vector x)
        {
            return (double)function.DynamicInvoke(x.vector); // Возвращает значение динамической функции уравнения
        }

        /// <summary>
        /// Значение производной в текущей точке
        /// </summary>
        public static Vector g { get { return FirstDerivativeSecond; } }
        /// <summary>
        /// Значение производной в текущей точке. Первая формула численного дифференцирования.
        /// </summary>
        public static Vector grad_1(Vector x)
        {
            Vector g = new Vector(x.Size);
            double h = 1e-5;
            for (int i = 0; i < x.Size; i++)
            {
                double[] hi = new double[x.Size];
                hi[i] = h;
                g[i] = (y(x + new Vector(hi)) - y(x)) / h;
            }
            return g;
        }
        /// <summary>
        /// Значение производной в текущей точке. Вторая формула численного дифференцирования.
        /// </summary>
        public static Vector grad_2(Vector x)
        {
            Vector g = new Vector(x.Size);
            double h = 1e-5;
            for (int i = 0; i < x.Size; i++)
            {
                double[] hi = new double[x.Size];
                hi[i] = h;
                g[i] = (y(x + new Vector(hi)) - y(x - new Vector(hi))) / (2 * h);
            }
            return g;
        }
        /// <summary>
        /// Значение производной в текущей точке. Четвертая формула численного дифференцирования.
        /// </summary>
        public static Vector grad_4(Vector x)
        {
            {
                Vector g = new Vector(x.Size);
                double h = 1e-5;
                for (int i = 0; i < x.Size; i++)
                {
                    double[] hi = new double[x.Size];
                    double[] hi2 = new double[x.Size];
                    hi[i] = h;
                    hi2[i] = 2 * h;
                    g[i] = (-y(x + new Vector(hi2)) + 8 * y(x + new Vector(hi)) - 8 * y(x - new Vector(hi)) + y(x - new Vector(hi2))) / (12 * h);
                }
                return g;
            }
        }

        /// <summary>
        /// Первая формула численного дифференцирования
        /// </summary>
        private static Vector firstderivativefirst()
        {
            Vector g = new Vector(x.Size);
            double h = 1e-5;
            for (int i = 0; i < x.Size; i++)
            {
                double[] hi = new double[x.Size];
                hi[i] = h;
                g[i] = (y(x + new Vector(hi)) - y(x)) / h;
            }
            return g;
        }

        /// <summary>
        /// Вторая формула численного дифференцирования
        /// </summary>
        private static Vector firstderivativesecond()
        {
            Vector g = new Vector(x.Size);
            double h = 1e-5;
            for (int i = 0; i < x.Size; i++)
            {
                double[] hi = new double[x.Size];
                hi[i] = h;
                g[i] = (y(x + new Vector(hi)) - y(x - new Vector(hi))) / (2 * h);
            }
            return g;
        }

        /// <summary>
        /// Четвертая формула численного дифференцирования
        /// </summary>
        private static Vector firstderivativefourth()
        {
            Vector g = new Vector(x.Size);
            double h = 1e-5;
            for (int i = 0; i < x.Size; i++)
            {
                double[] hi = new double[x.Size];
                double[] hi2 = new double[x.Size];
                hi[i] = h;
                hi2[i] = 2 * h;
                g[i] = (-y(x + new Vector(hi2)) + 8 * y(x + new Vector(hi)) - 8 * y(x - new Vector(hi)) + y(x - new Vector(hi2))) / (12 * h);
            }
            return g;
        }

        /// <summary>
        /// Получение гессиана первой формулой численного дифференцироания для второй производной
        /// </summary>
        public static Matrix Hessian
        {
            get
            {
                Matrix Gesse = new Matrix(x.Size);
                double h = 1e-5;
                for (int i = 0; i < x.Size; i++)
                {
                    Vector ei = new Vector(x.Size);
                    ei[i] = h;
                    for (int j = 0; j < x.Size; j++)
                    {
                        Vector ej = new Vector(x.Size);
                        ej[j] = h;
                        Gesse[i, j] = (y(x + ei + ej) - y(x + ei) - y(x + ej) + y(x)) / (h * h);
                    }
                }

                return Gesse;
            }
        }

        /// <summary>
        /// Первая формула численного дифференцирования
        /// </summary>
        public static Vector FirstDerivativeFirst { get { return firstderivativefirst(); } }
        /// <summary>
        /// Вторая формула численного дифференцирования
        /// </summary>
        public static Vector FirstDerivativeSecond { get { return firstderivativesecond(); } }
        /// <summary>
        /// Четвертая формула численного дифференцирования
        /// </summary>
        public static Vector FirstDerivativeFourth { get { return firstderivativefourth(); } }

    }
}