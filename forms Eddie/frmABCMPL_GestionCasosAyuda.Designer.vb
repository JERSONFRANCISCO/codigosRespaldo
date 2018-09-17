<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABCMPL_GestionCasosAyuda
    Inherits UsrPlanificacion.EditorBase

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblRespuesta = New System.Windows.Forms.Label()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblDatoEstadoCaso = New System.Windows.Forms.Label()
        Me.lblDatoFinalizado = New System.Windows.Forms.Label()
        Me.lblDatoFechaIngreso = New System.Windows.Forms.Label()
        Me.lblDatoCategoria = New System.Windows.Forms.Label()
        Me.lblDatoAtendido = New System.Windows.Forms.Label()
        Me.lblDatoUsuario = New System.Windows.Forms.Label()
        Me.lblEstadoCaso = New System.Windows.Forms.Label()
        Me.lblFechaFinalizado = New System.Windows.Forms.Label()
        Me.lblFechaIngreso = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.lblAtendidoPor = New System.Windows.Forms.Label()
        Me.lblUsuarioResgistrado = New System.Windows.Forms.Label()
        CType(Me.ErrorABC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sbpABC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpABC.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'sbABC
        '
        Me.sbABC.Location = New System.Drawing.Point(0, 543)
        Me.sbABC.Size = New System.Drawing.Size(759, 22)
        '
        'sbpABC
        '
        Me.sbpABC.Width = 743
        '
        'GrpABC
        '
        Me.GrpABC.Controls.Add(Me.Panel1)
        Me.GrpABC.Location = New System.Drawing.Point(12, 12)
        Me.GrpABC.Size = New System.Drawing.Size(722, 524)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblRespuesta)
        Me.Panel1.Controls.Add(Me.btnEnviar)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.txtDescripcion)
        Me.Panel1.Controls.Add(Me.lblDescripcion)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(6, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(707, 490)
        Me.Panel1.TabIndex = 0
        '
        'lblRespuesta
        '
        Me.lblRespuesta.AutoSize = True
        Me.lblRespuesta.Location = New System.Drawing.Point(55, 389)
        Me.lblRespuesta.Name = "lblRespuesta"
        Me.lblRespuesta.Size = New System.Drawing.Size(61, 13)
        Me.lblRespuesta.TabIndex = 5
        Me.lblRespuesta.Text = "Respuesta:"
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(527, 408)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(125, 68)
        Me.btnEnviar.TabIndex = 4
        Me.btnEnviar.Text = "Enviar Respuesta"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(55, 408)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(405, 68)
        Me.TextBox1.TabIndex = 3
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(55, 209)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(597, 164)
        Me.txtDescripcion.TabIndex = 2
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(52, 184)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripcion.TabIndex = 1
        Me.lblDescripcion.Text = "Descripcion:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblDatoEstadoCaso)
        Me.Panel2.Controls.Add(Me.lblDatoFinalizado)
        Me.Panel2.Controls.Add(Me.lblDatoFechaIngreso)
        Me.Panel2.Controls.Add(Me.lblDatoCategoria)
        Me.Panel2.Controls.Add(Me.lblDatoAtendido)
        Me.Panel2.Controls.Add(Me.lblDatoUsuario)
        Me.Panel2.Controls.Add(Me.lblEstadoCaso)
        Me.Panel2.Controls.Add(Me.lblFechaFinalizado)
        Me.Panel2.Controls.Add(Me.lblFechaIngreso)
        Me.Panel2.Controls.Add(Me.lblCategoria)
        Me.Panel2.Controls.Add(Me.lblAtendidoPor)
        Me.Panel2.Controls.Add(Me.lblUsuarioResgistrado)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(701, 162)
        Me.Panel2.TabIndex = 0
        '
        'lblDatoEstadoCaso
        '
        Me.lblDatoEstadoCaso.AutoSize = True
        Me.lblDatoEstadoCaso.Location = New System.Drawing.Point(510, 129)
        Me.lblDatoEstadoCaso.Name = "lblDatoEstadoCaso"
        Me.lblDatoEstadoCaso.Size = New System.Drawing.Size(10, 13)
        Me.lblDatoEstadoCaso.TabIndex = 11
        Me.lblDatoEstadoCaso.Text = "-"
        '
        'lblDatoFinalizado
        '
        Me.lblDatoFinalizado.AutoSize = True
        Me.lblDatoFinalizado.Location = New System.Drawing.Point(510, 74)
        Me.lblDatoFinalizado.Name = "lblDatoFinalizado"
        Me.lblDatoFinalizado.Size = New System.Drawing.Size(10, 13)
        Me.lblDatoFinalizado.TabIndex = 10
        Me.lblDatoFinalizado.Text = "-"
        '
        'lblDatoFechaIngreso
        '
        Me.lblDatoFechaIngreso.AutoSize = True
        Me.lblDatoFechaIngreso.Location = New System.Drawing.Point(510, 22)
        Me.lblDatoFechaIngreso.Name = "lblDatoFechaIngreso"
        Me.lblDatoFechaIngreso.Size = New System.Drawing.Size(10, 13)
        Me.lblDatoFechaIngreso.TabIndex = 9
        Me.lblDatoFechaIngreso.Text = "-"
        '
        'lblDatoCategoria
        '
        Me.lblDatoCategoria.AutoSize = True
        Me.lblDatoCategoria.Location = New System.Drawing.Point(174, 129)
        Me.lblDatoCategoria.Name = "lblDatoCategoria"
        Me.lblDatoCategoria.Size = New System.Drawing.Size(10, 13)
        Me.lblDatoCategoria.TabIndex = 8
        Me.lblDatoCategoria.Text = "-"
        '
        'lblDatoAtendido
        '
        Me.lblDatoAtendido.AutoSize = True
        Me.lblDatoAtendido.Location = New System.Drawing.Point(174, 74)
        Me.lblDatoAtendido.Name = "lblDatoAtendido"
        Me.lblDatoAtendido.Size = New System.Drawing.Size(10, 13)
        Me.lblDatoAtendido.TabIndex = 7
        Me.lblDatoAtendido.Text = "-"
        '
        'lblDatoUsuario
        '
        Me.lblDatoUsuario.AutoSize = True
        Me.lblDatoUsuario.Location = New System.Drawing.Point(174, 22)
        Me.lblDatoUsuario.Name = "lblDatoUsuario"
        Me.lblDatoUsuario.Size = New System.Drawing.Size(10, 13)
        Me.lblDatoUsuario.TabIndex = 6
        Me.lblDatoUsuario.Text = "-"
        '
        'lblEstadoCaso
        '
        Me.lblEstadoCaso.AutoSize = True
        Me.lblEstadoCaso.Location = New System.Drawing.Point(396, 129)
        Me.lblEstadoCaso.Name = "lblEstadoCaso"
        Me.lblEstadoCaso.Size = New System.Drawing.Size(87, 13)
        Me.lblEstadoCaso.TabIndex = 5
        Me.lblEstadoCaso.Text = "Estado del Caso:"
        '
        'lblFechaFinalizado
        '
        Me.lblFechaFinalizado.AutoSize = True
        Me.lblFechaFinalizado.Location = New System.Drawing.Point(396, 74)
        Me.lblFechaFinalizado.Name = "lblFechaFinalizado"
        Me.lblFechaFinalizado.Size = New System.Drawing.Size(90, 13)
        Me.lblFechaFinalizado.TabIndex = 4
        Me.lblFechaFinalizado.Text = "Fecha Finalizado:"
        '
        'lblFechaIngreso
        '
        Me.lblFechaIngreso.AutoSize = True
        Me.lblFechaIngreso.Location = New System.Drawing.Point(396, 22)
        Me.lblFechaIngreso.Name = "lblFechaIngreso"
        Me.lblFechaIngreso.Size = New System.Drawing.Size(82, 13)
        Me.lblFechaIngreso.TabIndex = 3
        Me.lblFechaIngreso.Text = "Fecha Registro:"
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Location = New System.Drawing.Point(46, 129)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(55, 13)
        Me.lblCategoria.TabIndex = 2
        Me.lblCategoria.Text = "Categoria:"
        '
        'lblAtendidoPor
        '
        Me.lblAtendidoPor.AutoSize = True
        Me.lblAtendidoPor.Location = New System.Drawing.Point(46, 74)
        Me.lblAtendidoPor.Name = "lblAtendidoPor"
        Me.lblAtendidoPor.Size = New System.Drawing.Size(70, 13)
        Me.lblAtendidoPor.TabIndex = 1
        Me.lblAtendidoPor.Text = "Atendido por:"
        '
        'lblUsuarioResgistrado
        '
        Me.lblUsuarioResgistrado.AutoSize = True
        Me.lblUsuarioResgistrado.Location = New System.Drawing.Point(46, 22)
        Me.lblUsuarioResgistrado.Name = "lblUsuarioResgistrado"
        Me.lblUsuarioResgistrado.Size = New System.Drawing.Size(100, 13)
        Me.lblUsuarioResgistrado.TabIndex = 0
        Me.lblUsuarioResgistrado.Text = "Usuario Registrado:"
        '
        'frmABCMPL_GestionCasosAyuda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 565)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "frmABCMPL_GestionCasosAyuda"
        Me.Text = "Gestión Casos de Ayuda."
        CType(Me.ErrorABC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sbpABC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpABC.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblEstadoCaso As System.Windows.Forms.Label
    Friend WithEvents lblFechaFinalizado As System.Windows.Forms.Label
    Friend WithEvents lblFechaIngreso As System.Windows.Forms.Label
    Friend WithEvents lblCategoria As System.Windows.Forms.Label
    Friend WithEvents lblAtendidoPor As System.Windows.Forms.Label
    Friend WithEvents lblUsuarioResgistrado As System.Windows.Forms.Label
    Friend WithEvents lblDatoEstadoCaso As System.Windows.Forms.Label
    Friend WithEvents lblDatoFinalizado As System.Windows.Forms.Label
    Friend WithEvents lblDatoFechaIngreso As System.Windows.Forms.Label
    Friend WithEvents lblDatoCategoria As System.Windows.Forms.Label
    Friend WithEvents lblDatoAtendido As System.Windows.Forms.Label
    Friend WithEvents lblDatoUsuario As System.Windows.Forms.Label
    Friend WithEvents lblRespuesta As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
End Class
