﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodFiltro", "CodTipo")]
public partial class MvtStatsDashFiltroTipo
{
    [Key]
    [Column("codFiltro")]
    public int CodFiltro { get; set; }

    [Key]
    [Column("codTipo")]
    public int CodTipo { get; set; }
}