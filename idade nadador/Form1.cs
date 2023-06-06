namespace idade_nadador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            int idadenadador;
            idadenadador = Convert.ToInt32(txtidadenadador.Text);
            if (idadenadador >= 5 && idadenadador <= 7)
            {
                txtresultado.Text = "Essa categoria é:  Infantil A";
            }
            else if (idadenadador >= 8 && idadenadador <= 11)
            {
                txtresultado.Text = "Essa categoria é:  Infantil B";
            }
            else if (idadenadador >= 12 && idadenadador <= 13)
            {
                txtresultado.Text = "Essa categoria é:  Juvenil A";
            }
            else if (idadenadador >= 14 && idadenadador <= 17)
            {
                txtresultado.Text = "Essa categoria é:  Juvenil B";
            }
            else if (idadenadador >= 18)
            {
                txtresultado.Text = "Essa categoria é:  Adulto";
            }
        }
    }
}





        
    
