using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace white_paper_master.Models;

[Keyless]
[Table("OD_WP_CB_CYBER_CRIME_REL_HACKING_F")]
public partial class OdWpCbCyberCrimeRelHackingF
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

    [Column("OTHR_DISPO")]
    public int? OthrDispo { get; set; }

    [Column("PI")]
    public int? Pi { get; set; }

    [Column("LCS")]
    public int? Lcs { get; set; }

    [Column("ARR_IN_STATE_M")]
    public int? ArrInStateM { get; set; }

    [Column("ARR_IN_STATE_F")]
    public int? ArrInStateF { get; set; }

    [Column("ARR_O_STATE_ARR_M")]
    public int? ArrOStateArrM { get; set; }

    [Column("ARR_O_STATE_ARR_F")]
    public int? ArrOStateArrF { get; set; }

    [Column("ARR_O_COUNT_ARR_M")]
    public int? ArrOCountArrM { get; set; }

    [Column("ARR_O_COUNT_ARR_F")]
    public int? ArrOCountArrF { get; set; }

    [Column("INV_IN_STATE_M")]
    public int? InvInStateM { get; set; }

    [Column("INV_IN_STATE_F")]
    public int? InvInStateF { get; set; }

    [Column("INV_O_STATE_ARR_M")]
    public int? InvOStateArrM { get; set; }

    [Column("INV_O_STATE_ARR_F")]
    public int? InvOStateArrF { get; set; }

    [Column("INV_O_COUNT_ARR_M")]
    public int? InvOCountArrM { get; set; }

    [Column("INV_O_COUNT_ARR_F")]
    public int? InvOCountArrF { get; set; }

    [Column("PROP_STOLEN", TypeName = "decimal(18, 2)")]
    public decimal? PropStolen { get; set; }

    [Column("PROP_RECO", TypeName = "decimal(18, 2)")]
    public decimal? PropReco { get; set; }

    [Column("PROP_FROZE", TypeName = "decimal(18, 2)")]
    public decimal? PropFroze { get; set; }

    [Column("DOS_ATTACK")]
    public int? DosAttack { get; set; }

    [Column("WEB_DEFACE")]
    public int? WebDeface { get; set; }

    [Column("MALWARE_ATT")]
    public int? MalwareAtt { get; set; }

    [Column("DATA_THEFT")]
    public int? DataTheft { get; set; }

    [Column("DATA_ALTER")]
    public int? DataAlter { get; set; }

    [Column("OTHR_HAC_CRIME")]
    public int? OthrHacCrime { get; set; }

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

    [Column("OTHER")]
    public int? Other { get; set; }

    [Column("ARR_IN_STATE_TG")]
    public int? ArrInStateTg { get; set; }

    [Column("ARR_O_STATE_ARR_TG")]
    public int? ArrOStateArrTg { get; set; }

    [Column("ARR_O_COUNT_ARR_TG")]
    public int? ArrOCountArrTg { get; set; }

    [Column("INV_IN_STATE_TG")]
    public int? InvInStateTg { get; set; }

    [Column("INV_O_STATE_ARR_TG")]
    public int? InvOStateArrTg { get; set; }

    [Column("INV_O_COUNT_ARR_TG")]
    public int? InvOCountArrTg { get; set; }

    [Column("MF_ML_NC_False_transfer")]
    public int? MfMlNcFalseTransfer { get; set; }

    [Column("TAMPERING_COMP_DOC")]
    public int? TamperingCompDoc { get; set; }
}
