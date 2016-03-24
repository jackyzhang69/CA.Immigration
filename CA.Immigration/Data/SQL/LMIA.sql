


--- lmia Database
use LMIA
go
-- If a required document is not attached, please explain:  do it someday

-- Recruitment Summary 
create table tblRecruitSummary(
Id int not null primary key identity(1,1),
ApplicationId int, 
CndResumesReceived int,  --How Many Canadians/PRs' resumes received
CndInterviewed int, --How many Canadians/PRs are interviewed
CndNotQualified int,  --How many Canadians/PRs are not qualified
CndJobOffered int,  --How many jobs offered to Canadians/PRs
CndOfferDeclined int,  --How many job offer declined by Canadians/PRs
CndHired int,  --How many Canadians/PRs are hired
WhyNotCnd nvarchar(4000) --Please explain why each Canadians/PRs is not qualified
)


-- Employer information
create table tblEmployer(
Id int not null primary key identity(1,1),
ESDCId char(6),   -- if not first apply, should have a ESDC employer ID
CRA_BN nvarchar(15) ,  -- CRA Business Number 
LegalName nvarchar(50) ,
OperatingName nvarchar(50),
FranchiseName nvarchar(50),
FranchiseAware int, --1 yes, 2 no, 3 not applicalb
CompanyType int,  -- 1 Incorporated 2 Partner 3 Solo proprietor
MailingAddress nvarchar(50),   -- street address for mailing address
MailingCity nvarchar(20),
MailingProvince int,
MailingCountry nvarchar(20),
MailingPostalCode nvarchar(10),
BizAddress nvarchar(50),   -- street address for business address, should check if same
BizCity nvarchar(20),
BizProvince int,
BizCountry nvarchar(20),
BizPostalCode nvarchar(10),
BizTelephone nvarchar(20),
Website nvarchar(100),
BizStartDate date,
BizActivity nvarchar(100),  --  Describe the principal business acivity
ContactFirstName nvarchar(20),
ContactMiddleName nvarchar(20),
ContactLastName nvarchar(20),
ContactJobTitle nvarchar(20),
ContactPhone nvarchar(20),
ContactFax nvarchar(20),
ContactEmail nvarchar(50),
theWitness nvarchar(20)
)

-- Application information
create table tblLMIAApplication(
LMIAApplicationId int not null primary key identity(1,1),
ProgramType int, -- 1 Only for PR, 2 PR+WP 3 N/A  // this data can be stored in codes
StreamType int, --0 for High Wage Stream 1 for Low Wage Stream
EmployerId int,
EmployeeId int,
RCICId int,
CreatedDate date,
SubmittedDate date,
ClosedDate date,
ApplicationNumber varchar(20),
ApplicationFee money,
SecondEmployer varchar(30),
NumberofPosition int,
ApplicationFeePerPosition money,
PayMethod int,  -- Method of Payment:1 Certified cheque or money order (postal or bank) made payable to the Receiver General for Canada 2 Credit Card
MoreThanOneEmployer bit,
AnotherEmployerName	varchar(150)
)

-- Application followup 
create table tblFollowup(
Id int not null primary key identity(1,1),
ApplicationId int,
Request nvarchar(200),
RequestDate date,
Response nvarchar(200),
ResponseDate date
)

--Business detail table
create table tblBusinessDetail (
Id int not null primary key identity(1,1),
ApplicationId int,  -- Business information could be changed, so it only directly related to application, instead of Employer
TotalEmployeeUnderCRA int, --"1. Number of employees currently employed nationally under this Canada Revenue Agency Business number (e.g. 5 franchises are covered by the business
                                           -- number and there are a total of 100 employees):"
TotalEmployeeThisLocation int, --2. Total number of employees currently employed at the work location specified on this form:

TotalCndThisLocation int, --3. Total number of Canadian/permanent resident employees at the work location specified on this form:

