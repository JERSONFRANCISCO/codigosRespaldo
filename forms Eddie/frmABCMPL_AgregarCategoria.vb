Public Class frmABCMPL_AgregarCategoria

#Region "Variables"
    Public varTipoRegistroProgramacion As String = ""
#End Region

    Private Sub frmABCMPL_ListaProgramacionProceso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenarCombos()
        Habilitar()
        ConfigurarTextos()
        If Modo <> TModo.Agregar Then
            Leer()
        End If
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
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
      
    End Sub
    Private Sub GuíaParaLaFormulaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuíaParaLaFormulaciónToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start(sRutaPrincipal & "\documentos\ArchivosPlaneacion\General\" & "GUIA_PARA_LA_FORMULACIÓN_POI.pdf")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub PictureBox_Manual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            System.Diagnostics.Process.Start(sRutaPrincipal & "\documentos\ArchivosPlaneacion\General\" & "Manual de Usuario - Sistema Planeación Estratégica - Perfil Usuario Enlace.pdf")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class
