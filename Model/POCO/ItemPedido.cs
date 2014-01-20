
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("Item_Pedido")]
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
