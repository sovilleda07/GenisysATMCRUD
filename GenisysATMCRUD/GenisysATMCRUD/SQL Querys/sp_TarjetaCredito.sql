USE GenisysATM_V2
GO

CREATE PROCEDURE sp_InsertarTarjetaCredito(
	@descripcion NVARCHAR(100),
	@monto DECIMAL(12,2),
	@limite DECIMAL(12,2),
	@cliente NVARCHAR(100)
)
AS
BEGIN
	DECLARE @clienteId INT

	SELECT @clienteId = id
	FROM ATM.Cliente
	WHERE nombres = @cliente

	INSERT INTO ATM.TarjetaCredito(descripcion, monto, limite, idCliente)
		VALUES(@descripcion, @monto, @limite, @clienteId)
END
GO

CREATE PROCEDURE sp_ActualizarTarjetaCredito(
	@descripcion NVARCHAR(100),
	@descripcionNueva NVARCHAR(100),
	@monto DECIMAL(12,2),
	@limite DECIMAL(12,2),
	@cliente NVARCHAR(100)
)
AS
BEGIN
	DECLARE @clienteId INT,
			@tarjetaId INT

	SELECT @clienteId = id
	FROM ATM.Cliente
	WHERE nombres = @cliente

	SELECT @tarjetaId = id
	FROM ATM.TarjetaCredito
	WHERE descripcion = @descripcion AND idCliente = @clienteId

	UPDATE ATM.TarjetaCredito SET descripcion = @descripcionNueva, monto = @monto, limite = @limite
	WHERE id = @tarjetaId
END
GO

CREATE PROCEDURE sp_EliminarTarjetaCredito(
	@descripcion NVARCHAR(100),
	@cliente NVARCHAR(100)
)
AS
BEGIN
	DECLARE @clienteId INT,
			@tarjetaId INT

	SELECT @clienteId = id
	FROM ATM.Cliente
	WHERE nombres = @cliente

	SELECT @tarjetaId = id
	FROM ATM.TarjetaCredito
	WHERE descripcion = @descripcion AND idCliente = @clienteId

	DELETE FROM ATM.TarjetaCredito WHERE id = @tarjetaId
END
GO