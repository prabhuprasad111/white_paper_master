using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace white_paper_master.Models;

[Keyless]
[Table("OD_WP_CB_SEIZED_EC_ART_IPC")]
public partial class OdWpCbSeizedEcArtIpc
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

    [Column("K.OIL")]
    public int? KOil { get; set; }

    [Column("PETROL")]
    public int? Petrol { get; set; }

    [Column("DIESEL")]
    public int? Diesel { get; set; }

    [Column("RICE")]
    public int? Rice { get; set; }

    [Column("PADDY")]
    public int? Paddy { get; set; }

    [Column("WHEAT")]
    public int? Wheat { get; set; }

    [Column("FERTILIZER")]
    public int? Fertilizer { get; set; }

    [Column("SUGAR")]
    public int? Sugar { get; set; }

    [Column("GAS CYLINDER")]
    public int? GasCylinder { get; set; }

    [Column("VEHICLE")]
    public int? Vehicle { get; set; }

    [Column("OTHERS")]
    public int? Others { get; set; }

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
}
