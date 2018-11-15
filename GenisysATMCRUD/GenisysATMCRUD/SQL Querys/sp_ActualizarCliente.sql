USE GenisysATM_V2
GO

CREATE PROCEDURE ActualizarCliente
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
	DECLARE @clienteId INT

	SELECT @clienteId = id
	FROM ATM.Cliente
	WHERE nombres = @nombre

	UPDATE ATM.Cliente SET nombres = @nombre, apellidos = @apellido, identidad = @identidad, direccion = @direccion, telefono = @telefono, celular = @celular
	WHERE id = @clienteId
END