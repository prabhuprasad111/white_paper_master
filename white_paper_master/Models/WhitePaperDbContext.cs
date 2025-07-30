using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace white_paper_master.Models;

public partial class WhitePaperDbContext : DbContext
{
    public WhitePaperDbContext()
    {
    }

    public WhitePaperDbContext(DbContextOptions<WhitePaperDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MCbWpCategory> MCbWpCategories { get; set; }

    public virtual DbSet<MCbWpMainCategory> MCbWpMainCategories { get; set; }

    public virtual DbSet<MCbWpSubCategory> MCbWpSubCategories { get; set; }

    public virtual DbSet<OdWpCb34APoliceAct> OdWpCb34APoliceActs { get; set; }

    public virtual DbSet<OdWpCbAbductionOfMenIncMChild> OdWpCbAbductionOfMenIncMChildren { get; set; }

    public virtual DbSet<OdWpCbAbductionOfWomenIncFChild> OdWpCbAbductionOfWomenIncFChildren { get; set; }

    public virtual DbSet<OdWpCbAbductionOfWomenIncFeChild> OdWpCbAbductionOfWomenIncFeChildren { get; set; }

    public virtual DbSet<OdWpCbAbetmentSuicideIpc306> OdWpCbAbetmentSuicideIpc306s { get; set; }

    public virtual DbSet<OdWpCbAbetmentToCommitSuicideIpc306> OdWpCbAbetmentToCommitSuicideIpc306s { get; set; }

    public virtual DbSet<OdWpCbAcidAttackOnMenUs326A> OdWpCbAcidAttackOnMenUs326As { get; set; }

    public virtual DbSet<OdWpCbAcidAttackOnMenUs326B> OdWpCbAcidAttackOnMenUs326Bs { get; set; }

    public virtual DbSet<OdWpCbAcidAttackOnWomenUs326A> OdWpCbAcidAttackOnWomenUs326As { get; set; }

    public virtual DbSet<OdWpCbAcidAttackOnWomenUs326B> OdWpCbAcidAttackOnWomenUs326Bs { get; set; }

    public virtual DbSet<OdWpCbAffary> OdWpCbAffaries { get; set; }

    public virtual DbSet<OdWpCbAgeGrpFJd> OdWpCbAgeGrpFJds { get; set; }

    public virtual DbSet<OdWpCbArmsAct> OdWpCbArmsActs { get; set; }

    public virtual DbSet<OdWpCbArmsActIpc> OdWpCbArmsActIpcs { get; set; }

    public virtual DbSet<OdWpCbArmsActSeizure> OdWpCbArmsActSeizures { get; set; }

    public virtual DbSet<OdWpCbArmsActWithoutIpc> OdWpCbArmsActWithoutIpcs { get; set; }

    public virtual DbSet<OdWpCbArmsWithoutIpcAct> OdWpCbArmsWithoutIpcActs { get; set; }

    public virtual DbSet<OdWpCbArson> OdWpCbArsons { get; set; }

    public virtual DbSet<OdWpCbArtSeizedInECAct> OdWpCbArtSeizedInECActs { get; set; }

    public virtual DbSet<OdWpCbArtSeizedInECActWithoutIpc> OdWpCbArtSeizedInECActWithoutIpcs { get; set; }

    public virtual DbSet<OdWpCbArtSeizedInExcise> OdWpCbArtSeizedInExcises { get; set; }

    public virtual DbSet<OdWpCbArtSeizedInExciseWoIpc> OdWpCbArtSeizedInExciseWoIpcs { get; set; }

    public virtual DbSet<OdWpCbArtSeizedInGambling> OdWpCbArtSeizedInGamblings { get; set; }

    public virtual DbSet<OdWpCbArtSeizedInGamblingWoIpc> OdWpCbArtSeizedInGamblingWoIpcs { get; set; }

    public virtual DbSet<OdWpCbArtSeizedOfExtortionCase> OdWpCbArtSeizedOfExtortionCases { get; set; }

    public virtual DbSet<OdWpCbArtSeizedOfNdpsAct> OdWpCbArtSeizedOfNdpsActs { get; set; }

    public virtual DbSet<OdWpCbArtSeizedOfNdpsActWoIpc> OdWpCbArtSeizedOfNdpsActWoIpcs { get; set; }

    public virtual DbSet<OdWpCbArticleSeizedEcArtIpc> OdWpCbArticleSeizedEcArtIpcs { get; set; }

    public virtual DbSet<OdWpCbAssultToPolice> OdWpCbAssultToPolices { get; set; }

    public virtual DbSet<OdWpCbAtmLoot> OdWpCbAtmLoots { get; set; }

    public virtual DbSet<OdWpCbAttemptCommitRape> OdWpCbAttemptCommitRapes { get; set; }

    public virtual DbSet<OdWpCbAttemptMurder> OdWpCbAttemptMurders { get; set; }

    public virtual DbSet<OdWpCbAttemptPreToCommitDacoity> OdWpCbAttemptPreToCommitDacoities { get; set; }

    public virtual DbSet<OdWpCbAttemptPreToCommitDacoityCase> OdWpCbAttemptPreToCommitDacoityCases { get; set; }

    public virtual DbSet<OdWpCbAttemptToCommitSuicide> OdWpCbAttemptToCommitSuicides { get; set; }

    public virtual DbSet<OdWpCbAutoBurglary> OdWpCbAutoBurglaries { get; set; }

    public virtual DbSet<OdWpCbAutoBurglary2> OdWpCbAutoBurglary2s { get; set; }

    public virtual DbSet<OdWpCbAutoBurglary3> OdWpCbAutoBurglary3s { get; set; }

    public virtual DbSet<OdWpCbAutoBurglary4> OdWpCbAutoBurglary4s { get; set; }

    public virtual DbSet<OdWpCbAutoBurglaryAboveFourWheeler> OdWpCbAutoBurglaryAboveFourWheelers { get; set; }

    public virtual DbSet<OdWpCbAutoBurglaryTotal> OdWpCbAutoBurglaryTotals { get; set; }

    public virtual DbSet<OdWpCbAutoTheft> OdWpCbAutoThefts { get; set; }

    public virtual DbSet<OdWpCbAutoTheft2w> OdWpCbAutoTheft2ws { get; set; }

    public virtual DbSet<OdWpCbAutoTheft3w> OdWpCbAutoTheft3ws { get; set; }

    public virtual DbSet<OdWpCbAutoTheft4w> OdWpCbAutoTheft4ws { get; set; }

    public virtual DbSet<OdWpCbAutoTheftAboveFourWheeler> OdWpCbAutoTheftAboveFourWheelers { get; set; }

    public virtual DbSet<OdWpCbAutoTheftTotal> OdWpCbAutoTheftTotals { get; set; }

    public virtual DbSet<OdWpCbBankDacoity> OdWpCbBankDacoities { get; set; }

    public virtual DbSet<OdWpCbBankDacoityBankCash> OdWpCbBankDacoityBankCashes { get; set; }

    public virtual DbSet<OdWpCbBankFraudCase> OdWpCbBankFraudCases { get; set; }

    public virtual DbSet<OdWpCbBankRobbery> OdWpCbBankRobberies { get; set; }

    public virtual DbSet<OdWpCbBankRobberyBankCash> OdWpCbBankRobberyBankCashes { get; set; }

    public virtual DbSet<OdWpCbBondedLabour> OdWpCbBondedLabours { get; set; }

    public virtual DbSet<OdWpCbBurglaryCase> OdWpCbBurglaryCases { get; set; }

    public virtual DbSet<OdWpCbBwTotalCase> OdWpCbBwTotalCases { get; set; }

    public virtual DbSet<OdWpCbCasesAgainstJd> OdWpCbCasesAgainstJds { get; set; }

    public virtual DbSet<OdWpCbCasesAttackDoctor> OdWpCbCasesAttackDoctors { get; set; }

    public virtual DbSet<OdWpCbCasesBettingCricMatch> OdWpCbCasesBettingCricMatches { get; set; }

    public virtual DbSet<OdWpCbCasesFAttackJournalistMedium> OdWpCbCasesFAttackJournalistMedia { get; set; }

    public virtual DbSet<OdWpCbCasesOfAttackOnDoctor> OdWpCbCasesOfAttackOnDoctors { get; set; }

    public virtual DbSet<OdWpCbCasesSupervisedGo> OdWpCbCasesSupervisedGos { get; set; }

    public virtual DbSet<OdWpCbCasesSurervisByGov> OdWpCbCasesSurervisByGovs { get; set; }

    public virtual DbSet<OdWpCbChildMarriageAct> OdWpCbChildMarriageActs { get; set; }

    public virtual DbSet<OdWpCbChildProstitution> OdWpCbChildProstitutions { get; set; }

    public virtual DbSet<OdWpCbCogPendingYrwise> OdWpCbCogPendingYrwises { get; set; }

    public virtual DbSet<OdWpCbCollectionChandum> OdWpCbCollectionChanda { get; set; }

    public virtual DbSet<OdWpCbComplaintAPolice> OdWpCbComplaintAPolices { get; set; }

    public virtual DbSet<OdWpCbContactKilling> OdWpCbContactKillings { get; set; }

    public virtual DbSet<OdWpCbCounterfeitCurrency> OdWpCbCounterfeitCurrencies { get; set; }

    public virtual DbSet<OdWpCbCriminalAGovtSer> OdWpCbCriminalAGovtSers { get; set; }

    public virtual DbSet<OdWpCbCriminalBreachOfTrust> OdWpCbCriminalBreachOfTrusts { get; set; }

    public virtual DbSet<OdWpCbCriminalIntimidation> OdWpCbCriminalIntimidations { get; set; }

    public virtual DbSet<OdWpCbCulturalPropertyTheft> OdWpCbCulturalPropertyThefts { get; set; }

    public virtual DbSet<OdWpCbCyberCrimeOtherF> OdWpCbCyberCrimeOtherves { get; set; }

    public virtual DbSet<OdWpCbCyberCrimeRelFinancialF> OdWpCbCyberCrimeRelFinancialves { get; set; }

    public virtual DbSet<OdWpCbCyberCrimeRelHackingF> OdWpCbCyberCrimeRelHackingFs { get; set; }

    public virtual DbSet<OdWpCbCyberCrimeRelSocialMediaF> OdWpCbCyberCrimeRelSocialMediaFs { get; set; }

    public virtual DbSet<OdWpCbDacoityCase> OdWpCbDacoityCases { get; set; }

    public virtual DbSet<OdWpCbDacoityWithMurder> OdWpCbDacoityWithMurders { get; set; }

    public virtual DbSet<OdWpCbDeathInPoliceCustody> OdWpCbDeathInPoliceCustodies { get; set; }

    public virtual DbSet<OdWpCbDisSessionTCase> OdWpCbDisSessionTCases { get; set; }

    public virtual DbSet<OdWpCbDispoPendingCriminalCase> OdWpCbDispoPendingCriminalCases { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcAdulterationSaleFood> OdWpCbDisposalIpcAdulterationSaleFoods { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcAffray> OdWpCbDisposalIpcAffrays { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcAgainstState> OdWpCbDisposalIpcAgainstStates { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcArson> OdWpCbDisposalIpcArsons { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcAssaultWoman> OdWpCbDisposalIpcAssaultWomen { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcAtmptHomicide> OdWpCbDisposalIpcAtmptHomicides { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcAtmptSuicide> OdWpCbDisposalIpcAtmptSuicides { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcAttemptDacoity> OdWpCbDisposalIpcAttemptDacoities { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcAttemptMurder> OdWpCbDisposalIpcAttemptMurders { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcAttemptRape> OdWpCbDisposalIpcAttemptRapes { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcAttemptSuicide> OdWpCbDisposalIpcAttemptSuicides { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcBreachTrust> OdWpCbDisposalIpcBreachTrusts { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcBurglary> OdWpCbDisposalIpcBurglaries { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcBuyingMinor> OdWpCbDisposalIpcBuyingMinors { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcCheatingImprsnmnt> OdWpCbDisposalIpcCheatingImprsnmnts { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcCirculateFakeNews> OdWpCbDisposalIpcCirculateFakeNews { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcCommittingDacoity> OdWpCbDisposalIpcCommittingDacoities { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcCounterfieting> OdWpCbDisposalIpcCounterfietings { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcCriminalIntimidation> OdWpCbDisposalIpcCriminalIntimidations { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcCriminalIntmdtn> OdWpCbDisposalIpcCriminalIntmdtns { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcCrmnlMisaprtn> OdWpCbDisposalIpcCrmnlMisaprtns { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcCrueltyByHusbnd> OdWpCbDisposalIpcCrueltyByHusbnds { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcDacoity> OdWpCbDisposalIpcDacoities { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcDeathNeglgnce> OdWpCbDisposalIpcDeathNeglgnces { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcDishonestlyStlngProp> OdWpCbDisposalIpcDishonestlyStlngProps { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcDisobdncPublcServant> OdWpCbDisposalIpcDisobdncPublcServants { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcDowryDeath> OdWpCbDisposalIpcDowryDeaths { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcExploitation> OdWpCbDisposalIpcExploitations { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcExtortion> OdWpCbDisposalIpcExtortions { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcFurgery> OdWpCbDisposalIpcFurgeries { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcHarbouring> OdWpCbDisposalIpcHarbourings { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcHomicide> OdWpCbDisposalIpcHomicides { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcHumanTrafficking> OdWpCbDisposalIpcHumanTraffickings { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcHurt> OdWpCbDisposalIpcHurts { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcInsultWoman> OdWpCbDisposalIpcInsultWomen { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcKidnapping> OdWpCbDisposalIpcKidnappings { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcMiscarriage> OdWpCbDisposalIpcMiscarriages { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcMischief> OdWpCbDisposalIpcMischiefs { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcMurder> OdWpCbDisposalIpcMurders { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcObsenceSong> OdWpCbDisposalIpcObsenceSongs { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcObstructionPblcWay> OdWpCbDisposalIpcObstructionPblcWays { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcOtheripcCrime> OdWpCbDisposalIpcOtheripcCrimes { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcPrmotingEnmity> OdWpCbDisposalIpcPrmotingEnmities { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcRape> OdWpCbDisposalIpcRapes { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcRashDriving> OdWpCbDisposalIpcRashDrivings { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcRelatingMischief> OdWpCbDisposalIpcRelatingMischiefs { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcRelatingReligion> OdWpCbDisposalIpcRelatingReligions { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcRelatngElection> OdWpCbDisposalIpcRelatngElections { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcReligion> OdWpCbDisposalIpcReligions { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcRiot> OdWpCbDisposalIpcRiots { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcRobbery> OdWpCbDisposalIpcRobberies { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcSaleObsceneBook> OdWpCbDisposalIpcSaleObsceneBooks { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcSellingMinor> OdWpCbDisposalIpcSellingMinors { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcTheft> OdWpCbDisposalIpcThefts { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcTotalIpcCrime> OdWpCbDisposalIpcTotalIpcCrimes { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcTotalSllCrime> OdWpCbDisposalIpcTotalSllCrimes { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcTreespass> OdWpCbDisposalIpcTreespasses { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcUnlawflAssembly> OdWpCbDisposalIpcUnlawflAssemblies { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcUnnatural> OdWpCbDisposalIpcUnnaturals { get; set; }

    public virtual DbSet<OdWpCbDisposalIpcWrngflRestraint> OdWpCbDisposalIpcWrngflRestraints { get; set; }

    public virtual DbSet<OdWpCbDisposalSllAirWaterPrevntn> OdWpCbDisposalSllAirWaterPrevntns { get; set; }

    public virtual DbSet<OdWpCbDisposalSllAntiqueArtTresureAct> OdWpCbDisposalSllAntiqueArtTresureActs { get; set; }

    public virtual DbSet<OdWpCbDisposalSllArmsAct> OdWpCbDisposalSllArmsActs { get; set; }

    public virtual DbSet<OdWpCbDisposalSllBenamiTran> OdWpCbDisposalSllBenamiTrans { get; set; }

    public virtual DbSet<OdWpCbDisposalSllBondedLabourAct> OdWpCbDisposalSllBondedLabourActs { get; set; }

    public virtual DbSet<OdWpCbDisposalSllCenematographAct> OdWpCbDisposalSllCenematographActs { get; set; }

    public virtual DbSet<OdWpCbDisposalSllChildLabour> OdWpCbDisposalSllChildLabours { get; set; }

    public virtual DbSet<OdWpCbDisposalSllChildMarriageAct> OdWpCbDisposalSllChildMarriageActs { get; set; }

    public virtual DbSet<OdWpCbDisposalSllChitFund> OdWpCbDisposalSllChitFunds { get; set; }

    public virtual DbSet<OdWpCbDisposalSllCigaretteTobacco> OdWpCbDisposalSllCigaretteTobaccos { get; set; }

    public virtual DbSet<OdWpCbDisposalSllCitizenship> OdWpCbDisposalSllCitizenships { get; set; }

    public virtual DbSet<OdWpCbDisposalSllCivilRightsAgnstSc> OdWpCbDisposalSllCivilRightsAgnstScs { get; set; }

    public virtual DbSet<OdWpCbDisposalSllCivilRightsAgnstSt> OdWpCbDisposalSllCivilRightsAgnstSts { get; set; }

    public virtual DbSet<OdWpCbDisposalSllCopyrightAct> OdWpCbDisposalSllCopyrightActs { get; set; }

    public virtual DbSet<OdWpCbDisposalSllCorruptionAct> OdWpCbDisposalSllCorruptionActs { get; set; }

    public virtual DbSet<OdWpCbDisposalSllCrime> OdWpCbDisposalSllCrimes { get; set; }

    public virtual DbSet<OdWpCbDisposalSllDamagePublicProp> OdWpCbDisposalSllDamagePublicProps { get; set; }

    public virtual DbSet<OdWpCbDisposalSllDefacementPublicProp> OdWpCbDisposalSllDefacementPublicProps { get; set; }

    public virtual DbSet<OdWpCbDisposalSllDowry> OdWpCbDisposalSllDowries { get; set; }

    public virtual DbSet<OdWpCbDisposalSllEcAct> OdWpCbDisposalSllEcActs { get; set; }

    public virtual DbSet<OdWpCbDisposalSllElectricityAct> OdWpCbDisposalSllElectricityActs { get; set; }

    public virtual DbSet<OdWpCbDisposalSllEmigration> OdWpCbDisposalSllEmigrations { get; set; }

    public virtual DbSet<OdWpCbDisposalSllEnvironmentalProtection> OdWpCbDisposalSllEnvironmentalProtections { get; set; }

    public virtual DbSet<OdWpCbDisposalSllExcise> OdWpCbDisposalSllExcises { get; set; }

    public virtual DbSet<OdWpCbDisposalSllExplosiveSubstance> OdWpCbDisposalSllExplosiveSubstances { get; set; }

    public virtual DbSet<OdWpCbDisposalSllExplosivesAct> OdWpCbDisposalSllExplosivesActs { get; set; }

    public virtual DbSet<OdWpCbDisposalSllFoodAdulterationAct> OdWpCbDisposalSllFoodAdulterationActs { get; set; }

    public virtual DbSet<OdWpCbDisposalSllFoodSafetyAct> OdWpCbDisposalSllFoodSafetyActs { get; set; }

    public virtual DbSet<OdWpCbDisposalSllForeignersAct> OdWpCbDisposalSllForeignersActs { get; set; }

    public virtual DbSet<OdWpCbDisposalSllForestAct> OdWpCbDisposalSllForestActs { get; set; }

    public virtual DbSet<OdWpCbDisposalSllGamblingAct> OdWpCbDisposalSllGamblingActs { get; set; }

    public virtual DbSet<OdWpCbDisposalSllImmoralDomesticViolence> OdWpCbDisposalSllImmoralDomesticViolences { get; set; }

    public virtual DbSet<OdWpCbDisposalSllImmoralTrafficking> OdWpCbDisposalSllImmoralTraffickings { get; set; }

    public virtual DbSet<OdWpCbDisposalSllIndecentReprsntnWoman> OdWpCbDisposalSllIndecentReprsntnWomen { get; set; }

    public virtual DbSet<OdWpCbDisposalSllInsultNationalHonour> OdWpCbDisposalSllInsultNationalHonours { get; set; }

    public virtual DbSet<OdWpCbDisposalSllItAct> OdWpCbDisposalSllItActs { get; set; }

    public virtual DbSet<OdWpCbDisposalSllJjAct> OdWpCbDisposalSllJjActs { get; set; }

    public virtual DbSet<OdWpCbDisposalSllLocalAct> OdWpCbDisposalSllLocalActs { get; set; }

    public virtual DbSet<OdWpCbDisposalSllMedicalTerminationPregnency> OdWpCbDisposalSllMedicalTerminationPregnencies { get; set; }

    public virtual DbSet<OdWpCbDisposalSllMinesMineral> OdWpCbDisposalSllMinesMinerals { get; set; }

    public virtual DbSet<OdWpCbDisposalSllMvAct> OdWpCbDisposalSllMvActs { get; set; }

    public virtual DbSet<OdWpCbDisposalSllNdp> OdWpCbDisposalSllNdps { get; set; }

    public virtual DbSet<OdWpCbDisposalSllNiosePollution> OdWpCbDisposalSllNiosePollutions { get; set; }

    public virtual DbSet<OdWpCbDisposalSllOfficialSecret> OdWpCbDisposalSllOfficialSecrets { get; set; }

    public virtual DbSet<OdWpCbDisposalSllPassport> OdWpCbDisposalSllPassports { get; set; }

    public virtual DbSet<OdWpCbDisposalSllPeopleAct> OdWpCbDisposalSllPeopleActs { get; set; }

    public virtual DbSet<OdWpCbDisposalSllPocso> OdWpCbDisposalSllPocsos { get; set; }

    public virtual DbSet<OdWpCbDisposalSllPreNatal> OdWpCbDisposalSllPreNatals { get; set; }

    public virtual DbSet<OdWpCbDisposalSllRailwayAct> OdWpCbDisposalSllRailwayActs { get; set; }

    public virtual DbSet<OdWpCbDisposalSllRailwayPropAct> OdWpCbDisposalSllRailwayPropActs { get; set; }

    public virtual DbSet<OdWpCbDisposalSllStscAgnstSc> OdWpCbDisposalSllStscAgnstScs { get; set; }

    public virtual DbSet<OdWpCbDisposalSllStscAgnstSt> OdWpCbDisposalSllStscAgnstSts { get; set; }

    public virtual DbSet<OdWpCbDisposalSllTelegraphAct> OdWpCbDisposalSllTelegraphActs { get; set; }

    public virtual DbSet<OdWpCbDisposalSllTelegraphWireAct> OdWpCbDisposalSllTelegraphWireActs { get; set; }

    public virtual DbSet<OdWpCbDisposalSllTelevisionAct> OdWpCbDisposalSllTelevisionActs { get; set; }

    public virtual DbSet<OdWpCbDisposalSllTownPoliceAct> OdWpCbDisposalSllTownPoliceActs { get; set; }

    public virtual DbSet<OdWpCbDisposalSllTransgender> OdWpCbDisposalSllTransgenders { get; set; }

    public virtual DbSet<OdWpCbDisposalSllTransplantationHumanOrgan> OdWpCbDisposalSllTransplantationHumanOrgans { get; set; }

    public virtual DbSet<OdWpCbDisposalSllUnlawfulActivity> OdWpCbDisposalSllUnlawfulActivities { get; set; }

    public virtual DbSet<OdWpCbDisposalSllWildlifeProtection> OdWpCbDisposalSllWildlifeProtections { get; set; }

    public virtual DbSet<OdWpCbDowryHomicide> OdWpCbDowryHomicides { get; set; }

    public virtual DbSet<OdWpCbDowryProhibitionAct> OdWpCbDowryProhibitionActs { get; set; }

    public virtual DbSet<OdWpCbDowrySuicide> OdWpCbDowrySuicides { get; set; }

    public virtual DbSet<OdWpCbDowryTorture> OdWpCbDowryTortures { get; set; }

    public virtual DbSet<OdWpCbDrugging> OdWpCbDruggings { get; set; }

    public virtual DbSet<OdWpCbECActIpc> OdWpCbECActIpcs { get; set; }

    public virtual DbSet<OdWpCbECActWithoutIpc> OdWpCbECActWithoutIpcs { get; set; }

    public virtual DbSet<OdWpCbEnergyTheft> OdWpCbEnergyThefts { get; set; }

    public virtual DbSet<OdWpCbEscapePolCustody> OdWpCbEscapePolCustodies { get; set; }

    public virtual DbSet<OdWpCbEssentialCommoAct> OdWpCbEssentialCommoActs { get; set; }

    public virtual DbSet<OdWpCbEssentialCommoActWithoutIpc> OdWpCbEssentialCommoActWithoutIpcs { get; set; }

    public virtual DbSet<OdWpCbEveTeasing> OdWpCbEveTeasings { get; set; }

    public virtual DbSet<OdWpCbExciseAct> OdWpCbExciseActs { get; set; }

    public virtual DbSet<OdWpCbExciseActWoIpc> OdWpCbExciseActWoIpcs { get; set; }

    public virtual DbSet<OdWpCbExciseIpc> OdWpCbExciseIpcs { get; set; }

    public virtual DbSet<OdWpCbExciseWoIpc> OdWpCbExciseWoIpcs { get; set; }

    public virtual DbSet<OdWpCbExplosiveAct> OdWpCbExplosiveActs { get; set; }

    public virtual DbSet<OdWpCbExplosiveActIpc> OdWpCbExplosiveActIpcs { get; set; }

    public virtual DbSet<OdWpCbExplosiveActSeizureWithoutIpc> OdWpCbExplosiveActSeizureWithoutIpcs { get; set; }

    public virtual DbSet<OdWpCbExplosiveActWithoutIpc> OdWpCbExplosiveActWithoutIpcs { get; set; }

    public virtual DbSet<OdWpCbExplosiveSubstance> OdWpCbExplosiveSubstances { get; set; }

    public virtual DbSet<OdWpCbExplosiveSubstanceAct> OdWpCbExplosiveSubstanceActs { get; set; }

    public virtual DbSet<OdWpCbExplosiveSubstanceActSeizure> OdWpCbExplosiveSubstanceActSeizures { get; set; }

    public virtual DbSet<OdWpCbExplosiveSubstanceActWtoIpc> OdWpCbExplosiveSubstanceActWtoIpcs { get; set; }

    public virtual DbSet<OdWpCbExplosiveSubstanceWithoutIpc> OdWpCbExplosiveSubstanceWithoutIpcs { get; set; }

    public virtual DbSet<OdWpCbExtortion> OdWpCbExtortions { get; set; }

    public virtual DbSet<OdWpCbGamblingAct> OdWpCbGamblingActs { get; set; }

    public virtual DbSet<OdWpCbGamblingActWoIpc> OdWpCbGamblingActWoIpcs { get; set; }

    public virtual DbSet<OdWpCbGamblingActWtoIpc> OdWpCbGamblingActWtoIpcs { get; set; }

    public virtual DbSet<OdWpCbGamblingDenseRaided> OdWpCbGamblingDenseRaideds { get; set; }

    public virtual DbSet<OdWpCbGamblingIpc> OdWpCbGamblingIpcs { get; set; }

    public virtual DbSet<OdWpCbGamblingWoIpc> OdWpCbGamblingWoIpcs { get; set; }

    public virtual DbSet<OdWpCbGangRapeCases376DbIpcBelow12y> OdWpCbGangRapeCases376DbIpcBelow12ies { get; set; }

    public virtual DbSet<OdWpCbGrCase> OdWpCbGrCases { get; set; }

    public virtual DbSet<OdWpCbHarashmentSeniorCitizen> OdWpCbHarashmentSeniorCitizens { get; set; }

    public virtual DbSet<OdWpCbHomicideMurderIpc304> OdWpCbHomicideMurderIpc304s { get; set; }

    public virtual DbSet<OdWpCbHonourKilling> OdWpCbHonourKillings { get; set; }

    public virtual DbSet<OdWpCbHumanOrganTransplant> OdWpCbHumanOrganTransplants { get; set; }

    public virtual DbSet<OdWpCbHumanSacrifice> OdWpCbHumanSacrifices { get; set; }

    public virtual DbSet<OdWpCbHumanTrafficking> OdWpCbHumanTraffickings { get; set; }

    public virtual DbSet<OdWpCbIdolTheft> OdWpCbIdolThefts { get; set; }

    public virtual DbSet<OdWpCbIllegalPosseOfArm> OdWpCbIllegalPosseOfArms { get; set; }

    public virtual DbSet<OdWpCbIllegalPosseOfArmsWoIpcBn> OdWpCbIllegalPosseOfArmsWoIpcBns { get; set; }

    public virtual DbSet<OdWpCbIncFWomenProhiAct> OdWpCbIncFWomenProhiActs { get; set; }

    public virtual DbSet<OdWpCbIpcExplosiveSubstanceAct> OdWpCbIpcExplosiveSubstanceActs { get; set; }

    public virtual DbSet<OdWpCbIpcWrngflRestraint> OdWpCbIpcWrngflRestraints { get; set; }

    public virtual DbSet<OdWpCbItpAct> OdWpCbItpActs { get; set; }

    public virtual DbSet<OdWpCbJuvenileJusticeAct> OdWpCbJuvenileJusticeActs { get; set; }

    public virtual DbSet<OdWpCbKiddnapAbductOfMan> OdWpCbKiddnapAbductOfMen { get; set; }

    public virtual DbSet<OdWpCbKiddnapAbductOfMf> OdWpCbKiddnapAbductOfMfs { get; set; }

    public virtual DbSet<OdWpCbKiddnapAbductOfTotal> OdWpCbKiddnapAbductOfTotals { get; set; }

    public virtual DbSet<OdWpCbKiddnapAbductOfWoman> OdWpCbKiddnapAbductOfWomen { get; set; }

    public virtual DbSet<OdWpCbKiddnapOfWomenIncFeChild> OdWpCbKiddnapOfWomenIncFeChildren { get; set; }

    public virtual DbSet<OdWpCbKidnappingChildrenBegging> OdWpCbKidnappingChildrenBeggings { get; set; }

    public virtual DbSet<OdWpCbKidnappingOfMenIncMChild> OdWpCbKidnappingOfMenIncMChildren { get; set; }

    public virtual DbSet<OdWpCbKidnappingOfWomenIncFChild> OdWpCbKidnappingOfWomenIncFChildren { get; set; }

    public virtual DbSet<OdWpCbKidnappingRansom> OdWpCbKidnappingRansoms { get; set; }

    public virtual DbSet<OdWpCbLiquoreDenseRaided> OdWpCbLiquoreDenseRaideds { get; set; }

    public virtual DbSet<OdWpCbLokAdalatCase> OdWpCbLokAdalatCases { get; set; }

    public virtual DbSet<OdWpCbMinesMineralsMmdrAct> OdWpCbMinesMineralsMmdrActs { get; set; }

    public virtual DbSet<OdWpCbMiscellaneousCase> OdWpCbMiscellaneousCases { get; set; }

    public virtual DbSet<OdWpCbMobLynching> OdWpCbMobLynchings { get; set; }

    public virtual DbSet<OdWpCbMolestationUs354> OdWpCbMolestationUs354s { get; set; }

    public virtual DbSet<OdWpCbMurderCase> OdWpCbMurderCases { get; set; }

    public virtual DbSet<OdWpCbMurderOfMinorGirlWithRape> OdWpCbMurderOfMinorGirlWithRapes { get; set; }

    public virtual DbSet<OdWpCbMurderOfWoman> OdWpCbMurderOfWomen { get; set; }

    public virtual DbSet<OdWpCbMurderOfWomenWithRape> OdWpCbMurderOfWomenWithRapes { get; set; }

    public virtual DbSet<OdWpCbMvAccidentCase> OdWpCbMvAccidentCases { get; set; }

    public virtual DbSet<OdWpCbNbwTotalCase> OdWpCbNbwTotalCases { get; set; }

    public virtual DbSet<OdWpCbNdpsAct> OdWpCbNdpsActs { get; set; }

    public virtual DbSet<OdWpCbNdpsIpc> OdWpCbNdpsIpcs { get; set; }

    public virtual DbSet<OdWpCbNdpsWoIpc> OdWpCbNdpsWoIpcs { get; set; }

    public virtual DbSet<OdWpCbNdpsWoIpcAct> OdWpCbNdpsWoIpcActs { get; set; }

    public virtual DbSet<OdWpCbNightArrest> OdWpCbNightArrests { get; set; }

    public virtual DbSet<OdWpCbNonDowryTorture> OdWpCbNonDowryTortures { get; set; }

    public virtual DbSet<OdWpCbNonFir> OdWpCbNonFirs { get; set; }

    public virtual DbSet<OdWpCbOdPrevenFCowLaughterAct> OdWpCbOdPrevenFCowLaughterActs { get; set; }

    public virtual DbSet<OdWpCbOdPrevenFWitchAct201> OdWpCbOdPrevenFWitchAct201s { get; set; }

    public virtual DbSet<OdWpCbOffenceComBail> OdWpCbOffenceComBails { get; set; }

    public virtual DbSet<OdWpCbOffenceComParole> OdWpCbOffenceComParoles { get; set; }

    public virtual DbSet<OdWpCbOffenceCommGr> OdWpCbOffenceCommGrs { get; set; }

    public virtual DbSet<OdWpCbOffenceCommHg> OdWpCbOffenceCommHgs { get; set; }

    public virtual DbSet<OdWpCbOffenceCommPolice> OdWpCbOffenceCommPolices { get; set; }

    public virtual DbSet<OdWpCbOmlrAct> OdWpCbOmlrActs { get; set; }

    public virtual DbSet<OdWpCbOmlrScheduledArea> OdWpCbOmlrScheduledAreas { get; set; }

    public virtual DbSet<OdWpCbOmptAct> OdWpCbOmptActs { get; set; }

    public virtual DbSet<OdWpCbOtherIpcOffencesCommitedAgainstWoman> OdWpCbOtherIpcOffencesCommitedAgainstWomen { get; set; }

    public virtual DbSet<OdWpCbOtherIpcOffencesCommitedByWoman> OdWpCbOtherIpcOffencesCommitedByWomen { get; set; }

    public virtual DbSet<OdWpCbPcrActProCivilRt> OdWpCbPcrActProCivilRts { get; set; }

    public virtual DbSet<OdWpCbPendingSupNote> OdWpCbPendingSupNotes { get; set; }

    public virtual DbSet<OdWpCbPocsoAct> OdWpCbPocsoActs { get; set; }

    public virtual DbSet<OdWpCbPocsoActTotal> OdWpCbPocsoActTotals { get; set; }

    public virtual DbSet<OdWpCbPocsoCasesMinorBoy> OdWpCbPocsoCasesMinorBoys { get; set; }

    public virtual DbSet<OdWpCbPocsoCasesMinorGirl> OdWpCbPocsoCasesMinorGirls { get; set; }

    public virtual DbSet<OdWpCbPocsoCasesTg> OdWpCbPocsoCasesTgs { get; set; }

    public virtual DbSet<OdWpCbPocsoCasesTotalMinorBoy> OdWpCbPocsoCasesTotalMinorBoys { get; set; }

    public virtual DbSet<OdWpCbPocsoCasesTotalMinorGirl> OdWpCbPocsoCasesTotalMinorGirls { get; set; }

    public virtual DbSet<OdWpCbPocsoCasesTotalTransgender> OdWpCbPocsoCasesTotalTransgenders { get; set; }

    public virtual DbSet<OdWpCbPoliceEncounterCasesPartI> OdWpCbPoliceEncounterCasesPartIs { get; set; }

    public virtual DbSet<OdWpCbPrUS107Crpc> OdWpCbPrUS107Crpcs { get; set; }

    public virtual DbSet<OdWpCbPrUS109110Crpc> OdWpCbPrUS109110Crpcs { get; set; }

    public virtual DbSet<OdWpCbPrUS144Crpc> OdWpCbPrUS144Crpcs { get; set; }

    public virtual DbSet<OdWpCbPrUS145146Crpc> OdWpCbPrUS145146Crpcs { get; set; }

    public virtual DbSet<OdWpCbPreventCrueltyAnimalAct> OdWpCbPreventCrueltyAnimalActs { get; set; }

    public virtual DbSet<OdWpCbPreventOfCrueltyAnimalAct> OdWpCbPreventOfCrueltyAnimalActs { get; set; }

    public virtual DbSet<OdWpCbPsWiseCogCase> OdWpCbPsWiseCogCases { get; set; }

    public virtual DbSet<OdWpCbPsWiseConviction> OdWpCbPsWiseConvictions { get; set; }

    public virtual DbSet<OdWpCbPublicDistorOfWomenUs354B> OdWpCbPublicDistorOfWomenUs354Bs { get; set; }

    public virtual DbSet<OdWpCbRagging> OdWpCbRaggings { get; set; }

    public virtual DbSet<OdWpCbRankWisePendingCogCase> OdWpCbRankWisePendingCogCases { get; set; }

    public virtual DbSet<OdWpCbRapeAttemptToCommit> OdWpCbRapeAttemptToCommits { get; set; }

    public virtual DbSet<OdWpCbRapeByRelation> OdWpCbRapeByRelations { get; set; }

    public virtual DbSet<OdWpCbRapeCase> OdWpCbRapeCases { get; set; }

    public virtual DbSet<OdWpCbRapeCases3761> OdWpCbRapeCases3761s { get; set; }

    public virtual DbSet<OdWpCbRapeCases3762> OdWpCbRapeCases3762s { get; set; }

    public virtual DbSet<OdWpCbRapeCases3763> OdWpCbRapeCases3763s { get; set; }

    public virtual DbSet<OdWpCbRapeCases376A> OdWpCbRapeCases376As { get; set; }

    public virtual DbSet<OdWpCbRapeCases376Ab> OdWpCbRapeCases376Abs { get; set; }

    public virtual DbSet<OdWpCbRapeCases376AbIpcBelow12y> OdWpCbRapeCases376AbIpcBelow12ies { get; set; }

    public virtual DbSet<OdWpCbRapeCases376B> OdWpCbRapeCases376Bs { get; set; }

    public virtual DbSet<OdWpCbRapeCases376C> OdWpCbRapeCases376Cs { get; set; }

    public virtual DbSet<OdWpCbRapeCases376D> OdWpCbRapeCases376Ds { get; set; }

    public virtual DbSet<OdWpCbRapeCases376DAbove16y> OdWpCbRapeCases376DAbove16ies { get; set; }

    public virtual DbSet<OdWpCbRapeCases376DaIpcBelow16y> OdWpCbRapeCases376DaIpcBelow16ies { get; set; }

    public virtual DbSet<OdWpCbRapeCases376Db> OdWpCbRapeCases376Dbs { get; set; }

    public virtual DbSet<OdWpCbRapeCases376Dum> OdWpCbRapeCases376Da { get; set; }

    public virtual DbSet<OdWpCbRapeCases376E> OdWpCbRapeCases376Es { get; set; }

    public virtual DbSet<OdWpCbRapeCasesMinor> OdWpCbRapeCasesMinors { get; set; }

    public virtual DbSet<OdWpCbRapeCasesMinorBelow18> OdWpCbRapeCasesMinorBelow18s { get; set; }

    public virtual DbSet<OdWpCbRapeCasesScStViction> OdWpCbRapeCasesScStVictions { get; set; }

    public virtual DbSet<OdWpCbRapeCasesScStViction1> OdWpCbRapeCasesScStVictions1 { get; set; }

    public virtual DbSet<OdWpCbRapeInsideRunningVehicle> OdWpCbRapeInsideRunningVehicles { get; set; }

    public virtual DbSet<OdWpCbReasonsHumanTrafficking> OdWpCbReasonsHumanTraffickings { get; set; }

    public virtual DbSet<OdWpCbRefusalMarryAfterSex> OdWpCbRefusalMarryAfterSexes { get; set; }

    public virtual DbSet<OdWpCbRelatingFinancialFraud2023> OdWpCbRelatingFinancialFraud2023s { get; set; }

    public virtual DbSet<OdWpCbRiotingCase> OdWpCbRiotingCases { get; set; }

    public virtual DbSet<OdWpCbRobberyCase> OdWpCbRobberyCases { get; set; }

    public virtual DbSet<OdWpCbRptTheft> OdWpCbRptThefts { get; set; }

    public virtual DbSet<OdWpCbScStPoaActForSc> OdWpCbScStPoaActForScs { get; set; }

    public virtual DbSet<OdWpCbScStPoaActForSt> OdWpCbScStPoaActForSts { get; set; }

    public virtual DbSet<OdWpCbSeizedEcArtIpc> OdWpCbSeizedEcArtIpcs { get; set; }

    public virtual DbSet<OdWpCbSeizedVehiclesLyingAtP> OdWpCbSeizedVehiclesLyingAtPs { get; set; }

    public virtual DbSet<OdWpCbSeizureExtoCase> OdWpCbSeizureExtoCases { get; set; }

    public virtual DbSet<OdWpCbSexHarashsmentWorkplaceWoman> OdWpCbSexHarashsmentWorkplaceWomen { get; set; }

    public virtual DbSet<OdWpCbSexualHarassmentUs354A> OdWpCbSexualHarassmentUs354As { get; set; }

    public virtual DbSet<OdWpCbSnatching> OdWpCbSnatchings { get; set; }

    public virtual DbSet<OdWpCbSocialBoycott> OdWpCbSocialBoycotts { get; set; }

    public virtual DbSet<OdWpCbStalkingUs354D> OdWpCbStalkingUs354Ds { get; set; }

    public virtual DbSet<OdWpCbSuicideFarmer> OdWpCbSuicideFarmers { get; set; }

    public virtual DbSet<OdWpCbSupplementaryProforma> OdWpCbSupplementaryProformas { get; set; }

    public virtual DbSet<OdWpCbSupplimentaryFUd> OdWpCbSupplimentaryFUds { get; set; }

    public virtual DbSet<OdWpCbSwindlingCase> OdWpCbSwindlingCases { get; set; }

    public virtual DbSet<OdWpCbTempleBurglary> OdWpCbTempleBurglaries { get; set; }

    public virtual DbSet<OdWpCbTempleTheft> OdWpCbTempleThefts { get; set; }

    public virtual DbSet<OdWpCbTheftCase> OdWpCbTheftCases { get; set; }

    public virtual DbSet<OdWpCbTotalCog> OdWpCbTotalCogs { get; set; }

    public virtual DbSet<OdWpCbTotalCogUnderIpc> OdWpCbTotalCogUnderIpcs { get; set; }

    public virtual DbSet<OdWpCbTotalCogUnderSll> OdWpCbTotalCogUnderSlls { get; set; }

    public virtual DbSet<OdWpCbTotalCyberCrime> OdWpCbTotalCyberCrimes { get; set; }

    public virtual DbSet<OdWpCbTraffickingOfMenUs370> OdWpCbTraffickingOfMenUs370s { get; set; }

    public virtual DbSet<OdWpCbTraffickingOfMenUs370A> OdWpCbTraffickingOfMenUs370As { get; set; }

    public virtual DbSet<OdWpCbTraffickingOfWomenUs370> OdWpCbTraffickingOfWomenUs370s { get; set; }

    public virtual DbSet<OdWpCbTraffickingOfWomenUs370A> OdWpCbTraffickingOfWomenUs370As { get; set; }

    public virtual DbSet<OdWpCbUapaAct> OdWpCbUapaActs { get; set; }

    public virtual DbSet<OdWpCbUdCase> OdWpCbUdCases { get; set; }

    public virtual DbSet<OdWpCbUdPendingYrwise> OdWpCbUdPendingYrwises { get; set; }

    public virtual DbSet<OdWpCbUiCase> OdWpCbUiCases { get; set; }

    public virtual DbSet<OdWpCbUnNaturalOffencesUS377Ipc> OdWpCbUnNaturalOffencesUS377Ipcs { get; set; }

    public virtual DbSet<OdWpCbUnderNsaPartI> OdWpCbUnderNsaPartIs { get; set; }

    public virtual DbSet<OdWpCbViolationOfNationalFood> OdWpCbViolationOfNationalFoods { get; set; }

    public virtual DbSet<OdWpCbVoyeurismUs354C> OdWpCbVoyeurismUs354Cs { get; set; }

    public virtual DbSet<OdWpCbWildLifeProAct> OdWpCbWildLifeProActs { get; set; }

    public virtual DbSet<OdWpHrpcCrimeAgnstScArson> OdWpHrpcCrimeAgnstScArsons { get; set; }

    public virtual DbSet<OdWpHrpcCrimeAgnstScMurder> OdWpHrpcCrimeAgnstScMurders { get; set; }

    public virtual DbSet<OdWpHrpcCrimeAgnstScOther> OdWpHrpcCrimeAgnstScOthers { get; set; }

    public virtual DbSet<OdWpHrpcCrimeAgnstScRape> OdWpHrpcCrimeAgnstScRapes { get; set; }

    public virtual DbSet<OdWpHrpcCrimeAgnstScViolence> OdWpHrpcCrimeAgnstScViolences { get; set; }

    public virtual DbSet<OdWpHrpcCrimeAgnstStArson> OdWpHrpcCrimeAgnstStArsons { get; set; }

    public virtual DbSet<OdWpHrpcCrimeAgnstStMurder> OdWpHrpcCrimeAgnstStMurders { get; set; }

    public virtual DbSet<OdWpHrpcCrimeAgnstStOther> OdWpHrpcCrimeAgnstStOthers { get; set; }

    public virtual DbSet<OdWpHrpcCrimeAgnstStRape> OdWpHrpcCrimeAgnstStRapes { get; set; }

    public virtual DbSet<OdWpHrpcCrimeAgnstStScArson> OdWpHrpcCrimeAgnstStScArsons { get; set; }

    public virtual DbSet<OdWpHrpcCrimeAgnstStScMurder> OdWpHrpcCrimeAgnstStScMurders { get; set; }

    public virtual DbSet<OdWpHrpcCrimeAgnstStScOther> OdWpHrpcCrimeAgnstStScOthers { get; set; }

    public virtual DbSet<OdWpHrpcCrimeAgnstStScRape> OdWpHrpcCrimeAgnstStScRapes { get; set; }

    public virtual DbSet<OdWpHrpcCrimeAgnstStScViolence> OdWpHrpcCrimeAgnstStScViolences { get; set; }

    public virtual DbSet<OdWpHrpcCrimeAgnstStViolence> OdWpHrpcCrimeAgnstStViolences { get; set; }

    public virtual DbSet<OdWpHrpcCrimePcrAct> OdWpHrpcCrimePcrActs { get; set; }

    public virtual DbSet<OodWpCbDacoityWithMurder> OodWpCbDacoityWithMurders { get; set; }

    public virtual DbSet<RapeCommByRel> RapeCommByRels { get; set; }

    public virtual DbSet<TCbWpCategory> TCbWpCategories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { 
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=10.200.1.58;Database=White_Paper;User Id=sa;Password=cctns@123; TrustServerCertificate=True;\n");
    
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MCbWpCategory>(entity =>
        {
            entity.HasKey(e => e.CatId).HasName("PK__M_CB_WP___5F8323A8A21F3253");

            entity.Property(e => e.RecordStatus)
                .HasDefaultValue("C")
                .IsFixedLength();
        });

        modelBuilder.Entity<MCbWpMainCategory>(entity =>
        {
            entity.HasKey(e => e.MainCatId).HasName("PK__M_CB_WP___655A139F79094D59");

            entity.Property(e => e.RecordStatus).IsFixedLength();
        });

        modelBuilder.Entity<MCbWpSubCategory>(entity =>
        {
            entity.HasKey(e => new { e.SubCatCd, e.LangCd }).HasName("PK__M_CB_WP___317F1E44B2FF682E");

            entity.Property(e => e.RecordStatus)
                .HasDefaultValue("C")
                .IsFixedLength();
        });

        modelBuilder.Entity<OdWpCb34APoliceAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbAbductionOfMenIncMChild>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbAbductionOfWomenIncFChild>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbAbductionOfWomenIncFeChild>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbAbetmentSuicideIpc306>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbAbetmentToCommitSuicideIpc306>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbAcidAttackOnMenUs326A>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbAcidAttackOnMenUs326B>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbAcidAttackOnWomenUs326A>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbAcidAttackOnWomenUs326B>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbAffary>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbAgeGrpFJd>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbArmsAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbArmsActIpc>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbArmsActSeizure>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbArmsActWithoutIpc>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbArmsWithoutIpcAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbArson>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbArtSeizedInECAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbArtSeizedInECActWithoutIpc>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbArtSeizedInExcise>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbArtSeizedInExciseWoIpc>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbArtSeizedInGambling>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbArtSeizedInGamblingWoIpc>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbArtSeizedOfExtortionCase>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbArtSeizedOfNdpsAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbArtSeizedOfNdpsActWoIpc>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbArticleSeizedEcArtIpc>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbAssultToPolice>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbAtmLoot>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbAttemptCommitRape>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbAttemptMurder>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbAttemptPreToCommitDacoity>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbAttemptPreToCommitDacoityCase>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbAttemptToCommitSuicide>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbAutoBurglary>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbAutoBurglary2>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbAutoBurglary3>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbAutoBurglary4>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbAutoBurglaryAboveFourWheeler>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbAutoBurglaryTotal>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbAutoTheft>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbAutoTheft2w>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbAutoTheft3w>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbAutoTheft4w>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbAutoTheftAboveFourWheeler>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbAutoTheftTotal>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbBankDacoity>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbBankDacoityBankCash>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbBankFraudCase>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbBankRobbery>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbBankRobberyBankCash>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbBondedLabour>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbBurglaryCase>(entity =>
        {
            entity.HasKey(e => e.SlNo).HasName("PK__OD_WP_CB__214121FCC7A54D49");

            entity.Property(e => e.ConvictionCs).HasDefaultValue(0);
            entity.Property(e => e.RecordStatus).IsFixedLength();
        });

        modelBuilder.Entity<OdWpCbBwTotalCase>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbCasesAgainstJd>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbCasesAttackDoctor>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbCasesBettingCricMatch>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbCasesFAttackJournalistMedium>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbCasesOfAttackOnDoctor>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbCasesSupervisedGo>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbCasesSurervisByGov>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbChildMarriageAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbChildProstitution>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbCogPendingYrwise>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbCollectionChandum>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbComplaintAPolice>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbContactKilling>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbCounterfeitCurrency>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbCriminalAGovtSer>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbCriminalBreachOfTrust>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbCriminalIntimidation>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbCulturalPropertyTheft>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbCyberCrimeOtherF>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbCyberCrimeRelFinancialF>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbCyberCrimeRelHackingF>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbCyberCrimeRelSocialMediaF>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDacoityCase>(entity =>
        {
            entity.HasKey(e => e.SlNo).HasName("PK__OD_WP_CB__214121FC9EC29C86");

            entity.Property(e => e.ConvictionCs).HasDefaultValue(0);
            entity.Property(e => e.RecordStatus).IsFixedLength();
        });

        modelBuilder.Entity<OdWpCbDacoityWithMurder>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDeathInPoliceCustody>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisSessionTCase>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDispoPendingCriminalCase>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcAdulterationSaleFood>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcAffray>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcAgainstState>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcArson>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcAssaultWoman>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcAtmptHomicide>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcAtmptSuicide>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcAttemptDacoity>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcAttemptMurder>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcAttemptRape>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcAttemptSuicide>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcBreachTrust>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcBurglary>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcBuyingMinor>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcCheatingImprsnmnt>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcCirculateFakeNews>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcCommittingDacoity>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcCounterfieting>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcCriminalIntimidation>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcCriminalIntmdtn>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcCrmnlMisaprtn>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcCrueltyByHusbnd>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcDacoity>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcDeathNeglgnce>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcDishonestlyStlngProp>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcDisobdncPublcServant>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcDowryDeath>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcExploitation>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcExtortion>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcFurgery>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcHarbouring>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcHomicide>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcHumanTrafficking>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcHurt>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcInsultWoman>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcKidnapping>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcMiscarriage>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcMischief>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcMurder>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcObsenceSong>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcObstructionPblcWay>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcOtheripcCrime>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcPrmotingEnmity>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcRape>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcRashDriving>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcRelatingMischief>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcRelatingReligion>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcRelatngElection>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcReligion>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcRiot>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcRobbery>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcSaleObsceneBook>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcSellingMinor>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcTheft>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcTotalIpcCrime>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcTotalSllCrime>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcTreespass>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcUnlawflAssembly>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcUnnatural>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalIpcWrngflRestraint>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllAirWaterPrevntn>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllAntiqueArtTresureAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllArmsAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllBenamiTran>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllBondedLabourAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllCenematographAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllChildLabour>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllChildMarriageAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllChitFund>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllCigaretteTobacco>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllCitizenship>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllCivilRightsAgnstSc>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllCivilRightsAgnstSt>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllCopyrightAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllCorruptionAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllCrime>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllDamagePublicProp>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllDefacementPublicProp>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllDowry>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllEcAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllElectricityAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllEmigration>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllEnvironmentalProtection>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllExcise>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllExplosiveSubstance>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllExplosivesAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllFoodAdulterationAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllFoodSafetyAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllForeignersAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllForestAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllGamblingAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllImmoralDomesticViolence>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllImmoralTrafficking>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllIndecentReprsntnWoman>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllInsultNationalHonour>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllItAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllJjAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllLocalAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllMedicalTerminationPregnency>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllMinesMineral>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllMvAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllNdp>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllNiosePollution>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllOfficialSecret>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllPassport>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllPeopleAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllPocso>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllPreNatal>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllRailwayAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllRailwayPropAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllStscAgnstSc>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllStscAgnstSt>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllTelegraphAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllTelegraphWireAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllTelevisionAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllTownPoliceAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllTransgender>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllTransplantationHumanOrgan>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllUnlawfulActivity>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDisposalSllWildlifeProtection>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDowryHomicide>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDowryProhibitionAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDowrySuicide>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDowryTorture>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbDrugging>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbECActIpc>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbECActWithoutIpc>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbEnergyTheft>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbEscapePolCustody>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbEssentialCommoAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbEssentialCommoActWithoutIpc>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbEveTeasing>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbExciseAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbExciseActWoIpc>(entity =>
        {
            entity.Property(e => e.CompoundedFr).HasDefaultValue(0);
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbExciseIpc>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbExciseWoIpc>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbExplosiveAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbExplosiveActIpc>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbExplosiveActSeizureWithoutIpc>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbExplosiveActWithoutIpc>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbExplosiveSubstance>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbExplosiveSubstanceAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbExplosiveSubstanceActSeizure>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbExplosiveSubstanceActWtoIpc>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbExplosiveSubstanceWithoutIpc>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbExtortion>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbGamblingAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbGamblingActWoIpc>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbGamblingActWtoIpc>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbGamblingDenseRaided>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbGamblingIpc>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbGamblingWoIpc>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbGangRapeCases376DbIpcBelow12y>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbGrCase>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbHarashmentSeniorCitizen>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbHomicideMurderIpc304>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbHonourKilling>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbHumanOrganTransplant>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbHumanSacrifice>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbHumanTrafficking>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbIdolTheft>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbIllegalPosseOfArm>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbIllegalPosseOfArmsWoIpcBn>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbIncFWomenProhiAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbIpcExplosiveSubstanceAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbIpcWrngflRestraint>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbItpAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbJuvenileJusticeAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbKiddnapAbductOfMan>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbKiddnapAbductOfMf>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbKiddnapAbductOfTotal>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbKiddnapAbductOfWoman>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbKiddnapOfWomenIncFeChild>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbKidnappingChildrenBegging>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbKidnappingOfMenIncMChild>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbKidnappingOfWomenIncFChild>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbKidnappingRansom>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbLiquoreDenseRaided>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbLokAdalatCase>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbMinesMineralsMmdrAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbMiscellaneousCase>(entity =>
        {
            entity.Property(e => e.CompFrDrop).HasDefaultValue(0);
            entity.Property(e => e.CsComp).HasDefaultValue(0);
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbMobLynching>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbMolestationUs354>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbMurderCase>(entity =>
        {
            entity.Property(e => e.ConvictionCs).HasDefaultValue(0);
            entity.Property(e => e.KilledTg).HasDefaultValue(0);
            entity.Property(e => e.RecordStatus).IsFixedLength();
        });

        modelBuilder.Entity<OdWpCbMurderOfMinorGirlWithRape>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbMurderOfWoman>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbMurderOfWomenWithRape>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbMvAccidentCase>(entity =>
        {
            entity.Property(e => e.Csconvicted).HasDefaultValue(0);
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbNbwTotalCase>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbNdpsAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbNdpsIpc>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbNdpsWoIpc>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbNdpsWoIpcAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbNightArrest>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbNonDowryTorture>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbNonFir>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbOdPrevenFCowLaughterAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbOdPrevenFWitchAct201>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbOffenceComBail>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbOffenceComParole>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbOffenceCommGr>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbOffenceCommHg>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbOffenceCommPolice>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbOmlrAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbOmlrScheduledArea>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbOmptAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbOtherIpcOffencesCommitedAgainstWoman>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbOtherIpcOffencesCommitedByWoman>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbPcrActProCivilRt>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbPendingSupNote>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbPocsoAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbPocsoActTotal>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbPocsoCasesMinorBoy>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbPocsoCasesMinorGirl>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbPocsoCasesTg>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbPocsoCasesTotalMinorBoy>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbPocsoCasesTotalMinorGirl>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbPocsoCasesTotalTransgender>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbPoliceEncounterCasesPartI>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbPrUS107Crpc>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbPrUS109110Crpc>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbPrUS144Crpc>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbPrUS145146Crpc>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbPreventCrueltyAnimalAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbPreventOfCrueltyAnimalAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbPsWiseCogCase>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbPsWiseConviction>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbPublicDistorOfWomenUs354B>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbRagging>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbRankWisePendingCogCase>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbRapeAttemptToCommit>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbRapeByRelation>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbRapeCase>(entity =>
        {
            entity.Property(e => e.Csconvicted).HasDefaultValue(0);
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbRapeCases3761>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbRapeCases3762>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbRapeCases3763>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbRapeCases376A>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbRapeCases376Ab>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbRapeCases376AbIpcBelow12y>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbRapeCases376B>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbRapeCases376C>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbRapeCases376D>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbRapeCases376DAbove16y>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbRapeCases376DaIpcBelow16y>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbRapeCases376Db>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbRapeCases376Dum>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbRapeCases376E>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbRapeCasesMinor>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbRapeCasesMinorBelow18>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbRapeCasesScStViction>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbRapeCasesScStViction1>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbRapeInsideRunningVehicle>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbReasonsHumanTrafficking>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbRefusalMarryAfterSex>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbRelatingFinancialFraud2023>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbRiotingCase>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbRobberyCase>(entity =>
        {
            entity.HasKey(e => e.SlNo).HasName("PK__OD_WP_CB__214121FC327DBE2F");

            entity.Property(e => e.ConvictionCs).HasDefaultValue(0);
            entity.Property(e => e.RecordStatus).IsFixedLength();
        });

        modelBuilder.Entity<OdWpCbRptTheft>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbScStPoaActForSc>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbScStPoaActForSt>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbSeizedEcArtIpc>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbSeizedVehiclesLyingAtP>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbSeizureExtoCase>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbSexHarashsmentWorkplaceWoman>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbSexualHarassmentUs354A>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbSnatching>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbSocialBoycott>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbStalkingUs354D>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbSuicideFarmer>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbSupplementaryProforma>(entity =>
        {
            entity.HasKey(e => e.SlNo).HasName("PK__T_CB_WP___214121FC740C9123");

            entity.Property(e => e.RecordStatus).IsFixedLength();
        });

        modelBuilder.Entity<OdWpCbSupplimentaryFUd>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbSwindlingCase>(entity =>
        {
            entity.Property(e => e.ConvictionCs).HasDefaultValue(0);
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbTempleBurglary>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbTempleTheft>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbTheftCase>(entity =>
        {
            entity.HasKey(e => e.SlNo).HasName("PK__OD_WP_CB__214121FC696B37DE");

            entity.Property(e => e.ConvictionCs).HasDefaultValue(0);
            entity.Property(e => e.RecordStatus).IsFixedLength();
        });

        modelBuilder.Entity<OdWpCbTotalCog>(entity =>
        {
            entity.HasKey(e => e.SlNo).HasName("PK__T_CB_WP___214121FC39C08222");

            entity.Property(e => e.RecordStatus).IsFixedLength();
        });

        modelBuilder.Entity<OdWpCbTotalCogUnderIpc>(entity =>
        {
            entity.HasKey(e => e.SlNo).HasName("PK__OD_WP_CB__214121FC1AD7F64E");

            entity.Property(e => e.RecordStatus).IsFixedLength();
        });

        modelBuilder.Entity<OdWpCbTotalCogUnderSll>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
        });

        modelBuilder.Entity<OdWpCbTotalCyberCrime>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbTraffickingOfMenUs370>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbTraffickingOfMenUs370A>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbTraffickingOfWomenUs370>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbTraffickingOfWomenUs370A>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbUapaAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbUdCase>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbUdPendingYrwise>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbUiCase>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbUnNaturalOffencesUS377Ipc>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbUnderNsaPartI>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbViolationOfNationalFood>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbVoyeurismUs354C>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpCbWildLifeProAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
        });

        modelBuilder.Entity<OdWpHrpcCrimeAgnstScArson>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpHrpcCrimeAgnstScMurder>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpHrpcCrimeAgnstScOther>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpHrpcCrimeAgnstScRape>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpHrpcCrimeAgnstScViolence>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpHrpcCrimeAgnstStArson>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpHrpcCrimeAgnstStMurder>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpHrpcCrimeAgnstStOther>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpHrpcCrimeAgnstStRape>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpHrpcCrimeAgnstStScArson>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpHrpcCrimeAgnstStScMurder>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpHrpcCrimeAgnstStScOther>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpHrpcCrimeAgnstStScRape>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpHrpcCrimeAgnstStScViolence>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpHrpcCrimeAgnstStViolence>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OdWpHrpcCrimePcrAct>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<OodWpCbDacoityWithMurder>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RapeCommByRel>(entity =>
        {
            entity.Property(e => e.RecordStatus).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TCbWpCategory>(entity =>
        {
            entity.HasKey(e => e.CatTransId).HasName("PK__T_CB_WP___59CF5BFAA500C4B9");

            entity.Property(e => e.RecordStatus)
                .HasDefaultValue("C")
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
