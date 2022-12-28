﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodModelo", "CodConfig", "IdConta", "Sequencia")]
[Table("MvtGestaoDRESimulacaoCfgBaseContaProporcao")]
public partial class MvtGestaoDresimulacaoCfgBaseContaProporcao
{
    [Key]
    [Column("codModelo")]
    public int CodModelo { get; set; }

    [Key]
    [Column("codConfig")]
    public int CodConfig { get; set; }

    [Key]
    [Column("idConta")]
    [StringLength(150)]
    [Unicode(false)]
    public string IdConta { get; set; }

    [Key]
    [Column("sequencia")]
    public int Sequencia { get; set; }

    [Column("codModeloProp")]
    public int CodModeloProp { get; set; }

    [Column("codContaProp")]
    public int CodContaProp { get; set; }
}