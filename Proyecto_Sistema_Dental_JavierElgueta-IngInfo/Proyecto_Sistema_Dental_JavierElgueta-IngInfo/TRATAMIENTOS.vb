Public Class TRATAMIENTOS


    Private Sub TRATAMIENTOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lfecha.Text = Today
        PAGOS.Close()
        PRESUPUESTO.Close()
        Registro.Close()
        PACIENTES.Close()
        AGENDA.Close()
        Me.WindowState = FormWindowState.Maximized
        'NuevoRepositorio https://github.com/DRDENTAL/Proyecto_Sistema_Dental_JavierElgueta-IngInfo.git
    End Sub
End Class