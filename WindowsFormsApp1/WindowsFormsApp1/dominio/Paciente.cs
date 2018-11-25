using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.dominio
{
    class Paciente
    {
        private String nome_pac;
        private int nasc_pac;
        private int idade_pac;
        private String rg_pac;
        private int cpf_pac;
        private String etnia_pac;
        private String sexo_pac;
        private int prontuario_pac;
        private String convenio_pac;
        private int matricula_pac;
        private String rua_pac;
        private String bairro_pac;
        private int numero_rua_pac;
        private String complemento_pac;
        private int cep_pac;
        private String naturalidade_pac;
        private String uf_pac;
        private String cidade_pac;
        private int telefone_pac;
        private int celular_pac;
        private String email_pac;
        private String mae_pac;
        private String pai_pac;
        private String responsavel_pac;
        private String imagem_pac;

        public string Nome_pac { get => nome_pac; set => nome_pac = value; }
        public int Nasc_pac { get => nasc_pac; set => nasc_pac = value; }
        public int Idade_pac { get => idade_pac; set => idade_pac = value; }
        public string Rg_pac { get => rg_pac; set => rg_pac = value; }
        public int Cpf_pac { get => cpf_pac; set => cpf_pac = value; }
        public string Etnia_pac { get => etnia_pac; set => etnia_pac = value; }
        public string Sexo_pac { get => sexo_pac; set => sexo_pac = value; }
        public int Prontuario_pac { get => prontuario_pac; set => prontuario_pac = value; }
        public string Convenio_pac { get => convenio_pac; set => convenio_pac = value; }
        public int Matricula_pac { get => matricula_pac; set => matricula_pac = value; }
        public string Rua_pac { get => rua_pac; set => rua_pac = value; }
        public string Bairro_pac { get => bairro_pac; set => bairro_pac = value; }
        public int Numero_rua_pac { get => numero_rua_pac; set => numero_rua_pac = value; }
        public string Complemento_pac { get => complemento_pac; set => complemento_pac = value; }
        public int Cep_pac { get => cep_pac; set => cep_pac = value; }
        public string Naturalidade_pac { get => naturalidade_pac; set => naturalidade_pac = value; }
        public string Uf_pac { get => uf_pac; set => uf_pac = value; }
        public string Cidade_pac { get => cidade_pac; set => cidade_pac = value; }
        public int Telefone_pac { get => telefone_pac; set => telefone_pac = value; }
        public int Celular_pac { get => celular_pac; set => celular_pac = value; }
        public string Email_pac { get => email_pac; set => email_pac = value; }
        public string Mae_pac { get => mae_pac; set => mae_pac = value; }
        public string Pai_pac { get => pai_pac; set => pai_pac = value; }
        public string Responsavel_pac { get => responsavel_pac; set => responsavel_pac = value; }
        public string Imagem_pac { get => imagem_pac; set => imagem_pac = value; }

        public override string ToString()
        {
            return String.Concat(Nome_pac, Nasc_pac, Idade_pac, Rg_pac, Cpf_pac, Etnia_pac, Sexo_pac, Prontuario_pac, Convenio_pac, Matricula_pac, Rua_pac, Bairro_pac, Numero_rua_pac,
                                 Complemento_pac, Cep_pac, Naturalidade_pac, Uf_pac, Cidade_pac, Email_pac, Mae_pac, Pai_pac, Responsavel_pac, Imagem_pac);
        }

        public void ExibirCadPac()
        {
            this.Nome_pac = "";
            MessageBox.Show(this.ToString());
        }
    }
}
