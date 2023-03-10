// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("Usuario", "Sistema", "Favorito")]
public partial class MvtAcessoUsuarioFavorito
{
    [Key]
    [Column("usuario")]
    [StringLength(50)]
    [Unicode(false)]
    public string Usuario { get; set; }

    [Key]
    [Column("sistema")]
    [StringLength(50)]
    [Unicode(false)]
    public string Sistema { get; set; }

    [Key]
    [Column("favorito")]
    [StringLength(255)]
    [Unicode(false)]
    public string Favorito { get; set; }

    [Column("programa")]
    [StringLength(255)]
    [Unicode(false)]
    public string Programa { get; set; }

    [Column("nome")]
    [StringLength(255)]
    [Unicode(false)]
    public string Nome { get; set; }
}