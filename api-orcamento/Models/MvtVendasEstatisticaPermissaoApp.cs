﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

public partial class MvtVendasEstatisticaPermissaoApp
{
    [Column("nomeUsuario")]
    [StringLength(50)]
    [Unicode(false)]
    public string NomeUsuario { get; set; }

    [Column("permiteConfigurarConsulta")]
    public int? PermiteConfigurarConsulta { get; set; }

    [Key]
    [Column("usuario")]
    [StringLength(50)]
    [Unicode(false)]
    public string Usuario { get; set; }
}