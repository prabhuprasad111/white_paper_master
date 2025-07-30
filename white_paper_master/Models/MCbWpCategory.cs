using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace white_paper_master.Models;

[Table("M_CB_WP_CATEGORY")]
public partial class MCbWpCategory
{
    [Key]
    [Column("CAT_ID")]
    public int CatId { get; set; }

    [Column("CATEGORY")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Category { get; set; }

    [Column("CATEGORY_DES")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CategoryDes { get; set; }

    [Column("RECORD_STATUS")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RecordStatus { get; set; }

    [Column("RECORD_TYPE")]
    [StringLength(200)]
    public string? RecordType { get; set; }

    [Column("ORDER_SEQ")]
    public int? OrderSeq { get; set; }

    [Column("TABLE_NAME")]
    [StringLength(200)]
    public string? TableName { get; set; }

    [Column("MAIN_CAT_ID")]
    public int? MainCatId { get; set; }
}
