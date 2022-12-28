﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("Usuario", "Maquina", "PId", "NomeArquivo")]
public partial class MvtAcessoProcesso
{
    [Key]
    [Column("usuario")]
    [StringLength(50)]
    [Unicode(false)]
    public string Usuario { get; set; }

    [Key]
    [Column("maquina")]
    [StringLength(400)]
    [Unicode(false)]
    public string Maquina { get; set; }

    [Key]
    [Column("pID")]
    public int PId { get; set; }

    [Key]
    [Column("nomeArquivo")]
    [StringLength(400)]
    [Unicode(false)]
    public string NomeArquivo { get; set; }

    [Column("nome")]
    [StringLength(100)]
    [Unicode(false)]
    public string Nome { get; set; }

    [Column("caminhoArquivo")]
    [StringLength(8000)]
    [Unicode(false)]
    public string CaminhoArquivo { get; set; }

    [Column("dataInicio", TypeName = "datetime")]
    public DateTime? DataInicio { get; set; }

    [Column("memoriaUsada")]
    [StringLength(100)]
    [Unicode(false)]
    public string MemoriaUsada { get; set; }

    [Column("processadorUsado")]
    [StringLength(100)]
    [Unicode(false)]
    public string ProcessadorUsado { get; set; }
}