namespace WindowsForms
{
    partial class FuncionarioView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNacionalidade = new TextBox();
            label5 = new Label();
            label4 = new Label();
            dtpNascimento = new DateTimePicker();
            txtMatricula = new TextBox();
            label3 = new Label();
            lblNascimento = new Label();
            txtCic = new TextBox();
            txtEndereco = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtEstadoCivil = new TextBox();
            label8 = new Label();
            label9 = new Label();
            dtpAdimissao = new DateTimePicker();
            label10 = new Label();
            cbmSexo = new ComboBox();
            txtNome = new TextBox();
            label11 = new Label();
            btnSalvar = new Button();
            mtxRg = new MaskedTextBox();
            mtxCpf = new MaskedTextBox();
            mtxTelefone = new MaskedTextBox();
            lblCpf = new Label();
            lblMatriculaFuncionario = new Label();
            SuspendLayout();
            // 
            // txtNacionalidade
            // 
            txtNacionalidade.Location = new Point(265, 104);
            txtNacionalidade.Name = "txtNacionalidade";
            txtNacionalidade.Size = new Size(191, 23);
            txtNacionalidade.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 255, 128);
            label5.Location = new Point(265, 86);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 20;
            label5.Text = "Nacionalidade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 255, 128);
            label4.Location = new Point(17, 135);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 19;
            label4.Text = "Telefone";
            // 
            // dtpNascimento
            // 
            dtpNascimento.Format = DateTimePickerFormat.Short;
            dtpNascimento.Location = new Point(145, 153);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(111, 23);
            dtpNascimento.TabIndex = 18;
            // 
            // txtMatricula
            // 
            txtMatricula.Enabled = false;
            txtMatricula.Location = new Point(17, 37);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(115, 23);
            txtMatricula.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 255, 128);
            label3.Location = new Point(17, 262);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 15;
            label3.Text = "RG";
            // 
            // lblNascimento
            // 
            lblNascimento.AutoSize = true;
            lblNascimento.BackColor = Color.FromArgb(255, 255, 128);
            lblNascimento.Location = new Point(145, 135);
            lblNascimento.Name = "lblNascimento";
            lblNascimento.Size = new Size(114, 15);
            lblNascimento.TabIndex = 14;
            lblNascimento.Text = "Data de Nascimento";
            // 
            // txtCic
            // 
            txtCic.Location = new Point(265, 229);
            txtCic.Name = "txtCic";
            txtCic.Size = new Size(100, 23);
            txtCic.TabIndex = 26;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(145, 280);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(251, 23);
            txtEndereco.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 255, 128);
            label6.Location = new Point(265, 211);
            label6.Name = "label6";
            label6.Size = new Size(26, 15);
            label6.TabIndex = 24;
            label6.Text = "CIC";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(255, 255, 128);
            label7.Location = new Point(145, 262);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 23;
            label7.Text = "Endereço";
            // 
            // txtEstadoCivil
            // 
            txtEstadoCivil.Location = new Point(17, 227);
            txtEstadoCivil.Name = "txtEstadoCivil";
            txtEstadoCivil.Size = new Size(115, 23);
            txtEstadoCivil.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(255, 255, 128);
            label8.Location = new Point(391, 135);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 28;
            label8.Text = "Sexo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(255, 255, 128);
            label9.Location = new Point(17, 213);
            label9.Name = "label9";
            label9.Size = new Size(68, 15);
            label9.TabIndex = 27;
            label9.Text = "Estado Civil";
            // 
            // dtpAdimissao
            // 
            dtpAdimissao.Format = DateTimePickerFormat.Short;
            dtpAdimissao.Location = new Point(145, 229);
            dtpAdimissao.Name = "dtpAdimissao";
            dtpAdimissao.Size = new Size(111, 23);
            dtpAdimissao.TabIndex = 32;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(255, 255, 128);
            label10.Location = new Point(145, 213);
            label10.Name = "label10";
            label10.Size = new Size(105, 15);
            label10.TabIndex = 31;
            label10.Text = "Data de Adimissão";
            // 
            // cbmSexo
            // 
            cbmSexo.FormattingEnabled = true;
            cbmSexo.Items.AddRange(new object[] { "Feminino", "Masculino" });
            cbmSexo.Location = new Point(391, 153);
            cbmSexo.Name = "cbmSexo";
            cbmSexo.Size = new Size(121, 23);
            cbmSexo.TabIndex = 33;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(17, 104);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(225, 23);
            txtNome.TabIndex = 35;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(255, 255, 128);
            label11.Location = new Point(17, 86);
            label11.Name = "label11";
            label11.Size = new Size(40, 15);
            label11.TabIndex = 34;
            label11.Text = "Nome";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(255, 255, 128);
            btnSalvar.Location = new Point(418, 337);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(150, 30);
            btnSalvar.TabIndex = 36;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += button1_Click;
            // 
            // mtxRg
            // 
            mtxRg.Location = new Point(17, 280);
            mtxRg.Mask = "0.000.000";
            mtxRg.Name = "mtxRg";
            mtxRg.Size = new Size(115, 23);
            mtxRg.TabIndex = 37;
            // 
            // mtxCpf
            // 
            mtxCpf.Location = new Point(280, 153);
            mtxCpf.Mask = "000.000.000-00";
            mtxCpf.Name = "mtxCpf";
            mtxCpf.Size = new Size(100, 23);
            mtxCpf.TabIndex = 38;
            // 
            // mtxTelefone
            // 
            mtxTelefone.Location = new Point(17, 153);
            mtxTelefone.Mask = "(00) 00000-0000";
            mtxTelefone.Name = "mtxTelefone";
            mtxTelefone.Size = new Size(104, 23);
            mtxTelefone.TabIndex = 39;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.BackColor = Color.FromArgb(255, 255, 128);
            lblCpf.Location = new Point(280, 135);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(28, 15);
            lblCpf.TabIndex = 40;
            lblCpf.Text = "CPF";
            // 
            // lblMatriculaFuncionario
            // 
            lblMatriculaFuncionario.AutoSize = true;
            lblMatriculaFuncionario.BackColor = Color.FromArgb(255, 255, 128);
            lblMatriculaFuncionario.Location = new Point(17, 19);
            lblMatriculaFuncionario.Name = "lblMatriculaFuncionario";
            lblMatriculaFuncionario.Size = new Size(248, 15);
            lblMatriculaFuncionario.TabIndex = 41;
            lblMatriculaFuncionario.Text = "NUMERO DA MATRICULA DO FUNCIONARIO:";
            // 
            // FuncionarioView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._2831322_menino_trabalhando_no_computador_ilustracao_conceito_gratis_vetor;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMatriculaFuncionario);
            Controls.Add(lblCpf);
            Controls.Add(mtxTelefone);
            Controls.Add(mtxCpf);
            Controls.Add(mtxRg);
            Controls.Add(btnSalvar);
            Controls.Add(txtNome);
            Controls.Add(label11);
            Controls.Add(cbmSexo);
            Controls.Add(dtpAdimissao);
            Controls.Add(label10);
            Controls.Add(txtEstadoCivil);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(txtCic);
            Controls.Add(txtEndereco);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtNacionalidade);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpNascimento);
            Controls.Add(txtMatricula);
            Controls.Add(label3);
            Controls.Add(lblNascimento);
            Name = "FuncionarioView";
            Text = "v";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNacionalidade;
        private Label label5;
        private Label label4;
        private DateTimePicker dtpNascimento;
        private TextBox txtMatricula;
        private Label label3;
        private Label lblNascimento;
        private TextBox txtCic;
        private TextBox txtEndereco;
        private Label label6;
        private Label label7;
        private TextBox txtEstadoCivil;
        private Label label8;
        private Label label9;
        private DateTimePicker dtpAdimissao;
        private Label label10;
        private ComboBox cbmSexo;
        private TextBox txtNome;
        private Label label11;
        private Button btnSalvar;
        private MaskedTextBox mtxRg;
        private MaskedTextBox mtxCpf;
        private MaskedTextBox mtxTelefone;
        private Label lblCpf;
        private Label lblMatriculaFuncionario;
    }
}