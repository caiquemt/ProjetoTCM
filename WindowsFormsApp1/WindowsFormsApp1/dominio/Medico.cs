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
        private String nome_medico;
        private DateTime nasc_medico;
        private int idade_medico;
        private String rg_medico;
        private int cpf_medico;
        private String especilidade_medico;
        private int crm_medico;
        private String rua_medico;
        private int numRua_medico;
        private String complemento_medico;
        private int cep_medico;
        private String naturalidade_medico;
        private String uf_medico;
        private String cidade_medico;
        private int telefone_medico;
        private int celular_medico;
        private String convenio_medico;
        private int matricula_medico;
        private DateTime horario_medico;
        private String dias_medico;
        private String imagem_medico;

        public string Nome_medico { get => nome_medico; set => nome_medico = value; }
        public DateTime Nasc_medico { get => nasc_medico; set => nasc_medico = value; }
        public int Idade_medico { get => idade_medico; set => idade_medico = value; }
        public string Rg_medico { get => rg_medico; set => rg_medico = value; }
        public int Cpf_medico { get => cpf_medico; set => cpf_medico = value; }
        public string Especilidade_medico { get => especilidade_medico; set => especilidade_medico = value; }
        public int Crm_medico { get => crm_medico; set => crm_medico = value; }
        public string Rua_medico { get => rua_medico; set => rua_medico = value; }
        public int NumRua_medico { get => numRua_medico; set => numRua_medico = value; }
        public string Complemento_medico { get => complemento_medico; set => complemento_medico = value; }
        public int Cep_medico { get => cep_medico; set => cep_medico = value; }
        public string Naturalidade_medico { get => naturalidade_medico; set => naturalidade_medico = value; }
        public string Uf_medico { get => uf_medico; set => uf_medico = value; }
        public string Cidade_medico { get => cidade_medico; set => cidade_medico = value; }
        public int Telefone_medico { get => telefone_medico; set => telefone_medico = value; }
        public int Celular_medico { get => celular_medico; set => celular_medico = value; }
        public string Convenio_medico { get => convenio_medico; set => convenio_medico = value; }
        public int Matricula_medico { get => matricula_medico; set => matricula_medico = value; }
        public DateTime Horario_medico { get => horario_medico; set => horario_medico = value; }
        public string Dias_medico { get => dias_medico; set => dias_medico = value; }
        public string Imagem_medico { get => imagem_medico; set => imagem_medico = value; }

        public override string ToString()
        {
            return String.Concat(Nome_medico, Nasc_medico, Rg_medico, Cpf_medico, Especilidade_medico, Crm_medico, Rua_medico, NumRua_medico, Complemento_medico,
                                 Cep_medico, Naturalidade_medico, Uf_medico, Cidade_medico, Telefone_medico, Celular_medico, Convenio_medico, Matricula_medico,
                                 Horario_medico, Dias_medico, Imagem_medico);
        }

        public void exibirMedico()
        {
            this.Nome_medico = "";
            MessageBox.Show(this.ToString());
        }
    }
}
