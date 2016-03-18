using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using CA.Immigration.Data;
using CA.Immigration;
using CA.Immigration.Utility;

namespace CA.Immigration.LMIA
{
    public class LMIAJobOffer
    {
        private static int? _numOfTFWs;
        private static int? _duration;
        private static string _durationUnit;
        private static string _durationRationale;
        private static DateTime _startDate;
        private static bool _readingEnglishFrenchRequied;
        private static bool _readingEnglishRequired;
        private static bool _readingFrenchRequired;
        private static bool _readingEnglishOrFrenchRequired;
        private static bool _readingEnglishAndFrenchRequired;
        private static bool _writingEnglishFrenchRequired;
        private static bool _writingEnglishRequired;
        private static bool _writingFrenchRequired;
        private static bool _writingEnglishOrFrenchRequired;
        private static bool _writingEnglishAndFrenchRequired;
        private static bool _otherLanguageRequired;
        private static string _otherLanguageExplanation;
        private static int? _vacationDays;
        private static int? _remuneration;
        private static bool _isSeasonal;
        private static bool _isFullyCoveredLMIA;
        private static string _notFullyCoveredReason;
        private static bool _isJobLicensed;
        private static string _licenseAuthority;
        private static bool _licenseReady;
        private static int? _licenseReadyTime;
        private static string _licenseReadyUnit;
        private static bool _isJobUnion;
        private static string _unionNameLocation;
        private static bool _isUnionConsulted;
        private static string _unionNotExplanation;
        private static string _unionOpinion;
        private static bool _attemptedRecruitCanadian;
        private static string _notAttemptedReason;
        private static string _OfficialAdNumber;
        private static string _briefBenefit;
        private static string _detailedBenefit;
        private static string _briefRationaleOfferingJob;
        private static string _detailedRationaleOfferingJob;
        private static bool _trainCanadian;
        private static string _noTrainReason;
        private static string _trainPlanBrief;
        private static string _trainPlanDetails;
        private static bool _willProvideAccomadation;
        private static string _notProvideButOffer;
        private static int? _provideRent;
        private static string _provideUnit;
        private static bool _accomadationNotApplicalbe;
        private static string _whoIsFillingBrief;
        private static string _whoIsFillingDetail;
        private static string _howDidYouFindBrief;
        private static string _howDidYouFindDetail;
        private static string _howDidYouDetermineBrief;
        private static string _howDidYouDetermineDetail;
        private static string _howAndWhenOfferBrief;
        private static string _howAndWhenOfferDetail;

