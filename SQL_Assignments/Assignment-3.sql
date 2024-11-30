use Infinite
select* from emp
select * from DEPT
                   --query 1
select ename 
from emp 
where job='manager'
                    --query 2
select ename,sal 
from emp 
where sal>1000
                    --query 3
select ename,sal 
from emp 
where ename!='james'
                     -- query 4
select empno,ename,job,mgr_id,hiredate,sal,comm,deptno 
from emp 
where ename like 's%'
                   --query 5
select ename 
from emp 
where ename like '%a%'
                   --query 6
select ename 
from emp 
where ename like '__l%'
                         --qurey 7
select ename, 
round(sal /30,2) as 'Day Salary' 
from emp  
where ename='james'
                     -- query 8
select sum 
(distinct sal) as "Total Salary"
from emp
                   --query 9
select avg(sal*12) as "Annual Salary" 
from emp
                           --query 10
select ename,job,sal,deptno 
from emp 
where not( deptno=30 and job='salesman')
                           --query 11
select distinct deptno 
from emp
                          --query 12
select ename as' Employee',
sal as 'Monthlysalary' 
from emp 
where sal>1500 and (deptno=10 or deptno=30)
                                  --query 13
select ename,job,sal 
from emp 
where (job='manager' or job='analyst') and sal not in (1000,3000,5000)
                             --query14
select ename,sal,comm 
from emp 
where comm>sal*1.1
                              --query 15
select ename 
from emp 
where (ename like '%l%l%' and (deptno=30 or mgr_id=7782))
                               --query 16
select ename 
from emp
where datediff(year,hiredate,getdate())between 30 and 40
select count(empno) 
from emp 
where datediff(year,hiredate,getdate())between 30 and 40
                        --query 17
select dept.dname,emp.ename
from emp
join dept on emp.deptno=dept.deptno
order by dept.dname asc, emp.ename desc
                        --query 18
select ename,datediff(year,hiredate,getdate()) as 'Experience'
from emp
where ename='miller'