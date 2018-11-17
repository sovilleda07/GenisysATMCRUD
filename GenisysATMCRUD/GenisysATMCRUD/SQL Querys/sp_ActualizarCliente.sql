USE GenisysATM_V2
GO

ALTER PROCEDURE sp_ActualizarCliente
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