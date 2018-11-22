using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.abrir_fechar_menus
{
    public class AbrirMedico
    {
        public AbrirMedico()
        {

        }

        public void AbrirCadMedico(Form cadmed)
        {
            telaMédico abrirMed = new telaMédico();
            abrirMed.Show();
            cadmed.Hide();
        }
    }
}
