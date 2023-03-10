// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodEmpresa", "NumeroOrcamento", "NomeConta", "Data")]
public partial class MvtOrcamentoOrcamentoManual
{
    [Key]
    [Column("codEmpresa")]
    public int CodEmpresa { get; set; }

    [Key]
    [Column("numeroOrcamento")]
    public int NumeroOrcamento { get; set; }

    [Key]
    [Column("nomeConta")]
    [StringLength(100)]
    [Unicode(false)]
    public string NomeConta { get; set; }

    [Key]
    [Column("data", TypeName = "date")]
    public DateTime Data { get; set; }

    [Column("valor")]
    public double? Valor { get; set; }
}