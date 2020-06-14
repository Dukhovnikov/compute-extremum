using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using myVector;
using MathParser;
using Core;
using static Core.Function;
using Laboratory;
namespace FinalDraft
{
    public partial class Form1 : Form
    {
        private bool temp = true;
        string[] Top = new string[] { "Исходная функция", "Метод одномерной оптимизации", "Тема многомерной оптимизации","Метод многомерной оптимизации", "Начальная точка", "Точность поиска", "Количество итераций", "Найденный минимум" };
        /// <summary>
        /// Вектор хранящий значение стартовых точек
        /// </summary>
        Vector startpoint;
        /// <summary>
        /// Вектор хранящий значение минимума
        /// </summary>
        Vector minimum; 
        public Form1()
        {
            InitializeComponent();
            InitialEquation.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) button1_Click(new object(), new EventArgs()); };
            StartingPoint.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) Сalculate_Click(new object(), new EventArgs()); };
            button1.Visible = false;
        }

        /// <summary>
        /// Выход из приложения
        /// </summary>
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ThemeName.DataSource = Methods.GetMethods().Select(methods => methods.ThemeName).Distinct().ToList();
            DimensionalMethods.DataSource = SimpleMethods.GetSimpleMethods().Select(simlpemethods => simlpemethods.MethodName).ToList();
        }

        private void ThemeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            MethodName.DataSource = Methods.GetMethods().Where(methods => (ThemeName.SelectedItem.ToString() == methods.ThemeName)).Select(methods => methods.MethodName).ToList();
        }

        private void InitialEquation_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (InitialEquation.Text == "") { MessageBox.Show("Функция не задана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; } // Проверка введена ли функция
            int i = 0; // Количество переменных в уравнении
            while (InitialEquation.Text.Contains("x" + (i + 1))) i++; // Подсчет количества переменных
            x = new Vector(i); // Инициализация переменных уравнения в виде вектора
            if (temp && function == null)
            {
                Parser parser = new Parser(); // Инициализация парсера
                parser.createDelegat(InitialEquation.Text); // Передача парсеру текста целевой функции
                function = Parser.variable; // Создание делегата исходной функции на С#
            }
            if (Fault.Text == "") Fault.Text = eps.ToString(); // Текущая точность локализации
            if (Limitation.Text == "") Limitation.Text = m.ToString(); // Текущее количество максимальных итераций

        }

        private void ChekFunction_Click(object sender, EventArgs e)
        {
            if (InitialEquation.Text == "") { MessageBox.Show("Функция не задана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; } // Проверка введена ли функция
            MessageBox.Show(Parser.initialFunction(InitialEquation.Text), "Пеобразованная функция", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void Сalculate_Click(object sender, EventArgs e)
        {
            button1_Click(new object(), new EventArgs());

            eps = Convert.ToDouble(Fault.Text);
            m = Convert.ToInt16(Limitation.Text);
            string[] NewPoint; // Значение вектора
            if (StartingPoint.Text != "") // Если введено значение для вектора то задать
            {
                NewPoint = StartingPoint.Text.Split(' ');
                for (int i = 0; i < NewPoint.Length; i++) x[i] = Convert.ToDouble(NewPoint[i]);
            }
            LaboratoryWork lab3 = new LaboratoryWork(function, x.Size, maxK , mineps); // Создание класса для поиска альфа
            Alpha getAlpha; // Метод одномерного поиска
            #region Выбор метода одномерного поиска
            switch (DimensionalMethods.SelectedIndex)
            {
                case 0: getAlpha = lab3.getAlphaBolzanoDavidon; break;
                case 1: getAlpha = lab3.getAlphaDihotomy; break;
                case 2: getAlpha = lab3.getAlphaZS1; break;
                case 3: getAlpha = lab3.getAlphaZS2; break;
                case 4: getAlpha = lab3.getAlphaCubic; break;
                case 5: getAlpha = lab3.getAlphaPauell; break;
                case 6: getAlpha = lab3.getAlphaBolzano; break;
                default: getAlpha = null; break;
            }
            #endregion
            startpoint = x; // Вектор хранящий значение стартовых точек
            minimum = x; // Вектор хранящий значение минимума
            #region Выбор метода многомерного поиска
            if (ThemeName.SelectedIndex == 0)
                switch (MethodName.SelectedIndex)
                {
                    case 0: minimum = NewtonOptimizationMethods.NewtonRaphson(getAlpha); break;
                    case 1: minimum = NewtonOptimizationMethods.NewtonControlStep(getAlpha); break;
                    case 2: minimum = NewtonOptimizationMethods.NewtonConstHessian(getAlpha); break;
                }

            if (ThemeName.SelectedIndex == 1)
            {
                VariableMetricMethods MetricMethod = new VariableMetricMethods();
                switch (MethodName.SelectedIndex)
                {
                    case 0: minimum = MetricMethod.QuasiNewton(getAlpha, MetricMethod.DFP); break;
                    case 1: minimum = MetricMethod.QuasiNewton(getAlpha, MetricMethod.BFSH); break;
                    case 2: minimum = MetricMethod.QuasiNewton(getAlpha, MetricMethod.BFGSH); break;
                    case 3: minimum = MetricMethod.QuasiNewton(getAlpha, MetricMethod.MK); break;
                    case 4: minimum = MetricMethod.QuasiNewton(getAlpha, MetricMethod.Broiden); break;
                    case 5: minimum = MetricMethod.QuasiNewton(getAlpha, MetricMethod.Pirson_2); break;
                    case 6: minimum = MetricMethod.QuasiNewton(getAlpha, MetricMethod.Pirson_3); break;
                    case 7: minimum = MetricMethod.QuasiNewton(getAlpha, MetricMethod.PZ); break;
                }
            }

            if (ThemeName.SelectedIndex == 2)
                switch (MethodName.SelectedIndex)
                {
                    case 0: minimum = new ConjugateGradientMethods().getOptimize(getAlpha, ConjugateGradientMethods.betaDaniel); break;
                    case 1: minimum = new ConjugateGradientMethods().getOptimize(getAlpha, ConjugateGradientMethods.betaPhitchersRivers); break;
                    case 2: minimum = new ConjugateGradientMethods().getOptimize(getAlpha, ConjugateGradientMethods.betaPolakRiber); break;
                    case 3: minimum = new ConjugateGradientMethods().getOptimize(getAlpha, ConjugateGradientMethods.betaDikson); break;
                }
            #endregion

            Result.Text = "Начальная точка: [ " + startpoint.ToString() + " ]" + Environment.NewLine;
            Result.Text += "Найденный минимум: [ " + minimum.ToString() + " ]" + Environment.NewLine;
            Result.Text += "Количество итераций: " + k;

            x = null;
            lab3 = null;

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #region Стандартные функции
        private void function33_Click(object sender, EventArgs e)
        {
            InitialEquation.Text = "(1,5 - x1*(1 - x2))^2 + (2,25 - x1*(1 - x2^2))^2 + (2,625 - x1*(1 - x2^3))^2";
            temp = false;
            function = f33;
        }

        private void function34_Click(object sender, EventArgs e)
        {
            InitialEquation.Text = "(x1 + 10*x2)^2 + 5*(x3 - x4)^2 + (x2 - 2*x3)^4 + 10*(x1 - x4)^4";
            temp = false;
            function = f34;
        }

        private void function35_Click(object sender, EventArgs e)
        {
            InitialEquation.Text = "100*(x2 - x1^2)^2 + (1 - x1)^2 + 90*(x4 - x3^2)^2 + (1 - x3)^3 + 10,1*((x2 - 1)^2 + (x4 - 1)^2) + 19,8*(x2 - 1)*(x4 - 1)";
            temp = false;
            function = f35;
        }

        private void function36_Click(object sender, EventArgs e)
        {
            InitialEquation.Text = "(2*x1^2 + 3*x2^2)*exp(x1^2 - x2^2)";
            temp = false;
            function = f36;
        }

        private void function37_Click(object sender, EventArgs e)
        {
            InitialEquation.Text = "0,1 * (12 + x1 ^ 2 + (1 + x2 ^ 2) / (x1 ^ 2) + (x1 ^ 2 * x2 ^ 2 + 100) / (x1 ^ 4 * x2 ^ 4))";
            temp = false;
            function = f37;
        }

        private void function38_Click(object sender, EventArgs e)
        {
            InitialEquation.Text = "100*(x3 - 0,25*(x1 + x2)^2)^2 + (1 - x1)^2 + (1 - x2)^2";
            temp = false;
            function = f38;
        }
        #endregion

        private void дополнительныеНастройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 formsetting = new Form2();
            formsetting.ShowDialog();
        }

        private void dataGridViewResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string logFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FinaDraft.csv");

            if (!File.Exists(logFilePath))
            {
                FileStream file = new FileStream(logFilePath, FileMode.Append);
                StreamWriter writer = new StreamWriter(file, Encoding.Unicode);

                for (int i = 0; i < Top.Length - 1; i++)
                {
                    writer.Write(Top[i] + "\t");
                }
                writer.Write(Top[Top.Length - 1]);
                writer.WriteLine();
                writer.Close();
            }
            else
            {
                FileStream file = new FileStream(logFilePath, FileMode.Append);
                StreamWriter writer = new StreamWriter(file, Encoding.Unicode);
                writer.Write(InitialEquation.Text + "\t");
                writer.Write(DimensionalMethods.Text + "\t");
                writer.Write(ThemeName.Text + "\t");
                writer.Write(MethodName.Text + "\t");
                writer.Write("[" + startpoint.ToString() + "]"  + "\t");
                writer.Write(eps.ToString() + "\t");
                writer.Write(k.ToString() + "\t");
                writer.Write(minimum.ToString() + "\t");
                writer.WriteLine();
                writer.Close();
            }
            
        }
    }
}
