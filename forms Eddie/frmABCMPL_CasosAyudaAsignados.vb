Public Class frmABCMPL_CasosAyudaAsignados

#Region "Variables"
    Public varTipoRegistroProgramacion As String = ""
#End Region

    Private Sub RefrescarGrid()
        Dim ObjBS As New DMG.Dat_MPL_Programacion
        Dim Ds As DataSet
        Try
            Ds = ObjBS.TraerListaPlaneacionObjBD(Me.Usuario, varTipoRegistroProgramacion)
            If Ds.Tables(0).Rows.Count > 0 Then
                DG_ListadoProgramacion.DataSource = Nothing
                DG_ListadoProgramacion.DataSource = Ds.Tables(0)
            Else
                DG_ListadoProgramacion.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub frmABCMPL_ListaProgramacionProceso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenarCombos()
        Habilitar()
        ConfigurarTextos()
        If Modo <> TModo.Agregar Then
            Leer()
        End If
        RefrescarGrid()
        AsignaEventos()
    End Sub

    Public Overrides Sub Habilitar()
        If varTipoRegistroProgramacion = "V" Then
            btnAceptar.Enabled = False
            Me.Text = "Verificación Gerencia - " & Me.Text
        ElseIf varTipoRegistroProgramacion = "A" Then
            btnAceptar.Enabled = False
            Me.Text = "Aprobación Jefatura - " & Me.Text
        ElseIf varTipoRegistroProgramacion = "R" Then
            Me.Text = "Registro - " & Me.Text
        ElseIf varTipoRegistroProgramacion = "S" Then
            Me.Text = "Seguimiento - " & Me.Text
            btnAceptar.Enabled = False
        ElseIf varTipoRegistroProgramacion = "M" Then
            Me.Text = "Modificación - " & Me.Text
            btnAceptar.Enabled = False
        End If
    End Sub

    Private Sub btn_ObjetivosOperativos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim varCodigoProgramacion As Integer = 0
        Dim varCodigoPrograma As Integer = 0
        Dim varCodigoUnidad As Integer = 0
        Dim varEstadoProgramacion As String = ""
        If DG_ListadoProgramacion.CurrentRowIndex = -1 Then
            Exit Sub
        End If
        Dim ObjBS As New DMG.Dat_MPL_Programacion
        Try
            varCodigoProgramacion = CInt(Mid(CStr(DG_ListadoProgramacion.Item(DG_ListadoProgramacion.CurrentRowIndex, 0)), 1, 2))
            varCodigoPrograma = CInt(Mid(CStr(DG_ListadoProgramacion.Item(DG_ListadoProgramacion.CurrentRowIndex, 0)), 3, 2))
            varCodigoUnidad = CInt(Mid(CStr(DG_ListadoProgramacion.Item(DG_ListadoProgramacion.CurrentRowIndex, 0)), 5, 6))
            varEstadoProgramacion = CStr(DG_ListadoProgramacion.Item(DG_ListadoProgramacion.CurrentRowIndex, 3))

            'If ObjBS.VerificacionUnidadResponsableBD(varCodigoPrograma, varCodigoUnidad) = False Then
            '    MsgBox("No se encuentra como responsable para la Unidad Administrativa, favor comunicarse con el Departamento de Planificación.", MsgBoxStyle.Exclamation, "Mensaje de Aviso")
            '    Exit Sub
            'End If

            Me.Hide()
            Dim Ventana As New frmABCMPL_ListaObjetivosInstitucionales
            If ObjBS.VerificacionUnidadResponsableBD(varCodigoPrograma, varCodigoUnidad) = True Then
                Ventana.Modo = TModo.Agregar
            Else
                Ventana.Modo = TModo.Consultar
            End If
            Ventana.varCodigoInstitucion = 1
            Ventana.varCodigoProgramacion = varCodigoProgramacion
            Ventana.varCodigoPrograma = varCodigoPrograma
            Ventana.varCodigoUnidad = varCodigoUnidad
            Ventana.varEstadoProgramacion = Mid(varEstadoProgramacion, 1, 1)
            Ventana.varTipoRegistroProgramacion = varTipoRegistroProgramacion
            Ventana.ShowDialog()
            Me.Show()
            RefrescarGrid()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, "Error")
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            Dim Ventana As New frmABCMPL_GestionCasosAyuda
            Ventana.Modo = TModo.Agregar
            Ventana.ShowDialog()
            If Ventana.AccionTomada = TAccionForma.Aceptar Then
                RefrescarGrid()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim varCodigoProgramacion As Integer = 0
        Dim varCodigoPrograma As Integer = 0
        Dim varCodigoUnidad As Integer = 0
        Dim varEstadoProgramacion As String = ""
        Dim VerificaProgramacion As String = Nothing
        If DG_ListadoProgramacion.CurrentRowIndex = -1 Then
            Exit Sub
        End If
        Try
            Dim objProgramacion As New DMG.Dat_MPL_Programacion
            Dim ObjBS As New DMG.Dat_MPL_DevolverPlaneacion
            varCodigoProgramacion = CInt(Mid(CStr(DG_ListadoProgramacion.Item(DG_ListadoProgramacion.CurrentRowIndex, 0)), 1, 2))
            varCodigoPrograma = CInt(Mid(CStr(DG_ListadoProgramacion.Item(DG_ListadoProgramacion.CurrentRowIndex, 0)), 3, 2))
            varCodigoUnidad = CInt(Mid(CStr(DG_ListadoProgramacion.Item(DG_ListadoProgramacion.CurrentRowIndex, 0)), 5, 6))
            varEstadoProgramacion = CStr(DG_ListadoProgramacion.Item(DG_ListadoProgramacion.CurrentRowIndex, 3))
            If Mid(varEstadoProgramacion, 1, 1) = "H" Then
                MsgBox("El Plan Estrátegico se encuentra en estado " & varEstadoProgramacion & ", no se permite realizar cambios en la programación.", MsgBoxStyle.Exclamation, "Cambio en la Programación")
            Else
                If varTipoRegistroProgramacion = "M" Then
                    VerificaProgramacion = objProgramacion.VerificaPeriodoModificacionBD(varCodigoProgramacion, varCodigoPrograma, varCodigoUnidad)
                    If VerificaProgramacion Is Nothing Then
                        If Mid(varEstadoProgramacion, 1, 1) = "F" Then
                            If MsgBox("Desea iniciar con la modificación.?", MsgBoxStyle.YesNo, "Modificación") = MsgBoxResult.No Then
                                Exit Sub
                            End If
                            VerificaProgramacion = ObjBS.CrearHistoricoPlaneacionPlanBD(varCodigoProgramacion, varCodigoPrograma, varCodigoUnidad)
                            If VerificaProgramacion Is Nothing Then
                                ObjBS.ModificacionPlaneacionPlanBD(varCodigoProgramacion, varCodigoPrograma, varCodigoUnidad)
                                MsgBox("Se habilitó el proceso de modificación.", MsgBoxStyle.Exclamation, "Modificación")
                                RefrescarGrid()
                                Exit Sub
                            Else
                                'MsgBox(VerificaProgramacion, MsgBoxStyle.Information, "Mensaje Aviso")
                                If Mid(varEstadoProgramacion, 1, 1) = "F" Then
                                    Dim Ventana As New frmABCMPL_ProgramacionProceso
                                    Ventana.Modo = TModo.Modificar
                                    Ventana.varCodigoProgramacion = varCodigoProgramacion
                                    Ventana.varCodigoPrograma = varCodigoPrograma
                                    Ventana.varCodigoUnidad = varCodigoUnidad
                                    Ventana.ShowDialog()
                                    If Ventana.AccionTomada = TAccionForma.Aceptar Then
                                        RefrescarGrid()
                                    End If
                                Else
                                    MsgBox("El Plan Estrátegico se encuentra en estado " & varEstadoProgramacion & ", no se permite realizar cambios en la programación.", MsgBoxStyle.Exclamation, "Cambio en la Programación")
                                End If
                            End If
                        Else
                            MsgBox("El Plan Estrátegico se encuentra en estado " & varEstadoProgramacion & ", no se permite realizar cambios en la programación.", MsgBoxStyle.Exclamation, "Cambio en la Programación")
                        End If
                    Else
                        MsgBox(VerificaProgramacion, MsgBoxStyle.Information, "Mensaje Aviso")
                    End If
                Else
                    VerificaProgramacion = objProgramacion.VerificaPeriodoFormulacionBD(varCodigoProgramacion, varCodigoPrograma, varCodigoUnidad)
                    If VerificaProgramacion Is Nothing Then
                        If Mid(varEstadoProgramacion, 1, 1) = "F" Then
                            Dim Ventana As New frmABCMPL_ProgramacionProceso
                            Ventana.Modo = TModo.Modificar
                            Ventana.varCodigoProgramacion = varCodigoProgramacion
                            Ventana.varCodigoPrograma = varCodigoPrograma
                            Ventana.varCodigoUnidad = varCodigoUnidad
                            Ventana.ShowDialog()
                            If Ventana.AccionTomada = TAccionForma.Aceptar Then
                                RefrescarGrid()
                            End If
                        Else
                            MsgBox("El Plan Estrátegico se encuentra en estado " & varEstadoProgramacion & ", no se permite realizar cambios en la programación.", MsgBoxStyle.Exclamation, "Cambio en la Programación")
                        End If
                    Else
                        MsgBox(VerificaProgramacion, MsgBoxStyle.Information, "Mensaje Aviso")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, "Error")
        End Try
    End Sub

    Private Sub btn_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim varCodigoProgramacion As Integer = 0
        Dim varCodigoPrograma As Integer = 0
        Dim varCodigoUnidad As Integer = 0
        If DG_ListadoProgramacion.CurrentRowIndex = -1 Then
            Exit Sub
        End If
        Try
            varCodigoProgramacion = CInt(Mid(CStr(DG_ListadoProgramacion.Item(DG_ListadoProgramacion.CurrentRowIndex, 0)), 1, 2))
            varCodigoPrograma = CInt(Mid(CStr(DG_ListadoProgramacion.Item(DG_ListadoProgramacion.CurrentRowIndex, 0)), 3, 2))
            varCodigoUnidad = CInt(Mid(CStr(DG_ListadoProgramacion.Item(DG_ListadoProgramacion.CurrentRowIndex, 0)), 5, 6))

            Dim Ventana As New frmABCMPL_ProgramacionProceso
            Ventana.Modo = TModo.Consultar
            Ventana.varCodigoProgramacion = varCodigoProgramacion
            Ventana.varCodigoPrograma = varCodigoPrograma
            Ventana.varCodigoUnidad = varCodigoUnidad
            Ventana.ShowDialog()
            If Ventana.AccionTomada = TAccionForma.Aceptar Then
                RefrescarGrid()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, "Error")
        End Try
    End Sub

    Private Sub GuíaParaLaFormulaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuíaParaLaFormulaciónToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start(sRutaPrincipal & "\documentos\ArchivosPlaneacion\General\" & "GUIA_PARA_LA_FORMULACIÓN_POI.pdf")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MatrixToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MatrixToolStripMenuItem.Click
        Dim varCodigoProgramacion As Integer = 0
        Dim varCodigoPrograma As Integer = 0
        Dim varCodigoUnidad As Integer = 0
        If DG_ListadoProgramacion.CurrentRowIndex = -1 Then
            Exit Sub
        End If
        Try
            varCodigoProgramacion = CInt(Mid(CStr(DG_ListadoProgramacion.Item(DG_ListadoProgramacion.CurrentRowIndex, 0)), 1, 2))
            varCodigoPrograma = CInt(Mid(CStr(DG_ListadoProgramacion.Item(DG_ListadoProgramacion.CurrentRowIndex, 0)), 3, 2))
            varCodigoUnidad = CInt(Mid(CStr(DG_ListadoProgramacion.Item(DG_ListadoProgramacion.CurrentRowIndex, 0)), 5, 6))

            Dim VentanaReporte As New ReportesMPL(ReportesMPL.MPL_RptProgramacionPlanTrabajo, ".", sODBCServidor, Me.BaseDatos, Me.Usuario, Me.Password)
            VentanaReporte.ParamCodigoProgramacion = varCodigoProgramacion
            VentanaReporte.ParamCodigoPrograma = varCodigoPrograma
            VentanaReporte.ParamCodigoUE = varCodigoUnidad
            VentanaReporte.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, "Error")
        End Try
    End Sub

    Private Sub PictureBox_Manual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            System.Diagnostics.Process.Start(sRutaPrincipal & "\documentos\ArchivosPlaneacion\General\" & "Manual de Usuario - Sistema Planeación Estratégica - Perfil Usuario Enlace.pdf")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MatrizDeDesempeñoConPesoTrimestralDelPeríodoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MatrizDeDesempeñoConPesoTrimestralDelPeríodoToolStripMenuItem.Click
        Dim varCodigoProgramacion As Integer = 0
        Dim varCodigoPrograma As Integer = 0
        Dim varCodigoUnidad As Integer = 0

        If DG_ListadoProgramacion.CurrentRowIndex = -1 Then
            Exit Sub
        End If
        Try
            varCodigoProgramacion = CInt(Mid(CStr(DG_ListadoProgramacion.Item(DG_ListadoProgramacion.CurrentRowIndex, 0)), 1, 2))
            varCodigoPrograma = CInt(Mid(CStr(DG_ListadoProgramacion.Item(DG_ListadoProgramacion.CurrentRowIndex, 0)), 3, 2))
            varCodigoUnidad = CInt(Mid(CStr(DG_ListadoProgramacion.Item(DG_ListadoProgramacion.CurrentRowIndex, 0)), 5, 6))


            Dim VentanaReporte As New ReportesMPL(ReportesMPL.MPL_RptProgramacionPlanTrabajoPesoFormulacion, ".", sODBCServidor, Me.BaseDatos, Me.Usuario, Me.Password)
            VentanaReporte.ParamCodigoProgramacion = varCodigoProgramacion
            VentanaReporte.ParamCodigoPrograma = varCodigoPrograma
            VentanaReporte.ParamCodigoUE = varCodigoUnidad


            VentanaReporte.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, "Error")
        End Try
    End Sub
End Class
