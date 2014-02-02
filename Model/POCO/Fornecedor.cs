
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Model.POCO;

namespace Model
{
    [Table("Fornecedor")]
    public partial class Fornecedor
    {
        public Fornecedor()
        {
            this.FornecedorProduto = new List<FornecedorProduto>();
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

        public virtual ICollection<FornecedorProduto> FornecedorProduto { get; set; }

        public override string ToString()
        {
            return this.RazaoSocial + " - " + this.Cnpj;
        }

    }
}
