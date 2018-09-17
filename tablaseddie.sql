USE planificacion_db
go
CREATE TABLE dbo.MPL_CorreosPAR
(
    CO_MPL_Correos   int         IDENTITY,
    DE_Corroe        varchar(20) NOT NULL,
    ES_EstadoCorreos varchar(1)  NOT NULL,
    FK_CedulaUsuario varchar(12) NULL,
    CONSTRAINT CKC_ES_EstadoCorreos
    CHECK (ES_EstadoCorreos in ('I','A'))
)
LOCK ALLPAGES
go
IF OBJECT_ID('dbo.MPL_CorreosPAR') IS NOT NULL
    PRINT '<<< CREATED TABLE dbo.MPL_CorreosPAR >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE dbo.MPL_CorreosPAR >>>'
go
