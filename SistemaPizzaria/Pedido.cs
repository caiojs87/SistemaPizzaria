using System;
using System.Windows.Forms;

namespace SistemaPizzaria
{
    public partial class Pedido : Form

    
    
    {

        //Instanciando a classe de conexão

        Conexao con = new Conexao();
       
        public Pedido()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //hugo homossexual



        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            cmbTamanhoPizza.Items.Add("Pequena- R$ 20,00");
            cmbTamanhoPizza.Items.Add("Média- R$ 30,00");
            cmbTamanhoPizza.Items.Add("Grande- R$ 50,00");

        }
    }
}
