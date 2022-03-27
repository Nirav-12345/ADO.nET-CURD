create procedure SpAddEmployeeDetails2
(
@EmployeeName varchar(255),
@phonenumber varchar(255),

@Address varchar(255),

@department varchar(255),

@Gender char(1),

@basicpay float,

@deductions float,

@Taxablepay float,

@Tax float,

@netPay float,

@city varchar(255),

@statdate Date,


@country varchar(255)





)



as

	begin

	insert into employee_payroll4 values(@EmployeeName,@phonenumber,@Address,@department,@Gender,@basicpay,@deductions,@Taxablepay,@Tax,@netPay,@city,@statdate,@country)

	End