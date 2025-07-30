using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace white_paper_master.Models;

[Keyless]
[Table("OD_WP_CB_SUPPLIMENTARY_F_UD")]
public partial class OdWpCbSupplimentaryFUd
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

    [Column("TOTAL_CASES_YEAR")]
    public int? TotalCasesYear { get; set; }

    [Column("TURNED_TO_COG")]
    public int? TurnedToCog { get; set; }

    [Column("TURNED_TO_MURDER")]
    public int? TurnedToMurder { get; set; }

    [Column("PEN_ENQUIRY")]
    public int? PenEnquiry { get; set; }

    [Column("SUICIDAL_POISIONING")]
    public int? SuicidalPoisioning { get; set; }

    [Column("SUICIDAL_DROWNING")]
    public int? SuicidalDrowning { get; set; }

    [Column("SUICIDAL_BURNING")]
    public int? SuicidalBurning { get; set; }

    [Column("SUICIDAL_HANGING")]
    public int? SuicidalHanging { get; set; }

    [Column("SUICIDAL_GUNSHOT")]
    public int? SuicidalGunshot { get; set; }

    [Column("SUICIDAL_RUN_OVR_TRAIN")]
    public int? SuicidalRunOvrTrain { get; set; }

    [Column("SUICIDAL_VIDEO_VIR")]
    public int? SuicidalVideoVir { get; set; }

    [Column("ACCI_DROWNING")]
    public int? AcciDrowning { get; set; }

    [Column("ACCI_BURNING")]
    public int? AcciBurning { get; set; }

    [Column("ACCI_ELEC_SHOCK")]
    public int? AcciElecShock { get; set; }

    [Column("ACCI_R_OVR_TRAIN")]
    public int? AcciROvrTrain { get; set; }

    [Column("ACCI_VEH_ACCI_TRAIN")]
    public int? AcciVehAcciTrain { get; set; }

    [Column("ACCI_EARTH_COL")]
    public int? AcciEarthCol { get; set; }

    [Column("ACCI_GUN_SHOT")]
    public int? AcciGunShot { get; set; }

    [Column("ACCI_SUN_STROKE")]
    public int? AcciSunStroke { get; set; }

    [Column("ACCI_LIGHTNING")]
    public int? AcciLightning { get; set; }

    [Column("ACCI_HEART_ATT")]
    public int? AcciHeartAtt { get; set; }

    [Column("ACCI_FALL")]
    public int? AcciFall { get; set; }

    [Column("EPILEPTIC_FITS")]
    public int? EpilepticFits { get; set; }

    [Column("EXCESSIVE_DRINKS")]
    public int? ExcessiveDrinks { get; set; }

    [Column("EXCESSIVE_COLD")]
    public int? ExcessiveCold { get; set; }

    [Column("FOOD_POISIONING")]
    public int? FoodPoisioning { get; set; }

    [Column("OVR_DOSE_MED")]
    public int? OvrDoseMed { get; set; }

    [Column("EXPLOSIVE")]
    public int? Explosive { get; set; }

    [Column("FALL_IN_WELL")]
    public int? FallInWell { get; set; }

    [Column("FALL_FRM_WALL")]
    public int? FallFrmWall { get; set; }

    [Column("FALL_FRM_HIGH")]
    public int? FallFrmHigh { get; set; }

    [Column("FALL_FRM_TRAIN")]
    public int? FallFrmTrain { get; set; }

    [Column("KIILL_WILD_ANI")]
    public int? KiillWildAni { get; set; }

    [Column("INSECT_BITE")]
    public int? InsectBite { get; set; }

    [Column("DOG_BITE")]
    public int? DogBite { get; set; }

    [Column("ATT_BY_BULLOCK")]
    public int? AttByBullock { get; set; }

    [Column("CROCODILE_BITE")]
    public int? CrocodileBite { get; set; }

    [Column("BEER_BITE")]
    public int? BeerBite { get; set; }

    [Column("TIGER_BITE")]
    public int? TigerBite { get; set; }

    [Column("SNAKE_BITE")]
    public int? SnakeBite { get; set; }

    [Column("ELEPHANT_ATT")]
    public int? ElephantAtt { get; set; }

    [Column("OLD_AGE_DISE")]
    public int? OldAgeDise { get; set; }

    [Column("NATURAL_CAUSE")]
    public int? NaturalCause { get; set; }

    [Column("CAUSE_NOT_KNO")]
    public int? CauseNotKno { get; set; }

    [Column("OTHER")]
    public int? Other { get; set; }

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

    [Column("RATH_WHEEL")]
    public int? RathWheel { get; set; }

    [Column("ATTACK_BULLOCK")]
    public int? AttackBullock { get; set; }

    [Column("SUICIDAL_Total")]
    public int? SuicidalTotal { get; set; }

    [Column("ACCIDENTAL_Excesive_dring")]
    public int? AccidentalExcesiveDring { get; set; }
}
