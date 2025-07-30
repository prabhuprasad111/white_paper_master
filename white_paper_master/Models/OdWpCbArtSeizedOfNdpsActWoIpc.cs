using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace white_paper_master.Models;

[Keyless]
[Table("OD_WP_CB_ART_SEIZED_OF_NDPS_ACT_WO_IPC")]
public partial class OdWpCbArtSeizedOfNdpsActWoIpc
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

    [Column("BROWN_SUGAR")]
    [StringLength(200)]
    public string? BrownSugar { get; set; }

    [Column("GANJA")]
    [StringLength(200)]
    public string? Ganja { get; set; }

    [Column("GANJA_PLANT")]
    [StringLength(200)]
    public string? GanjaPlant { get; set; }

    [Column("BHANGA")]
    [StringLength(200)]
    public string? Bhanga { get; set; }

    [Column("OPIUM")]
    [StringLength(200)]
    public string? Opium { get; set; }

    [Column("COUGH_SYRUP")]
    [StringLength(200)]
    public string? CoughSyrup { get; set; }

    [Column("MOBILE")]
    [StringLength(200)]
    public string? Mobile { get; set; }

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

    [Column("Brown_Sugar_KG", TypeName = "decimal(18, 2)")]
    public decimal? BrownSugarKg { get; set; }

    [Column("Brown_Sugar_GM", TypeName = "decimal(18, 2)")]
    public decimal? BrownSugarGm { get; set; }

    [Column("Brown_Sugar_MG", TypeName = "decimal(18, 2)")]
    public decimal? BrownSugarMg { get; set; }

    [Column("Ganja_QNTL", TypeName = "decimal(18, 2)")]
    public decimal? GanjaQntl { get; set; }

    [Column("Ganja_KG", TypeName = "decimal(18, 2)")]
    public decimal? GanjaKg { get; set; }

    [Column("Ganja_GM", TypeName = "decimal(18, 2)")]
    public decimal? GanjaGm { get; set; }

    [Column("Ganja_MG", TypeName = "decimal(18, 2)")]
    public decimal? GanjaMg { get; set; }

    [Column("Bhanga_KG", TypeName = "decimal(18, 2)")]
    public decimal? BhangaKg { get; set; }

    [Column("Bhanga_LTS", TypeName = "decimal(18, 2)")]
    public decimal? BhangaLts { get; set; }

    [Column("Opium_KG", TypeName = "decimal(18, 2)")]
    public decimal? OpiumKg { get; set; }

    [Column("Opium_GM", TypeName = "decimal(18, 2)")]
    public decimal? OpiumGm { get; set; }

    [Column("Opium_MG", TypeName = "decimal(18, 2)")]
    public decimal? OpiumMg { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? Cash { get; set; }
}
