<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PACIENTES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PACIENTES))
        Me.LEjemplo = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.txtNomApe = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.m1 = New System.Windows.Forms.Label()
        Me.m2 = New System.Windows.Forms.Label()
        Me.m3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LEjemplo
        '
        Me.LEjemplo.AutoSize = True
        Me.LEjemplo.BackColor = System.Drawing.Color.Transparent
        Me.LEjemplo.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEjemplo.ForeColor = System.Drawing.Color.OrangeRed
        Me.LEjemplo.Location = New System.Drawing.Point(12, 123)
        Me.LEjemplo.Name = "LEjemplo"
        Me.LEjemplo.Size = New System.Drawing.Size(140, 26)
        Me.LEjemplo.TabIndex = 48
        Me.LEjemplo.Text = "(Ej: 12345678A)"
        Me.LEjemplo.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(157, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 26)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Rut :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(106, 427)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 26)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Nombres :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(106, 465)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 26)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Apellidos :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(109, 503)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 26)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Télefono :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(124, 541)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 26)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "@Email :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(808, 99)
        Me.Panel1.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Playbill", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(808, 99)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "PACIENTE"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtRut
        '
        Me.txtRut.BackColor = System.Drawing.Color.White
        Me.txtRut.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRut.ForeColor = System.Drawing.Color.Navy
        Me.txtRut.Location = New System.Drawing.Point(211, 121)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(264, 32)
        Me.txtRut.TabIndex = 57
        '
        'txtNomApe
        '
        Me.txtNomApe.BackColor = System.Drawing.Color.White
        Me.txtNomApe.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomApe.ForeColor = System.Drawing.Color.Navy
        Me.txtNomApe.Location = New System.Drawing.Point(211, 421)
        Me.txtNomApe.Name = "txtNomApe"
        Me.txtNomApe.Size = New System.Drawing.Size(264, 32)
        Me.txtNomApe.TabIndex = 58
        '
        'txtTel
        '
        Me.txtTel.BackColor = System.Drawing.Color.White
        Me.txtTel.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.ForeColor = System.Drawing.Color.Navy
        Me.txtTel.Location = New System.Drawing.Point(210, 497)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(264, 32)
        Me.txtTel.TabIndex = 60
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Navy
        Me.txtEmail.Location = New System.Drawing.Point(210, 535)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(264, 32)
        Me.txtEmail.TabIndex = 61
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(210, 573)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(264, 38)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'm1
        '
        Me.m1.AutoSize = True
        Me.m1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m1.ForeColor = System.Drawing.Color.Red
        Me.m1.Location = New System.Drawing.Point(480, 129)
        Me.m1.Name = "m1"
        Me.m1.Size = New System.Drawing.Size(74, 20)
        Me.m1.TabIndex = 63
        Me.m1.Text = "Obligatorio"
        Me.m1.Visible = False
        '
        'm2
        '
        Me.m2.AutoSize = True
        Me.m2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m2.ForeColor = System.Drawing.Color.Red
        Me.m2.Location = New System.Drawing.Point(480, 435)
        Me.m2.Name = "m2"
        Me.m2.Size = New System.Drawing.Size(74, 20)
        Me.m2.TabIndex = 64
        Me.m2.Text = "Obligatorio"
        Me.m2.Visible = False
        '
        'm3
        '
        Me.m3.AutoSize = True
        Me.m3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m3.ForeColor = System.Drawing.Color.Red
        Me.m3.Location = New System.Drawing.Point(480, 473)
        Me.m3.Name = "m3"
        Me.m3.Size = New System.Drawing.Size(74, 20)
        Me.m3.TabIndex = 65
        Me.m3.Text = "Obligatorio"
        Me.m3.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.Proyecto_Sistema_Dental_JavierElgueta_IngInfo.My.Resources.Resources.BuscarPaciente
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(210, 159)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(265, 57)
        Me.Button4.TabIndex = 69
        Me.Button4.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(17, 222)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(595, 193)
        Me.DataGridView1.TabIndex = 70
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(210, 613)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(264, 38)
        Me.Button2.TabIndex = 71
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtApellido
        '
        Me.txtApellido.BackColor = System.Drawing.Color.White
        Me.txtApellido.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.ForeColor = System.Drawing.Color.Navy
        Me.txtApellido.Location = New System.Drawing.Point(210, 459)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(264, 32)
        Me.txtApellido.TabIndex = 72
        '
        'PACIENTES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(808, 693)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.m3)
        Me.Controls.Add(Me.m2)
        Me.Controls.Add(Me.m1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtNomApe)
        Me.Controls.Add(Me.txtRut)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LEjemplo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.No
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PACIENTES"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LEjemplo As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRut As System.Windows.Forms.TextBox
    Friend WithEvents txtNomApe As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents m1 As System.Windows.Forms.Label
    Friend WithEvents m2 As System.Windows.Forms.Label
    Friend WithEvents m3 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
End Class
