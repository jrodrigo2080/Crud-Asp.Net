using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_CLIENTES.Model
{
    public class ModelUsuario
    {
        int id;

        string nome, email, senha;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}