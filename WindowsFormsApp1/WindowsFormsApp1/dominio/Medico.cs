using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.dominio
{
    class Medico
    {
        private String nome_Medico;
        private DateTime nasc_Medico;
        private int idade_Medico;
        private String rg_Medico;
        private int cpf_Medico;
        private String especilidade_Medico;
        private int crm_Medico;
        private String rua_Medico;
        private int numRua_Medico;
        private String complemento_Medico;
        private int cep_Medico;
        private String naturalidade_Medico;
        private String uf_Medico;
        private String cidade_Medico;
        private int telefone_Medico;
        private int celular_Medico;
        private String convenio_Medico;
        private int matricula_Medico;
        private DateTime horario_Medico;
        private String dias_Medico;
        private String imagem_Medico;

        public string Nome_Medico { get => nome_Medico; set => nome_Medico = value; }
        public DateTime Nasc_Medico { get => nasc_Medico; set => nasc_Medico = value; }
        public int Idade_Medico { get => idade_Medico; set => idade_Medico = value; }
        public string Rg_Medico { get => rg_Medico; set => rg_Medico = value; }
        public int Cpf_Medico { get => cpf_Medico; set => cpf_Medico = value; }
        public string Especilidade_Medico { get => especilidade_Medico; set => especilidade_Medico = value; }
        public int Crm_Medico { get => crm_Medico; set => crm_Medico = value; }
        public string Rua_Medico { get => rua_Medico; set => rua_Medico = value; }
        public int NumRua_Medico { get => numRua_Medico; set => numRua_Medico = value; }
        public string Complemento_Medico { get => complemento_Medico; set => complemento_Medico = value; }
        public int Cep_Medico { get => cep_Medico; set => cep_Medico = value; }
        public string Naturalidade_Medico { get => naturalidade_Medico; set => naturalidade_Medico = value; }
        public string Uf_Medico { get => uf_Medico; set => uf_Medico = value; }
        public string Cidade_Medico { get => cidade_Medico; set => cidade_Medico = value; }
        public int Telefone_Medico { get => telefone_Medico; set => telefone_Medico = value; }
        public int Celular_Medico { get => celular_Medico; set => celular_Medico = value; }
        public string Convenio_Medico { get => convenio_Medico; set => convenio_Medico = value; }
        public int Matricula_Medico { get => matricula_Medico; set => matricula_Medico = value; }
        public DateTime Horario_Medico { get => horario_Medico; set => horario_Medico = value; }
        public string Dias_Medico { get => dias_Medico; set => dias_Medico = value; }
        public string Imagem_Medico { get => imagem_Medico; set => imagem_Medico = value; }

        public override string ToString()
        {
            return String.Concat(Nome_Medico, Nasc_Medico, Rg_Medico, Cpf_Medico, Especilidade_Medico, Crm_Medico, Rua_Medico, NumRua_Medico, Complemento_Medico,
                                 Cep_Medico, Naturalidade_Medico, Uf_Medico, Cidade_Medico, Telefone_Medico, Celular_Medico, Convenio_Medico, Matricula_Medico,
                                 Horario_Medico, Dias_Medico, Imagem_Medico);
        }

        public void exibirMedico()
        {
            this.Nome_Medico = "";
            MessageBox.Show(this.ToString());
        }
    }
}
