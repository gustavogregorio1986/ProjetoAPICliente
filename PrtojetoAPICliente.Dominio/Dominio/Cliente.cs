using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAPICliente.Dominio.Dominio
{
    [Table("tb_Cliente")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCliente { get; set; }

        public string NomeCliente { get; set; }

        public string EmailCliente { get; set; }

        public string Cpf { get; set; }
    }
}
