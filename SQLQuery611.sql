create database payroll_service4


create table employee_payroll4
(
EmplyeeId int identity,

EmployeeName varchar(255),

Addess varchar(255),

PhoneNumber varchar(255),

Department varchar(255),

Gender varchar(1),

BasicPay float,

Deductions float,

TaxablePay float,

Tax float,

NetPay float,

startDate Date,

city varchar(255),

Country varchar(255)


)



select * from employee_payroll4