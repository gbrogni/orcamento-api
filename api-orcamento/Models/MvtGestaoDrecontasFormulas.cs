// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodModelo", "CodConta", "Sequencia")]
[Table("MvtGestaoDREContasFormulas")]
public partial class MvtGestaoDrecontasFormulas
{
    [Key]
    [Column("codConta")]
    public int CodConta { get; set; }

    [Column("codContaCalculo")]
    public int? CodContaCalculo { get; set; }

    [Key]
    [Column("codModelo")]
    public int CodModelo { get; set; }

    [Column("operacao")]
    [StringLength(50)]
    public string Operacao { get; set; }

    [Column("percentual")]
    public int? Percentual { get; set; }

    [Key]
    [Column("sequencia")]
    public int Sequencia { get; set; }

    [Column("codModeloCalculo")]
    public int? CodModeloCalculo { get; set; }
}