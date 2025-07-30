using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace white_paper_master.Models;

[Keyless]
[Table("OD_WP_CB_DIS_SESSION_T_CASES")]
public partial class OdWpCbDisSessionTCase
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

    [Column("TOT_TRI")]
    public int? TotTri { get; set; }

    [Column("TOT_CON")]
    public int? TotCon { get; set; }

    [Column("TOT_ACQ")]
    public int? TotAcq { get; set; }

    [Column("MUR_TRI")]
    public int? MurTri { get; set; }

    [Column("MUR_CON")]
    public int? MurCon { get; set; }

    [Column("MUR_ACQ")]
    public int? MurAcq { get; set; }

    [Column("DAC_TRI")]
    public int? DacTri { get; set; }

    [Column("DAC_CON")]
    public int? DacCon { get; set; }

    [Column("DAC_ACQ")]
    public int? DacAcq { get; set; }

    [Column("S_RIO_TRI")]
    public int? SRioTri { get; set; }

    [Column("S_RIO_CON")]
    public int? SRioCon { get; set; }

    [Column("S_RIO_ACQ")]
    public int? SRioAcq { get; set; }

    [Column("RAPE_TRI")]
    public int? RapeTri { get; set; }

    [Column("RAPE_CON")]
    public int? RapeCon { get; set; }

    [Column("RAPE_ACQ")]
    public int? RapeAcq { get; set; }

    [Column("DOW_TRI")]
    public int? DowTri { get; set; }

    [Column("DOW_CON")]
    public int? DowCon { get; set; }

    [Column("DOW_ACQ")]
    public int? DowAcq { get; set; }

    [Column("NDPS_TRI")]
    public int? NdpsTri { get; set; }

    [Column("NDPS_CON")]
    public int? NdpsCon { get; set; }

    [Column("NDPS_ACQ")]
    public int? NdpsAcq { get; set; }

    [Column("MIS_TRI")]
    public int? MisTri { get; set; }

    [Column("MIS_CON")]
    public int? MisCon { get; set; }

    [Column("MIS_ACQ")]
    public int? MisAcq { get; set; }

    [Column("SR_TRI")]
    public int? SrTri { get; set; }

    [Column("SR_CON")]
    public int? SrCon { get; set; }

    [Column("SR_ACQ")]
    public int? SrAcq { get; set; }

    [Column("N_SR_TRI")]
    public int? NSrTri { get; set; }

    [Column("N_SR_CON")]
    public int? NSrCon { get; set; }

    [Column("N_SR_ACQ")]
    public int? NSrAcq { get; set; }

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
