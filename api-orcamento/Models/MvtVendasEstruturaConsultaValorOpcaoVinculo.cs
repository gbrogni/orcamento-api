﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("NomeValor", "NomeVinculo")]
public partial class MvtVendasEstruturaConsultaValorOpcaoVinculo
{
    [Key]
    [Column("nomeValor")]
    [StringLength(50)]
    [Unicode(false)]
    public string NomeValor { get; set; }

    [Key]
    [Column("nomeVinculo")]
    [StringLength(50)]
    [Unicode(false)]
    public string NomeVinculo { get; set; }
}