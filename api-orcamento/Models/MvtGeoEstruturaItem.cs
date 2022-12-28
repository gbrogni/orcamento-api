﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodEstrutura", "CodItem")]
public partial class MvtGeoEstruturaItem
{
    [Key]
    [Column("codEstrutura")]
    public int CodEstrutura { get; set; }

    [Key]
    [Column("codItem")]
    public int CodItem { get; set; }

    [Required]
    [Column("tipoColuna")]
    [StringLength(50)]
    [Unicode(false)]
    public string TipoColuna { get; set; }

    [Required]
    [Column("nomeColuna")]
    [StringLength(50)]
    [Unicode(false)]
    public string NomeColuna { get; set; }

    [Column("tipoOrigem")]
    [StringLength(50)]
    [Unicode(false)]
    public string TipoOrigem { get; set; }

    [Column("tipoExibicao")]
    [StringLength(50)]
    [Unicode(false)]
    public string TipoExibicao { get; set; }

    [Column("tipoPerimetro")]
    [StringLength(50)]
    [Unicode(false)]
    public string TipoPerimetro { get; set; }

    [Column("nomeColunaLatitude")]
    [StringLength(50)]
    [Unicode(false)]
    public string NomeColunaLatitude { get; set; }

    [Column("nomeColunaLongitude")]
    [StringLength(50)]
    [Unicode(false)]
    public string NomeColunaLongitude { get; set; }

    [Column("nomeColunaCodigo")]
    [StringLength(50)]
    [Unicode(false)]
    public string NomeColunaCodigo { get; set; }

    [Column("estilo")]
    [Unicode(false)]
    public string Estilo { get; set; }

    [Column("filtro")]
    public int Filtro { get; set; }

    [Column("ordem")]
    public int Ordem { get; set; }
}