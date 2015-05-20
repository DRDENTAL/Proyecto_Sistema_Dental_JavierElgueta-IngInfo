<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.m1 = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.m2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.m3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.m6 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.LEjemplo = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(718, 104)
        Me.Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Playbill", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MintCream
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(718, 104)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "SECRETARIA"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'm1
        '
        Me.m1.AutoSize = True
        Me.m1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m1.ForeColor = System.Drawing.Color.Red
        Me.m1.Location = New System.Drawing.Point(494, 131)
        Me.m1.Name = "m1"
        Me.m1.Size = New System.Drawing.Size(185, 20)
        Me.m1.TabIndex = 28
        Me.m1.Text = "Debe ingresar un RUT vàlido."
        Me.m1.Visible = False
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.MintCream
        Me.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrar.FlatAppearance.BorderSize = 0
        Me.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRegistrar.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.Location = New System.Drawing.Point(225, 389)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(263, 41)
        Me.btnRegistrar.TabIndex = 26
        Me.btnRegistrar.Text = "Guardar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'txtApellidos
        '
        Me.txtApellidos.BackColor = System.Drawing.Color.White
        Me.txtApellidos.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidos.Location = New System.Drawing.Point(225, 241)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(263, 31)
        Me.txtApellidos.TabIndex = 24
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MintCream
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(225, 436)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(263, 34)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.White
        Me.txtTelefono.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(225, 278)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(263, 31)
        Me.txtTelefono.TabIndex = 25
        '
        'm2
        '
        Me.m2.AutoSize = True
        Me.m2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m2.ForeColor = System.Drawing.Color.Red
        Me.m2.Location = New System.Drawing.Point(494, 211)
        Me.m2.Name = "m2"
        Me.m2.Size = New System.Drawing.Size(74, 20)
        Me.m2.TabIndex = 29
        Me.m2.Text = "Obligatorio"
        Me.m2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(120, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 26)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Apellidos :"
        '
        'm3
        '
        Me.m3.AutoSize = True
        Me.m3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m3.ForeColor = System.Drawing.Color.Red
        Me.m3.Location = New System.Drawing.Point(494, 252)
        Me.m3.Name = "m3"
        Me.m3.Size = New System.Drawing.Size(74, 20)
        Me.m3.TabIndex = 30
        Me.m3.Text = "Obligatorio"
        Me.m3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(124, 283)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 26)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Teléfono :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(170, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 26)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Rut :"
        '
        'txtRut
        '
        Me.txtRut.BackColor = System.Drawing.Color.White
        Me.txtRut.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRut.Location = New System.Drawing.Point(225, 123)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(263, 32)
        Me.txtRut.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(122, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 26)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nombres :"
        '
        'txtNombres
        '
        Me.txtNombres.BackColor = System.Drawing.Color.White
        Me.txtNombres.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombres.Location = New System.Drawing.Point(225, 204)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(263, 31)
        Me.txtNombres.TabIndex = 21
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(225, 315)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(263, 31)
        Me.txtEmail.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(138, 320)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 26)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "@Email :"
        '
        'm6
        '
        Me.m6.AutoSize = True
        Me.m6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m6.ForeColor = System.Drawing.Color.Red
        Me.m6.Location = New System.Drawing.Point(494, 363)
        Me.m6.Name = "m6"
        Me.m6.Size = New System.Drawing.Size(74, 20)
        Me.m6.TabIndex = 37
        Me.m6.Text = "Obligatorio"
        Me.m6.Visible = False
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.White
        Me.txtPass.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(225, 352)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(263, 31)
        Me.txtPass.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(105, 357)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 26)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Contraseña"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.MintCream
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBuscar.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(225, 161)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(263, 37)
        Me.btnBuscar.TabIndex = 38
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'LEjemplo
        '
        Me.LEjemplo.AutoSize = True
        Me.LEjemplo.BackColor = System.Drawing.Color.Transparent
        Me.LEjemplo.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEjemplo.ForeColor = System.Drawing.Color.OrangeRed
        Me.LEjemplo.Location = New System.Drawing.Point(24, 129)
        Me.LEjemplo.Name = "LEjemplo"
        Me.LEjemplo.Size = New System.Drawing.Size(140, 26)
        Me.LEjemplo.TabIndex = 49
        Me.LEjemplo.Text = "(Ej: 12345678A)"
        Me.LEjemplo.Visible = False
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(718, 719)
        Me.ControlBox = False
        Me.Controls.Add(Me.LEjemplo)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.m6)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.m1)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.txtApellidos)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.m2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.m3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRut)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombres)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Registro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents m1 As System.Windows.Forms.Label
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents txtApellidos As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents m2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents m3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRut As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents m6 As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents LEjemplo As System.Windows.Forms.Label
End Class
