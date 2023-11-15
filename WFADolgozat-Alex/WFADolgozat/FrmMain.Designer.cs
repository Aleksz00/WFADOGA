namespace WFADolgozat
{
    partial class FrmMain
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
            lblWelcome = new Label();
            txtName = new TextBox();
            btnKoszon = new Button();
            lblUdvozol = new Label();
            lblRed = new Label();
            lblGreen = new Label();
            lblBlue = new Label();
            btnlOssze = new Button();
            btnKivon = new Button();
            btnOszt = new Button();
            btnSzorz = new Button();
            txtelsoSzam = new TextBox();
            txtmasodikSzam = new TextBox();
            label1 = new Label();
            lblEredmeny = new Label();
            btnSzamol = new Button();
            btnKilep = new Button();
            alaphelyzet = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(12, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(29, 15);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "név:";
            // 
            // txtName
            // 
            txtName.Location = new Point(47, 6);
            txtName.Name = "txtName";
            txtName.Size = new Size(116, 23);
            txtName.TabIndex = 1;
            // 
            // btnKoszon
            // 
            btnKoszon.Location = new Point(169, 6);
            btnKoszon.Name = "btnKoszon";
            btnKoszon.Size = new Size(75, 23);
            btnKoszon.TabIndex = 2;
            btnKoszon.Text = "Köszönj!";
            btnKoszon.UseVisualStyleBackColor = true;
            // 
            // lblUdvozol
            // 
            lblUdvozol.BackColor = Color.Khaki;
            lblUdvozol.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUdvozol.Location = new Point(12, 32);
            lblUdvozol.Name = "lblUdvozol";
            lblUdvozol.Size = new Size(232, 38);
            lblUdvozol.TabIndex = 3;
            lblUdvozol.Text = "###UDVOZLES###";
            lblUdvozol.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRed
            // 
            lblRed.BackColor = Color.Red;
            lblRed.ForeColor = Color.White;
            lblRed.Location = new Point(317, 10);
            lblRed.Name = "lblRed";
            lblRed.Size = new Size(49, 51);
            lblRed.TabIndex = 4;
            lblRed.Text = "Red";
            // 
            // lblGreen
            // 
            lblGreen.BackColor = Color.Green;
            lblGreen.ForeColor = Color.White;
            lblGreen.Location = new Point(372, 10);
            lblGreen.Name = "lblGreen";
            lblGreen.Size = new Size(49, 51);
            lblGreen.TabIndex = 4;
            lblGreen.Text = "Green";
            // 
            // lblBlue
            // 
            lblBlue.BackColor = Color.Blue;
            lblBlue.ForeColor = Color.White;
            lblBlue.Location = new Point(427, 9);
            lblBlue.Name = "lblBlue";
            lblBlue.Size = new Size(49, 51);
            lblBlue.TabIndex = 4;
            lblBlue.Text = "Blue";
            // 
            // btnlOssze
            // 
            btnlOssze.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnlOssze.Location = new Point(92, 84);
            btnlOssze.Name = "btnlOssze";
            btnlOssze.Size = new Size(30, 30);
            btnlOssze.TabIndex = 5;
            btnlOssze.Text = "+";
            btnlOssze.UseVisualStyleBackColor = true;
            // 
            // btnKivon
            // 
            btnKivon.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKivon.Location = new Point(128, 84);
            btnKivon.Name = "btnKivon";
            btnKivon.Size = new Size(30, 30);
            btnKivon.TabIndex = 5;
            btnKivon.Text = "-";
            btnKivon.UseVisualStyleBackColor = true;
            // 
            // btnOszt
            // 
            btnOszt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOszt.Location = new Point(128, 120);
            btnOszt.Name = "btnOszt";
            btnOszt.Size = new Size(30, 30);
            btnOszt.TabIndex = 5;
            btnOszt.Text = "/";
            btnOszt.UseVisualStyleBackColor = true;
            // 
            // btnSzorz
            // 
            btnSzorz.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSzorz.Location = new Point(92, 120);
            btnSzorz.Name = "btnSzorz";
            btnSzorz.Size = new Size(30, 30);
            btnSzorz.TabIndex = 5;
            btnSzorz.Text = "*";
            btnSzorz.UseVisualStyleBackColor = true;
            // 
            // txtelsoSzam
            // 
            txtelsoSzam.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtelsoSzam.Location = new Point(12, 84);
            txtelsoSzam.Name = "txtelsoSzam";
            txtelsoSzam.Size = new Size(74, 43);
            txtelsoSzam.TabIndex = 6;
            // 
            // txtmasodikSzam
            // 
            txtmasodikSzam.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtmasodikSzam.Location = new Point(170, 81);
            txtmasodikSzam.Name = "txtmasodikSzam";
            txtmasodikSzam.Size = new Size(74, 43);
            txtmasodikSzam.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(250, 84);
            label1.Name = "label1";
            label1.Size = new Size(35, 37);
            label1.TabIndex = 7;
            label1.Text = "=";
            // 
            // lblEredmeny
            // 
            lblEredmeny.BackColor = Color.White;
            lblEredmeny.BorderStyle = BorderStyle.FixedSingle;
            lblEredmeny.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEredmeny.Location = new Point(280, 87);
            lblEredmeny.Name = "lblEredmeny";
            lblEredmeny.Size = new Size(106, 34);
            lblEredmeny.TabIndex = 8;
            lblEredmeny.Text = "#eredmeny#";
            lblEredmeny.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSzamol
            // 
            btnSzamol.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSzamol.Location = new Point(12, 156);
            btnSzamol.Name = "btnSzamol";
            btnSzamol.Size = new Size(489, 34);
            btnSzamol.TabIndex = 9;
            btnSzamol.Text = "Számolj!";
            btnSzamol.UseVisualStyleBackColor = true;
            // 
            // btnKilep
            // 
            btnKilep.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKilep.ForeColor = Color.Red;
            btnKilep.Location = new Point(389, 196);
            btnKilep.Name = "btnKilep";
            btnKilep.Size = new Size(75, 34);
            btnKilep.TabIndex = 10;
            btnKilep.Text = "Kilépés";
            btnKilep.UseVisualStyleBackColor = true;
            // 
            // alaphelyzet
            // 
            alaphelyzet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            alaphelyzet.ForeColor = Color.FromArgb(0, 0, 192);
            alaphelyzet.Location = new Point(293, 196);
            alaphelyzet.Name = "alaphelyzet";
            alaphelyzet.Size = new Size(93, 34);
            alaphelyzet.TabIndex = 10;
            alaphelyzet.Text = "Alaphelyzet";
            alaphelyzet.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 245);
            Controls.Add(alaphelyzet);
            Controls.Add(btnKilep);
            Controls.Add(btnSzamol);
            Controls.Add(lblEredmeny);
            Controls.Add(label1);
            Controls.Add(txtmasodikSzam);
            Controls.Add(txtelsoSzam);
            Controls.Add(btnSzorz);
            Controls.Add(btnOszt);
            Controls.Add(btnKivon);
            Controls.Add(btnlOssze);
            Controls.Add(lblBlue);
            Controls.Add(lblGreen);
            Controls.Add(lblRed);
            Controls.Add(lblUdvozol);
            Controls.Add(btnKoszon);
            Controls.Add(txtName);
            Controls.Add(lblWelcome);
            Name = "FrmMain";
            Text = "WFA Dolgozat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private TextBox txtName;
        private Button btnKoszon;
        private Label lblUdvozol;
        private Label lblRed;
        private Label lblGreen;
        private Label lblBlue;
        private Button btnlOssze;
        private Button btnKivon;
        private Button btnOszt;
        private Button btnSzorz;
        private TextBox txtelsoSzam;
        private TextBox txtmasodikSzam;
        private Label label1;
        private Label lblEredmeny;
        private Button btnSzamol;
        private Button btnKilep;
        private Button alaphelyzet;
    }
}