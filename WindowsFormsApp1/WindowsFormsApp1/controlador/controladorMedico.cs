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
    class controladorMedico
    {
        repositorioMedico repositorioMedico = new repositorioMedico();

        public controladorMedico() { }

        public void inserirMedico(Medico Medico)
        {
            repositorioMedico.salvarMedico(Medico);
            MessageBox.Show("Médico cadastrado com sucesso!");
        }

        public void alterarMedico(Medico Medico)
        {
            repositorioMedico.upgradeMedico(Medico);
            MessageBox.Show("Alteração concluída com sucesso!");
        }

        public void apagarMedico(Medico Medico)
        {
            repositorioMedico.deleteMedico(Medico);
            MessageBox.Show("Médico excluído com sucesso!");
        }

    }
}
