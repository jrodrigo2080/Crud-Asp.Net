using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;

namespace CRUD_CLIENTES.DAO
{
    public class DAOConexao
    {

        public SQLiteConnection conexao = new SQLiteConnection("Data Source=C:\\Snet\\DADOS\\DADOS.db");

        public void Conectar()
        {

            try
            {
                conexao.Open();
                ///resultado = "Conectado com o banco";
            }catch(Exception ex)
            {
                // resultado = "Erro ao conectar "+ex;
                
            }

        }

    }
}