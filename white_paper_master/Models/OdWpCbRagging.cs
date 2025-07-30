using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace white_paper_master.Models;

[Keyless]
[Table("OD_WP_CB_RAGGING")]
public partial class OdWpCbRagging
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

    [Column("CURRENT_YEAR")]
    public int? CurrentYear { get; set; }

    [Column("LAST_YEAR")]
    public int? LastYear { get; set; }

    [Column("LAST_LAST_YEAR")]
    public int? LastLastYear { get; set; }

    [Column("TA", TypeName = "decimal(6, 2)")]
    public decimal? Ta { get; set; }

    [Column("CS")]
    public int? Cs { get; set; }

    [Column("FRT")]
    public int? Frt { get; set; }

    [Column("MF_ML")]
    public int? MfMl { get; set; }

    [Column("PI")]
    public int? Pi { get; set; }

    [Column("LCS")]
    public int? Lcs { get; set; }

    [Column("PERC_INC_LCS", TypeName = "decimal(6, 2)")]
    public decimal? PercIncLcs { get; set; }

    [Column("PERC_INC_DEC_TA", TypeName = "decimal(6, 2)")]
    public decimal? PercIncDecTa { get; set; }

    [Column("ARREST_M")]
    public int? ArrestM { get; set; }

    [Column("ARREST_F")]
    public int? ArrestF { get; set; }

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

    [Column("ARREST_TG")]
    public int? ArrestTg { get; set; }

    [Column("CRPC_41_BNSS_35_M")]
    public int? Crpc41Bnss35M { get; set; }

    [Column("CRPC_41_BNSS_35_F")]
    public int? Crpc41Bnss35F { get; set; }

    [Column("CRPC_41_BNSS_35_TG")]
    public int? Crpc41Bnss35Tg { get; set; }
}
