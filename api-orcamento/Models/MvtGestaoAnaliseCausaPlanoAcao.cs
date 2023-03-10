// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodEmpresa", "Data", "Identificador", "Sequencia", "SequenciaPlanoAcao")]
public partial class MvtGestaoAnaliseCausaPlanoAcao
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

    [Column("acao")]
    [StringLength(500)]
    [Unicode(false)]
    public string Acao { get; set; }

    [Column("usuarioResponsavel")]
    [StringLength(20)]
    [Unicode(false)]
    public string UsuarioResponsavel { get; set; }

    [Column("dataPrazo", TypeName = "date")]
    public DateTime? DataPrazo { get; set; }

    [Column("situacao")]
    [StringLength(20)]
    [Unicode(false)]
    public string Situacao { get; set; }

    [Column("eficaz")]
    [StringLength(5)]
    [Unicode(false)]
    public string Eficaz { get; set; }

    [Column("dataBaixa", TypeName = "date")]
    public DateTime? DataBaixa { get; set; }

    [Column("observacao")]
    [StringLength(500)]
    [Unicode(false)]
    public string Observacao { get; set; }

    [Column("usuarioCancelamento")]
    [StringLength(20)]
    [Unicode(false)]
    public string UsuarioCancelamento { get; set; }

    [Column("usuarioCadastro")]
    [StringLength(20)]
    [Unicode(false)]
    public string UsuarioCadastro { get; set; }

    [Column("statusPrazo")]
    [StringLength(10)]
    [Unicode(false)]
    public string StatusPrazo { get; set; }
}