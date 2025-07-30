using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace white_paper_master.Models;

[Table("M_CB_WP_MAIN_CATEGORY")]
public partial class MCbWpMainCategory
{
    [Key]
    [Column("MAIN_CAT_ID")]
    public int MainCatId { get; set; }

    [Column("MAIN_CATEGORY")]
    [StringLength(200)]
    [Unicode(false)]
    public string? MainCategory { get; set; }

    [Column("MAIN_CATEGORY_DES")]
    [StringLength(100)]
    [Unicode(false)]
    public string? MainCategoryDes { get; set; }

    [Column("RECORD_STATUS")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RecordStatus { get; set; }

    [Column("RECORD_TYPE")]
    [StringLength(200)]
    public string? RecordType { get; set; }

    [Column("ORDER_SEQ")]
    public int? OrderSeq { get; set; }
}
