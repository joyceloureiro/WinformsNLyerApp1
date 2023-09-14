namespace WindowsForms.telas.Cargos
{
    partial class CargoView
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
            txtCargo = new TextBox();
            chkStatus = new CheckBox();
            groupBoxCargo = new GroupBox();
            txtSalvar = new Button();
            gvCargos = new DataGridView();
            btnNovoCargo = new Button();
            label1 = new Label();
            btnRegarregar = new Button();
            groupBoxCargo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvCargos).BeginInit();
            SuspendLayout();
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(6, 32);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(203, 23);
            txtCargo.TabIndex = 37;
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Location = new Point(234, 36);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(89, 19);
            chkStatus.TabIndex = 40;
            chkStatus.Text = "Cargo Ativo";
            chkStatus.UseVisualStyleBackColor = true;
            chkStatus.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // groupBoxCargo
            // 
            groupBoxCargo.Controls.Add(txtSalvar);
            groupBoxCargo.Controls.Add(txtCargo);
            groupBoxCargo.Controls.Add(chkStatus);
            groupBoxCargo.Location = new Point(12, 40);
            groupBoxCargo.Name = "groupBoxCargo";
            groupBoxCargo.Size = new Size(776, 73);
            groupBoxCargo.TabIndex = 41;
            groupBoxCargo.TabStop = false;
            groupBoxCargo.Text = "Novo cargo";
            groupBoxCargo.Visible = false;
            // 
            // txtSalvar
            // 
            txtSalvar.Location = new Point(695, 31);
            txtSalvar.Name = "txtSalvar";
            txtSalvar.Size = new Size(75, 23);
            txtSalvar.TabIndex = 41;
            txtSalvar.Text = "Salvar";
            txtSalvar.UseVisualStyleBackColor = true;
            txtSalvar.Click += txtSalvar_Click;
            // 
            // gvCargos
            // 
            gvCargos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvCargos.Location = new Point(18, 162);
            gvCargos.Name = "gvCargos";
            gvCargos.RowTemplate.Height = 25;
            gvCargos.Size = new Size(753, 276);
            gvCargos.TabIndex = 42;
            // 
            // btnNovoCargo
            // 
            btnNovoCargo.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            btnNovoCargo.Location = new Point(18, 3);
            btnNovoCargo.Name = "btnNovoCargo";
            btnNovoCargo.Size = new Size(111, 31);
            btnNovoCargo.TabIndex = 43;
            btnNovoCargo.Text = "Novo cargo";
            btnNovoCargo.UseVisualStyleBackColor = true;
            btnNovoCargo.Click += btnNovoCargo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 144);
            label1.Name = "label1";
            label1.Size = new Size(152, 15);
            label1.TabIndex = 44;
            label1.Text = "Todos os cargos  (GridView)";
            // 
            // btnRegarregar
            // 
            btnRegarregar.Location = new Point(696, 136);
            btnRegarregar.Name = "btnRegarregar";
            btnRegarregar.Size = new Size(75, 23);
            btnRegarregar.TabIndex = 45;
            btnRegarregar.Text = "Regarregar";
            btnRegarregar.UseVisualStyleBackColor = true;
            // 
            // CargoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegarregar);
            Controls.Add(label1);
            Controls.Add(btnNovoCargo);
            Controls.Add(gvCargos);
            Controls.Add(groupBoxCargo);
            Name = "CargoView";
            Text = "CargoView";
            groupBoxCargo.ResumeLayout(false);
            groupBoxCargo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gvCargos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label label11;
        private TextBox txtCargo;
        private CheckBox chkStatus;
        private GroupBox groupBoxCargo;
        private Button txtSalvar;
        private DataGridView gvCargos;
        private Button btnNovoCargo;
        private Label label1;
        private Button btnRegarregar;
    }
}