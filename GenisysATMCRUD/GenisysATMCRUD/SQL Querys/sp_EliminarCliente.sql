USE GenisysATM_V2
GO

CREATE PROCEDURE sp_EliminarCliente
(
	@nombre nvarchar(100)
)
AS
BEGIN
	DECLARE @clienteId INT

	SELECT @clienteId = id
	FROM ATM.Cliente
	WHERE nombres = @nombre

	DELETE FROM ATM.Cliente WHERE id = @clienteId
END