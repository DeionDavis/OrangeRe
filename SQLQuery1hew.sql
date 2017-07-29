

CREATE PROC Proc_Orange_LoginSelect 'rada','rad1234','user'
(
	@username varchar(50),
	@password varchar(50),
	@UserType varchar(50)
)
As
BEGIN
SELECT  * FROM Login
WHERE Username=@username and Password=@password and UserType=@UserType
END
