using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.abrir_fechar_menus
{
    public class AbrirProntuario
    {
        public AbrirProntuario()
        {

        }

        public void AbrirCadProntuario(Form cadpront)
        {
            telaExame abrirPront = new telaExame();
            abrirPront.Show();
            cadpront.Hide();
        }
    }
}