using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.abrir_fechar_menus
{
    public class AbrirServico
    {
        public AbrirServico()
        {

        }

        public void AbrirCadServico(Form cadserv)
        {
            telaServiço abrirServ = new telaServiço();
            abrirServ.Show();
            cadserv.Hide();
        }
    }
}