﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

public partial class MvtCadMoeda
{
    [Key]
    [Column("codMoeda")]
    public int CodMoeda { get; set; }

    [Column("descricao")]
    [StringLength(50)]
    public string Descricao { get; set; }

    [Column("simbolo")]
    [StringLength(5)]
    public string Simbolo { get; set; }

    [Column("codBACEN")]
    public int? CodBacen { get; set; }
}