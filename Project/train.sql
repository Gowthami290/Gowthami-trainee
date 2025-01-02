CREATE DATABASE RailwayReservation
use RailwayReservation

create table Trains
(
trainnumber int primary key,
trainName varchar(20),
source varchar(20),
destination varchar(20),
availableBerths int,
IsActive bit
)
insert into trains (trainnumber,trainname,source,destination,availableBerths, IsActive)
values
(12345,'Bidhar express','Machiliptnam','Hyderabad',50,1),
(12346,'Godavari express','vizag','machiliptnam',20,1);
--------------------------------------------------------------------------------------------------------
create or alter procedure Addtrain
@TrainNumber int,@trainName varchar(20),@source varchar(20),@destination varchar(20),@availableBerths int,@trainclass varchar(20),@isActive bit
as
begin
if exists (select 1 from trains where Trainnumber = @Trainnumber)
begin
print 'Train with this Trainnumber already exists,';
return;
end
insert into Trains(TrainNumber,Trainname,source, destination, availableBerths, trainclass,isactive)
Values(@TrainNumber,@Trainname,@Source,@Destination, @availableBerths,@Trainclass,1);
print 'train addded successfully';
end;


create or alter procedure ModifyTrain
@TrainNumber int,@trainName varchar(20),@source varchar(20),@destination varchar(20),@availableBerths int,@trainclass varchar(20)
as
begin
if not exists (select 1 from trains where TrainNumber = @TrainNumber)
begin
print 'Train with this TrainNumber does not exist'
Return
end;
update Trains
set TrainName = @TrainName,source = @source,Destination =@destination,TrainClass = @TrainClass
where TrainNumber = @TrainNumber;
Print 'Train details updated Successfullly';
end;

Drop procedure if exists train;

select * from Trains

-------------------------------------------
---user
create table BookingTickets
(
bookingid int identity(1,1),
trainnumber int references trains(trainnumber),
passengername varchar(50),
class varchar(50),
Berths int
);
INSERT into Bookingtickets(trainnumber, passengername, class, berths)
values
(12345,'gowthami','2a' ,3)

create or alter procedure sp_bookingtickets
(
@trainnumber int, @passengername varchar(50),@class varchar(50), @berths int
)
as
begin
    declare @Available int;
    select @Available = availableBerths from Trains where trainnumber = @trainnumber;
    if @Available >= @berths
    begin
        insert into BookingTickets values (@trainnumber, @passengername, @class,@berths );
        update Trains
        set availableBerths = availableBerths - @berths where trainnumber = @trainnumber;
    end
    else
    begin
        print 'Not Enough berths are available...!!';
    end
end

--drop procedure sp_Cancelticket;

select * from bookingtickets;


CREATE OR ALTER PROCEDURE sp_Cancelticket
    @bid INT
AS
BEGIN
    declare @TrainNo int, @berths int;
-- Get booking details
    select @TrainNo = trainnumber, @berths = Berths from BookingTickets where bookingid = @bid;
 
    delete from BookingTickets where bookingid = @bid;
-- Restore available berths
 
    update Trains
    set availableBerths = availableBerths + @berths
    where trainnumber = @TrainNo;
END;
 
create or alter procedure showalltrains
as
begin
select trainnumber,trainname 
from trains;
end;

create or alter procedure showbooking
as
 begin
 select 
 trainnumber, passengername,class,berths, trainname
 from
 bookingtickets
 join
 trains  on @trainnumber = trainnumber
 end



Select * from Bookingtickets
select * from trains

