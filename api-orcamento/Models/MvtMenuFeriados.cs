﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

public partial class MvtMenuFeriados
{
    [Key]
    [Column("feriado", TypeName = "date")]
    public DateTime Feriado { get; set; }

    [Column("bancario")]
    public int? Bancario { get; set; }

    [Column("descricao")]
    [StringLength(100)]
    [Unicode(false)]
    public string Descricao { get; set; }
}