using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace white_paper_master.Models;

[Keyless]
[Table("OD_WP_CB_RAPE_CASES")]
public partial class OdWpCbRapeCase
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

    [Column("GANG_RAPE")]
    public int? GangRape { get; set; }

    [Column("SC_SC_GIRLS_VICTIM")]
    public int? ScScGirlsVictim { get; set; }

    [Column("REFUSAL_MARRY_AFT_S")]
    public int? RefusalMarryAftS { get; set; }

    [Column("REFUSAL_MARRY_AFT_C")]
    public int? RefusalMarryAftC { get; set; }

    [Column("RAPE_BY_RELATION")]
    public int? RapeByRelation { get; set; }

    [Column("RAPE_OVER_MINORS")]
    public int? RapeOverMinors { get; set; }

    [Column("CUSTODIAL_RAPE_BY_P")]
    public int? CustodialRapeByP { get; set; }

    [Column("CUSTODIAL_RAPE_BY_J")]
    public int? CustodialRapeByJ { get; set; }

    [Column("CUSTODIAL_RAPE_BY_D")]
    public int? CustodialRapeByD { get; set; }

    [Column("CUSTODIAL_RAPE_BY_O")]
    public int? CustodialRapeByO { get; set; }

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

    [Column("RAPE_RUNNING_VEHICLE")]
    public int? RapeRunningVehicle { get; set; }

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

    [Column("KIDN_TURNED_RAPE_MAJOR")]
    public int? KidnTurnedRapeMajor { get; set; }

    [Column("KIDN_TURNED_RAPE_MINOR")]
    public int? KidnTurnedRapeMinor { get; set; }

    [Column("Final_True")]
    public int? FinalTrue { get; set; }

    [Column("KIDN_TURNED_RAPE_TOTAL")]
    public int? KidnTurnedRapeTotal { get; set; }

    [Column("REMARKS")]
    [StringLength(100)]
    public string? Remarks { get; set; }

    [Column("CSCONVICTED")]
    public int? Csconvicted { get; set; }
}
