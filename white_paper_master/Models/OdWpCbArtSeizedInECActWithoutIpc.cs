using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace white_paper_master.Models;

[Keyless]
[Table("OD_WP_CB_ART_SEIZED_IN_E_C_ACT_WITHOUT_IPC")]
public partial class OdWpCbArtSeizedInECActWithoutIpc
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

    [Column("K_OIL")]
    [StringLength(50)]
    public string? KOil { get; set; }

    [Column("PETROL")]
    [StringLength(50)]
    public string? Petrol { get; set; }

    [Column("DIESEL")]
    [StringLength(50)]
    public string? Diesel { get; set; }

    [Column("RICE")]
    [StringLength(50)]
    public string? Rice { get; set; }

    [Column("PADDY")]
    [StringLength(50)]
    public string? Paddy { get; set; }

    [Column("WHEAT")]
    [StringLength(50)]
    public string? Wheat { get; set; }

    [Column("FERTILIZER")]
    [StringLength(50)]
    public string? Fertilizer { get; set; }

    [Column("SUGAR")]
    [StringLength(50)]
    public string? Sugar { get; set; }

    [Column("GAS_CYLINDER")]
    [StringLength(50)]
    public string? GasCylinder { get; set; }

    [Column("VEHICLE")]
    [StringLength(50)]
    public string? Vehicle { get; set; }

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

    [Column("VEHICLES_2W")]
    public int? Vehicles2w { get; set; }

    [Column("VEHICLES_3W")]
    public int? Vehicles3w { get; set; }

    [Column("VEHICLES_4W")]
    public int? Vehicles4w { get; set; }

    [Column("VEHICLES_Above")]
    public int? VehiclesAbove { get; set; }
}
