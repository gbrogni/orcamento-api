﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[Table("MvtGestaoDREConsultaSalva")]
public partial class MvtGestaoDreconsultaSalva
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("descricao")]
    [StringLength(150)]
    [Unicode(false)]
    public string Descricao { get; set; }

    [Column("dataGeracao", TypeName = "datetime")]
    public DateTime? DataGeracao { get; set; }

    [Column("usuarioGeracao")]
    [StringLength(50)]
    [Unicode(false)]
    public string UsuarioGeracao { get; set; }

    [Column("fazParteBook")]
    public int? FazParteBook { get; set; }

    [Column("ordemImpressao")]
    public int? OrdemImpressao { get; set; }

    [Column("tipoPeriodoBook")]
    public int? TipoPeriodoBook { get; set; }

    [Column("tituloNoBook")]
    [StringLength(150)]
    [Unicode(false)]
    public string TituloNoBook { get; set; }

    [Column("orientacaoImpressao")]
    public int? OrientacaoImpressao { get; set; }

    [Column("dimensionamento")]
    public int? Dimensionamento { get; set; }

    [Column("nomeFonteBook")]
    [StringLength(100)]
    [Unicode(false)]
    public string NomeFonteBook { get; set; }

    [Column("tamanhoFonteBook")]
    public int? TamanhoFonteBook { get; set; }

    [Column("paginasLargura")]
    public int? PaginasLargura { get; set; }

    [Column("paginasAltura")]
    public int? PaginasAltura { get; set; }

    [Column("margemEsquerda")]
    public double? MargemEsquerda { get; set; }

    [Column("margemDireita")]
    public double? MargemDireita { get; set; }

    [Column("margemCabecalho")]
    public double? MargemCabecalho { get; set; }

    [Column("margemRodape")]
    public double? MargemRodape { get; set; }
}