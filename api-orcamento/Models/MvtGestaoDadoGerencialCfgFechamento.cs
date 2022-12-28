﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodEmpresa", "CodModelo", "Mes")]
public partial class MvtGestaoDadoGerencialCfgFechamento
{
    [Key]
    [Column("codEmpresa")]
    public int CodEmpresa { get; set; }

    [Key]
    [Column("codModelo")]
    public int CodModelo { get; set; }

    [Key]
    [Column("mes")]
    public int Mes { get; set; }

    [Required]
    [Column("usuario")]
    [StringLength(50)]
    [Unicode(false)]
    public string Usuario { get; set; }

    [Column("data", TypeName = "date")]
    public DateTime? Data { get; set; }
}