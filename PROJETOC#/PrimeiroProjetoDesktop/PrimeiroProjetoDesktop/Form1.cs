using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroProjetoDesktop
{
    public partial class Form1 : Form
    {

        public int segundos;
        public int minutos;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá C-Sharp Lindão!");
            MessageBox.Show($"Olá {txtNome.Text}! Seja Bem Vindo!", "Boas Vindas");
            MessageBox.Show($"Olá {txtNome.Text}! Seja Bem Vindo!", "Boas Vindas", MessageBoxButtons.OKCancel);
            MessageBox.Show($"Olá {txtNome.Text}! Seja Bem Vindo!", "Boas Vindas", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double N1 = Convert.ToDouble(txtN1.Text);
            double N2 = Convert.ToDouble(txtN2.Text);
            double resultado = (N1 + N2);
            txtResultado.Text = resultado.ToString();
        }

        private void tmrSegundos_Tick(object sender, EventArgs e)
        {
            segundos += 1;
 
            if (segundos > 59)
            {
                minutos += 1;
                segundos = 0;
            }
            lblSegundos.Text = string.Format("{0:00}:{1:00}", minutos, segundos);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrSegundos.Enabled = true;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            btnReset.Enabled = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrSegundos.Enabled = false;
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            btnReset.Enabled = true;
            btnStart.Text = "Continuar";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            segundos = 0;
            minutos = 0;
            lblSegundos.Text = segundos.ToString();
            btnReset.Enabled = false;
            btnStart.Text = "Iniciar";
        }
    }
}
