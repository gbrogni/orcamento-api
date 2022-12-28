﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[Keyless]
public partial class MvtVendasEstruturaConsultaMes
{
    [Column("codEmpresa")]
    public int CodEmpresa { get; set; }

    [Required]
    [Column("tipo")]
    [StringLength(200)]
    [Unicode(false)]
    public string Tipo { get; set; }

    [Column("data", TypeName = "date")]
    public DateTime Data { get; set; }

    [Required]
    [Column("codProduto")]
    [StringLength(200)]
    [Unicode(false)]
    public string CodProduto { get; set; }

    [Column("nomeProduto")]
    [StringLength(300)]
    [Unicode(false)]
    public string NomeProduto { get; set; }

    [Column("qtde")]
    public double? Qtde { get; set; }

    [Column("custoUni")]
    public double? CustoUni { get; set; }

    [Column("valorVenda")]
    public double? ValorVenda { get; set; }

    [Column("custoTotal")]
    public double? CustoTotal { get; set; }
}