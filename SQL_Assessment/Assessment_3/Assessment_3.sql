use infinite
 create table C_students (

C_ID varchar(15),

C_Name varchar(20),

Start_Date varchar(25),

End_Date varchar(25),

Fee int)
 
insert into C_students values
create table
c_id     C_name             start_date   end_date      fee
DN003  DotNet               2018_02_01   2018 _02_28   15000
DV004  datavisualization    2018_03_01    2018_04_15   15000
JA002  advancedjava         2018_01_02    2018_01_20    10000
JC001  corejava              2018_01_02   2018_01_12   3000
select * from C_students
 
create function Calculate_Course_Duration(@start_date DATE, @end_date DATE) 

returns int 

as 

begin 

return DATEDIFF(day, @start_date, @end_date) 

end 

select dbo.Calculate_Course_Duration('2018-01-02', '2018-01-20') AS DurationInDays;
 

 ---------------------------------query 2---------------------------
 
 CREATE TABLE T_CourseInfo(
C_Name VARCHAR(30),
Start_date DATE)

 
CREATE TRIGGER InsertionTrigger ON C_students
AFTER INSERT AS
BEGIN
INSERT INTO T_CourseInfo(java, Start_date)
SELECT java, Start_date FROM inserted 
END
INSERT INTO C_students VALUES
('GA002','java','2024-06-12','2020-08-22',9000)
SELECT * FROM T_CourseInfo
 

 --------------------------------query 3----------------------------
 CREATE PROCEDURE sp_InsertProductDetails
c_id        C_name             start_date   end_date      fee
DN003  DotNet               2018_02_01   2018 _02_28   15000
DV004  datavisualization    2018_03_01    2018_04_15   15000
JA002  advancedjava         2018_01_02    2018_01_20    10000
JC001  corejava              2018_01_02   2018_01_12   3000 
@ProductName VARCHAR(250),
    @Price DECIMAL(10)
AS
BEGIN
      
    INSERT INTO ProductsDetails (ProductName, Price)
    VALUES (@ProductName, @Price);
 
    
    SELECT SCOPE_IDENTITY() AS ProductId;
 
    RETURN SCOPE_IDENTITY();
END;