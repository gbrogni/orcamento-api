﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodConsulta", "Tipo", "CodIdentificador")]
public partial class MvtVendasEstatisticaConsultaSalvaPermissaoApp
{
    [Key]
    [Column("codConsulta")]
    public int CodConsulta { get; set; }

    [Key]
    [Column("codIdentificador")]
    [StringLength(100)]
    [Unicode(false)]
    public string CodIdentificador { get; set; }

    [Key]
    [Column("tipo")]
    public int Tipo { get; set; }
}