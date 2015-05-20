Public Class Registro
    Public coneccion As SqlClient.SqlConnection
    Dim accion As String, rut As String, sql As String
    Dim res As Integer, nombres, apellidos, telefono, email, pass As String
    'Dim telefono As Integer
    Dim com As SqlClient.SqlCommand, dr As SqlClient.SqlDataReader
    Dim da As SqlClient.SqlDataAdapter, cb As SqlClient.SqlCommandBuilder
    Dim ds As DataSet
    Public Sub conectar()
        coneccion = New SqlClient.SqlConnection
        coneccion.ConnectionString = "server=LENOVO-PC; database=DRDENTAL; integrated security=true"
        coneccion.Open()
    End Sub
    Private Sub Registro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtRut.FindForm()
        txtRut.Select()
        Me.txtRut.CharacterCasing = CharacterCasing.Upper
        Me.txtNombres.CharacterCasing = CharacterCasing.Upper
        Me.txtApellidos.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Form1.Show()
    End Sub


    Private Sub verificardatos()
        rut = txtRut.Text
        nombres = txtNombres.Text
        apellidos = txtApellidos.Text
        email = txtEmail.Text
        telefono = txtTelefono.Text
        pass = txtPass.Text
        If txtRut.Text = "" Then
            m1.Visible = True
        Else
            m1.Visible = False
        End If
        If txtNombres.Text = "" Then
            m2.Visible = True
        Else
            m2.Visible = False
        End If
        If txtApellidos.Text = "" Then
            m3.Visible = True
        Else
            m3.Visible = False
        End If

        If txtPass.Text = "" Then
            m6.Visible = True
        Else
            m6.Visible = False
        End If
        txtRut.Select()
        If txtRut.Text <> "" And txtNombres.Text <> "" And txtApellidos.Text <> "" And txtPass.Text <> "" Then
            Call Me.registrarSecretaria()


        End If
    End Sub
    Private Sub registrarSecretaria()
        rut = txtRut.Text
        nombres = txtNombres.Text
        apellidos = txtApellidos.Text
        email = txtEmail.Text
        telefono = txtTelefono.Text
        pass = txtPass.Text
        sql = "exec ver_secretarias '" + rut + "'"
        conectar()
        com = New SqlClient.SqlCommand(sql, coneccion)
        dr = com.ExecuteReader
        If dr.Read Then
            com = New SqlClient.SqlCommand(sql, coneccion)
            sql = "exec editar_secretarias" + "'" + rut + "','" + nombres + "','" + apellidos + "','" + telefono + "','" + email + "','" + pass + "'"
            conectar()
            com = New SqlClient.SqlCommand(sql, coneccion)
            res = com.ExecuteNonQuery
            MessageBox.Show("Ha guardado exitosamente", "secretarias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            coneccion.Close()
        Else
            sql = "exec registrar_secretarias" + "'" + rut + "','" + nombres + "','" + apellidos + "','" + telefono + "','" + email + "','" + pass + "'"
            conectar()
            com = New SqlClient.SqlCommand(sql, coneccion)
            res = com.ExecuteNonQuery
            coneccion.Close()
            MsgBox("Felicidades", MsgBoxStyle.Information, "Guardado Correctamente")
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtRut.Text = ""
        txtNombres.Text = ""
        txtApellidos.Text = ""
        txtTelefono.Text = ""
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Call Me.verificardatos()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles btnBuscar.Click
        veriicarSecretaria()
    End Sub
    Private Sub veriicarSecretaria()
        rut = txtRut.Text
        nombres = txtNombres.Text
        apellidos = txtApellidos.Text
        email = txtEmail.Text
        telefono = txtTelefono.Text
        pass = txtPass.Text
        If rut = "" Then
            m1.Visible = True
            m2.Visible = False
            m3.Visible = False
            m6.Visible = False

        Else
            m1.Visible = False
        End If
        txtRut.Select()
        If rut <> "" Then
            Call Me.buscarSecretaria()
        End If

    End Sub
    Private Sub buscarSecretaria()
        If rut <> "" Then
            m1.Visible = False
            sql = "exec buscar_secretarias '" + rut + "'"
            conectar()
            com = New SqlClient.SqlCommand(sql, coneccion)
            dr = com.ExecuteReader
            If dr.Read Then
                Me.txtNombres.Text = dr(2)
                Me.txtApellidos.Text = dr(3)
                Me.txtTelefono.Text = dr(4)
                Me.txtEmail.Text = dr(5)
                Me.txtPass.Text = dr(6)

            Else

                MsgBox("Secretaria no existe", MsgBoxStyle.Critical, "Acceso Denegado")
                txtRut.Text = ""
                txtNombres.Text = ""
                txtApellidos.Text = ""
                txtTelefono.Text = ""
                txtEmail.Text = ""
                txtPass.Text = ""
            End If
            coneccion.Close()
        End If
    End Sub

    Private Sub txtRut_TextChanged(sender As Object, e As EventArgs) Handles txtRut.TextChanged
        m1.Visible = False
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.txtRut.Text = ""
        Me.txtNombres.Text = ""
        Me.txtApellidos.Text = ""
        Me.txtTelefono.Text = ""
        Me.txtEmail.Text = ""
        Me.txtPass.Text = ""
    End Sub

    Private Sub txtRut_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRut.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                btnBuscar.PerformClick()
                If txtRut.Text = Nothing Then

                    m1.Visible = True
                End If
                txtRut.Focus()
                '`'  txtTotal.Text = (txtTasaB.Text + txtComisionB.Text + txtGasto.Text + txtIva.Text + txtNotificacion.Text)
        End Select
    End Sub

    Private Sub txtRut_MouseHover(sender As Object, e As EventArgs) Handles txtRut.MouseHover
        LEjemplo.Visible = True
    End Sub

    Private Sub txtRut_MouseLeave(sender As Object, e As EventArgs) Handles txtRut.MouseLeave
        LEjemplo.Visible = False
    End Sub

  
    Private Sub txtNombres_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombres.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                btnRegistrar.PerformClick()
                If txtNombres.Text = Nothing Then

                    m2.Visible = True
                End If
                txtNombres.Focus()
                '`'  txtTotal.Text = (txtTasaB.Text + txtComisionB.Text + txtGasto.Text + txtIva.Text + txtNotificacion.Text)
        End Select
    End Sub

    Private Sub txtApellidos_KeyDown(sender As Object, e As KeyEventArgs) Handles txtApellidos.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                btnRegistrar.PerformClick()
                If txtApellidos.Text = Nothing Then

                    m3.Visible = True
                End If
                txtApellidos.Focus()
                '`'  txtTotal.Text = (txtTasaB.Text + txtComisionB.Text + txtGasto.Text + txtIva.Text + txtNotificacion.Text)
        End Select
    End Sub

    Private Sub txtTelefono_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTelefono.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                btnRegistrar.PerformClick()
             
                txtTelefono.Focus()
                '`'  txtTotal.Text = (txtTasaB.Text + txtComisionB.Text + txtGasto.Text + txtIva.Text + txtNotificacion.Text)
        End Select
    End Sub

    Private Sub txtEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                btnRegistrar.PerformClick()
               
                txtEmail.Focus()
                '`'  txtTotal.Text = (txtTasaB.Text + txtComisionB.Text + txtGasto.Text + txtIva.Text + txtNotificacion.Text)
        End Select
    End Sub

    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                btnRegistrar.PerformClick()
                If txtPass.Text = Nothing Then

                    m6.Visible = True
                End If
                txtPass.Focus()
                '`'  txtTotal.Text = (txtTasaB.Text + txtComisionB.Text + txtGasto.Text + txtIva.Text + txtNotificacion.Text)
        End Select
    End Sub

    Private Sub txtRut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRut.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub
End Class

