using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Model
{
    [Table("Fornecedor")]
    public class Fornecedor
    {
        public Fornecedor()
        {
            this.Produtos = new List<Produto>();
            this.Pedidos = new List<Pedido>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }

        [InverseProperty("Fornecedores")]
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
