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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnick = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.m2 = New System.Windows.Forms.Label()
        Me.m1 = New System.Windows.Forms.Label()
        Me.lmin = New System.Windows.Forms.Label()
        Me.lCerr = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(207, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nick"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(178, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña"
        '
        'txtnick
        '
        Me.txtnick.BackColor = System.Drawing.Color.LightGray
        Me.txtnick.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnick.ForeColor = System.Drawing.Color.Black
        Me.txtnick.Location = New System.Drawing.Point(117, 122)
        Me.txtnick.Name = "txtnick"
        Me.txtnick.Size = New System.Drawing.Size(222, 29)
        Me.txtnick.TabIndex = 2
        Me.txtnick.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtpass
        '
        Me.txtpass.BackColor = System.Drawing.Color.LightGray
        Me.txtpass.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.ForeColor = System.Drawing.Color.Black
        Me.txtpass.Location = New System.Drawing.Point(117, 193)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(222, 29)
        Me.txtpass.TabIndex = 3
        Me.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtpass.UseSystemPasswordChar = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Arial Black", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(106, 253)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(247, 74)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "ENTRAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button3.Font = New System.Drawing.Font("Arial Black", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(378, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(47, 35)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "X"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.Font = New System.Drawing.Font("Arial Black", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(12, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(42, 35)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "__"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Playbill", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Info
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(437, 80)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "DR. DENTAL"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'm2
        '
        Me.m2.AutoSize = True
        Me.m2.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m2.ForeColor = System.Drawing.Color.Red
        Me.m2.Location = New System.Drawing.Point(261, 225)
        Me.m2.Name = "m2"
        Me.m2.Size = New System.Drawing.Size(78, 16)
        Me.m2.TabIndex = 19
        Me.m2.Text = "Obligatorio"
        Me.m2.Visible = False
        '
        'm1
        '
        Me.m1.AutoSize = True
        Me.m1.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m1.ForeColor = System.Drawing.Color.Red
        Me.m1.Location = New System.Drawing.Point(261, 152)
        Me.m1.Name = "m1"
        Me.m1.Size = New System.Drawing.Size(78, 16)
        Me.m1.TabIndex = 18
        Me.m1.Text = "Obligatorio"
        Me.m1.Visible = False
        '
        'lmin
        '
        Me.lmin.AutoSize = True
        Me.lmin.BackColor = System.Drawing.Color.White
        Me.lmin.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lmin.ForeColor = System.Drawing.Color.Black
        Me.lmin.Location = New System.Drawing.Point(-3, 52)
        Me.lmin.Name = "lmin"
        Me.lmin.Size = New System.Drawing.Size(75, 18)
        Me.lmin.TabIndex = 20
        Me.lmin.Text = "Minimizar"
        Me.lmin.Visible = False
        '
        'lCerr
        '
        Me.lCerr.AutoSize = True
        Me.lCerr.BackColor = System.Drawing.Color.White
        Me.lCerr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lCerr.ForeColor = System.Drawing.Color.Black
        Me.lCerr.Location = New System.Drawing.Point(372, 52)
        Me.lCerr.Name = "lCerr"
        Me.lCerr.Size = New System.Drawing.Size(53, 18)
        Me.lCerr.TabIndex = 21
        Me.lCerr.Text = "Cerrar"
        Me.lCerr.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Proyecto_Sistema_Dental_JavierElgueta_IngInfo.My.Resources.Resources.MSN_Users
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 344)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(437, 224)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(437, 568)
        Me.Controls.Add(Me.lCerr)
        Me.Controls.Add(Me.lmin)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.m2)
        Me.Controls.Add(Me.m1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnick)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar Sesion"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnick As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents m2 As System.Windows.Forms.Label
    Friend WithEvents m1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lmin As System.Windows.Forms.Label
    Friend WithEvents lCerr As System.Windows.Forms.Label

End Class
