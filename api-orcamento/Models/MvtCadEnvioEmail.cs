﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

public partial class MvtCadEnvioEmail
{
    [Key]
    [Column("identificador")]
    [StringLength(100)]
    [Unicode(false)]
    public string Identificador { get; set; }

    [Column("assunto")]
    [StringLength(250)]
    [Unicode(false)]
    public string Assunto { get; set; }

    [Required]
    [Column("corpo")]
    [StringLength(5000)]
    [Unicode(false)]
    public string Corpo { get; set; }

    [Column("isHtml")]
    public bool IsHtml { get; set; }

    [Column("dataGeracao", TypeName = "date")]
    public DateTime DataGeracao { get; set; }

    [Required]
    [Column("usuarioGeracao")]
    [StringLength(50)]
    [Unicode(false)]
    public string UsuarioGeracao { get; set; }

    [Column("dataEnvio", TypeName = "date")]
    public DateTime DataEnvio { get; set; }

    [Column("dataUltEnvio", TypeName = "date")]
    public DateTime? DataUltEnvio { get; set; }

    [Column("diasReenvio")]
    public int? DiasReenvio { get; set; }

    [Column("situacao")]
    public int Situacao { get; set; }

    [Column("reenviar")]
    public bool? Reenviar { get; set; }
}