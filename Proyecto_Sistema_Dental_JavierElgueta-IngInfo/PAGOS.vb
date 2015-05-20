Imports System.Data.SqlClient
Public Class PAGOS
    Public coneccion As SqlClient.SqlConnection
    Dim accion As String, rut As String, sql As String
    Dim res As Integer, nombres, apellidos, monto, fecha, tratamiento As String
    Dim com As SqlClient.SqlCommand, dr As SqlClient.SqlDataReader
    Dim da As SqlClient.SqlDataAdapter, cb As SqlClient.SqlCommandBuilder
    Dim ds As DataSet
    Dim conexion As New SqlConnection("server=LENOVO-PC; database=DRDENTAL; integrated security=true")
    Public Sub conectar()
        coneccion = New SqlClient.SqlConnection
        coneccion.ConnectionString = "server=LENOVO-PC; database=DRDENTAL; integrated security=true"
        coneccion.Open()
    End Sub
    Public Sub soloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo Numeros", MsgBoxStyle.Information, "Error")
        End If
    End Sub
    Private Sub PAGOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DRDENTALDataSet.presupuesto' Puede moverla o quitarla según sea necesario.
        'Me.PresupuestoTableAdapter.Fill(Me.DRDENTALDataSet.presupuesto)
        txtRutPagos.CharacterCasing = CharacterCasing.Upper
        Try
            Dim da As New SqlDataAdapter("select rut,nombres,apellidos,fecha,monto,tratamiento from dbo.pagos", conexion)
            Dim ds As New DataSet
            da.Fill(ds, "pagos")
            Me.DataGridView1.DataSource = ds.Tables("pagos")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try

            Dim da As New SqlDataAdapter("select nombre from dbo.presupuesto", conexion)
            Dim ds As New DataSet
            da.Fill(ds, "presupuesto")
            ComboBox1.DataSource = ds.Tables(0)
            ComboBox1.ValueMember = ds.Tables(0).Columns(0).Caption
            ComboBox1.DisplayMember = ds.Tables(0).Columns(0).Caption.ToString
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub bPago_Click(sender As Object, e As EventArgs) Handles bPago.Click
        verificarpago()
    End Sub
    Private Sub verificarpago()
        rut = txtRutPagos.Text
        nombres = txtNombres.Text
        apellidos = txtApellidos.Text
        fecha = Today
        monto = TextBox1.Text

        If rut = "" Then

            m1.Visible = True

        Else
            m1.Visible = False
        End If
        If nombres = "" Then
            m2.Visible = True
        Else
            m2.Visible = False
        End If
        If apellidos = "" Then
            Label5.Visible = True
        Else
            Label5.Visible = False
        End If

        If monto = "" Then
            m3.Visible = True
        Else
            m3.Visible = False
        End If
        If txtRutPagos.Text <> "" And txtNombres.Text <> "" And txtApellidos.Text <> "" And TextBox1.Text <> "" Then
            Call Me.registrarpago()
        Else
            txtNombres.Text = ""
            txtApellidos.Text = ""
            MsgBox("No se guardo el pago", MsgBoxStyle.Exclamation)
        End If
    End Sub
    Private Sub registrarpago()
        rut = txtRutPagos.Text
        nombres = txtNombres.Text
        apellidos = txtApellidos.Text
        fecha = Today
        monto = TextBox1.Text
        tratamiento = ComboBox1.Text
        Try
            sql = "exec efectuar_pago" + "'" + rut + "','" + nombres + "','" + apellidos + "','" + fecha + "','" + monto + "','" + tratamiento + "'"
            conectar()
            com = New SqlClient.SqlCommand(sql, coneccion)
            res = com.ExecuteNonQuery
            MsgBox("Tratamiento Pagado", MsgBoxStyle.Information, "Registro de Pago")
            Try
                Dim da As New SqlDataAdapter("select rut,nombres,apellidos,fecha,monto,tratamiento from dbo.pagos where rut= '" & rut & "' ", conexion)
                Dim ds As New DataSet
                da.Fill(ds, "pagos")
                Me.DataGridView1.DataSource = ds.Tables("pagos")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch
            MsgBox("No se guardo el pago", MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Private Sub bBusPac_Click(sender As Object, e As EventArgs) Handles bBusPac.Click
        verificarrut()
    End Sub
    Private Sub verificarrut()
        rut = txtRutPagos.Text
        nombres = txtNombres.Text
        If rut = "" Then
            m1.Visible = True
        Else
            m1.Visible = False
        End If
        Call Me.buscarpaciente()
    End Sub
    Private Sub buscarpaciente()
        If rut <> "" Then
            sql = "exec buscar_pacientes '" + rut + "'"
            conectar()
            com = New SqlClient.SqlCommand(sql, coneccion)
            dr = com.ExecuteReader
            If dr.Read Then
                Me.txtNombres.Text = dr(1)
                Me.txtApellidos.Text = dr(2)
                Try
                    Dim da As New SqlDataAdapter("select rut,nombres,apellidos,fecha,monto,tratamiento from dbo.pagos where rut= '" & rut & "' ", conexion)
                    Dim ds As New DataSet
                    da.Fill(ds, "pagos")
                    Me.DataGridView1.DataSource = ds.Tables("pagos")

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MsgBox("Paciente no existe", MsgBoxStyle.Exclamation, "Acceso Denegado")
                txtRutPagos.Text = ""
                txtNombres.Text = ""
                txtApellidos.Text = ""
                m2.Visible = False
                m3.Visible = False
                'Dim result As Integer = MessageBox.Show("¿ Desea Ingresar un Nuevo Paciente ?", "Busqueda Finalizada", MessageBoxButtons.YesNo)
                'If result = DialogResult.No Then
                '    txtNombres.Enabled = False
                '    txtApellidos.Enabled = False
                'ElseIf result = DialogResult.Yes Then
                '    txtNombres.Enabled = True
                '    txtApellidos.Enabled = True
                'End If
                coneccion.Close()
            End If
        End If
    End Sub

    Private Sub txtRutPagos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRutPagos.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub txtRutPagos_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRutPagos.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                bBusPac.PerformClick()
                If txtRutPagos.Text = Nothing Then

                    m1.Visible = True
                End If
                txtRutPagos.Focus()
                '`'  txtTotal.Text = (txtTasaB.Text + txtComisionB.Text + txtGasto.Text + txtIva.Text + txtNotificacion.Text)
        End Select
    End Sub

    Private Sub txtRutPagos_TextChanged(sender As Object, e As EventArgs) Handles txtRutPagos.TextChanged
        m1.Visible = False
        If txtRutPagos.Text = "" Then
            Try
                Dim da As New SqlDataAdapter("select rut,nombres,apellidos,fecha,monto,tratamiento from dbo.pagos", conexion)
                Dim ds As New DataSet
                da.Fill(ds, "pagos")
                Me.DataGridView1.DataSource = ds.Tables("pagos")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                bPago.PerformClick()
                If txtRutPagos.Text = Nothing Then

                    m1.Visible = True
                End If
                txtRutPagos.Focus()
                '`'  txtTotal.Text = (txtTasaB.Text + txtComisionB.Text + txtGasto.Text + txtIva.Text + txtNotificacion.Text)
        End Select
    End Sub
End Class