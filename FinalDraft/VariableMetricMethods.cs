using System;
using myMatrix;
using myVector;
using Core;
using static Core.Function;


namespace FinalDraft
{
    /// <summary>
    /// Класс реализации методов переменной метрики
    /// </summary>
    class VariableMetricMethods
    {
        /// <summary>
        /// Матрица переменной метрики
        /// </summary>
        private Matrix A = new Matrix(x.Size);

        /// <summary>
        /// Квазиньютоновский алгоритм.
        /// </summary>
        public Vector QuasiNewton(Alpha getAlpha, MetricMethod getA)
        {
            int k = 1;
            int j = 0;
            Vector x = Function.x;
            int N = x.Size;
            Vector x1 = x; // Предыдущая точка
            Vector p = new Vector(x.Size);
            while (grad(x).Norma > eps && k < m)
            {
                if (k == j * N + 1) { j++; A = Matrix.E(x.Size); } // Шаг 1 Построим корректирующую матрицу
                else { A = getA(x, x1); }
                p = -1*(A * grad(x)); // Шаг 2 Построим квазиньютоновское направление
                x1 = x;
                x = x + getAlpha(x, p) * p; // Шаг 3 Переход в новую точку
                k++;
            }
            Function.k = k;
            return x;
        }

        /// <summary>
        /// Формула переменной метрики Дэвидона–Флетчера–Пауэлла.
        /// </summary>
        public Matrix DFP(Vector x2, Vector x1)
        {
            Vector gamma = grad(x2) - grad(x1);
            Vector S = A * gamma;
            Vector deltaX = x2 - x1;
            return A + ((Vector.Multiplication(deltaX, deltaX)) / (deltaX * gamma)) - ((Vector.Multiplication(S, S)) / (S * gamma));
        }

        /// <summary>
        /// Формула переменной метрики Бройдена–Флетчера–Шенно.
        /// </summary>
        public Matrix BFSH(Vector x2, Vector x1)
        {
            Vector gamma = grad(x2) - grad(x1);
            Vector S = A * gamma;
            Vector deltaX = x2 - x1;
            Matrix B = Matrix.E(x2.Size) - ((Vector.Multiplication(deltaX, gamma)) / (gamma * deltaX));
            return B * A * B + ((Vector.Multiplication(deltaX, deltaX)) / (deltaX * gamma));
        }

        /// <summary>
        /// Формула переменной метрики Бройдена–Флетчера–Гольдфарба–Шенно.
        /// </summary>
        public Matrix BFGSH(Vector x2, Vector x1)
        {
            Vector gamma = grad(x2) - grad(x1);
            Vector S = A * gamma;
            Vector deltaX = x2 - x1;
            return A + (1 + (S * gamma) / (gamma * deltaX)) * ((Vector.Multiplication(deltaX, deltaX)) / (deltaX * gamma)) - ((Vector.Multiplication(deltaX, gamma) + Vector.Multiplication(gamma, deltaX)) / (deltaX * gamma));
        }

        /// <summary>
        /// Формула переменной метрики Мак-Кормика.
        /// </summary>
        public Matrix MK(Vector x2, Vector x1)
        {
            Vector gamma = grad(x2) - grad(x1);
            Vector S = A * gamma;
            Vector deltaX = x2 - x1;
            return A + ((Vector.Multiplication(deltaX, deltaX)) / (deltaX * gamma)) - ((Vector.Multiplication(gamma, deltaX)) / (deltaX * gamma));
        }

        /// <summary>
        /// Формула переменной метрики Бройдена.
        /// </summary>
        public Matrix Broiden(Vector x2, Vector x1)
        {
            Vector gamma = grad(x2) - grad(x1);
            Vector S = A * gamma;
            Vector deltaX = x2 - x1;
            return A + ((Vector.Multiplication(deltaX - S, deltaX - S)) / ((deltaX - S) * gamma));
        }

        /// <summary>
        /// Формула переменной метрики Пирсона-2.
        /// </summary>
        public Matrix Pirson_2(Vector x2, Vector x1)
        {
            Vector gamma = grad(x2) - grad(x1);
            Vector S = A * gamma;
            Vector deltaX = x2 - x1;
            return A + ((Vector.Multiplication(deltaX - S, deltaX)) / (deltaX * gamma));
        }

        /// <summary>
        /// Формула переменной метрики Пирсона-3.
        /// </summary>
        public Matrix Pirson_3(Vector x2, Vector x1)
        {
            Vector gamma = grad(x2) - grad(x1);
            Vector S = A * gamma;
            Vector deltaX = x2 - x1;
            return A + ((Vector.Multiplication(deltaX - S, S)) / (gamma * S));
        }

        /// <summary>
        /// Формула переменной метрики Проекции Заутендийка.
        /// </summary>
        public Matrix PZ(Vector x2, Vector x1)
        {
            Vector gamma = grad(x2) - grad(x1);
            Vector S = A * gamma;
            Vector deltaX = x2 - x1;
            return A - ((Vector.Multiplication(S, S)) / (gamma * S));
        }
    }
}
