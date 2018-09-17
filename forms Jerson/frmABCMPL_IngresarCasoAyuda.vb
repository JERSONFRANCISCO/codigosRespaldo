Imports System.Windows.Forms

Public Class frmABCMPL_IngresarCasoAyuda
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents lbl_Descripcion As System.Windows.Forms.Label
    Friend WithEvents txt_Descripcion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Estado As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbo_Estado As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lbl_Descripcion = New System.Windows.Forms.Label()
        Me.txt_Descripcion = New System.Windows.Forms.TextBox()
        Me.lbl_Estado = New System.Windows.Forms.Label()
        Me.cbo_Estado = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.ErrorABC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sbpABC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpABC.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(142, 370)
        Me.btnAceptar.TabIndex = 1
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(270, 370)
        Me.btnSalir.TabIndex = 2
        '
        'sbABC
        '
        Me.sbABC.Location = New System.Drawing.Point(0, 409)
        Me.sbABC.Size = New System.Drawing.Size(475, 22)
        '
        'sbpABC
        '
        Me.sbpABC.Width = 458
        '
        'GrpABC
        '
        Me.GrpABC.Controls.Add(Me.Label4)
        Me.GrpABC.Controls.Add(Me.Label3)
        Me.GrpABC.Controls.Add(Me.Label2)
        Me.GrpABC.Controls.Add(Me.Label1)
        Me.GrpABC.Controls.Add(Me.lbl_Descripcion)
        Me.GrpABC.Controls.Add(Me.txt_Descripcion)
        Me.GrpABC.Controls.Add(Me.lbl_Estado)
        Me.GrpABC.Controls.Add(Me.cbo_Estado)
        Me.GrpABC.Location = New System.Drawing.Point(12, 12)
        Me.GrpABC.Size = New System.Drawing.Size(464, 352)
        Me.GrpABC.TabIndex = 0
        '
        'lbl_Descripcion
        '
        Me.lbl_Descripcion.AutoSize = True
        Me.lbl_Descripcion.Location = New System.Drawing.Point(37, 187)
        Me.lbl_Descripcion.Name = "lbl_Descripcion"
        Me.lbl_Descripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbl_Descripcion.TabIndex = 2
        Me.lbl_Descripcion.Text = "Descripción"
        '
        'txt_Descripcion
        '
        Me.txt_Descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Descripcion.Location = New System.Drawing.Point(39, 212)
        Me.txt_Descripcion.MaxLength = 255
        Me.txt_Descripcion.Multiline = True
        Me.txt_Descripcion.Name = "txt_Descripcion"
        Me.txt_Descripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Descripcion.Size = New System.Drawing.Size(373, 134)
        Me.txt_Descripcion.TabIndex = 2
        '
        'lbl_Estado
        '
        Me.lbl_Estado.AutoSize = True
        Me.lbl_Estado.Location = New System.Drawing.Point(36, 127)
        Me.lbl_Estado.Name = "lbl_Estado"
        Me.lbl_Estado.Size = New System.Drawing.Size(124, 13)
        Me.lbl_Estado.TabIndex = 4
        Me.lbl_Estado.Text = "Selecione una categoría"
        '
        'cbo_Estado
        '
        Me.cbo_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Estado.Location = New System.Drawing.Point(39, 153)
        Me.cbo_Estado.Name = "cbo_Estado"
        Me.cbo_Estado.Size = New System.Drawing.Size(373, 21)
        Me.cbo_Estado.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Fecha:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(121, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(121, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "."
        '
        'frmABCMPL_IngresarCasoAyuda
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(475, 431)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "frmABCMPL_IngresarCasoAyuda"
        Me.Text = "Mantenimiento Clasificador Funcional"
        CType(Me.ErrorABC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sbpABC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpABC.ResumeLayout(False)
        Me.GrpABC.PerformLayout()
        Me.ResumeLayout(False)

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

        AsignaEventos()
    End Sub


    Private Sub comentarios()


        Dim ObjBS As New DMG.Dat_MPL_Comentarios

        Dim Clasificador As String
        Dim Modificar As String
        Dim Consultar As String
        Try
            Clasificador = ObjBS.CapturaDatos("Clasificador Funcional")
            Me.ToolTip1.IsBalloon = True
            Me.ToolTip1.SetToolTip(txt_Descripcion, Clasificador)


        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

        End Try



    End Sub


    Public Overrides Sub LlenarCombos()
        cbo_Estado.Items.Clear()
        cbo_Estado.Items.Add("A - Activo")
        cbo_Estado.Items.Add("I - Inactivo")
    End Sub

    Public Overrides Sub Habilitar()
      
    End Sub

    Public Overrides Sub Limpiar()
      
    End Sub

    Public Overrides Sub Leer()
        Dim objBS As New DMG.Dat_MPL_Perspectivas()

        Dim v_Descripcion As String
        Dim v_Estado As String

        ' num_CodigoClasificacion.Text = ListaValores.Item(1)

        ' objBS.TraerRegistroBD(num_CodigoClasificacion.Text, v_Descripcion, v_Estado)

        txt_Descripcion.Text = v_Descripcion
        AsignaValorCombo(cbo_Estado, v_Estado)

        'obtiene valores de tablas relacionadas

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            If txt_Descripcion.Text = "" Then
                ErrorABC.SetError(txt_Descripcion, mensajeInsert)
                Exit Sub
            End If
            If cbo_Estado.Text = "" Then
                ErrorABC.SetError(cbo_Estado, mensajeInsert)
                Exit Sub
            End If

            Dim objBS As New DMG.Dat_MPL_Perspectivas()

            AccionTomada = TAccionForma.Aceptar
            Select Case Modo
                Case TModo.Agregar
                    '   objBS.AgregarBD(Ortografia(txt_Descripcion.Text), Mid(cbo_Estado.Text, 1, 1))
                    Me.Close()
                Case TModo.Borrar
                    '  objBS.BorrarBD(num_CodigoClasificacion.Text)
                    Me.Close()
                Case TModo.Modificar
                    '    objBS.ModificarBD(num_CodigoClasificacion.Text, Ortografia(txt_Descripcion.Text), Mid(cbo_Estado.Text, 1, 1))
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


    Private Sub cbo_Estado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Estado.SelectedIndexChanged

    End Sub
End Class
