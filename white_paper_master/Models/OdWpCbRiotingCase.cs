using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace white_paper_master.Models;

[Keyless]
[Table("OD_WP_CB_RIOTING_CASES")]
public partial class OdWpCbRiotingCase
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

    [Column("CONVICTED")]
    public int? Convicted { get; set; }

    [Column("ACQUITTED")]
    public int? Acquitted { get; set; }

    [Column("DISCHARGED")]
    public int? Discharged { get; set; }

    [Column("WITHDRAWN")]
    public int? Withdrawn { get; set; }

    [Column("COMPOUNDED")]
    public int? Compounded { get; set; }

    [Column("PENDING_TRIAL")]
    public int? PendingTrial { get; set; }

    [Column("FRT")]
    public int? Frt { get; set; }

    [Column("MF_ML")]
    public int? MfMl { get; set; }

    [Column("NON_C")]
    public int? NonC { get; set; }

    [Column("FALSE")]
    public int? False { get; set; }

    [Column("TRANSFER")]
    public int? Transfer { get; set; }

    [Column("PI")]
    public int? Pi { get; set; }

    [Column("LCS")]
    public int? Lcs { get; set; }

    [Column("TRUE_CASES")]
    public int? TrueCases { get; set; }

    [Column("PERC_INC_LCS", TypeName = "decimal(6, 2)")]
    public decimal? PercIncLcs { get; set; }

    [Column("PERC_INC_DEC_YEAR", TypeName = "decimal(6, 2)")]
    public decimal? PercIncDecYear { get; set; }

    [Column("PERC_INC_DEC_TA", TypeName = "decimal(6, 2)")]
    public decimal? PercIncDecTa { get; set; }

    [Column("COMMUNAL")]
    public int? Communal { get; set; }

    [Column("INDUSTRIAL")]
    public int? Industrial { get; set; }

    [Column("POLITICAL")]
    public int? Political { get; set; }

    [Column("CASTEISM")]
    public int? Casteism { get; set; }

    [Column("AGRARIAN")]
    public int? Agrarian { get; set; }

    [Column("STUDENTS")]
    public int? Students { get; set; }

    [Column("VILL_DISPUTE")]
    public int? VillDispute { get; set; }

    [Column("OTHERS")]
    public int? Others { get; set; }

    [Column("ARREST_M")]
    public int? ArrestM { get; set; }

    [Column("ARREST_F")]
    public int? ArrestF { get; set; }

    [Column("SERIOUS_RIOTING")]
    public int? SeriousRioting { get; set; }

    [Column("KILLED_M")]
    public int? KilledM { get; set; }

    [Column("KILLED_F")]
    public int? KilledF { get; set; }

    [Column("S_RIOTING_ARREST_M")]
    public int? SRiotingArrestM { get; set; }

    [Column("S_RIOTING_ARREST_F")]
    public int? SRiotingArrestF { get; set; }

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

    [Column("Final_IE")]
    public int? FinalIe { get; set; }

    [Column("ARREST_TG")]
    public int? ArrestTg { get; set; }

    [Column("CRPC_41A_M")]
    public int? Crpc41aM { get; set; }

    [Column("CRPC_41A_F")]
    public int? Crpc41aF { get; set; }

    [Column("CRPC_41A_TG")]
    public int? Crpc41aTg { get; set; }

    [Column("NO_OF_SERIOUS_RIOTING")]
    public int? NoOfSeriousRioting { get; set; }

    [Column("CASE_REF_IN_SERIOUS_RIOTING")]
    [StringLength(500)]
    public string? CaseRefInSeriousRioting { get; set; }

    [Column("CAUSE")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Cause { get; set; }

    [Column("SOs")]
    [StringLength(500)]
    public string? Sos { get; set; }

    [Column("DIS_OF_SERIOUS_RIOTING_CS")]
    public int? DisOfSeriousRiotingCs { get; set; }

    [Column("DIS_OF_SERIOUS_RIOTING_FRT")]
    public int? DisOfSeriousRiotingFrt { get; set; }

    [Column("DIS_OF_SERIOUS_RIOTING_OD")]
    public int? DisOfSeriousRiotingOd { get; set; }

    [Column("DIS_OF_SERIOUS_RIOTING_PI")]
    public int? DisOfSeriousRiotingPi { get; set; }

    [Column("DIS_OF_SERIOUS_RIOTING_LCS")]
    public int? DisOfSeriousRiotingLcs { get; set; }

    [Column("Final_True")]
    public int? FinalTrue { get; set; }

    [Column("S_RIOTING_ARREST_TG")]
    public int? SRiotingArrestTg { get; set; }

    [Column("REMARKS")]
    [StringLength(100)]
    public string? Remarks { get; set; }

    [Column("KILLED_TG")]
    public int? KilledTg { get; set; }

    [Column("CONVICTION_CS")]
    public int? ConvictionCs { get; set; }
}
