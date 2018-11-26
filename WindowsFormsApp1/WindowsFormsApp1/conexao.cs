using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        /*private void btnSalvarFunc_Click(object sender, EventArgs e)
        {
            string strcon = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Documents and Settings\\k\\Meus documentos\\Visual Studio 2005\\Projects\\conect_sql_server\\conect_sql_server\\banco_dados.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            SqlConnection conexao = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("INSERT INTO tabela(nome,numero) VALUES('" + textBox1.Text + "'," + textBox2.Text.Replace(",", ".") + ")", conexao);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                btnSalvarFunc_Click(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }*/

    }
}

