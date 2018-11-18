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
    class controladorServico
    {
        repositorioServico repositorioServico = new repositorioServico();

        public controladorServico() { }

        public void inserirServico(Servico Servico)
        {
            repositorioServico.salvarServico(Servico);
            MessageBox.Show("Serviço cadastrado com sucesso!");
        }

        public void alterarServico(Servico Servico)
        {
            repositorioServico.upgradeServico(Servico);
            MessageBox.Show("Alteração concluída com sucesso!");
        }

        public void apagarServico(Servico Servico)
        {
            repositorioServico.deleteServico(Servico);
            MessageBox.Show("Serviço excluído com sucesso!");
        }

    }
}
