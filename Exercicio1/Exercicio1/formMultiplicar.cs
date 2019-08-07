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
    public partial class formMultiplicar : Form
    {
        public formMultiplicar()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumero.Text);
            int resultado;

            resultado = numero * numero;

            MessageBox.Show($"O numero vezes ele mesmo é {resultado}");
        }
    }
}
