﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

public partial class MvtAcessoUsuario
{
    [Key]
    [Column("usuario")]
    [StringLength(50)]
    [Unicode(false)]
    public string Usuario { get; set; }

    [Column("codGrupo")]
    public int? CodGrupo { get; set; }

    [Column("email")]
    [StringLength(200)]
    [Unicode(false)]
    public string Email { get; set; }

    [Column("nome")]
    [StringLength(50)]
    [Unicode(false)]
    public string Nome { get; set; }

    [Column("situacao")]
    [StringLength(50)]
    [Unicode(false)]
    public string Situacao { get; set; }

    [Column("senha")]
    [StringLength(50)]
    [Unicode(false)]
    public string Senha { get; set; }

    [Column("tipo")]
    [StringLength(50)]
    [Unicode(false)]
    public string Tipo { get; set; }

    [Column("fundo")]
    [StringLength(255)]
    [Unicode(false)]
    public string Fundo { get; set; }

    [Column("tema")]
    [StringLength(50)]
    [Unicode(false)]
    public string Tema { get; set; }

    [Column("moduloPadrao")]
    [StringLength(50)]
    [Unicode(false)]
    public string ModuloPadrao { get; set; }

    [Column("usuarioActiveDirectory")]
    [StringLength(50)]
    [Unicode(false)]
    public string UsuarioActiveDirectory { get; set; }

    [Column("tempoExpiracaoSessao")]
    public int? TempoExpiracaoSessao { get; set; }

    [Column("horaInicioIntervaloAcesso")]
    public TimeSpan? HoraInicioIntervaloAcesso { get; set; }

    [Column("horaFimIntervaloAcesso")]
    public TimeSpan? HoraFimIntervaloAcesso { get; set; }

    [Column("horaInicioAcesso")]
    public TimeSpan? HoraInicioAcesso { get; set; }

    [Column("horaFimAcesso")]
    public TimeSpan? HoraFimAcesso { get; set; }

    [Column("diasSemanaAcesso")]
    [StringLength(15)]
    [Unicode(false)]
    public string DiasSemanaAcesso { get; set; }
}