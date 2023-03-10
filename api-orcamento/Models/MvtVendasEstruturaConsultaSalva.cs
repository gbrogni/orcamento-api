// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[Keyless]
public partial class MvtVendasEstruturaConsultaSalva
{
    [Required]
    [Column("usuario")]
    [StringLength(50)]
    [Unicode(false)]
    public string Usuario { get; set; }

    [Required]
    [Column("nomeConsulta")]
    [StringLength(50)]
    [Unicode(false)]
    public string NomeConsulta { get; set; }

    [Column("dataHora", TypeName = "datetime")]
    public DateTime DataHora { get; set; }

    [Column("paiObjeto")]
    [StringLength(50)]
    [Unicode(false)]
    public string PaiObjeto { get; set; }

    [Required]
    [Column("nomeObjeto")]
    [StringLength(50)]
    [Unicode(false)]
    public string NomeObjeto { get; set; }

    [Column("tipoObjeto")]
    [StringLength(50)]
    [Unicode(false)]
    public string TipoObjeto { get; set; }

    [Column("sequencia")]
    public int Sequencia { get; set; }

    [Column("valorObjeto")]
    [Unicode(false)]
    public string ValorObjeto { get; set; }
}