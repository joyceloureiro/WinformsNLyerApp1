namespace WindowsForms
{
    partial class Tela
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
            txtNacionalidade=new TextBox();
            txtTelefone=new TextBox();
            label5=new Label();
            label4=new Label();
            dtpNascimento=new DateTimePicker();
            txtRg=new TextBox();
            txtMatricula=new TextBox();
            label3=new Label();
            lblNascimento=new Label();
            label1=new Label();
            txtCic=new TextBox();
            txtEndereco=new TextBox();
            label6=new Label();
            label7=new Label();
            txtEstadoCivil=new TextBox();
            label8=new Label();
            label9=new Label();
            dtpAdimissao=new DateTimePicker();
            label10=new Label();
            cbmSexo=new ComboBox();
            txtNome=new TextBox();
            label11=new Label();
            button1=new Button();
            SuspendLayout();
            // 
            // txtNacionalidade
            // 
            txtNacionalidade.Location=new Point(211, 197);
            txtNacionalidade.Name="txtNacionalidade";
            txtNacionalidade.Size=new Size(191, 23);
            txtNacionalidade.TabIndex=22;
            // 
            // txtTelefone
            // 
            txtTelefone.Location=new Point(28, 197);
            txtTelefone.Name="txtTelefone";
            txtTelefone.Size=new Size(161, 23);
            txtTelefone.TabIndex=21;
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point(211, 179);
            label5.Name="label5";
            label5.Size=new Size(83, 15);
            label5.TabIndex=20;
            label5.Text="Nacionalidade";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(28, 179);
            label4.Name="label4";
            label4.Size=new Size(51, 15);
            label4.TabIndex=19;
            label4.Text="Telefone";
            // 
            // dtpNascimento
            // 
            dtpNascimento.Format=DateTimePickerFormat.Short;
            dtpNascimento.Location=new Point(28, 142);
            dtpNascimento.Name="dtpNascimento";
            dtpNascimento.Size=new Size(111, 23);
            dtpNascimento.TabIndex=18;
            // 
            // txtRg
            // 
            txtRg.Location=new Point(167, 256);
            txtRg.Name="txtRg";
            txtRg.Size=new Size(100, 23);
            txtRg.TabIndex=17;
            txtRg.TextChanged+=txtCpf_TextChanged;
            // 
            // txtMatricula
            // 
            txtMatricula.Location=new Point(275, 82);
            txtMatricula.Name="txtMatricula";
            txtMatricula.Size=new Size(115, 23);
            txtMatricula.TabIndex=16;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(167, 238);
            label3.Name="label3";
            label3.Size=new Size(22, 15);
            label3.TabIndex=15;
            label3.Text="RG";
            label3.Click+=label3_Click;
            // 
            // lblNascimento
            // 
            lblNascimento.AutoSize=true;
            lblNascimento.Location=new Point(28, 124);
            lblNascimento.Name="lblNascimento";
            lblNascimento.Size=new Size(114, 15);
            lblNascimento.TabIndex=14;
            lblNascimento.Text="Data de Nascimento";
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(275, 59);
            label1.Name="label1";
            label1.Size=new Size(57, 15);
            label1.TabIndex=13;
            label1.Text="Matricula";
            // 
            // txtCic
            // 
            txtCic.Location=new Point(413, 197);
            txtCic.Name="txtCic";
            txtCic.Size=new Size(100, 23);
            txtCic.TabIndex=26;
            txtCic.TextChanged+=textBox1_TextChanged;
            // 
            // txtEndereco
            // 
            txtEndereco.Location=new Point(287, 256);
            txtEndereco.Name="txtEndereco";
            txtEndereco.Size=new Size(115, 23);
            txtEndereco.TabIndex=25;
            txtEndereco.TextChanged+=textBox2_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Location=new Point(413, 179);
            label6.Name="label6";
            label6.Size=new Size(26, 15);
            label6.TabIndex=24;
            label6.Text="CIC";
            label6.Click+=label6_Click;
            // 
            // label7
            // 
            label7.AutoSize=true;
            label7.Location=new Point(287, 238);
            label7.Name="label7";
            label7.Size=new Size(56, 15);
            label7.TabIndex=23;
            label7.Text="Endereço";
            label7.Click+=label7_Click;
            // 
            // txtEstadoCivil
            // 
            txtEstadoCivil.Location=new Point(28, 256);
            txtEstadoCivil.Name="txtEstadoCivil";
            txtEstadoCivil.Size=new Size(115, 23);
            txtEstadoCivil.TabIndex=29;
            // 
            // label8
            // 
            label8.AutoSize=true;
            label8.Location=new Point(413, 238);
            label8.Name="label8";
            label8.Size=new Size(32, 15);
            label8.TabIndex=28;
            label8.Text="Sexo";
            // 
            // label9
            // 
            label9.AutoSize=true;
            label9.Location=new Point(28, 238);
            label9.Name="label9";
            label9.Size=new Size(68, 15);
            label9.TabIndex=27;
            label9.Text="Estado Civil";
            // 
            // dtpAdimissao
            // 
            dtpAdimissao.Format=DateTimePickerFormat.Short;
            dtpAdimissao.Location=new Point(167, 142);
            dtpAdimissao.Name="dtpAdimissao";
            dtpAdimissao.Size=new Size(111, 23);
            dtpAdimissao.TabIndex=32;
            // 
            // label10
            // 
            label10.AutoSize=true;
            label10.Location=new Point(162, 124);
            label10.Name="label10";
            label10.Size=new Size(105, 15);
            label10.TabIndex=31;
            label10.Text="Data de Adimissão";
            // 
            // cbmSexo
            // 
            cbmSexo.FormattingEnabled=true;
            cbmSexo.Items.AddRange(new object[] { "Feminino", "Masculino" });
            cbmSexo.Location=new Point(413, 256);
            cbmSexo.Name="cbmSexo";
            cbmSexo.Size=new Size(121, 23);
            cbmSexo.TabIndex=33;
            // 
            // txtNome
            // 
            txtNome.Location=new Point(28, 82);
            txtNome.Name="txtNome";
            txtNome.Size=new Size(225, 23);
            txtNome.TabIndex=35;
            // 
            // label11
            // 
            label11.AutoSize=true;
            label11.Location=new Point(28, 59);
            label11.Name="label11";
            label11.Size=new Size(40, 15);
            label11.TabIndex=34;
            label11.Text="Nome";
            // 
            // button1
            // 
            button1.Location=new Point(211, 350);
            button1.Name="button1";
            button1.Size=new Size(151, 23);
            button1.TabIndex=36;
            button1.Text="button1";
            button1.UseVisualStyleBackColor=true;
            // 
            // Tela
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(button1);
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
            Controls.Add(txtTelefone);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpNascimento);
            Controls.Add(txtRg);
            Controls.Add(txtMatricula);
            Controls.Add(label3);
            Controls.Add(lblNascimento);
            Controls.Add(label1);
            Name="Tela";
            Text="Tela";
            Load+=Tela_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNacionalidade;
        private TextBox txtTelefone;
        private Label label5;
        private Label label4;
        private DateTimePicker dtpNascimento;
        private TextBox txtRg;
        private TextBox txtMatricula;
        private Label label3;
        private Label lblNascimento;
        private Label label1;
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
        private Button button1;
    }
}