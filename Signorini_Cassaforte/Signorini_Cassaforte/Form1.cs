namespace Signorini_Cassaforte
{
    public partial class Form1 : Form
    {
        private Cassaforte c1;
        public Form1()
        {
            InitializeComponent();
            c1 = new Cassaforte("345634", "Cassa s.r.l.", "A67", "567765234432");
        }
        private void BottonePin_Click(object sender, EventArgs e)
        {
            c1.Codice(Convert.ToString(numericUpDown3.Value));
        }
        private void BottoneApri_Click(object sender, EventArgs e)
        {
            c1.Apri(Convert.ToString(numericUpDown1.Value));
            
        }

        private void BottoneCodice_Click(object sender, EventArgs e)
        {
            c1.Sblocca(Convert.ToString(numericUpDown2.Value));
            
        }

        private void BottoneChiudi_Click(object sender, EventArgs e)
        {
            c1.Chiudi();
            
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        
    }
}
