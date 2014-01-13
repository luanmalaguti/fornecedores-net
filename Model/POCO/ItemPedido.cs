using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Model
{
    [Table("ItemPedido")]
    public class ItemPedido
    {
        [Key, Column(Order = 1, TypeName = "int")]
        [ForeignKey("Pedido")]
        public int PedidoID { get; set; }
        public Pedido Pedido { get; set; }

        [Key, Column(Order = 2, TypeName = "int")]
        [ForeignKey("Produto")]
        public int ProdutoID { get; set; }
        public Produto Produto { get; set; }
        
        [Required]
        public int quantidade { get; set; }

    }
}
