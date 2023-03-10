// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodEmpresa", "Ano", "NumeroOrcamento", "CodGrupo")]
public partial class MvtOrcamentoGrupoContabilizacao
{
    [Key]
    [Column("codEmpresa")]
    public int CodEmpresa { get; set; }

    [Key]
    [Column("ano")]
    public int Ano { get; set; }

    [Key]
    [Column("numeroOrcamento")]
    public int NumeroOrcamento { get; set; }

    [Key]
    [Column("codGrupo")]
    public int CodGrupo { get; set; }

    [Column("nomeGrupo")]
    [StringLength(150)]
    [Unicode(false)]
    public string NomeGrupo { get; set; }
}