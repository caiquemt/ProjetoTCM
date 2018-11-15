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
    class controladorFuncionario
    {
        repositorioFuncionario repositoriofuncionario = new repositorioFuncionario();

        public controladorFuncionario() { }

        public void inserirFuncionario(Funcionario funcionario)
        {
            repositoriofuncionario.salvarFuncionario(funcionario);
            MessageBox.Show("Funcionario cadastrado com sucesso!");
        }

        public void alterarFuncionario(Funcionario funcionario)
        {
            repositoriofuncionario.upgradeFuncionario(funcionario);
            MessageBox.Show("Alteração concluída com sucesso!");
        }

        public void apagarFuncionario(Funcionario funcionario)
        {
            repositoriofuncionario.deleteFuncionario(funcionario);
            MessageBox.Show("Funcionario excluído com sucesso!");
        }
        
    }
}
