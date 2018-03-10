using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PrimeiraAula.Modelo;

namespace PrimeiraAula
{
    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void btnSomar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle(txbPrimeiroNumero.Text, txbSegundoNumero.Text, "+");
            lblResultado.Text = controle.Resposta;
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        
       
    }
}
