// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodEmpresa", "CodPlanoMeta")]
public partial class MvtVendasCadastroPlanoMeta
{
    [Key]
    [Column("codEmpresa")]
    public int CodEmpresa { get; set; }

    [Key]
    [Column("codPlanoMeta")]
    public int CodPlanoMeta { get; set; }

    [Column("descricaoPlanoMeta")]
    [StringLength(150)]
    [Unicode(false)]
    public string DescricaoPlanoMeta { get; set; }

    [Column("oficial")]
    public int? Oficial { get; set; }
}