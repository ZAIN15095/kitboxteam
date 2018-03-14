ALTER PROC UserAdd
@LastName varchar(50),
@FirstName varchar(50),
@contact varchar(50),
@address varchar(50)
AS
	INSERT INTO tblUser(LastName,FirstName,contact,address)

	VALUES (@LastName,@FirstName,@contact,@address)




