// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodVisao", "CodObjeto", "CodItem", "CodFaixa")]
public partial class MvtStatsDashObjetoItemFaixa
{
    [Key]
    [Column("codVisao")]
    public int CodVisao { get; set; }

    [Key]
    [Column("codObjeto")]
    public int CodObjeto { get; set; }

    [Key]
    [Column("codItem")]
    public int CodItem { get; set; }

    [Key]
    [Column("codFaixa")]
    public int CodFaixa { get; set; }

    [Required]
    [Column("nome")]
    [StringLength(100)]
    [Unicode(false)]
    public string Nome { get; set; }

    [Column("valorDe")]
    public double ValorDe { get; set; }

    [Column("valorAte")]
    public double ValorAte { get; set; }

    [Required]
    [Column("corFundo")]
    [StringLength(50)]
    [Unicode(false)]
    public string CorFundo { get; set; }
}