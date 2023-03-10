// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodVisao", "CodObjeto", "CodIndicador")]
public partial class MvtGestaoPainelVisaoObjetoIndicador
{
    [Key]
    [Column("codVisao")]
    public int CodVisao { get; set; }

    [Key]
    [Column("codObjeto")]
    public int CodObjeto { get; set; }

    [Key]
    [Column("codIndicador")]
    public int CodIndicador { get; set; }

    [Column("descricao")]
    [StringLength(100)]
    [Unicode(false)]
    public string Descricao { get; set; }

    [Column("agrupamento")]
    [StringLength(50)]
    [Unicode(false)]
    public string Agrupamento { get; set; }

    [Column("coluna")]
    [StringLength(50)]
    [Unicode(false)]
    public string Coluna { get; set; }

    [Column("codEmpresa")]
    public int? CodEmpresa { get; set; }

    [Column("codModelo")]
    public int? CodModelo { get; set; }

    [Column("codGrupo")]
    public int? CodGrupo { get; set; }

    [Column("codItem")]
    public int? CodItem { get; set; }

    [Column("corFundo")]
    [StringLength(50)]
    [Unicode(false)]
    public string CorFundo { get; set; }

    [Column("base")]
    [StringLength(50)]
    [Unicode(false)]
    public string Base { get; set; }

    [Column("periodo")]
    [StringLength(50)]
    [Unicode(false)]
    public string Periodo { get; set; }

    [Column("intervalo")]
    public double? Intervalo { get; set; }

    [Column("ordem")]
    public double? Ordem { get; set; }

    [Column("exibicao")]
    [StringLength(50)]
    [Unicode(false)]
    public string Exibicao { get; set; }

    [Column("tipoIndicador")]
    [StringLength(50)]
    [Unicode(false)]
    public string TipoIndicador { get; set; }

    [Column("codModeloDRE")]
    public int? CodModeloDre { get; set; }

    [Column("codContaDRE")]
    public int? CodContaDre { get; set; }

    [Column("codModeloGerencial")]
    public int? CodModeloGerencial { get; set; }

    [Column("codIndicadorGerencial")]
    public int? CodIndicadorGerencial { get; set; }

    [Column("periodoExibicao")]
    [StringLength(50)]
    [Unicode(false)]
    public string PeriodoExibicao { get; set; }

    [Column("tipoSerie")]
    [StringLength(50)]
    [Unicode(false)]
    public string TipoSerie { get; set; }

    [Column("periodoAnterior")]
    public int? PeriodoAnterior { get; set; }

    [Column("periodoAnteriorAnos")]
    public int? PeriodoAnteriorAnos { get; set; }

    [Column("mostrarValorGrafico")]
    public int? MostrarValorGrafico { get; set; }

    [Column("resultadoAcumulado")]
    public int? ResultadoAcumulado { get; set; }

    [Column("criaTrendLine")]
    public int? CriaTrendLine { get; set; }

    [Column("inverteValor")]
    public int? InverteValor { get; set; }
}