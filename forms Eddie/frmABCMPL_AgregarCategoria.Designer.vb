<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABCMPL_AgregarCategoria
    Inherits UsrPlanificacion.EditorBase

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cbpRows = New System.Windows.Forms.StatusBarPanel()
        Me.CMnu_Imprimir = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MatrixToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuíaParaLaFormulaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MatrizDeDesempeñoConPesoTrimestralDelPeríodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.txtIngreseCategoria = New System.Windows.Forms.TextBox()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.rdoActivo = New System.Windows.Forms.RadioButton()
        Me.rdoInactivo = New System.Windows.Forms.RadioButton()
        Me.lblEstado = New System.Windows.Forms.Label()
        CType(Me.ErrorABC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sbpABC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpABC.SuspendLayout()
        CType(Me.cbpRows, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMnu_Imprimir.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Image = Global.UsrPlanificacion.My.Resources.Resources.button_ok_16x16
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAceptar.Location = New System.Drawing.Point(65, 188)
        Me.btnAceptar.Size = New System.Drawing.Size(94, 35)
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.UsrPlanificacion.My.Resources.Resources.button_cancel_16x16
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.Location = New System.Drawing.Point(165, 188)
        Me.btnSalir.Size = New System.Drawing.Size(94, 35)
        '
        'sbABC
        '
        Me.sbABC.Location = New System.Drawing.Point(0, 239)
        Me.sbABC.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.cbpRows})
        Me.sbABC.Size = New System.Drawing.Size(338, 22)
        '
        'sbpABC
        '
        Me.sbpABC.Width = 222
        '
        'GrpABC
        '
        Me.GrpABC.Controls.Add(Me.lblEstado)
        Me.GrpABC.Controls.Add(Me.rdoInactivo)
        Me.GrpABC.Controls.Add(Me.rdoActivo)
        Me.GrpABC.Controls.Add(Me.lblCategoria)
        Me.GrpABC.Controls.Add(Me.txtIngreseCategoria)
        Me.GrpABC.Location = New System.Drawing.Point(0, 3)
        Me.GrpABC.Size = New System.Drawing.Size(341, 179)
        '
        'cbpRows
        '
        Me.cbpRows.Name = "cbpRows"
        Me.cbpRows.Text = "Registros"
        '
        'CMnu_Imprimir
        '
        Me.CMnu_Imprimir.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MatrixToolStripMenuItem, Me.GuíaParaLaFormulaciónToolStripMenuItem, Me.MatrizDeDesempeñoConPesoTrimestralDelPeríodoToolStripMenuItem})
        Me.CMnu_Imprimir.Name = "CMnu_Imprimir"
        Me.CMnu_Imprimir.Size = New System.Drawing.Size(319, 70)
        '
        'MatrixToolStripMenuItem
        '
        Me.MatrixToolStripMenuItem.Name = "MatrixToolStripMenuItem"
        Me.MatrixToolStripMenuItem.Size = New System.Drawing.Size(318, 22)
        Me.MatrixToolStripMenuItem.Text = "Matriz de Desempeño Programático del Periodo"
        '
        'GuíaParaLaFormulaciónToolStripMenuItem
        '
        Me.GuíaParaLaFormulaciónToolStripMenuItem.Name = "GuíaParaLaFormulaciónToolStripMenuItem"
        Me.GuíaParaLaFormulaciónToolStripMenuItem.Size = New System.Drawing.Size(318, 22)
        Me.GuíaParaLaFormulaciónToolStripMenuItem.Text = "Guía para la Formulación"
        '
        'MatrizDeDesempeñoConPesoTrimestralDelPeríodoToolStripMenuItem
        '
        Me.MatrizDeDesempeñoConPesoTrimestralDelPeríodoToolStripMenuItem.Name = "MatrizDeDesempeñoConPesoTrimestralDelPeríodoToolStripMenuItem"
        Me.MatrizDeDesempeñoConPesoTrimestralDelPeríodoToolStripMenuItem.Size = New System.Drawing.Size(318, 22)
        Me.MatrizDeDesempeñoConPesoTrimestralDelPeríodoToolStripMenuItem.Text = "Matriz de Desempeño Programación de Actividades"
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Responsable"
        Me.DataGridTextBoxColumn5.MappingName = "Responsable"
        Me.DataGridTextBoxColumn5.Width = 260
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Tipo"
        Me.DataGridTextBoxColumn4.MappingName = "Estado"
        Me.DataGridTextBoxColumn4.Width = 85
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Estado"
        Me.DataGridTextBoxColumn3.MappingName = "Finalizado"
        Me.DataGridTextBoxColumn3.Width = 85
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Periodo"
        Me.DataGridTextBoxColumn2.MappingName = "Periodo"
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridTextBoxColumn1.MappingName = "CodigoProgramacion"
        Me.DataGridTextBoxColumn1.Width = 300
        '
        'txtIngreseCategoria
        '
        Me.txtIngreseCategoria.Location = New System.Drawing.Point(65, 40)
        Me.txtIngreseCategoria.Name = "txtIngreseCategoria"
        Me.txtIngreseCategoria.Size = New System.Drawing.Size(194, 20)
        Me.txtIngreseCategoria.TabIndex = 0
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Location = New System.Drawing.Point(65, 21)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(110, 13)
        Me.lblCategoria.TabIndex = 1
        Me.lblCategoria.Text = "Ingrese una categoria"
        '
        'rdoActivo
        '
        Me.rdoActivo.AutoSize = True
        Me.rdoActivo.Location = New System.Drawing.Point(169, 102)
        Me.rdoActivo.Name = "rdoActivo"
        Me.rdoActivo.Size = New System.Drawing.Size(55, 17)
        Me.rdoActivo.TabIndex = 2
        Me.rdoActivo.TabStop = True
        Me.rdoActivo.Text = "Activo"
        Me.rdoActivo.UseVisualStyleBackColor = True
        '
        'rdoInactivo
        '
        Me.rdoInactivo.AutoSize = True
        Me.rdoInactivo.Location = New System.Drawing.Point(169, 126)
        Me.rdoInactivo.Name = "rdoInactivo"
        Me.rdoInactivo.Size = New System.Drawing.Size(63, 17)
        Me.rdoInactivo.TabIndex = 3
        Me.rdoInactivo.TabStop = True
        Me.rdoInactivo.Text = "Inactivo"
        Me.rdoInactivo.UseVisualStyleBackColor = True
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(65, 102)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(43, 13)
        Me.lblEstado.TabIndex = 4
        Me.lblEstado.Text = "Estado:"
        '
        'frmABCMPL_AgregarCategoria
        '
        Me.ClientSize = New System.Drawing.Size(338, 261)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "frmABCMPL_AgregarCategoria"
        Me.Text = "Agregar Categorias"
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnAceptar, 0)
        Me.Controls.SetChildIndex(Me.GrpABC, 0)
        Me.Controls.SetChildIndex(Me.sbABC, 0)
        CType(Me.ErrorABC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sbpABC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpABC.ResumeLayout(False)
        Me.GrpABC.PerformLayout()
        CType(Me.cbpRows, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMnu_Imprimir.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbpRows As System.Windows.Forms.StatusBarPanel
    Friend WithEvents CMnu_Imprimir As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MatrixToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuíaParaLaFormulaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MatrizDeDesempeñoConPesoTrimestralDelPeríodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents rdoInactivo As System.Windows.Forms.RadioButton
    Friend WithEvents rdoActivo As System.Windows.Forms.RadioButton
    Friend WithEvents lblCategoria As System.Windows.Forms.Label
    Friend WithEvents txtIngreseCategoria As System.Windows.Forms.TextBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label

End Class
