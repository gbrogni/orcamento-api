﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("Identificador", "Email", "Tipo")]
public partial class MvtCadenvioEmailDestinatario
{
    [Key]
    [Column("identificador")]
    [StringLength(100)]
    [Unicode(false)]
    public string Identificador { get; set; }

    [Key]
    [Column("email")]
    [StringLength(150)]
    [Unicode(false)]
    public string Email { get; set; }

    [Key]
    [Column("tipo")]
    public int Tipo { get; set; }
}