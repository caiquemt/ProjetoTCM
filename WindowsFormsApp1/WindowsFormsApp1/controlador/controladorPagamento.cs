using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.dominio;
using WindowsFormsApp1.repositorio;

namespace WindowsFormsApp1.controlador
{
    class controladorPagamento
    {
        repositorioPagamento repositorioPagamento = new repositorioPagamento();

        public controladorPagamento() { }

        public void inserirPagamento(Pagamento Pagamento)
        {
            repositorioPagamento.salvarPagamento(Pagamento);
            MessageBox.Show("Pagamento cadastrado com sucesso!");
        }

        public void alterarPagamento(Pagamento Pagamento)
        {
            repositorioPagamento.upgradePagamento(Pagamento);
            MessageBox.Show("Alteração concluída com sucesso!");
        }

        public void apagarPagamento(Pagamento Pagamento)
        {
            repositorioPagamento.deletePagamento(Pagamento);
            MessageBox.Show("Pagamento excluído com sucesso!");
        }

    }
}
