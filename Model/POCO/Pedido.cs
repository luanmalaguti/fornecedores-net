
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
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
        public String Descricao { get; set; }

        public virtual ICollection<ItemPedido> ItemsPedido { get; set; }
    }
}
