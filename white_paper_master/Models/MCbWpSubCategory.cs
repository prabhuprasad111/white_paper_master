using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace white_paper_master.Models;

[PrimaryKey("SubCatCd", "LangCd")]
[Table("M_CB_WP_SUB_CATEGORY")]
public partial class MCbWpSubCategory
{
    [Key]
    [Column("SUB_CAT_CD")]
    public int SubCatCd { get; set; }

    [Key]
    [Column("LANG_CD")]
    public int LangCd { get; set; }

    [Column("SUB_CATEGORY")]
    [StringLength(200)]
    public string? SubCategory { get; set; }

    [Column("SUB_CATEGORY_DES")]
    [StringLength(200)]
    public string? SubCategoryDes { get; set; }

    [Column("SECTION_CD_IN")]
    [StringLength(800)]
    public string? SectionCdIn { get; set; }

    [Column("SECTION_CD_NOT_IN")]
    [StringLength(800)]
    public string? SectionCdNotIn { get; set; }

    [Column("MAJORHEAD_CD")]
    public int MajorheadCd { get; set; }

    [Column("MAJORHEAD")]
    [StringLength(100)]
    public string Majorhead { get; set; } = null!;

    [Column("RECORD_STATUS")]
    [StringLength(1)]
    public string? RecordStatus { get; set; }

    [Column("RECORD_TYPE")]
    public int? RecordType { get; set; }

    [Column("RECORD_CREATED_ON", TypeName = "datetime")]
    public DateTime? RecordCreatedOn { get; set; }

    [Column("RECORD_CREATED_BY")]
    [StringLength(50)]
    public string? RecordCreatedBy { get; set; }

    [Column("RECORD_UPDATED_ON", TypeName = "datetime")]
    public DateTime? RecordUpdatedOn { get; set; }

    [Column("RECORD_UPDATED_BY")]
    [StringLength(50)]
    public string? RecordUpdatedBy { get; set; }

    [Column("DUMMY_COLUMN_1")]
    [StringLength(30)]
    public string? DummyColumn1 { get; set; }

    [Column("DUMMY_COLUMN_2")]
    [StringLength(50)]
    public string? DummyColumn2 { get; set; }

    [Column("ORIGINAL_RECORD")]
    public int OriginalRecord { get; set; }
}
