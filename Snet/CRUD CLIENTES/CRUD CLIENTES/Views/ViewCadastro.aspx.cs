using System;

namespace CRUD_CLIENTES.Views
{
    //api de busca
    using API_CEP;
    using CRUD_CLIENTES.DAO;
    using CRUD_CLIENTES.Model;
    using System.CodeDom;
    using System.Data;
    using System.Data.SQLite;
    using System.IO;

    public partial class WebForm1 : System.Web.UI.Page
    {
        DAOConexao conexao = new DAOConexao();
        ModelCliente cliente = new ModelCliente();
        DAOCliente daoCliente = new DAOCliente();

        protected void Page_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        public void ConsultaCEp(string cep)
        {
            using(var buscacep = new AtendeClienteClient() )
            {
                var resposta = buscacep.consultaCEP(cep);

                Console.Clear();

                Console.WriteLine(String.Format("Endereco : {0}"), resposta.end);
                Console.WriteLine(String.Format("bairro : {0}"), resposta.bairro);
                Console.WriteLine(String.Format("cidade : {0}"), resposta.cidade);
                Console.WriteLine(String.Format("estado : {0}"), resposta.uf);
                Console.WriteLine("");
                Console.WriteLine("Precione algo..............");
                Console.ReadKey();
            }
        }

        protected void Unnamed5_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtCep.Text))//verifica se o campo cep é diferente de vazio
            {
                
                    using (var cep = new API_CEP.AtendeClienteClient())
                    {
                    var endereco = cep.consultaCEP(txtCep.Text.Trim());
                    try
                    {
                        //aciona a consulta atraves do cep digitado, limpando todos espaços em branco que existir atraves do metodo TRIM()
                       
                        txtRua.Text = endereco.end;
                        txtestado.Text = endereco.uf;
                        txtBairro.Text = endereco.bairro;
                        txtcidade.Text = endereco.cidade;

                    }catch (IOException ex)
                {
                    lbErro.Text = "Cep não encontrado......";
                }
            }
               
            }
            else
            {
                lbErro.Text = "Cep não encontrado....."; 
            }

        }


        public void ListarClientes()
        {
            conexao.Conectar();

            var  sql = "select * from tbcliente order by nome asc";

            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter();

            DataTable dt = new DataTable();

            SQLiteCommand comando = new SQLiteCommand(sql, conexao.conexao);


            dataAdapter.SelectCommand = comando;

            dataAdapter.Fill(dt);

            tbCliente.DataSource = dt;

            tbCliente.DataBind();

        }

        protected void Cadastrar_Click(object sender, EventArgs e)
        {
            cliente.cep = txtCep.Text;
            cliente.cidade = txtcidade.Text;
            cliente.endereco = txtRua.Text;
            cliente.nome = txtNome.Text;
            cliente.numero = txtNumero.Text;
            cliente.pais = txtPais.Text;
            cliente.telefone = txtTelefone.Text;
            cliente.bairro = txtBairro.Text;

            daoCliente.InserirCliente(cliente);
            ListarClientes();

        }

        protected void tbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}