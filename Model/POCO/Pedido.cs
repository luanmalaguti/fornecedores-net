
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Model.Util;

namespace Model
{
    [Table("Pedido")]
    public class Pedido
    {
        public Pedido()
        {
            this.ItemsPedido = new List<ItemPedido>();
        }

        [Key]
        public int Id { get; set; }

        public string Descricao { get; set; }
        
        [Required(ErrorMessage = "Informe o Status do Pedido")]
        public StatusPedido Status { get; set; }

        public System.DateTime Prazo { get; set; }

        public System.DateTime Entrega { get; set; }

        public virtual ICollection<ItemPedido> ItemsPedido { get; set; }
    }
}
