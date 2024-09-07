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
            gbEmpregado = new GroupBox();
            btnEnviar = new Button();
            txtCpf = new TextBox();
            txtSobrenome = new TextBox();
            txtNome = new TextBox();
            dgvEmpregado = new DataGridView();
            gbEmpregado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpregado).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Lime;
            lblNome.Location = new Point(19, 40);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 21);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            lblNome.Click += txtNome_Click;
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.BackColor = Color.Lime;
            lblSobrenome.Location = new Point(19, 69);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(84, 21);
            lblSobrenome.TabIndex = 1;
            lblSobrenome.Text = "Sobrenome";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.BackColor = Color.Lime;
            lblCpf.Location = new Point(19, 98);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(37, 21);
            lblCpf.TabIndex = 2;
            lblCpf.Text = "CPF";
            // 
            // gbEmpregado
            // 
            gbEmpregado.BackColor = Color.Indigo;
            gbEmpregado.Controls.Add(btnEnviar);
            gbEmpregado.Controls.Add(txtCpf);
            gbEmpregado.Controls.Add(txtSobrenome);
            gbEmpregado.Controls.Add(txtNome);
            gbEmpregado.Controls.Add(lblCpf);
            gbEmpregado.Controls.Add(lblSobrenome);
            gbEmpregado.Controls.Add(lblNome);
            gbEmpregado.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbEmpregado.Location = new Point(12, 289);
            gbEmpregado.Name = "gbEmpregado";
            gbEmpregado.Size = new Size(450, 230);
            gbEmpregado.TabIndex = 3;
            gbEmpregado.TabStop = false;
            gbEmpregado.Text = "Empregado";
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.Aqua;
            btnEnviar.Font = new Font("Goudy Old Style", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnviar.Location = new Point(291, 146);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(138, 65);
            btnEnviar.TabIndex = 6;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txtCpf
            // 
            txtCpf.BackColor = Color.IndianRed;
            txtCpf.Location = new Point(62, 95);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(191, 27);
            txtCpf.TabIndex = 5;
            // 
            // txtSobrenome
            // 
            txtSobrenome.BackColor = Color.IndianRed;
            txtSobrenome.Location = new Point(109, 66);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(297, 27);
            txtSobrenome.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.IndianRed;
            txtNome.Location = new Point(75, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(331, 27);
            txtNome.TabIndex = 3;
            // 
            // dgvEmpregado
            // 
            dgvEmpregado.AllowUserToAddRows = false;
            dgvEmpregado.AllowUserToDeleteRows = false;
            dgvEmpregado.BackgroundColor = Color.Crimson;
            dgvEmpregado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpregado.Location = new Point(12, 53);
            dgvEmpregado.Name = "dgvEmpregado";
            dgvEmpregado.ReadOnly = true;
            dgvEmpregado.RowHeadersVisible = false;
            dgvEmpregado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpregado.Size = new Size(686, 230);
            dgvEmpregado.TabIndex = 7;
            // 
            // frmEmpregados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(1253, 624);
            Controls.Add(dgvEmpregado);
            Controls.Add(gbEmpregado);
            ForeColor = SystemColors.Desktop;
            Name = "frmEmpregados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão de Empregados";
            Load += Form1_Load;
            SizeChanged += frmEmpregados_SizeChanged;
            gbEmpregado.ResumeLayout(false);
            gbEmpregado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpregado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNome;
        private Label lblSobrenome;
        private Label lblCpf;
        private GroupBox gbEmpregado;
        private TextBox txtCpf;
        private TextBox txtSobrenome;
        private TextBox txtNome;
        private Button btnEnviar;
        private DataGridView dgvEmpregado;
    }
}
