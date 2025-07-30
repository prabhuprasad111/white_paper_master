using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace white_paper_master.Models;

[Keyless]
[Table("OD_WP_CB_ART_SEIZED_IN_EXCISE")]
public partial class OdWpCbArtSeizedInExcise
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

    [Column("I_D_LIQUORE")]
    [StringLength(50)]
    public string? IDLiquore { get; set; }

    [Column("COUNRTY_LIQUORE")]
    [StringLength(50)]
    public string? CounrtyLiquore { get; set; }

    [Column("MAHUA_LIQUORE")]
    [StringLength(50)]
    public string? MahuaLiquore { get; set; }

    [Column("FORIGN_LIQUORE_BOTTLE")]
    [StringLength(50)]
    public string? ForignLiquoreBottle { get; set; }

    [Column("FORIGN_LIQUORE_LOOSE")]
    [StringLength(50)]
    public string? ForignLiquoreLoose { get; set; }

    [Column("BEER")]
    [StringLength(50)]
    public string? Beer { get; set; }

    [Column("ASKA_40")]
    [StringLength(50)]
    public string? Aska40 { get; set; }

    [Column("TADI")]
    [StringLength(50)]
    public string? Tadi { get; set; }

    [Column("SALAD")]
    [StringLength(50)]
    public string? Salad { get; set; }

    [Column("BHANGA")]
    [StringLength(50)]
    public string? Bhanga { get; set; }

    [Column("VEHICLE_2W")]
    public int? Vehicle2w { get; set; }

    [Column("VEHICLE_3W")]
    public int? Vehicle3w { get; set; }

    [Column("VEHICLE_4W")]
    public int? Vehicle4w { get; set; }

    [Column("ABOVE")]
    public int? Above { get; set; }

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

    [Column("Country_liquor_Ltr", TypeName = "decimal(18, 2)")]
    public decimal? CountryLiquorLtr { get; set; }

    [Column("Country_liquor_Pouch_nos")]
    public int? CountryLiquorPouchNos { get; set; }

    [Column("FL_Loose_Ltrs", TypeName = "decimal(18, 2)")]
    public decimal? FlLooseLtrs { get; set; }

    [Column("FL_Loose_Ml", TypeName = "decimal(18, 2)")]
    public decimal? FlLooseMl { get; set; }

    [Column("Beer_Bottles")]
    public int? BeerBottles { get; set; }

    [Column("Beer_Ltrs", TypeName = "decimal(18, 2)")]
    public decimal? BeerLtrs { get; set; }

    [Column("Aska40_Ltr", TypeName = "decimal(18, 2)")]
    public decimal? Aska40Ltr { get; set; }

    [Column("Aska40_Pouch_nos")]
    public int? Aska40PouchNos { get; set; }

    [Column("Bhanga_kg", TypeName = "decimal(18, 2)")]
    public decimal? BhangaKg { get; set; }

    [Column("Bhanga_gm", TypeName = "decimal(18, 2)")]
    public decimal? BhangaGm { get; set; }

    [Column("Bhanga_Paste_Liquid_ltrs", TypeName = "decimal(18, 2)")]
    public decimal? BhangaPasteLiquidLtrs { get; set; }

    [Column("Mobile_Nos")]
    public int? MobileNos { get; set; }
}
