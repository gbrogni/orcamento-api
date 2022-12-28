﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodEmpresa", "Usuario", "CodGrupoUsuario", "CodModelo", "CodObjetivo", "CodAcao", "CodIniciativa", "CodArea", "CodNivel", "CodIndicador")]
public partial class MvtGestaoDadoGerencialPermissao
{
    [Key]
    [Column("codEmpresa")]
    public int CodEmpresa { get; set; }

    [Key]
    [Column("usuario")]
    [StringLength(50)]
    [Unicode(false)]
    public string Usuario { get; set; }

    [Key]
    [Column("codGrupoUsuario")]
    public int CodGrupoUsuario { get; set; }

    [Key]
    [Column("codModelo")]
    public int CodModelo { get; set; }

    [Key]
    [Column("codObjetivo")]
    public int CodObjetivo { get; set; }

    [Key]
    [Column("codAcao")]
    public int CodAcao { get; set; }

    [Key]
    [Column("codIniciativa")]
    public int CodIniciativa { get; set; }

    [Key]
    [Column("codArea")]
    public int CodArea { get; set; }

    [Key]
    [Column("codNivel")]
    public int CodNivel { get; set; }

    [Key]
    [Column("codIndicador")]
    public int CodIndicador { get; set; }

    [Required]
    [Column("usuarioLog")]
    [StringLength(50)]
    [Unicode(false)]
    public string UsuarioLog { get; set; }

    [Column("dataHoraLog", TypeName = "datetime")]
    public DateTime DataHoraLog { get; set; }

    [Column("visualizar")]
    public bool Visualizar { get; set; }

    [Column("editar")]
    public bool Editar { get; set; }
}