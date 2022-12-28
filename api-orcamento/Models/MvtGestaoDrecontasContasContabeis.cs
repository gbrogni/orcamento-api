﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodModelo", "CodConta", "CodCentroCusto", "CodContaContabil")]
[Table("MvtGestaoDREContasContasContabeis")]
public partial class MvtGestaoDrecontasContasContabeis
{
    [Key]
    [Column("codModelo")]
    public int CodModelo { get; set; }

    [Key]
    [Column("codConta")]
    public int CodConta { get; set; }

    [Key]
    [Column("codCentroCusto")]
    public int CodCentroCusto { get; set; }

    [Key]
    [Column("codContaContabil")]
    [StringLength(10)]
    [Unicode(false)]
    public string CodContaContabil { get; set; }

    [Column("codCentroCustoFim")]
    public int? CodCentroCustoFim { get; set; }

    [Column("codContaContabilFim")]
    [StringLength(10)]
    [Unicode(false)]
    public string CodContaContabilFim { get; set; }
}