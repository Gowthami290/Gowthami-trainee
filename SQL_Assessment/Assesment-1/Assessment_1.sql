 create database Sql_1



select *from Book             ---Query 1
where author like '%er'
 
select b.title,b.author,r.reviewer_name   ---Query_2

from Book b join reviews r

on  b.id=r.book_id
 
 
select reviewer_name from Reviews               ---Qurey_3

where book_id is not null

group by reviewer_name

having count(distinct book_id)>1
 
select lower(Ename) as Employee_name            ---Query 6 

from employee

where salary is null
 
select Ename from Employee                            
where addres like'%o%'                         ---Query 4 
 
SELECT Date, COUNT(CUSTOMER_ID) AS TotalCustomers FROM Orders GROUP BY Date;     ---Query 5 
select gender,count(*) as Total_count                  ---Query 7
from Student_details
group by gender
 
                           