﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("Usuario", "Projeto", "Formulario", "DataGrid", "Coluna")]
public partial class MvtAcessoUsuarioConsultaColuna
{
    [Key]
    [Column("usuario")]
    [StringLength(30)]
    [Unicode(false)]
    public string Usuario { get; set; }

    [Key]
    [Column("projeto")]
    [StringLength(30)]
    [Unicode(false)]
    public string Projeto { get; set; }

    [Key]
    [Column("formulario")]
    [StringLength(30)]
    [Unicode(false)]
    public string Formulario { get; set; }

    [Key]
    [Column("dataGrid")]
    [StringLength(30)]
    [Unicode(false)]
    public string DataGrid { get; set; }

    [Key]
    [Column("coluna")]
    [StringLength(30)]
    [Unicode(false)]
    public string Coluna { get; set; }

    [Column("visivel")]
    public int? Visivel { get; set; }
}