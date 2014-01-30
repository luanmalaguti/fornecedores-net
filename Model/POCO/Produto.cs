
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Model.POCO;

namespace Model
{
    [Table("Produto")]
    public class Produto
    {
        public Produto()
        {
            this.FornecedorProduto = new List<FornecedorProduto>();
            this.ItemsPedido = new List<ItemPedido>();
        }

        [Key]
        public int Id { get; set; }
        
       [Required(ErrorMessage = "Informe a Descrição do Produto")]
        public string Descricao { get; set; }

        public int Tamanho { get; set; }

        public string UnidadeMedida { get; set; }

        [NotMapped]
        public double valor { get; set; }

        [NotMapped]
        public int quantidade { get; set; }

        public virtual ICollection<FornecedorProduto> FornecedorProduto { get; set; }

        public virtual ICollection<ItemPedido> ItemsPedido { get; set; }

        

    }
}
