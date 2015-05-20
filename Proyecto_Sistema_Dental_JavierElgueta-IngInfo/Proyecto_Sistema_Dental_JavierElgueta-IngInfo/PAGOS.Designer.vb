<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PAGOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PAGOS))
        Me.txtRutPagos = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bPago = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.bBusPac = New System.Windows.Forms.Button()
        Me.m3 = New System.Windows.Forms.Label()
        Me.m2 = New System.Windows.Forms.Label()
        Me.m1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtRutPagos
        '
        Me.txtRutPagos.BackColor = System.Drawing.Color.White
        Me.txtRutPagos.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRutPagos.ForeColor = System.Drawing.Color.Navy
        Me.txtRutPagos.Location = New System.Drawing.Point(175, 102)
        Me.txtRutPagos.Name = "txtRutPagos"
        Me.txtRutPagos.Size = New System.Drawing.Size(271, 33)
        Me.txtRutPagos.TabIndex = 0
        '
        'txtNombres
        '
        Me.txtNombres.BackColor = System.Drawing.Color.White
        Me.txtNombres.Enabled = False
        Me.txtNombres.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombres.ForeColor = System.Drawing.Color.Navy
        Me.txtNombres.Location = New System.Drawing.Point(199, 448)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(284, 33)
        Me.txtNombres.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(129, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 26)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Rut"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(74, 455)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 26)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nombres"
        '
        'bPago
        '
        Me.bPago.BackColor = System.Drawing.Color.Honeydew
        Me.bPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bPago.FlatAppearance.BorderSize = 0
        Me.bPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.bPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.bPago.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPago.Location = New System.Drawing.Point(199, 647)
        Me.bPago.Name = "bPago"
        Me.bPago.Size = New System.Drawing.Size(284, 35)
        Me.bPago.TabIndex = 6
        Me.bPago.Text = "Pagar"
        Me.bPago.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(81, 601)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 26)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Monto $"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Navy
        Me.TextBox1.Location = New System.Drawing.Point(199, 594)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(284, 33)
        Me.TextBox1.TabIndex = 7
        '
        'bBusPac
        '
        Me.bBusPac.BackColor = System.Drawing.Color.Transparent
        Me.bBusPac.BackgroundImage = Global.Proyecto_Sistema_Dental_JavierElgueta_IngInfo.My.Resources.Resources.BuscarPaciente
        Me.bBusPac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bBusPac.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bBusPac.FlatAppearance.BorderSize = 0
        Me.bBusPac.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.bBusPac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.bBusPac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBusPac.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBusPac.Location = New System.Drawing.Point(115, 141)
        Me.bBusPac.Name = "bBusPac"
        Me.bBusPac.Size = New System.Drawing.Size(331, 70)
        Me.bBusPac.TabIndex = 9
        Me.bBusPac.UseVisualStyleBackColor = False
        '
        'm3
        '
        Me.m3.AutoSize = True
        Me.m3.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m3.ForeColor = System.Drawing.Color.Red
        Me.m3.Location = New System.Drawing.Point(489, 609)
        Me.m3.Name = "m3"
        Me.m3.Size = New System.Drawing.Size(82, 18)
        Me.m3.TabIndex = 74
        Me.m3.Text = "Obligatorio"
        Me.m3.Visible = False
        '
        'm2
        '
        Me.m2.AutoSize = True
        Me.m2.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m2.ForeColor = System.Drawing.Color.Red
        Me.m2.Location = New System.Drawing.Point(489, 463)
        Me.m2.Name = "m2"
        Me.m2.Size = New System.Drawing.Size(82, 18)
        Me.m2.TabIndex = 73
        Me.m2.Text = "Obligatorio"
        Me.m2.Visible = False
        '
        'm1
        '
        Me.m1.AutoSize = True
        Me.m1.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m1.ForeColor = System.Drawing.Color.Red
        Me.m1.Location = New System.Drawing.Point(452, 117)
        Me.m1.Name = "m1"
        Me.m1.Size = New System.Drawing.Size(82, 18)
        Me.m1.TabIndex = 72
        Me.m1.Text = "Obligatorio"
        Me.m1.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Playbill", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(824, 96)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "PAGO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(824, 96)
        Me.Panel1.TabIndex = 76
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(489, 511)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 18)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Obligatorio"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(76, 503)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 26)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Apellidos"
        '
        'txtApellidos
        '
        Me.txtApellidos.BackColor = System.Drawing.Color.White
        Me.txtApellidos.Enabled = False
        Me.txtApellidos.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidos.ForeColor = System.Drawing.Color.Navy
        Me.txtApellidos.Location = New System.Drawing.Point(199, 497)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(284, 33)
        Me.txtApellidos.TabIndex = 77
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(21, 222)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(562, 214)
        Me.DataGridView1.TabIndex = 80
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(489, 555)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 18)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "Obligatorio"
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(76, 555)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 26)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Tratamiento"
        '
        'ComboBox1
        '
        Me.ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(199, 555)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(284, 21)
        Me.ComboBox1.TabIndex = 84
        '
        'PAGOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(824, 756)
        Me.ControlBox = False
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtApellidos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.m3)
        Me.Controls.Add(Me.m2)
        Me.Controls.Add(Me.m1)
        Me.Controls.Add(Me.bBusPac)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.bPago)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombres)
        Me.Controls.Add(Me.txtRutPagos)
        Me.Cursor = System.Windows.Forms.Cursors.No
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PAGOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRutPagos As System.Windows.Forms.TextBox
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bPago As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents bBusPac As System.Windows.Forms.Button
    Friend WithEvents m3 As System.Windows.Forms.Label
    Friend WithEvents m2 As System.Windows.Forms.Label
    Friend WithEvents m1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtApellidos As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
