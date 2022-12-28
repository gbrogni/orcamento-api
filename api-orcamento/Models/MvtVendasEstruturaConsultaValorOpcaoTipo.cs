﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("Nome", "CodTipo")]
public partial class MvtVendasEstruturaConsultaValorOpcaoTipo
{
    [Key]
    [Column("nome")]
    [StringLength(50)]
    [Unicode(false)]
    public string Nome { get; set; }

    [Key]
    [Column("codTipo")]
    public int CodTipo { get; set; }

    [Required]
    [Column("valor")]
    [StringLength(2000)]
    [Unicode(false)]
    public string Valor { get; set; }
}