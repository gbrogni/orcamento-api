﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("IdSimulacao", "CodModelo", "IdConta", "Sequencia", "DataMes")]
[Table("MvtGestaoDRESimulacaoCfgContasValorAjuste")]
public partial class MvtGestaoDresimulacaoCfgContasValorAjuste
{
    [Key]
    [Column("idSimulacao")]
    public int IdSimulacao { get; set; }

    [Key]
    [Column("codModelo")]
    public int CodModelo { get; set; }

    [Key]
    [Column("idConta")]
    [StringLength(150)]
    [Unicode(false)]
    public string IdConta { get; set; }

    [Key]
    [Column("sequencia")]
    public int Sequencia { get; set; }

    [Key]
    [Column("dataMes", TypeName = "date")]
    public DateTime DataMes { get; set; }

    [Column("tipoAjuste")]
    public int TipoAjuste { get; set; }

    [Column("valor")]
    public double? Valor { get; set; }
}