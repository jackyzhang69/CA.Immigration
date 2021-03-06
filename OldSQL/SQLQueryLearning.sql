--/****** Script for SelectTopNRows command from SSMS  ******/
--SELECT TOP 1000 [Id]
--      ,[KnowledgeType]
--      ,[Tag]
--      ,[Syntax]
--      ,[Sample]
--  FROM [Programing].[dbo].[tblKnowledges]
--  select * from Persons 
--  select UPPER(Name) from Persons
--  select Name from Persons


--  declare @start int
--set @start=65
--while (@start<=90)
--begin 
--   print char(@start)
--   set @start=@start+1
--end

--select right('hello',3)
--select charindex('@', 'jacky@unigenius.com')
--select substring('jacky@unigenius.com',7,13)
--select substring('jacky@unigenius.com',charindex('@','jacky@unigenius.com')+1,len('jacky@unigenius.com')-charindex('@','jacky@unigenius.com') )
--select replicate ('good ',3)

--select space(5)
--select getdate()
--select CURRENT_TIMESTAMP
--select SYSDATETIMEOFFSET()


--select isdate(getdate())
--select year(getdate())

--select datename(WEEK,'2016-10-02 10:31:46.990') 
--select datepart(weekday,getdate())
--select datename(weekday,getdate())
--select dateadd(day,14, getdate()) 
--select datediff(day, getdate(), dateadd(day, 100,getdate()))
--select datediff(month,getdate(),'2016-11-3')
--select datediff(day,getdate(),'2016-11-3')

create function fnComputeAge(@DOB datetime)
returns varchar(50)
as 
begin 

declare @tempdate datetime,@years int, @months int, @days int

select @tempdate=@DOB

select @years=datediff(year, @tempdate,getdate())-
    case
         when (month(@DOB)>month(getdate())) or 
         (month(@DOB)=month(getdate()) and day(@DOB)>day(getdate()))
          then 1 else 0
    end
select @tempdate=dateadd(year, @years,@tempdate)  -- add the year difference in order to only calculate months

select @months=DATEDIFF(month,@tempdate,getdate())-
     case
	     when day(@DOB)>DAY(getdate())
		 then 1 else 0
     end
select @tempdate=dateadd(month,@months,@tempdate) -- add the months difference in order to only calculate days

select @days=datediff(day, @tempdate,getdate())

declare @Age varchar(50)
set @Age=cast(@Years as varchar(4))+' Years'+cast(@months  as varchar(2))+' Months'+cast(@days as varchar(2))  +' Days age'

return @Age

end 

 How to use it
select Name, Telephone, DOB, [dbo].[fnComputeAge](DOB) AS Age
from dbo.Persons

--select * from Persons

select Id, Name, DOB,convert(nvarchar, DOB,105) as ConvertedDOB from Persons
select Id, Name, DOB,cast(DOB as nvarchar(20)) as ConvertedDOB from Persons
select cast(getdate() as date)

select Id, Name, Name+'-'+cast(Id as varchar) as NameId from Persons
select rand(3300000)
select round(989.56625,-1)

select SQUARE(3.33) as Area
select cast(getdate() as varchar)

 create table #temp1 (Id int, Name varchar(20))
	select * from #temp1
	insert into #temp1 values (1, 'hi')
select * from tempdb..sysobjects
where name like '#temp1%'

-- global temp table with ##
create table ##temp1 (Id int, Name varchar(20))
	select * from ##temp1
	insert into ##temp1 values (1, 'hi')
select * from tempdb..sysobjects
where name like '##temp1%'


create index IX_Name
on Persons(DOB desc)

select DOB from Persons
ORDER BY DOB DESC

EXEC SP_HELPINDEX Persons

CREATE TABLE A
(UD INT,
NAME VARCHAR(20),
age varchar(15)
)

create clustered index Ix_age
on a(age)
select * from a order by age desc

create unique nonclustered index UIX_Name
on a(Name asc)
insert into a values(1,'Dan','6')

select Name from a order by age desc

update a set age=5.5 where Name='Dan'
select * from a
update a set age=17 where Name='Jackson'

update a set age=47 where Name='Jacky'

update a set age=44 where Name='May'

select Name,age from a 

exec sp_helpindex a

drop index a.UIX_Name

create table school
(
  Id int primary key not null,
  Name varchar(30)
)

alter table a
add SchoolId int

update a set SchoolId=1 where Name='Jacky'
update a set SchoolId=2 where Name='Jackson'
update a set SchoolId=3 where Name='May'
update a set SchoolId=4 where Name='Dan'

insert into school (Id,Name) values(1,'Ashton')
insert into school (Id,Name) values(2,'Pinetree')
insert into school (Id,Name) values(3,'PineTree Way')
insert into school (Id,Name) values(4,'Montegamary')


select * from a

create view vwPerson
as 
select UD,Name
from a

select * from vwPerson
insert into vwPerson values(5, 'Max')
delete vwPerson where UD=5
 



