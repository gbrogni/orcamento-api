﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodEmpresa", "CodInvestimento", "NumeroOrcamento", "AnoMes")]
public partial class MvtCtbOrcamentoCapitais
{
    [Key]
    [Column("codEmpresa")]
    public int CodEmpresa { get; set; }

    [Key]
    [Column("codInvestimento")]
    public int CodInvestimento { get; set; }

    [Key]
    [Column("numeroOrcamento")]
    public int NumeroOrcamento { get; set; }

    [Key]
    [Column("anoMes", TypeName = "date")]
    public DateTime AnoMes { get; set; }

    [Column("valor")]
    public double? Valor { get; set; }
}