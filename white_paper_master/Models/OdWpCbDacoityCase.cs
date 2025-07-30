using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace white_paper_master.Models;

[Table("OD_WP_CB_DACOITY_CASES")]
public partial class OdWpCbDacoityCase
{
    [Key]
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
    public int Cs { get; set; }

    [Column("CONVICTED")]
    public int Convicted { get; set; }

    [Column("ACQUITTED")]
    public int Acquitted { get; set; }

    [Column("DISCHARGED")]
    public int Discharged { get; set; }

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

    [Column("RESIDENT_PREM")]
    public int? ResidentPrem { get; set; }

    [Column("ON_HIGHWAY")]
    public int? OnHighway { get; set; }

    [Column("IN_BANK")]
    public int? InBank { get; set; }

    [Column("IN_TRAIN")]
    public int? InTrain { get; set; }

    [Column("COMMERCIAL_PLACES")]
    public int? CommercialPlaces { get; set; }

    [Column("OTHER_PLACES")]
    public int? OtherPlaces { get; set; }

    [Column("ATTEMPT_PREP")]
    public int? AttemptPrep { get; set; }

    [Column("BY_GANG")]
    public int? ByGang { get; set; }

    [Column("INTER_STATE_CRIM_INV")]
    public int? InterStateCrimInv { get; set; }

    [Column("POL_ENCT_DUR_OP")]
    public int? PolEnctDurOp { get; set; }

    [Column("CRIMINAL_Killed")]
    public int? CriminalKilled { get; set; }

    [Column("CRIMINAL_INJURED")]
    public int? CriminalInjured { get; set; }

    [Column("INMATE_KILLED")]
    public int? InmateKilled { get; set; }

    [Column("INMATE_INJURED")]
    public int? InmateInjured { get; set; }

    [Column("OUTSIDERS_KILLED")]
    public int? OutsidersKilled { get; set; }

    [Column("OUTSIDERS_INJURED")]
    public int? OutsidersInjured { get; set; }

    [Column("POLICE_KILLED")]
    public int? PoliceKilled { get; set; }

    [Column("POLICE_INJURED")]
    public int? PoliceInjured { get; set; }

    [Column("FIREARMS_USED")]
    public int? FirearmsUsed { get; set; }

    [Column("FIREARMS_STOLEN")]
    public int? FirearmsStolen { get; set; }

    [Column("FIREARMS_RECOVERY")]
    [StringLength(1000)]
    public string? FirearmsRecovery { get; set; }

    [Column("ARREST_M")]
    public int? ArrestM { get; set; }

    [Column("ARREST_F")]
    public int? ArrestF { get; set; }

    [Column("AMT_PROP_STOLEN")]
    public int? AmtPropStolen { get; set; }

    [Column("AMT_PROP_RECOVERED")]
    public int? AmtPropRecovered { get; set; }

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

    [Column("Final_True")]
    public int? FinalTrue { get; set; }

    [Column("Final_IE")]
    public int? FinalIe { get; set; }

    [Column("INTER_STATE_CRIM_ARRESTED")]
    public int? InterStateCrimArrested { get; set; }

    [Column("CRPC_41A_M")]
    public int? Crpc41aM { get; set; }

    [Column("CRPC_41A_F")]
    public int? Crpc41aF { get; set; }

    [Column("CRPC_41A_TG")]
    public int? Crpc41aTg { get; set; }

    [Column("ARREST_TG")]
    public int? ArrestTg { get; set; }

    [Column("REMARKS")]
    [StringLength(100)]
    public string? Remarks { get; set; }

    [Column("CONVICTION_CS")]
    public int? ConvictionCs { get; set; }
}
