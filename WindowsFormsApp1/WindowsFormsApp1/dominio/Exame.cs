using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.dominio
{
    class Exame
    {
        private String nome_exame;
        private DateTime data_exame;
        private String nome_pac;
        private String imagem_exame;

        public string Nome_exame { get => nome_exame; set => nome_exame = value; }
        public DateTime Data_exame { get => data_exame; set => data_exame = value; }
        public string Nome_pac { get => nome_pac; set => nome_pac = value; }
        public string Imagem_exame { get => imagem_exame; set => imagem_exame = value; }

        public override string ToString()
        {
            return String.Concat(Nome_exame, Data_exame, Nome_pac, Imagem_exame);
        }

        public void exibirCadExame()
        {
            this.Nome_exame = "";
            MessageBox.Show(this.ToString());
        }
    }
}
