using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// RateLock
    /// </summary>
    public sealed partial class RateLock : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _actualSellAmount;
        /// <summary>
        /// Purchase Advice Actual Sell Amount [3424]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Purchase Advice Actual Sell Amount")]
        public decimal? ActualSellAmount { get => _actualSellAmount; set => SetField(ref _actualSellAmount, value); }
        private DirtyValue<decimal?> _actualSellPrice;
        /// <summary>
        /// Purchase Advice Actual Sell Price [3422]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6, Description = "Purchase Advice Actual Sell Price")]
        public decimal? ActualSellPrice { get => _actualSellPrice; set => SetField(ref _actualSellPrice, value); }
        private DirtyValue<decimal?> _actualSellSideSRP;
        /// <summary>
        /// Purchase Advice Actual Sell Side SRP [3426]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6, Description = "Purchase Advice Actual Sell Side SRP")]
        public decimal? ActualSellSideSRP { get => _actualSellSideSRP; set => SetField(ref _actualSellSideSRP, value); }
        private DirtyValue<decimal?> _actualSRPAmount;
        /// <summary>
        /// Purchase Advice Actual SRP Amount [3428]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Purchase Advice Actual SRP Amount")]
        public decimal? ActualSRPAmount { get => _actualSRPAmount; set => SetField(ref _actualSRPAmount, value); }
        private DirtyValue<decimal?> _amountDue;
        /// <summary>
        /// Purchase Advice Amt Due To [2631]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Purchase Advice Amt Due To")]
        public decimal? AmountDue { get => _amountDue; set => SetField(ref _amountDue, value); }
        private DirtyValue<StringEnumValue<PartyType>> _amountDueTo;
        /// <summary>
        /// Purchase Advice Amt Due to Lender/Investor [2627]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Purchase Advice Amt Due to Lender/Investor")]
        public StringEnumValue<PartyType> AmountDueTo { get => _amountDueTo; set => SetField(ref _amountDueTo, value); }
        private DirtyValue<decimal?> _amountPaid;
        /// <summary>
        /// Purchase Advice Amt Paid To [2632]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Purchase Advice Amt Paid To")]
        public decimal? AmountPaid { get => _amountPaid; set => SetField(ref _amountPaid, value); }
        private DirtyValue<StringEnumValue<PartyType>> _amountPaidTo;
        /// <summary>
        /// Purchase Advice Amt Paid to Lender/Investor [2628]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Purchase Advice Amt Paid to Lender/Investor")]
        public StringEnumValue<PartyType> AmountPaidTo { get => _amountPaidTo; set => SetField(ref _amountPaidTo, value); }
        private DirtyValue<decimal?> _amountReceived;
        /// <summary>
        /// Purchase Advice Amount Received [2214]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Purchase Advice Amount Received")]
        public decimal? AmountReceived { get => _amountReceived; set => SetField(ref _amountReceived, value); }
        private DirtyValue<int?> _balloonLoanMaturityTermMonths;
        /// <summary>
        /// Lock Request Term Due In [2960]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Term Due In")]
        public int? BalloonLoanMaturityTermMonths { get => _balloonLoanMaturityTermMonths; set => SetField(ref _balloonLoanMaturityTermMonths, value); }
        private DirtyValue<decimal?> _baseLoanAmount;
        /// <summary>
        /// Lock Request Loan Amnt Excluding MIP/PMI [3043]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Lock Request Loan Amnt Excluding MIP/PMI")]
        public decimal? BaseLoanAmount { get => _baseLoanAmount; set => SetField(ref _baseLoanAmount, value); }
        private DirtyValue<decimal?> _borrowerRequestedLoanAmount;
        /// <summary>
        /// Lock Request Loan Amount [2965]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Lock Request Loan Amount")]
        public decimal? BorrowerRequestedLoanAmount { get => _borrowerRequestedLoanAmount; set => SetField(ref _borrowerRequestedLoanAmount, value); }
        private DirtyValue<DateTime?> _branchApprovalDate;
        /// <summary>
        /// Rate Lock Buy Side Branch Concession Approval Date [3376]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Buy Side Branch Concession Approval Date")]
        public DateTime? BranchApprovalDate { get => _branchApprovalDate; set => SetField(ref _branchApprovalDate, value); }
        private DirtyValue<string> _branchApprovedby;
        /// <summary>
        /// Rate Lock Buy Side Branch Concession Approved by [3377]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Buy Side Branch Concession Approved by")]
        public string BranchApprovedby { get => _branchApprovedby; set => SetField(ref _branchApprovedby, value); }
        private DirtyValue<decimal?> _branchPrice;
        /// <summary>
        /// Rate Lock Buy Side Branch Price Concession [3375]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Buy Side Branch Price Concession")]
        public decimal? BranchPrice { get => _branchPrice; set => SetField(ref _branchPrice, value); }
        private DirtyList<PriceAdjustment> _buySideAdjustments;
        /// <summary>
        /// RateLock BuySideAdjustments
        /// </summary>
        public IList<PriceAdjustment> BuySideAdjustments { get => GetField(ref _buySideAdjustments); set => SetField(ref _buySideAdjustments, value); }
        private DirtyValue<string> _buySideComments;
        /// <summary>
        /// Rate Lock Buy Side Comments [2204]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Buy Side Comments")]
        public string BuySideComments { get => _buySideComments; set => SetField(ref _buySideComments, value); }
        private DirtyValue<DateTime?> _buySideCommitmentDate;
        /// <summary>
        /// Rate Lock BuySide Commitment Date [3909]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock BuySide Commitment Date")]
        public DateTime? BuySideCommitmentDate { get => _buySideCommitmentDate; set => SetField(ref _buySideCommitmentDate, value); }
        private DirtyValue<string> _buySideCommitmentNumber;
        /// <summary>
        /// Rate Lock BuySide Commitment Number [3902]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock BuySide Commitment Number")]
        public string BuySideCommitmentNumber { get => _buySideCommitmentNumber; set => SetField(ref _buySideCommitmentNumber, value); }
        private DirtyValue<string> _buySideCommitmentType;
        /// <summary>
        /// Rate Lock BuySide Commitment Type [3910]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock BuySide Commitment Type")]
        public string BuySideCommitmentType { get => _buySideCommitmentType; set => SetField(ref _buySideCommitmentType, value); }
        private DirtyValue<DateTime?> _buySideCurrentRateSetDate;
        /// <summary>
        /// Rate Lock Buy Side Last Rate Set Date [3256]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Buy Side Last Rate Set Date")]
        public DateTime? BuySideCurrentRateSetDate { get => _buySideCurrentRateSetDate; set => SetField(ref _buySideCurrentRateSetDate, value); }
        private DirtyValue<int?> _buySideDaystoExtend;
        /// <summary>
        /// Rate Lock Buy Side Days to Extend [3363]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Buy Side Days to Extend")]
        public int? BuySideDaystoExtend { get => _buySideDaystoExtend; set => SetField(ref _buySideDaystoExtend, value); }
        private DirtyValue<DateTime?> _buySideDeliveryExpirationDate;
        /// <summary>
        /// Rate Lock BuySide Delivery Expiration Date [3913]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock BuySide Delivery Expiration Date")]
        public DateTime? BuySideDeliveryExpirationDate { get => _buySideDeliveryExpirationDate; set => SetField(ref _buySideDeliveryExpirationDate, value); }
        private DirtyValue<string> _buySideDeliveryType;
        /// <summary>
        /// Rate Lock BuySide Delivery Type [3911]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock BuySide Delivery Type")]
        public string BuySideDeliveryType { get => _buySideDeliveryType; set => SetField(ref _buySideDeliveryType, value); }
        private DirtyValue<DateTime?> _buySideExpirationDate;
        /// <summary>
        /// Rate Lock BuySide Expiration Date [3912]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock BuySide Expiration Date")]
        public DateTime? BuySideExpirationDate { get => _buySideExpirationDate; set => SetField(ref _buySideExpirationDate, value); }
        private DirtyValue<DateTime?> _buySideExtendedLockExpires;
        /// <summary>
        /// Rate Lock Buy Side Extended Lock Expires Date [3364]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Buy Side Extended Lock Expires Date")]
        public DateTime? BuySideExtendedLockExpires { get => _buySideExtendedLockExpires; set => SetField(ref _buySideExtendedLockExpires, value); }
        private DirtyValue<DateTime?> _buySideLockDate;
        /// <summary>
        /// Rate Lock Buy Side Lock Date [2149]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Buy Side Lock Date")]
        public DateTime? BuySideLockDate { get => _buySideLockDate; set => SetField(ref _buySideLockDate, value); }
        private DirtyValue<DateTime?> _buySideLockExpires;
        /// <summary>
        /// Rate Lock Buy Side Lock Expires Date [2151]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Buy Side Lock Expires Date")]
        public DateTime? BuySideLockExpires { get => _buySideLockExpires; set => SetField(ref _buySideLockExpires, value); }
        private DirtyValue<decimal?> _buySideLockExtendPriceAdjustment;
        /// <summary>
        /// Rate Lock Buy Side Lock Extension Price Adjustment [3365]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Buy Side Lock Extension Price Adjustment")]
        public decimal? BuySideLockExtendPriceAdjustment { get => _buySideLockExtendPriceAdjustment; set => SetField(ref _buySideLockExtendPriceAdjustment, value); }
        private DirtyValue<decimal?> _buySideMarginNetBuyRate;
        /// <summary>
        /// Rate Lock Buy Side Net Buy ARM Margin [2775]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Buy Side Net Buy ARM Margin")]
        public decimal? BuySideMarginNetBuyRate { get => _buySideMarginNetBuyRate; set => SetField(ref _buySideMarginNetBuyRate, value); }
        private DirtyValue<decimal?> _buySideMarginRate;
        /// <summary>
        /// Rate Lock Buy Side Base Margin [2733]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Buy Side Base Margin")]
        public decimal? BuySideMarginRate { get => _buySideMarginRate; set => SetField(ref _buySideMarginRate, value); }
        private DirtyValue<decimal?> _buySideMarginTotalAdjustment;
        /// <summary>
        /// Rate Lock Buy Side Base Rate Total Adjust [2774]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Buy Side Base Rate Total Adjust")]
        public decimal? BuySideMarginTotalAdjustment { get => _buySideMarginTotalAdjustment; set => SetField(ref _buySideMarginTotalAdjustment, value); }
        private DirtyValue<string> _buySideMasterCommitmentNumber;
        /// <summary>
        /// Rate Lock BuySide Master Commitment Number [3903]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock BuySide Master Commitment Number")]
        public string BuySideMasterCommitmentNumber { get => _buySideMasterCommitmentNumber; set => SetField(ref _buySideMasterCommitmentNumber, value); }
        private DirtyValue<int?> _buySideNumberOfDays;
        /// <summary>
        /// Rate Lock Buy Side Number of Days [2150]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Buy Side Number of Days")]
        public int? BuySideNumberOfDays { get => _buySideNumberOfDays; set => SetField(ref _buySideNumberOfDays, value); }
        private DirtyValue<bool?> _buySideOnrpEligible;
        /// <summary>
        /// Rate Lock Buy Side ONRP Eligible Flag [4059]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Lock Buy Side ONRP Eligible Flag", OptionsJson = "{\"true\":\"Y\",\"false\":\"N\"}")]
        public bool? BuySideOnrpEligible { get => _buySideOnrpEligible; set => SetField(ref _buySideOnrpEligible, value); }
        private DirtyValue<DateTime?> _buySideOnrpLockDate;
        /// <summary>
        /// Rate Lock Buy Side ONRP Lock Date [4070]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Lock Buy Side ONRP Lock Date")]
        public DateTime? BuySideOnrpLockDate { get => _buySideOnrpLockDate; set => SetField(ref _buySideOnrpLockDate, value); }
        private DirtyValue<string> _buySideOnrpLockTime;
        /// <summary>
        /// Rate Lock Buy Side ONRP Lock Time [4058]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Lock Buy Side ONRP Lock Time")]
        public string BuySideOnrpLockTime { get => _buySideOnrpLockTime; set => SetField(ref _buySideOnrpLockTime, value); }
        private DirtyValue<string> _buySideOrgID;
        /// <summary>
        /// Rate Lock BuySide Org ID [3906]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock BuySide Org ID")]
        public string BuySideOrgID { get => _buySideOrgID; set => SetField(ref _buySideOrgID, value); }
        private DirtyValue<DateTime?> _buySideOriginalLockExpires;
        /// <summary>
        /// Rate Lock Buy Side Lock Expires Date [3358]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Buy Side Lock Expires Date")]
        public DateTime? BuySideOriginalLockExpires { get => _buySideOriginalLockExpires; set => SetField(ref _buySideOriginalLockExpires, value); }
        private DirtyValue<decimal?> _buySidePriceNetBuyPrice;
        /// <summary>
        /// Rate Lock Buy Side Base Price Rate Net Buy Price [2203]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Buy Side Base Price Rate Net Buy Price")]
        public decimal? BuySidePriceNetBuyPrice { get => _buySidePriceNetBuyPrice; set => SetField(ref _buySidePriceNetBuyPrice, value); }
        private DirtyValue<decimal?> _buySidePriceRate;
        /// <summary>
        /// Rate Lock Buy Side Base Price Rate [2161]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Buy Side Base Price Rate")]
        public decimal? BuySidePriceRate { get => _buySidePriceRate; set => SetField(ref _buySidePriceRate, value); }
        private DirtyValue<decimal?> _buySidePriceTotalAdjustment;
        /// <summary>
        /// Rate Lock Buy Side Base Price Tot Adjustment [2202]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Buy Side Base Price Tot Adjustment")]
        public decimal? BuySidePriceTotalAdjustment { get => _buySidePriceTotalAdjustment; set => SetField(ref _buySidePriceTotalAdjustment, value); }
        private DirtyValue<decimal?> _buySideRate;
        /// <summary>
        /// Rate Lock Buy Side Base Rate [2152]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Buy Side Base Rate")]
        public decimal? BuySideRate { get => _buySideRate; set => SetField(ref _buySideRate, value); }
        private DirtyValue<decimal?> _buySideRateNetBuyRate;
        /// <summary>
        /// Rate Lock Buy Side Net Buy Rate [2160]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Buy Side Net Buy Rate")]
        public decimal? BuySideRateNetBuyRate { get => _buySideRateNetBuyRate; set => SetField(ref _buySideRateNetBuyRate, value); }
        private DirtyValue<string> _buySideRateSheetID;
        /// <summary>
        /// Rate Lock Buy Side Rate Sheet ID [2148]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Buy Side Rate Sheet ID")]
        public string BuySideRateSheetID { get => _buySideRateSheetID; set => SetField(ref _buySideRateSheetID, value); }
        private DirtyValue<decimal?> _buySideRateTotalAdjustment;
        /// <summary>
        /// Rate Lock Buy Side Base Rate Tot Adjustment [2159]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Buy Side Base Rate Tot Adjustment")]
        public decimal? BuySideRateTotalAdjustment { get => _buySideRateTotalAdjustment; set => SetField(ref _buySideRateTotalAdjustment, value); }
        private DirtyValue<string> _buySideRequestedBy;
        /// <summary>
        /// Rate Lock Buy Side Requested By [2029]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Buy Side Requested By")]
        public string BuySideRequestedBy { get => _buySideRequestedBy; set => SetField(ref _buySideRequestedBy, value); }
        private DirtyValue<decimal?> _buySideSRPPaidOut;
        /// <summary>
        /// Rate Lock Buy Side SRP Paid Out [2205]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Buy Side SRP Paid Out")]
        public decimal? BuySideSRPPaidOut { get => _buySideSRPPaidOut; set => SetField(ref _buySideSRPPaidOut, value); }
        private DirtyValue<decimal?> _buySideStartingAdjPoint;
        /// <summary>
        /// Rate Lock BuySide Starting Adjust Point [3875]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock BuySide Starting Adjust Point")]
        public decimal? BuySideStartingAdjPoint { get => _buySideStartingAdjPoint; set => SetField(ref _buySideStartingAdjPoint, value); }
        private DirtyValue<decimal?> _buySideStartingAdjPrice;
        /// <summary>
        /// RateLock BuySideStartingAdjPrice
        /// </summary>
        public decimal? BuySideStartingAdjPrice { get => _buySideStartingAdjPrice; set => SetField(ref _buySideStartingAdjPrice, value); }
        private DirtyValue<decimal?> _buySideStartingAdjRate;
        /// <summary>
        /// Rate Lock BuySide Starting Adjust Rate [3873]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock BuySide Starting Adjust Rate")]
        public decimal? BuySideStartingAdjRate { get => _buySideStartingAdjRate; set => SetField(ref _buySideStartingAdjRate, value); }
        private DirtyValue<string> _buySideTPOID;
        /// <summary>
        /// Rate Lock BuySide TPOID [3905]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock BuySide TPOID")]
        public string BuySideTPOID { get => _buySideTPOID; set => SetField(ref _buySideTPOID, value); }
        private DirtyValue<string> _buySideTPOName;
        /// <summary>
        /// Rate Lock BuySide TPO Name [3904]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock BuySide TPO Name")]
        public string BuySideTPOName { get => _buySideTPOName; set => SetField(ref _buySideTPOName, value); }
        private DirtyValue<string> _buySideTradeGuid;
        /// <summary>
        /// Assigned Trade Unique Identifier [3914]
        /// </summary>
        [LoanFieldProperty(Description = "Assigned Trade Unique Identifier")]
        public string BuySideTradeGuid { get => _buySideTradeGuid; set => SetField(ref _buySideTradeGuid, value); }
        private DirtyValue<string> _buySideTradeNumber;
        /// <summary>
        /// Rate Lock Assigned Trade Number [3915]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Assigned Trade Number")]
        public string BuySideTradeNumber { get => _buySideTradeNumber; set => SetField(ref _buySideTradeNumber, value); }
        private DirtyValue<decimal?> _buySideUnDiscountedRate;
        /// <summary>
        /// Rate Lock BuySide UnDiscounted Rate [3848]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock BuySide UnDiscounted Rate")]
        public decimal? BuySideUnDiscountedRate { get => _buySideUnDiscountedRate; set => SetField(ref _buySideUnDiscountedRate, value); }
        private DirtyValue<string> _cancellationRequestPending;
        /// <summary>
        /// RateLock CancellationRequestPending
        /// </summary>
        public string CancellationRequestPending { get => _cancellationRequestPending; set => SetField(ref _cancellationRequestPending, value); }
        private DirtyValue<decimal?> _combinedLTV;
        /// <summary>
        /// Lock RequestCOmbined Loan to Value (CLTV) [3242]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Lock RequestCOmbined Loan to Value (CLTV)")]
        public decimal? CombinedLTV { get => _combinedLTV; set => SetField(ref _combinedLTV, value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// Purchase Adv Reconciliation Comments [2840]
        /// </summary>
        [LoanFieldProperty(Description = "Purchase Adv Reconciliation Comments")]
        public string Comments { get => _comments; set => SetField(ref _comments, value); }
        private DirtyValue<string> _commitment;
        /// <summary>
        /// Rate Lock Buy Side Investor Commitment [2215]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Buy Side Investor Commitment")]
        public string Commitment { get => _commitment; set => SetField(ref _commitment, value); }
        private DirtyValue<string> _commitmentType;
        /// <summary>
        /// Rate Lock Request Commitment Type [4187]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Commitment Type")]
        public string CommitmentType { get => _commitmentType; set => SetField(ref _commitmentType, value); }
        private DirtyValue<decimal?> _compGainLossPercentage;
        /// <summary>
        /// Rate Lock Comparison Gain Loss Percent [3836]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Comparison Gain Loss Percent")]
        public decimal? CompGainLossPercentage { get => _compGainLossPercentage; set => SetField(ref _compGainLossPercentage, value); }
        private DirtyValue<decimal?> _compGainLossPrice;
        /// <summary>
        /// Rate Lock Comparison Gain Loss Price [3837]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Comparison Gain Loss Price")]
        public decimal? CompGainLossPrice { get => _compGainLossPrice; set => SetField(ref _compGainLossPrice, value); }
        private DirtyValue<decimal?> _compGainLossTotalBuyPrice;
        /// <summary>
        /// RateLock CompGainLossTotalBuyPrice
        /// </summary>
        public decimal? CompGainLossTotalBuyPrice { get => _compGainLossTotalBuyPrice; set => SetField(ref _compGainLossTotalBuyPrice, value); }
        private DirtyValue<decimal?> _compGainLossTotalCompPrice;
        /// <summary>
        /// Rate Lock Comparison Total Comparison Price [3835]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Comparison Total Comparison Price")]
        public decimal? CompGainLossTotalCompPrice { get => _compGainLossTotalCompPrice; set => SetField(ref _compGainLossTotalCompPrice, value); }
        private DirtyValue<string> _compInvestorAddress;
        /// <summary>
        /// Rate Lock Comparison Side Investor Address [3826]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Side Investor Address")]
        public string CompInvestorAddress { get => _compInvestorAddress; set => SetField(ref _compInvestorAddress, value); }
        private DirtyValue<string> _compInvestorCity;
        /// <summary>
        /// Rate Lock Comparison Side Investor City [3827]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Side Investor City")]
        public string CompInvestorCity { get => _compInvestorCity; set => SetField(ref _compInvestorCity, value); }
        private DirtyValue<string> _compInvestorCommitment;
        /// <summary>
        /// RateLock CompInvestorCommitment
        /// </summary>
        public string CompInvestorCommitment { get => _compInvestorCommitment; set => SetField(ref _compInvestorCommitment, value); }
        private DirtyValue<string> _compInvestorContact;
        /// <summary>
        /// Rate Lock Comparison Side Investor Contact [3823]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Side Investor Contact")]
        public string CompInvestorContact { get => _compInvestorContact; set => SetField(ref _compInvestorContact, value); }
        private DirtyValue<string> _compInvestorEmail;
        /// <summary>
        /// Rate Lock Comparison Side Investor Email [3825]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Side Investor Email")]
        public string CompInvestorEmail { get => _compInvestorEmail; set => SetField(ref _compInvestorEmail, value); }
        private DirtyValue<string> _compInvestorLockType;
        /// <summary>
        /// Rate Lock Comparison Investor Lock Type [3832]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Investor Lock Type")]
        public string CompInvestorLockType { get => _compInvestorLockType; set => SetField(ref _compInvestorLockType, value); }
        private DirtyValue<string> _compInvestorName;
        /// <summary>
        /// Rate Lock Comparison Investor Name [3822]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Investor Name")]
        public string CompInvestorName { get => _compInvestorName; set => SetField(ref _compInvestorName, value); }
        private DirtyValue<string> _compInvestorPhone;
        /// <summary>
        /// Rate Lock Comparison Side Investor Phone [3824]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Rate Lock Comparison Side Investor Phone")]
        public string CompInvestorPhone { get => _compInvestorPhone; set => SetField(ref _compInvestorPhone, value); }
        private DirtyValue<string> _compInvestorPostalCode;
        /// <summary>
        /// Rate Lock Comparison Side Investor Zipcode [3829]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Rate Lock Comparison Side Investor Zipcode")]
        public string CompInvestorPostalCode { get => _compInvestorPostalCode; set => SetField(ref _compInvestorPostalCode, value); }
        private DirtyValue<string> _compInvestorProgramCode;
        /// <summary>
        /// Rate Lock Comparison Investor Program Code [3833]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Investor Program Code")]
        public string CompInvestorProgramCode { get => _compInvestorProgramCode; set => SetField(ref _compInvestorProgramCode, value); }
        private DirtyValue<StringEnumValue<State>> _compInvestorState;
        /// <summary>
        /// Rate Lock Comparison Side Investor State [3828]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Side Investor State")]
        public StringEnumValue<State> CompInvestorState { get => _compInvestorState; set => SetField(ref _compInvestorState, value); }
        private DirtyValue<string> _compInvestorTemplateName;
        /// <summary>
        /// Rate Lock Comparison Investor Template Name [3838]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Investor Template Name")]
        public string CompInvestorTemplateName { get => _compInvestorTemplateName; set => SetField(ref _compInvestorTemplateName, value); }
        private DirtyValue<string> _compInvestorWebsite;
        /// <summary>
        /// Rate Lock Comparison Side Investor Website [3830]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Side Investor Website")]
        public string CompInvestorWebsite { get => _compInvestorWebsite; set => SetField(ref _compInvestorWebsite, value); }
        private DirtyList<PriceAdjustment> _compSideAdjustments;
        /// <summary>
        /// RateLock CompSideAdjustments
        /// </summary>
        public IList<PriceAdjustment> CompSideAdjustments { get => GetField(ref _compSideAdjustments); set => SetField(ref _compSideAdjustments, value); }
        private DirtyValue<string> _compSideComments;
        /// <summary>
        /// Rate Lock Comparison Comments [3834]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Comments")]
        public string CompSideComments { get => _compSideComments; set => SetField(ref _compSideComments, value); }
        private DirtyValue<string> _compSideComparisonedBy;
        /// <summary>
        /// Rate Lock Comparison Comparisoned By [3661]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Comparisoned By")]
        public string CompSideComparisonedBy { get => _compSideComparisonedBy; set => SetField(ref _compSideComparisonedBy, value); }
        private DirtyValue<DateTime?> _compSideCurrentRateSetDate;
        /// <summary>
        /// Rate Lock Comparison Last Rate Set Date [3663]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Last Rate Set Date")]
        public DateTime? CompSideCurrentRateSetDate { get => _compSideCurrentRateSetDate; set => SetField(ref _compSideCurrentRateSetDate, value); }
        private DirtyValue<int?> _compSideDaystoExtend;
        /// <summary>
        /// RateLock CompSideDaystoExtend
        /// </summary>
        public int? CompSideDaystoExtend { get => _compSideDaystoExtend; set => SetField(ref _compSideDaystoExtend, value); }
        private DirtyValue<decimal?> _compSideDiscountYSP;
        /// <summary>
        /// Rate Lock Comparison Discount YSP [3821]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Comparison Discount YSP")]
        public decimal? CompSideDiscountYSP { get => _compSideDiscountYSP; set => SetField(ref _compSideDiscountYSP, value); }
        private DirtyValue<DateTime?> _compSideExtendedLockExpires;
        /// <summary>
        /// RateLock CompSideExtendedLockExpires
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? CompSideExtendedLockExpires { get => _compSideExtendedLockExpires; set => SetField(ref _compSideExtendedLockExpires, value); }
        private DirtyValue<string> _compSideInvestorStatus;
        /// <summary>
        /// RateLock CompSideInvestorStatus
        /// </summary>
        public string CompSideInvestorStatus { get => _compSideInvestorStatus; set => SetField(ref _compSideInvestorStatus, value); }
        private DirtyValue<DateTime?> _compSideInvestorStatusDate;
        /// <summary>
        /// RateLock CompSideInvestorStatusDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? CompSideInvestorStatusDate { get => _compSideInvestorStatusDate; set => SetField(ref _compSideInvestorStatusDate, value); }
        private DirtyValue<string> _compSideInvestorTradeNumber;
        /// <summary>
        /// RateLock CompSideInvestorTradeNumber
        /// </summary>
        public string CompSideInvestorTradeNumber { get => _compSideInvestorTradeNumber; set => SetField(ref _compSideInvestorTradeNumber, value); }
        private DirtyValue<string> _compSideLoanProgram;
        /// <summary>
        /// Rate Lock Comparison Loan Program [3660]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Loan Program")]
        public string CompSideLoanProgram { get => _compSideLoanProgram; set => SetField(ref _compSideLoanProgram, value); }
        private DirtyValue<DateTime?> _compSideLockDate;
        /// <summary>
        /// Rate Lock Comparison Lock Date [3664]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Lock Date")]
        public DateTime? CompSideLockDate { get => _compSideLockDate; set => SetField(ref _compSideLockDate, value); }
        private DirtyValue<DateTime?> _compSideLockExpires;
        /// <summary>
        /// Rate Lock Comparison Lock Expires Date [3666]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Lock Expires Date")]
        public DateTime? CompSideLockExpires { get => _compSideLockExpires; set => SetField(ref _compSideLockExpires, value); }
        private DirtyValue<decimal?> _compSideLockExtendPriceAdjustment;
        /// <summary>
        /// RateLock CompSideLockExtendPriceAdjustment
        /// </summary>
        public decimal? CompSideLockExtendPriceAdjustment { get => _compSideLockExtendPriceAdjustment; set => SetField(ref _compSideLockExtendPriceAdjustment, value); }
        private DirtyValue<decimal?> _compSideMarginNetCompRate;
        /// <summary>
        /// Rate Lock Comparison Net Comparison ARM Margin [3819]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Comparison Net Comparison ARM Margin")]
        public decimal? CompSideMarginNetCompRate { get => _compSideMarginNetCompRate; set => SetField(ref _compSideMarginNetCompRate, value); }
        private DirtyValue<decimal?> _compSideMarginRate;
        /// <summary>
        /// Rate Lock Comparison Base Margin [3777]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Comparison Base Margin")]
        public decimal? CompSideMarginRate { get => _compSideMarginRate; set => SetField(ref _compSideMarginRate, value); }
        private DirtyValue<decimal?> _compSideMarginTotalAdjustment;
        /// <summary>
        /// Rate Lock Comparison Base Rate Total Adjust [3818]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Comparison Base Rate Total Adjust")]
        public decimal? CompSideMarginTotalAdjustment { get => _compSideMarginTotalAdjustment; set => SetField(ref _compSideMarginTotalAdjustment, value); }
        private DirtyValue<string> _compSideMasterContractNumber;
        /// <summary>
        /// RateLock CompSideMasterContractNumber
        /// </summary>
        public string CompSideMasterContractNumber { get => _compSideMasterContractNumber; set => SetField(ref _compSideMasterContractNumber, value); }
        private DirtyValue<decimal?> _compSideNetCompPrice;
        /// <summary>
        /// Rate Lock Comparison Base Price Rate Net Comparison Price [3776]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Comparison Base Price Rate Net Comparison Price")]
        public decimal? CompSideNetCompPrice { get => _compSideNetCompPrice; set => SetField(ref _compSideNetCompPrice, value); }
        private DirtyValue<decimal?> _compSideNetCompRate;
        /// <summary>
        /// Rate Lock Comparison Net Comparison Rate [3713]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Comparison Net Comparison Rate")]
        public decimal? CompSideNetCompRate { get => _compSideNetCompRate; set => SetField(ref _compSideNetCompRate, value); }
        private DirtyValue<int?> _compSideNumberOfDays;
        /// <summary>
        /// Rate Lock Comparison Number of Days [3665]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Number of Days")]
        public int? CompSideNumberOfDays { get => _compSideNumberOfDays; set => SetField(ref _compSideNumberOfDays, value); }
        private DirtyValue<DateTime?> _compSideOriginalLockExpires;
        /// <summary>
        /// RateLock CompSideOriginalLockExpires
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? CompSideOriginalLockExpires { get => _compSideOriginalLockExpires; set => SetField(ref _compSideOriginalLockExpires, value); }
        private DirtyValue<decimal?> _compSidePriceRate;
        /// <summary>
        /// Rate Lock Comparison Base Price Rate [3714]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Comparison Base Price Rate")]
        public decimal? CompSidePriceRate { get => _compSidePriceRate; set => SetField(ref _compSidePriceRate, value); }
        private DirtyValue<decimal?> _compSidePriceTotalAdjustment;
        /// <summary>
        /// Rate Lock Comparison Base Price Tot Adjustment [3775]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Comparison Base Price Tot Adjustment")]
        public decimal? CompSidePriceTotalAdjustment { get => _compSidePriceTotalAdjustment; set => SetField(ref _compSidePriceTotalAdjustment, value); }
        private DirtyValue<decimal?> _compSideRate;
        /// <summary>
        /// Rate Lock Comparison Base Rate [3671]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Comparison Base Rate")]
        public decimal? CompSideRate { get => _compSideRate; set => SetField(ref _compSideRate, value); }
        private DirtyValue<string> _compSideRateSheetID;
        /// <summary>
        /// Rate Lock Comparison Rate Sheet ID [3662]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Rate Sheet ID")]
        public string CompSideRateSheetID { get => _compSideRateSheetID; set => SetField(ref _compSideRateSheetID, value); }
        private DirtyValue<decimal?> _compSideRateTotalAdjustment;
        /// <summary>
        /// Rate Lock Comparison Base Rate Tot Adjustment [3712]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Comparison Base Rate Tot Adjustment")]
        public decimal? CompSideRateTotalAdjustment { get => _compSideRateTotalAdjustment; set => SetField(ref _compSideRateTotalAdjustment, value); }
        private DirtyValue<string> _compSideRequestedBy;
        /// <summary>
        /// RateLock CompSideRequestedBy
        /// </summary>
        public string CompSideRequestedBy { get => _compSideRequestedBy; set => SetField(ref _compSideRequestedBy, value); }
        private DirtyValue<StringEnumValue<ServicingType>> _compSideServicingType;
        /// <summary>
        /// Rate Lock Comparison Servicing Type [3831]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Servicing Type")]
        public StringEnumValue<ServicingType> CompSideServicingType { get => _compSideServicingType; set => SetField(ref _compSideServicingType, value); }
        private DirtyValue<decimal?> _compSideSRPPaidOut;
        /// <summary>
        /// Rate Lock Comparison SRP Paid Out [3820]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Comparison SRP Paid Out")]
        public decimal? CompSideSRPPaidOut { get => _compSideSRPPaidOut; set => SetField(ref _compSideSRPPaidOut, value); }
        private DirtyValue<string> _compSideTradeGuid;
        /// <summary>
        /// RateLock CompSideTradeGuid
        /// </summary>
        public string CompSideTradeGuid { get => _compSideTradeGuid; set => SetField(ref _compSideTradeGuid, value); }
        private DirtyValue<string> _compSideTradeNumber;
        /// <summary>
        /// RateLock CompSideTradeNumber
        /// </summary>
        public string CompSideTradeNumber { get => _compSideTradeNumber; set => SetField(ref _compSideTradeNumber, value); }
        private DirtyValue<string> _confirmedBy;
        /// <summary>
        /// Purchase Advice Confirmed By [2396]
        /// </summary>
        [LoanFieldProperty(Description = "Purchase Advice Confirmed By")]
        public string ConfirmedBy { get => _confirmedBy; set => SetField(ref _confirmedBy, value); }
        private DirtyValue<DateTime?> _confirmedDate;
        /// <summary>
        /// Purchase Advice Confirmed Date [2630]
        /// </summary>
        [LoanFieldProperty(Description = "Purchase Advice Confirmed Date")]
        public DateTime? ConfirmedDate { get => _confirmedDate; set => SetField(ref _confirmedDate, value); }
        private DirtyValue<DateTime?> _corporateApprovalDate;
        /// <summary>
        /// Rate Lock Buy Side Corporate Concession Approval Date [3372]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Buy Side Corporate Concession Approval Date")]
        public DateTime? CorporateApprovalDate { get => _corporateApprovalDate; set => SetField(ref _corporateApprovalDate, value); }
        private DirtyValue<string> _corporateApprovedby;
        /// <summary>
        /// Rate Lock Buy Side Corporate Concession Approved by [3373]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Buy Side Corporate Concession Approved by")]
        public string CorporateApprovedby { get => _corporateApprovedby; set => SetField(ref _corporateApprovedby, value); }
        private DirtyValue<decimal?> _corporatePrice;
        /// <summary>
        /// Rate Lock Buy Side Corporate Price Concession [3371]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Buy Side Corporate Price Concession")]
        public decimal? CorporatePrice { get => _corporatePrice; set => SetField(ref _corporatePrice, value); }
        private DirtyValue<decimal?> _correspondentAdditionalEscrowAdditionalEscrow;
        /// <summary>
        /// Additional Escrow Payment Collection - Additional Escrow [CPA.ADDLESCROW.AdditionalEscrow]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Additional Escrow Payment Collection - Additional Escrow")]
        public decimal? CorrespondentAdditionalEscrowAdditionalEscrow { get => _correspondentAdditionalEscrowAdditionalEscrow; set => SetField(ref _correspondentAdditionalEscrowAdditionalEscrow, value); }
        private DirtyValue<decimal?> _correspondentAdditionalEscrowAmount1007;
        /// <summary>
        /// Additional Escrow Payment Collection - Line 1007 Amount [CPA.ADDLESCROW.1007Amount]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Additional Escrow Payment Collection - Line 1007 Amount")]
        public decimal? CorrespondentAdditionalEscrowAmount1007 { get => _correspondentAdditionalEscrowAmount1007; set => SetField(ref _correspondentAdditionalEscrowAmount1007, value); }
        private DirtyValue<decimal?> _correspondentAdditionalEscrowAmount1008;
        /// <summary>
        /// Additional Escrow Payment Collection - Line 1008 Amount [CPA.ADDLESCROW.1008Amount]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Additional Escrow Payment Collection - Line 1008 Amount")]
        public decimal? CorrespondentAdditionalEscrowAmount1008 { get => _correspondentAdditionalEscrowAmount1008; set => SetField(ref _correspondentAdditionalEscrowAmount1008, value); }
        private DirtyValue<decimal?> _correspondentAdditionalEscrowAmount1009;
        /// <summary>
        /// Additional Escrow Payment Collection - Line 1009 Amount [CPA.ADDLESCROW.1009Amount]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Additional Escrow Payment Collection - Line 1009 Amount")]
        public decimal? CorrespondentAdditionalEscrowAmount1009 { get => _correspondentAdditionalEscrowAmount1009; set => SetField(ref _correspondentAdditionalEscrowAmount1009, value); }
        private DirtyValue<decimal?> _correspondentAdditionalEscrowCityPropertyTax;
        /// <summary>
        /// Additional Escrow Payment Collection - City Property Tax [CPA.ADDLESCROW.CityPropertyTax]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Additional Escrow Payment Collection - City Property Tax")]
        public decimal? CorrespondentAdditionalEscrowCityPropertyTax { get => _correspondentAdditionalEscrowCityPropertyTax; set => SetField(ref _correspondentAdditionalEscrowCityPropertyTax, value); }
        private DirtyValue<string> _correspondentAdditionalEscrowDescription1007;
        /// <summary>
        /// Additional Escrow Payment Collection - Line 1007 Description [CPA.ADDLESCROW.1007Description]
        /// </summary>
        [LoanFieldProperty(Description = "Additional Escrow Payment Collection - Line 1007 Description")]
        public string CorrespondentAdditionalEscrowDescription1007 { get => _correspondentAdditionalEscrowDescription1007; set => SetField(ref _correspondentAdditionalEscrowDescription1007, value); }
        private DirtyValue<string> _correspondentAdditionalEscrowDescription1008;
        /// <summary>
        /// Additional Escrow Payment Collection - Line 1008 Description [CPA.ADDLESCROW.1008Description]
        /// </summary>
        [LoanFieldProperty(Description = "Additional Escrow Payment Collection - Line 1008 Description")]
        public string CorrespondentAdditionalEscrowDescription1008 { get => _correspondentAdditionalEscrowDescription1008; set => SetField(ref _correspondentAdditionalEscrowDescription1008, value); }
        private DirtyValue<string> _correspondentAdditionalEscrowDescription1009;
        /// <summary>
        /// Additional Escrow Payment Collection - Line 1009 Description [CPA.ADDLESCROW.1009Description]
        /// </summary>
        [LoanFieldProperty(Description = "Additional Escrow Payment Collection - Line 1009 Description")]
        public string CorrespondentAdditionalEscrowDescription1009 { get => _correspondentAdditionalEscrowDescription1009; set => SetField(ref _correspondentAdditionalEscrowDescription1009, value); }
        private DirtyValue<decimal?> _correspondentAdditionalEscrowFloodInsurance;
        /// <summary>
        /// Additional Escrow Payment Collection - Flood Insurance [CPA.ADDLESCROW.FloodInsurance]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Additional Escrow Payment Collection - Flood Insurance")]
        public decimal? CorrespondentAdditionalEscrowFloodInsurance { get => _correspondentAdditionalEscrowFloodInsurance; set => SetField(ref _correspondentAdditionalEscrowFloodInsurance, value); }
        private DirtyValue<decimal?> _correspondentAdditionalEscrowHomeInsurance;
        /// <summary>
        /// Additional Escrow Payment Collection - Homeowners Insurance [CPA.ADDLESCROW.HomeInsurance]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Additional Escrow Payment Collection - Homeowners Insurance")]
        public decimal? CorrespondentAdditionalEscrowHomeInsurance { get => _correspondentAdditionalEscrowHomeInsurance; set => SetField(ref _correspondentAdditionalEscrowHomeInsurance, value); }
        private DirtyValue<decimal?> _correspondentAdditionalEscrowMIMIP;
        /// <summary>
        /// Additional Escrow Payment Collection - MI/MIP [CPA.ADDLESCROW.MIMIP]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Additional Escrow Payment Collection - MI/MIP")]
        public decimal? CorrespondentAdditionalEscrowMIMIP { get => _correspondentAdditionalEscrowMIMIP; set => SetField(ref _correspondentAdditionalEscrowMIMIP, value); }
        private DirtyValue<int?> _correspondentAdditionalEscrowNumOfPayments;
        /// <summary>
        /// Additional Escrow Payment Collection - Number of Payments [CPA.ADDLESCROW.NumOfPayments]
        /// </summary>
        [LoanFieldProperty(Description = "Additional Escrow Payment Collection - Number of Payments")]
        public int? CorrespondentAdditionalEscrowNumOfPayments { get => _correspondentAdditionalEscrowNumOfPayments; set => SetField(ref _correspondentAdditionalEscrowNumOfPayments, value); }
        private DirtyValue<decimal?> _correspondentAdditionalEscrowOption1Amount;
        /// <summary>
        /// Additional Escrow Payment Collection - Additional Amount Value 1 [CPA.ADDLESCROW.Option1Amount]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Additional Escrow Payment Collection - Additional Amount Value 1")]
        public decimal? CorrespondentAdditionalEscrowOption1Amount { get => _correspondentAdditionalEscrowOption1Amount; set => SetField(ref _correspondentAdditionalEscrowOption1Amount, value); }
        private DirtyValue<StringEnumValue<CorrespondentOptionDesc>> _correspondentAdditionalEscrowOption1Desc;
        /// <summary>
        /// Additional Escrow Payment Collection - Additional Amount Description 1 [CPA.ADDLESCROW.Option1Desc]
        /// </summary>
        [LoanFieldProperty(Description = "Additional Escrow Payment Collection - Additional Amount Description 1")]
        public StringEnumValue<CorrespondentOptionDesc> CorrespondentAdditionalEscrowOption1Desc { get => _correspondentAdditionalEscrowOption1Desc; set => SetField(ref _correspondentAdditionalEscrowOption1Desc, value); }
        private DirtyValue<decimal?> _correspondentAdditionalEscrowOption2Amount;
        /// <summary>
        /// Additional Escrow Payment Collection - Additional Amount Value 2 [CPA.ADDLESCROW.Option2Amount]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Additional Escrow Payment Collection - Additional Amount Value 2")]
        public decimal? CorrespondentAdditionalEscrowOption2Amount { get => _correspondentAdditionalEscrowOption2Amount; set => SetField(ref _correspondentAdditionalEscrowOption2Amount, value); }
        private DirtyValue<StringEnumValue<CorrespondentOptionDesc>> _correspondentAdditionalEscrowOption2Desc;
        /// <summary>
        /// Additional Escrow Payment Collection - Additional Amount Description 2 [CPA.ADDLESCROW.Option2Desc]
        /// </summary>
        [LoanFieldProperty(Description = "Additional Escrow Payment Collection - Additional Amount Description 2")]
        public StringEnumValue<CorrespondentOptionDesc> CorrespondentAdditionalEscrowOption2Desc { get => _correspondentAdditionalEscrowOption2Desc; set => SetField(ref _correspondentAdditionalEscrowOption2Desc, value); }
        private DirtyValue<decimal?> _correspondentAdditionalEscrowPropertyTax;
        /// <summary>
        /// Additional Escrow Payment Collection - Property Tax [CPA.ADDLESCROW.PropertyTax]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Additional Escrow Payment Collection - Property Tax")]
        public decimal? CorrespondentAdditionalEscrowPropertyTax { get => _correspondentAdditionalEscrowPropertyTax; set => SetField(ref _correspondentAdditionalEscrowPropertyTax, value); }
        private DirtyValue<decimal?> _correspondentAdditionalEscrowSumOfPayments;
        /// <summary>
        /// Additional Escrow Payment Collection - Sum of Payments [CPA.ADDLESCROW.SumOfPayments]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Additional Escrow Payment Collection - Sum of Payments")]
        public decimal? CorrespondentAdditionalEscrowSumOfPayments { get => _correspondentAdditionalEscrowSumOfPayments; set => SetField(ref _correspondentAdditionalEscrowSumOfPayments, value); }
        private DirtyValue<decimal?> _correspondentAdditionalEscrowUSDAAnnualFee;
        /// <summary>
        /// Additional Escrow Payment Collection - USDA Annual Fee [CPA.ADDLESCROW.USDAAnnualFee]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Additional Escrow Payment Collection - USDA Annual Fee")]
        public decimal? CorrespondentAdditionalEscrowUSDAAnnualFee { get => _correspondentAdditionalEscrowUSDAAnnualFee; set => SetField(ref _correspondentAdditionalEscrowUSDAAnnualFee, value); }
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount1;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 1 [3588]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Additional Amount 1")]
        public decimal? CorrespondentAdditionalLineAmount1 { get => _correspondentAdditionalLineAmount1; set => SetField(ref _correspondentAdditionalLineAmount1, value); }
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount10;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 10 [3606]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Additional Amount 10")]
        public decimal? CorrespondentAdditionalLineAmount10 { get => _correspondentAdditionalLineAmount10; set => SetField(ref _correspondentAdditionalLineAmount10, value); }
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount11;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 11 [3608]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Additional Amount 11")]
        public decimal? CorrespondentAdditionalLineAmount11 { get => _correspondentAdditionalLineAmount11; set => SetField(ref _correspondentAdditionalLineAmount11, value); }
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount12;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 12 [3610]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Additional Amount 12")]
        public decimal? CorrespondentAdditionalLineAmount12 { get => _correspondentAdditionalLineAmount12; set => SetField(ref _correspondentAdditionalLineAmount12, value); }
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount13;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Total Amount [3970]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Additional Total Amount")]
        public decimal? CorrespondentAdditionalLineAmount13 { get => _correspondentAdditionalLineAmount13; set => SetField(ref _correspondentAdditionalLineAmount13, value); }
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount2;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 2 [3590]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Additional Amount 2")]
        public decimal? CorrespondentAdditionalLineAmount2 { get => _correspondentAdditionalLineAmount2; set => SetField(ref _correspondentAdditionalLineAmount2, value); }
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount3;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 3 [3592]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Additional Amount 3")]
        public decimal? CorrespondentAdditionalLineAmount3 { get => _correspondentAdditionalLineAmount3; set => SetField(ref _correspondentAdditionalLineAmount3, value); }
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount4;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 4 [3594]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Additional Amount 4")]
        public decimal? CorrespondentAdditionalLineAmount4 { get => _correspondentAdditionalLineAmount4; set => SetField(ref _correspondentAdditionalLineAmount4, value); }
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount5;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 5 [3596]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Additional Amount 5")]
        public decimal? CorrespondentAdditionalLineAmount5 { get => _correspondentAdditionalLineAmount5; set => SetField(ref _correspondentAdditionalLineAmount5, value); }
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount6;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 6 [3598]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Additional Amount 6")]
        public decimal? CorrespondentAdditionalLineAmount6 { get => _correspondentAdditionalLineAmount6; set => SetField(ref _correspondentAdditionalLineAmount6, value); }
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount7;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 7 [3600]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Additional Amount 7")]
        public decimal? CorrespondentAdditionalLineAmount7 { get => _correspondentAdditionalLineAmount7; set => SetField(ref _correspondentAdditionalLineAmount7, value); }
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount8;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 8 [3602]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Additional Amount 8")]
        public decimal? CorrespondentAdditionalLineAmount8 { get => _correspondentAdditionalLineAmount8; set => SetField(ref _correspondentAdditionalLineAmount8, value); }
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount9;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 9 [3604]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Additional Amount 9")]
        public decimal? CorrespondentAdditionalLineAmount9 { get => _correspondentAdditionalLineAmount9; set => SetField(ref _correspondentAdditionalLineAmount9, value); }
        private DirtyValue<string> _correspondentAdditionalLineDescription1;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Description 1 [3587]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Additional Purchase Details Additional Description 1")]
        public string CorrespondentAdditionalLineDescription1 { get => _correspondentAdditionalLineDescription1; set => SetField(ref _correspondentAdditionalLineDescription1, value); }
        private DirtyValue<string> _correspondentAdditionalLineDescription10;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Description 10 [3605]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Additional Purchase Details Additional Description 10")]
        public string CorrespondentAdditionalLineDescription10 { get => _correspondentAdditionalLineDescription10; set => SetField(ref _correspondentAdditionalLineDescription10, value); }
        private DirtyValue<string> _correspondentAdditionalLineDescription11;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Description 11 [3607]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Additional Purchase Details Additional Description 11")]
        public string CorrespondentAdditionalLineDescription11 { get => _correspondentAdditionalLineDescription11; set => SetField(ref _correspondentAdditionalLineDescription11, value); }
        private DirtyValue<string> _correspondentAdditionalLineDescription12;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Description 12 [3609]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Additional Purchase Details Additional Description 12")]
        public string CorrespondentAdditionalLineDescription12 { get => _correspondentAdditionalLineDescription12; set => SetField(ref _correspondentAdditionalLineDescription12, value); }
        private DirtyValue<string> _correspondentAdditionalLineDescription2;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Description 2 [3589]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Additional Purchase Details Additional Description 2")]
        public string CorrespondentAdditionalLineDescription2 { get => _correspondentAdditionalLineDescription2; set => SetField(ref _correspondentAdditionalLineDescription2, value); }
        private DirtyValue<string> _correspondentAdditionalLineDescription3;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Description 3 [3591]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Additional Purchase Details Additional Description 3")]
        public string CorrespondentAdditionalLineDescription3 { get => _correspondentAdditionalLineDescription3; set => SetField(ref _correspondentAdditionalLineDescription3, value); }
        private DirtyValue<string> _correspondentAdditionalLineDescription4;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Description 4 [3593]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Additional Purchase Details Additional Description 4")]
        public string CorrespondentAdditionalLineDescription4 { get => _correspondentAdditionalLineDescription4; set => SetField(ref _correspondentAdditionalLineDescription4, value); }
        private DirtyValue<string> _correspondentAdditionalLineDescription5;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Description 5 [3595]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Additional Purchase Details Additional Description 5")]
        public string CorrespondentAdditionalLineDescription5 { get => _correspondentAdditionalLineDescription5; set => SetField(ref _correspondentAdditionalLineDescription5, value); }
        private DirtyValue<string> _correspondentAdditionalLineDescription6;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Description 6 [3597]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Additional Purchase Details Additional Description 6")]
        public string CorrespondentAdditionalLineDescription6 { get => _correspondentAdditionalLineDescription6; set => SetField(ref _correspondentAdditionalLineDescription6, value); }
        private DirtyValue<string> _correspondentAdditionalLineDescription7;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Description 7 [3599]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Additional Purchase Details Additional Description 7")]
        public string CorrespondentAdditionalLineDescription7 { get => _correspondentAdditionalLineDescription7; set => SetField(ref _correspondentAdditionalLineDescription7, value); }
        private DirtyValue<string> _correspondentAdditionalLineDescription8;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Description 8 [3601]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Additional Purchase Details Additional Description 8")]
        public string CorrespondentAdditionalLineDescription8 { get => _correspondentAdditionalLineDescription8; set => SetField(ref _correspondentAdditionalLineDescription8, value); }
        private DirtyValue<string> _correspondentAdditionalLineDescription9;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Description 9 [3603]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Additional Purchase Details Additional Description 9")]
        public string CorrespondentAdditionalLineDescription9 { get => _correspondentAdditionalLineDescription9; set => SetField(ref _correspondentAdditionalLineDescription9, value); }
        private DirtyValue<decimal?> _correspondentAdditionalLineTotalAmount;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Total Amount [3611]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Additional Total Amount")]
        public decimal? CorrespondentAdditionalLineTotalAmount { get => _correspondentAdditionalLineTotalAmount; set => SetField(ref _correspondentAdditionalLineTotalAmount, value); }
        private DirtyValue<decimal?> _correspondentAdjusterAmount1;
        /// <summary>
        /// Correspondent Purchase Advice Additional Adjusters 1 Amount [3573]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Correspondent Purchase Advice Additional Adjusters 1 Amount")]
        public decimal? CorrespondentAdjusterAmount1 { get => _correspondentAdjusterAmount1; set => SetField(ref _correspondentAdjusterAmount1, value); }
        private DirtyValue<decimal?> _correspondentAdjusterAmount2;
        /// <summary>
        /// Correspondent Purchase Advice Additional Adjusters 2 Amount [3575]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Correspondent Purchase Advice Additional Adjusters 2 Amount")]
        public decimal? CorrespondentAdjusterAmount2 { get => _correspondentAdjusterAmount2; set => SetField(ref _correspondentAdjusterAmount2, value); }
        private DirtyValue<decimal?> _correspondentAdjusterAmount3;
        /// <summary>
        /// Correspondent Purchase Advice Additional Adjusters 3 Amount [3577]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Correspondent Purchase Advice Additional Adjusters 3 Amount")]
        public decimal? CorrespondentAdjusterAmount3 { get => _correspondentAdjusterAmount3; set => SetField(ref _correspondentAdjusterAmount3, value); }
        private DirtyValue<string> _correspondentAdjusterDescription1;
        /// <summary>
        /// Correspondent Purchase Advice Additional Adjusters 1 Description [3572]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Additional Adjusters 1 Description")]
        public string CorrespondentAdjusterDescription1 { get => _correspondentAdjusterDescription1; set => SetField(ref _correspondentAdjusterDescription1, value); }
        private DirtyValue<string> _correspondentAdjusterDescription2;
        /// <summary>
        /// Correspondent Purchase Advice Additional Adjusters 2 Description [3574]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Additional Adjusters 2 Description")]
        public string CorrespondentAdjusterDescription2 { get => _correspondentAdjusterDescription2; set => SetField(ref _correspondentAdjusterDescription2, value); }
        private DirtyValue<string> _correspondentAdjusterDescription3;
        /// <summary>
        /// Correspondent Purchase Advice Additional Adjusters 3 Description [3576]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Additional Adjusters 3 Description")]
        public string CorrespondentAdjusterDescription3 { get => _correspondentAdjusterDescription3; set => SetField(ref _correspondentAdjusterDescription3, value); }
        private DirtyValue<string> _correspondentConfirmedBy;
        /// <summary>
        /// Correspondent Purchase Advice Confirmed By [3612]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Confirmed By")]
        public string CorrespondentConfirmedBy { get => _correspondentConfirmedBy; set => SetField(ref _correspondentConfirmedBy, value); }
        private DirtyValue<DateTime?> _correspondentConfirmedDate;
        /// <summary>
        /// Correspondent Purchase Advice Confirmed Date [3613]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Confirmed Date")]
        public DateTime? CorrespondentConfirmedDate { get => _correspondentConfirmedDate; set => SetField(ref _correspondentConfirmedDate, value); }
        private DirtyValue<decimal?> _correspondentCurrentImpounds;
        /// <summary>
        /// Correspondent Purchase Advice Current Impounds [3568]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Current Impounds")]
        public decimal? CorrespondentCurrentImpounds { get => _correspondentCurrentImpounds; set => SetField(ref _correspondentCurrentImpounds, value); }
        private DirtyValue<decimal?> _correspondentCurrentPrincipal;
        /// <summary>
        /// Correspondent Purchase Advice Current Principal [3571]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Current Principal")]
        public decimal? CorrespondentCurrentPrincipal { get => _correspondentCurrentPrincipal; set => SetField(ref _correspondentCurrentPrincipal, value); }
        private DirtyValue<DateTime?> _correspondentDate;
        /// <summary>
        /// Correspondent Purchase Advice Date [3567]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Date")]
        public DateTime? CorrespondentDate { get => _correspondentDate; set => SetField(ref _correspondentDate, value); }
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsAmount1007;
        /// <summary>
        /// Escrow Disbursements - Line 1007 Amount [CPA.ESCROWDISBURSE.1007Amount]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow Disbursements - Line 1007 Amount")]
        public decimal? CorrespondentEscrowDisbursementsAmount1007 { get => _correspondentEscrowDisbursementsAmount1007; set => SetField(ref _correspondentEscrowDisbursementsAmount1007, value); }
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsAmount1008;
        /// <summary>
        /// Escrow Disbursements - Line 1008 Amount [CPA.ESCROWDISBURSE.1008Amount]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow Disbursements - Line 1008 Amount")]
        public decimal? CorrespondentEscrowDisbursementsAmount1008 { get => _correspondentEscrowDisbursementsAmount1008; set => SetField(ref _correspondentEscrowDisbursementsAmount1008, value); }
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsAmount1009;
        /// <summary>
        /// Escrow Disbursements - Line 1009 Amount [CPA.ESCROWDISBURSE.1009Amount]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow Disbursements - Line 1009 Amount")]
        public decimal? CorrespondentEscrowDisbursementsAmount1009 { get => _correspondentEscrowDisbursementsAmount1009; set => SetField(ref _correspondentEscrowDisbursementsAmount1009, value); }
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsCityPropertyTax;
        /// <summary>
        /// Escrow Disbursements - City Property Tax [CPA.ESCROWDISBURSE.CityPropertyTax]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow Disbursements - City Property Tax")]
        public decimal? CorrespondentEscrowDisbursementsCityPropertyTax { get => _correspondentEscrowDisbursementsCityPropertyTax; set => SetField(ref _correspondentEscrowDisbursementsCityPropertyTax, value); }
        private DirtyValue<string> _correspondentEscrowDisbursementsDescription1007;
        /// <summary>
        /// Escrow Disbursements - Line 1007 Description [CPA.ESCROWDISBURSE.1007Description]
        /// </summary>
        [LoanFieldProperty(Description = "Escrow Disbursements - Line 1007 Description")]
        public string CorrespondentEscrowDisbursementsDescription1007 { get => _correspondentEscrowDisbursementsDescription1007; set => SetField(ref _correspondentEscrowDisbursementsDescription1007, value); }
        private DirtyValue<string> _correspondentEscrowDisbursementsDescription1008;
        /// <summary>
        /// Escrow Disbursements - Line 1008 Description [CPA.ESCROWDISBURSE.1008Description]
        /// </summary>
        [LoanFieldProperty(Description = "Escrow Disbursements - Line 1008 Description")]
        public string CorrespondentEscrowDisbursementsDescription1008 { get => _correspondentEscrowDisbursementsDescription1008; set => SetField(ref _correspondentEscrowDisbursementsDescription1008, value); }
        private DirtyValue<string> _correspondentEscrowDisbursementsDescription1009;
        /// <summary>
        /// Escrow Disbursements - Line 1009 Description [CPA.ESCROWDISBURSE.1009Description]
        /// </summary>
        [LoanFieldProperty(Description = "Escrow Disbursements - Line 1009 Description")]
        public string CorrespondentEscrowDisbursementsDescription1009 { get => _correspondentEscrowDisbursementsDescription1009; set => SetField(ref _correspondentEscrowDisbursementsDescription1009, value); }
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsEscrowsToBePaidBySeller;
        /// <summary>
        /// Escrow Disbursements - Escrows to be paid by Seller [CPA.ESCROWDISBURSE.EscrowsToBePaidBySeller]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow Disbursements - Escrows to be paid by Seller")]
        public decimal? CorrespondentEscrowDisbursementsEscrowsToBePaidBySeller { get => _correspondentEscrowDisbursementsEscrowsToBePaidBySeller; set => SetField(ref _correspondentEscrowDisbursementsEscrowsToBePaidBySeller, value); }
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsEsrowFundedByInvestor;
        /// <summary>
        /// Escrow Disbursements - Total Escrow Net Funded by Investor [CPA.ESCROWDISBURSE.EsrowFundedByInvestor]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow Disbursements - Total Escrow Net Funded by Investor")]
        public decimal? CorrespondentEscrowDisbursementsEsrowFundedByInvestor { get => _correspondentEscrowDisbursementsEsrowFundedByInvestor; set => SetField(ref _correspondentEscrowDisbursementsEsrowFundedByInvestor, value); }
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsFloodInsurance;
        /// <summary>
        /// Escrow Disbursements - Flood Insurance [CPA.ESCROWDISBURSE.FloodInsurance]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow Disbursements - Flood Insurance")]
        public decimal? CorrespondentEscrowDisbursementsFloodInsurance { get => _correspondentEscrowDisbursementsFloodInsurance; set => SetField(ref _correspondentEscrowDisbursementsFloodInsurance, value); }
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsHomeInsurance;
        /// <summary>
        /// Escrow Disbursements - Homeowners Insurance [CPA.ESCROWDISBURSE.HomeInsurance]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow Disbursements - Homeowners Insurance")]
        public decimal? CorrespondentEscrowDisbursementsHomeInsurance { get => _correspondentEscrowDisbursementsHomeInsurance; set => SetField(ref _correspondentEscrowDisbursementsHomeInsurance, value); }
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsMortgageInsurance;
        /// <summary>
        /// Escrow Disbursements - Mortgage Insurance [CPA.ESCROWDISBURSE.MortgageInsurance]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow Disbursements - Mortgage Insurance")]
        public decimal? CorrespondentEscrowDisbursementsMortgageInsurance { get => _correspondentEscrowDisbursementsMortgageInsurance; set => SetField(ref _correspondentEscrowDisbursementsMortgageInsurance, value); }
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsOption1Amount;
        /// <summary>
        /// Escrow Disbursements - Additional Amount Value 1 [CPA.ESCROWDISBURSE.Option1Amount]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow Disbursements - Additional Amount Value 1")]
        public decimal? CorrespondentEscrowDisbursementsOption1Amount { get => _correspondentEscrowDisbursementsOption1Amount; set => SetField(ref _correspondentEscrowDisbursementsOption1Amount, value); }
        private DirtyValue<StringEnumValue<CorrespondentOptionDesc>> _correspondentEscrowDisbursementsOption1Desc;
        /// <summary>
        /// Escrow Disbursements - Additional Amount Description 1 [CPA.ESCROWDISBURSE.Option1Desc]
        /// </summary>
        [LoanFieldProperty(Description = "Escrow Disbursements - Additional Amount Description 1")]
        public StringEnumValue<CorrespondentOptionDesc> CorrespondentEscrowDisbursementsOption1Desc { get => _correspondentEscrowDisbursementsOption1Desc; set => SetField(ref _correspondentEscrowDisbursementsOption1Desc, value); }
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsOption2Amount;
        /// <summary>
        /// Escrow Disbursements - Additional Amount Value 2 [CPA.ESCROWDISBURSE.Option2Amount]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow Disbursements - Additional Amount Value 2")]
        public decimal? CorrespondentEscrowDisbursementsOption2Amount { get => _correspondentEscrowDisbursementsOption2Amount; set => SetField(ref _correspondentEscrowDisbursementsOption2Amount, value); }
        private DirtyValue<StringEnumValue<CorrespondentOptionDesc>> _correspondentEscrowDisbursementsOption2Desc;
        /// <summary>
        /// Escrow Disbursements - Additional Amount Description 2 [CPA.ESCROWDISBURSE.Option2Desc]
        /// </summary>
        [LoanFieldProperty(Description = "Escrow Disbursements - Additional Amount Description 2")]
        public StringEnumValue<CorrespondentOptionDesc> CorrespondentEscrowDisbursementsOption2Desc { get => _correspondentEscrowDisbursementsOption2Desc; set => SetField(ref _correspondentEscrowDisbursementsOption2Desc, value); }
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsPropertyTax;
        /// <summary>
        /// Escrow Disbursements - Property Tax [CPA.ESCROWDISBURSE.PropertyTax]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow Disbursements - Property Tax")]
        public decimal? CorrespondentEscrowDisbursementsPropertyTax { get => _correspondentEscrowDisbursementsPropertyTax; set => SetField(ref _correspondentEscrowDisbursementsPropertyTax, value); }
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsUSDAAnnualFee;
        /// <summary>
        /// Escrow Disbursements - USDA Annual Fee [CPA.ESCROWDISBURSE.USDAAnnualFee]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow Disbursements - USDA Annual Fee")]
        public decimal? CorrespondentEscrowDisbursementsUSDAAnnualFee { get => _correspondentEscrowDisbursementsUSDAAnnualFee; set => SetField(ref _correspondentEscrowDisbursementsUSDAAnnualFee, value); }
        private DirtyValue<decimal?> _correspondentFinalBuyAmount;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Final Buy Amount [3583]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Final Buy Amount")]
        public decimal? CorrespondentFinalBuyAmount { get => _correspondentFinalBuyAmount; set => SetField(ref _correspondentFinalBuyAmount, value); }
        private DirtyValue<decimal?> _correspondentFinalBuyPrice;
        /// <summary>
        /// Correspondent Purchase Advice Additional Adjusters Final Buy Price [3578]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Correspondent Purchase Advice Additional Adjusters Final Buy Price")]
        public decimal? CorrespondentFinalBuyPrice { get => _correspondentFinalBuyPrice; set => SetField(ref _correspondentFinalBuyPrice, value); }
        private DirtyValue<decimal?> _correspondentFinalCDAggAdjAmount;
        /// <summary>
        /// Final CD - Aggregate Adjustment Amount [CPA.FCD.AggAdjAmount]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Final CD - Aggregate Adjustment Amount")]
        public decimal? CorrespondentFinalCDAggAdjAmount { get => _correspondentFinalCDAggAdjAmount; set => SetField(ref _correspondentFinalCDAggAdjAmount, value); }
        private DirtyValue<decimal?> _correspondentFinalCDAmount1007;
        /// <summary>
        /// Final CD - Line 1007 Amount [CPA.FCD.1007Amount]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Final CD - Line 1007 Amount")]
        public decimal? CorrespondentFinalCDAmount1007 { get => _correspondentFinalCDAmount1007; set => SetField(ref _correspondentFinalCDAmount1007, value); }
        private DirtyValue<decimal?> _correspondentFinalCDAmount1008;
        /// <summary>
        /// Final CD - Line 1008 Amount [CPA.FCD.1008Amount]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Final CD - Line 1008 Amount")]
        public decimal? CorrespondentFinalCDAmount1008 { get => _correspondentFinalCDAmount1008; set => SetField(ref _correspondentFinalCDAmount1008, value); }
        private DirtyValue<decimal?> _correspondentFinalCDAmount1009;
        /// <summary>
        /// Final CD - Line 1009 Amount [CPA.FCD.1009Amount]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Final CD - Line 1009 Amount")]
        public decimal? CorrespondentFinalCDAmount1009 { get => _correspondentFinalCDAmount1009; set => SetField(ref _correspondentFinalCDAmount1009, value); }
        private DirtyValue<decimal?> _correspondentFinalCDCityPropertyTax;
        /// <summary>
        /// Final CD - City Property Tax [CPA.FCD.CityPropertyTax]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Final CD - City Property Tax")]
        public decimal? CorrespondentFinalCDCityPropertyTax { get => _correspondentFinalCDCityPropertyTax; set => SetField(ref _correspondentFinalCDCityPropertyTax, value); }
        private DirtyValue<string> _correspondentFinalCDDescription1007;
        /// <summary>
        /// Final CD - Line 1007 Description [CPA.FCD.1007Description]
        /// </summary>
        [LoanFieldProperty(Description = "Final CD - Line 1007 Description")]
        public string CorrespondentFinalCDDescription1007 { get => _correspondentFinalCDDescription1007; set => SetField(ref _correspondentFinalCDDescription1007, value); }
        private DirtyValue<string> _correspondentFinalCDDescription1008;
        /// <summary>
        /// Final CD - Line 1008 Description [CPA.FCD.1008Description]
        /// </summary>
        [LoanFieldProperty(Description = "Final CD - Line 1008 Description")]
        public string CorrespondentFinalCDDescription1008 { get => _correspondentFinalCDDescription1008; set => SetField(ref _correspondentFinalCDDescription1008, value); }
        private DirtyValue<string> _correspondentFinalCDDescription1009;
        /// <summary>
        /// Final CD - Line 1009 Description [CPA.FCD.1009Description]
        /// </summary>
        [LoanFieldProperty(Description = "Final CD - Line 1009 Description")]
        public string CorrespondentFinalCDDescription1009 { get => _correspondentFinalCDDescription1009; set => SetField(ref _correspondentFinalCDDescription1009, value); }
        private DirtyValue<decimal?> _correspondentFinalCDFloodInsurance;
        /// <summary>
        /// Final CD - Flood Insurance [CPA.FCD.FloodInsurance]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Final CD - Flood Insurance")]
        public decimal? CorrespondentFinalCDFloodInsurance { get => _correspondentFinalCDFloodInsurance; set => SetField(ref _correspondentFinalCDFloodInsurance, value); }
        private DirtyValue<decimal?> _correspondentFinalCDHomeInsurance;
        /// <summary>
        /// Final CD - Homeowners Insurance [CPA.FCD.HomeInsurance]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Final CD - Homeowners Insurance")]
        public decimal? CorrespondentFinalCDHomeInsurance { get => _correspondentFinalCDHomeInsurance; set => SetField(ref _correspondentFinalCDHomeInsurance, value); }
        private DirtyValue<decimal?> _correspondentFinalCDMortgageInsurance;
        /// <summary>
        /// Final CD - Mortgage Insurance [CPA.FCD.MortgageInsurance]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Final CD - Mortgage Insurance")]
        public decimal? CorrespondentFinalCDMortgageInsurance { get => _correspondentFinalCDMortgageInsurance; set => SetField(ref _correspondentFinalCDMortgageInsurance, value); }
        private DirtyValue<decimal?> _correspondentFinalCDOption1Amount;
        /// <summary>
        /// Final CD - Additional Amount Value 1 [CPA.FCD.Option1Amount]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Final CD - Additional Amount Value 1")]
        public decimal? CorrespondentFinalCDOption1Amount { get => _correspondentFinalCDOption1Amount; set => SetField(ref _correspondentFinalCDOption1Amount, value); }
        private DirtyValue<StringEnumValue<CorrespondentOptionDesc>> _correspondentFinalCDOption1Desc;
        /// <summary>
        /// Final CD - Additional Amount Description 1 [CPA.FCD.Option1Desc]
        /// </summary>
        [LoanFieldProperty(Description = "Final CD - Additional Amount Description 1")]
        public StringEnumValue<CorrespondentOptionDesc> CorrespondentFinalCDOption1Desc { get => _correspondentFinalCDOption1Desc; set => SetField(ref _correspondentFinalCDOption1Desc, value); }
        private DirtyValue<decimal?> _correspondentFinalCDOption2Amount;
        /// <summary>
        /// Final CD - Additional Amount Value 2 [CPA.FCD.Option2Amount]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Final CD - Additional Amount Value 2")]
        public decimal? CorrespondentFinalCDOption2Amount { get => _correspondentFinalCDOption2Amount; set => SetField(ref _correspondentFinalCDOption2Amount, value); }
        private DirtyValue<StringEnumValue<CorrespondentOptionDesc>> _correspondentFinalCDOption2Desc;
        /// <summary>
        /// Final CD - Additional Amount Description 2 [CPA.FCD.Option2Desc]
        /// </summary>
        [LoanFieldProperty(Description = "Final CD - Additional Amount Description 2")]
        public StringEnumValue<CorrespondentOptionDesc> CorrespondentFinalCDOption2Desc { get => _correspondentFinalCDOption2Desc; set => SetField(ref _correspondentFinalCDOption2Desc, value); }
        private DirtyValue<decimal?> _correspondentFinalCDPropertyTax;
        /// <summary>
        /// Final CD - Property Tax [CPA.FCD.PropertyTax]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Final CD - Property Tax")]
        public decimal? CorrespondentFinalCDPropertyTax { get => _correspondentFinalCDPropertyTax; set => SetField(ref _correspondentFinalCDPropertyTax, value); }
        private DirtyValue<decimal?> _correspondentFinalCDReservesCollectedAtClosing;
        /// <summary>
        /// Final CD - Reservces Collected at Closing [CPA.FCD.ReservesCollectedAtClosing]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Final CD - Reservces Collected at Closing")]
        public decimal? CorrespondentFinalCDReservesCollectedAtClosing { get => _correspondentFinalCDReservesCollectedAtClosing; set => SetField(ref _correspondentFinalCDReservesCollectedAtClosing, value); }
        private DirtyValue<decimal?> _correspondentFinalCDUSDAAnnualFee;
        /// <summary>
        /// Final CD - USDA Annual Fee [CPA.FCD.USDAAnnualFee]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Final CD - USDA Annual Fee")]
        public decimal? CorrespondentFinalCDUSDAAnnualFee { get => _correspondentFinalCDUSDAAnnualFee; set => SetField(ref _correspondentFinalCDUSDAAnnualFee, value); }
        private DirtyValue<DateTime?> _correspondentFirstPaymentDate;
        /// <summary>
        /// Correspondent Purchase Advice First Payment Date [3570]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice First Payment Date")]
        public DateTime? CorrespondentFirstPaymentDate { get => _correspondentFirstPaymentDate; set => SetField(ref _correspondentFirstPaymentDate, value); }
        private DirtyValue<decimal?> _correspondentImpounds;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Impounds [3582]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Impounds")]
        public decimal? CorrespondentImpounds { get => _correspondentImpounds; set => SetField(ref _correspondentImpounds, value); }
        private DirtyValue<decimal?> _correspondentInterest;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Interest [3580]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Interest")]
        public decimal? CorrespondentInterest { get => _correspondentInterest; set => SetField(ref _correspondentInterest, value); }
        private DirtyValue<int?> _correspondentInterestDays;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Interest Days [3581]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Additional Purchase Details Interest Days")]
        public int? CorrespondentInterestDays { get => _correspondentInterestDays; set => SetField(ref _correspondentInterestDays, value); }
        private DirtyValue<decimal?> _correspondentLateFeeAmount;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Late Fee [3939]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Late Fee")]
        public decimal? CorrespondentLateFeeAmount { get => _correspondentLateFeeAmount; set => SetField(ref _correspondentLateFeeAmount, value); }
        private DirtyValue<decimal?> _correspondentLateFeePriceAdjustment;
        /// <summary>
        /// Correspondent Purchase Advice Additional Adjusters Late Fee Price Adjustment [3938]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Correspondent Purchase Advice Additional Adjusters Late Fee Price Adjustment")]
        public decimal? CorrespondentLateFeePriceAdjustment { get => _correspondentLateFeePriceAdjustment; set => SetField(ref _correspondentLateFeePriceAdjustment, value); }
        private DirtyValue<DateTime?> _correspondentPaidToDate;
        /// <summary>
        /// Correspondent Purchase Advice Paid to Date [3569]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Paid to Date")]
        public DateTime? CorrespondentPaidToDate { get => _correspondentPaidToDate; set => SetField(ref _correspondentPaidToDate, value); }
        private DirtyValue<DateTime?> _correspondentPaymentHistoryAnticipatedPurchaseDate;
        /// <summary>
        /// Correspondent Purchase Advice Payment History Calculator Anticipated Purchase Date [CPA.PaymentHistory.AnticipatedPurchaseDate]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Payment History Calculator Anticipated Purchase Date")]
        public DateTime? CorrespondentPaymentHistoryAnticipatedPurchaseDate { get => _correspondentPaymentHistoryAnticipatedPurchaseDate; set => SetField(ref _correspondentPaymentHistoryAnticipatedPurchaseDate, value); }
        private DirtyValue<decimal?> _correspondentPaymentHistoryCalculatedPurchasedPrincipal;
        /// <summary>
        /// Correspondent Purchase Advice Payment History Calculator Calculated Purchased Principal [CPA.PaymentHistory.CalculatedPurchasedPrincipal]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Payment History Calculator Calculated Purchased Principal")]
        public decimal? CorrespondentPaymentHistoryCalculatedPurchasedPrincipal { get => _correspondentPaymentHistoryCalculatedPurchasedPrincipal; set => SetField(ref _correspondentPaymentHistoryCalculatedPurchasedPrincipal, value); }
        private DirtyValue<DateTime?> _correspondentPaymentHistoryFirstBorrowerPaymentDueDate;
        /// <summary>
        /// Correspondent Purchase Advice Payment History Calculator 1st Payment Due from Borrower  [CPA.PaymentHistory.FirstBorrowerPaymentDueDate]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Payment History Calculator 1st Payment Due from Borrower ")]
        public DateTime? CorrespondentPaymentHistoryFirstBorrowerPaymentDueDate { get => _correspondentPaymentHistoryFirstBorrowerPaymentDueDate; set => SetField(ref _correspondentPaymentHistoryFirstBorrowerPaymentDueDate, value); }
        private DirtyValue<DateTime?> _correspondentPaymentHistoryFirstInvestorPaymentDate;
        /// <summary>
        /// Correspondent Purchase Advice Payment History Calculator ◦1st Payment Due to Investor [CPA.PaymentHistory.FirstInvestorPaymentDate]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Payment History Calculator ◦1st Payment Due to Investor")]
        public DateTime? CorrespondentPaymentHistoryFirstInvestorPaymentDate { get => _correspondentPaymentHistoryFirstInvestorPaymentDate; set => SetField(ref _correspondentPaymentHistoryFirstInvestorPaymentDate, value); }
        private DirtyValue<DateTime?> _correspondentPaymentHistoryNoteDate;
        /// <summary>
        /// Correspondent Purchase Advice Payment History Calculator Note Date [CPA.PaymentHistory.NoteDate]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Payment History Calculator Note Date")]
        public DateTime? CorrespondentPaymentHistoryNoteDate { get => _correspondentPaymentHistoryNoteDate; set => SetField(ref _correspondentPaymentHistoryNoteDate, value); }
        private DirtyValue<decimal?> _correspondentPaymentHistoryPricipalReduction;
        /// <summary>
        /// Correspondent Purchase Advice Payment History Calculator principal reduction prior to 1st payment date [CPA.PaymentHistory.PricipalReduction]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Payment History Calculator principal reduction prior to 1st payment date")]
        public decimal? CorrespondentPaymentHistoryPricipalReduction { get => _correspondentPaymentHistoryPricipalReduction; set => SetField(ref _correspondentPaymentHistoryPricipalReduction, value); }
        private DirtyValue<decimal?> _correspondentPurchasedPrincipal;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Purchased Principal [3579]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Purchased Principal")]
        public decimal? CorrespondentPurchasedPrincipal { get => _correspondentPurchasedPrincipal; set => SetField(ref _correspondentPurchasedPrincipal, value); }
        private DirtyValue<string> _correspondentReconcilationComments;
        /// <summary>
        /// Correspondent Purchase Advice Reconcilation Comments [3586]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Reconcilation Comments")]
        public string CorrespondentReconcilationComments { get => _correspondentReconcilationComments; set => SetField(ref _correspondentReconcilationComments, value); }
        private DirtyValue<decimal?> _correspondentRemainingBuydownAmount;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Remaining Buydown Amount [3585]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Remaining Buydown Amount")]
        public decimal? CorrespondentRemainingBuydownAmount { get => _correspondentRemainingBuydownAmount; set => SetField(ref _correspondentRemainingBuydownAmount, value); }
        private DirtyValue<decimal?> _correspondentSRPAmount;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details SRP Amount [3584]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details SRP Amount")]
        public decimal? CorrespondentSRPAmount { get => _correspondentSRPAmount; set => SetField(ref _correspondentSRPAmount, value); }
        private DirtyValue<decimal?> _correspondentTotalBuyAmount;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Total Buy Amount [4191]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Total Buy Amount")]
        public decimal? CorrespondentTotalBuyAmount { get => _correspondentTotalBuyAmount; set => SetField(ref _correspondentTotalBuyAmount, value); }
        private DirtyValue<decimal?> _correspondentTotalFees;
        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Total Fees  [4192]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Total Fees ")]
        public decimal? CorrespondentTotalFees { get => _correspondentTotalFees; set => SetField(ref _correspondentTotalFees, value); }
        private DirtyValue<string> _correspondentWarehouseBankABANum;
        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank ABA Number [3945]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank ABA Number")]
        public string CorrespondentWarehouseBankABANum { get => _correspondentWarehouseBankABANum; set => SetField(ref _correspondentWarehouseBankABANum, value); }
        private DirtyValue<string> _correspondentWarehouseBankAcctName;
        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Account Name [4202]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank Account Name")]
        public string CorrespondentWarehouseBankAcctName { get => _correspondentWarehouseBankAcctName; set => SetField(ref _correspondentWarehouseBankAcctName, value); }
        private DirtyValue<string> _correspondentWarehouseBankAcctNum;
        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Account Number [3944]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank Account Number")]
        public string CorrespondentWarehouseBankAcctNum { get => _correspondentWarehouseBankAcctNum; set => SetField(ref _correspondentWarehouseBankAcctNum, value); }
        private DirtyValue<string> _correspondentWarehouseBankAddress;
        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Address [3948]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank Address")]
        public string CorrespondentWarehouseBankAddress { get => _correspondentWarehouseBankAddress; set => SetField(ref _correspondentWarehouseBankAddress, value); }
        private DirtyValue<string> _correspondentWarehouseBankAddress1;
        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Address1 [3949]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank Address1")]
        public string CorrespondentWarehouseBankAddress1 { get => _correspondentWarehouseBankAddress1; set => SetField(ref _correspondentWarehouseBankAddress1, value); }
        private DirtyValue<DateTime?> _correspondentWarehouseBankBaileeExpirationDate;
        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Bailee Expiration Date [3956]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank Bailee Expiration Date")]
        public DateTime? CorrespondentWarehouseBankBaileeExpirationDate { get => _correspondentWarehouseBankBaileeExpirationDate; set => SetField(ref _correspondentWarehouseBankBaileeExpirationDate, value); }
        private DirtyValue<bool?> _correspondentWarehouseBankBaileeLetterReceivedIndicator;
        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Bailee Letter Received Indicator [3947]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank Bailee Letter Received Indicator")]
        public bool? CorrespondentWarehouseBankBaileeLetterReceivedIndicator { get => _correspondentWarehouseBankBaileeLetterReceivedIndicator; set => SetField(ref _correspondentWarehouseBankBaileeLetterReceivedIndicator, value); }
        private DirtyValue<bool?> _correspondentWarehouseBankBaileeLetterReqIndicator;
        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Bailee Letter Required Indicator [3955]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank Bailee Letter Required Indicator")]
        public bool? CorrespondentWarehouseBankBaileeLetterReqIndicator { get => _correspondentWarehouseBankBaileeLetterReqIndicator; set => SetField(ref _correspondentWarehouseBankBaileeLetterReqIndicator, value); }
        private DirtyValue<string> _correspondentWarehouseBankCity;
        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank City [3950]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank City")]
        public string CorrespondentWarehouseBankCity { get => _correspondentWarehouseBankCity; set => SetField(ref _correspondentWarehouseBankCity, value); }
        private DirtyValue<string> _correspondentWarehouseBankContactEmail;
        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Contact Email [3959]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank Contact Email")]
        public string CorrespondentWarehouseBankContactEmail { get => _correspondentWarehouseBankContactEmail; set => SetField(ref _correspondentWarehouseBankContactEmail, value); }
        private DirtyValue<string> _correspondentWarehouseBankContactFax;
        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Contact Fax Number [3961]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Correspondent Purchase Advice Warehouse Bank Contact Fax Number")]
        public string CorrespondentWarehouseBankContactFax { get => _correspondentWarehouseBankContactFax; set => SetField(ref _correspondentWarehouseBankContactFax, value); }
        private DirtyValue<string> _correspondentWarehouseBankContactName;
        /// <summary>
        /// Correspondent Purchase Advice Warehouse Contact Name [3958]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Contact Name")]
        public string CorrespondentWarehouseBankContactName { get => _correspondentWarehouseBankContactName; set => SetField(ref _correspondentWarehouseBankContactName, value); }
        private DirtyValue<string> _correspondentWarehouseBankContactPhone;
        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Contact Phone Number [3960]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Correspondent Purchase Advice Warehouse Bank Contact Phone Number")]
        public string CorrespondentWarehouseBankContactPhone { get => _correspondentWarehouseBankContactPhone; set => SetField(ref _correspondentWarehouseBankContactPhone, value); }
        private DirtyValue<string> _correspondentWarehouseBankDescription;
        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Description [3953]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank Description")]
        public string CorrespondentWarehouseBankDescription { get => _correspondentWarehouseBankDescription; set => SetField(ref _correspondentWarehouseBankDescription, value); }
        private DirtyValue<string> _correspondentWarehouseBankFurtherCreditAcctName;
        /// <summary>
        /// Correspondent Purchase Advice Warehouse Further Credit Account Name [4204]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Further Credit Account Name")]
        public string CorrespondentWarehouseBankFurtherCreditAcctName { get => _correspondentWarehouseBankFurtherCreditAcctName; set => SetField(ref _correspondentWarehouseBankFurtherCreditAcctName, value); }
        private DirtyValue<string> _correspondentWarehouseBankFurtherCreditAcctNum;
        /// <summary>
        /// Correspondent Purchase Advice Warehouse Further Credit Account Number [4203]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Further Credit Account Number")]
        public string CorrespondentWarehouseBankFurtherCreditAcctNum { get => _correspondentWarehouseBankFurtherCreditAcctNum; set => SetField(ref _correspondentWarehouseBankFurtherCreditAcctNum, value); }
        private DirtyValue<int?> _correspondentWarehouseBankId;
        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank ID  [3964]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank ID ")]
        public int? CorrespondentWarehouseBankId { get => _correspondentWarehouseBankId; set => SetField(ref _correspondentWarehouseBankId, value); }
        private DirtyValue<string> _correspondentWarehouseBankName;
        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Name  [3943]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank Name ")]
        public string CorrespondentWarehouseBankName { get => _correspondentWarehouseBankName; set => SetField(ref _correspondentWarehouseBankName, value); }
        private DirtyValue<string> _correspondentWarehouseBankNotes;
        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Note [3962]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank Note")]
        public string CorrespondentWarehouseBankNotes { get => _correspondentWarehouseBankNotes; set => SetField(ref _correspondentWarehouseBankNotes, value); }
        private DirtyValue<bool?> _correspondentWarehouseBankSelfFunderIndicator;
        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Self - Funder Indicator [3954]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank Self - Funder Indicator")]
        public bool? CorrespondentWarehouseBankSelfFunderIndicator { get => _correspondentWarehouseBankSelfFunderIndicator; set => SetField(ref _correspondentWarehouseBankSelfFunderIndicator, value); }
        private DirtyValue<StringEnumValue<State>> _correspondentWarehouseBankState;
        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank State [3951]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank State")]
        public StringEnumValue<State> CorrespondentWarehouseBankState { get => _correspondentWarehouseBankState; set => SetField(ref _correspondentWarehouseBankState, value); }
        private DirtyValue<bool?> _correspondentWarehouseBankTriPartyContractIndicator;
        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Tri - Party Contract Indicator [3957]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank Tri - Party Contract Indicator")]
        public bool? CorrespondentWarehouseBankTriPartyContractIndicator { get => _correspondentWarehouseBankTriPartyContractIndicator; set => SetField(ref _correspondentWarehouseBankTriPartyContractIndicator, value); }
        private DirtyValue<bool?> _correspondentWarehouseBankUseDefaultContactIndicator;
        /// <summary>
        /// Correspondent Purchase Advice Use Default Contact Indicator [3963]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Use Default Contact Indicator")]
        public bool? CorrespondentWarehouseBankUseDefaultContactIndicator { get => _correspondentWarehouseBankUseDefaultContactIndicator; set => SetField(ref _correspondentWarehouseBankUseDefaultContactIndicator, value); }
        private DirtyValue<string> _correspondentWarehouseBankWireConfirmationNumber;
        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Wire Confirmation # [4190]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank Wire Confirmation #")]
        public string CorrespondentWarehouseBankWireConfirmationNumber { get => _correspondentWarehouseBankWireConfirmationNumber; set => SetField(ref _correspondentWarehouseBankWireConfirmationNumber, value); }
        private DirtyValue<bool?> _correspondentWarehouseBankWireInstructionsReceivedIndicator;
        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Wire Instructions Received Indicator [3946]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank Wire Instructions Received Indicator")]
        public bool? CorrespondentWarehouseBankWireInstructionsReceivedIndicator { get => _correspondentWarehouseBankWireInstructionsReceivedIndicator; set => SetField(ref _correspondentWarehouseBankWireInstructionsReceivedIndicator, value); }
        private DirtyValue<string> _correspondentWarehouseBankZip;
        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Zip Code [3952]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Correspondent Purchase Advice Warehouse Bank Zip Code")]
        public string CorrespondentWarehouseBankZip { get => _correspondentWarehouseBankZip; set => SetField(ref _correspondentWarehouseBankZip, value); }
        private DirtyValue<string> _creditScoreToUse;
        /// <summary>
        /// RateLock CreditScoreToUse
        /// </summary>
        public string CreditScoreToUse { get => _creditScoreToUse; set => SetField(ref _creditScoreToUse, value); }
        private DirtyValue<int?> _cumulatedDaystoExtend;
        /// <summary>
        /// Rate Lock Cumulated Days to Extend [3431]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Lock Cumulated Days to Extend")]
        public int? CumulatedDaystoExtend { get => _cumulatedDaystoExtend; set => SetField(ref _cumulatedDaystoExtend, value); }
        private DirtyValue<bool?> _currentAcquisition;
        /// <summary>
        /// Initial Acquisition of Land [4254]
        /// </summary>
        [LoanFieldProperty(Description = "Initial Acquisition of Land")]
        public bool? CurrentAcquisition { get => _currentAcquisition; set => SetField(ref _currentAcquisition, value); }
        private DirtyList<PriceAdjustment> _currentAdjustments;
        /// <summary>
        /// RateLock CurrentAdjustments
        /// </summary>
        public IList<PriceAdjustment> CurrentAdjustments { get => GetField(ref _currentAdjustments); set => SetField(ref _currentAdjustments, value); }
        private DirtyValue<string> _currentComments;
        /// <summary>
        /// Rate Lock Current Comments [2035]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Lock Current Comments")]
        public string CurrentComments { get => _currentComments; set => SetField(ref _currentComments, value); }
        private DirtyValue<bool?> _currentConstructionRefi;
        /// <summary>
        /// Construction Refinance Indicator [4255]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Refinance Indicator")]
        public bool? CurrentConstructionRefi { get => _currentConstructionRefi; set => SetField(ref _currentConstructionRefi, value); }
        private DirtyValue<DateTime?> _currentLockDate;
        /// <summary>
        /// Rate Lock Current Lock Date [2145]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Current Lock Date")]
        public DateTime? CurrentLockDate { get => _currentLockDate; set => SetField(ref _currentLockDate, value); }
        private DirtyValue<DateTime?> _currentLockExpires;
        /// <summary>
        /// Rate Lock Current Lock Expires Date [2147]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Current Lock Expires Date")]
        public DateTime? CurrentLockExpires { get => _currentLockExpires; set => SetField(ref _currentLockExpires, value); }
        private DirtyValue<decimal?> _currentMarginRate;
        /// <summary>
        /// Rate Lock Current Base Margin Rate [2690]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Rate Lock Current Base Margin Rate")]
        public decimal? CurrentMarginRate { get => _currentMarginRate; set => SetField(ref _currentMarginRate, value); }
        private DirtyValue<decimal?> _currentMarginRateRequested;
        /// <summary>
        /// Rate Lock Current Base Margin Rate Requested [2732]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Rate Lock Current Base Margin Rate Requested")]
        public decimal? CurrentMarginRateRequested { get => _currentMarginRateRequested; set => SetField(ref _currentMarginRateRequested, value); }
        private DirtyValue<decimal?> _currentMarginTotalAdjustment;
        /// <summary>
        /// Rate Lock Current Base Margin Total Adjustment [2731]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Rate Lock Current Base Margin Total Adjustment")]
        public decimal? CurrentMarginTotalAdjustment { get => _currentMarginTotalAdjustment; set => SetField(ref _currentMarginTotalAdjustment, value); }
        private DirtyValue<int?> _currentNumberOfDays;
        /// <summary>
        /// Rate Lock Current Number of Days [2146]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Current Number of Days")]
        public int? CurrentNumberOfDays { get => _currentNumberOfDays; set => SetField(ref _currentNumberOfDays, value); }
        private DirtyValue<decimal?> _currentPriceRate;
        /// <summary>
        /// Rate Lock Current Base Price Rate [2045]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, ReadOnly = true, Description = "Rate Lock Current Base Price Rate")]
        public decimal? CurrentPriceRate { get => _currentPriceRate; set => SetField(ref _currentPriceRate, value); }
        private DirtyValue<decimal?> _currentPriceRateRequested;
        /// <summary>
        /// Rate Lock Current Base Price Rate Requested [2087]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, ReadOnly = true, Description = "Rate Lock Current Base Price Rate Requested")]
        public decimal? CurrentPriceRateRequested { get => _currentPriceRateRequested; set => SetField(ref _currentPriceRateRequested, value); }
        private DirtyValue<decimal?> _currentPriceTotalAdjustment;
        /// <summary>
        /// Rate Lock Current Base Price Tot Adjustment [2086]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, ReadOnly = true, Description = "Rate Lock Current Base Price Tot Adjustment")]
        public decimal? CurrentPriceTotalAdjustment { get => _currentPriceTotalAdjustment; set => SetField(ref _currentPriceTotalAdjustment, value); }
        private DirtyValue<decimal?> _currentRate;
        /// <summary>
        /// Rate Lock Current Base Rate [2036]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Rate Lock Current Base Rate")]
        public decimal? CurrentRate { get => _currentRate; set => SetField(ref _currentRate, value); }
        private DirtyValue<decimal?> _currentRateRequested;
        /// <summary>
        /// Rate Lock Current Base Rate Requested [2044]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Rate Lock Current Base Rate Requested")]
        public decimal? CurrentRateRequested { get => _currentRateRequested; set => SetField(ref _currentRateRequested, value); }
        private DirtyValue<DateTime?> _currentRateSetDate;
        /// <summary>
        /// Rate Lock Current Lock Last Rate Set Date [3255]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Current Lock Last Rate Set Date")]
        public DateTime? CurrentRateSetDate { get => _currentRateSetDate; set => SetField(ref _currentRateSetDate, value); }
        private DirtyValue<string> _currentRateSheetID;
        /// <summary>
        /// Rate Lock Current Rate Sheet ID [2034]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Lock Current Rate Sheet ID")]
        public string CurrentRateSheetID { get => _currentRateSheetID; set => SetField(ref _currentRateSheetID, value); }
        private DirtyValue<decimal?> _currentRateTotalAdjustment;
        /// <summary>
        /// Rate Lock Current Base Rate Tot Adjustment [2043]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Rate Lock Current Base Rate Tot Adjustment")]
        public decimal? CurrentRateTotalAdjustment { get => _currentRateTotalAdjustment; set => SetField(ref _currentRateTotalAdjustment, value); }
        private DirtyValue<DateTime?> _date;
        /// <summary>
        /// Purchase Advice Date [2370]
        /// </summary>
        [LoanFieldProperty(Description = "Purchase Advice Date")]
        public DateTime? Date { get => _date; set => SetField(ref _date, value); }
        private DirtyValue<DateTime?> _dateFirstPaymentToInvestor;
        /// <summary>
        /// Purchase Advice Date First Payment to Investor [3514]
        /// </summary>
        [LoanFieldProperty(Description = "Purchase Advice Date First Payment to Investor")]
        public DateTime? DateFirstPaymentToInvestor { get => _dateFirstPaymentToInvestor; set => SetField(ref _dateFirstPaymentToInvestor, value); }
        private DirtyValue<DateTime?> _dateLockedWithInvestor;
        /// <summary>
        /// Rate Lock Sell Side Date Locked with Investor [2291]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Date Locked with Investor")]
        public DateTime? DateLockedWithInvestor { get => _dateLockedWithInvestor; set => SetField(ref _dateLockedWithInvestor, value); }
        private DirtyValue<DateTime?> _dateSold;
        /// <summary>
        /// Date Sold to Third Party [3337]
        /// </summary>
        [LoanFieldProperty(Description = "Date Sold to Third Party")]
        public DateTime? DateSold { get => _dateSold; set => SetField(ref _dateSold, value); }
        private DirtyValue<DateTime?> _dateWarehoused;
        /// <summary>
        /// Date Warehoused [3341]
        /// </summary>
        [LoanFieldProperty(Description = "Date Warehoused")]
        public DateTime? DateWarehoused { get => _dateWarehoused; set => SetField(ref _dateWarehoused, value); }
        private DirtyValue<int?> _daysToExtend;
        /// <summary>
        /// RateLock DaysToExtend
        /// </summary>
        public int? DaysToExtend { get => _daysToExtend; set => SetField(ref _daysToExtend, value); }
        private DirtyValue<string> _deliveryType;
        /// <summary>
        /// Rate Lock Request Delivery Type [3965]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Delivery Type")]
        public string DeliveryType { get => _deliveryType; set => SetField(ref _deliveryType, value); }
        private DirtyValue<decimal?> _diffAmountReceived;
        /// <summary>
        /// Purchase Advice Amt Rcvd Dif [2624]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Purchase Advice Amt Rcvd Dif")]
        public decimal? DiffAmountReceived { get => _diffAmountReceived; set => SetField(ref _diffAmountReceived, value); }
        private DirtyValue<decimal?> _diffImpounds;
        /// <summary>
        /// Purchase Adv Impounds Difference [2839]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Purchase Adv Impounds Difference")]
        public decimal? DiffImpounds { get => _diffImpounds; set => SetField(ref _diffImpounds, value); }
        private DirtyValue<decimal?> _diffInterest;
        /// <summary>
        /// Purchase Adv Interest Difference [2838]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Purchase Adv Interest Difference")]
        public decimal? DiffInterest { get => _diffInterest; set => SetField(ref _diffInterest, value); }
        private DirtyValue<decimal?> _diffPremium;
        /// <summary>
        /// Purchase Advice Premium Dif [2610]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Purchase Advice Premium Dif")]
        public decimal? DiffPremium { get => _diffPremium; set => SetField(ref _diffPremium, value); }
        private DirtyValue<decimal?> _diffPrinciple;
        /// <summary>
        /// Purchase Advice Principal Dif [2609]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Purchase Advice Principal Dif")]
        public decimal? DiffPrinciple { get => _diffPrinciple; set => SetField(ref _diffPrinciple, value); }
        private DirtyValue<decimal?> _diffRemainingBuydownFunds;
        /// <summary>
        /// Purch Adv Remaining Buydown Funds Dif. [3132]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Purch Adv Remaining Buydown Funds Dif.")]
        public decimal? DiffRemainingBuydownFunds { get => _diffRemainingBuydownFunds; set => SetField(ref _diffRemainingBuydownFunds, value); }
        private DirtyValue<decimal?> _diffSellAmount;
        /// <summary>
        /// Purchase Advice Diff Sell Amount [3425]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Purchase Advice Diff Sell Amount")]
        public decimal? DiffSellAmount { get => _diffSellAmount; set => SetField(ref _diffSellAmount, value); }
        private DirtyValue<decimal?> _diffSellPrice;
        /// <summary>
        /// Purchase Advice Diff Sell Price [3423]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6, ReadOnly = true, Description = "Purchase Advice Diff Sell Price")]
        public decimal? DiffSellPrice { get => _diffSellPrice; set => SetField(ref _diffSellPrice, value); }
        private DirtyValue<decimal?> _diffSellSideSRP;
        /// <summary>
        /// Purchase Advice Diff Sell Side SRP [3427]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6, ReadOnly = true, Description = "Purchase Advice Diff Sell Side SRP")]
        public decimal? DiffSellSideSRP { get => _diffSellSideSRP; set => SetField(ref _diffSellSideSRP, value); }
        private DirtyValue<decimal?> _diffSRP;
        /// <summary>
        /// Purchase Advice SRP Received Dif [2611]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Purchase Advice SRP Received Dif")]
        public decimal? DiffSRP { get => _diffSRP; set => SetField(ref _diffSRP, value); }
        private DirtyValue<decimal?> _diffSRPAmount;
        /// <summary>
        /// Purchase Advice Diff SRP Amount [3429]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Purchase Advice Diff SRP Amount")]
        public decimal? DiffSRPAmount { get => _diffSRPAmount; set => SetField(ref _diffSRPAmount, value); }
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator1;
        /// <summary>
        /// Lock Request Borr Self Employed [3516]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Borr Self Employed")]
        public bool? EmploymentBorrowerSelfEmployedIndicator1 { get => _employmentBorrowerSelfEmployedIndicator1; set => SetField(ref _employmentBorrowerSelfEmployedIndicator1, value); }
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator10;
        /// <summary>
        /// Lock Request Co-Mort8 Self Employed [3525]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Co-Mort8 Self Employed")]
        public bool? EmploymentBorrowerSelfEmployedIndicator10 { get => _employmentBorrowerSelfEmployedIndicator10; set => SetField(ref _employmentBorrowerSelfEmployedIndicator10, value); }
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator11;
        /// <summary>
        /// Lock Request Co-Mort9 Self Employed [3526]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Co-Mort9 Self Employed")]
        public bool? EmploymentBorrowerSelfEmployedIndicator11 { get => _employmentBorrowerSelfEmployedIndicator11; set => SetField(ref _employmentBorrowerSelfEmployedIndicator11, value); }
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator12;
        /// <summary>
        /// Lock Request Co-Mort10 Self Employed [3527]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Co-Mort10 Self Employed")]
        public bool? EmploymentBorrowerSelfEmployedIndicator12 { get => _employmentBorrowerSelfEmployedIndicator12; set => SetField(ref _employmentBorrowerSelfEmployedIndicator12, value); }
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator2;
        /// <summary>
        /// Lock Request Co-Borr Self Employed [3517]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Co-Borr Self Employed")]
        public bool? EmploymentBorrowerSelfEmployedIndicator2 { get => _employmentBorrowerSelfEmployedIndicator2; set => SetField(ref _employmentBorrowerSelfEmployedIndicator2, value); }
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator3;
        /// <summary>
        /// Lock Request Co-Mort1 Self Employed [3518]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Co-Mort1 Self Employed")]
        public bool? EmploymentBorrowerSelfEmployedIndicator3 { get => _employmentBorrowerSelfEmployedIndicator3; set => SetField(ref _employmentBorrowerSelfEmployedIndicator3, value); }
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator4;
        /// <summary>
        /// Lock Request Co-Mort2 Self Employed [3519]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Co-Mort2 Self Employed")]
        public bool? EmploymentBorrowerSelfEmployedIndicator4 { get => _employmentBorrowerSelfEmployedIndicator4; set => SetField(ref _employmentBorrowerSelfEmployedIndicator4, value); }
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator5;
        /// <summary>
        /// Lock Request Co-Mort3 Self Employed [3520]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Co-Mort3 Self Employed")]
        public bool? EmploymentBorrowerSelfEmployedIndicator5 { get => _employmentBorrowerSelfEmployedIndicator5; set => SetField(ref _employmentBorrowerSelfEmployedIndicator5, value); }
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator6;
        /// <summary>
        /// Lock Request Co-Mort4 Self Employed [3521]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Co-Mort4 Self Employed")]
        public bool? EmploymentBorrowerSelfEmployedIndicator6 { get => _employmentBorrowerSelfEmployedIndicator6; set => SetField(ref _employmentBorrowerSelfEmployedIndicator6, value); }
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator7;
        /// <summary>
        /// Lock Request Co-Mort5 Self Employed [3522]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Co-Mort5 Self Employed")]
        public bool? EmploymentBorrowerSelfEmployedIndicator7 { get => _employmentBorrowerSelfEmployedIndicator7; set => SetField(ref _employmentBorrowerSelfEmployedIndicator7, value); }
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator8;
        /// <summary>
        /// Lock Request Co-Mort6 Self Employed [3523]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Co-Mort6 Self Employed")]
        public bool? EmploymentBorrowerSelfEmployedIndicator8 { get => _employmentBorrowerSelfEmployedIndicator8; set => SetField(ref _employmentBorrowerSelfEmployedIndicator8, value); }
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator9;
        /// <summary>
        /// Lock Request Co-Mort7 Self Employed [3524]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Co-Mort7 Self Employed")]
        public bool? EmploymentBorrowerSelfEmployedIndicator9 { get => _employmentBorrowerSelfEmployedIndicator9; set => SetField(ref _employmentBorrowerSelfEmployedIndicator9, value); }
        private DirtyValue<decimal?> _expectedAmountReceived;
        /// <summary>
        /// Purchase Advice Expctd Amt Rcvd [2608]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Purchase Advice Expctd Amt Rcvd")]
        public decimal? ExpectedAmountReceived { get => _expectedAmountReceived; set => SetField(ref _expectedAmountReceived, value); }
        private DirtyValue<decimal?> _expectedImpounds;
        /// <summary>
        /// Purchase Adv Expected Impounds Transfer [2837]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Purchase Adv Expected Impounds Transfer")]
        public decimal? ExpectedImpounds { get => _expectedImpounds; set => SetField(ref _expectedImpounds, value); }
        private DirtyValue<decimal?> _expectedInterest;
        /// <summary>
        /// Purchase Adv Expected Int Pymt from Investor [2836]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Purchase Adv Expected Int Pymt from Investor")]
        public decimal? ExpectedInterest { get => _expectedInterest; set => SetField(ref _expectedInterest, value); }
        private DirtyValue<decimal?> _expectedPremium;
        /// <summary>
        /// Purchase Advice Expctd Premium [2594]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Purchase Advice Expctd Premium")]
        public decimal? ExpectedPremium { get => _expectedPremium; set => SetField(ref _expectedPremium, value); }
        private DirtyValue<decimal?> _expectedPrinciple;
        /// <summary>
        /// Purchase Advice Expctd Principal [2593]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Purchase Advice Expctd Principal")]
        public decimal? ExpectedPrinciple { get => _expectedPrinciple; set => SetField(ref _expectedPrinciple, value); }
        private DirtyValue<decimal?> _expectedRemainingBuydownFunds;
        /// <summary>
        /// Purch Adv Expctd Remaining Buydown Funds [3130]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Purch Adv Expctd Remaining Buydown Funds")]
        public decimal? ExpectedRemainingBuydownFunds { get => _expectedRemainingBuydownFunds; set => SetField(ref _expectedRemainingBuydownFunds, value); }
        private DirtyValue<decimal?> _expectedSRP;
        /// <summary>
        /// Purchase Advice Expctd SRP Received [2595]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Purchase Advice Expctd SRP Received")]
        public decimal? ExpectedSRP { get => _expectedSRP; set => SetField(ref _expectedSRP, value); }
        private DirtyValue<string> _extensionRequestPending;
        /// <summary>
        /// RateLock ExtensionRequestPending
        /// </summary>
        public string ExtensionRequestPending { get => _extensionRequestPending; set => SetField(ref _extensionRequestPending, value); }
        private DirtyValue<int?> _extensionSequenceNumber;
        /// <summary>
        /// Rate Lock Extension Sequence Number [3433]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Lock Extension Sequence Number")]
        public int? ExtensionSequenceNumber { get => _extensionSequenceNumber; set => SetField(ref _extensionSequenceNumber, value); }
        private DirtyList<ExtraPayment> _extraPayments;
        /// <summary>
        /// RateLock ExtraPayments
        /// </summary>
        public IList<ExtraPayment> ExtraPayments { get => GetField(ref _extraPayments); set => SetField(ref _extraPayments, value); }
        private DirtyValue<decimal?> _fHAUpfrontMIPremiumPercent;
        /// <summary>
        /// Lock Request MI Premium/Funding Fee % [3044]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6, Description = "Lock Request MI Premium/Funding Fee %")]
        public decimal? FHAUpfrontMIPremiumPercent { get => _fHAUpfrontMIPremiumPercent; set => SetField(ref _fHAUpfrontMIPremiumPercent, value); }
        private DirtyValue<int?> _financedNumberOfUnits;
        /// <summary>
        /// Lock Request Subject Property # Units [3529]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Subject Property # Units")]
        public int? FinancedNumberOfUnits { get => _financedNumberOfUnits; set => SetField(ref _financedNumberOfUnits, value); }
        private DirtyValue<StringEnumValue<PartyType>> _firstPaymenTo;
        /// <summary>
        /// Purchase Advice First Payment To [2371]
        /// </summary>
        [LoanFieldProperty(Description = "Purchase Advice First Payment To")]
        public StringEnumValue<PartyType> FirstPaymenTo { get => _firstPaymenTo; set => SetField(ref _firstPaymenTo, value); }
        private DirtyValue<decimal?> _firstSubordinateAmount;
        /// <summary>
        /// Lock Request First Subordinate Amount [3035]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Lock Request First Subordinate Amount")]
        public decimal? FirstSubordinateAmount { get => _firstSubordinateAmount; set => SetField(ref _firstSubordinateAmount, value); }
        private DirtyValue<bool?> _firstTimeHomebuyersIndicator;
        /// <summary>
        /// Lock Request Borr First Time Homebuyer [3528]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Borr First Time Homebuyer")]
        public bool? FirstTimeHomebuyersIndicator { get => _firstTimeHomebuyersIndicator; set => SetField(ref _firstTimeHomebuyersIndicator, value); }
        private DirtyValue<string> _fNMProductPlanIdentifier;
        /// <summary>
        /// Lock Request Amort Type ARM Descr [2956]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Amort Type ARM Descr")]
        public string FNMProductPlanIdentifier { get => _fNMProductPlanIdentifier; set => SetField(ref _fNMProductPlanIdentifier, value); }
        private DirtyValue<decimal?> _fundingAmount;
        /// <summary>
        /// Lock Request MI Premium/Funding Amnt [3045]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Lock Request MI Premium/Funding Amnt")]
        public decimal? FundingAmount { get => _fundingAmount; set => SetField(ref _fundingAmount, value); }
        private DirtyValue<decimal?> _gainLossPercentage;
        /// <summary>
        /// Rate Lock Sell Side Gain Loss Percent [2296]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Sell Side Gain Loss Percent")]
        public decimal? GainLossPercentage { get => _gainLossPercentage; set => SetField(ref _gainLossPercentage, value); }
        private DirtyValue<decimal?> _gainLossPrice;
        /// <summary>
        /// Rate Lock Sell Side Gain Loss Price [2028]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Sell Side Gain Loss Price")]
        public decimal? GainLossPrice { get => _gainLossPrice; set => SetField(ref _gainLossPrice, value); }
        private DirtyValue<decimal?> _gainLossTotalBuyPrice;
        /// <summary>
        /// Rate Lock Sell Side Total Sell Price [2295]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Sell Side Total Sell Price")]
        public decimal? GainLossTotalBuyPrice { get => _gainLossTotalBuyPrice; set => SetField(ref _gainLossTotalBuyPrice, value); }
        private DirtyValue<decimal?> _gPMRate;
        /// <summary>
        /// Lock Request Amort Type GPM Rate [2954]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Lock Request Amort Type GPM Rate")]
        public decimal? GPMRate { get => _gPMRate; set => SetField(ref _gPMRate, value); }
        private DirtyValue<int?> _gPMYears;
        /// <summary>
        /// Lock Request Amort Type GPM Years [2955]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Amort Type GPM Years")]
        public int? GPMYears { get => _gPMYears; set => SetField(ref _gPMYears, value); }
        private DirtyValue<StringEnumValue<PropertyType>> _gSEPropertyType;
        /// <summary>
        /// Lock Request Subject Property Type [2947]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Subject Property Type")]
        public StringEnumValue<PropertyType> GSEPropertyType { get => _gSEPropertyType; set => SetField(ref _gSEPropertyType, value); }
        private DirtyValue<StringEnumValue<YOrN>> _hedging;
        /// <summary>
        /// Rate Lock Hedging [2401]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Hedging", OptionsJson = "{\"Y\":\"Y\",\"N\":\"N\"}")]
        public StringEnumValue<YOrN> Hedging { get => _hedging; set => SetField(ref _hedging, value); }
        private DirtyValue<string> _hELOCActualBalance;
        /// <summary>
        /// Lock Request Freddie Mac HELOC Actual Bal [3846]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Freddie Mac HELOC Actual Bal")]
        public string HELOCActualBalance { get => _hELOCActualBalance; set => SetField(ref _hELOCActualBalance, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// RateLock Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<decimal?> _impounds;
        /// <summary>
        /// Purchase Adv Actual Impounds Transfer [2835]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Purchase Adv Actual Impounds Transfer")]
        public decimal? Impounds { get => _impounds; set => SetField(ref _impounds, value); }
        private DirtyValue<StringEnumValue<ImpoundType>> _impoundType;
        /// <summary>
        /// Trans Details Impound Types [2294]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Impound Types")]
        public StringEnumValue<ImpoundType> ImpoundType { get => _impoundType; set => SetField(ref _impoundType, value); }
        private DirtyValue<string> _impoundWaived;
        /// <summary>
        /// RateLock ImpoundWaived
        /// </summary>
        public string ImpoundWaived { get => _impoundWaived; set => SetField(ref _impoundWaived, value); }
        private DirtyValue<StringEnumValue<ImpoundWaived>> _impoundWavied;
        /// <summary>
        /// Trans Details Impounds Waived [2293]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Impounds Waived")]
        public StringEnumValue<ImpoundWaived> ImpoundWavied { get => _impoundWavied; set => SetField(ref _impoundWavied, value); }
        private DirtyValue<decimal?> _interest;
        /// <summary>
        /// Purchase Adv Actual Interest Payment from Investor [2834]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Purchase Adv Actual Interest Payment from Investor")]
        public decimal? Interest { get => _interest; set => SetField(ref _interest, value); }
        private DirtyValue<string> _investorAddress;
        /// <summary>
        /// Rate Lock Sell Side Investor Address [2281]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Investor Address")]
        public string InvestorAddress { get => _investorAddress; set => SetField(ref _investorAddress, value); }
        private DirtyValue<string> _investorCity;
        /// <summary>
        /// Rate Lock Sell Side Investor City [2282]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Investor City")]
        public string InvestorCity { get => _investorCity; set => SetField(ref _investorCity, value); }
        private DirtyValue<string> _investorCommitment;
        /// <summary>
        /// Rate Lock Sell Side Investor Commitment [2286]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Investor Commitment")]
        public string InvestorCommitment { get => _investorCommitment; set => SetField(ref _investorCommitment, value); }
        private DirtyValue<string> _investorContact;
        /// <summary>
        /// Rate Lock Sell Side Investor Contact [2279]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Investor Contact")]
        public string InvestorContact { get => _investorContact; set => SetField(ref _investorContact, value); }
        private DirtyValue<DateTime?> _investorDeliveryDate;
        /// <summary>
        /// Rate Lock Sell Side Investor Delivery Date [2297]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Investor Delivery Date")]
        public DateTime? InvestorDeliveryDate { get => _investorDeliveryDate; set => SetField(ref _investorDeliveryDate, value); }
        private DirtyValue<string> _investorEmail;
        /// <summary>
        /// Rate Lock Sell Side Investor Email [3055]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Investor Email")]
        public string InvestorEmail { get => _investorEmail; set => SetField(ref _investorEmail, value); }
        private DirtyValue<string> _investorLoanNumber;
        /// <summary>
        /// Rate Lock Sell Side Investor Loan Number [2288]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Investor Loan Number")]
        public string InvestorLoanNumber { get => _investorLoanNumber; set => SetField(ref _investorLoanNumber, value); }
        private DirtyValue<string> _investorLockType;
        /// <summary>
        /// Rate Lock Sell Side Investor Lock Type [2287]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Investor Lock Type")]
        public string InvestorLockType { get => _investorLockType; set => SetField(ref _investorLockType, value); }
        private DirtyValue<string> _investorMERSNumber;
        /// <summary>
        /// Rate Lock Sell Side Investor MERS Number [2290]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Investor MERS Number")]
        public string InvestorMERSNumber { get => _investorMERSNumber; set => SetField(ref _investorMERSNumber, value); }
        private DirtyValue<string> _investorName;
        /// <summary>
        /// Rate Lock Sell Investor Name [2278]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Investor Name")]
        public string InvestorName { get => _investorName; set => SetField(ref _investorName, value); }
        private DirtyValue<string> _investorPhone;
        /// <summary>
        /// Rate Lock Sell Side Investor Phone [2280]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Rate Lock Sell Side Investor Phone")]
        public string InvestorPhone { get => _investorPhone; set => SetField(ref _investorPhone, value); }
        private DirtyValue<string> _investorPostalCode;
        /// <summary>
        /// Rate Lock Sell Side Investor Zipcode [2284]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Rate Lock Sell Side Investor Zipcode")]
        public string InvestorPostalCode { get => _investorPostalCode; set => SetField(ref _investorPostalCode, value); }
        private DirtyValue<string> _investorProgramCode;
        /// <summary>
        /// Rate Lock Sell Side Investor Program Code [2289]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Investor Program Code")]
        public string InvestorProgramCode { get => _investorProgramCode; set => SetField(ref _investorProgramCode, value); }
        private DirtyValue<StringEnumValue<State>> _investorState;
        /// <summary>
        /// Rate Lock Sell Side Investor State [2283]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Investor State")]
        public StringEnumValue<State> InvestorState { get => _investorState; set => SetField(ref _investorState, value); }
        private DirtyValue<DateTime?> _investorTargetDeliveryDate;
        /// <summary>
        /// Rate Lock Sell Side Target Delivery Date [2206]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Target Delivery Date")]
        public DateTime? InvestorTargetDeliveryDate { get => _investorTargetDeliveryDate; set => SetField(ref _investorTargetDeliveryDate, value); }
        private DirtyValue<string> _investorTemplateName;
        /// <summary>
        /// Rate Lock Sell Investor Template Name [3263]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Investor Template Name")]
        public string InvestorTemplateName { get => _investorTemplateName; set => SetField(ref _investorTemplateName, value); }
        private DirtyValue<string> _investorWebsite;
        /// <summary>
        /// Rate Lock Sell Side Investor Website [2285]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Investor Website")]
        public string InvestorWebsite { get => _investorWebsite; set => SetField(ref _investorWebsite, value); }
        private DirtyValue<string> _isCancelled;
        /// <summary>
        /// RateLock IsCancelled
        /// </summary>
        public string IsCancelled { get => _isCancelled; set => SetField(ref _isCancelled, value); }
        private DirtyValue<bool?> _isDeliveryType;
        /// <summary>
        /// Rate Lock Request Delivery Type is Visible [3966]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Delivery Type is Visible")]
        public bool? IsDeliveryType { get => _isDeliveryType; set => SetField(ref _isDeliveryType, value); }
        private DirtyValue<bool?> _lenderFeeWaiverOption;
        /// <summary>
        /// Rate Lock Request Lender Fee Waiver Option [4459]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Lender Fee Waiver Option")]
        public bool? LenderFeeWaiverOption { get => _lenderFeeWaiverOption; set => SetField(ref _lenderFeeWaiverOption, value); }
        private DirtyValue<bool?> _lenderPaidMortgageInsuranceIndicator;
        /// <summary>
        /// Lock Request Lender Paid Mortgage Insurance [3628]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Lender Paid Mortgage Insurance")]
        public bool? LenderPaidMortgageInsuranceIndicator { get => _lenderPaidMortgageInsuranceIndicator; set => SetField(ref _lenderPaidMortgageInsuranceIndicator, value); }
        private DirtyValue<StringEnumValue<LienType>> _lienPriorityType;
        /// <summary>
        /// Lock Request Lein Position [2958]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Lein Position")]
        public StringEnumValue<LienType> LienPriorityType { get => _lienPriorityType; set => SetField(ref _lienPriorityType, value); }
        private DirtyValue<int?> _loanAmortizationTermMonths;
        /// <summary>
        /// Lock Request Term Months [2959]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Term Months")]
        public int? LoanAmortizationTermMonths { get => _loanAmortizationTermMonths; set => SetField(ref _loanAmortizationTermMonths, value); }
        private DirtyValue<StringEnumValue<AmortizationType>> _loanAmortizationType;
        /// <summary>
        /// Lock Request Amort Type [2953]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Amort Type")]
        public StringEnumValue<AmortizationType> LoanAmortizationType { get => _loanAmortizationType; set => SetField(ref _loanAmortizationType, value); }
        private DirtyValue<StringEnumValue<LoanDocumentationType>> _loanDocumentationType;
        /// <summary>
        /// Lock Request Doc Type [2867]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Doc Type")]
        public StringEnumValue<LoanDocumentationType> LoanDocumentationType { get => _loanDocumentationType; set => SetField(ref _loanDocumentationType, value); }
        private DirtyValue<bool?> _loanFor203K;
        /// <summary>
        /// Lock Request HUD 92900 LT Loan for 203K [3844]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request HUD 92900 LT Loan for 203K")]
        public bool? LoanFor203K { get => _loanFor203K; set => SetField(ref _loanFor203K, value); }
        private DirtyValue<string> _loanProgram;
        /// <summary>
        /// Lock Request Loan Program [2866]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Loan Program")]
        public string LoanProgram { get => _loanProgram; set => SetField(ref _loanProgram, value); }
        private DirtyValue<string> _loanProgramFile;
        /// <summary>
        /// Lock Request Loan Program File [2967]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Lock Request Loan Program File")]
        public string LoanProgramFile { get => _loanProgramFile; set => SetField(ref _loanProgramFile, value); }
        private DirtyValue<DateTime?> _loanScheduledClosingDate;
        /// <summary>
        /// Lock Request Est Closing Date [2966]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Est Closing Date")]
        public DateTime? LoanScheduledClosingDate { get => _loanScheduledClosingDate; set => SetField(ref _loanScheduledClosingDate, value); }
        private DirtyValue<bool?> _lockField;
        /// <summary>
        /// Lock Request MI Premium/Funding Lock [3046]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request MI Premium/Funding Lock")]
        public bool? LockField { get => _lockField; set => SetField(ref _lockField, value); }
        private DirtyList<PriceAdjustment> _lockRequestAdjustments;
        /// <summary>
        /// RateLock LockRequestAdjustments
        /// </summary>
        public IList<PriceAdjustment> LockRequestAdjustments { get => GetField(ref _lockRequestAdjustments); set => SetField(ref _lockRequestAdjustments, value); }
        private DirtyList<LockRequestBorrower> _lockRequestBorrowers;
        /// <summary>
        /// RateLock LockRequestBorrowers
        /// </summary>
        public IList<LockRequestBorrower> LockRequestBorrowers { get => GetField(ref _lockRequestBorrowers); set => SetField(ref _lockRequestBorrowers, value); }
        private DirtyValue<StringEnumValue<LockRequestLoanPurposeType>> _lockRequestLoanPurposeType;
        /// <summary>
        /// Lock Request Loan Purpose [2951]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Loan Purpose")]
        public StringEnumValue<LockRequestLoanPurposeType> LockRequestLoanPurposeType { get => _lockRequestLoanPurposeType; set => SetField(ref _lockRequestLoanPurposeType, value); }
        private DirtyValue<decimal?> _lTV;
        /// <summary>
        /// Lock Request Loan to Value (LTV) [3241]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Lock Request Loan to Value (LTV)")]
        public decimal? LTV { get => _lTV; set => SetField(ref _lTV, value); }
        private DirtyValue<string> _minFICO;
        /// <summary>
        /// Lock Request Borr Minimum FICO Score [2940]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Borr Minimum FICO Score")]
        public string MinFICO { get => _minFICO; set => SetField(ref _minFICO, value); }
        private DirtyValue<string> _minFICO2;
        /// <summary>
        /// Lock Request Co-Borr Minimum FICO Score [2941]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Co-Borr Minimum FICO Score")]
        public string MinFICO2 { get => _minFICO2; set => SetField(ref _minFICO2, value); }
        private DirtyValue<decimal?> _mIPPaidInCash;
        /// <summary>
        /// Lock Request Upfont MI Premium/Funding Amt Paid in Cash [3047]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Lock Request Upfont MI Premium/Funding Amt Paid in Cash")]
        public decimal? MIPPaidInCash { get => _mIPPaidInCash; set => SetField(ref _mIPPaidInCash, value); }
        private DirtyValue<StringEnumValue<LoanType>> _mortgageType;
        /// <summary>
        /// Lock Request Loan Type [2952]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Loan Type")]
        public StringEnumValue<LoanType> MortgageType { get => _mortgageType; set => SetField(ref _mortgageType, value); }
        private DirtyValue<decimal?> _netSellAmount;
        /// <summary>
        /// Purchase Advice Sell Amount [2208]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Purchase Advice Sell Amount")]
        public decimal? NetSellAmount { get => _netSellAmount; set => SetField(ref _netSellAmount, value); }
        private DirtyValue<decimal?> _netSellPrice;
        /// <summary>
        /// Purchase Advice Net Sell Price [2207]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6, Description = "Purchase Advice Net Sell Price")]
        public decimal? NetSellPrice { get => _netSellPrice; set => SetField(ref _netSellPrice, value); }
        private DirtyValue<DateTime?> _nextPaymentDate;
        /// <summary>
        /// Purchase Advice Next Payment Date [2397]
        /// </summary>
        [LoanFieldProperty(Description = "Purchase Advice Next Payment Date")]
        public DateTime? NextPaymentDate { get => _nextPaymentDate; set => SetField(ref _nextPaymentDate, value); }
        private DirtyValue<bool?> _noClosingCostOption;
        /// <summary>
        /// Rate Lock Request No Closing Cost Option [3892]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request No Closing Cost Option")]
        public bool? NoClosingCostOption { get => _noClosingCostOption; set => SetField(ref _noClosingCostOption, value); }
        private DirtyValue<StringEnumValue<YOrN>> _oNRPLock;
        /// <summary>
        /// Locked during ONRP Window [4057]
        /// </summary>
        [LoanFieldProperty(Description = "Locked during ONRP Window", OptionsJson = "{\"Y\":\"Y\",\"N\":\"N\"}")]
        public StringEnumValue<YOrN> ONRPLock { get => _oNRPLock; set => SetField(ref _oNRPLock, value); }
        private DirtyValue<string> _otherAmortizationTypeDescription;
        /// <summary>
        /// Lock Request Amort Type Other Descr [2957]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Amort Type Other Descr")]
        public string OtherAmortizationTypeDescription { get => _otherAmortizationTypeDescription; set => SetField(ref _otherAmortizationTypeDescription, value); }
        private DirtyValue<decimal?> _otherSubordinateAmount;
        /// <summary>
        /// Lock Request Other Subordinate Amount [3037]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Lock Request Other Subordinate Amount")]
        public decimal? OtherSubordinateAmount { get => _otherSubordinateAmount; set => SetField(ref _otherSubordinateAmount, value); }
        private DirtyValue<StringEnumValue<PenaltyTerm>> _penaltyTerm;
        /// <summary>
        /// Trans Details Penalty Term [2217]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Penalty Term")]
        public StringEnumValue<PenaltyTerm> PenaltyTerm { get => _penaltyTerm; set => SetField(ref _penaltyTerm, value); }
        private DirtyValue<StringEnumValue<PerDiemInterestRoundingType>> _perDiemInterestRoundingType;
        /// <summary>
        /// Purchase Adv Interest Calcuation - Per Diem Interest Rounding [3550]
        /// </summary>
        [LoanFieldProperty(Description = "Purchase Adv Interest Calcuation - Per Diem Interest Rounding")]
        public StringEnumValue<PerDiemInterestRoundingType> PerDiemInterestRoundingType { get => _perDiemInterestRoundingType; set => SetField(ref _perDiemInterestRoundingType, value); }
        private DirtyValue<string> _planCode;
        /// <summary>
        /// Lock Request Plan Code [3041]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Plan Code")]
        public string PlanCode { get => _planCode; set => SetField(ref _planCode, value); }
        private DirtyValue<decimal?> _premium;
        /// <summary>
        /// Purchase Advice Premium [2212]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Purchase Advice Premium")]
        public decimal? Premium { get => _premium; set => SetField(ref _premium, value); }
        private DirtyValue<StringEnumValue<YOrN>> _prepayPenalty;
        /// <summary>
        /// Trans Details Prepay Penalty [2216]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Prepay Penalty")]
        public StringEnumValue<YOrN> PrepayPenalty { get => _prepayPenalty; set => SetField(ref _prepayPenalty, value); }
        private DirtyValue<decimal?> _priceAdjustment;
        /// <summary>
        /// RateLock PriceAdjustment
        /// </summary>
        public decimal? PriceAdjustment { get => _priceAdjustment; set => SetField(ref _priceAdjustment, value); }
        private DirtyList<PriceAdjustment> _priceAdjustments;
        /// <summary>
        /// RateLock PriceAdjustments
        /// </summary>
        public IList<PriceAdjustment> PriceAdjustments { get => GetField(ref _priceAdjustments); set => SetField(ref _priceAdjustments, value); }
        private DirtyValue<string> _pricingHistoryData;
        /// <summary>
        /// RateLock PricingHistoryData
        /// </summary>
        public string PricingHistoryData { get => _pricingHistoryData; set => SetField(ref _pricingHistoryData, value); }
        private DirtyValue<string> _pricingUpdated;
        /// <summary>
        /// Lock Request Field For Pricing Updated [3039]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Field For Pricing Updated")]
        public string PricingUpdated { get => _pricingUpdated; set => SetField(ref _pricingUpdated, value); }
        private DirtyValue<decimal?> _principle;
        /// <summary>
        /// Purchase Advice Principal [2211]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Purchase Advice Principal")]
        public decimal? Principle { get => _principle; set => SetField(ref _principle, value); }
        private DirtyValue<decimal?> _profitMarginAdjustedBuyPrice;
        /// <summary>
        /// Rate Lock Buy Side Adjusted Buy Price [3420]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Buy Side Adjusted Buy Price")]
        public decimal? ProfitMarginAdjustedBuyPrice { get => _profitMarginAdjustedBuyPrice; set => SetField(ref _profitMarginAdjustedBuyPrice, value); }
        private DirtyValue<int?> _propertyAppraisedValueAmount;
        /// <summary>
        /// Lock Request Subject Property Appraised Value [2949]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Subject Property Appraised Value")]
        public int? PropertyAppraisedValueAmount { get => _propertyAppraisedValueAmount; set => SetField(ref _propertyAppraisedValueAmount, value); }
        private DirtyValue<int?> _propertyEstimatedValueAmount;
        /// <summary>
        /// Lock Request Subject Property Est Value [2948]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Subject Property Est Value")]
        public int? PropertyEstimatedValueAmount { get => _propertyEstimatedValueAmount; set => SetField(ref _propertyEstimatedValueAmount, value); }
        private DirtyValue<StringEnumValue<PropertyUsageType>> _propertyUsageType;
        /// <summary>
        /// Lock Request Subject Property Occupancy Status [2950]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Subject Property Occupancy Status")]
        public StringEnumValue<PropertyUsageType> PropertyUsageType { get => _propertyUsageType; set => SetField(ref _propertyUsageType, value); }
        private DirtyValue<int?> _purchaseAdviceNumberOfDays;
        /// <summary>
        /// Purchase Adv Interest Calcuation - Number of Days [3549]
        /// </summary>
        [LoanFieldProperty(Description = "Purchase Adv Interest Calcuation - Number of Days", OptionsJson = "{\"360\":\"360\",\"364\":\"364\",\"365\":\"365\"}")]
        public int? PurchaseAdviceNumberOfDays { get => _purchaseAdviceNumberOfDays; set => SetField(ref _purchaseAdviceNumberOfDays, value); }
        private DirtyList<PurchaseAdvicePayout> _purchaseAdvicePayouts;
        /// <summary>
        /// RateLock PurchaseAdvicePayouts
        /// </summary>
        public IList<PurchaseAdvicePayout> PurchaseAdvicePayouts { get => GetField(ref _purchaseAdvicePayouts); set => SetField(ref _purchaseAdvicePayouts, value); }
        private DirtyValue<decimal?> _purchasePriceAmount;
        /// <summary>
        /// Lock Request Purchase Price Amount [3038]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Lock Request Purchase Price Amount")]
        public decimal? PurchasePriceAmount { get => _purchasePriceAmount; set => SetField(ref _purchasePriceAmount, value); }
        private DirtyValue<string> _rateRequestStatus;
        /// <summary>
        /// RateLock RateRequestStatus
        /// </summary>
        public string RateRequestStatus { get => _rateRequestStatus; set => SetField(ref _rateRequestStatus, value); }
        private DirtyValue<string> _rateStatus;
        /// <summary>
        /// RateLock RateStatus
        /// </summary>
        public string RateStatus { get => _rateStatus; set => SetField(ref _rateStatus, value); }
        private DirtyValue<string> _reasonforBranchApproval;
        /// <summary>
        /// Rate Lock Buy Side Reason for Branch Concession Approval [3378]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Buy Side Reason for Branch Concession Approval")]
        public string ReasonforBranchApproval { get => _reasonforBranchApproval; set => SetField(ref _reasonforBranchApproval, value); }
        private DirtyValue<string> _reasonforCorporateApproval;
        /// <summary>
        /// Rate Lock Buy Side Reason for Corporate  Concession Approval [3374]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Buy Side Reason for Corporate  Concession Approval")]
        public string ReasonforCorporateApproval { get => _reasonforCorporateApproval; set => SetField(ref _reasonforCorporateApproval, value); }
        private DirtyValue<decimal?> _reconciledDiff;
        /// <summary>
        /// Purchase Advice Reconciled Differences [2629]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Purchase Advice Reconciled Differences")]
        public decimal? ReconciledDiff { get => _reconciledDiff; set => SetField(ref _reconciledDiff, value); }
        private DirtyValue<string> _reLockRequestPending;
        /// <summary>
        /// RateLock ReLockRequestPending
        /// </summary>
        public string ReLockRequestPending { get => _reLockRequestPending; set => SetField(ref _reLockRequestPending, value); }
        private DirtyValue<decimal?> _remainingBuydownFunds;
        /// <summary>
        /// Purch Adv Remaining Buydown Funds [3131]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Purch Adv Remaining Buydown Funds")]
        public decimal? RemainingBuydownFunds { get => _remainingBuydownFunds; set => SetField(ref _remainingBuydownFunds, value); }
        private DirtyValue<string> _requestComments;
        /// <summary>
        /// Rate Lock Request Comments [2144]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Comments")]
        public string RequestComments { get => _requestComments; set => SetField(ref _requestComments, value); }
        private DirtyValue<DateTime?> _requestCurrentRateSetDate;
        /// <summary>
        /// Rate Lock Request Last Rate Set Date [3254]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Last Rate Set Date")]
        public DateTime? RequestCurrentRateSetDate { get => _requestCurrentRateSetDate; set => SetField(ref _requestCurrentRateSetDate, value); }
        private DirtyValue<int?> _requestDaystoExtend;
        /// <summary>
        /// Rate Lock Request Days to Extend [3360]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Days to Extend")]
        public int? RequestDaystoExtend { get => _requestDaystoExtend; set => SetField(ref _requestDaystoExtend, value); }
        private DirtyValue<DateTime?> _requestExtendedLockExpires;
        /// <summary>
        /// Rate Lock Request Extended Lock Expires Date [3361]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Extended Lock Expires Date")]
        public DateTime? RequestExtendedLockExpires { get => _requestExtendedLockExpires; set => SetField(ref _requestExtendedLockExpires, value); }
        private DirtyValue<string> _requestFullfilledDateTime;
        /// <summary>
        /// Rate Lock Request Fulfilled Date Time [2592]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Fulfilled Date Time")]
        public string RequestFullfilledDateTime { get => _requestFullfilledDateTime; set => SetField(ref _requestFullfilledDateTime, value); }
        private DirtyValue<StringEnumValue<ImpoundType>> _requestImpoundType;
        /// <summary>
        /// Lock Request Impound Types [2962]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Impound Types")]
        public StringEnumValue<ImpoundType> RequestImpoundType { get => _requestImpoundType; set => SetField(ref _requestImpoundType, value); }
        private DirtyValue<string> _requestImpoundWaived;
        /// <summary>
        /// RateLock RequestImpoundWaived
        /// </summary>
        public string RequestImpoundWaived { get => _requestImpoundWaived; set => SetField(ref _requestImpoundWaived, value); }
        private DirtyValue<StringEnumValue<ImpoundWaived>> _requestImpoundWavied;
        /// <summary>
        /// Lock Request Impounds Waived [2961]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Impounds Waived")]
        public StringEnumValue<ImpoundWaived> RequestImpoundWavied { get => _requestImpoundWavied; set => SetField(ref _requestImpoundWavied, value); }
        private DirtyValue<string> _requestLockCancellationComment;
        /// <summary>
        /// Rate Lock Request Lock Cancellation Comment [3623]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Lock Cancellation Comment")]
        public string RequestLockCancellationComment { get => _requestLockCancellationComment; set => SetField(ref _requestLockCancellationComment, value); }
        private DirtyValue<DateTime?> _requestLockCancellationDate;
        /// <summary>
        /// Rate Lock Request Lock Cancellation Date [3622]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Lock Cancellation Date")]
        public DateTime? RequestLockCancellationDate { get => _requestLockCancellationDate; set => SetField(ref _requestLockCancellationDate, value); }
        private DirtyValue<DateTime?> _requestLockDate;
        /// <summary>
        /// Rate Lock Request Lock Date [2089]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Lock Date")]
        public DateTime? RequestLockDate { get => _requestLockDate; set => SetField(ref _requestLockDate, value); }
        private DirtyValue<DateTime?> _requestLockExpires;
        /// <summary>
        /// Rate Lock Request Lock Expires Date [2091]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Lock Expires Date")]
        public DateTime? RequestLockExpires { get => _requestLockExpires; set => SetField(ref _requestLockExpires, value); }
        private DirtyValue<string> _requestLockExtendComment;
        /// <summary>
        /// Rate Lock Request Lock Extension Comment [3370]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Lock Extension Comment")]
        public string RequestLockExtendComment { get => _requestLockExtendComment; set => SetField(ref _requestLockExtendComment, value); }
        private DirtyValue<decimal?> _requestLockExtendPriceAdjustment;
        /// <summary>
        /// Rate Lock Request Lock Extension Price Adjustment [3362]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Request Lock Extension Price Adjustment")]
        public decimal? RequestLockExtendPriceAdjustment { get => _requestLockExtendPriceAdjustment; set => SetField(ref _requestLockExtendPriceAdjustment, value); }
        private DirtyValue<string> _requestLockStatus;
        /// <summary>
        /// Rate Lock Request Lock Status [4209]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Lock Status")]
        public string RequestLockStatus { get => _requestLockStatus; set => SetField(ref _requestLockStatus, value); }
        private DirtyValue<string> _requestLockType;
        /// <summary>
        /// Rate Lock Request Type [3841]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Type")]
        public string RequestLockType { get => _requestLockType; set => SetField(ref _requestLockType, value); }
        private DirtyValue<decimal?> _requestMarginRate;
        /// <summary>
        /// Rate Lock Request Base Margin Rate [2647]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Request Base Margin Rate")]
        public decimal? RequestMarginRate { get => _requestMarginRate; set => SetField(ref _requestMarginRate, value); }
        private DirtyValue<decimal?> _requestMarginRateRequested;
        /// <summary>
        /// Rate Lock Request Base Margin Rate Requested [2689]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Request Base Margin Rate Requested")]
        public decimal? RequestMarginRateRequested { get => _requestMarginRateRequested; set => SetField(ref _requestMarginRateRequested, value); }
        private DirtyValue<decimal?> _requestMarginSRPPaidOut;
        /// <summary>
        /// Lock Request SRP Paid Out [2848]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Lock Request SRP Paid Out")]
        public decimal? RequestMarginSRPPaidOut { get => _requestMarginSRPPaidOut; set => SetField(ref _requestMarginSRPPaidOut, value); }
        private DirtyValue<decimal?> _requestMarginTotalAdjustment;
        /// <summary>
        /// Rate Lock Request Base Margin Total Adjust [2688]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Request Base Margin Total Adjust")]
        public decimal? RequestMarginTotalAdjustment { get => _requestMarginTotalAdjustment; set => SetField(ref _requestMarginTotalAdjustment, value); }
        private DirtyValue<int?> _requestNumberOfDays;
        /// <summary>
        /// Rate Lock Request Number of Days [2090]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Number of Days")]
        public int? RequestNumberOfDays { get => _requestNumberOfDays; set => SetField(ref _requestNumberOfDays, value); }
        private DirtyValue<bool?> _requestOnrpEligible;
        /// <summary>
        /// Rate Lock Request ONRP Eligible Flag [4061]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Lock Request ONRP Eligible Flag", OptionsJson = "{\"true\":\"Y\",\"false\":\"N\"}")]
        public bool? RequestOnrpEligible { get => _requestOnrpEligible; set => SetField(ref _requestOnrpEligible, value); }
        private DirtyValue<DateTime?> _requestOnrpLockDate;
        /// <summary>
        /// Rate Lock Request ONRP Lock Date [4069]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Lock Request ONRP Lock Date")]
        public DateTime? RequestOnrpLockDate { get => _requestOnrpLockDate; set => SetField(ref _requestOnrpLockDate, value); }
        private DirtyValue<string> _requestOnrpLockTime;
        /// <summary>
        /// Rate Lock Request ONRP Lock Time [4060]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Lock Request ONRP Lock Time")]
        public string RequestOnrpLockTime { get => _requestOnrpLockTime; set => SetField(ref _requestOnrpLockTime, value); }
        private DirtyValue<DateTime?> _requestOriginalLockExpires;
        /// <summary>
        /// Rate Lock Request Original Lock Expires Date [3369]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Original Lock Expires Date")]
        public DateTime? RequestOriginalLockExpires { get => _requestOriginalLockExpires; set => SetField(ref _requestOriginalLockExpires, value); }
        private DirtyValue<StringEnumValue<PenaltyTerm>> _requestPenaltyTerm;
        /// <summary>
        /// Lock Request Penelaty Term [2964]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Penelaty Term")]
        public StringEnumValue<PenaltyTerm> RequestPenaltyTerm { get => _requestPenaltyTerm; set => SetField(ref _requestPenaltyTerm, value); }
        private DirtyValue<string> _requestPending;
        /// <summary>
        /// RateLock RequestPending
        /// </summary>
        public string RequestPending { get => _requestPending; set => SetField(ref _requestPending, value); }
        private DirtyValue<StringEnumValue<YOrN>> _requestPrepayPenalty;
        /// <summary>
        /// Lock Request Prepay Penalty [2963]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Prepay Penalty")]
        public StringEnumValue<YOrN> RequestPrepayPenalty { get => _requestPrepayPenalty; set => SetField(ref _requestPrepayPenalty, value); }
        private DirtyValue<decimal?> _requestPriceRate;
        /// <summary>
        /// Rate Lock Request Base Price Rate [2101]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Request Base Price Rate")]
        public decimal? RequestPriceRate { get => _requestPriceRate; set => SetField(ref _requestPriceRate, value); }
        private DirtyValue<decimal?> _requestPriceRateRequested;
        /// <summary>
        /// Rate Lock Request Base Price Rate Requested [2143]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Request Base Price Rate Requested")]
        public decimal? RequestPriceRateRequested { get => _requestPriceRateRequested; set => SetField(ref _requestPriceRateRequested, value); }
        private DirtyValue<decimal?> _requestPriceTotalAdjustment;
        /// <summary>
        /// Rate Lock Request Base Price Tot Adjustment [2142]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Request Base Price Tot Adjustment")]
        public decimal? RequestPriceTotalAdjustment { get => _requestPriceTotalAdjustment; set => SetField(ref _requestPriceTotalAdjustment, value); }
        private DirtyValue<decimal?> _requestRate;
        /// <summary>
        /// Rate Lock Request Base Rate [2092]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Request Base Rate")]
        public decimal? RequestRate { get => _requestRate; set => SetField(ref _requestRate, value); }
        private DirtyValue<decimal?> _requestRateRequested;
        /// <summary>
        /// Rate Lock Request Base Rate Requested [2100]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Request Base Rate Requested")]
        public decimal? RequestRateRequested { get => _requestRateRequested; set => SetField(ref _requestRateRequested, value); }
        private DirtyValue<string> _requestRateSheetID;
        /// <summary>
        /// Rate Lock Request Rate Sheet ID [2088]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Rate Sheet ID")]
        public string RequestRateSheetID { get => _requestRateSheetID; set => SetField(ref _requestRateSheetID, value); }
        private DirtyValue<decimal?> _requestRateTotalAdjustment;
        /// <summary>
        /// Rate Lock Request Base Rate Tot Adjustment [2099]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Request Base Rate Tot Adjustment")]
        public decimal? RequestRateTotalAdjustment { get => _requestRateTotalAdjustment; set => SetField(ref _requestRateTotalAdjustment, value); }
        private DirtyValue<decimal?> _requestStartingAdjPoint;
        /// <summary>
        /// Lock Request Starting Adjust Point [3874]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Lock Request Starting Adjust Point")]
        public decimal? RequestStartingAdjPoint { get => _requestStartingAdjPoint; set => SetField(ref _requestStartingAdjPoint, value); }
        private DirtyValue<decimal?> _requestStartingAdjRate;
        /// <summary>
        /// Lock Request Starting Adjust Rate [3872]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Lock Request Starting Adjust Rate")]
        public decimal? RequestStartingAdjRate { get => _requestStartingAdjRate; set => SetField(ref _requestStartingAdjRate, value); }
        private DirtyValue<string> _requestType;
        /// <summary>
        /// RateLock RequestType
        /// </summary>
        public string RequestType { get => _requestType; set => SetField(ref _requestType, value); }
        private DirtyValue<decimal?> _requestUnDiscountedRate;
        /// <summary>
        /// Lock Request UnDiscounted Rate [3847]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Lock Request UnDiscounted Rate")]
        public decimal? RequestUnDiscountedRate { get => _requestUnDiscountedRate; set => SetField(ref _requestUnDiscountedRate, value); }
        private DirtyValue<bool?> _roundToNearest50;
        /// <summary>
        /// Lock Request Field For Rounding to Nearest $50 [3056]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Field For Rounding to Nearest $50")]
        public bool? RoundToNearest50 { get => _roundToNearest50; set => SetField(ref _roundToNearest50, value); }
        private DirtyValue<decimal?> _secondSubordinateAmount;
        /// <summary>
        /// Lock Request Second Subordinate Amount [3036]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Lock Request Second Subordinate Amount")]
        public decimal? SecondSubordinateAmount { get => _secondSubordinateAmount; set => SetField(ref _secondSubordinateAmount, value); }
        private DirtyValue<decimal?> _sellerPaidMIPremium;
        /// <summary>
        /// Lock Request Seller Paid MI Premium [3049]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Lock Request Seller Paid MI Premium")]
        public decimal? SellerPaidMIPremium { get => _sellerPaidMIPremium; set => SetField(ref _sellerPaidMIPremium, value); }
        private DirtyList<PriceAdjustment> _sellSideAdjustments;
        /// <summary>
        /// RateLock SellSideAdjustments
        /// </summary>
        public IList<PriceAdjustment> SellSideAdjustments { get => GetField(ref _sellSideAdjustments); set => SetField(ref _sellSideAdjustments, value); }
        private DirtyValue<string> _sellSideComments;
        /// <summary>
        /// Rate Lock Sell Side Comments [2275]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Comments")]
        public string SellSideComments { get => _sellSideComments; set => SetField(ref _sellSideComments, value); }
        private DirtyValue<string> _sellSideCommitmentContractNumber;
        /// <summary>
        /// Rate Lock Sell Side Commitment Contract Number [4093]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Commitment Contract Number")]
        public string SellSideCommitmentContractNumber { get => _sellSideCommitmentContractNumber; set => SetField(ref _sellSideCommitmentContractNumber, value); }
        private DirtyValue<DateTime?> _sellSideCommitmentDate;
        /// <summary>
        /// Rate Lock Sell Side Commitment Date [4016]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Commitment Date")]
        public DateTime? SellSideCommitmentDate { get => _sellSideCommitmentDate; set => SetField(ref _sellSideCommitmentDate, value); }
        private DirtyValue<DateTime?> _sellSideCurrentRateSetDate;
        /// <summary>
        /// Rate Lock Sell Side Last Rate Set Date [3257]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Last Rate Set Date")]
        public DateTime? SellSideCurrentRateSetDate { get => _sellSideCurrentRateSetDate; set => SetField(ref _sellSideCurrentRateSetDate, value); }
        private DirtyValue<int?> _sellSideDaystoExtend;
        /// <summary>
        /// Rate Lock Sell Side Days to Extend [3366]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Days to Extend")]
        public int? SellSideDaystoExtend { get => _sellSideDaystoExtend; set => SetField(ref _sellSideDaystoExtend, value); }
        private DirtyValue<decimal?> _sellSideDiscountYSP;
        /// <summary>
        /// Rate Lock Sell Side Discount YSP [2277]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Sell Side Discount YSP")]
        public decimal? SellSideDiscountYSP { get => _sellSideDiscountYSP; set => SetField(ref _sellSideDiscountYSP, value); }
        private DirtyValue<DateTime?> _sellSideExtendedLockExpires;
        /// <summary>
        /// Rate Lock Sell Side Extended Lock Expires Date [3367]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Extended Lock Expires Date")]
        public DateTime? SellSideExtendedLockExpires { get => _sellSideExtendedLockExpires; set => SetField(ref _sellSideExtendedLockExpires, value); }
        private DirtyValue<decimal?> _sellSideGuaranteeFee;
        /// <summary>
        /// Rate Lock Sell Side Guarantee Fee [3889]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_4, Description = "Rate Lock Sell Side Guarantee Fee")]
        public decimal? SellSideGuaranteeFee { get => _sellSideGuaranteeFee; set => SetField(ref _sellSideGuaranteeFee, value); }
        private DirtyValue<decimal?> _sellSideGuarantyBaseFee;
        /// <summary>
        /// Rate Lock Sell Side Base Guaranty Fee [4182]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_4, Description = "Rate Lock Sell Side Base Guaranty Fee")]
        public decimal? SellSideGuarantyBaseFee { get => _sellSideGuarantyBaseFee; set => SetField(ref _sellSideGuarantyBaseFee, value); }
        private DirtyValue<StringEnumValue<SellSideInvestorStatus>> _sellSideInvestorStatus;
        /// <summary>
        /// Rate Lock Sell Side Investor Status [2031]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Lock Sell Side Investor Status")]
        public StringEnumValue<SellSideInvestorStatus> SellSideInvestorStatus { get => _sellSideInvestorStatus; set => SetField(ref _sellSideInvestorStatus, value); }
        private DirtyValue<DateTime?> _sellSideInvestorStatusDate;
        /// <summary>
        /// Rate Lock Sell Side Investor Status Modification Date [2033]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Lock Sell Side Investor Status Modification Date")]
        public DateTime? SellSideInvestorStatusDate { get => _sellSideInvestorStatusDate; set => SetField(ref _sellSideInvestorStatusDate, value); }
        private DirtyValue<string> _sellSideInvestorTradeNumber;
        /// <summary>
        /// Investor Trade Number [2842]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Investor Trade Number")]
        public string SellSideInvestorTradeNumber { get => _sellSideInvestorTradeNumber; set => SetField(ref _sellSideInvestorTradeNumber, value); }
        private DirtyValue<string> _sellSideLoanProgram;
        /// <summary>
        /// Rate Lock Sell Side Loan Program [3123]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Loan Program")]
        public string SellSideLoanProgram { get => _sellSideLoanProgram; set => SetField(ref _sellSideLoanProgram, value); }
        private DirtyValue<DateTime?> _sellSideLockDate;
        /// <summary>
        /// Rate Lock Sell Side Lock Date [2220]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Lock Date")]
        public DateTime? SellSideLockDate { get => _sellSideLockDate; set => SetField(ref _sellSideLockDate, value); }
        private DirtyValue<DateTime?> _sellSideLockExpires;
        /// <summary>
        /// Rate Lock Sell Side Lock Expires Date [2222]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Lock Expires Date")]
        public DateTime? SellSideLockExpires { get => _sellSideLockExpires; set => SetField(ref _sellSideLockExpires, value); }
        private DirtyValue<decimal?> _sellSideLockExtendPriceAdjustment;
        /// <summary>
        /// Rate Lock Sell Side Lock Extension Price Adjustment [3368]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Sell Side Lock Extension Price Adjustment")]
        public decimal? SellSideLockExtendPriceAdjustment { get => _sellSideLockExtendPriceAdjustment; set => SetField(ref _sellSideLockExtendPriceAdjustment, value); }
        private DirtyValue<decimal?> _sellSideMarginNetSellRate;
        /// <summary>
        /// Rate Lock Sell Side Net Buy Rate [2818]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Sell Side Net Buy Rate")]
        public decimal? SellSideMarginNetSellRate { get => _sellSideMarginNetSellRate; set => SetField(ref _sellSideMarginNetSellRate, value); }
        private DirtyValue<decimal?> _sellSideMarginRate;
        /// <summary>
        /// Rate Lock Sell Side Base Rate [2776]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Sell Side Base Rate")]
        public decimal? SellSideMarginRate { get => _sellSideMarginRate; set => SetField(ref _sellSideMarginRate, value); }
        private DirtyValue<decimal?> _sellSideMarginTotalAdjustment;
        /// <summary>
        /// Rate Lock Sell Side Base Rate Total Adjustment [2817]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Sell Side Base Rate Total Adjustment")]
        public decimal? SellSideMarginTotalAdjustment { get => _sellSideMarginTotalAdjustment; set => SetField(ref _sellSideMarginTotalAdjustment, value); }
        private DirtyValue<string> _sellSideMasterContractNumber;
        /// <summary>
        /// Master Contract Number [2841]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Master Contract Number")]
        public string SellSideMasterContractNumber { get => _sellSideMasterContractNumber; set => SetField(ref _sellSideMasterContractNumber, value); }
        private DirtyValue<decimal?> _sellSideMSRValue;
        /// <summary>
        /// Rate Lock Sell Side MSR Value [4118]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_4, Description = "Rate Lock Sell Side MSR Value")]
        public decimal? SellSideMSRValue { get => _sellSideMSRValue; set => SetField(ref _sellSideMSRValue, value); }
        private DirtyValue<decimal?> _sellSideNetSellPrice;
        /// <summary>
        /// Rate Lock Sell Side Net Sell Price [2274]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Sell Side Net Sell Price")]
        public decimal? SellSideNetSellPrice { get => _sellSideNetSellPrice; set => SetField(ref _sellSideNetSellPrice, value); }
        private DirtyValue<decimal?> _sellSideNetSellRate;
        /// <summary>
        /// Rate Lock Sell Side Net Buy Rate [2231]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Sell Side Net Buy Rate")]
        public decimal? SellSideNetSellRate { get => _sellSideNetSellRate; set => SetField(ref _sellSideNetSellRate, value); }
        private DirtyValue<int?> _sellSideNumberOfDays;
        /// <summary>
        /// Rate Lock Sell Side Number of Days [2221]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Number of Days")]
        public int? SellSideNumberOfDays { get => _sellSideNumberOfDays; set => SetField(ref _sellSideNumberOfDays, value); }
        private DirtyValue<DateTime?> _sellSideOriginalLockExpires;
        /// <summary>
        /// Rate Lock Sell Side Lock Expires Date [3359]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Lock Expires Date")]
        public DateTime? SellSideOriginalLockExpires { get => _sellSideOriginalLockExpires; set => SetField(ref _sellSideOriginalLockExpires, value); }
        private DirtyValue<string> _sellSidePoolID;
        /// <summary>
        /// Rate Lock Sell Side Pool ID [4019]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Pool ID")]
        public string SellSidePoolID { get => _sellSidePoolID; set => SetField(ref _sellSidePoolID, value); }
        private DirtyValue<string> _sellSidePoolNumber;
        /// <summary>
        /// Rate Lock Sell Side Pool Number [3890]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Pool Number")]
        public string SellSidePoolNumber { get => _sellSidePoolNumber; set => SetField(ref _sellSidePoolNumber, value); }
        private DirtyValue<decimal?> _sellSidePriceRate;
        /// <summary>
        /// Rate Lock Sell Side Base Price Rate [2232]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Sell Side Base Price Rate")]
        public decimal? SellSidePriceRate { get => _sellSidePriceRate; set => SetField(ref _sellSidePriceRate, value); }
        private DirtyValue<decimal?> _sellSidePriceTotalAdjustment;
        /// <summary>
        /// Rate Lock Sell Side Base Price Total Adjust [2273]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Sell Side Base Price Total Adjust")]
        public decimal? SellSidePriceTotalAdjustment { get => _sellSidePriceTotalAdjustment; set => SetField(ref _sellSidePriceTotalAdjustment, value); }
        private DirtyValue<string> _sellSideProductName;
        /// <summary>
        /// Rate Lock Sell Side Product Name [4094]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Product Name")]
        public string SellSideProductName { get => _sellSideProductName; set => SetField(ref _sellSideProductName, value); }
        private DirtyValue<decimal?> _sellSideRate;
        /// <summary>
        /// Rate Lock Sell Side Base Rate [2223]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Sell Side Base Rate")]
        public decimal? SellSideRate { get => _sellSideRate; set => SetField(ref _sellSideRate, value); }
        private DirtyValue<string> _sellSideRateSheetID;
        /// <summary>
        /// Rate Lock Sell Side Rate Sheet ID [2219]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Rate Sheet ID")]
        public string SellSideRateSheetID { get => _sellSideRateSheetID; set => SetField(ref _sellSideRateSheetID, value); }
        private DirtyValue<decimal?> _sellSideRateTotalAdjustment;
        /// <summary>
        /// Rate Lock Sell Side Base Rate Tot Adjustment [2230]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Sell Side Base Rate Tot Adjustment")]
        public decimal? SellSideRateTotalAdjustment { get => _sellSideRateTotalAdjustment; set => SetField(ref _sellSideRateTotalAdjustment, value); }
        private DirtyValue<string> _sellSideRequestedBy;
        /// <summary>
        /// Rate Lock Sell Side Requested By [2030]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Requested By")]
        public string SellSideRequestedBy { get => _sellSideRequestedBy; set => SetField(ref _sellSideRequestedBy, value); }
        private DirtyValue<string> _sellSideServicer;
        /// <summary>
        /// Rate Lock Sell Side Servicer [3535]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Servicer")]
        public string SellSideServicer { get => _sellSideServicer; set => SetField(ref _sellSideServicer, value); }
        private DirtyValue<decimal?> _sellSideServicingFee;
        /// <summary>
        /// Rate Lock Sell Side Servicing Fee [3888]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_4, Description = "Rate Lock Sell Side Servicing Fee")]
        public decimal? SellSideServicingFee { get => _sellSideServicingFee; set => SetField(ref _sellSideServicingFee, value); }
        private DirtyValue<StringEnumValue<ServicingType>> _sellSideServicingType;
        /// <summary>
        /// Rate Lock Sell Side Servicing Type [3534]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Servicing Type")]
        public StringEnumValue<ServicingType> SellSideServicingType { get => _sellSideServicingType; set => SetField(ref _sellSideServicingType, value); }
        private DirtyValue<decimal?> _sellSideSRP;
        /// <summary>
        /// Purchase Advice Sell Side SRP [2209]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6, Description = "Purchase Advice Sell Side SRP")]
        public decimal? SellSideSRP { get => _sellSideSRP; set => SetField(ref _sellSideSRP, value); }
        private DirtyValue<decimal?> _sellSideSRPPaidOut;
        /// <summary>
        /// Rate Lock Sell Side SRP Paid Out [2276]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Sell Side SRP Paid Out")]
        public decimal? SellSideSRPPaidOut { get => _sellSideSRPPaidOut; set => SetField(ref _sellSideSRPPaidOut, value); }
        private DirtyValue<string> _sellSideTradeGuid;
        /// <summary>
        /// Assigned Trade Unique Identifier [2819]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Assigned Trade Unique Identifier")]
        public string SellSideTradeGuid { get => _sellSideTradeGuid; set => SetField(ref _sellSideTradeGuid, value); }
        private DirtyValue<string> _sellSideTradeMgmtPrevConfirmedLockGuid;
        /// <summary>
        /// Rate Lock Identifier Trade Mgmt Prev Confirmed Lock [3839]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Lock Identifier Trade Mgmt Prev Confirmed Lock")]
        public string SellSideTradeMgmtPrevConfirmedLockGuid { get => _sellSideTradeMgmtPrevConfirmedLockGuid; set => SetField(ref _sellSideTradeMgmtPrevConfirmedLockGuid, value); }
        private DirtyValue<string> _sellSideTradeNumber;
        /// <summary>
        /// Rate Lock Assigned Trade Number [2032]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Lock Assigned Trade Number")]
        public string SellSideTradeNumber { get => _sellSideTradeNumber; set => SetField(ref _sellSideTradeNumber, value); }
        private DirtyValue<bool?> _servicingReleaseIndicator;
        /// <summary>
        /// Servicing Release Indicator [3338]
        /// </summary>
        [LoanFieldProperty(Description = "Servicing Release Indicator")]
        public bool? ServicingReleaseIndicator { get => _servicingReleaseIndicator; set => SetField(ref _servicingReleaseIndicator, value); }
        private DirtyValue<decimal?> _sRP;
        /// <summary>
        /// Purchase Advice SRP Received [2213]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Purchase Advice SRP Received")]
        public decimal? SRP { get => _sRP; set => SetField(ref _sRP, value); }
        private DirtyValue<decimal?> _sRPAmount;
        /// <summary>
        /// Purchase Advice SRP Amount [2210]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Purchase Advice SRP Amount")]
        public decimal? SRPAmount { get => _sRPAmount; set => SetField(ref _sRPAmount, value); }
        private DirtyValue<decimal?> _sRPPaidOut;
        /// <summary>
        /// Rate Lock Request SRP Paid Out [4201]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Request SRP Paid Out")]
        public decimal? SRPPaidOut { get => _sRPPaidOut; set => SetField(ref _sRPPaidOut, value); }
        private DirtyValue<string> _subjectPropertyCity;
        /// <summary>
        /// Lock Request Subject Property City [2943]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Subject Property City")]
        public string SubjectPropertyCity { get => _subjectPropertyCity; set => SetField(ref _subjectPropertyCity, value); }
        private DirtyValue<bool?> _subjectPropertyCondotelIndicator;
        /// <summary>
        /// Lock Request Subject Property is a Condotel [4115]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Subject Property is a Condotel")]
        public bool? SubjectPropertyCondotelIndicator { get => _subjectPropertyCondotelIndicator; set => SetField(ref _subjectPropertyCondotelIndicator, value); }
        private DirtyValue<string> _subjectPropertyCounty;
        /// <summary>
        /// Lock Request Subject Property County [2944]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Subject Property County")]
        public string SubjectPropertyCounty { get => _subjectPropertyCounty; set => SetField(ref _subjectPropertyCounty, value); }
        private DirtyValue<bool?> _subjectPropertyNonWarrantableProjectIndicator;
        /// <summary>
        /// Lock Request Subject Property is a Non-Warrantable Project [4116]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Subject Property is a Non-Warrantable Project")]
        public bool? SubjectPropertyNonWarrantableProjectIndicator { get => _subjectPropertyNonWarrantableProjectIndicator; set => SetField(ref _subjectPropertyNonWarrantableProjectIndicator, value); }
        private DirtyValue<string> _subjectPropertyPostalCode;
        /// <summary>
        /// Lock Request Subject Property Zip [2946]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Lock Request Subject Property Zip")]
        public string SubjectPropertyPostalCode { get => _subjectPropertyPostalCode; set => SetField(ref _subjectPropertyPostalCode, value); }
        private DirtyValue<StringEnumValue<State>> _subjectPropertyState;
        /// <summary>
        /// Lock Request Subject Property State [2945]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Subject Property State")]
        public StringEnumValue<State> SubjectPropertyState { get => _subjectPropertyState; set => SetField(ref _subjectPropertyState, value); }
        private DirtyValue<string> _subjectPropertyStreetAddress;
        /// <summary>
        /// Lock Request Subject Property Address [2942]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Subject Property Address")]
        public string SubjectPropertyStreetAddress { get => _subjectPropertyStreetAddress; set => SetField(ref _subjectPropertyStreetAddress, value); }
        private DirtyValue<string> _timeLockedWithInvestor;
        /// <summary>
        /// Rate Lock Sell Side Time Locked with Investor [2292]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Time Locked with Investor")]
        public string TimeLockedWithInvestor { get => _timeLockedWithInvestor; set => SetField(ref _timeLockedWithInvestor, value); }
        private DirtyValue<decimal?> _totalBuyPrice;
        /// <summary>
        /// Rate Lock Buy Side Total Buy Price [2218]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Buy Side Total Buy Price")]
        public decimal? TotalBuyPrice { get => _totalBuyPrice; set => SetField(ref _totalBuyPrice, value); }
        private DirtyValue<decimal?> _totalForLesserOfSumAsIs;
        /// <summary>
        /// Lock Request FHA 203k D2 Lesser of Sum(A2+B14)/A4 [3845]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Lock Request FHA 203k D2 Lesser of Sum(A2+B14)/A4")]
        public decimal? TotalForLesserOfSumAsIs { get => _totalForLesserOfSumAsIs; set => SetField(ref _totalForLesserOfSumAsIs, value); }
        private DirtyValue<decimal?> _totalPrice;
        /// <summary>
        /// Rate Lock Buy Side Total Price Concessions [3379]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Buy Side Total Price Concessions")]
        public decimal? TotalPrice { get => _totalPrice; set => SetField(ref _totalPrice, value); }
        private DirtyValue<decimal?> _totalSubordinateFinancing;
        /// <summary>
        /// Loan Info Subordinate Financing [2398]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Info Subordinate Financing")]
        public decimal? TotalSubordinateFinancing { get => _totalSubordinateFinancing; set => SetField(ref _totalSubordinateFinancing, value); }
        private DirtyValue<bool?> _twelveMonthMortgageRentalHistoryIndicator;
        /// <summary>
        /// Lock Request Borrower Can Demonstrate 12-Month Mortgage/Rental History [3530]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Borrower Can Demonstrate 12-Month Mortgage/Rental History")]
        public bool? TwelveMonthMortgageRentalHistoryIndicator { get => _twelveMonthMortgageRentalHistoryIndicator; set => SetField(ref _twelveMonthMortgageRentalHistoryIndicator, value); }
        private DirtyValue<string> _type;
        /// <summary>
        /// RateLock Type
        /// </summary>
        public string Type { get => _type; set => SetField(ref _type, value); }
        private DirtyValue<bool?> _usePoint;
        /// <summary>
        /// Use Point for Calculation SRP and Price Balancing [3430]
        /// </summary>
        [LoanFieldProperty(Description = "Use Point for Calculation SRP and Price Balancing")]
        public bool? UsePoint { get => _usePoint; set => SetField(ref _usePoint, value); }
    }
}