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
    public partial class formSalarioFuncionario : Form
    {
        public formSalarioFuncionario()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            decimal salario = Convert.ToDecimal(txtSalario.Text);
            decimal percentual = Convert.ToDecimal(txtPercentual.Text);
            decimal resultado;



            resultado = salario + (salario * (percentual/100));

            MessageBox.Show($"O novo salário do(a) {nome} é {resultado:C}");
        }
    }
}
