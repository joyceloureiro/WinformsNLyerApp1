namespace WindowsForms.telas.clientes
{
    partial class ClienteCadrastrar
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNomeCompleto = new TextBox();
            txtCpf = new TextBox();
            dtpNascimento = new DateTimePicker();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            lblBolsaEstudos = new Label();
            cmbBolsaEstudos = new ComboBox();
            chkEhResponsavel = new CheckBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 37);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome Completo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 91);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 1;
            label2.Text = "Data de Nascimento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(382, 37);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 2;
            label3.Text = "Cpf";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(145, 55);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(231, 23);
            txtNomeCompleto.TabIndex = 3;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(382, 55);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(100, 23);
            txtCpf.TabIndex = 5;
            // 
            // dtpNascimento
            // 
            dtpNascimento.Format = DateTimePickerFormat.Short;
            dtpNascimento.Location = new Point(149, 109);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(111, 23);
            dtpNascimento.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(28, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 82);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(146, 144);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 9;
            label4.Text = "Telefone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(329, 144);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 10;
            label5.Text = "E-mail";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(145, 162);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(161, 23);
            txtTelefone.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(329, 162);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(191, 23);
            txtEmail.TabIndex = 12;
            // 
            // lblBolsaEstudos
            // 
            lblBolsaEstudos.AutoSize = true;
            lblBolsaEstudos.Location = new Point(145, 200);
            lblBolsaEstudos.Name = "lblBolsaEstudos";
            lblBolsaEstudos.Size = new Size(95, 15);
            lblBolsaEstudos.TabIndex = 13;
            lblBolsaEstudos.Text = "Bolsa de Estudos";
            // 
            // cmbBolsaEstudos
            // 
            cmbBolsaEstudos.FormattingEnabled = true;
            cmbBolsaEstudos.Items.AddRange(new object[] { "cbBolsa" });
            cmbBolsaEstudos.Location = new Point(145, 218);
            cmbBolsaEstudos.Name = "cmbBolsaEstudos";
            cmbBolsaEstudos.Size = new Size(121, 23);
            cmbBolsaEstudos.TabIndex = 14;
            // 
            // chkEhResponsavel
            // 
            chkEhResponsavel.AutoSize = true;
            chkEhResponsavel.Location = new Point(146, 256);
            chkEhResponsavel.Name = "chkEhResponsavel";
            chkEhResponsavel.Size = new Size(183, 19);
            chkEhResponsavel.TabIndex = 16;
            chkEhResponsavel.Text = "Cliente é o responsavel legal ?";
            chkEhResponsavel.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(146, 324);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            // 
            // ClienteCadrastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(chkEhResponsavel);
            Controls.Add(cmbBolsaEstudos);
            Controls.Add(lblBolsaEstudos);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(dtpNascimento);
            Controls.Add(txtCpf);
            Controls.Add(txtNomeCompleto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ClienteCadrastrar";
            Text = "ClienteCadrastrar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNomeCompleto;
        private TextBox txtCpf;
        private DateTimePicker dtpNascimento;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private Label lblBolsaEstudos;
        private ComboBox cmbBolsaEstudos;
        private CheckBox chkEhResponsavel;
        private Button button1;
    }
}