USE GenisysATM_V2
GO

CREATE PROCEDURE sp_InsertarCuentaCliente(
	@numero CHAR(14),
	@cliente NVARCHAR(100),
	@saldo DECIMAL(12,2),
	@pin CHAR(4)
)
AS
BEGIN
	DECLARE @clienteId INT

	SELECT @clienteId = id
	FROM ATM.Cliente
	WHERE nombres = @cliente

	INSERT INTO ATM.CuentaCliente(numero, idCliente, saldo, pin)
		VALUES(@numero, @clienteId, @saldo, @pin)
END
GO

CREATE PROCEDURE sp_ActualizarCuentaCliente(
	@numero CHAR(14),
	@numeroNuevo CHAR(14),
	@cliente NVARCHAR(100),
	@saldo DECIMAL(12,2),
	@pin CHAR(4)
)
AS
BEGIN
	DECLARE @clienteId INT

	SELECT @clienteId = id
	FROM ATM.Cliente
	WHERE nombres = @cliente

	UPDATE ATM.CuentaCliente SET numero = @numeroNuevo, saldo = @saldo, pin = @pin
	WHERE numero = @numero AND idCliente = @clienteId
END
GO

CREATE PROCEDURE sp_EliminarCuentaCliente(
	@numero CHAR(14),
	@cliente NVARCHAR(100)
)
AS
BEGIN
	DECLARE @clienteId INT

	SELECT @clienteId = id
	FROM ATM.Cliente
	WHERE nombres = @cliente

	DELETE FROM ATM.CuentaCliente WHERE numero = @numero AND idCliente = @clienteId
END
GO

