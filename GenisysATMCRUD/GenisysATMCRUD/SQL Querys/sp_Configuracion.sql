USE GenisysATM_V2
GO

CREATE PROCEDURE sp_InsertarConfiguracion
(
	@appKey NCHAR(50),
	@valor NCHAR(50),
	@descripcion NVARCHAR(2000)
)
AS
BEGIN
	INSERT INTO ATM.Configuracion(appKey, valor, descripcion)
		VALUES(@appKey, @valor, @descripcion)
END
GO

CREATE PROCEDURE sp_ActualizarConfiguracion(
	@appKey NCHAR(50),
	@appKeyNueva NCHAR(50),
	@valor NCHAR(50),
	@descripcion NVARCHAR(2000)
)
AS
BEGIN
	DECLARE @configuracionId INT

	SELECT @configuracionId = id
	FROM ATM.Configuracion
	WHERE appKey = @appKey

	UPDATE ATM.Configuracion SET appKey = @appKeyNueva, valor = @valor, descripcion = @descripcion
	WHERE id = @configuracionId
END
GO

CREATE PROCEDURE sp_EliminarConfiguracion(
	@appKey NCHAR(50)
)
AS
BEGIN
	DECLARE @configuracionId INT

	SELECT @configuracionId = id
	FROM ATM.Configuracion
	WHERE appKey = @appKey

	DELETE FROM ATM.Configuracion where id = @configuracionId

END
