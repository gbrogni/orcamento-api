// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

public partial class MvtCtbPacote
{
    [Key]
    [Column("codPacote")]
    public int CodPacote { get; set; }

    [Required]
    [Column("nomePacote")]
    [StringLength(150)]
    [Unicode(false)]
    public string NomePacote { get; set; }
}