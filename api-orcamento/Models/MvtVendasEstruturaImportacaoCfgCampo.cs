﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodEmpresa", "Tipo", "CampoStats")]
public partial class MvtVendasEstruturaImportacaoCfgCampo
{
    [Key]
    [Column("codEmpresa")]
    public int CodEmpresa { get; set; }

    [Key]
    [Column("tipo")]
    [StringLength(50)]
    [Unicode(false)]
    public string Tipo { get; set; }

    [Key]
    [Column("campoStats")]
    [StringLength(50)]
    [Unicode(false)]
    public string CampoStats { get; set; }

    [Column("bloqueiaDuplicar")]
    public int? BloqueiaDuplicar { get; set; }

    [Column("campoErp")]
    [StringLength(1000)]
    [Unicode(false)]
    public string CampoErp { get; set; }

    [Column("campoErpUnionAll")]
    [Unicode(false)]
    public string CampoErpUnionAll { get; set; }

    [Column("campoErpUnionAll1")]
    [Unicode(false)]
    public string CampoErpUnionAll1 { get; set; }

    [Column("estado")]
    public int? Estado { get; set; }
}