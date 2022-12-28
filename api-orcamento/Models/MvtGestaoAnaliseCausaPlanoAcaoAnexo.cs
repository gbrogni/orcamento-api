﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodEmpresa", "Data", "Identificador", "Sequencia", "SequenciaPlanoAcao", "SequenciaAnexo")]
public partial class MvtGestaoAnaliseCausaPlanoAcaoAnexo
{
    [Key]
    [Column("codEmpresa")]
    public int CodEmpresa { get; set; }

    [Key]
    [Column("data", TypeName = "date")]
    public DateTime Data { get; set; }

    [Key]
    [Column("identificador")]
    [StringLength(50)]
    [Unicode(false)]
    public string Identificador { get; set; }

    [Key]
    [Column("sequencia")]
    public int Sequencia { get; set; }

    [Key]
    [Column("sequenciaPlanoAcao")]
    public int SequenciaPlanoAcao { get; set; }

    [Key]
    [Column("sequenciaAnexo")]
    public int SequenciaAnexo { get; set; }

    [Required]
    [Column("nome")]
    [StringLength(100)]
    [Unicode(false)]
    public string Nome { get; set; }

    [Required]
    [Column("arquivo")]
    public byte[] Arquivo { get; set; }

    [Column("dataCadastro", TypeName = "datetime")]
    public DateTime DataCadastro { get; set; }

    [Required]
    [Column("usuarioCadastro")]
    [StringLength(50)]
    [Unicode(false)]
    public string UsuarioCadastro { get; set; }

    [Column("dataExclusao", TypeName = "datetime")]
    public DateTime? DataExclusao { get; set; }

    [Column("usuarioExclusao")]
    [StringLength(50)]
    [Unicode(false)]
    public string UsuarioExclusao { get; set; }
}