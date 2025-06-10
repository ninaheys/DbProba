namespace Szamosszeado
{
    partial class Form1
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
            btnOsszead = new Button();
            labelSzam1 = new Label();
            labelSzam2 = new Label();
            tbSzam1 = new TextBox();
            tbSzam2 = new TextBox();
            labelEredmeny = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnOsszead
            // 
            btnOsszead.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnOsszead.Location = new Point(43, 196);
            btnOsszead.Name = "btnOsszead";
            btnOsszead.Size = new Size(203, 54);
            btnOsszead.TabIndex = 0;
            btnOsszead.Text = "Összead";
            btnOsszead.UseVisualStyleBackColor = true;
            btnOsszead.Click += btnOsszead_Click;
            // 
            // labelSzam1
            // 
            labelSzam1.AutoSize = true;
            labelSzam1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelSzam1.Location = new Point(43, 71);
            labelSzam1.Name = "labelSzam1";
            labelSzam1.Size = new Size(83, 30);
            labelSzam1.TabIndex = 2;
            labelSzam1.Text = "Szám1:";
            // 
            // labelSzam2
            // 
            labelSzam2.AutoSize = true;
            labelSzam2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelSzam2.Location = new Point(43, 125);
            labelSzam2.Name = "labelSzam2";
            labelSzam2.Size = new Size(83, 30);
            labelSzam2.TabIndex = 2;
            labelSzam2.Text = "Szám2:";
            // 
            // tbSzam1
            // 
            tbSzam1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            tbSzam1.Location = new Point(146, 71);
            tbSzam1.Name = "tbSzam1";
            tbSzam1.Size = new Size(100, 35);
            tbSzam1.TabIndex = 3;
            // 
            // tbSzam2
            // 
            tbSzam2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            tbSzam2.Location = new Point(146, 125);
            tbSzam2.Name = "tbSzam2";
            tbSzam2.Size = new Size(100, 35);
            tbSzam2.TabIndex = 4;
            // 
            // labelEredmeny
            // 
            labelEredmeny.AutoSize = true;
            labelEredmeny.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelEredmeny.Location = new Point(288, 74);
            labelEredmeny.Name = "labelEredmeny";
            labelEredmeny.Size = new Size(74, 86);
            labelEredmeny.TabIndex = 5;
            labelEredmeny.Text = "0";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(262, 27);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 295);
            Controls.Add(textBox1);
            Controls.Add(labelEredmeny);
            Controls.Add(tbSzam2);
            Controls.Add(tbSzam1);
            Controls.Add(labelSzam2);
            Controls.Add(labelSzam1);
            Controls.Add(btnOsszead);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOsszead;
        private Label labelSzam1;
        private Label labelSzam2;
        private TextBox tbSzam1;
        private TextBox tbSzam2;
        private Label labelEredmeny;
        private TextBox textBox1;
    }
}
