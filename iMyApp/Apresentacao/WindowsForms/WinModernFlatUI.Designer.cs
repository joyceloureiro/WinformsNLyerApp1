namespace WindowsForms
{
    partial class WinModernFlatUI
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
            iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            panelMenu = new Panel();
            icbSett = new FontAwesome.Sharp.IconButton();
            icbmar = new FontAwesome.Sharp.IconButton();
            icbCu = new FontAwesome.Sharp.IconButton();
            icbPr = new FontAwesome.Sharp.IconButton();
            icbOr = new FontAwesome.Sharp.IconButton();
            icbDash = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // iconDropDownButton1
            // 
            iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconDropDownButton1.IconColor = Color.Black;
            iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconDropDownButton1.Name = "iconDropDownButton1";
            iconDropDownButton1.Size = new Size(23, 23);
            iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Indigo;
            panelMenu.Controls.Add(icbSett);
            panelMenu.Controls.Add(icbmar);
            panelMenu.Controls.Add(icbCu);
            panelMenu.Controls.Add(icbPr);
            panelMenu.Controls.Add(icbOr);
            panelMenu.Controls.Add(icbDash);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 494);
            panelMenu.TabIndex = 0;
            // 
            // icbSett
            // 
            icbSett.Dock = DockStyle.Top;
            icbSett.FlatAppearance.BorderSize = 0;
            icbSett.FlatStyle = FlatStyle.Flat;
            icbSett.IconChar = FontAwesome.Sharp.IconChar.Tools;
            icbSett.IconColor = Color.Ivory;
            icbSett.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbSett.IconSize = 32;
            icbSett.ImageAlign = ContentAlignment.MiddleLeft;
            icbSett.Location = new Point(0, 410);
            icbSett.Name = "icbSett";
            icbSett.Size = new Size(200, 60);
            icbSett.TabIndex = 6;
            icbSett.Text = "Setting";
            icbSett.TextAlign = ContentAlignment.MiddleLeft;
            icbSett.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbSett.UseVisualStyleBackColor = true;
            icbSett.Click += icbSett_Click;
            // 
            // icbmar
            // 
            icbmar.Dock = DockStyle.Top;
            icbmar.FlatAppearance.BorderSize = 0;
            icbmar.FlatStyle = FlatStyle.Flat;
            icbmar.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            icbmar.IconColor = Color.Ivory;
            icbmar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbmar.IconSize = 32;
            icbmar.ImageAlign = ContentAlignment.MiddleLeft;
            icbmar.Location = new Point(0, 350);
            icbmar.Name = "icbmar";
            icbmar.Size = new Size(200, 60);
            icbmar.TabIndex = 5;
            icbmar.Text = "Marketing";
            icbmar.TextAlign = ContentAlignment.MiddleLeft;
            icbmar.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbmar.UseVisualStyleBackColor = true;
            icbmar.Click += icbmar_Click;
            // 
            // icbCu
            // 
            icbCu.Dock = DockStyle.Top;
            icbCu.FlatAppearance.BorderSize = 0;
            icbCu.FlatStyle = FlatStyle.Flat;
            icbCu.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            icbCu.IconColor = Color.Ivory;
            icbCu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbCu.IconSize = 32;
            icbCu.ImageAlign = ContentAlignment.MiddleLeft;
            icbCu.Location = new Point(0, 290);
            icbCu.Name = "icbCu";
            icbCu.Size = new Size(200, 60);
            icbCu.TabIndex = 4;
            icbCu.Text = "Custorms";
            icbCu.TextAlign = ContentAlignment.MiddleLeft;
            icbCu.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbCu.UseVisualStyleBackColor = true;
            icbCu.Click += icbCu_Click;
            // 
            // icbPr
            // 
            icbPr.Dock = DockStyle.Top;
            icbPr.FlatAppearance.BorderSize = 0;
            icbPr.FlatStyle = FlatStyle.Flat;
            icbPr.IconChar = FontAwesome.Sharp.IconChar.Tag;
            icbPr.IconColor = Color.Ivory;
            icbPr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbPr.IconSize = 32;
            icbPr.ImageAlign = ContentAlignment.MiddleLeft;
            icbPr.Location = new Point(0, 230);
            icbPr.Name = "icbPr";
            icbPr.Size = new Size(200, 60);
            icbPr.TabIndex = 3;
            icbPr.Text = "Products";
            icbPr.TextAlign = ContentAlignment.MiddleLeft;
            icbPr.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbPr.UseVisualStyleBackColor = true;
            icbPr.Click += icbPr_Click;
            // 
            // icbOr
            // 
            icbOr.Dock = DockStyle.Top;
            icbOr.FlatAppearance.BorderSize = 0;
            icbOr.FlatStyle = FlatStyle.Flat;
            icbOr.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            icbOr.IconColor = Color.Ivory;
            icbOr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbOr.IconSize = 32;
            icbOr.ImageAlign = ContentAlignment.MiddleLeft;
            icbOr.Location = new Point(0, 170);
            icbOr.Name = "icbOr";
            icbOr.Size = new Size(200, 60);
            icbOr.TabIndex = 2;
            icbOr.Text = "Ordens";
            icbOr.TextAlign = ContentAlignment.MiddleLeft;
            icbOr.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbOr.UseVisualStyleBackColor = true;
            icbOr.Click += icbOr_Click;
            // 
            // icbDash
            // 
            icbDash.Dock = DockStyle.Top;
            icbDash.FlatAppearance.BorderSize = 0;
            icbDash.FlatStyle = FlatStyle.Flat;
            icbDash.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            icbDash.IconColor = Color.Ivory;
            icbDash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbDash.IconSize = 32;
            icbDash.ImageAlign = ContentAlignment.MiddleLeft;
            icbDash.Location = new Point(0, 110);
            icbDash.Name = "icbDash";
            icbDash.Size = new Size(200, 60);
            icbDash.TabIndex = 1;
            icbDash.Text = "Dashboord";
            icbDash.TextAlign = ContentAlignment.MiddleLeft;
            icbDash.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbDash.UseVisualStyleBackColor = true;
            icbDash.Click += icbDash_Click;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Padding = new Padding(10, 0, 20, 0);
            panelLogo.Size = new Size(200, 110);
            panelLogo.TabIndex = 1;
            // 
            // WinModernFlatUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 494);
            Controls.Add(panelMenu);
            ForeColor = Color.Gainsboro;
            Name = "WinModernFlatUI";
            Text = "WinModernFlatUI";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton icbDash;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton icbSett;
        private FontAwesome.Sharp.IconButton icbmar;
        private FontAwesome.Sharp.IconButton icbCu;
        private FontAwesome.Sharp.IconButton icbPr;
        private FontAwesome.Sharp.IconButton icbOr;
    }
}