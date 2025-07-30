using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace white_paper_master.Models;

[Keyless]
[Table("OD_WP_CB_AGE_GRP_F_JD")]
public partial class OdWpCbAgeGrpFJd
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

    [Column("CASES_REGD")]
    public int? CasesRegd { get; set; }

    [Column("CASES_REGD_A_B")]
    public int? CasesRegdAB { get; set; }

    [Column("CASES_REGD_A_G")]
    public int? CasesRegdAG { get; set; }

    [Column("CASES_REGD_A_GRP_7_TO_12_B")]
    public int? CasesRegdAGrp7To12B { get; set; }

    [Column("CASES_REGD_A_GRP_7_TO_12_G")]
    public int? CasesRegdAGrp7To12G { get; set; }

    [Column("CASES_REGD_A_GRP_13_TO_16_B")]
    public int? CasesRegdAGrp13To16B { get; set; }

    [Column("CASES_REGD_A_GRP_13_TO_16_G")]
    public int? CasesRegdAGrp13To16G { get; set; }

    [Column("CASES_REGD_A_GRP_ABOVE_16_B")]
    public int? CasesRegdAGrpAbove16B { get; set; }

    [Column("CASES_REGD_A_GRP_ABOVE_16_G")]
    public int? CasesRegdAGrpAbove16G { get; set; }

    [Column("TOT_NO_F_JD_INV")]
    public int? TotNoFJdInv { get; set; }

    [Column("TOT_NO_F_JD_ARRES")]
    public int? TotNoFJdArres { get; set; }

    [Column("NO_F_JD_BOYS_INV")]
    public int? NoFJdBoysInv { get; set; }

    [Column("NO_F_JD_BOYS_ARRES")]
    public int? NoFJdBoysArres { get; set; }

    [Column("NO_F_JD_GIRLS_INV")]
    public int? NoFJdGirlsInv { get; set; }

    [Column("NO_F_JD_GIRLS_ARRES")]
    public int? NoFJdGirlsArres { get; set; }

    [Column("AGE_7_12_BOYS_INV")]
    public int? Age712BoysInv { get; set; }

    [Column("AGE_7_12_BOYS_ARRES")]
    public int? Age712BoysArres { get; set; }

    [Column("AGE_7_12_GIRLS_INV")]
    public int? Age712GirlsInv { get; set; }

    [Column("AGE_7_12_GIRLS_ARRES")]
    public int? Age712GirlsArres { get; set; }

    [Column("AGE_13_16_BOYS_INV")]
    public int? Age1316BoysInv { get; set; }

    [Column("AGE_13_16_BOYS_ARRES")]
    public int? Age1316BoysArres { get; set; }

    [Column("AGE_13_16_GIRLS_INV")]
    public int? Age1316GirlsInv { get; set; }

    [Column("AGE_13_16_GIRLS_ARRES")]
    public int? Age1316GirlsArres { get; set; }

    [Column("AGE_ABOVE_16_BOYS_INV")]
    public int? AgeAbove16BoysInv { get; set; }

    [Column("AGE_ABOVE_16_BOYS_ARRES")]
    public int? AgeAbove16BoysArres { get; set; }

    [Column("AGE_ABOVE_16_GIRLS_INV")]
    public int? AgeAbove16GirlsInv { get; set; }

    [Column("AGE_ABOVE_16_GIRLS_ARRES")]
    public int? AgeAbove16GirlsArres { get; set; }

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
