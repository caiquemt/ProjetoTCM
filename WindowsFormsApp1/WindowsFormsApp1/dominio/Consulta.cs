using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.dominio
{
    class Consulta
    {
        private String nome_pac;
        private String nome_med;
        private String especilidade_med;
        private int crm_med;
        private DateTime data_cons;
        private DateTime hora_cons;
        private String dia_cons;

        public string Nome_pac { get => nome_pac; set => nome_pac = value; }
        public string Nome_med { get => nome_med; set => nome_med = value; }
        public string Especilidade_med { get => especilidade_med; set => especilidade_med = value; }
        public int Crm_med { get => crm_med; set => crm_med = value; }
        public DateTime Data_cons { get => data_cons; set => data_cons = value; }
        public DateTime Hora_cons { get => hora_cons; set => hora_cons = value; }
        public string Dia_cons { get => dia_cons; set => dia_cons = value; }

        public override string ToString()
        {
            return String.Concat(Nome_pac, Nome_med, Especilidade_med, Crm_med, Data_cons, Hora_cons, Dia_cons);
        }

        public void exibirCadCons()
        {
            this.Nome_pac = "";
            MessageBox.Show(this.ToString());
        }
    }
}
