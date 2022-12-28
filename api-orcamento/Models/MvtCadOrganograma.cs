﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodEmpresa", "Ano", "CodNivelAgrupador", "CodNivel")]
public partial class MvtCadOrganograma
{
    [Key]
    [Column("codEmpresa")]
    public int CodEmpresa { get; set; }

    [Key]
    [Column("ano")]
    public int Ano { get; set; }

    [Key]
    [Column("codNivelAgrupador")]
    public int CodNivelAgrupador { get; set; }

    [Key]
    [Column("codNivel")]
    [StringLength(10)]
    public string CodNivel { get; set; }
}