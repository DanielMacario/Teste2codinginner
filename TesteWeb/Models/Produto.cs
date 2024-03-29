﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteWeb.Models
{
    [Table("Produto")]

    public class Produto
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Column("Senha")]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [Column("Status")]
        [Display(Name = "Status")]
        public int Status { get; set; }
    }
}
