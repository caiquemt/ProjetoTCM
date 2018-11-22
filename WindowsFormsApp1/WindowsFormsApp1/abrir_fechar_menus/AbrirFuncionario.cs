using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.abrir_fechar_menus
{
    public class AbrirFuncionario
    {
        public AbrirFuncionario()
        {

        }

        public void AbrirCadFuncionario(Form cadfunc)
        {
            telaCadastroDoFuncionario abrirfunc = new telaCadastroDoFuncionario();
            abrirfunc.Show();
            cadfunc.Hide();
        }
    }
}