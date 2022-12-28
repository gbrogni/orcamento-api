﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodEmpresa", "Id")]
public partial class MvtGestaoDadoGerencialAtributo
{
    [Key]
    [Column("codEmpresa")]
    public int CodEmpresa { get; set; }

    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Required]
    [Column("atributo")]
    [StringLength(50)]
    [Unicode(false)]
    public string Atributo { get; set; }

    [Column("tipoValor")]
    [StringLength(250)]
    [Unicode(false)]
    public string TipoValor { get; set; }

    [Column("obrigatorio")]
    public int? Obrigatorio { get; set; }
}