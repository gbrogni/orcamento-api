﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodEmpresa", "AnoMes", "TipoFuncionario", "CodFuncionario")]
public partial class MvtRhSitMensalFuncion
{
    [Key]
    [Column("codEmpresa")]
    public int CodEmpresa { get; set; }

    [Key]
    [Column("anoMes", TypeName = "date")]
    public DateTime AnoMes { get; set; }

    [Key]
    [Column("tipoFuncionario")]
    [StringLength(10)]
    [Unicode(false)]
    public string TipoFuncionario { get; set; }

    [Key]
    [Column("codFuncionario")]
    public int CodFuncionario { get; set; }

    [Column("salario")]
    public double? Salario { get; set; }
}