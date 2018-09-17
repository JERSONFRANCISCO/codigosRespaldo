USE planificacion_db
go
CREATE TABLE dbo.MPL_CategoriasCasosAyudaPAR
(
    ID_Categoria     int         IDENTITY,
    DE_Categoria     text        NOT NULL,
    ES_EstadoCorreos varchar(1)  NOT NULL,
    FK_CedulaUsuario varchar(12) NULL
)
LOCK ALLPAGES
go
IF OBJECT_ID('dbo.MPL_CategoriasCasosAyudaPAR') IS NOT NULL
    PRINT '<<< CREATED TABLE dbo.MPL_CategoriasCasosAyudaPAR >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE dbo.MPL_CategoriasCasosAyudaPAR >>>'
go
