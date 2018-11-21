using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.dominio
{
    class Funcionario
    {
        private String nome_func;
        private String rua_func;
        private int num_rua_func;
        private String bairro_func;
        private String cidade_func;
        private String uf_func;
        private int dtNasc_func;
        private String cargo_func;
        private int hrexp_func;
        private int tel_func;
        private int cel_func;
        private String email_func;
        private int matricula_func;
        private String imagem_func;

        public string Nome_func { get => nome_func; set => nome_func = value; }
        public string Rua_func { get => rua_func; set => rua_func = value; }
        public int Num_rua_func { get => num_rua_func; set => num_rua_func = value; }
        public string Bairro_func { get => bairro_func; set => bairro_func = value; }
        public string Cidade_func { get => cidade_func; set => cidade_func = value; }
        public string Uf_func { get => uf_func; set => uf_func = value; }
        public int DtNasc_func { get => dtNasc_func; set => dtNasc_func = value; }
        public string Cargo_func { get => cargo_func; set => cargo_func = value; }
        public int Hrexp_func { get => hrexp_func; set => hrexp_func = value; }
        public int Tel_func { get => tel_func; set => tel_func = value; }
        public int Cel_func { get => cel_func; set => cel_func = value; }
        public string Email_func { get => email_func; set => email_func = value; }
        public int Matricula_func { get => matricula_func; set => matricula_func = value; }
        public string Imagem_func { get => imagem_func; set => imagem_func = value; }
        

        public override string ToString()
        {
            return String.Concat(Nome_func, DtNasc_func, Cargo_func, Hrexp_func, Tel_func, Cel_func, Email_func, Email_func, Cidade_func, Matricula_func, Imagem_func);
        }

        public void exibirValores()
        {
            this.Nome_func = "";
            MessageBox.Show(this.ToString());
        }
    }
}
