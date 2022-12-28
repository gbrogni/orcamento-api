﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodEmpresa", "CodCentroCusto", "Usuario")]
public partial class MvtOrcamentoLiberacaoCentroCusto
{
    [Key]
    [Column("codEmpresa")]
    public int CodEmpresa { get; set; }

    [Key]
    [Column("codCentroCusto")]
    public int CodCentroCusto { get; set; }

    [Key]
    [Column("usuario")]
    [StringLength(50)]
    public string Usuario { get; set; }
}