using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace white_paper_master.Models;

[Keyless]
[Table("OD_WP_CB_CYBER_CRIME_REL_SOCIAL_MEDIA_F")]
public partial class OdWpCbCyberCrimeRelSocialMediaF
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

    [Column("MEN_67_A_FB")]
    public int? Men67AFb { get; set; }

    [Column("MEN_67_A_INSTA")]
    public int? Men67AInsta { get; set; }

    [Column("MEN_67_A_TWIT")]
    public int? Men67ATwit { get; set; }

    [Column("MEN_67_A_YT")]
    public int? Men67AYt { get; set; }

    [Column("MEN_67_A_PRON")]
    public int? Men67APron { get; set; }

    [Column("MEN_67_A_OTHER")]
    public int? Men67AOther { get; set; }

    [Column("MEN_67_B_FB")]
    public int? Men67BFb { get; set; }

    [Column("MEN_67_B_INSTA")]
    public int? Men67BInsta { get; set; }

    [Column("MEN_67_B_TWIT")]
    public int? Men67BTwit { get; set; }

    [Column("MEN_67_B_YT")]
    public int? Men67BYt { get; set; }

    [Column("MEN_67_B_PRON")]
    public int? Men67BPron { get; set; }

    [Column("MEN_67_B_OTHER")]
    public int? Men67BOther { get; set; }

    [Column("MEN_67_FB")]
    public int? Men67Fb { get; set; }

    [Column("MEN_67_INSTA")]
    public int? Men67Insta { get; set; }

    [Column("MEN_67_TWIT")]
    public int? Men67Twit { get; set; }

    [Column("MEN_67_YT")]
    public int? Men67Yt { get; set; }

    [Column("MEN_67_PRON")]
    public int? Men67Pron { get; set; }

    [Column("MEN_67_OTHER")]
    public int? Men67Other { get; set; }

    [Column("MEN_66_C_FB")]
    public int? Men66CFb { get; set; }

    [Column("MEN_66_C_INSTA")]
    public int? Men66CInsta { get; set; }

    [Column("MEN_66_C_TWIT")]
    public int? Men66CTwit { get; set; }

    [Column("MEN_66_C_YT")]
    public int? Men66CYt { get; set; }

    [Column("MEN_66_C_PRON")]
    public int? Men66CPron { get; set; }

    [Column("MEN_66_C_OTHER")]
    public int? Men66COther { get; set; }

    [Column("WOMEN_67_A_FB")]
    public int? Women67AFb { get; set; }

    [Column("WOMEN_67_A_INSTA")]
    public int? Women67AInsta { get; set; }

    [Column("WOMEN_67_A_TWIT")]
    public int? Women67ATwit { get; set; }

    [Column("WOMEN_67_A_YT")]
    public int? Women67AYt { get; set; }

    [Column("WOMEN_67_A_PRON")]
    public int? Women67APron { get; set; }

    [Column("WOMEN_67_A_OTHER")]
    public int? Women67AOther { get; set; }

    [Column("WOMEN_67_B_FB")]
    public int? Women67BFb { get; set; }

    [Column("WOMEN_67_B_INSTA")]
    public int? Women67BInsta { get; set; }

    [Column("WOMEN_67_B_TWIT")]
    public int? Women67BTwit { get; set; }

    [Column("WOMEN_67_B_YT")]
    public int? Women67BYt { get; set; }

    [Column("WOMEN_67_B_PRON")]
    public int? Women67BPron { get; set; }

    [Column("WOMEN_67_B_OTHER")]
    public int? Women67BOther { get; set; }

    [Column("WOMEN_67_FB")]
    public int? Women67Fb { get; set; }

    [Column("WOMEN_67_INSTA")]
    public int? Women67Insta { get; set; }

    [Column("WOMEN_67_TWIT")]
    public int? Women67Twit { get; set; }

    [Column("WOMEN_67_YT")]
    public int? Women67Yt { get; set; }

    [Column("WOMEN_67_PRON")]
    public int? Women67Pron { get; set; }

    [Column("WOMEN_67_OTHER")]
    public int? Women67Other { get; set; }

    [Column("WOMEN_66_C_FB")]
    public int? Women66CFb { get; set; }

    [Column("WOMEN_66_C_INSTA")]
    public int? Women66CInsta { get; set; }

    [Column("WOMEN_66_C_TWIT")]
    public int? Women66CTwit { get; set; }

    [Column("WOMEN_66_C_YT")]
    public int? Women66CYt { get; set; }

    [Column("WOMEN_66_C_PRON")]
    public int? Women66CPron { get; set; }

    [Column("WOMEN_66_C_OTHER")]
    public int? Women66COther { get; set; }

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

    [Column("OTHER_MEN")]
    public int? OtherMen { get; set; }

    [Column("OTHER_WOMEN")]
    public int? OtherWomen { get; set; }

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

    [Column("FOR_WOMEN_OTHER")]
    public int? ForWomenOther { get; set; }

    [Column("FOR_MEN_OTHER")]
    public int? ForMenOther { get; set; }
}
