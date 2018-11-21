using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.dominio
{
    class Pagamento
    {
        private int codigo_serv;
        private int matricula_pac;
        private String forma_pag;
        private String cartao_pag;
        private String qtd_parcelas_pag;
        private Decimal valor_pag;

        public int Codigo_serv { get => codigo_serv; set => codigo_serv = value; }
        public int Matricula_pac { get => matricula_pac; set => matricula_pac = value; }
        public string Forma_pag { get => forma_pag; set => forma_pag = value; }
        public string Cartao_pag { get => cartao_pag; set => cartao_pag = value; }
        public string Qtd_parcelas_pag { get => qtd_parcelas_pag; set => qtd_parcelas_pag = value; }
        public decimal Valor_pag { get => valor_pag; set => valor_pag = value; }

        public override string ToString()
        {
            return String.Concat(Codigo_serv, Matricula_pac, Forma_pag, Cartao_pag, Qtd_parcelas_pag, Valor_pag);
        }

        public void exibirCadPag()
        {
             
            MessageBox.Show(this.ToString());
        }
    }
}
