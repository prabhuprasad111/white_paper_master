using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace white_paper_master.Models;

[Keyless]
[Table("OD_WP_CB_DISPO_PENDING_CRIMINAL_CASES")]
public partial class OdWpCbDispoPendingCriminalCase
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

    [Column("PEN_PREV_YR")]
    public int? PenPrevYr { get; set; }

    [Column("REG_DUR_YEAR")]
    public int? RegDurYear { get; set; }

    [Column("TOTAL")]
    public int? Total { get; set; }

    [Column("TOT_DISPO_B_F_YR")]
    public int? TotDispoBFYr { get; set; }

    [Column("TOT_DIS_OUT_REGD_YR")]
    public int? TotDisOutRegdYr { get; set; }

    [Column("TOT_CASES_DIS")]
    public int? TotCasesDis { get; set; }

    [Column("TOT_PEN_INV_YR")]
    public int? TotPenInvYr { get; set; }

    [Column("NO_ASI_IO")]
    public int? NoAsiIo { get; set; }

    [Column("TOT_DISPO_ASI")]
    public int? TotDispoAsi { get; set; }

    [Column("NO_Sis_AS_IOs")]
    public int? NoSisAsIos { get; set; }

    [Column("TOT_DISPO_Sis")]
    public int? TotDispoSis { get; set; }

    [Column("NO_Inspr_IO")]
    public int? NoInsprIo { get; set; }

    [Column("TOT_DISPO_Inspr")]
    public int? TotDispoInspr { get; set; }

    [Column("NO_D_Ss_P_AS_IO")]
    public int? NoDSsPAsIo { get; set; }

    [Column("TOT_DISPO_D_Ss_P")]
    public int? TotDispoDSsP { get; set; }

    [Column("TO_IOs")]
    public int? ToIos { get; set; }

    [Column("TOT_DISPO_OFF")]
    public int? TotDispoOff { get; set; }

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
