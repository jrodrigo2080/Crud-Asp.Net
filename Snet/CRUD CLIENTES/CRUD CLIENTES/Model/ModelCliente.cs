using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_CLIENTES.Model
{
    public class ModelCliente
    {

        public int id { get; set; }

        public string nome { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
        public string numero { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string pais { get; set; }
        public string cep { get; set; }
        public string bairro { get; set; }
    }
}