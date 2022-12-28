﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodEmpresa", "CodObjetivo")]
public partial class MvtGestaoDadoGerencialObjetivo
{
    [Key]
    [Column("codEmpresa")]
    public int CodEmpresa { get; set; }

    [Key]
    [Column("codObjetivo")]
    public int CodObjetivo { get; set; }

    [Column("nomeObjetivo")]
    [StringLength(100)]
    [Unicode(false)]
    public string NomeObjetivo { get; set; }

    [Column("ordenacao")]
    public int? Ordenacao { get; set; }

    [Column("corFundo")]
    public long? CorFundo { get; set; }

    [Column("corTexto")]
    public long? CorTexto { get; set; }
}