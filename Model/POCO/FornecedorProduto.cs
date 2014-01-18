using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.POCO
{
    [Table("Fornecedor_Produto")]
    public class FornecedorProduto
    {
        [Key, Column(Order = 1, TypeName = "int")]
        [ForeignKey("Fornecedor")]
        public int FornecedorID { get; set; }
        public Fornecedor Fornecedor { get; set; }

        [Key, Column(Order = 2, TypeName = "int")]
        [ForeignKey("Produto")]
        public int ProdutoID { get; set; }
        public Produto Produto { get; set; }

        [Required]
        public double ValorUnitario { get; set; }
    }
}
