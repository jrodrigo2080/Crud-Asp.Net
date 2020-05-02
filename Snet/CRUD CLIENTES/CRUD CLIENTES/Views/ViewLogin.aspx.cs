using CRUD_CLIENTES.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD_CLIENTES.Views
{
    public partial class ViewLogin : System.Web.UI.Page
    {

        DAOConexao conexao = new DAOConexao();
        protected void Page_Load(object sender, EventArgs e)
        {
            


        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtSenha.Text == "")
            {
                lbConexao.Text = "Informações não encontrada";
                txtSenha.Text = null;
                txtEmail.Focus();
            }
            else
            {
                fazerLogin();
            }
        }

        public void fazerLogin()
        {
            conexao.Conectar();
            try
            {
                var sql = "select * from tbusuario where email=@email and senha =@senha";
                
                var comando = new SQLiteCommand(sql,conexao.conexao);

                

                comando.Parameters.AddWithValue("@email",txtEmail.Text);
                comando.Parameters.AddWithValue("@senha", txtSenha.Text);

                SQLiteDataReader reader = comando.ExecuteReader();


                if(reader.HasRows )
                {
                    lbConexao.Text = "ok";
                    Server.Transfer("ViewCadastro.aspx");
                }
                else
                {
                    lbConexao.Text = "não encontrou";
                }




            }
            catch(Exception ex)
            {
                lbConexao.Text = "Erro: " + ex;
            }

        }


        public void logar()
        {
            try
            {

                conexao.Conectar();
                var sql = "select * from tbusuario where email= '"+txtEmail.Text+"' and senha = '"+txtSenha.Text+"'";

                


                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sql,conexao.conexao);//realiza a consulta no banco
                DataTable usuario = new DataTable();


                dataAdapter.Fill(usuario);

                if (usuario.Rows.Count <0)
                {
                    lbConexao.Text = "Usuario não encontrado";
                    txtEmail.Text = null;
                    txtSenha.Text = null;
                }
                else
                {
                    Server.Transfer("ViewCadastro.aspx");
                }


            }catch(Exception ex)
            {
                lbConexao.Text = "Erro ao conectar"+ex.Message.ToString();
            }
        }





    }
}
