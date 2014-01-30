
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Model.Util;
using System.Runtime.Serialization;

namespace Model
{
    [Table("Pedido")]
    public class Pedido
    {
        public Pedido()
        {
            this.ItemsPedido = new List<ItemPedido>();
        }

        [DataMember]
        [Key]
        public int Id { get; set; }

        [DataMember]
        public string Descricao { get; set; }
        
        [Required(ErrorMessage = "Informe o Status do Pedido")]
        public StatusPedido Status { get; set; }

        [DataMember]
        public double Total { get; set; }

        [DataMember]
        public System.DateTime Prazo { get; set; }

        [DataMember]
        public System.DateTime Entrega { get; set; }

        public virtual ICollection<ItemPedido> ItemsPedido { get; set; }
    }
}
