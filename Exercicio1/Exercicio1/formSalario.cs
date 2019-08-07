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
    public partial class formSalario : Form
    {
        public formSalario()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            decimal salario = Convert.ToDecimal(txtSalario.Text);
            decimal vendas = Convert.ToDecimal(txtVendas.Text);
            decimal resultado;

            resultado = salario + (vendas * 0.10m);
            MessageBox.Show($"O salário do(a) {nome} este mês é de {resultado:C}");
        }
    }
}
