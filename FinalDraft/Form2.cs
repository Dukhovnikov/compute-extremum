using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Core.Function;

namespace FinalDraft
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            if (grad == grad_1)
                Derivative.SelectedIndex = 0;
            if (grad == grad_2)
                Derivative.SelectedIndex = 1;
            if (grad == grad_4)
                Derivative.SelectedIndex = 2;
            ТочностьЛокализации.Text = mineps.ToString();
            ОграничениеИтераций.Text = maxK.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (Derivative.SelectedIndex)
            {
                case 0: grad = grad_1; break;
                case 1: grad = grad_2; break;
                case 2: grad = grad_4; break;
            }

            mineps = Convert.ToDouble(ТочностьЛокализации.Text);
            maxK = Convert.ToInt32(ОграничениеИтераций.Text);
            Close();
        }
    }
}
