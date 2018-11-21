using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.dominio
{
    class Estoque
    {
        private String nome_prod;
        private int qtd_prod;
        private DateTime val_prod;

        public string Nome_prod { get => nome_prod; set => nome_prod = value; }
        public int Qtd_prod { get => qtd_prod; set => qtd_prod = value; }
        public DateTime Val_prod { get => val_prod; set => val_prod = value; }

        public override string ToString()
        {
            return String.Concat(Nome_prod, Qtd_prod, Val_prod);
        }

        public void exibirCadPRod()
        {
            this.Nome_prod = "";
            MessageBox.Show(this.ToString());
        }
    }
}
