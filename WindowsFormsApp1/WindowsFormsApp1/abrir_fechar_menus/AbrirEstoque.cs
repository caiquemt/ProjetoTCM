using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.abrir_fechar_menus
{
    public class AbrirEstoque
    {
        public AbrirEstoque()
        {

        }

        public void AbrirCadEstoque(Form cadest)
        {
            telaEstoque abrirEst = new telaEstoque();
            abrirEst.Show();
            cadest.Hide();
        }
    }
}