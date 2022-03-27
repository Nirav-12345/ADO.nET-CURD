create procedure SpAddEmployeeDetails4

(
@EmployeeId int,
@EmployeeFirstName varchar(255),
@EmployeeSecondName varchar(255),
@Address varchar(255),
@city varchar(255),
@state varchar(255),
@zip varchar(255),
@email varchar(255)

)

as

begin
insert into Address_bok  values(@EmployeeId,@EmployeeFirstName,@EmployeeSecondName,@Address,@city,@state,@zip,@email)

	End