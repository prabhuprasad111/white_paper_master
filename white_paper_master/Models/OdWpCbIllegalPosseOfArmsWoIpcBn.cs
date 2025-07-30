using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace white_paper_master.Models;

[Keyless]
[Table("OD_WP_CB_ILLEGAL_POSSE_OF_ARMS_WO_IPC_BNS")]
public partial class OdWpCbIllegalPosseOfArmsWoIpcBn
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

    [Column("CASES_REGD")]
    public int? CasesRegd { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(2000)]
    public string? Description { get; set; }

    [Column("STEPS_TAKEN_RECO")]
    [StringLength(2000)]
    public string? StepsTakenReco { get; set; }

    [Column("RECORD_STATUS")]
    [StringLength(1)]
    [Unicode(false)]
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

    [Column("Seizure_Pistol")]
    public int? SeizurePistol { get; set; }

    [Column("Seizure_Gun")]
    public int? SeizureGun { get; set; }

    [Column("Seizure_Revolver")]
    public int? SeizureRevolver { get; set; }

    [Column("Seizure_Mouzer")]
    public int? SeizureMouzer { get; set; }

    [Column("Seizure_Rifle")]
    public int? SeizureRifle { get; set; }

    [Column("Seizure_AK47")]
    public int? SeizureAk47 { get; set; }

    [Column("Seizure_Insas")]
    public int? SeizureInsas { get; set; }

    [Column("Seizure_SLR")]
    public int? SeizureSlr { get; set; }

    [Column("Seizure_MP5")]
    public int? SeizureMp5 { get; set; }

    [Column("Seizure_Others")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? SeizureOthers { get; set; }

    public int? Ammunitions { get; set; }

    [Column("Others_catridge")]
    public int? OthersCatridge { get; set; }

    [Column("Others_Magazine")]
    public int? OthersMagazine { get; set; }

    [Column("Others_Sword")]
    public int? OthersSword { get; set; }

    [Column("Others_Knife")]
    public int? OthersKnife { get; set; }

    [Column("Others_Bhujali")]
    public int? OthersBhujali { get; set; }

    [Column("Others_Others")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? OthersOthers { get; set; }
}
