using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class conexao
    {
        private SqlConnection conexao1 = new SqlConnection("User ID = DESKTOP-FQM5N44; Initial Catalog =  TCM_clinica; Data Source = (local); Password = ");


        public SqlConnection getConexao
        {
            get { return this.conexao1; }

        }

        //  public SqlConnection getConexao { get => conexao; }

        public void abrirConexao()
        {
            if (this.conexao1.State == ConnectionState.Closed)
            {
                this.conexao1.Open();
            }

        }

        public void fecharConexao()
        {
            if (this.conexao1.State == ConnectionState.Closed)
            {
                this.conexao1.Close();
            }
        }

        public bool testarConexao()
         {
             if (this.conexao1 != null && conexao1.State != ConnectionState.Closed)
                 return false;
             else
                 return true;

         }

    }
}

