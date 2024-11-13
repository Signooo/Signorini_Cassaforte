namespace Signorini_Cassaforte
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
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            textBox2 = new TextBox();
            numericUpDown3 = new NumericUpDown();
            BottonePin = new Button();
            BottoneApri = new Button();
            BottoneChiudi = new Button();
            BottoneCodice = new Button();
            Cassaforte = new Button();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(232, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Inserisci il Pin per aprire la cassforte";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(618, 80);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(166, 23);
            textBox3.TabIndex = 2;
            textBox3.Text = "Inserisci il codice segreto";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(274, 122);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(643, 122);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(31, 202);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(120, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "Inserisci il nuovo pin";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(31, 257);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(120, 23);
            numericUpDown3.TabIndex = 5;
            // 
            // BottonePin
            // 
            BottonePin.Location = new Point(31, 318);
            BottonePin.Name = "BottonePin";
            BottonePin.Size = new Size(120, 75);
            BottonePin.TabIndex = 6;
            BottonePin.Text = "Crea nuovo pin";
            BottonePin.UseVisualStyleBackColor = true;
            // 
            // BottoneApri
            // 
            BottoneApri.Location = new Point(293, 170);
            BottoneApri.Name = "BottoneApri";
            BottoneApri.Size = new Size(75, 75);
            BottoneApri.TabIndex = 7;
            BottoneApri.Text = "Apri";
            BottoneApri.UseVisualStyleBackColor = true;
            BottoneApri.Click += BottoneApri_Click;
            // 
            // BottoneChiudi
            // 
            BottoneChiudi.Location = new Point(498, 170);
            BottoneChiudi.Name = "BottoneChiudi";
            BottoneChiudi.Size = new Size(75, 75);
            BottoneChiudi.TabIndex = 8;
            BottoneChiudi.Text = "Chiudi";
            BottoneChiudi.UseVisualStyleBackColor = true;
            BottoneChiudi.Click += BottoneChiudi_Click;
            // 
            // BottoneCodice
            // 
            BottoneCodice.Location = new Point(664, 170);
            BottoneCodice.Name = "BottoneCodice";
            BottoneCodice.Size = new Size(75, 75);
            BottoneCodice.TabIndex = 9;
            BottoneCodice.Text = "Sblocca";
            BottoneCodice.UseVisualStyleBackColor = true;
            BottoneCodice.Click += BottoneCodice_Click;
            // 
            // Cassaforte
            // 
            Cassaforte.Location = new Point(477, 318);
            Cassaforte.Name = "Cassaforte";
            Cassaforte.Size = new Size(133, 90);
            Cassaforte.TabIndex = 10;
            Cassaforte.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(498, 289);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 11;
            textBox4.Text = "Cassaforte";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 475);
            Controls.Add(textBox4);
            Controls.Add(Cassaforte);
            Controls.Add(BottoneCodice);
            Controls.Add(BottoneChiudi);
            Controls.Add(BottoneApri);
            Controls.Add(BottonePin);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox3;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private TextBox textBox2;
        private NumericUpDown numericUpDown3;
        private Button BottonePin;
        private Button BottoneApri;
        private Button BottoneChiudi;
        private Button BottoneCodice;
        private Button Cassaforte;
        private TextBox textBox4;
    }
}
