using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.abrir_fechar_menus
{
    public class AbrirPagamento
    {
        public AbrirPagamento()
        {

        }

        public void AbrirCadPagamento(Form cadpag)
        {
            telaPagamento abrirPag = new telaPagamento();
            abrirPag.Show();
            cadpag.Hide();
        }
    }
}