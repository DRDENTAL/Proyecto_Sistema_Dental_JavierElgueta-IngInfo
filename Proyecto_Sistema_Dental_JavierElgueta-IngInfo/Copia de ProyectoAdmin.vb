Public Class CopiaProyectoAdmin


    Private Sub GestionarPacientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarPacientesToolStripMenuItem.Click
        PACIENTES.MdiParent = Me
        PACIENTES.Show()
        My.Forms.PACIENTES.WindowState = FormWindowState.Maximized
        If PACIENTES.Visible = True Then
            PAGOS.Close()
            PRESUPUESTO.Close()
            Registro.Close()
            AGENDA.Close()
        End If
        If Not PAGOS Is Nothing Then
            PAGOS.Close()
        End If
        If Not PRESUPUESTO Is Nothing Then
            PRESUPUESTO.Close()
        End If
        If Not Registro Is Nothing Then
            Registro.Close()
        End If
        If Not AGENDA Is Nothing Then
            AGENDA.Close()
        End If

    End Sub

    Private Sub CerrarToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        If Not PACIENTES Is Nothing Then
            PACIENTES.Close()
        End If
        If Not PAGOS Is Nothing Then
            PAGOS.Close()
        End If
        If Not PRESUPUESTO Is Nothing Then
            PRESUPUESTO.Close()
        End If
        If Not Registro Is Nothing Then
            Registro.Close()
        End If
        If Not AGENDA Is Nothing Then
            AGENDA.Close()
        End If
        AGENDA.Close()
        PACIENTES.Close()
        PAGOS.Close()
        PRESUPUESTO.Close()
        Registro.Close()

        Me.Close()
        Form1.Show()
    End Sub

    Private Sub MinimizarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub GestionarPagosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarPagosToolStripMenuItem.Click
        PAGOS.MdiParent = Me
        PAGOS.Show()
        My.Forms.PAGOS.WindowState = FormWindowState.Maximized
        If PAGOS.Visible = True Then
            PACIENTES.Close()
            PRESUPUESTO.Close()
            Registro.Close()
            AGENDA.Close()
        End If
        If Not PACIENTES Is Nothing Then
            PACIENTES.Close()
        End If
        If Not PRESUPUESTO Is Nothing Then
            PRESUPUESTO.Close()
        End If
        If Not Registro Is Nothing Then
            Registro.Close()
        End If
        If Not AGENDA Is Nothing Then
            AGENDA.Close()
        End If

    End Sub

    Private Sub GestionarPresupuestoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarPresupuestoToolStripMenuItem.Click
        PRESUPUESTO.MdiParent = Me
        PRESUPUESTO.Show()
        My.Forms.PRESUPUESTO.WindowState = FormWindowState.Maximized
        If PRESUPUESTO.Visible = True Then
            PAGOS.Close()
            PACIENTES.Close()
            Registro.Close()
            AGENDA.Close()
        End If
        If Not PACIENTES Is Nothing Then
            PACIENTES.Close()
        End If
        If Not PAGOS Is Nothing Then
            PAGOS.Close()
        End If
        If Not Registro Is Nothing Then
            Registro.Close()
        End If
        If Not AGENDA Is Nothing Then
            AGENDA.Close()
        End If
    End Sub

    Private Sub GestionarSecretariasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarSecretariasToolStripMenuItem.Click
        AGENDA.MdiParent = Me
        AGENDA.Show()
        My.Forms.AGENDA.WindowState = FormWindowState.Maximized
        If AGENDA.Visible = True Then
            PAGOS.Close()
            PRESUPUESTO.Close()
            PACIENTES.Close()
            Registro.Close()
        End If
        If Not PACIENTES Is Nothing Then
            PACIENTES.Close()
        End If
        If Not PAGOS Is Nothing Then
            PAGOS.Close()
        End If
        If Not PRESUPUESTO Is Nothing Then
            PRESUPUESTO.Close()
        End If
        If Not Registro Is Nothing Then
            Registro.Close()
        End If
    End Sub

    Private Sub CerrarToolStripMenuItem1_Click_1(sender As Object, e As EventArgs)

        'Dim result As Integer = MessageBox.Show("Usted está a punto de Salir", "Saliendo...", MessageBoxButtons.YesNoCancel)
        'If result = DialogResult.Cancel Then
        '    MessageBox.Show("Usted ha presionado cancelar")
        'ElseIf result = DialogResult.No Then
        '    MessageBox.Show("Ha negado el cierre")
        'ElseIf result = DialogResult.Yes Then
        '    MessageBox.Show("Usted ha confirmado cerrar.")
        '    Me.Close()
        '    Form1.Show()
        'End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Dim result As Integer = MessageBox.Show("¿ Usted está seguro que quiere Salir ?", "Saliendo...", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then

            Me.Close()
            Form1.Show()
        End If
    End Sub

    Private Sub CerrarToolStripMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.MouseLeave
        Label1.Visible = False
    End Sub

    Private Sub CerrarToolStripMenuItem_MouseHover(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.MouseHover
        Label1.Visible = True

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Registro.MdiParent = Me
        Registro.Show()
        My.Forms.Registro.WindowState = FormWindowState.Maximized
        If Registro.Visible = True Then
            PAGOS.Close()
            PRESUPUESTO.Close()
            PACIENTES.Close()
            AGENDA.Close()
        End If
        If Not PACIENTES Is Nothing Then
            PACIENTES.Close()
        End If
        If Not PAGOS Is Nothing Then
            PAGOS.Close()
        End If
        If Not PRESUPUESTO Is Nothing Then
            PRESUPUESTO.Close()
        End If
    End Sub

    Private Sub ProyectoAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("¡Este producto está hecho para Gestionar a los Pacientes y sus Citas! ", MsgBoxStyle.Information, "BIENVENIDO al Sistema de Información DR.DENTAL")
    End Sub


    Private Sub ToolStripMenuItem1_MouseHover(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.MouseHover
        Label2.Visible = True
    End Sub

    Private Sub ToolStripMenuItem1_MouseLeave(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.MouseLeave
        Label2.Visible = False
    End Sub


End Class