        public static void getInput(LMIAForm lf) {
            _numOfTFWs = getValue.getIntValue(lf.txtJobOfferNumberofTFW.Text);
            _duration =  getValue.getIntValue(lf.txtJobOfferduration.tex);
            _durationUnit = lf.cmbDurationUnit.SelectedText;
            _durationRationale = lf.txtJobOfferDurationRationale.Text;
            _startDate = lf.dtpJobOfferStartDate.Value;
            _readingEnglishFrenchRequied =  ;
            _readingEnglishRequired =  ;
            _readingFrenchRequired =  ;
            _readingEnglishOrFrenchRequired =  ;
            _readingEnglishAndFrenchRequired =  ;
            _writingEnglishFrenchRequired =  ;
            _writingEnglishRequired =  ;
            _writingFrenchRequired =  ;
            _writingEnglishOrFrenchRequired =  ;
            _writingEnglishAndFrenchRequired =  ;
            _otherLanguageRequired =  ;
            _otherLanguageExplanation =  ;
            _vacationDays =  ;
            _remuneration =  ;
            _isSeasonal =  ;
            _isFullyCoveredLMIA =  ;
            _notFullyCoveredReason =  ;
            _isJobLicensed =  ;
            _licenseAuthority =  ;
            _licenseReady =  ;
            _licenseReadyTime =  ;
            _licenseReadyUnit =  ;
            _isJobUnion =  ;
            _unionNameLocation =  ;
            _isUnionConsulted =  ;
            _unionNotExplanation =  ;
            _unionOpinion =  ;
            _attemptedRecruitCanadian =  ;
            _notAttemptedReason =  ;
            _OfficialAdNumber =  ;
            _briefBenefit =  ;
            _detailedBenefit =  ;
            _briefRationaleOfferingJob =  ;
            _detailedRationaleOfferingJob =  ;
            _trainCanadian =  ;
            _noTrainReason =  ;
            _trainPlanBrief =  ;
            _trainPlanDetails =  ;
            _willProvideAccomadation =  ;
            _notProvideButOffer =  ;
            _provideRent =  ;
            _provideUnit =  ;
            _accomadationNotApplicalbe =  ;
            _whoIsFillingBrief =  ;
            _whoIsFillingDetail =  ;
            _howDidYouFindBrief =  ;
            _howDidYouFindDetail =  ;
            _howDidYouDetermineBrief =  ;
            _howDidYouDetermineDetail =  ;
            _howAndWhenOfferBrief =  ;
            _howAndWhenOfferDetail =  ;

        }
        public static void loadFromDB(LMIAForm lf) {
            if (GlobalData.CurrentApplicationId != null) {
                using (CommonDataContext cdc = new CommonDataContext()) {

                    tblJobOffer jo = cdc.tblJobOffers.Where(x => x.applicationID == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                    if (jo!=null)
                    {
                        _numOfTFWs = jo.numOfTFWs;
                        _duration = jo.duration;
                        _durationUnit = jo.durationUnit;
                        _durationRationale = jo.durationRationale;
                        _startDate = jo.startDate!=null?(DateTime)jo.startDate:DateTime.Today;
                        _readingEnglishFrenchRequied = jo.readingEnglishFrenchRequied==true? true :false;
                        _readingEnglishRequired = jo.readingEnglishRequired == true ? true : false;
                        _readingFrenchRequired = jo.readingFrenchRequired == true ? true : false;
                        _readingEnglishOrFrenchRequired = jo.readingEnglishOrFrenchRequired == true ? true : false;
                        _readingEnglishAndFrenchRequired = jo.readingEnglishAndFrenchRequired == true ? true : false;
                        _writingEnglishFrenchRequired = jo.writingEnglishFrenchRequired == true ? true : false;
                        _writingEnglishRequired = jo.writingEnglishRequired == true ? true : false;
                        _writingFrenchRequired = jo.writingFrenchRequired == true ? true : false;
                        _writingEnglishOrFrenchRequired = jo.writingEnglishOrFrenchRequired == true ? true : false;
                        _writingEnglishAndFrenchRequired = jo.writingEnglishAndFrenchRequired == true ? true : false;
                        _otherLanguageRequired = jo.otherLanguageRequired == true ? true : false;
                        _otherLanguageExplanation = jo.otherLanguageExplanation;
                        _vacationDays = jo.vacationDays;
                        _remuneration = jo.remuneration;
                        _isSeasonal = jo.isSeasonal == true ? true : false;
                        _isFullyCoveredLMIA = jo.isFullyCoveredLMIA == true ? true : false;
                        _notFullyCoveredReason = jo.notFullyCoveredReason;
                        _isJobLicensed = jo.isJobLicensed == true ? true : false;
                        _licenseAuthority = jo.licenseAuthority;
                        _licenseReady = jo.licenseReady == true ? true : false;
                        _licenseReadyTime = jo.licenseReadyTime;
                        _licenseReadyUnit = jo.licenseReadyUnit;
                        _isJobUnion = jo.isJobUnion == true ? true : false;
                        _unionNameLocation = jo.unionNameLocation;
                        _isUnionConsulted = jo.isUnionConsulted == true ? true : false;
                        _unionNotExplanation = jo.unionNotExplanation;
                        _unionOpinion = jo.unionOpinion;
                        _attemptedRecruitCanadian = jo.attemptedRecruitCanadian == true ? true : false;
                        _notAttemptedReason = jo.notAttemptedReason;
                        _OfficialAdNumber = jo.OfficialAdNumber;
                        _briefBenefit = jo.briefBenefit;
                        _detailedBenefit = jo.detailedBenefit;
                        _briefRationaleOfferingJob = jo.briefRationaleOfferingJob;
                        _detailedRationaleOfferingJob = jo.detailedRationaleOfferingJob;
                        _trainCanadian = jo.trainCanadian == true ? true : false;
                        _noTrainReason = jo.noTrainReason;
                        _trainPlanBrief = jo.trainPlanBrief;
                        _trainPlanDetails = jo.trainPlanDetails;
                        _willProvideAccomadation = jo.willProvideAccomadation == true ? true : false;
                        _notProvideButOffer = jo.notProvideButOffer;
                        _provideRent = jo.provideRent;
                        _provideUnit = jo.provideUnit;
                        _accomadationNotApplicalbe = jo.accomadationNotApplicalbe == true ? true : false;
                        _whoIsFillingBrief = jo.whoIsFillingBrief;
                        _whoIsFillingDetail = jo.whoIsFillingDetail;
                        _howDidYouFindBrief = jo.howDidYouFindBrief;
                        _howDidYouFindDetail = jo.howDidYouFindDetail;
                        _howDidYouDetermineBrief = jo.howDidYouDetermineBrief;
                        _howDidYouDetermineDetail = jo.howDidYouDetermineDetail;
                        _howAndWhenOfferBrief = jo.howAndWhenOfferBrief;
                        _howAndWhenOfferDetail = jo.howAndWhenOfferDetail;
                    }  else MessageBox.Show("There is no record of job offer in this application!");
                }  // end of using

            }else MessageBox.Show("There is no active application existing!");
        }
        public static void fillForm(LMIAForm lf ) { }
        public static void clearForm(LMIAForm lf) { }
        public static void insert2DB(LMIAForm lf) { }
        public static void deleteRecord(LMIAForm lf) { }
        public static void updateRecord(LMIAForm lf) { }
        public static void buildupDict5602(ref Dictionary<string,string> dict) { }
    }
}
