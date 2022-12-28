﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodModelo", "Ano", "Sequencia")]
[Table("MvtGestaoDadoGerencialConfigPDIPrazo")]
public partial class MvtGestaoDadoGerencialConfigPdiprazo
{
    [Key]
    [Column("codModelo")]
    [StringLength(10)]
    public string CodModelo { get; set; }

    [Key]
    [Column("ano")]
    public int Ano { get; set; }

    [Key]
    [Column("sequencia")]
    public int Sequencia { get; set; }

    [Column("dataInicio", TypeName = "date")]
    public DateTime DataInicio { get; set; }

    [Column("dataFinal", TypeName = "date")]
    public DateTime DataFinal { get; set; }

    [Column("ciclo")]
    public int? Ciclo { get; set; }
}