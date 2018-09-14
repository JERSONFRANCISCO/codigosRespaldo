Imports System.Windows.Forms

Public Class frmABCMPL_UsuariosPlanificacion
    Inherits EditorBase

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DG_ListadoNotificaciones As System.Windows.Forms.DataGrid

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DG_ListadoNotificaciones = New System.Windows.Forms.DataGrid()
        CType(Me.ErrorABC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sbpABC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpABC.SuspendLayout()
        CType(Me.DG_ListadoNotificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(126, 328)
        Me.btnAceptar.TabIndex = 1
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(263, 328)
        Me.btnSalir.TabIndex = 2
        '
        'sbABC
        '
        Me.sbABC.Location = New System.Drawing.Point(0, 375)
        Me.sbABC.Size = New System.Drawing.Size(501, 20)
        '
        'sbpABC
        '
        Me.sbpABC.Width = 484
        '
        'GrpABC
        '
        Me.GrpABC.Controls.Add(Me.DG_ListadoNotificaciones)
        Me.GrpABC.Location = New System.Drawing.Point(12, 38)
        Me.GrpABC.Size = New System.Drawing.Size(475, 284)
        Me.GrpABC.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(475, 20)
        Me.TextBox1.TabIndex = 17
        '
        'DG_ListadoNotificaciones
        '
        Me.DG_ListadoNotificaciones.DataMember = ""
        Me.DG_ListadoNotificaciones.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DG_ListadoNotificaciones.Location = New System.Drawing.Point(6, 19)
        Me.DG_ListadoNotificaciones.Name = "DG_ListadoNotificaciones"
        Me.DG_ListadoNotificaciones.ReadOnly = True
        Me.DG_ListadoNotificaciones.Size = New System.Drawing.Size(463, 259)
        Me.DG_ListadoNotificaciones.TabIndex = 2
        '
        'frmABCMPL_UsuariosPlanificacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(501, 395)
        Me.Controls.Add(Me.TextBox1)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "frmABCMPL_UsuariosPlanificacion"
        Me.Text = "Mantenimiento Clasificador Funcional"
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnAceptar, 0)
        Me.Controls.SetChildIndex(Me.sbABC, 0)
        Me.Controls.SetChildIndex(Me.GrpABC, 0)
        Me.Controls.SetChildIndex(Me.TextBox1, 0)
        CType(Me.ErrorABC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sbpABC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpABC.ResumeLayout(False)
        CType(Me.DG_ListadoNotificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region " Constructores "
    Public Sub New(ByVal pModo As TModo)
        Me.New()
        Modo = pModo
    End Sub
#End Region

#Region " Variables "

#End Region

    Private Sub frmABCMPL_ClasificadorFuncional_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenarCombos()
        Habilitar()
        ConfigurarTextos()
        comentarios()
        If Modo <> TModo.Agregar Then
            Leer()
        End If
        AsignaEventos()
    End Sub


    Private Sub comentarios()


        Dim ObjBS As New DMG.Dat_MPL_Comentarios

        Dim Clasificador As String
        Dim Modificar As String
        Dim Consultar As String
        Try
            ' Clasificador = ObjBS.CapturaDatos("Clasificador Funcional")

            ' Me.ToolTip1.IsBalloon = True


            ' Me.ToolTip1.SetToolTip(txt_Descripcion, Clasificador)



            'Consultar = ObjBS.CapturaDatos("Consultar")
            'Me.ToolTip2.SetToolTip(btn_Modifica, Consultar)


        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

        End Try



    End Sub


    Public Overrides Sub LlenarCombos()
       
    End Sub

    Public Overrides Sub Habilitar()
        GrpABC.Enabled = (Modo = TModo.Agregar) Or (Modo = TModo.Modificar)
        If GrpABC.Enabled Then
            'Proteger campos llave

        End If
        btnAceptar.Visible = (Modo <> TModo.Consultar)
    End Sub

    Public Overrides Sub Limpiar()
       
    End Sub

    Public Overrides Sub Leer()
        Dim objBS As New DMG.Dat_MPL_Perspectivas()

        Dim v_Descripcion As String
        Dim v_Estado As String

      

        'obtiene valores de tablas relacionadas

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            

            Dim objBS As New DMG.Dat_MPL_Perspectivas()

            AccionTomada = TAccionForma.Aceptar
            Select Case Modo
                Case TModo.Agregar
                    '  objBS.AgregarBD(Ortografia(txt_Descripcion.Text), Mid(cbo_Estado.Text, 1, 1))
                    Me.Close()
                Case TModo.Borrar
                    ' objBS.BorrarBD(num_CodigoClasificacion.Text)
                    Me.Close()
                Case TModo.Modificar
                    ' objBS.ModificarBD(num_CodigoClasificacion.Text, Ortografia(txt_Descripcion.Text), Mid(cbo_Estado.Text, 1, 1))
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        AccionTomada = TAccionForma.Cancelar
        Me.Close()
    End Sub

    Public Overrides Sub AsignaEventos()
        Try
            'agrega eventos para los controles que exigen valores
            'tambi�n el evento Enter para marcar el contenido de los textbox
            'AddHandler num_CodigoClasificacion.Enter, AddressOf MyBase.Evento_Enter
            'AddHandler num_CodigoClasificacion.Validating, AddressOf MyBase.Evento_Validating
            'AddHandler num_CodigoClasificacion.Validated, AddressOf MyBase.Evento_Validated
            'AddHandler txt_Descripcion.Enter, AddressOf MyBase.Evento_Enter
            'AddHandler txt_Descripcion.Validating, AddressOf MyBase.Evento_Validating
            'AddHandler txt_Descripcion.Validated, AddressOf MyBase.Evento_Validated
            'AddHandler cbo_Estado.Validating, AddressOf MyBase.Evento_Validating
            'AddHandler cbo_Estado.Validated, AddressOf MyBase.Evento_Validated
        Catch
        End Try
    End Sub



#Region " Utilitarios "

#End Region


    Private Sub cbo_Estado_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class
