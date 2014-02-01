using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace WebService.Models
{
    public class PedidoDB
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Descricao { get; set; }

        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public double Total { get; set; }

        [DataMember]
        public string Prazo { get; set; }

        [DataMember]
        public string Entrega { get; set; }
    }
}