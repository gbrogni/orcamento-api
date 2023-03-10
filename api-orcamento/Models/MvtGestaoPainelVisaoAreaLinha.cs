// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodVisao", "CodSlide", "CodArea", "CodLinha")]
public partial class MvtGestaoPainelVisaoAreaLinha
{
    [Key]
    [Column("codVisao")]
    public int CodVisao { get; set; }

    [Key]
    [Column("codSlide")]
    public int CodSlide { get; set; }

    [Key]
    [Column("codArea")]
    public int CodArea { get; set; }

    [Key]
    [Column("codLinha")]
    public int CodLinha { get; set; }

    [Column("tipo")]
    [StringLength(50)]
    [Unicode(false)]
    public string Tipo { get; set; }

    [Column("altura")]
    public int? Altura { get; set; }
}