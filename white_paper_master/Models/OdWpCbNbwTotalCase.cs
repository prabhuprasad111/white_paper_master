using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace white_paper_master.Models;

[Keyless]
[Table("OD_WP_CB_NBW_TOTAL_CASES")]
public partial class OdWpCbNbwTotalCase
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

    [Column("T_PEN_PREV_YR")]
    public int? TPenPrevYr { get; set; }

    [Column("T_REC_DUR_YR")]
    public int? TRecDurYr { get; set; }

    [Column("T_TOTAL")]
    public int? TTotal { get; set; }

    [Column("T_EXECUTED")]
    public int? TExecuted { get; set; }

    [Column("T_OTHR_DIS")]
    public int? TOthrDis { get; set; }

    [Column("T_PEN_END_YR")]
    public int? TPenEndYr { get; set; }

    [Column("ST_PEN_PREV_YR")]
    public int? StPenPrevYr { get; set; }

    [Column("ST_REC_DUR_YR")]
    public int? StRecDurYr { get; set; }

    [Column("ST_TOTAL")]
    public int? StTotal { get; set; }

    [Column("ST_EXECUTED")]
    public int? StExecuted { get; set; }

    [Column("ST_OTHR_DIS")]
    public int? StOthrDis { get; set; }

    [Column("ST_PEN_END_YR")]
    public int? StPenEndYr { get; set; }

    [Column("GR_PEN_PREV_YR")]
    public int? GrPenPrevYr { get; set; }

    [Column("GR_REC_DUR_YR")]
    public int? GrRecDurYr { get; set; }

    [Column("GR_TOTAL")]
    public int? GrTotal { get; set; }

    [Column("GR_EXECUTED")]
    public int? GrExecuted { get; set; }

    [Column("GR_OTHR_DIS")]
    public int? GrOthrDis { get; set; }

    [Column("GR_PEN_END_YR")]
    public int? GrPenEndYr { get; set; }

    [Column("EX_PEN_PREV_YR")]
    public int? ExPenPrevYr { get; set; }

    [Column("EX_REC_DUR_YR")]
    public int? ExRecDurYr { get; set; }

    [Column("EX_TOTAL")]
    public int? ExTotal { get; set; }

    [Column("EX_EXECUTED")]
    public int? ExExecuted { get; set; }

    [Column("EX_OTHR_DIS")]
    public int? ExOthrDis { get; set; }

    [Column("EX_PEN_END_YR")]
    public int? ExPenEndYr { get; set; }

    [Column("C_PEN_PREV_YR")]
    public int? CPenPrevYr { get; set; }

    [Column("C_REC_DUR_YR")]
    public int? CRecDurYr { get; set; }

    [Column("C_TOTAL")]
    public int? CTotal { get; set; }

    [Column("C_EXECUTED")]
    public int? CExecuted { get; set; }

    [Column("C_OTHR_DIS")]
    public int? COthrDis { get; set; }

    [Column("C_PEN_END_YR")]
    public int? CPenEndYr { get; set; }

    [Column("M_PEN_PREV_YR")]
    public int? MPenPrevYr { get; set; }

    [Column("M_REC_DUR_YR")]
    public int? MRecDurYr { get; set; }

    [Column("M_TOTAL")]
    public int? MTotal { get; set; }

    [Column("M_EXECUTED")]
    public int? MExecuted { get; set; }

    [Column("M_OTHR_DIS")]
    public int? MOthrDis { get; set; }

    [Column("M_PEN_END_YR")]
    public int? MPenEndYr { get; set; }

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
