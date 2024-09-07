namespace UltimoSemestre
{
    public partial class frmEmpregados : Form
    {
        public frmEmpregados()
        {
            InitializeComponent();
        }

        private void txtNome_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvEmpregado.DataSource = em.Consultar();
            dgvEmpregado.Columns[0].Width = (this.Width / 100) * 40;
            dgvEmpregado.Columns[1].Width = (this.Width / 100) * 40;
            dgvEmpregado.Columns[2].Width = (this.Width / 100) * 20;
            gbEmpregado.Width = this.Width - 50;
            txtNome.Width = gbEmpregado.Width - 300;
            txtSobrenome.Width = gbEmpregado.Width - 300;
            txtCpf.Width = gbEmpregado.Width - 800;
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
                MessageBox.Show("Informações gravadas com sucesso!");

                dgvEmpregado.DataSource = em.Consultar();
                dgvEmpregado.Columns[0].Visible = false;
            }
        }

        private void frmEmpregados_SizeChanged(object sender, EventArgs e)
        {
            dgvEmpregado.Width = this.Width - 50;
            dgvEmpregado.Columns[0].Width = (this.Width / 100) * 40;
            dgvEmpregado.Columns[1].Width = (this.Width / 100) * 40;
            dgvEmpregado.Columns[2].Width = (this.Width / 100) * 20;
            gbEmpregado.Width = this.Width - 50;
            txtNome.Width = gbEmpregado.Width - 300;
            txtSobrenome.Width = gbEmpregado.Width - 300;
            txtCpf.Width = gbEmpregado.Width - 800;
        }
    }
}
