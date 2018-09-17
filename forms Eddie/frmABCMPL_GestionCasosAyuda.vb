Public Class frmABCMPL_GestionCasosAyuda

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
            btnEnviar.Enabled = False
            Me.Text = "Verificación Gerencia - " & Me.Text
        ElseIf varTipoRegistroProgramacion = "A" Then
            btnEnviar.Enabled = False
            Me.Text = "Aprobación Jefatura - " & Me.Text
        ElseIf varTipoRegistroProgramacion = "R" Then
            Me.Text = "Registro - " & Me.Text
        ElseIf varTipoRegistroProgramacion = "S" Then
            Me.Text = "Seguimiento - " & Me.Text
            btnEnviar.Enabled = False
        ElseIf varTipoRegistroProgramacion = "M" Then
            Me.Text = "Modificación - " & Me.Text
            btnEnviar.Enabled = False
        End If
    End Sub
End Class