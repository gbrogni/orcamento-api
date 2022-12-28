﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodEmpresa", "NumeroOrcamento", "Data", "CodContaContabil", "CodNatFinanceira")]
public partial class MvtOrcamentoBalancoPartidaCfgBaixa
{
    [Key]
    [Column("codEmpresa")]
    public int CodEmpresa { get; set; }

    [Key]
    [Column("numeroOrcamento")]
    public int NumeroOrcamento { get; set; }

    [Key]
    [Column("data", TypeName = "date")]
    public DateTime Data { get; set; }

    [Key]
    [Column("codContaContabil")]
    [StringLength(10)]
    [Unicode(false)]
    public string CodContaContabil { get; set; }

    [Key]
    [Column("codNatFinanceira")]
    [StringLength(10)]
    [Unicode(false)]
    public string CodNatFinanceira { get; set; }

    [Column("valor")]
    public double? Valor { get; set; }
}