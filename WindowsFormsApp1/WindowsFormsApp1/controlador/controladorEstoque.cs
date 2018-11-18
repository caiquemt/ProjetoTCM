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
    class controladorEstoque
    {
        repositorioEstoque repositorioEstoque = new repositorioEstoque();

        public controladorEstoque() { }

        public void inserirEstoque(Estoque Estoque)
        {
            repositorioEstoque.salvarEstoque(Estoque);
            MessageBox.Show("Estoque cadastrado com sucesso!");
        }

        public void alterarEstoque(Estoque Estoque)
        {
            repositorioEstoque.upgradeEstoque(Estoque);
            MessageBox.Show("Alteração concluída com sucesso!");
        }

        public void apagarEstoque(Estoque Estoque)
        {
            repositorioEstoque.deleteEstoque(Estoque);
            MessageBox.Show("Estoque excluído com sucesso!");
        }

    }
}
