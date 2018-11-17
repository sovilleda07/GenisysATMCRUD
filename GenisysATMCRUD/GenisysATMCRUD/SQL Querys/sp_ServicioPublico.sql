USE GenisysATM_V2
GO

CREATE PROCEDURE sp_InsertarServicioP(
	@descripcion NVARCHAR(100)
)
AS
BEGIN
	INSERT INTO ATM.ServicioPublico(descripcion)
		VALUES(@descripcion)
END
GO

CREATE PROCEDURE sp_ActualizarServicioP(
	@descripcion NVARCHAR(100),
	@descripcionNueva NVARCHAR(100)
)
AS
BEGIN
	DECLARE @servicioId INT

	SELECT @servicioId = id
	FROM ATM.ServicioPublico
	WHERE descripcion = @descripcion

	UPDATE ATM.ServicioPublico SET descripcion = @descripcionNueva
	WHERE id = @servicioId

END
GO

CREATE PROCEDURE sp_EliminarServicioP
(
	@descripcion NVARCHAR(100)
)
AS
BEGIN
	DECLARE @servicioId INT

	SELECT @servicioId = id
	FROM ATM.ServicioPublico
	WHERE descripcion = @descripcion

	DELETE FROM ATM.ServicioPublico WHERE id = @servicioId
END
GO