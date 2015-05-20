<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CopiaProyectoAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CopiaProyectoAdmin))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarPacientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarPagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarPresupuestoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarSecretariasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.DodgerBlue
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarToolStripMenuItem, Me.ToolStripMenuItem1, Me.GestionarPacientesToolStripMenuItem, Me.GestionarPagosToolStripMenuItem, Me.GestionarPresupuestoToolStripMenuItem, Me.ToolStripMenuItem2, Me.GestionarSecretariasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 612)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1314, 70)
        Me.MenuStrip1.Stretch = False
        Me.MenuStrip1.TabIndex = 26
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CerrarToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CerrarToolStripMenuItem.Image = CType(resources.GetObject("CerrarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CerrarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(44, 66)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(44, 66)
        '
        'GestionarPacientesToolStripMenuItem
        '
        Me.GestionarPacientesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GestionarPacientesToolStripMenuItem.Name = "GestionarPacientesToolStripMenuItem"
        Me.GestionarPacientesToolStripMenuItem.Size = New System.Drawing.Size(171, 66)
        Me.GestionarPacientesToolStripMenuItem.Text = "Pacientes"
        '
        'GestionarPagosToolStripMenuItem
        '
        Me.GestionarPagosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GestionarPagosToolStripMenuItem.Name = "GestionarPagosToolStripMenuItem"
        Me.GestionarPagosToolStripMenuItem.Size = New System.Drawing.Size(122, 66)
        Me.GestionarPagosToolStripMenuItem.Text = "Pagos"
        '
        'GestionarPresupuestoToolStripMenuItem
        '
        Me.GestionarPresupuestoToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GestionarPresupuestoToolStripMenuItem.Name = "GestionarPresupuestoToolStripMenuItem"
        Me.GestionarPresupuestoToolStripMenuItem.Size = New System.Drawing.Size(231, 66)
        Me.GestionarPresupuestoToolStripMenuItem.Text = "Presupuestos"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(194, 66)
        Me.ToolStripMenuItem2.Text = "Secretarias"
        '
        'GestionarSecretariasToolStripMenuItem
        '
        Me.GestionarSecretariasToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GestionarSecretariasToolStripMenuItem.Name = "GestionarSecretariasToolStripMenuItem"
        Me.GestionarSecretariasToolStripMenuItem.Size = New System.Drawing.Size(148, 66)
        Me.GestionarSecretariasToolStripMenuItem.Text = "Agenda"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 575)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1314, 37)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Cerrar"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 538)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1314, 37)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Minimizar"
        Me.Label2.Visible = False
        '
        'ProyectoAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.OldLace
        Me.BackgroundImage = Global.Proyecto_Sistema_Dental_JavierElgueta_IngInfo.My.Resources.Resources.dental
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1314, 682)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ProyectoAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProyectoAdmin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarPacientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarPagosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarPresupuestoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarSecretariasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
