using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTcc.DAL
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection(); 
        public Conexao()//Metodo construtor
        {
            con.ConnectionString = @"";//recebe o endereço do banco

        }
        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)//Se a conexao estiver closed então posso abrir
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {
            //Se a conexao estiver closed então posso abrir
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Close();
            }
            
        }

    }
}
