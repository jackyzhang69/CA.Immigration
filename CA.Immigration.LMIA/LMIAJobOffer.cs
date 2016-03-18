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
        private static DateTime _startDate=DateTime.Today;
        private static bool _languageRequired;
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
        public  static string _detailedBenefit;
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

        public static void getInput(LMIAForm lf)
        {
            _numOfTFWs = getValue.getIntValue(lf.txtJobOfferNumberofTFW.Text);
            _duration = getValue.getIntValue(lf.txtJobOfferExpectedDuration.Text);
            _durationUnit = lf.cmbDurationUnit.SelectedText;
            _durationRationale = lf.txtJobOfferDurationRationale.Text;
            _startDate = lf.dtpJobOfferStartDate.Value;
            _languageRequired = lf.chkLanguageRequired.Checked == true ? true : false;
            _readingEnglishFrenchRequied = lf.chkLIMAOralEnglish.Checked == true ? true : false;
            _readingEnglishRequired = lf.chkLMIAoralEnglish.Checked == true ? true : false;
            _readingFrenchRequired = lf.chkLMIAOralFrench.Checked == true ? true : false;
            _readingEnglishOrFrenchRequired = lf.chkLMIAoralEnglish.Checked == true ? true : false;
            _readingEnglishAndFrenchRequired = lf.chkLMIAOralEnglisAndFrench.Checked == true ? true : false;

            _writingEnglishFrenchRequired = lf.chkLMIAWritingEnglish.Checked == true ? true : false;
            _writingEnglishRequired = lf.chkLMIAWritingFrench.Checked == true ? true : false;
            _writingFrenchRequired = lf.chkLMIAWritingFrench.Checked == true ? true : false;
            _writingEnglishOrFrenchRequired = lf.chkLMIAWritingEnglisOrFrench.Checked == true ? true : false;
            _writingEnglishAndFrenchRequired = lf.chkLMIAWritingEnglisAndFrench.Checked == true ? true : false;

            _otherLanguageRequired = lf.chkLMIAOtherLanguage.Checked == true ? true : false;
            _otherLanguageExplanation = lf.txtLMIAOtherLanguage.Text;
            if(lf.rdbJobOfferVacationDays.Checked) _vacationDays = getValue.getIntValue(lf.txtJobOfferVacationDays.Text);
            else _vacationDays = null;
            if(lf.rdbJobOfferRemuneration.Checked) _remuneration = getValue.getIntValue(lf.txtJobOfferRemuneraton.Text);
            else _remuneration = null;
            _isSeasonal = lf.chkJobOfferSeasonal.Checked == true ? true : false;
            _isFullyCoveredLMIA = lf.chkJobOfferFullDuration.Checked == true ? true : false;
            _notFullyCoveredReason = lf.txtJobOfferRemuneration.Text;
            _isJobLicensed = lf.chkJobOfferLicenseNeeded.Checked == true ? true : false;
            _licenseAuthority = lf.txtJobOfferLicenseAuthority.Text;
            _licenseReady = lf.chkJobOfferLicenseReady.Checked == true ? true : false;
            _licenseReadyTime = getValue.getIntValue(lf.txtJobOfferHowlongLicense.Text);
            _licenseReadyUnit = lf.cmbJobOfferDWM.Text;
            _isJobUnion = lf.chkJobOfferIsUnion.Checked == true ? true : false;
            _unionNameLocation = lf.txtJobOfferUnionName.Text;
            _isUnionConsulted = lf.chkJobOfferUnionConsulted.Checked == true ? true : false;
            if(_isUnionConsulted == false) _unionNotExplanation = lf.txtJobOfferUnionExpOrOpinion.Text;
            if(_isUnionConsulted == true) _unionOpinion = lf.txtJobOfferUnionExpOrOpinion.Text;
            _attemptedRecruitCanadian = lf.chkJobOfferRecruitCanadian.Checked == true ? true : false;
            if(_attemptedRecruitCanadian == false) _notAttemptedReason = lf.txtJobOfferRecruitCanadian.Text;
            if(_attemptedRecruitCanadian == true) _OfficialAdNumber = lf.txtJobOfferRecruitCanadian.Text;
            _briefBenefit = lf.txtJobOfferBenefitBrief.Text;
            // _detailedBenefit =  ;
            _briefRationaleOfferingJob = lf.txtJobOfferOfferRationale.Text;
            //_detailedRationaleOfferingJob =  ;
            _trainCanadian = lf.chkJobOfferTrainCanadian.Checked == true ? true : false;
            if(_trainCanadian == false) _noTrainReason = lf.txtJobOfferTrainCanadian.Text;
            if(_trainCanadian == true) _trainPlanBrief = lf.txtJobOfferTrainCanadian.Text;
            //_trainPlanDetails =  ;
            _willProvideAccomadation = lf.chkJobOfferProvideAccomadation.Checked = true ? true : false;
            if(_willProvideAccomadation == false) _notProvideButOffer = lf.txtJobOfferProvideAssistant.Text;
            _provideRent = getValue.getIntValue(lf.txtJobOfferProvideRent.Text);
            _provideUnit = lf.cmbJobOfferProvideRent.SelectedText;
            _accomadationNotApplicalbe = lf.chkJobOfferProvideRentNA.Checked == true ? true : false;
            if(lf.lblJobOfferWhoCurrentInThePosition.Visible == true)
            {  //Below are EMP5593 Questions
                _whoIsFillingBrief = lf.txtJobOfferWhoFillInThisJob.Text;
                // _whoIsFillingDetail =  ; 
            }
            if(lf.lblJobOfferHowDidYouFind.Visible == true)
            {
                _howDidYouFindBrief = lf.txtJobOfferHowDidYouFind.Text;
                //_howDidYouFindDetail =  ;
            }
            if(lf.lblJobOfferHowtoQualify.Visible == true)
            {
                _howDidYouDetermineBrief = lf.txtJobOfferHowtoDetermine.Text;
                //_howDidYouDetermineDetail =  ;
            }
            if(lf.lblJobOfferWhentoOffer.Visible == true)
            {
                _howAndWhenOfferBrief = lf.txtJobOfferWhentoOffer.Text;
                //_howAndWhenOfferDetail =  ;
            }

        }
        public static void loadFromDB(LMIAForm lf)
        {
            if(GlobalData.CurrentApplicationId != null)
            {
                using(CommonDataContext cdc = new CommonDataContext())
                {

                    tblJobOffer jo = cdc.tblJobOffers.Where(x => x.applicationID == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                    if(jo != null)
                    {
                        _numOfTFWs = jo.numOfTFWs;
                        _duration = jo.duration;
                        _durationUnit = jo.durationUnit;
                        _durationRationale = jo.durationRationale;
                        _startDate = jo.startDate != null ? (DateTime)jo.startDate : DateTime.Today;
                        _languageRequired = jo.languageRequired == true ? true : false;
                        _readingEnglishFrenchRequied = jo.readingEnglishFrenchRequied == true ? true : false;
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
                    }
                    else MessageBox.Show("There is no record of job offer in this application!");
                }  // end of using

            }
            else MessageBox.Show("There is no active application existing!");
        }
        public static void fillForm(LMIAForm lf)
        {
            lf.txtJobOfferNumberofTFW.Text = _numOfTFWs.ToString();
            lf.txtJobOfferExpectedDuration.Text = _duration.ToString();
            lf.cmbDurationUnit.SelectedText = _durationUnit;
            lf.txtJobOfferDurationRationale.Text = _durationRationale;
            lf.dtpJobOfferStartDate.Value = _startDate;
            lf.chkLanguageRequired.Checked = _languageRequired;
            lf.chkLIMAOralEnglish.Checked = _readingEnglishFrenchRequied;
            lf.chkLMIAoralEnglish.Checked = _readingEnglishRequired;
            lf.chkLMIAOralFrench.Checked = _readingFrenchRequired;
            lf.chkLMIAoralEnglish.Checked = _readingEnglishOrFrenchRequired;
            lf.chkLMIAOralEnglisAndFrench.Checked = _readingEnglishAndFrenchRequired;

            lf.chkLMIAWritingEnglish.Checked = _writingEnglishFrenchRequired;
            lf.chkLMIAWritingFrench.Checked = _writingEnglishRequired;
            lf.chkLMIAWritingFrench.Checked = _writingFrenchRequired;
            lf.chkLMIAWritingEnglisOrFrench.Checked = _writingEnglishOrFrenchRequired;
            lf.chkLMIAWritingEnglisAndFrench.Checked = _writingEnglishAndFrenchRequired;

            lf.chkLMIAOtherLanguage.Checked = _otherLanguageRequired;
            lf.txtLMIAOtherLanguage.Text = _otherLanguageExplanation;
            if(_vacationDays != null)
            {
                lf.txtJobOfferVacationDays.Text = _vacationDays.ToString();
                lf.rdbJobOfferVacationDays.Checked = true;
            }
            else {
                lf.rdbJobOfferVacationDays.Checked = false;
                lf.txtJobOfferVacationDays.Text = null;
            }
            if(_remuneration != null)
            {
                lf.txtJobOfferRemuneraton.Text = _remuneration.ToString();
                lf.rdbJobOfferRemuneration.Checked = true;
            }
            else {
                lf.txtJobOfferRemuneraton.Text = null;
                lf.rdbJobOfferRemuneration.Checked = false;
            };
            lf.chkJobOfferSeasonal.Checked = _isSeasonal;
            lf.chkJobOfferFullDuration.Checked = _isFullyCoveredLMIA;
            lf.txtJobOfferRemuneration.Text = _notFullyCoveredReason;
            lf.chkJobOfferLicenseNeeded.Checked = _isJobLicensed;
            lf.txtJobOfferLicenseAuthority.Text = _licenseAuthority;
            lf.chkJobOfferLicenseReady.Checked = _licenseReady;
            lf.txtJobOfferHowlongLicense.Text = _licenseReadyTime.ToString();
            lf.cmbJobOfferDWM.Text = _licenseReadyUnit;
            lf.chkJobOfferIsUnion.Checked = _isJobUnion;
            lf.txtJobOfferUnionName.Text = _unionNameLocation;
            lf.chkJobOfferUnionConsulted.Checked = _isUnionConsulted;
            if(_isUnionConsulted == false) lf.txtJobOfferUnionExpOrOpinion.Text = _unionNotExplanation;
            if(_isUnionConsulted == true) lf.txtJobOfferUnionExpOrOpinion.Text = _unionOpinion;
            lf.chkJobOfferRecruitCanadian.Checked = _attemptedRecruitCanadian;
            if(_attemptedRecruitCanadian == false) lf.txtJobOfferRecruitCanadian.Text = _notAttemptedReason;
            if(_attemptedRecruitCanadian == true) lf.txtJobOfferRecruitCanadian.Text = _OfficialAdNumber;
            lf.txtJobOfferBenefitBrief.Text = _briefBenefit;
            // _detailedBenefit =  ;
            lf.txtJobOfferOfferRationale.Text = _briefRationaleOfferingJob;
            //_detailedRationaleOfferingJob =  ;
            lf.chkJobOfferTrainCanadian.Checked = _trainCanadian;
            if(_trainCanadian == false) lf.txtJobOfferTrainCanadian.Text = _noTrainReason;
            if(_trainCanadian == true) lf.txtJobOfferTrainCanadian.Text = _trainPlanBrief;
            //_trainPlanDetails =  ;
            lf.chkJobOfferProvideAccomadation.Checked = _willProvideAccomadation;
            if(_willProvideAccomadation == false) lf.txtJobOfferProvideAssistant.Text = _notProvideButOffer;
            lf.txtJobOfferProvideRent.Text = _provideRent.ToString();
            lf.cmbJobOfferProvideRent.SelectedText = _provideUnit;
            lf.chkJobOfferProvideRentNA.Checked = _accomadationNotApplicalbe;
            if(lf.lblJobOfferWhoCurrentInThePosition.Visible == true)
            {  //Below are EMP5593 Questions
                lf.txtJobOfferWhoFillInThisJob.Text = _whoIsFillingBrief;
                // _whoIsFillingDetail =  ; 
            }
            if(lf.lblJobOfferHowDidYouFind.Visible == true)
            {
                lf.txtJobOfferHowDidYouFind.Text = _howDidYouFindBrief;
                //_howDidYouFindDetail =  ;
            }
            if(lf.lblJobOfferHowtoQualify.Visible == true)
            {
                lf.txtJobOfferHowtoDetermine.Text = _howDidYouDetermineBrief;
                //_howDidYouDetermineDetail =  ;
            }
            if(lf.lblJobOfferWhentoOffer.Visible == true)
            {
                lf.txtJobOfferWhentoOffer.Text = _howAndWhenOfferBrief;
                //_howAndWhenOfferDetail =  ;
            }
        }
        public static void clearForm(LMIAForm lf)
        {
            lf.txtJobOfferNumberofTFW.Text = null;
            lf.txtJobOfferExpectedDuration.Text = null;
            lf.cmbDurationUnit.SelectedText = null;
            lf.txtJobOfferDurationRationale.Text = null;
            lf.dtpJobOfferStartDate.Value = DateTime.Today;
            lf.chkLanguageRequired.Checked = true;

            lf.chkLIMAOralEnglish.Checked = true;
            lf.chkLMIAoralEnglish.Checked = true;
            lf.chkLMIAOralFrench.Checked = false;
            lf.chkLMIAOralEnglisAndFrench.Checked = false;

            lf.chkLMIAWritingEnglish.Checked = true;
            lf.chkLMIAWritingFrench.Checked = false;
            lf.chkLMIAWritingEnglisOrFrench.Checked = false;
            lf.chkLMIAWritingEnglisAndFrench.Checked = false;

            lf.chkLMIAOtherLanguage.Checked = false;
            lf.txtLMIAOtherLanguage.Text = null;

            lf.txtJobOfferVacationDays.Text = null;
            lf.rdbJobOfferVacationDays.Checked = false;


            lf.txtJobOfferRemuneraton.Text = null;
            lf.rdbJobOfferRemuneration.Checked = false;

            lf.chkJobOfferSeasonal.Checked = false;
            lf.chkJobOfferFullDuration.Checked = true;
            lf.txtJobOfferRemuneration.Text = null;
            lf.chkJobOfferLicenseNeeded.Checked = false;
            lf.txtJobOfferLicenseAuthority.Text = null;
            lf.chkJobOfferLicenseReady.Checked = false;
            lf.txtJobOfferHowlongLicense.Text = null;
            lf.cmbJobOfferDWM.Text = null;
            lf.chkJobOfferIsUnion.Checked = false;
            lf.txtJobOfferUnionName.Text = null;
            lf.chkJobOfferUnionConsulted.Checked = false;
            lf.txtJobOfferUnionExpOrOpinion.Text = null;
            lf.chkJobOfferRecruitCanadian.Checked = true;
            lf.txtJobOfferRecruitCanadian.Text = null;
            lf.txtJobOfferBenefitBrief.Text = null;
            // _detailedBenefit =  ;
            lf.txtJobOfferOfferRationale.Text = null;
            //_detailedRationaleOfferingJob =  ;
            lf.chkJobOfferTrainCanadian.Checked = false;
            lf.txtJobOfferTrainCanadian.Text = null;
            //_trainPlanDetails =  ;
            lf.chkJobOfferProvideAccomadation.Checked = false;
            lf.txtJobOfferProvideAssistant.Text = null;
            lf.txtJobOfferProvideRent.Text = null;
            lf.cmbJobOfferProvideRent.SelectedText = null;
            lf.chkJobOfferProvideRentNA.Checked = false;
            lf.txtJobOfferWhoFillInThisJob.Text = null;
            // _whoIsFillingDetail =  ; 
            lf.txtJobOfferHowDidYouFind.Text = null;

            lf.txtJobOfferHowtoDetermine.Text = null;
            //_howDidYouDetermineDetail =  ;
            lf.txtJobOfferWhentoOffer.Text = null;
            //_howAndWhenOfferDetail =  ;
            getInput(lf);
            fillForm(lf);
        }
        public static void deleteRecord(LMIAForm lf)
        {
            if(MessageBox.Show("Do you really want to delete the job offer record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if(GlobalData.CurrentApplicationId != null)
                {
                    using(CommonDataContext cdc = new CommonDataContext())
                    {
                        tblJobOffer jo = cdc.tblJobOffers.Where(x => x.applicationID == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                        if(jo != null)
                        {
                            try
                            {
                                cdc.tblJobOffers.DeleteOnSubmit(jo);
                                cdc.SubmitChanges();
                                clearForm(lf);
                                MessageBox.Show("Record has been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch(Exception)
                            {

                                throw;
                            }
                        }
                        else { MessageBox.Show("There is no Job offer record to delete!"); }
                    }
                }
                else {
                    MessageBox.Show("There is no active application");
                }
            }
        }
        public static void SaveRecord(LMIAForm lf) {

            if(GlobalData.CurrentApplicationId != null)
            {
                using(CommonDataContext cdc = new CommonDataContext())
                {
                    tblJobOffer jo = cdc.tblJobOffers.Where(x => x.applicationID == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                    if(jo != null)
                    {
                        getInput(lf);
                        jo.numOfTFWs= _numOfTFWs;
                        jo.duration= _duration;
                        jo.durationUnit= _durationUnit;
                        jo.durationRationale= _durationRationale;
                        jo.startDate= _startDate;
                        jo.languageRequired = _languageRequired;
                        jo.readingEnglishFrenchRequied = _readingEnglishFrenchRequied;
                        jo.readingEnglishRequired= _readingEnglishRequired;
                        jo.readingFrenchRequired = _readingFrenchRequired;
                        jo.readingEnglishOrFrenchRequired = _readingEnglishOrFrenchRequired;
                        jo.readingEnglishAndFrenchRequired = _readingEnglishAndFrenchRequired;
                        jo.writingEnglishFrenchRequired = _writingEnglishFrenchRequired;
                        jo.writingEnglishRequired = _writingEnglishRequired;
                        jo.writingFrenchRequired = _writingFrenchRequired;
                        jo.writingEnglishOrFrenchRequired = _writingEnglishOrFrenchRequired;
                        jo.writingEnglishAndFrenchRequired = _writingEnglishAndFrenchRequired;
                        jo.otherLanguageRequired = _otherLanguageRequired;
                        jo.otherLanguageExplanation= _otherLanguageExplanation;
                        jo.vacationDays= _vacationDays;
                        jo.remuneration= _remuneration;
                        jo.isSeasonal = _isSeasonal;
                        jo.isFullyCoveredLMIA = _isFullyCoveredLMIA;
                        jo.notFullyCoveredReason= _notFullyCoveredReason;
                        jo.isJobLicensed = _isJobLicensed;
                        jo.licenseAuthority= _licenseAuthority;
                        jo.licenseReady = _licenseReady;
                        jo.licenseReadyTime= _licenseReadyTime;
                        jo.licenseReadyUnit= _licenseReadyUnit;
                        jo.isJobUnion = _isJobUnion;
                        jo.unionNameLocation= _unionNameLocation;
                        jo.isUnionConsulted = _isUnionConsulted;
                        jo.unionNotExplanation= _unionNotExplanation;
                        jo.unionOpinion= _unionOpinion;
                        jo.attemptedRecruitCanadian = _attemptedRecruitCanadian;
                        jo.notAttemptedReason= _notAttemptedReason;
                        jo.OfficialAdNumber= _OfficialAdNumber;
                        jo.briefBenefit= _briefBenefit;
                        jo.detailedBenefit= _detailedBenefit;
                        jo.briefRationaleOfferingJob= _briefRationaleOfferingJob;
                        jo.detailedRationaleOfferingJob= _detailedRationaleOfferingJob;
                        jo.trainCanadian = _trainCanadian;
                        jo.noTrainReason= _noTrainReason;
                        jo.trainPlanBrief= _trainPlanBrief;
                        jo.trainPlanDetails= _trainPlanDetails;
                        jo.willProvideAccomadation = _willProvideAccomadation;
                        jo.notProvideButOffer= _notProvideButOffer;
                        jo.provideRent= _provideRent;
                        jo.provideUnit= _provideUnit;
                        jo.accomadationNotApplicalbe = _accomadationNotApplicalbe;
                        jo.whoIsFillingBrief= _whoIsFillingBrief;
                        jo.whoIsFillingDetail= _whoIsFillingDetail;
                        jo.howDidYouFindBrief= _howDidYouFindBrief;
                        jo.howDidYouFindDetail= _howDidYouFindDetail;
                        jo.howDidYouDetermineBrief= _howDidYouDetermineBrief;
                        jo.howDidYouDetermineDetail= _howDidYouDetermineDetail;
                        jo.howAndWhenOfferBrief= _howAndWhenOfferBrief;
                        jo.howAndWhenOfferDetail= _howAndWhenOfferDetail;
                        try
                        {
                            cdc.SubmitChanges();
                            MessageBox.Show("Data has been saved.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        catch(Exception exc)
                        {

                            MessageBox.Show(exc.Message);;
                        }
                    }
                    else MessageBox.Show("There is no job offer record to delete.");

                }
            }
            else MessageBox.Show("There is no active application");

        }
        public static void buildupDict5602(ref Dictionary<string, string> dict) { }
    }
}
