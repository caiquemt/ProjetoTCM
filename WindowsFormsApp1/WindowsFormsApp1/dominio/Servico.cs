using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.dominio
{
    class Servico
    {
        private String nome_pac;
        private String resp_serv;
        private int cpf_resp_serv;
        private String rg_resp_serv;
        private String nome_med;
        private DateTime data_cons;
        private DateTime data_serv;
        private String convenio_serv;
        private int numero_cart_serv;
        private String nome_car_serv;
        private String Email_resp_serv;

        public string Nome_pac { get => nome_pac; set => nome_pac = value; }
        public string Resp_serv { get => resp_serv; set => resp_serv = value; }
        public int Cpf_resp_serv { get => cpf_resp_serv; set => cpf_resp_serv = value; }
        public string Rg_resp_serv { get => rg_resp_serv; set => rg_resp_serv = value; }
        public string Nome_med { get => nome_med; set => nome_med = value; }
        public DateTime Data_cons { get => data_cons; set => data_cons = value; }
        public DateTime Data_serv { get => data_serv; set => data_serv = value; }
        public string Convenio_serv { get => convenio_serv; set => convenio_serv = value; }
        public int Numero_cart_serv { get => numero_cart_serv; set => numero_cart_serv = value; }
        public string Nome_car_serv { get => nome_car_serv; set => nome_car_serv = value; }
        public string Email_resp_serv1 { get => Email_resp_serv1; set => Email_resp_serv1 = value; }

        public override string ToString()
        {
            return String.Concat(Nome_pac, Resp_serv, Cpf_resp_serv, Rg_resp_serv, Nome_med, Data_cons, Data_serv, Convenio_serv, Numero_cart_serv, Nome_car_serv, Email_resp_serv1);
        }

        public void exibirCadServ()
        {
            this.Nome_pac = "";
            MessageBox.Show(this.ToString());
        }
    }
}
