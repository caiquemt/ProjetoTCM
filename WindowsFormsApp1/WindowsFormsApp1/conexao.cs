using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class conexao
    {
        /*private SqlConnection conexao = new SqlConnection("User ID = DESKTOP-FQM5N44/gabs; Initial Catalog =  TCM_clinica; Data Source = (local); Password = ");


        public SqlConnection getConexao
        {
            get { return this.conexao; }

        }

        //  public SqlConnection getConexao { get => conexao; }

        public void abrirConexao()
        {
            if (this.conexao.State == ConnectionState.Closed)
            {
                this.conexao.Open();
            }

        }

        public void fecharConexao()
        {
            if (this.conexao.State == ConnectionState.Closed)
            {
                this.conexao.Close();
            }
        }

        /* public bool testarConexao()
         {
             if (this.conexao != null && conexao.State != ConnectionState.Closed)
                 return false;
             else
                 return true;

         }*/

    }
}

