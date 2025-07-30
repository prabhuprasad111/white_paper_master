using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace white_paper_master.Models;

[Keyless]
[Table("OD_WP_CB_PENDING_SUP_NOTE")]
public partial class OdWpCbPendingSupNote
{
    [Column("SL_NO")]
    public int SlNo { get; set; }

    [Column("DISTRICT_CD")]
    public int? DistrictCd { get; set; }

    [Column("PS_CD")]
    public int? PsCd { get; set; }

    [Column("REG_YEAR")]
    public int? RegYear { get; set; }

    [Column("REG_MONTH")]
    public int? RegMonth { get; set; }

    [Column("SSP_DCSP")]
    public int? SspDcsp { get; set; }

    [Column("AD_SSP_DCSP")]
    public int? AdSspDcsp { get; set; }

    [Column("DSSP_ACSP")]
    public int? DsspAcsp { get; set; }

    [Column("SDPO")]
    public int? Sdpo { get; set; }

    [Column("ISIC")]
    public int? Isic { get; set; }

    [Column("TOTAL")]
    public int? Total { get; set; }

    [Column("RECORD_STATUS")]
    [StringLength(1)]
    public string? RecordStatus { get; set; }

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
}
