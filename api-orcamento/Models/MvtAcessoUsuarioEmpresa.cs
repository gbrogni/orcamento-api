// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("Usuario", "CodEmpresa")]
public partial class MvtAcessoUsuarioEmpresa
{
    [Key]
    [Column("usuario")]
    [StringLength(50)]
    [Unicode(false)]
    public string Usuario { get; set; }

    [Key]
    [Column("codEmpresa")]
    public int CodEmpresa { get; set; }
}