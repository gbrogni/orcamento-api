﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("NomeProjeto", "NomeForm")]
public partial class MvtAcessoAjuda
{
    [Key]
    [Column("nomeProjeto")]
    [StringLength(50)]
    [Unicode(false)]
    public string NomeProjeto { get; set; }

    [Key]
    [Column("nomeForm")]
    [StringLength(50)]
    [Unicode(false)]
    public string NomeForm { get; set; }

    [Column("dados", TypeName = "text")]
    public string Dados { get; set; }
}