TotalEmployeeThisOccupationLocation int,  --4. Total number of employees (including Canadians/permanent residents and TFWs) working in this occupation at this work location:
TotalTFWAfterPositive int,  --5. Total number of foreign workers (as a result of receiving a positive LMIA) at the work location specified on this form:
Q6 bit , --	1 N 2 Y, within two years before 12/31/2013, did you employ a foreign worker(as the result of receiving LMIA)
Q6_1 bit,  --  1N 2 Y,If YES ?did you provide all foreign workers employed by you in the last two years with wages, working conditions and employment in an occupation that were substantially the same as those that were described in the offer(s) of employment (and confirmed in the LMIA letter(s) and annexe(s))?
Q7 bit , --	Have you applied for and received a positive LMIA on or after December 31, 2013, and employed a foreign worker in that position?
Q7_1 bit,  --	  If YES ?did you provide all foreign workers employed by you, on LMIAs received on or after December 31, 2013, with employment in the same occupation as described in the offer(s) of employment (and confirmed in the LMIA letter(s) and annexe(s)) and with substantially the same wages and working conditions - but not less favourable than- those set out in that offer(s) of employment (and confirmed in the LMIA letter(s) and annexe(s))?
Q8 bit ,  --	  Have you had an LMIA revoked, within the previous 2 years from the date you submitted this Application?
Q8_1 bit, 	--If YES ?was the LMIA revoked because you had provided false, misleading or inaccurate information in the context of a request for an opinion?
Q8_2 date, -- If yes, please provide the following details regarding this revocation:	Date (yyyy-mm-dd):
Q8_3 varchar(20),--System File Number:	  
Q8_4 varchar(100),	 -- If the public policy considerations that justified the revocation are no longer relevant, please provide a detailed explanation:
Q9 bit, --   Were any employees laid off in the past 12 months?
Q9_1 int,  -- 	 If yes, how many Canadians/permanent residents?
Q9_2 int,  --  How many foreign workers?
Q9_3 varchar(100),	-- Reason(s) for layoff(s) and occupations affected:
Q10 bit, --  Does your business receive support through any Government of Canada program (e.g. Work-Sharing Program)?
Q10_1 varchar(50)  -- If yes, name the program(s):

)


-- Job offer tables, 1 for Job itself(5593:1-18), 2 for related info(5593:19-28)
create table tblJobOffer(
Id int not null primary key identity(1,1),
applicationID int,  -- Business information could be changed, so it only directly related to application, instead of Employer
jobTile varchar(30),
numOfTFWs int,
duration int,
durationUnit varchar(30),
durationRationale varchar(150),
startDate date,
languageRequired bit,
readingEnglishFrenchRequied bit,
readingEnglishRequired bit,
readingFrenchRequired bit,
readingEnglishOrFrenchRequired bit,
readingEnglishAndFrenchRequired bit,
writingEnglishFrenchRequired bit,
writingEnglishRequired bit,
writingFrenchRequired bit,
writingEnglishOrFrenchRequired bit,
writingEnglishAndFrenchRequired bit,
otherLanguageRequired bit,
otherLanguageExplanation varchar(150),
vacationDays int,
remuneration int,
isSeasonal  bit,
isFullyCoveredLMIA bit,
notFullyCoveredReason varchar(150),
isJobLicensed  bit,
licenseAuthority varchar(150),
licenseReady  bit,
licenseReadyTime int,
licenseReadyUnit  varchar(30),
isJobUnion bit,
unionNameLocation varchar(150),
isUnionConsulted  bit,
unionNotExplanation varchar(150),
unionOpinion varchar(150),
attemptedRecruitCanadian  bit,
notAttemptedReason varchar(150),
OfficialAdNumber varchar(20),
briefBenefit varchar(150),
detailedBenefit varchar(4000),
briefRationaleOfferingJob varchar(150),
detailedRationaleOfferingJob varchar(4000),
trainCanadian  bit,
noTrainReason varchar(150),
trainPlanBrief varchar(150),
trainPlanDetails varchar(4000),
willProvideAccomadation  bit,
notProvideButOffer  varchar(150),
provideRent int,
provideUnit varchar(30),
accomadationNotApplicalbe  bit,
whoIsFillingBrief varchar(150),
whoIsFillingDetail varchar(4000),
howDidYouFindBrief varchar(150),
howDidYouFindDetail  varchar(4000),
howDidYouDetermineBrief  varchar(150),
howDidYouDetermineDetail varchar(4000),
howAndWhenOfferBrief  varchar(150),
howAndWhenOfferDetail varchar(4000),
)

create table tblImpactLM(
Id int not null primary key identity(1,1),
ApplicationID int,  -- Business information could be changed, so it only directly related to application, instead of Employer
JobLoss int,  --  the TFW hiring will lead Canadian job lose?
JobLossExplain nvarchar(200),
OutSourcing int, 
ContractSummary nvarchar(200),
ImpactCanadian nvarchar(200),
HireWithoutLMIA int, 
RecruitEffort nvarchar(200), -- past 2 years hire effore
HiringImpactCanadian nvarchar(200)
) 

create table tblEmployee(
Id int not null primary key identity(1,1),
PersonId int,
OutCanadaCity nvarchar(20),
OutCanadaCountry nvarchar(20),
StatusinCanada nvarchar(20),
CanadaCity nvarchar(20),
CanadaProvince nvarchar(20),
Visitor int, 
Student int,
ForeignWorker int,
RefugeeClaimant int,
Hired int, 
Duration nvarchar(30)
)
