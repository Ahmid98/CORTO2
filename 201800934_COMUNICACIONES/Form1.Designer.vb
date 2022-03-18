<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LIMPIARENTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARTABLAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lb_sueldofinal = New System.Windows.Forms.ListBox()
        Me.lb_bono = New System.Windows.Forms.ListBox()
        Me.lb_comision = New System.Windows.Forms.ListBox()
        Me.lb_articulo = New System.Windows.Forms.ListBox()
        Me.lb_valorbruto = New System.Windows.Forms.ListBox()
        Me.lb_nombre = New System.Windows.Forms.ListBox()
        Me.Articul = New System.Windows.Forms.Label()
        Me.txt_valorbruto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_articulo = New System.Windows.Forms.ComboBox()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LIMPIARENTRADASToolStripMenuItem, Me.LIMPIARTABLAToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(849, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LIMPIARENTRADASToolStripMenuItem
        '
        Me.LIMPIARENTRADASToolStripMenuItem.Name = "LIMPIARENTRADASToolStripMenuItem"
        Me.LIMPIARENTRADASToolStripMenuItem.Size = New System.Drawing.Size(189, 29)
        Me.LIMPIARENTRADASToolStripMenuItem.Text = "LIMPIAR ENTRADAS"
        '
        'LIMPIARTABLAToolStripMenuItem
        '
        Me.LIMPIARTABLAToolStripMenuItem.Name = "LIMPIARTABLAToolStripMenuItem"
        Me.LIMPIARTABLAToolStripMenuItem.Size = New System.Drawing.Size(151, 29)
        Me.LIMPIARTABLAToolStripMenuItem.Text = "LIMPIAR TABLA"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(74, 29)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global._201800934_COMUNICACIONES.My.Resources.Resources.images
        Me.GroupBox1.Controls.Add(Me.lb_sueldofinal)
        Me.GroupBox1.Controls.Add(Me.lb_bono)
        Me.GroupBox1.Controls.Add(Me.lb_comision)
        Me.GroupBox1.Controls.Add(Me.lb_articulo)
        Me.GroupBox1.Controls.Add(Me.lb_valorbruto)
        Me.GroupBox1.Controls.Add(Me.lb_nombre)
        Me.GroupBox1.Controls.Add(Me.Articul)
        Me.GroupBox1.Controls.Add(Me.txt_valorbruto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cb_articulo)
        Me.GroupBox1.Controls.Add(Me.btn_calcular)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(826, 468)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESO DE DATOS:"
        '
        'lb_sueldofinal
        '
        Me.lb_sueldofinal.FormattingEnabled = True
        Me.lb_sueldofinal.ItemHeight = 20
        Me.lb_sueldofinal.Location = New System.Drawing.Point(665, 241)
        Me.lb_sueldofinal.Name = "lb_sueldofinal"
        Me.lb_sueldofinal.Size = New System.Drawing.Size(120, 204)
        Me.lb_sueldofinal.TabIndex = 12
        '
        'lb_bono
        '
        Me.lb_bono.FormattingEnabled = True
        Me.lb_bono.ItemHeight = 20
        Me.lb_bono.Location = New System.Drawing.Point(539, 241)
        Me.lb_bono.Name = "lb_bono"
        Me.lb_bono.Size = New System.Drawing.Size(120, 204)
        Me.lb_bono.TabIndex = 11
        '
        'lb_comision
        '
        Me.lb_comision.FormattingEnabled = True
        Me.lb_comision.ItemHeight = 20
        Me.lb_comision.Location = New System.Drawing.Point(413, 241)
        Me.lb_comision.Name = "lb_comision"
        Me.lb_comision.Size = New System.Drawing.Size(120, 204)
        Me.lb_comision.TabIndex = 10
        '
        'lb_articulo
        '
        Me.lb_articulo.FormattingEnabled = True
        Me.lb_articulo.ItemHeight = 20
        Me.lb_articulo.Location = New System.Drawing.Point(287, 241)
        Me.lb_articulo.Name = "lb_articulo"
        Me.lb_articulo.Size = New System.Drawing.Size(120, 204)
        Me.lb_articulo.TabIndex = 9
        '
        'lb_valorbruto
        '
        Me.lb_valorbruto.FormattingEnabled = True
        Me.lb_valorbruto.ItemHeight = 20
        Me.lb_valorbruto.Location = New System.Drawing.Point(161, 241)
        Me.lb_valorbruto.Name = "lb_valorbruto"
        Me.lb_valorbruto.Size = New System.Drawing.Size(120, 204)
        Me.lb_valorbruto.TabIndex = 8
        '
        'lb_nombre
        '
        Me.lb_nombre.FormattingEnabled = True
        Me.lb_nombre.ItemHeight = 20
        Me.lb_nombre.Location = New System.Drawing.Point(35, 241)
        Me.lb_nombre.Name = "lb_nombre"
        Me.lb_nombre.Size = New System.Drawing.Size(120, 204)
        Me.lb_nombre.TabIndex = 7
        '
        'Articul
        '
        Me.Articul.AutoSize = True
        Me.Articul.Location = New System.Drawing.Point(31, 161)
        Me.Articul.Name = "Articul"
        Me.Articul.Size = New System.Drawing.Size(66, 20)
        Me.Articul.TabIndex = 6
        Me.Articul.Text = "Articulo:"
        '
        'txt_valorbruto
        '
        Me.txt_valorbruto.Location = New System.Drawing.Point(197, 106)
        Me.txt_valorbruto.Name = "txt_valorbruto"
        Me.txt_valorbruto.Size = New System.Drawing.Size(121, 26)
        Me.txt_valorbruto.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Valor bruto:"
        '
        'cb_articulo
        '
        Me.cb_articulo.FormattingEnabled = True
        Me.cb_articulo.Items.AddRange(New Object() {"Tablet", "Drone", "Celular", "Televisor"})
        Me.cb_articulo.Location = New System.Drawing.Point(197, 161)
        Me.cb_articulo.Name = "cb_articulo"
        Me.cb_articulo.Size = New System.Drawing.Size(121, 28)
        Me.cb_articulo.TabIndex = 3
        '
        'btn_calcular
        '
        Me.btn_calcular.Location = New System.Drawing.Point(527, 89)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(180, 61)
        Me.btn_calcular.TabIndex = 2
        Me.btn_calcular.Text = "CALCULAR"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(197, 53)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(121, 26)
        Me.txt_nombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre empleado:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(849, 534)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LIMPIARENTRADASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARTABLAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cb_articulo As ComboBox
    Friend WithEvents btn_calcular As Button
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_valorbruto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lb_sueldofinal As ListBox
    Friend WithEvents lb_bono As ListBox
    Friend WithEvents lb_comision As ListBox
    Friend WithEvents lb_articulo As ListBox
    Friend WithEvents lb_valorbruto As ListBox
    Friend WithEvents lb_nombre As ListBox
    Friend WithEvents Articul As Label
End Class
