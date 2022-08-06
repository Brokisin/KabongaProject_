using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication_C.Classes;

namespace WebApplication_C.Funcoes
{
    public class Funcoes
    {
        public void CadastrarUsuario(Usuario usuario)
        {
            string query = $"INSERT INTO Usuario(nome,login,senha,email) VALUES({usuario.Nome},{usuario.Login},{usuario.Senha},{usuario.Email})";

            if (BancoDeDados.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, BancoDeDados.conn);

                while (true)
                {

                }
            }
        }
    }
}