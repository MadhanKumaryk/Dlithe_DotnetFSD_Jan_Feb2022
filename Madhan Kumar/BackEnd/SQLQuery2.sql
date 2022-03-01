--primary key
create table Dept
(
Dno int Primary key,
Dname varchar(25)
)
--insert (depart table)
insert into Dept values(1,'HR')
insert into Dept values(2,'Java')
insert into Dept values(3,'Python')
--select (dept table)
Select *from Dept
--Foreign Key(Dept-emp)
create table emp
(
eid int Primary key,
ename varchar(25),
dno int Foreign key references Dept(Dno)
)
--insert  (emp table)
insert into emp values(1001,'Ganesh',1);
insert into emp values(1002,'Arun',2);
insert into emp values(1003,'Arjun',2);
--select
select * from emp
--Check constraint
create table Project
(
prjno int Primary key, 
prjname varchar(25) check(prjname like 'P1%'),
prjclient varchar(25) default 'ABC'
)
--insert 

select * from Project
insert into Project values(1,'P1001','TE')
insert into Project(prjno,prjname) values(2,'P1002')
--unique
create table Dlithe_Trainees
(
TID int Primary key,
TNAME varchar(30) unique,
TSALARY int default 35000,
TADDRESS varchar(50) NOT NULL,
TDEPT varchar(10) check(Tdept like 'DIT%')
)
insert into Dlithe_Trainees values(10,'Rohith',40000,'Bangalore','DITDOTNET')
select * from Dlithe_Trainees

