using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace white_paper_master.Models;

[Keyless]
[Table("OD_WP_HRPC_CRIME_AGNST_ST_SC_VIOLENCE")]
public partial class OdWpHrpcCrimeAgnstStScViolence
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

    [Column("REPORT")]
    public int? Report { get; set; }

    [Column("CS")]
    public int? Cs { get; set; }

    [Column("FRT")]
    public int? Frt { get; set; }

    [Column("MF_ML")]
    public int? MfMl { get; set; }

    [Column("NC")]
    public int? Nc { get; set; }

    [Column("FALSE")]
    public int? False { get; set; }

    [Column("SR_DIS")]
    public int? SrDis { get; set; }

    [Column("SR_TRANS")]
    public int? SrTrans { get; set; }

    [Column("PI")]
    public int? Pi { get; set; }

    [Column("TRUE")]
    public int? True { get; set; }

    [Column("LCS")]
    public int? Lcs { get; set; }

    [Column("PERC_DETECTION", TypeName = "decimal(18, 2)")]
    public decimal? PercDetection { get; set; }

    [Column("CONV")]
    public int? Conv { get; set; }

    [Column("ACQ")]
    public int? Acq { get; set; }

    [Column("PT")]
    public int? Pt { get; set; }

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
