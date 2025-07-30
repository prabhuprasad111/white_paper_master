using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace white_paper_master.Models;

[Keyless]
[Table("OD_WP_CB_CYBER_CRIME_REL_FINANCIAL_F")]
public partial class OdWpCbCyberCrimeRelFinancialF
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

    [Column("CURRENT_YEAR")]
    public int? CurrentYear { get; set; }

    [Column("LAST_YEAR")]
    public int? LastYear { get; set; }

    [Column("LAST_LAST_YEAR")]
    public int? LastLastYear { get; set; }

    [Column("TA", TypeName = "decimal(6, 2)")]
    public decimal? Ta { get; set; }

    [Column("CS")]
    public int? Cs { get; set; }

    [Column("FRT")]
    public int? Frt { get; set; }

    [Column("OTHR_DISPO")]
    public int? OthrDispo { get; set; }

    [Column("PI")]
    public int? Pi { get; set; }

    [Column("LCS")]
    public int? Lcs { get; set; }

    [Column("ARR_IN_STATE_M")]
    public int? ArrInStateM { get; set; }

    [Column("ARR_IN_STATE_F")]
    public int? ArrInStateF { get; set; }

    [Column("ARR_O_STATE_ARR_M")]
    public int? ArrOStateArrM { get; set; }

    [Column("ARR_O_STATE_ARR_F")]
    public int? ArrOStateArrF { get; set; }

    [Column("ARR_O_COUNT_ARR_M")]
    public int? ArrOCountArrM { get; set; }

    [Column("ARR_O_COUNT_ARR_F")]
    public int? ArrOCountArrF { get; set; }

    [Column("INV_IN_STATE_M")]
    public int? InvInStateM { get; set; }

    [Column("INV_IN_STATE_F")]
    public int? InvInStateF { get; set; }

    [Column("INV_O_STATE_ARR_M")]
    public int? InvOStateArrM { get; set; }

    [Column("INV_O_STATE_ARR_F")]
    public int? InvOStateArrF { get; set; }

    [Column("INV_O_COUNT_ARR_M")]
    public int? InvOCountArrM { get; set; }

    [Column("INV_O_COUNT_ARR_F")]
    public int? InvOCountArrF { get; set; }

    [Column("PROP_STOLEN", TypeName = "decimal(18, 2)")]
    public decimal? PropStolen { get; set; }

    [Column("PROP_RECO", TypeName = "decimal(18, 2)")]
    public decimal? PropReco { get; set; }

    [Column("PROP_FROZE", TypeName = "decimal(18, 2)")]
    public decimal? PropFroze { get; set; }

    [Column("CRED_VISHING")]
    public int? CredVishing { get; set; }

    [Column("CRED_SMISHING")]
    public int? CredSmishing { get; set; }

    [Column("CRED_SKIMMING")]
    public int? CredSkimming { get; set; }

    [Column("CRED_CARD_TH")]
    public int? CredCardTh { get; set; }

    [Column("CRED_AUTO_TRAN")]
    public int? CredAutoTran { get; set; }

    [Column("DEBT_VISHING")]
    public int? DebtVishing { get; set; }

    [Column("DEBT_SMISHING")]
    public int? DebtSmishing { get; set; }

    [Column("DEBT_SKIMMING")]
    public int? DebtSkimming { get; set; }

    [Column("DEBT_CARD_TH")]
    public int? DebtCardTh { get; set; }

    [Column("DEBT_AUTO_TRAN")]
    public int? DebtAutoTran { get; set; }

    [Column("UPI_FRAUD")]
    public int? UpiFraud { get; set; }

    [Column("CRYPTO_F")]
    public int? CryptoF { get; set; }

    [Column("FIN_F_JOB")]
    public int? FinFJob { get; set; }

    [Column("FIN_F_INS")]
    public int? FinFIns { get; set; }

    [Column("FIN_F_TOWER")]
    public int? FinFTower { get; set; }

    [Column("FIN_F_MATRI")]
    public int? FinFMatri { get; set; }

    [Column("FIN_F_LOTTERY")]
    public int? FinFLottery { get; set; }

    [Column("FIN_F_E_COMM")]
    public int? FinFEComm { get; set; }

    [Column("FIN_F_SIM_SWAP")]
    public int? FinFSimSwap { get; set; }

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

    [Column("OTHER")]
    public int? Other { get; set; }

    [Column("FIN_F_ONLINE_TRADE")]
    public int? FinFOnlineTrade { get; set; }

    [Column("FIN_F_OTHER")]
    public int? FinFOther { get; set; }

    [Column("FIN_F_DIGITAL_ARREST")]
    public int? FinFDigitalArrest { get; set; }

    [Column("ARR_IN_STATE_T")]
    public int? ArrInStateT { get; set; }

    [Column("ARR_O_STATE_ARR_T")]
    public int? ArrOStateArrT { get; set; }

    [Column("ARR_O_COUNT_ARR_T")]
    public int? ArrOCountArrT { get; set; }

    [Column("INV_IN_STATE_T")]
    public int? InvInStateT { get; set; }

    [Column("INV_O_STATE_ARR_T")]
    public int? InvOStateArrT { get; set; }

    [Column("INV_O_COUNT_ARR_T")]
    public int? InvOCountArrT { get; set; }

    [Column("OTHER_INVESTMENT_FRAUD")]
    public int? OtherInvestmentFraud { get; set; }

    [Column("SEXTORTION_NUDE_VIDEO_CALL")]
    public int? SextortionNudeVideoCall { get; set; }

    [Column("OTHER_VISHING")]
    public int? OtherVishing { get; set; }

    [Column("OTHER_SMISHING")]
    public int? OtherSmishing { get; set; }

    [Column("OTHER_SKIMMING")]
    public int? OtherSkimming { get; set; }

    [Column("CARD_THEFT")]
    public int? CardTheft { get; set; }

    [Column("OLX_QUICKR_JUST_DIAL")]
    public int? OlxQuickrJustDial { get; set; }

    [Column("HOTEL_BOOKING_FRAUD")]
    public int? HotelBookingFraud { get; set; }

    [Column("CUSTOMER_CARE_FRAUD")]
    public int? CustomerCareFraud { get; set; }

    [Column("LOAN_FRAUD")]
    public int? LoanFraud { get; set; }

    [Column("FEDEX_PARCLE_FRAUD")]
    public int? FedexParcleFraud { get; set; }
}
