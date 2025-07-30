using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace white_paper_master.Models;

[Keyless]
[Table("OD_WP_CB_DISPOSAL_SLL_UNLAWFUL_ACTIVITY")]
public partial class OdWpCbDisposalSllUnlawfulActivity
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

    [Column("PEND_TRIAL_PRE_YR")]
    public int? PendTrialPreYr { get; set; }

    [Column("SENT_TRIAL_DUR_YR")]
    public int? SentTrialDurYr { get; set; }

    [Column("TOTAL_CASES")]
    public int? TotalCases { get; set; }

    [Column("ABATED_BY_COURT")]
    public int? AbatedByCourt { get; set; }

    [Column("WITDRWN_FR_PROSECUTION")]
    public int? WitdrwnFrProsecution { get; set; }

    [Column("COMPOUND_COMPROMISED")]
    public int? CompoundCompromised { get; set; }

    [Column("DISPOSED_PLEA")]
    public int? DisposedPlea { get; set; }

    [Column("CASH_QUASHED")]
    public int? CashQuashed { get; set; }

    [Column("DISPOSED_WTOUT_TRIAL")]
    public int? DisposedWtoutTrial { get; set; }

    [Column("STAYED_SENT_RCRD_RM")]
    public int? StayedSentRcrdRm { get; set; }

    [Column("CONVICTED_PREV_YR")]
    public int? ConvictedPrevYr { get; set; }

    [Column("CONVICTED_DUR_YR")]
    public int? ConvictedDurYr { get; set; }

    [Column("TOTAL_CONVICTED_CASE")]
    public int? TotalConvictedCase { get; set; }

    [Column("DISCHARGED")]
    public int? Discharged { get; set; }

    [Column("ACQUITTED")]
    public int? Acquitted { get; set; }

    [Column("TRIAL_COMPLETED")]
    public int? TrialCompleted { get; set; }

    [Column("DISPOSED_COURTS")]
    public int? DisposedCourts { get; set; }

    [Column("PEND_TRIAL_END_YR")]
    public int? PendTrialEndYr { get; set; }

    [Column("CONVICTION_RATE", TypeName = "decimal(18, 2)")]
    public decimal? ConvictionRate { get; set; }

    [Column("PENDENCY_PERCENTAGE", TypeName = "decimal(18, 2)")]
    public decimal? PendencyPercentage { get; set; }

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
