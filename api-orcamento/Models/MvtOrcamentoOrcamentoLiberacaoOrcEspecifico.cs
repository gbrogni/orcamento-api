// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodEmpresa", "DesOrcamento", "NumeroOrcamento")]
public partial class MvtOrcamentoOrcamentoLiberacaoOrcEspecifico
{
    [Key]
    [Column("codEmpresa")]
    public int CodEmpresa { get; set; }

    [Key]
    [Column("desOrcamento")]
    [StringLength(150)]
    [Unicode(false)]
    public string DesOrcamento { get; set; }

    [Key]
    [Column("numeroOrcamento")]
    public int NumeroOrcamento { get; set; }
}