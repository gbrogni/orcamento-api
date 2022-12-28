﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodEmpresa", "CodModelo", "Data", "CodIndicador", "SeqAnexo")]
public partial class MvtGestaoDadoGerencialRealizadoAnexo
{
    [Key]
    [Column("codEmpresa")]
    public int CodEmpresa { get; set; }

    [Key]
    [Column("codModelo")]
    public int CodModelo { get; set; }

    [Key]
    [Column("data", TypeName = "date")]
    public DateTime Data { get; set; }

    [Key]
    [Column("codIndicador")]
    public int CodIndicador { get; set; }

    [Key]
    [Column("seqAnexo")]
    public int SeqAnexo { get; set; }

    [Required]
    [Column("nome")]
    [StringLength(100)]
    [Unicode(false)]
    public string Nome { get; set; }

    [Required]
    [Column("arquivo")]
    public byte[] Arquivo { get; set; }

    [Required]
    [Column("usuarioCadastro")]
    [StringLength(50)]
    [Unicode(false)]
    public string UsuarioCadastro { get; set; }

    [Column("dataCadastro", TypeName = "datetime")]
    public DateTime DataCadastro { get; set; }

    [Column("usuarioExclusao")]
    [StringLength(50)]
    [Unicode(false)]
    public string UsuarioExclusao { get; set; }

    [Column("dataExclusao", TypeName = "datetime")]
    public DateTime? DataExclusao { get; set; }
}