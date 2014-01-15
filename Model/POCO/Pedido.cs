
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Required]
        public string Descricao { get; set; }

        public virtual ICollection<ItemPedido> ItemsPedido { get; set; }
    }
}
