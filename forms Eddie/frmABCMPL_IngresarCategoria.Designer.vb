<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABCMPL_IngresarCategoria
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
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Consultar = New System.Windows.Forms.Button()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.DG_ListadoProgramacion = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.cbpRows = New System.Windows.Forms.StatusBarPanel()
        Me.CMnu_Imprimir = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MatrixToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuíaParaLaFormulaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MatrizDeDesempeñoConPesoTrimestralDelPeríodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.ErrorABC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sbpABC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpABC.SuspendLayout()
        CType(Me.DG_ListadoProgramacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbpRows, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMnu_Imprimir.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Image = Global.UsrPlanificacion.My.Resources.Resources.button_ok_16x16
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAceptar.Location = New System.Drawing.Point(22, 8)
        Me.btnAceptar.Size = New System.Drawing.Size(94, 35)
        Me.btnAceptar.Text = "&Agregar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.UsrPlanificacion.My.Resources.Resources.button_cancel_16x16
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.Location = New System.Drawing.Point(776, 8)
        Me.btnSalir.Size = New System.Drawing.Size(94, 35)
        '
        'sbABC
        '
        Me.sbABC.Location = New System.Drawing.Point(0, 341)
        Me.sbABC.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.cbpRows})
        Me.sbABC.Size = New System.Drawing.Size(888, 22)
        '
        'sbpABC
        '
        Me.sbpABC.Width = 772
        '
        'GrpABC
        '
        Me.GrpABC.Controls.Add(Me.DG_ListadoProgramacion)
        Me.GrpABC.Location = New System.Drawing.Point(12, 44)
        Me.GrpABC.Size = New System.Drawing.Size(864, 290)
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Eliminar.Location = New System.Drawing.Point(222, 8)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(94, 35)
        Me.btn_Eliminar.TabIndex = 27
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'btn_Consultar
        '
        Me.btn_Consultar.Image = Global.UsrPlanificacion.My.Resources.Resources.find_16x16
        Me.btn_Consultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Consultar.Location = New System.Drawing.Point(322, 8)
        Me.btn_Consultar.Name = "btn_Consultar"
        Me.btn_Consultar.Size = New System.Drawing.Size(94, 35)
        Me.btn_Consultar.TabIndex = 26
        Me.btn_Consultar.Text = "&Consultar"
        Me.btn_Consultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Consultar.UseVisualStyleBackColor = True
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Image = Global.UsrPlanificacion.My.Resources.Resources.files_edit_16x16
        Me.btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Modificar.Location = New System.Drawing.Point(122, 8)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(94, 35)
        Me.btn_Modificar.TabIndex = 25
        Me.btn_Modificar.Text = "&Modificar"
        Me.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'DG_ListadoProgramacion
        '
        Me.DG_ListadoProgramacion.DataMember = ""
        Me.DG_ListadoProgramacion.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DG_ListadoProgramacion.Location = New System.Drawing.Point(6, 13)
        Me.DG_ListadoProgramacion.Name = "DG_ListadoProgramacion"
        Me.DG_ListadoProgramacion.ReadOnly = True
        Me.DG_ListadoProgramacion.Size = New System.Drawing.Size(852, 271)
        Me.DG_ListadoProgramacion.TabIndex = 0
        Me.DG_ListadoProgramacion.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DG_ListadoProgramacion
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Table"
        Me.DataGridTableStyle1.ReadOnly = True
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridTextBoxColumn1.MappingName = "CodigoProgramacion"
        Me.DataGridTextBoxColumn1.Width = 300
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
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Estado"
        Me.DataGridTextBoxColumn3.MappingName = "Finalizado"
        Me.DataGridTextBoxColumn3.Width = 85
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Tipo"
        Me.DataGridTextBoxColumn4.MappingName = "Estado"
        Me.DataGridTextBoxColumn4.Width = 85
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Responsable"
        Me.DataGridTextBoxColumn5.MappingName = "Responsable"
        Me.DataGridTextBoxColumn5.Width = 260
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
        'frmABCMPL_IngresarCategoria
        '
        Me.ClientSize = New System.Drawing.Size(888, 363)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Consultar)
        Me.Controls.Add(Me.btn_Modificar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "frmABCMPL_IngresarCategoria"
        Me.Text = "Ingresar categorias"
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnAceptar, 0)
        Me.Controls.SetChildIndex(Me.GrpABC, 0)
        Me.Controls.SetChildIndex(Me.sbABC, 0)
        Me.Controls.SetChildIndex(Me.btn_Modificar, 0)
        Me.Controls.SetChildIndex(Me.btn_Consultar, 0)
        Me.Controls.SetChildIndex(Me.btn_Eliminar, 0)
        CType(Me.ErrorABC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sbpABC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpABC.ResumeLayout(False)
        CType(Me.DG_ListadoProgramacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbpRows, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMnu_Imprimir.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Consultar As System.Windows.Forms.Button
    Friend WithEvents btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents DG_ListadoProgramacion As System.Windows.Forms.DataGrid
    Friend WithEvents cbpRows As System.Windows.Forms.StatusBarPanel
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents CMnu_Imprimir As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MatrixToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuíaParaLaFormulaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MatrizDeDesempeñoConPesoTrimestralDelPeríodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
