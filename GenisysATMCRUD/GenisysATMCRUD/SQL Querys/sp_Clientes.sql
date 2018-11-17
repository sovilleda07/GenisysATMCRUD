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
GO

USE GenisysATM_V2
GO

CREATE PROCEDURE sp_ActualizarCliente
(
	@nombre nvarchar(100),
	@apellido nvarchar(100),
	@identidad char(13),
	@direccion nvarchar(2000),
	@telefono char(9),
	@celular char(9)
)
AS
BEGIN
	UPDATE ATM.Cliente SET nombres = @nombre, apellidos = @apellido, direccion = @direccion, telefono = @telefono, celular = @celular
	WHERE identidad = @identidad
END
GO

CREATE PROCEDURE sp_EliminarCliente
(
	@nombre nvarchar(100),
	@identidad char(13)
)
AS
BEGIN
	DECLARE @clienteId INT

	SELECT @clienteId = id
	FROM ATM.Cliente
	WHERE nombres = @nombre AND identidad = @identidad

	DELETE FROM ATM.Cliente WHERE id = @clienteId
END
GO