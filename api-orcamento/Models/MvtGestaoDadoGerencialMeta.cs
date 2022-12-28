﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodEmpresa", "CodModelo", "Data", "CodIndicador")]
public partial class MvtGestaoDadoGerencialMeta
{
    [Key]
    [Column("codEmpresa")]
    public int CodEmpresa { get; set; }

    [Key]
    [Column("codModelo")]
    public int CodModelo { get; set; }

    [Key]
    [Column("data", TypeName = "date")]
    public DateTime Data { get; set; }

    [Key]
    [Column("codIndicador")]
    public int CodIndicador { get; set; }

    [Column("valorMeta")]
    public double? ValorMeta { get; set; }

    [Column("vlrMetaParaAcumular")]
    public double? VlrMetaParaAcumular { get; set; }

    [Column("observacao")]
    [StringLength(500)]
    [Unicode(false)]
    public string Observacao { get; set; }
}