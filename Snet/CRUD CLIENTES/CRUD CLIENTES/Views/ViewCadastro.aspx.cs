using System;

namespace CRUD_CLIENTES.Views
{
    //api de busca
    using API_CEP;
    using System.IO;

    public partial class WebForm1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
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
    }
}