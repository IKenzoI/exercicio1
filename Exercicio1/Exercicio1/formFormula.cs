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
    public partial class formFormula : Form
    {
        public formFormula()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txtNum1.Text);
            int numero2 = Convert.ToInt32(txtNum2.Text);
            int resultado;

            resultado = ((numero1 * 9) / (87 - numero2)) * ((numero1 * 9) / (87 - numero2));
        }
    }
}
