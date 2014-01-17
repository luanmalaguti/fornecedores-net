using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Util;

namespace Model.POCO
{
    [Table("Usuario")]
    public partial class Usuario
    {
        [Key]
        public int Id { get; set; }
         
        [Required(ErrorMessage = "Informe o Login")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Informe a Senha")]
        public string Password { get; set; }

        public Boolean Admin { get; set; }

        public Fornecedor Fornecedor { get; set; }
    }
}
