ALTER TRIGGER [dbo].[BCSYS_ATIVO_Update] ON [dbo].[BCSYS_ATIVO] FOR UPDATE,INSERT
AS
BEGIN
       -- Sem contador de linhas afetadas
       SET NOCOUNT ON
       --- Variaveis locais
       DECLARE @ATV_CODIGO varchar(20)
       DECLARE @ATV_DAT_DATAHORA datetime
       DECLARE @ATV_DES_ULT varchar(50)
       -- Obter dados do insert
       SELECT @ATV_CODIGO=ATV_CODIGO,@ATV_DAT_DATAHORA=ATV_DAT_DATAHORA,@ATV_DES_ULT=ATV_DES_ULT FROM INSERTED
       -- Inserir historico
       IF @ATV_DES_ULT<>''
              INSERT INTO BCSYS_ATIVO_HIST (ATV_CODIGO,ATV_DAT_DATAHORA,ATV_DES_ULT) VALUES (@ATV_CODIGO,@ATV_DAT_DATAHORA,@ATV_DES_ULT)
END