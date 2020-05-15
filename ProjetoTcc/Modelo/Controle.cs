using ProjetoTcc.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTcc.Modelo
{
    public class Controle
    { 
        //Metodos para acesso e cadastro
        public bool tem;
        public String mensagem="";
        public bool acessar(String login, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();//instancia da classe login
            tem = loginDao.verificarLogin(login, senha);//metodo para verificar se foi encontrado
            if(!string.IsNullOrEmpty(loginDao.mensagem))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }
        
        public String cadastrar(String email, String senha, String confSenha)
        {
            return mensagem;
        }
    }
}
