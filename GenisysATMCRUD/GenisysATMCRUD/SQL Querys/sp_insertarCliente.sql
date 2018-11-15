USE GenisysATM_V2
GO


CREATE PROCEDURE sp_insertarCliente(
	@nombre nvarchar(100),
	@apellido nvarchar(100),
	@identidad char(13),
	@direccion nvarchar(2000),
	@telefono char(9),
	@celular char(9)
)
AS
BEGIN
	INSERT INTO ATM.Cliente(nombres,apellidos,identidad,direccion,telefono,celular)
		VALUES (@nombre,@apellido,@identidad,@direccion,@telefono,@celular)
END