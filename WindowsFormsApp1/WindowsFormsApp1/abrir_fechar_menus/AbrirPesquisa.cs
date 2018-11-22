using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.abrir_fechar_menus
{
    public class AbrirPesquisa
    {
        public AbrirPesquisa()
        {

        }

        public void AbrirCadPEsquisa(Form cadpesq)
        {
            telaMédico abrirEst = new telaMédico();
            abrirEst.Show();
            cadpesq.Hide();
        }
    }
}