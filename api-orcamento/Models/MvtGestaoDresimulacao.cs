﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[Table("MvtGestaoDRESimulacao")]
public partial class MvtGestaoDresimulacao
{
    [Key]
    [Column("idSimulacao")]
    public int IdSimulacao { get; set; }

    [Column("descricao")]
    [StringLength(150)]
    [Unicode(false)]
    public string Descricao { get; set; }

    [Column("numeroOrcamento")]
    public int? NumeroOrcamento { get; set; }

    [Column("dataInicio", TypeName = "date")]
    public DateTime? DataInicio { get; set; }

    [Column("dataFim", TypeName = "date")]
    public DateTime? DataFim { get; set; }

    [Column("ultCodModeloSimulado")]
    public int? UltCodModeloSimulado { get; set; }

    [Column("comentarios")]
    [StringLength(5000)]
    [Unicode(false)]
    public string Comentarios { get; set; }

    [Column("usuarioGeracao")]
    [StringLength(50)]
    [Unicode(false)]
    public string UsuarioGeracao { get; set; }

    [Column("dataGeracao", TypeName = "date")]
    public DateTime? DataGeracao { get; set; }

    [Column("tipo")]
    [StringLength(50)]
    [Unicode(false)]
    public string Tipo { get; set; }

    [Column("dataInicioProjecao", TypeName = "date")]
    public DateTime? DataInicioProjecao { get; set; }
}