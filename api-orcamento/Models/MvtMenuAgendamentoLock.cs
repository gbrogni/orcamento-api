﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

public partial class MvtMenuAgendamentoLock
{
    [Key]
    [Column("sequencia")]
    public int Sequencia { get; set; }

    [Column("dataHora", TypeName = "datetime")]
    public DateTime? DataHora { get; set; }

    [Column("usuario")]
    [StringLength(50)]
    [Unicode(false)]
    public string Usuario { get; set; }
}