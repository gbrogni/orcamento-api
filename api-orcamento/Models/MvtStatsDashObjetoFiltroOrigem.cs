﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodVisao", "CodObjeto", "CodFiltro", "CodTipo")]
public partial class MvtStatsDashObjetoFiltroOrigem
{
    [Key]
    [Column("codFiltro")]
    public int CodFiltro { get; set; }

    [Key]
    [Column("codObjeto")]
    public int CodObjeto { get; set; }

    [Key]
    [Column("codTipo")]
    public int CodTipo { get; set; }

    [Key]
    [Column("codVisao")]
    public int CodVisao { get; set; }
}