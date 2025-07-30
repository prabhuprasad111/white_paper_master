using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace white_paper_master.Models;

[Keyless]
[Table("OD_WP_CB_ART_SEIZED_IN_GAMBLING_WO_IPC")]
public partial class OdWpCbArtSeizedInGamblingWoIpc
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

    [Column("CASH")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Cash { get; set; }

    [Column("PLAYING_CARD_POCKET")]
    public int? PlayingCardPocket { get; set; }

    [Column("PLAYING_CARD_LOOSE")]
    public int? PlayingCardLoose { get; set; }

    [Column("GOTI")]
    public int? Goti { get; set; }

    [Column("PALI_PATI")]
    public int? PaliPati { get; set; }

    [Column("DICE")]
    public int? Dice { get; set; }

    [Column("SATTA_PAPER")]
    public int? SattaPaper { get; set; }

    [Column("MOBILE_PH")]
    public int? MobilePh { get; set; }

    [Column("LIGHT_PETROMAX")]
    public int? LightPetromax { get; set; }

    [Column("LIGHT_GAS")]
    public int? LightGas { get; set; }

    [Column("VEHICLE_2W")]
    public int? Vehicle2w { get; set; }

    [Column("VEHICLE_3W")]
    public int? Vehicle3w { get; set; }

    [Column("VEHICLE_4W")]
    public int? Vehicle4w { get; set; }

    [Column("ABOVE")]
    public int? Above { get; set; }

    [Column("CYCLE")]
    public int? Cycle { get; set; }

    [Column("OTHERS")]
    [StringLength(200)]
    public string? Others { get; set; }

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

    [Column("Light_Charge")]
    public int? LightCharge { get; set; }
}
