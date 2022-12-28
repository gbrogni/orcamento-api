﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodEmpresa", "NumeroOrcamento", "CodModelo", "CodConta", "Tipo", "DataProjecao", "Data")]
[Table("MvtGestaoDREDados")]
public partial class MvtGestaoDredados
{
    [Key]
    [Column("codEmpresa")]
    public int CodEmpresa { get; set; }

    [Key]
    [Column("numeroOrcamento")]
    public int NumeroOrcamento { get; set; }

    [Key]
    [Column("codModelo")]
    public int CodModelo { get; set; }

    [Key]
    [Column("codConta")]
    public int CodConta { get; set; }

    [Key]
    [Column("tipo")]
    public int Tipo { get; set; }

    [Key]
    [Column("data", TypeName = "date")]
    public DateTime Data { get; set; }

    [Column("valor")]
    public double Valor { get; set; }

    [Key]
    [Column("dataProjecao", TypeName = "date")]
    public DateTime DataProjecao { get; set; }
}