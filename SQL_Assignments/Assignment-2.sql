create database Infinite
create table EMP                    --Creating emp table
(
Empno int primary key,
Ename varchar(20),
job varchar(20),
Mgr_id int ,
Hiredate date ,
Sal int ,
Comm int,
Deptno int references DEPT(Deptno)
)

 
insert into EMP
values (7369, 'SMITH', 'CLERK', 7902, '17-DEC-80' , 800 ,null ,20),
	   (7499,'ALLEN','SALESMAN',7698, '20-FEB-81', 1600,300 ,30),
		(7521, 'WARD', 'SALESMAN', 7698, '22-FEB-81', 1250, 500 , 30),
		(7566, 'JONES', 'MANAGER', 7839, '02-APR-81', 2975,null, 20),
		(7654, 'MARTIN', 'SALESMAN', 7698, '28-SEP-81', 1250,1400, 30),
		(7698, 'BLAKE','MANAGER',7839, '01-MAY-81', 2850 ,null,30),
		(7782, 'CLARK','MANAGER', 7839, '09-JUN-81', 2450 ,null, 10),
		(7788,'SCOTT','ANALYST', 7566 ,'19-APR-87',3000, null, 20),
		(7839, 'KING','PRESIDENT',null,'17-NOV-81',5000 ,null,10),
		(7844, 'TURNER','SALESMAN',7698, '08-SEP-81',1500, 0, 30),
		(7876, 'ADAMS', 'CLERK', 7788,'23-MAY-87', 1100,null, 20),
		(7900, 'JAMES', 'CLERK', 7698,'03-DEC-81',950,null, 30),
		(7902, 'FORD', 'ANALYST', 7566, '03-DEC-81',3000,null, 20),
		(7934, 'MILLER', 'CLERK', 7782, '23-JAN-82',1300,null, 10)
 
 
select *from Emp                  --Fetching Emp table
sp_help EMP                       --Description regarding emp table
 
create table DEPT                 --Creating DEPT table
(
Deptno int primary key,
Dname varchar(50) not null,
loc varchar(20)
)
 

 
insert into DEPT                   --inserting values into Dept table
values (10,'ACCOUNTING','NEW YORK' ),
	   (20, 'RESEARCH', 'DALLAS' ),
	   (30, 'SALES', 'CHICAGO' ),
	   (40, 'OPERATIONS','BOSTON' )
 
 
select * from DEPT              --Fetching details of DEPT
sp_help DEPT                    --Describing DEPT table
 
                            
				Assignment-2   (QUERIES)
 
 
select Ename from Emp where ename like 'A%'    
select Ename from EMP where Mgr_id is null      
 
select Ename,Empno,Sal                         
from EMP
where Sal between 1200 and 1400    
 
select Sal,Sal*1.10 as Pay_raise               
from Emp
where Deptno=(select Deptno from Dept where Dname='Research')
 
select count(*) as Clerk_Count                  
from EMP
where job='Clerk'
 
select job,avg(sal) as Avg_Salary ,count(*) as EMP_Count   
from EMP
Group by job;
select Ename from EMP                         
where Sal=(select max(Sal) from EMP)
select ename from emp 
where sal=(select min(sal) from Emp)
 
 
select d.Dname                                 
from dept d Left join EMP e 
on d.Deptno=e.Deptno
where e.Deptno IS NULL
 
select * from emp                             
where job='Analyst' and sal>1200 and deptno=20
 
select e.Ename,e.Sal,e.Deptno,sum(e1.Sal) as Total_sal  
from emp e join emp e1
on e.Deptno=e1.Deptno
group by e.ename,e.sal,e.deptno
 
select ename sal from emp                     
where ename in ('smith','miller')
 
select ename from EMP                        
where Ename like 'A%' or  Ename like 'M%'
 
select ename,sal,sal*12 as Smith_Annual_sal   
where ename='Smith'
 
select ename,sal from emp                    
where sal not between 1500 and 2850
 
select mgr_id,count(*) as Emp_Count           
from emp group by mgr_id
having  count(*)>2
 