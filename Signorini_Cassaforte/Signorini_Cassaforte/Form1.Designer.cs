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
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            BottonePin = new Button();
            BottoneApri = new Button();
            BottoneChiudi = new Button();
            BottoneCodice = new Button();
            Cassaforte = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(274, 122);
            numericUpDown1.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(643, 122);
            numericUpDown2.Maximum = new decimal(new int[] { -294420992, 1321, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 4;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(31, 257);
            numericUpDown3.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
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
            BottonePin.Click += BottonePin_Click;
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
            Cassaforte.Location = new Point(481, 318);
            Cassaforte.Name = "Cassaforte";
            Cassaforte.Size = new Size(133, 90);
            Cassaforte.TabIndex = 10;
            Cassaforte.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(643, 92);
            label1.Name = "label1";
            label1.Size = new Size(138, 15);
            label1.TabIndex = 12;
            label1.Text = "Inserisci il codice segreto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 230);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 13;
            label2.Text = "Inserisci il nuovo pin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, 92);
            label3.Name = "label3";
            label3.Size = new Size(199, 15);
            label3.TabIndex = 14;
            label3.Text = "Inserisci il pin per aprire la cassaforte";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(522, 300);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 15;
            label4.Text = "cassaforte";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 475);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Cassaforte);
            Controls.Add(BottoneCodice);
            Controls.Add(BottoneChiudi);
            Controls.Add(BottoneApri);
            Controls.Add(BottonePin);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
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
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Button BottonePin;
        private Button BottoneApri;
        private Button BottoneChiudi;
        private Button BottoneCodice;
        private Button Cassaforte;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
