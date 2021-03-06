fuse common
go

-- RCIC Information table
create table tblRCIC(
Id int not null primary key identity(1,1),
FirstName nvarchar(20),
MiddleName nvarchar(20),
LastName nvarchar(20),
JobTitle nvarchar(50),
Telephone nvarchar(15),
FaxNumber nvarchar(15),
Email nvarchar(50),
MembershipID nvarchar(10),
BusinessOperatingName nvarchar(50),
CRABN nvarchar(15),
BusinessLegalName nvarchar(50),
ESDCThirdPartyID nvarchar(20),
MailingAddress nvarchar(30),
BusinessAddress nvarchar(30),
City nvarchar(20),
Province int,
Country nvarchar(20),
PostalCode nvarchar(10),
MainBizActivities nvarchar(100),
theSignature image,
MailPO nvarchar(10),
MailAptUnit nvarchar(20),
MailStreetNo nvarchar(100),
MailStreetName nvarchar(100)
)

-- how to add image to column
update dbo.tblRCIC 
set Signature=(SELECT MyImage.* from Openrowset(Bulk 'C:\VBA\signature.png', Single_Blob) MyImage) 
where Id=2

create table tblNOC
(
Id int not null primary key identity(1,1),
NOC char(4),
MainDuties varchar(1000),
EmploymentRequirement varchar(1000)
)

-- Credit card table
create table tblCreditCard(
Id int not null primary key identity(1,1),
EmployerId int,
PersonId int,
CardType int , -- // 0 is visa, 1 is master 2 is american express
CardHolderName nvarchar(50),
--Last4Number nvarchar(4) not null,  this could be calculated by code
CardNumber nvarchar(16),
SecurityCode nvarchar(10),
ExpireMonth nvarchar(2),
ExpireYear nvarchar(4)
)

create table tblApplication(
Id int not null primary key identity(1,1),
ApplicantId int,
RCICId int,
ApplicationType int, -- need to define
CreatedDate date,
SubmittedDate date,
ClosedDate date,
ApplicationNumber nvarchar(20),
ApplicationFee money,
)

-- Create country PK table
create table tblCountry
(
Id int not null primary key Identity(1,1),
CountryCode int not null,  -- Match with CIC country code defenition
Country varchar(30) not null
)






-- Creat phone type PK table
create table tblPhoneType
(
Id int not null primary key Identity(1,1),
TypeCode int not null,  -- Code matchs CIC Definition
Type varchar(10) not null
)

insert into tblPhoneType values(1, 'Residence')
insert into tblPhoneType values(2, 'Cellular')
insert into tblPhoneType values(3, 'Business')

-- Creat address type PK table

-- Creat language type PK table
create table tblLanguageType
(
Id int not null primary key Identity(1,1),
TypeCode int,  -- Code matchs CIC Definition
LanguageType varchar(10)
)



-- Create education information 
-- PersonId: FK to reference the person who owns this education
-- LevelId: FK to reference the level of this eduation

create table tblEducation
(
Id int not null primary key Identity(1,1),
PersonId int,  -- Fk to reference the education owner
StartDate date,
EndDate date,
School varchar(100),
Program varchar(100),
LevelId int,  --FK to reference the educatin level
City varchar(50),
CountryId int, --FK to reference the country
ProvinceId int  --Fk to reference the Canada province
)

-- Create employment table
create table tblEmployment
(
Id int not null primary key Identity(1,1),
PersonId int,  -- FK to reference the Person Id
FromDate date,
ToDate date ,
ActivityorOccupation varchar(50) ,
CompanyorPlace varchar(100),
City varchar(50),
CountryId int,  -- FK to reference the country
ProvinceId int  --Fk to reference the Canada province
)

-- Create 

-- Create background information table
create table tblTRBackgroundInfo
(
Id int not null primary key Identity(1,1),
PersonId int,  -- FK to reference the Person Id,
Q1a bit ,  --within the past 2 years, have you or a family member ever had tuberculosis of the lungs or been in close contact with a person with tuberculosis?
Q1b bit ,
Q1c varchar(200),
Q2a bit ,
Q2b bit ,
Q2c bit ,
Q2d varchar(200),
Q3a bit ,
Q3b varchar(200),
Q4a bit ,
Q4b varchar(200),
Q5 bit ,
Q6 bit ,
)

-- Create coming to Canada table
create table tblTRCanadaVisit
(
Id int not null primary key Identity(1,1),
PersonId int,  -- FK to reference the Person Id,
OriginalEntryDate date,
OriginalEntryPlace varchar(20),
OriginalPurposeId int,  -- FK to reference the visit purpose
OtherPurpose varchar(50),
RecentEntryDate date,
RecentEntryPlace varchar(20),
MostRecentyDocNumber varchar(20)
)

-- Create Phone table
create table tblPhone
(
Id int not null primary key Identity(1,1),
PersonId int,  -- FK to reference the Person Id,
PhoneTypeId int , --FK to reference the phone type
CountryCode int ,
Number varchar(25)
)

--Create Address table
create table tblAddress
(
Id int not null primary key Identity(1,1),
PersonId int,  -- FK to reference the Person Id,
POBox varchar(10),
Unit varchar(20),
StreetNo varchar(15),
StreetName varchar(100),
District varchar(50),
City varchar(30),
CountryCode char(3) , -- reference the Country code of cic
CNDProvinceId int,
PostalCode varchar(10),
AddressTypeId varchar(30)
)

-- Create passport table
 create table tblPassport
