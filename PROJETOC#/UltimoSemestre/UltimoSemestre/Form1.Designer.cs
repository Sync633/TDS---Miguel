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
            btnExcluir = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpregados).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(21, 29);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.Location = new Point(21, 53);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(68, 15);
            lblSobrenome.TabIndex = 1;
            lblSobrenome.Text = "Sobrenome";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(21, 78);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(28, 15);
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
            groupBox1.Location = new Point(10, 228);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(685, 118);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Empregado";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(127, 76);
            txtCpf.Margin = new Padding(3, 2, 3, 2);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(110, 23);
            txtCpf.TabIndex = 5;
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(127, 51);
            txtSobrenome.Margin = new Padding(3, 2, 3, 2);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(502, 23);
            txtSobrenome.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(127, 26);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(502, 23);
            txtNome.TabIndex = 3;
            // 
            // btnEnviar
            // 
            btnEnviar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEnviar.Location = new Point(522, 350);
            btnEnviar.Margin = new Padding(3, 2, 3, 2);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(174, 49);
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
            dgvEmpregados.Location = new Point(10, 9);
            dgvEmpregados.Margin = new Padding(3, 2, 3, 2);
            dgvEmpregados.Name = "dgvEmpregados";
            dgvEmpregados.ReadOnly = true;
            dgvEmpregados.RowHeadersVisible = false;
            dgvEmpregados.RowHeadersWidth = 51;
            dgvEmpregados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpregados.Size = new Size(685, 215);
            dgvEmpregados.TabIndex = 5;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(408, 353);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(108, 43);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // frmEmpregados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 409);
            Controls.Add(btnExcluir);
            Controls.Add(dgvEmpregados);
            Controls.Add(btnEnviar);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmEmpregados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão de Empregados";
            Load += Form1_Load;
            SizeChanged += Form1_SizeChanged;
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
        private Button btnExcluir;
    }
}
