﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

public partial class MvtMenuModulo
{
    [Key]
    [Column("nome")]
    [StringLength(50)]
    [Unicode(false)]
    public string Nome { get; set; }

    [Column("descricao")]
    [StringLength(50)]
    [Unicode(false)]
    public string Descricao { get; set; }

    [Column("logo")]
    [StringLength(51)]
    [Unicode(false)]
    public string Logo { get; set; }
}