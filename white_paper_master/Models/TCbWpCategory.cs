using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace white_paper_master.Models;

[Table("T_CB_WP_CATEGORY")]
public partial class TCbWpCategory
{
    [Key]
    [Column("CAT_TRANS_ID")]
    public long CatTransId { get; set; }

    [Column("CAT_ID")]
    public int? CatId { get; set; }

    [Column("DISTRICT_CD")]
    [StringLength(10)]
    [Unicode(false)]
    public string? DistrictCd { get; set; }

    [Column("PS_CD")]
    [StringLength(10)]
    [Unicode(false)]
    public string? PsCd { get; set; }

    [Column("YEAR")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Year { get; set; }

    [Column("RECORD_STATUS")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RecordStatus { get; set; }

    [Column("RECORD_CREATED_ON", TypeName = "datetime")]
    public DateTime? RecordCreatedOn { get; set; }
}
