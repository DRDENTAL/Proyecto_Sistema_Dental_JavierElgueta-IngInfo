<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TRATAMIENTOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TRATAMIENTOS))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Lfecha = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lnom = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DArr = New System.Windows.Forms.Label()
        Me.Daba = New System.Windows.Forms.Label()
        Me.Dder = New System.Windows.Forms.Label()
        Me.Dizq = New System.Windows.Forms.Label()
        Me.DCen = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.OvalShape6 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape5 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape4 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape3 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.Rizq = New System.Windows.Forms.RadioButton()
        Me.Rarr = New System.Windows.Forms.RadioButton()
        Me.Rcen = New System.Windows.Forms.RadioButton()
        Me.Rder = New System.Windows.Forms.RadioButton()
        Me.Raba = New System.Windows.Forms.RadioButton()
        Me.Lntrat = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lndie = New System.Windows.Forms.Label()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Panel1.SuspendLayout()
        CType(Me.Lntrat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Lfecha)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Lnom)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1060, 102)
        Me.Panel1.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightCoral
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(987, 13)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(61, 35)
        Me.Button3.TabIndex = 72
        Me.Button3.Text = "SALIR"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Lfecha
        '
        Me.Lfecha.AutoSize = True
        Me.Lfecha.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lfecha.ForeColor = System.Drawing.Color.AliceBlue
        Me.Lfecha.Location = New System.Drawing.Point(419, 10)
        Me.Lfecha.Name = "Lfecha"
        Me.Lfecha.Size = New System.Drawing.Size(73, 30)
        Me.Lfecha.TabIndex = 22
        Me.Lfecha.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label3.Location = New System.Drawing.Point(322, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 30)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Fecha"
        '
        'Lnom
        '
        Me.Lnom.AutoSize = True
        Me.Lnom.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lnom.ForeColor = System.Drawing.Color.AliceBlue
        Me.Lnom.Location = New System.Drawing.Point(322, 59)
        Me.Lnom.Name = "Lnom"
        Me.Lnom.Size = New System.Drawing.Size(101, 30)
        Me.Lnom.TabIndex = 20
        Me.Lnom.Text = "Nombres"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(3, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 53)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tratamiento"
        '
        'DArr
        '
        Me.DArr.AutoSize = True
        Me.DArr.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DArr.ForeColor = System.Drawing.Color.Lime
        Me.DArr.Location = New System.Drawing.Point(760, 147)
        Me.DArr.Name = "DArr"
        Me.DArr.Size = New System.Drawing.Size(64, 56)
        Me.DArr.TabIndex = 1
        Me.DArr.Text = "O"
        Me.DArr.Visible = False
        '
        'Daba
        '
        Me.Daba.AutoSize = True
        Me.Daba.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Daba.ForeColor = System.Drawing.Color.Lime
        Me.Daba.Location = New System.Drawing.Point(760, 372)
        Me.Daba.Name = "Daba"
        Me.Daba.Size = New System.Drawing.Size(64, 56)
        Me.Daba.TabIndex = 2
        Me.Daba.Text = "O"
        Me.Daba.Visible = False
        '
        'Dder
        '
        Me.Dder.AutoSize = True
        Me.Dder.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dder.ForeColor = System.Drawing.Color.Lime
        Me.Dder.Location = New System.Drawing.Point(862, 256)
        Me.Dder.Name = "Dder"
        Me.Dder.Size = New System.Drawing.Size(64, 56)
        Me.Dder.TabIndex = 3
        Me.Dder.Text = "O"
        Me.Dder.Visible = False
        '
        'Dizq
        '
        Me.Dizq.AutoSize = True
        Me.Dizq.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dizq.ForeColor = System.Drawing.Color.Lime
        Me.Dizq.Location = New System.Drawing.Point(652, 256)
        Me.Dizq.Name = "Dizq"
        Me.Dizq.Size = New System.Drawing.Size(64, 56)
        Me.Dizq.TabIndex = 4
        Me.Dizq.Text = "O"
        Me.Dizq.Visible = False
        '
        'DCen
        '
        Me.DCen.AutoSize = True
        Me.DCen.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DCen.ForeColor = System.Drawing.Color.Lime
        Me.DCen.Location = New System.Drawing.Point(761, 256)
        Me.DCen.Name = "DCen"
        Me.DCen.Size = New System.Drawing.Size(64, 56)
        Me.DCen.TabIndex = 5
        Me.DCen.Text = "O"
        Me.DCen.Visible = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape6, Me.OvalShape5, Me.OvalShape4, Me.OvalShape3, Me.OvalShape2, Me.OvalShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1059, 673)
        Me.ShapeContainer1.TabIndex = 7
        Me.ShapeContainer1.TabStop = False
        '
        'OvalShape6
        '
        Me.OvalShape6.Location = New System.Drawing.Point(737, 231)
        Me.OvalShape6.Name = "OvalShape6"
        Me.OvalShape6.Size = New System.Drawing.Size(106, 111)
        '
        'OvalShape5
        '
        Me.OvalShape5.Location = New System.Drawing.Point(733, 341)
        Me.OvalShape5.Name = "OvalShape5"
        Me.OvalShape5.Size = New System.Drawing.Size(113, 116)
        '
        'OvalShape4
        '
        Me.OvalShape4.Location = New System.Drawing.Point(732, 121)
        Me.OvalShape4.Name = "OvalShape4"
        Me.OvalShape4.Size = New System.Drawing.Size(114, 111)
        '
        'OvalShape3
        '
        Me.OvalShape3.Location = New System.Drawing.Point(844, 199)
        Me.OvalShape3.Name = "OvalShape3"
        Me.OvalShape3.Size = New System.Drawing.Size(101, 176)
        '
        'OvalShape2
        '
        Me.OvalShape2.Location = New System.Drawing.Point(627, 199)
        Me.OvalShape2.Name = "OvalShape2"
        Me.OvalShape2.Size = New System.Drawing.Size(109, 175)
        '
        'OvalShape1
        '
        Me.OvalShape1.BackColor = System.Drawing.Color.White
        Me.OvalShape1.Location = New System.Drawing.Point(618, 110)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.Size = New System.Drawing.Size(336, 358)
        '
        'Rizq
        '
        Me.Rizq.AutoSize = True
        Me.Rizq.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rizq.Location = New System.Drawing.Point(676, 279)
        Me.Rizq.Name = "Rizq"
        Me.Rizq.Size = New System.Drawing.Size(14, 13)
        Me.Rizq.TabIndex = 8
        Me.Rizq.TabStop = True
        Me.Rizq.UseVisualStyleBackColor = True
        '
        'Rarr
        '
        Me.Rarr.AutoSize = True
        Me.Rarr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rarr.Location = New System.Drawing.Point(784, 169)
        Me.Rarr.Name = "Rarr"
        Me.Rarr.Size = New System.Drawing.Size(14, 13)
        Me.Rarr.TabIndex = 9
        Me.Rarr.TabStop = True
        Me.Rarr.UseVisualStyleBackColor = True
        '
        'Rcen
        '
        Me.Rcen.AutoSize = True
        Me.Rcen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rcen.Location = New System.Drawing.Point(784, 279)
        Me.Rcen.Name = "Rcen"
        Me.Rcen.Size = New System.Drawing.Size(14, 13)
        Me.Rcen.TabIndex = 10
        Me.Rcen.TabStop = True
        Me.Rcen.UseVisualStyleBackColor = True
        '
        'Rder
        '
        Me.Rder.AutoSize = True
        Me.Rder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rder.Location = New System.Drawing.Point(886, 279)
        Me.Rder.Name = "Rder"
        Me.Rder.Size = New System.Drawing.Size(14, 13)
        Me.Rder.TabIndex = 11
        Me.Rder.TabStop = True
        Me.Rder.UseVisualStyleBackColor = True
        '
        'Raba
        '
        Me.Raba.AutoSize = True
        Me.Raba.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Raba.Location = New System.Drawing.Point(784, 395)
        Me.Raba.Name = "Raba"
        Me.Raba.Size = New System.Drawing.Size(14, 13)
        Me.Raba.TabIndex = 12
        Me.Raba.TabStop = True
        Me.Raba.UseVisualStyleBackColor = True
        '
        'Lntrat
        '
        Me.Lntrat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lntrat.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lntrat.Location = New System.Drawing.Point(61, 229)
        Me.Lntrat.Name = "Lntrat"
        Me.Lntrat.Size = New System.Drawing.Size(153, 37)
        Me.Lntrat.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 30)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nº del Tratamiento"
        '
        'Lndie
        '
        Me.Lndie.AutoSize = True
        Me.Lndie.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lndie.Location = New System.Drawing.Point(57, 269)
        Me.Lndie.Name = "Lndie"
        Me.Lndie.Size = New System.Drawing.Size(157, 30)
        Me.Lndie.TabIndex = 16
        Me.Lndie.Text = "Nº del Diente"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown2.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown2.Location = New System.Drawing.Point(61, 302)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(153, 37)
        Me.NumericUpDown2.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(57, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 30)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Rut"
        '
        'txtRut
        '
        Me.txtRut.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRut.Location = New System.Drawing.Point(110, 156)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(191, 37)
        Me.txtRut.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(61, 353)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 56)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "GUARDAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(326, 156)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 37)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.HorizontalScrollbar = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"AM", "CC", "CS", "D", "EA", "EP", "ES", "ETM", "FP", "H", "R", "S", "UD", "V"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(497, 130)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(75, 298)
        Me.CheckedListBox1.TabIndex = 17
        '
        'TRATAMIENTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 673)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtRut)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.Lndie)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lntrat)
        Me.Controls.Add(Me.Raba)
        Me.Controls.Add(Me.Rder)
        Me.Controls.Add(Me.Rcen)
        Me.Controls.Add(Me.Rarr)
        Me.Controls.Add(Me.Rizq)
        Me.Controls.Add(Me.DCen)
        Me.Controls.Add(Me.Dizq)
        Me.Controls.Add(Me.Dder)
        Me.Controls.Add(Me.Daba)
        Me.Controls.Add(Me.DArr)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TRATAMIENTOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TRATAMIENTOS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Lntrat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DArr As System.Windows.Forms.Label
    Friend WithEvents Daba As System.Windows.Forms.Label
    Friend WithEvents Dder As System.Windows.Forms.Label
    Friend WithEvents Dizq As System.Windows.Forms.Label
    Friend WithEvents DCen As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents OvalShape6 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents OvalShape5 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents OvalShape4 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents OvalShape3 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents OvalShape2 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents OvalShape1 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents Rizq As System.Windows.Forms.RadioButton
    Friend WithEvents Rarr As System.Windows.Forms.RadioButton
    Friend WithEvents Rcen As System.Windows.Forms.RadioButton
    Friend WithEvents Rder As System.Windows.Forms.RadioButton
    Friend WithEvents Raba As System.Windows.Forms.RadioButton
    Friend WithEvents Lntrat As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Lndie As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRut As System.Windows.Forms.TextBox
    Friend WithEvents Lfecha As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Lnom As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
End Class
