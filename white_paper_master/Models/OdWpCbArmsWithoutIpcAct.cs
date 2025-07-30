using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace white_paper_master.Models;

[Keyless]
[Table("OD_WP_CB_ARMS_WITHOUT_IPC_ACT")]
public partial class OdWpCbArmsWithoutIpcAct
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

    [Column("ARMS_SEIZURE_DESCRIPTION")]
    [StringLength(2000)]
    public string? ArmsSeizureDescription { get; set; }

    [Column("ARREST_TG")]
    public int? ArrestTg { get; set; }

    [Column("CRPC_41_BNSS_35_M")]
    public int? Crpc41Bnss35M { get; set; }

    [Column("CRPC_41_BNSS_35_F")]
    public int? Crpc41Bnss35F { get; set; }

    [Column("CRPC_41_BNSS_35_TG")]
    public int? Crpc41Bnss35Tg { get; set; }

    [Column("Arms_Seizure_Pistol")]
    public int? ArmsSeizurePistol { get; set; }

    [Column("Arms_Seizure_Gun")]
    public int? ArmsSeizureGun { get; set; }

    [Column("Arms_Seizure_Revolver")]
    public int? ArmsSeizureRevolver { get; set; }

    [Column("Arms_Seizure_Mouzer")]
    public int? ArmsSeizureMouzer { get; set; }

    [Column("Arms_Seizure_Rifle")]
    public int? ArmsSeizureRifle { get; set; }

    [Column("Arms_Seizure_AK47")]
    public int? ArmsSeizureAk47 { get; set; }

    [Column("Arms_Seizure_Insas")]
    public int? ArmsSeizureInsas { get; set; }

    [Column("Arms_Seizure_SLR")]
    public int? ArmsSeizureSlr { get; set; }

    [Column("Arms_Seizure_MP5")]
    public int? ArmsSeizureMp5 { get; set; }

    [Column("Arms_Seizure_Others")]
    [StringLength(2000)]
    public string? ArmsSeizureOthers { get; set; }

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
    public string? OthersOthers { get; set; }
}
