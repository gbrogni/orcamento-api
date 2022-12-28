// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using IndexAttribute = Microsoft.EntityFrameworkCore.IndexAttribute;

namespace api_orcamento.Models;

[Index("Origem", Name = "IX_MvtStatsConsulta_Origem")]
public partial class MvtStatsConsulta
{
    [Key]
    [Column("codConsulta")]
    public int CodConsulta { get; set; }

    [Required]
    [Column("nome")]
    [StringLength(100)]
    [Unicode(false)]
    public string Nome { get; set; }

    [Column("imagem")]
    [Unicode(false)]
    public string Imagem { get; set; }

    [Required]
    [Column("dados")]
    [Unicode(false)]
    public string Dados { get; set; }

    [Required]
    [Column("usuarioCadastro")]
    [StringLength(50)]
    [Unicode(false)]
    public string UsuarioCadastro { get; set; }

    [Column("dataHoraCadastro", TypeName = "datetime")]
    public DateTime DataHoraCadastro { get; set; }

    [Required]
    [Column("origem")]
    [StringLength(50)]
    [Unicode(false)]
    public string Origem { get; set; }

    [Column("grupo")]
    [StringLength(100)]
    [Unicode(false)]
    public string Grupo { get; set; }
}