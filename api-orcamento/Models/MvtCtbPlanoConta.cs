// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodPlano", "CodContaContabil")]
public partial class MvtCtbPlanoConta
{
    [Key]
    [Column("codPlano")]
    public int CodPlano { get; set; }

    [Key]
    [Column("codContaContabil")]
    public long CodContaContabil { get; set; }

    [Column("nomeContaContabil")]
    [StringLength(250)]
    [Unicode(false)]
    public string NomeContaContabil { get; set; }

    [Column("classe")]
    public int? Classe { get; set; }

    [Column("res")]
    [StringLength(15)]
    [Unicode(false)]
    public string Res { get; set; }

    [Column("digito")]
    public int? Digito { get; set; }

    [Column("contaPai")]
    public long? ContaPai { get; set; }

    [Column("codContaNivel1")]
    public long? CodContaNivel1 { get; set; }

    [Column("codContaNivel2")]
    public long? CodContaNivel2 { get; set; }

    [Column("codContaNivel3")]
    public long? CodContaNivel3 { get; set; }

    [Column("codContaNivel4")]
    public long? CodContaNivel4 { get; set; }

    [Column("codContaNivel5")]
    public long? CodContaNivel5 { get; set; }

    [Column("codContaNivel6")]
    public long? CodContaNivel6 { get; set; }

    [Column("nivel")]
    public int? Nivel { get; set; }

    [Column("bloqueada")]
    public bool? Bloqueada { get; set; }

    [Column("aceitaCentroCusto")]
    public bool? AceitaCentroCusto { get; set; }

    [Column("centroCustoObrigatorio")]
    public bool? CentroCustoObrigatorio { get; set; }

    [Column("dataUltimaMovimentacao", TypeName = "date")]
    public DateTime? DataUltimaMovimentacao { get; set; }
}