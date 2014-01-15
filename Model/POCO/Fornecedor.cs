
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("Fornecedor")]
    public partial class Fornecedor
    {
        public Fornecedor()
        {
            this.Produtos = new List<Produto>();
            this.Pedidos = new List<Pedido>();
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o Nome")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "Informe o Nome")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "Informe o Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Informe o Endereco")]
        public string Endereco { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }

        [InverseProperty("Fornecedores")]
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
