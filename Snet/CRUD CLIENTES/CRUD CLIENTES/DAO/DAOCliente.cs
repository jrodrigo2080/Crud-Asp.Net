using CRUD_CLIENTES.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace CRUD_CLIENTES.DAO
{
    public class DAOCliente
    {
        DAOConexao conexao = new DAOConexao();
        SQLiteCommand comando;


        public void InserirCliente(ModelCliente cliente)
        {

            var sql = "insert into tbcliente(nome,telefone,endereco,bairro,numero,estado,pais,cep) values(@nome,@telefone,@endereco,@bairro,@numero,@estado,@pais,@cep)";
            conexao.Conectar();

            comando = new SQLiteCommand(sql, conexao.conexao);

            comando.Parameters.AddWithValue("@nome", cliente.nome);
            comando.Parameters.AddWithValue("@telefone", cliente.telefone);
            comando.Parameters.AddWithValue("@endereco", cliente.endereco);
            comando.Parameters.AddWithValue("@bairro", cliente.bairro);
            comando.Parameters.AddWithValue("@numero", cliente.numero);
            comando.Parameters.AddWithValue("@estado", cliente.estado);
            comando.Parameters.AddWithValue("@pais", cliente.pais);
            comando.Parameters.AddWithValue("@cep", cliente.cep);

            
            comando.ExecuteNonQuery();
        


        }
       

    }
}