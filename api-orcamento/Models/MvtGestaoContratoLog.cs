﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodEmpresa", "Data", "CodContrato", "DataHora")]
public partial class MvtGestaoContratoLog
{
    [Key]
    [Column("codEmpresa")]
    public int CodEmpresa { get; set; }

    [Key]
    [Column("data", TypeName = "date")]
    public DateTime Data { get; set; }

    [Key]
    [Column("codContrato")]
    public int CodContrato { get; set; }

    [Key]
    [Column("dataHora", TypeName = "datetime")]
    public DateTime DataHora { get; set; }

    [Required]
    [Column("usuario")]
    [StringLength(50)]
    [Unicode(false)]
    public string Usuario { get; set; }

    [Column("descricao")]
    [StringLength(500)]
    [Unicode(false)]
    public string Descricao { get; set; }
}