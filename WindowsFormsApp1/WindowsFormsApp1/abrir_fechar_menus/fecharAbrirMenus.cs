using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class fecharAbrirMenus
    {
        public fecharAbrirMenus()
        {

        }


        public void FecharTela(Form form)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente fechar o programa? Podem haver alterações não salvar.", "Sair do sistema", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                form.Close();
            }
           
        }
    }
}
