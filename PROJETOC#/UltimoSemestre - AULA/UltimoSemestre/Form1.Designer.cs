namespace UltimoSemestre
{
    partial class frmEmpregados
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNome = new Label();
            lblSobrenome = new Label();
            lblCpf = new Label();
            groupBox1 = new GroupBox();
            txtCpf = new TextBox();
            txtSobrenome = new TextBox();
            txtNome = new TextBox();
            btnEnviar = new Button();
            dgvEmpregados = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpregados).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(30, 48);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(61, 25);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.Location = new Point(30, 89);
            lblSobrenome.Margin = new Padding(4, 0, 4, 0);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(105, 25);
            lblSobrenome.TabIndex = 1;
            lblSobrenome.Text = "Sobrenome";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(30, 130);
            lblCpf.Margin = new Padding(4, 0, 4, 0);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(42, 25);
            lblCpf.TabIndex = 2;
            lblCpf.Text = "CPF";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCpf);
            groupBox1.Controls.Add(txtSobrenome);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(lblNome);
            groupBox1.Controls.Add(lblCpf);
            groupBox1.Controls.Add(lblSobrenome);
            groupBox1.Location = new Point(15, 380);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(979, 196);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Empregado";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(182, 126);
            txtCpf.Margin = new Padding(4, 4, 4, 4);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(155, 31);
            txtCpf.TabIndex = 5;
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(182, 85);
            txtSobrenome.Margin = new Padding(4, 4, 4, 4);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(716, 31);
            txtSobrenome.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(182, 44);
            txtNome.Margin = new Padding(4, 4, 4, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(716, 31);
            txtNome.TabIndex = 3;
            // 
            // btnEnviar
            // 
            btnEnviar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEnviar.Location = new Point(746, 584);
            btnEnviar.Margin = new Padding(4, 4, 4, 4);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(248, 82);
            btnEnviar.TabIndex = 4;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // dgvEmpregados
            // 
            dgvEmpregados.AllowUserToAddRows = false;
            dgvEmpregados.AllowUserToDeleteRows = false;
            dgvEmpregados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpregados.Location = new Point(15, 15);
            dgvEmpregados.Margin = new Padding(4, 4, 4, 4);
            dgvEmpregados.Name = "dgvEmpregados";
            dgvEmpregados.ReadOnly = true;
            dgvEmpregados.RowHeadersVisible = false;
            dgvEmpregados.RowHeadersWidth = 51;
            dgvEmpregados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpregados.Size = new Size(979, 358);
            dgvEmpregados.TabIndex = 5;
            // 
            // frmEmpregados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 681);
            Controls.Add(dgvEmpregados);
            Controls.Add(btnEnviar);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmEmpregados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão de Empregados";
            Load += Form1_Load;
            SizeChanged += frmEmpregados_SizeChanged;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpregados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNome;
        private Label lblSobrenome;
        private Label lblCpf;
        private GroupBox groupBox1;
        private TextBox txtNome;
        private TextBox txtCpf;
        private TextBox txtSobrenome;
        private Button btnEnviar;
        private DataGridView dgvEmpregados;
    }
}
