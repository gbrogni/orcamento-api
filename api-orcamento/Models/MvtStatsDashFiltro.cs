﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodVisao", "CodColuna")]
public partial class MvtStatsDashFiltro
{
    [Key]
    [Column("codVisao")]
    public int CodVisao { get; set; }

    [Key]
    [Column("codColuna")]
    [StringLength(50)]
    [Unicode(false)]
    public string CodColuna { get; set; }

    [Column("ordem")]
    public int Ordem { get; set; }
}