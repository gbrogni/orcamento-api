// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodModelo", "AnoBase", "DataInicial", "CodEmpresa")]
public partial class MvtGestaoDadoGerencialConfigOrcDespesa
{
    [Key]
    [Column("codModelo")]
    public int CodModelo { get; set; }

    [Key]
    [Column("anoBase")]
    public int AnoBase { get; set; }

    [Key]
    [Column("dataInicial", TypeName = "date")]
    public DateTime DataInicial { get; set; }

    [Key]
    [Column("codEmpresa")]
    public int CodEmpresa { get; set; }

    [Column("numeroOrcamento")]
    public int NumeroOrcamento { get; set; }

    [Column("dataInicioProjecao", TypeName = "date")]
    public DateTime DataInicioProjecao { get; set; }
}