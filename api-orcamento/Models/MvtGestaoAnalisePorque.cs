// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodEmpresa", "Data", "Identificador", "Sequencia")]
public partial class MvtGestaoAnalisePorque
{
    [Key]
    [Column("codEmpresa")]
    public int CodEmpresa { get; set; }

    [Key]
    [Column("data", TypeName = "date")]
    public DateTime Data { get; set; }

    [Key]
    [Column("identificador")]
    [StringLength(50)]
    [Unicode(false)]
    public string Identificador { get; set; }

    [Key]
    [Column("sequencia")]
    public int Sequencia { get; set; }

    [Column("porque1")]
    [StringLength(250)]
    [Unicode(false)]
    public string Porque1 { get; set; }

    [Column("porque2")]
    [StringLength(250)]
    [Unicode(false)]
    public string Porque2 { get; set; }

    [Column("porque3")]
    [StringLength(250)]
    [Unicode(false)]
    public string Porque3 { get; set; }

    [Column("porque4")]
    [StringLength(250)]
    [Unicode(false)]
    public string Porque4 { get; set; }

    [Column("porque5")]
    [StringLength(250)]
    [Unicode(false)]
    public string Porque5 { get; set; }
}