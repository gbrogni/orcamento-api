﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodConsulta", "Usuario")]
public partial class MvtStatsConsultaUsuario
{
    [Key]
    [Column("codConsulta")]
    public int CodConsulta { get; set; }

    [Key]
    [Column("usuario")]
    [StringLength(50)]
    [Unicode(false)]
    public string Usuario { get; set; }

    [Column("qtdeUso")]
    public int QtdeUso { get; set; }

    [Required]
    [Column("usuarioCadastro")]
    [StringLength(50)]
    [Unicode(false)]
    public string UsuarioCadastro { get; set; }

    [Column("dataHoraCadastro", TypeName = "datetime")]
    public DateTime DataHoraCadastro { get; set; }

    [Column("permissaoEdicao")]
    public int? PermissaoEdicao { get; set; }
}