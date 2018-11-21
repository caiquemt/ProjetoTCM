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
    class controladorExame
    {
        repositorioExame repositorioExame = new repositorioExame();

        public controladorExame() { }

        public void inserirExame(Exame Exame)
        {
            repositorioExame.salvarExame(Exame);
            MessageBox.Show("Exame cadastrado com sucesso!");
        }

        public void alterarExame(Exame Exame)
        {
            repositorioExame.upgradeExame(Exame);
            MessageBox.Show("Alteração concluída com sucesso!");
        }

        public void apagarExame(Exame Exame)
        {
            repositorioExame.deleteExame(Exame);
            MessageBox.Show("Exame excluído com sucesso!");
        }

    }
}
