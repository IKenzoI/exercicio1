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
    public partial class formCombustivel : Form
    {
        public formCombustivel()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int tempo = Convert.ToInt32(txtTempo.Text);
            int velocidade = Convert.ToInt32(txtVelocidade.Text);
            int distanciapercorrida;
            decimal litros;
            int tempo2 = tempo * 60;

            distanciapercorrida = velocidade * tempo2;

            litros = distanciapercorrida / 12;

            MessageBox.Show($"A velocidade média foi de {velocidade} Km/h");
            MessageBox.Show($"O tempo gasto na viagem foi de {tempo} horas");
            MessageBox.Show($"A distância percorrida foi de {distanciapercorrida} Km");
            MessageBox.Show($"A quantidade de litros usada na viagem foi de {litros} litros");

        }
    }
}
