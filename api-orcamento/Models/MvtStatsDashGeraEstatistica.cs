// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

public partial class MvtStatsDashGeraEstatistica
{
    [Key]
    [Column("codigo")]
    public int Codigo { get; set; }

    [Column("marcado")]
    public int Marcado { get; set; }

    [Required]
    [Column("nome")]
    [StringLength(100)]
    [Unicode(false)]
    public string Nome { get; set; }

    [Column("ordem")]
    public int Ordem { get; set; }
}