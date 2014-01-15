
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("Produto")]
    public class Produto
    {
        public Produto()
        {
            this.Fornecedores = new List<Fornecedor>();
            this.ItemsPedido = new List<ItemPedido>();
        }

        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Descricao { get; set; }

        [Required]
        public double Preco { get; set; }

        [InverseProperty("Produtos")]
        public virtual ICollection<Fornecedor> Fornecedores { get; set; }

        public virtual ICollection<ItemPedido> ItemsPedido { get; set; }
    }
}
