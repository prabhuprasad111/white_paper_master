using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace white_paper_master.Models;

[Keyless]
[Table("OD_WP_CB_MV_ACCIDENT_CASES")]
public partial class OdWpCbMvAccidentCase
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

    [Column("ARREST_M")]
    public int? ArrestM { get; set; }

    [Column("ARREST_F")]
    public int? ArrestF { get; set; }

    [Column("NO_OF_PERSON_DIED")]
    public int? NoOfPersonDied { get; set; }

    [Column("NO_OF_PERSON_SUSTAINED_GI")]
    public int? NoOfPersonSustainedGi { get; set; }

    [Column("NO_OF_PERSON_SUSTAINED_SI")]
    public int? NoOfPersonSustainedSi { get; set; }

    [Column("TOT_VAL_OF_PROP_DAMAGED")]
    public int? TotValOfPropDamaged { get; set; }

    [Column("TOT_NO_OF_PR_SUB_IND_DUR_MOB_COURT")]
    public int? TotNoOfPrSubIndDurMobCourt { get; set; }

    [Column("TOT_NO_OF_PR_SUB_IND")]
    public int? TotNoOfPrSubInd { get; set; }

    [Column("NO_OF_PR_SUB_DUR_MOB_COURT")]
    public int? NoOfPrSubDurMobCourt { get; set; }

    [Column("NO_OF_MOB_COURT_HELD")]
    public int? NoOfMobCourtHeld { get; set; }

    [Column("AMT_OF_FINE_REC_DUR_MOB_COURT")]
    public int? AmtOfFineRecDurMobCourt { get; set; }

    [Column("NO_OF_DL_SUSUPENED")]
    public int? NoOfDlSusupened { get; set; }

    [Column("MOB_COURT_HELD_WITH_TRAS_DEPT")]
    public int? MobCourtHeldWithTrasDept { get; set; }

    [Column("NO_OF_VCR_E_CHALLAN_SUB")]
    public int? NoOfVcrEChallanSub { get; set; }

    [Column("AMT_OF_FINE_RELEASED_DUR_VCR")]
    public int? AmtOfFineReleasedDurVcr { get; set; }

    [Column("TRAFFICKING_CHECKING_ORG_OR_ARRE")]
    public int? TraffickingCheckingOrgOrArre { get; set; }

    [Column("ACCI_ON_NAT_HIGH_NO_F_ACC")]
    public int? AcciOnNatHighNoFAcc { get; set; }

    [Column("ACCI_ON_NAT_HIGH_DIED")]
    public int? AcciOnNatHighDied { get; set; }

    [Column("ACCI_ON_NAT_HIGH_GI")]
    public int? AcciOnNatHighGi { get; set; }

    [Column("ACCI_ON_NAT_HIGH_SI")]
    public int? AcciOnNatHighSi { get; set; }

    [Column("ACCI_ON_NAT_HIGH_VAL_F_PRO_DAM")]
    public int? AcciOnNatHighValFProDam { get; set; }

    [Column("ACCI_ON_STATE_HIGH_NO_F_ACC")]
    public int? AcciOnStateHighNoFAcc { get; set; }

    [Column("ACCI_ON_STATE_HIGH_DIED")]
    public int? AcciOnStateHighDied { get; set; }

    [Column("ACCI_ON_STATE_HIGH_GI")]
    public int? AcciOnStateHighGi { get; set; }

    [Column("ACCI_ON_STATE_HIGH_SI")]
    public int? AcciOnStateHighSi { get; set; }

    [Column("ACCI_ON_STATE_HIGH_VAL_F_PRO_DAM")]
    public int? AcciOnStateHighValFProDam { get; set; }

    [Column("ACCI_ON_OTHER_ROADS_NO_F_ACC")]
    public int? AcciOnOtherRoadsNoFAcc { get; set; }

    [Column("ACCI_ON_OTHER_ROADS_DIED")]
    public int? AcciOnOtherRoadsDied { get; set; }

    [Column("ACCI_ON_OTHER_ROADS_GI")]
    public int? AcciOnOtherRoadsGi { get; set; }

    [Column("ACCI_ON_OTHER_ROADS_SI")]
    public int? AcciOnOtherRoadsSi { get; set; }

    [Column("ACCI_ON_OTHER_ROADS_VAL_F_PRO_DAM")]
    public int? AcciOnOtherRoadsValFProDam { get; set; }

    [Column("OTHER_STEPS_TAKEN")]
    [StringLength(1000)]
    public string? OtherStepsTaken { get; set; }

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

    [Column("AMT_FINE_REL_VERS_ECHAL")]
    public int? AmtFineRelVersEchal { get; set; }

    [Column("Final_True")]
    public int? FinalTrue { get; set; }

    [Column("REMARKS")]
    [StringLength(100)]
    public string? Remarks { get; set; }

    [Column("TOT_NO_OF_PR_SUB_IND_MOB_COURT")]
    public int? TotNoOfPrSubIndMobCourt { get; set; }

    [Column("MV_CHECK_ORG")]
    public int? MvCheckOrg { get; set; }

    [Column("CSCONVICTED")]
    public int? Csconvicted { get; set; }

    [Column("No_Of_OUAP")]
    public int? NoOfOuap { get; set; }

    [Column("Fine_Release_in_OUAP")]
    public int? FineReleaseInOuap { get; set; }

    [Column("No_Of_COTPA")]
    public int? NoOfCotpa { get; set; }

    [Column("Fine_Release_in_COTPA")]
    public int? FineReleaseInCotpa { get; set; }
}
