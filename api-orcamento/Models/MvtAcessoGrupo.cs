// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

public partial class MvtAcessoGrupo
{
    [Key]
    [Column("codGrupo")]
    public int CodGrupo { get; set; }

    [Column("nomeGrupo")]
    [StringLength(50)]
    [Unicode(false)]
    public string NomeGrupo { get; set; }
}