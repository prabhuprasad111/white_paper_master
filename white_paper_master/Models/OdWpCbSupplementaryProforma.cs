using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace white_paper_master.Models;

[Table("OD_WP_CB_SUPPLEMENTARY_PROFORMA")]
public partial class OdWpCbSupplementaryProforma
{
    [Key]
    [Column("SL_NO")]
    public int SlNo { get; set; }

    [Column("SUB_CAT_CD")]
    public int SubCatCd { get; set; }

    [Column("DISTRICT_CD")]
    public int DistrictCd { get; set; }

    [Column("PS_CD")]
    public int? PsCd { get; set; }

    [Column("REG_YEAR")]
    public int? RegYear { get; set; }

    [Column("REG_MONTH")]
    public int? RegMonth { get; set; }

    [Column("CURRENT_YEAR")]
    public int? CurrentYear { get; set; }

    [Column("LAST_YEAR")]
    public int? LastYear { get; set; }

    [Column("LAST_TO_LAST_YEAR")]
    public int? LastToLastYear { get; set; }

    [Column("TA", TypeName = "decimal(6, 2)")]
    public decimal Ta { get; set; }

    [Column("CHARGE_SHEET")]
    public int? ChargeSheet { get; set; }

    [Column("FRT")]
    public int? Frt { get; set; }

    [Column("MF_ML")]
    public int? MfMl { get; set; }

    [Column("PENDING_I")]
    public int? PendingI { get; set; }

    [Column("LCS")]
    public int? Lcs { get; set; }

    [Column("PERCENT_LCS", TypeName = "decimal(6, 2)")]
    public decimal? PercentLcs { get; set; }

    [Column("PERCENT_INC_DEC_TA", TypeName = "decimal(6, 2)")]
    public decimal? PercentIncDecTa { get; set; }

    [Column("ARRESTED_MALE")]
    public int? ArrestedMale { get; set; }

    [Column("ARRESTED_FEMALE")]
    public int? ArrestedFemale { get; set; }

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
