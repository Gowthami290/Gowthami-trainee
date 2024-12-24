CREATE DATABASE RailwayReservation
use RailwayReservation

create table Train
(
trainnumber int primary key,
trainName varchar(20),
source varchar(20),
destination varchar(20),
availableBerths int,
trainClass varchar(20),
IsActive bit
)
insert into train (trainnumber,trainname,source,destination,availableBerths, trainClass, IsActive)
values
(12345,'Bidhar express','Machiliptnam','Hyderabad',50,'2A',1),
(12346,'Godavari express','vizag','machiliptnam',20,'1A',1);
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

create or alter Procedure deleteTrain
Drop procedure if exists train;

select * from Trains
-------------------------------------------
---user
create table BookingTickets
(
trainnumber int not null,
foreign key (trainnumber)references trains(trainnumber),
passengername varchar(50),
class varchar(50),
Berths int
);
INSERT into Bookingtickets(trainnumber, passengername, class, berths)
values
(111,22,'gowthami','2a' ,33)

create or alter procedure sp_bookingtickets
(
@trainnumber int, @passengername varchar(50),@class varchar(50), @berths int
)
as
begin
insert into Bookingtickets(trainnumber,passengername,class,berths)
values(@trainnumber,@passengername,@class,@berths);
--select 'Booking successfull'as message,  lastinsertid () as bookingid;
end
--drop procedure sp_Cancelticket;

select * from bookingtickets;
CREATE OR ALTER PROCEDURE sp_Cancelticket
    @trainnumber INT
AS
BEGIN
    DECLARE @Berths INT;
    DECLARE @Class VARCHAR(50);
  --  DECLARE @TrainNumber INT;
    DECLARE @AvailableSeats INT;
 
    -- Retrieve details about the booking
    SELECT
        @Berths = Berths,
        @Class = Class,
        @TrainNumber = TrainNumber
    FROM bookingtickets
    WHERE trainnumber = @trainnumber;
 
    -- Check if the booking exists
    IF @TrainNumber IS NOT NULL
    BEGIN
        -- Retrieve available berths for the train
        SELECT @AvailableSeats = availableBerths
        FROM trains
        WHERE TrainNumber = @TrainNumber;
 
        -- Update available seats in the trains table
        UPDATE trains
        SET availableBerths = @AvailableSeats + @Berths
        WHERE TrainNumber = @TrainNumber;
 
        -- Delete the booking from bookingtickets table
        DELETE FROM bookingtickets
        WHERE trainnumber = @trainnumber;
 
        PRINT 'Ticket canceled successfully';
    END
    ELSE
    BEGIN
        PRINT 'Booking not found';
    END
END;
 
create or alter procedure showalltrains
as
begin
select trainnumber,trainname
from train;
end;
create or alter procedure showbooking
as
 begin
 select 
 trainnumber, passengername,class,berths, trainname
 from
 bookingtickets
 join
 train  on trainnumber = trainnumber
 end



Select * from Bookingtickets
select * from trains