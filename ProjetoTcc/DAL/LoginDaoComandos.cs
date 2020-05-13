using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTcc.DAL
{
    class LoginDaoComandos
    {
        public bool tem;
        public String mensagem;
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();

        //bool retorna se a informação é verdadeira ou falsa
        public bool verificarLogin(String login, String senha)
        {
            //Comandos sql para verificar se tem no banco
            cmd.CommandText = "select * from nomeDaTabela where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                cmd.BeginExecuteReader();//Quando se pega informação do banco para ser guardada
            }
            catch (SqlException)
            {
                throw;
            }

            return tem;

        }
        public String cadastrar(String email, String senha, String)
        {
            //comandos para inserir
            return mensagem;
        }
    }
}
