USE GenisysATM_V2
GO

CREATE PROCEDURE sp_InsertarServicioCliente(
	@cliente NVARCHAR(100),
	@servicio NVARCHAR(100),
	@saldo DECIMAL(12,2)
)
AS
BEGIN
	DECLARE @clienteId INT,
			@servicioId INT

	SELECT @clienteId = id
	FROM ATM.Cliente
	WHERE nombres = @cliente

	SELECT @servicioId = id
	FROM ATM.ServicioPublico
	WHERE descripcion = @servicio

	INSERT INTO ATM.ServicioCliente(idCliente, idServicio, saldo)
		VALUES(@clienteId,@servicioId,@saldo)
END
GO

CREATE PROCEDURE sp_ActualizarServicioCliente(
	@cliente NVARCHAR(100),
	@servicio NVARCHAR(100),
	@saldo DECIMAL(12,2)
)
AS
BEGIN
	DECLARE @clienteId INT,
			@servicioId INT,
			@servicioClienteId INT

	SELECT @clienteId = id
	FROM ATM.Cliente
	WHERE nombres = @cliente

	SELECT @servicioId = id
	FROM ATM.ServicioPublico
	WHERE descripcion = @servicio

	SELECT @servicioClienteId = id
	FROM ATM.ServicioCliente
	WHERE idCliente = @clienteId
	AND idServicio = @servicioId

	UPDATE ATM.ServicioCliente SET idCliente = @clienteId, idServicio = @servicioId, saldo = @saldo WHERE id = @servicioClienteId
END
GO

CREATE PROCEDURE sp_EliminarServicioCliente(
	@cliente NVARCHAR(100),
	@servicio NVARCHAR(100)
)
AS
BEGIN
	DECLARE @clienteId INT,
			@servicioId INT,
			@servicioClienteId INT

	SELECT @clienteId = id
	FROM ATM.Cliente
	WHERE nombres = @cliente

	SELECT @servicioId = id
	FROM ATM.ServicioPublico
	WHERE descripcion = @servicio

	SELECT @servicioClienteId = id
	FROM ATM.ServicioCliente
	WHERE idCliente = @clienteId
	AND idServicio = @servicioId

	DELETE FROM ATM.ServicioCliente WHERE id = @servicioClienteId
END
GO
