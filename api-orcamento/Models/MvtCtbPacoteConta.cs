﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Models;

[PrimaryKey("CodPacote", "CodConta")]
public partial class MvtCtbPacoteConta
{
    [Key]
    [Column("codPacote")]
    public int CodPacote { get; set; }

    [Key]
    [Column("codConta")]
    public long CodConta { get; set; }
}