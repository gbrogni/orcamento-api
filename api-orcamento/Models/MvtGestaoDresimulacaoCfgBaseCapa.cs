﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodModelo", "CodConfig")]
[Table("MvtGestaoDRESimulacaoCfgBaseCapa")]
public partial class MvtGestaoDresimulacaoCfgBaseCapa
{
    [Key]
    [Column("codModelo")]
    public int CodModelo { get; set; }

    [Key]
    [Column("codConfig")]
    public int CodConfig { get; set; }

    [Column("descricao")]
    [StringLength(150)]
    [Unicode(false)]
    public string Descricao { get; set; }
}