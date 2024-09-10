using System.Windows.Forms;

namespace UltimoSemestre
{
    public partial class frmEmpregados : Form
    {
        public frmEmpregados()
        {
            InitializeComponent();
        }

        Empregado em = new Empregado();
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                em.setCpf(txtCpf.Text);
                em.setNome(txtNome.Text);
                em.setSobrenome(txtSobrenome.Text);
                em.Inserir();

            }

            finally
            {
                MessageBox.Show("Informações gravadas com sucesso");
            }

            dgvEmpregados.DataSource = em.Consultar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvEmpregados.DataSource = em.Consultar();
            dgvEmpregados.Columns[0].Visible = false;
            dgvEmpregados.Columns[1].Width = (this.Width / 100) * 40;
            dgvEmpregados.Columns[2].Width = (this.Width / 100) * 40;
            dgvEmpregados.Columns[3].Width = (this.Width / 100) * 20;
        }






        private void frmEmpregados_SizeChanged(object sender, EventArgs e)
        {
            dgvEmpregados.Width = this.Width - 50;
        }
    }
}
