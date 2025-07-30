namespace white_paper_master.Models.DTO
{
    
    public class WP_CB_TOTALCOG_DTO
    {
        public int SL_NO { get; set; }
        public int REPORTID { get; set; }
        public int REG_YEAR { get; set; }
        public int REG_MONTH { get; set; }
        public int DISTRICT_CD { get; set; }
        public int PS_CD { get; set; }
        public int CURRENT_YEAR { get; set; }
        public int LAST_YEAR { get; set; }
        public int LAST_LAST_YEAR { get; set; }
        public decimal TA { get; set; }
        public int CS { get; set; }
        public int Convicted { get; set; }
        public int Acquitted { get; set; }
        public int Discharged { get; set; }
        public int Withdrawn { get; set; }
        public int Compounded { get; set; }
        public int Pending_Trail { get; set; }
        public int Comp_FR_Drop { get; set; }
        public int RI { get; set; }
        public int NONCOG { get; set; }
        public int False { get; set; }
        public int Transfer { get; set; }
        public int MF_ML { get; set; }
        public int FRT { get; set; }
        public int PI { get; set; }
        public int LCS { get; set; }
        public decimal PERC_INC_LCS { get; set; }
        public decimal PERC_INC_DEC_TA { get; set; }
        public decimal PERC_INC_DEC_LASTYEAR { get; set; }
        public int TRUE_CASES { get; set; }
        public int ARREST_M { get; set; }
        public int ARREST_F { get; set; }
        public int ARREST_TG { get; set; }
        public string RECORD_STATUS { get; set; }
        public DateTime RECORD_CREATED_ON { get; set; }
        public string RECORD_CREATED_BY { get; set; }
        public int Final_True { get; set; }
        public int Final_IE { get; set; }
        public int CRPC_41A_M { get; set; }
        public int CRPC_41A_F { get; set; }
        public int CRPC_41A_TG { get; set; }
        public string REMARKS { get; set; }
        public int CS_Comp { get; set; }
        public int CONVICTION_CS { get; set; }
        public int COMPOUNDED_FR_DROPPED { get; set; }
    }
}
