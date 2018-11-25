using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.abrir_fechar_menus
{
    public class AbrirPaciente
    {
        public AbrirPaciente()
        {

        }

        public void AbrirCadPaciente(Form cadpac)
        {
            btnSalvarFunc abrir = new btnSalvarFunc();
            abrir.Show();
            cadpac.Hide();
        }
    }
}
