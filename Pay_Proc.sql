USE PayRoll;

create proc SpAddEmployeeDetails
(
@id int,
@Name varchar(255),
@Salary int,
@Date Date,
@Gender char(1),
@Address varchar(255),
@PhoneNumber varchar(255),
@Department varchar(255),
@BasicPay float,
@Deductions float,
@TaxablePay float,
@IncomeTax float,
@NetPay float
)
as
begin
insert into employee_payroll values
(
@id, @Name, @Salary, @Date, @Gender, @Address, @PhoneNumber, @Department, @BasicPay, @Deductions, @TaxablePay, @IncomeTax, @NetPay 
)
end
Go