using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.abrir_fechar_menus
{
    public class AbrirAgenda
    {
        public AbrirAgenda()
        {

        }

        public void AbrirCadAgenda(Form cadagen)
        {
            barraInferior abrirAgen = new barraInferior();
            abrirAgen.Show();
            cadagen.Hide();
        }
    }
}