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
        public bool tem = false;
        public String mensagem;
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        //bool retorna se a informação é verdadeira ou falsa
        public bool verificarLogin(String login, String senha)
        {
            //Comandos sql para verificar se tem no banco
            cmd.CommandText = "select * from logins where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();//Quando se pega informação do banco para ser guardada, todas info estão dentro do dr
                if(dr.HasRows)// Se tiver linha no banco de dados
                {
                    tem = true;
                }
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados";
            }

            return tem;

        }
        public String cadastrar(String email, String senha)
        {
            //comandos para inserir
            return mensagem;
        }
    }
}
