﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodEmpresa", "NumeroOrcamento", "Ano", "Mes")]
public partial class MvtOrcamentoConfigJustificativaPrazo
{
    [Key]
    [Column("codEmpresa")]
    public int CodEmpresa { get; set; }

    [Key]
    [Column("numeroOrcamento")]
    public int NumeroOrcamento { get; set; }

    [Key]
    [Column("ano")]
    public int Ano { get; set; }

    [Key]
    [Column("mes")]
    public int Mes { get; set; }

    [Column("dataPrazo", TypeName = "date")]
    public DateTime? DataPrazo { get; set; }

    [Column("permissaoEspecial")]
    [StringLength(550)]
    [Unicode(false)]
    public string PermissaoEspecial { get; set; }
}