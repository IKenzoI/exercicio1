using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            new formMultiplicar().Show();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new formFormula().Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new formSalarioFuncionario().Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            new formCombustivel().Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            new formSalario().Show();
        }
    }
}
