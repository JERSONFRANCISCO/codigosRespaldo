Imports System.Windows.Forms

Public Class frmABCMPL_AgregarCorreo
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
    Friend WithEvents lbl_CodigoClasificacion As System.Windows.Forms.Label
    Friend WithEvents num_CodigoClasificacion As NumericTextBox.NumericTextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lbl_CodigoClasificacion = New System.Windows.Forms.Label()
        Me.num_CodigoClasificacion = New NumericTextBox.NumericTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.ErrorABC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sbpABC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpABC.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(101, 253)
        Me.btnAceptar.TabIndex = 1
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(229, 253)
        Me.btnSalir.TabIndex = 2
        '
        'sbABC
        '
        Me.sbABC.Location = New System.Drawing.Point(0, 299)
        Me.sbABC.Size = New System.Drawing.Size(416, 22)
        '
        'sbpABC
        '
        Me.sbpABC.Width = 478
        '
        'GrpABC
        '
        Me.GrpABC.Controls.Add(Me.TextBox1)
        Me.GrpABC.Controls.Add(Me.LinkLabel1)
        Me.GrpABC.Controls.Add(Me.GroupBox1)
        Me.GrpABC.Controls.Add(Me.lbl_CodigoClasificacion)
        Me.GrpABC.Controls.Add(Me.num_CodigoClasificacion)
        Me.GrpABC.Location = New System.Drawing.Point(12, 12)
        Me.GrpABC.Size = New System.Drawing.Size(388, 235)
        Me.GrpABC.TabIndex = 0
        '
        'lbl_CodigoClasificacion
        '
        Me.lbl_CodigoClasificacion.AutoSize = True
        Me.lbl_CodigoClasificacion.Location = New System.Drawing.Point(57, 22)
        Me.lbl_CodigoClasificacion.Name = "lbl_CodigoClasificacion"
        Me.lbl_CodigoClasificacion.Size = New System.Drawing.Size(40, 13)
        Me.lbl_CodigoClasificacion.TabIndex = 0
        Me.lbl_CodigoClasificacion.Text = "Código"
        '
        'num_CodigoClasificacion
        '
        Me.num_CodigoClasificacion.Decimals = False
        Me.num_CodigoClasificacion.DecimalsLength = 0
        Me.num_CodigoClasificacion.Location = New System.Drawing.Point(103, 19)
        Me.num_CodigoClasificacion.MaxLength = 52
        Me.num_CodigoClasificacion.Name = "num_CodigoClasificacion"
        Me.num_CodigoClasificacion.Negatives = True
        Me.num_CodigoClasificacion.ReadOnly = True
        Me.num_CodigoClasificacion.Size = New System.Drawing.Size(73, 20)
        Me.num_CodigoClasificacion.TabIndex = 0
        Me.num_CodigoClasificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(60, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(269, 100)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estado"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(57, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(55, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Activo"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(57, 56)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(63, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Inactivo"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(57, 55)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(103, 13)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Usuarios del sistema"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(60, 82)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(269, 20)
        Me.TextBox1.TabIndex = 7
        '
        'frmABCMPL_AgregarCorreo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(416, 321)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "frmABCMPL_AgregarCorreo"
        Me.Text = "Mantenimiento Clasificador Funcional"
        CType(Me.ErrorABC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sbpABC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpABC.ResumeLayout(False)
        Me.GrpABC.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
            '   Clasificador = ObjBS.CapturaDatos("Clasificador Funcional")
            '   Me.ToolTip1.IsBalloon = True
            '   Me.ToolTip1.SetToolTip(txt_Descripcion, Clasificador)



            'Consultar = ObjBS.CapturaDatos("Consultar")
            'Me.ToolTip2.SetToolTip(btn_Modifica, Consultar)


        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

        End Try



    End Sub


    Public Overrides Sub LlenarCombos()
        ' cbo_Estado.Items.Clear()
        ' cbo_Estado.Items.Add("A - Activo")
        ' cbo_Estado.Items.Add("I - Inactivo")
    End Sub

    Public Overrides Sub Habilitar()
        GrpABC.Enabled = (Modo = TModo.Agregar) Or (Modo = TModo.Modificar)
        If GrpABC.Enabled Then
            'Proteger campos llave
            num_CodigoClasificacion.Enabled = (Modo = TModo.Agregar)
        End If
        btnAceptar.Visible = (Modo <> TModo.Consultar)
    End Sub

    Public Overrides Sub Limpiar()
        num_CodigoClasificacion.Text = ""
        '  txt_Descripcion.Text = ""
        '  cbo_Estado.SelectedIndex = -1
    End Sub

    Public Overrides Sub Leer()
        Dim objBS As New DMG.Dat_MPL_Perspectivas()

        Dim v_Descripcion As String
        Dim v_Estado As String

        num_CodigoClasificacion.Text = ListaValores.Item(1)

        objBS.TraerRegistroBD(num_CodigoClasificacion.Text, v_Descripcion, v_Estado)

        ' txt_Descripcion.Text = v_Descripcion
        ' AsignaValorCombo(cbo_Estado, v_Estado)

        'obtiene valores de tablas relacionadas

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
        
            Dim objBS As New DMG.Dat_MPL_Perspectivas()

            AccionTomada = TAccionForma.Aceptar
            Select Case Modo
                Case TModo.Agregar
                    ' objBS.AgregarBD(Ortografia(txt_Descripcion.Text), Mid(cbo_Estado.Text, 1, 1))
                    Me.Close()
                Case TModo.Borrar
                    '    objBS.BorrarBD(num_CodigoClasificacion.Text)
                    Me.Close()
                Case TModo.Modificar
                    '   objBS.ModificarBD(num_CodigoClasificacion.Text, Ortografia(txt_Descripcion.Text), Mid(cbo_Estado.Text, 1, 1))
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

    Private Sub num_CodigoClasificacion_TextChanged(sender As Object, e As EventArgs) Handles num_CodigoClasificacion.TextChanged

    End Sub
End Class
