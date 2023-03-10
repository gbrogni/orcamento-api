// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

public partial class MvtGeoCidade
{
    [Key]
    [Column("codCidade")]
    public int CodCidade { get; set; }

    [Required]
    [Column("nomeCidade")]
    [StringLength(100)]
    [Unicode(false)]
    public string NomeCidade { get; set; }

    [Column("codMicrorregiao")]
    public int CodMicrorregiao { get; set; }

    [Required]
    [Column("nomeMicrorregiao")]
    [StringLength(100)]
    [Unicode(false)]
    public string NomeMicrorregiao { get; set; }

    [Column("codMesorregiao")]
    public int CodMesorregiao { get; set; }

    [Required]
    [Column("nomeMesorregiao")]
    [StringLength(100)]
    [Unicode(false)]
    public string NomeMesorregiao { get; set; }

    [Column("codEstado")]
    public int CodEstado { get; set; }

    [Required]
    [Column("siglaEstado")]
    [StringLength(10)]
    [Unicode(false)]
    public string SiglaEstado { get; set; }

    [Required]
    [Column("nomeEstado")]
    [StringLength(100)]
    [Unicode(false)]
    public string NomeEstado { get; set; }

    [Column("codRegiao")]
    public int CodRegiao { get; set; }

    [Required]
    [Column("nomeRegiao")]
    [StringLength(100)]
    [Unicode(false)]
    public string NomeRegiao { get; set; }

    [Column("codPais")]
    public int CodPais { get; set; }

    [Required]
    [Column("nomePais")]
    [StringLength(100)]
    [Unicode(false)]
    public string NomePais { get; set; }

    [Column("codRepresentante")]
    public int? CodRepresentante { get; set; }

    [Column("populacao")]
    public int? Populacao { get; set; }

    [Column("pibPerCapita")]
    public double? PibPerCapita { get; set; }

    [Column("latitude")]
    public double? Latitude { get; set; }

    [Column("longitude")]
    public double? Longitude { get; set; }
}