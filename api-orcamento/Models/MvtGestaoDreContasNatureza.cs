﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodModelo", "CodConta", "CodNatureza")]
public partial class MvtGestaoDreContasNatureza
{
    [Key]
    [Column("codModelo")]
    public int CodModelo { get; set; }

    [Key]
    [Column("codConta")]
    public int CodConta { get; set; }

    [Key]
    [Column("codNatureza")]
    [StringLength(10)]
    public string CodNatureza { get; set; }
}