(
Id int not null primary key Identity(1,1),
PersonId int ,  -- FK to reference the Person Id,
PassportNumber varchar(10),
Name nvarchar(30) ,
GenderId int,   -- 1 Male or 2 Female 3 unknown
BirthCountryId int, -- CIC Code 202 is China
NationalityId int ,   --reference the country code which Matchs CIC country definition
DOB date ,
BrithPlace varchar(20),
IssueDate date ,
IssuePlace varchar(20) ,
ExpiryDate date ,
IsValid bit,
IssueCountryId char(3)
)

-- Create language table
create table tblLanguage
(
Id int not null primary key Identity(1,1),
PersonId int ,  -- FK to reference the Person Id,
NativeLanguageId char(3) ,  --FK to reference the language Id who matchs CIC defenition
OtherMostlyUse char(2), --Other than native language, which one does you use mostly 01 English, 02 French 03 neither, 04 Both
CommIn varchar(20),  -- English or french, Both,Neither
LanguageTest bit
)


create table tblMarriageHistory(
Id int not null primary key Identity(1,1),
PersonId int ,  -- FK to reference the Person Id,
SpouseId int,   --FK to reference the Person Id
BeginDate date,
EndDate date,
relationship char(2)
)

-- Create residence table
create table tblResidence
(
Id int not null primary key Identity(1,1),
ApplicationId int,  --FK  Reference to Application Id
StartDate date,
EndDate date,
CountryId int,
StatusId char(2),
OtherStatus nvarchar(30),
ResidenceType int
)

-- Create person table

create table tblPerson
(
Id int not null primary key Identity(1,1),
FirstName varchar(20),
MiddleName varchar(20),
LastName varchar(20),
DOB Date,
Gender int,  -- 1 Male 2 Female 3 Unknown
IsAliasName bit,
AliasLastName varchar(20),
AliasFirstName varchar(20),
UCI char(8),
MarriageStatusId char(2),
Phone varchar(20),
Email varchar(100),
Photo Image,
theSignature Image
)

-- Create Phone table
	create table tblPhone
(
Id int not null primary key Identity(1,1),
PersonId int,  -- FK to reference the Person Id,
USorCa varchar(2),
Other varchar(2),
PhoneType varchar(15),
CountryCode varchar(6),
PhoneNumber varchar(15),
Extension varchar(10),
PhoneorFax varchar(10),
)

create table tblProgram
(
Id int not null primary key identity(1,1),
Name varchar(150),
CategoryId int
)
insert into tblProgram values('LMIA PR Support Only',1)
insert into tblProgram values('LMIA PR and WP',1)
insert into tblProgram values('LMIA WP Only',1)
insert into tblProgram values('BCPNP SW',2)
insert into tblProgram values('BCPNP EI',2)
insert into tblProgram values('BCPNP International Graduate',2)

create table tblCategory
(
  Id int not null primary key identity(1,1),
Name varchar(100),
)
insert into tblCategory values ('LMIA')
insert into tblCategory values ('BCPNP')

create table tblFinance
(
Id int not null primary key identity(1,1),
ApplicationId int,
FiscalYear int,
TotalRevenue money,
Cash money,
NetIncome money,
RetainedEarning money,
GrossPayroll money,
T4SlipsIssued int
)

create table tblLMIAPosition
(
Id int not null primary key identity(1,1),
ApplicationId int,
workLocationId int,
JobTitle varchar(100),
NOC char(4),
employmentTerm varchar(100),
jobDuties varchar(4000),
skillRequirement varchar(1000),
workExperience	varchar(1000),
languageRequirement	  varchar(500),
otherRequirement	varchar(1000),
contactInformation	 varchar(500),
Province int,
WorkingHours float,
HourlyRate money,
ProvincialMedian money,
LocalNOCMedian money,
LocalNOCLowest money,
LocalNOCHighest money,
SamePlaceSamePositionLowest money,
SamePlaceSamePositionHighest money,
NoSamePosition bit,
UmemploymentRate float,
COPSRating int,  -- 1 poor 2 moderate 3 good
OccupationProfile int, -- 1 poor 2 moderate 3 good
EmployerSituation nvarchar(500),
EmployerImact nvarchar(500)

)
create table tblLMIA11Factors
(
Id int not null primary key identity(1,1),
ApplicationId int,
JobCreation bit,
SkillTransfer bit,
FillLabourShortage bit,
PrevailingWageOffered bit,
HireCanadianEffort bit,
LabourDisputUnaffected bit,
CommitmentFulfilled bit,
BusinessEngagement bit,
OfferConsistentwithDemand bit,
AbletoFulfillTermofOffer bit,
PastCompliance bit
)
-- Application information
create table tblLMIAApplication(
Id int not null primary key identity(1,1),
ProgramType int, -- 1 Only for PR, 2 PR+WP 3 N/A  // this data can be stored in codes
StreamType int, --0 for High Wage Stream 1 for Low Wage Stream
EmployerId int,
EmployeeId int,
RCICId int,
WorkLocationId int,
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

-- Job offer tables, 1 for Job itself(5593:1-18), 2 for related info(5593:19-28)
create table tblJobOffer(
Id int not null primary key identity(1,1),
applicationID int,  -- Business information could be changed, so it only directly related to application, instead of Employer
jobTile varchar(30),
numOfTFWs int,
duration int,
durationUnit int,
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
otherBenefit varchar(100),
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
accommodationDescription varchar(150),
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
MailAddressId int,
BizAddressId int,
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

create table tblJobPost
(
Id int not null primary key identity(1,1),
applicationID int,
mediaId int, 
[Status] int,
Qualified bit,
MediaName varchar(150),
PostDate datetime,
ExpiryDate datetime,
InitialPrintDate datetime,
LastPrintDate datetime,
Account varchar(150),
[Password] varchar(20),
OtherInfo varchar(200),
Cost money,
Link varchar(200)
)