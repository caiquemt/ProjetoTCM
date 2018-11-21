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
    class controladorConsulta
    {
        repositorioConsulta repositorioConsulta = new repositorioConsulta();

        public controladorConsulta() { }

        public void inserirConsulta(Consulta Consulta)
        {
            repositorioConsulta.salvarConsulta(Consulta);
            MessageBox.Show("Consulta cadastrada com sucesso!");
        }

        public void alterarConsulta(Consulta Consulta)
        {
            repositorioConsulta.upgradeConsulta(Consulta);
            MessageBox.Show("Alteração concluída com sucesso!");
        }

        public void apagarConsulta(Consulta Consulta)
        {
            repositorioConsulta.deleteConsulta(Consulta);
            MessageBox.Show("Consulta excluída com sucesso!");
        }

    }
}
