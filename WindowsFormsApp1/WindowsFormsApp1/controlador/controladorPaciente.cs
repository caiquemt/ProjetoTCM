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
    class controladorPaciente
    {
        repositorioPaciente repositorioPaciente = new repositorioPaciente();

        public controladorPaciente() { }

        public void inserirPaciente(Paciente Paciente)
        {
            repositorioPaciente.salvarPaciente(Paciente);
            MessageBox.Show("Paciente cadastrado com sucesso!");
        }

        public void alterarPaciente(Paciente Paciente)
        {
            repositorioPaciente.upgradePaciente(Paciente);
            MessageBox.Show("Alteração concluída com sucesso!");
        }

        public void apagarPaciente(Paciente Paciente)
        {
            repositorioPaciente.deletePaciente(Paciente);
            MessageBox.Show("Paciente excluído com sucesso!");
        }

    }
}
