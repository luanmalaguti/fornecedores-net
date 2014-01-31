using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebService.Models
{
    public class FornecedorDB
    {
        
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string RazaoSocial { get; set; }

        [DataMember]
        public string Cnpj { get; set; }

        [DataMember]
        public string Telefone { get; set; }

        [DataMember]
        public string Endereco { get; set; }

        [DataMember]
        public PedidoDB[] pedidos { get; set; }
    }
}