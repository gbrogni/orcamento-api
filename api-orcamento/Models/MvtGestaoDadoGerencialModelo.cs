﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodEmpresa", "CodModelo")]
public partial class MvtGestaoDadoGerencialModelo
{
    [Key]
    [Column("codEmpresa")]
    public int CodEmpresa { get; set; }

    [Key]
    [Column("codModelo")]
    public int CodModelo { get; set; }

    [Column("nomeModelo")]
    [StringLength(100)]
    [Unicode(false)]
    public string NomeModelo { get; set; }

    [Column("enviaEmail")]
    public int? EnviaEmail { get; set; }

    [Column("possuiControleMeta")]
    public int? PossuiControleMeta { get; set; }

    [Column("permiteAlterarPrazo")]
    public int? PermiteAlterarPrazo { get; set; }
}