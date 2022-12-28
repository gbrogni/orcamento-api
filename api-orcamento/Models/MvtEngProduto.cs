﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodProduto", "CodInsumo", "DataInicio", "DataTermino", "CodSequencia", "CodOperacao")]
public partial class MvtEngProduto
{
    [Key]
    [Column("codProduto")]
    [StringLength(20)]
    [Unicode(false)]
    public string CodProduto { get; set; }

    [Key]
    [Column("codInsumo")]
    [StringLength(20)]
    [Unicode(false)]
    public string CodInsumo { get; set; }

    [Key]
    [Column("dataInicio", TypeName = "date")]
    public DateTime DataInicio { get; set; }

    [Key]
    [Column("dataTermino", TypeName = "date")]
    public DateTime DataTermino { get; set; }

    [Key]
    [Column("codSequencia")]
    public int CodSequencia { get; set; }

    [Key]
    [Column("codOperacao")]
    public int CodOperacao { get; set; }

    [Column("fantasma")]
    [StringLength(1)]
    [Unicode(false)]
    public string Fantasma { get; set; }

    [Column("geraReserva")]
    [StringLength(1)]
    [Unicode(false)]
    public string GeraReserva { get; set; }

    [Column("qtdeAgregada")]
    public double? QtdeAgregada { get; set; }

    [Column("qtdePerdaFixa")]
    public double? QtdePerdaFixa { get; set; }

    [Column("percentualRendimento")]
    public double? PercentualRendimento { get; set; }

    [Column("possuiEngenharia")]
    public int? PossuiEngenharia { get; set; }
}