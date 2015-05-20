Imports System.Data.SqlClient
Public Class PACIENTES
    Public coneccion As SqlClient.SqlConnection
    Dim accion As String, rut As String, sql As String
    Dim res As Integer, nombres, apellidos, telefono, email As String
    Dim com As SqlClient.SqlCommand, dr As SqlClient.SqlDataReader
    Dim da As SqlClient.SqlDataAdapter, cb As SqlClient.SqlCommandBuilder
    Dim ds As DataSet
    Dim conexion As New SqlConnection("server=LENOVO-PC; database=DRDENTAL; integrated security=true")
    Public Sub conectar()
        coneccion = New SqlClient.SqlConnection
        coneccion.ConnectionString = "server=LENOVO-PC; database=DRDENTAL; integrated security=true"
        coneccion.Open()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub PACIENTES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtRut.FindForm()
        Me.txtRut.CharacterCasing = CharacterCasing.Upper
        Me.txtNomApe.CharacterCasing = CharacterCasing.Upper
        Me.txtApellido.CharacterCasing = CharacterCasing.Upper
        Me.txtEmail.CharacterCasing = CharacterCasing.Lower
        Me.txtRut.Select()
        txtNomApe.Enabled = False
        txtApellido.Enabled = False
        txtEmail.Enabled = False
        txtTel.Enabled = False
        Try
            Dim da As New SqlDataAdapter("select rut,nombres,apellidos,telefono,email from dbo.pacientes", conexion)
            Dim ds As New DataSet
            da.Fill(ds, "pacientes")
            Me.DataGridView1.DataSource = ds.Tables("pacientes")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtRut_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRut.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtTel_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTel.KeyPress
        'SOLO NUMEROS'
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
    End Sub
    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub verificardatos()
        rut = txtRut.Text
        nombres = txtNomApe.Text
        apellidos = txtApellido.Text
        telefono = txtTel.Text
        email = txtEmail.Text
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
            m3.Visible = True
        Else
            m3.Visible = False
        End If

        txtRut.Select()
        If txtRut.Text <> "" And txtNomApe.Text <> "" And txtApellido.Text <> "" Then
            Call Me.registrarpaciente()
        End If
    End Sub
    Private Sub registrarpaciente()
        rut = txtRut.Text
        nombres = txtNomApe.Text
        apellidos = txtApellido.Text
        telefono = txtTel.Text
        email = txtEmail.Text
        sql = "exec ver_pacientes '" + rut + "'"
        conectar()
        com = New SqlClient.SqlCommand(sql, coneccion)
        dr = com.ExecuteReader
        If dr.Read Then
            com = New SqlClient.SqlCommand(sql, coneccion)
            sql = "exec editar_pacientes" + "'" + rut + "','" + nombres + "','" + apellidos + "','" + telefono + "','" + email + "'"
            conectar()
            com = New SqlClient.SqlCommand(sql, coneccion)
            res = com.ExecuteNonQuery
            MessageBox.Show("Ha guardado exitosamente", "pacientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            coneccion.Close()

            Try
                Dim da As New SqlDataAdapter("select rut,nombres,apellidos,telefono,email from dbo.pacientes where rut= '" & rut & "' ", conexion)
                Dim ds As New DataSet
                da.Fill(ds, "pacientes")
                Me.DataGridView1.DataSource = ds.Tables("pacientes")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            txtRut.Text = ""
            txtNomApe.Text = ""
            txtApellido.Text = ""
            txtTel.Text = ""
            txtEmail.Text = ""
            'segunda
            'sql = "exec ver_pacientes '" + rut + "'"
            'conectar()
            'com = New SqlClient.SqlCommand(sql, coneccion)
            'dr = com.ExecuteReader
            'If dr.Read Then
            '    If rut = dr(0) And nombres = dr(1) Then
            '        'AGENDA.txtrut.Text = dr(0)
            '        'AGENDA.txtNombres.Text = dr(1)
            '        Me.Close()
            '        'AGENDA.Show()
            '    End If
            'End If


        Else
            sql = "exec ingresar_pacientes '" + rut + "','" + nombres + "','" + apellidos + "','" + telefono + "','" + email + "'"
            conectar()
            com = New SqlClient.SqlCommand(sql, coneccion)
            res = com.ExecuteNonQuery
            coneccion.Close()

            Try
                Dim da As New SqlDataAdapter("select rut,nombres,apellidos,telefono,email from dbo.pacientes where rut= '" & rut & "' ", conexion)
                Dim ds As New DataSet
                da.Fill(ds, "pacientes")
                Me.DataGridView1.DataSource = ds.Tables("pacientes")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            txtRut.Text = ""
            txtNomApe.Text = ""
            txtApellido.Text = ""
            txtTel.Text = ""
            txtEmail.Text = ""
            'sql = "exec ver_pacientes '" + rut + "'"
            'conectar()
            'com = New SqlClient.SqlCommand(sql, coneccion)
            'dr = com.ExecuteReader
            'If dr.Read Then
            '    If rut = dr(0) And nombres = dr(1) Then
            '        'AGENDA.txtrut.Text = dr(0)
            '        'AGENDA.txtNombres.Text = dr(1)
            '        Me.Close()
            '        'AGENDA.Show()
            '    End If
            'End If



            MsgBox("Paciente Guardado", MsgBoxStyle.Information, "Ingreso Correcto")
        End If
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call Me.verificardatos()
    End Sub
    'Private Sub actualizarpaciente()
    '    rut = txtRut.Text
    '    nombres = txtNomApe.Text
    '    apellidos = mApellido.Text
    '    telefono = txtTel.Text
    '    email = txtEmail.Text
    '    sql = "exec ver_pacientes '" + rut + "'"
    '    conectar()
    '    com = New SqlClient.SqlCommand(sql, coneccion)
    '    dr = com.ExecuteReader
    '    sql = "exec editar_pacientes" + "'" + rut + "','" + nombres + "','" + apellidos + "','" + telefono + "','" + email + "'"
    '    conectar()
    '    com = New SqlClient.SqlCommand(sql, coneccion)
    '    res = com.ExecuteNonQuery
    '    coneccion.Close()
    '    sql = "exec ver_pacientes '" + rut + "'"
    '    conectar()
    '    com = New SqlClient.SqlCommand(sql, coneccion)
    '    dr = com.ExecuteReader
    '    If dr.Read Then
    '        If rut = dr(0) And nombres = dr(1) Then
    '            Me.Close()
    '            AGENDA.txtrut.Text = dr(0)
    '            AGENDA.txtNombres.Text = dr(1)

    '            AGENDA.Show()
    '        End If
    '    End If
    '    MsgBox("Paciente Actualizado ya puede Agregar una Cita", MsgBoxStyle.Information, "Actualizado Correctamente")
    'End Sub
    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    '    Call Me.actualizarpaciente()
    'End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        verificarrut()
    End Sub
    Private Sub verificarrut()
        rut = txtRut.Text
        nombres = txtNomApe.Text
        apellidos = txtApellido.Text
        telefono = txtTel.Text
        email = txtEmail.Text
        If rut = "" Then
            m1.Visible = True
            m2.Visible = False
            m3.Visible = False
        Else
            m1.Visible = False
        End If
        txtRut.Select()
        If rut <> "" Then
            Call Me.buscarpaciente()
        End If
    End Sub
    Private Sub buscarpaciente()
        If rut <> "" Then
            sql = "exec buscar_pacientes '" + rut + "'"
            conectar()
            com = New SqlClient.SqlCommand(sql, coneccion)
            dr = com.ExecuteReader
            If dr.Read Then
                Me.txtNomApe.Text = dr(1)
                Me.txtApellido.Text = dr(2)
                Me.txtTel.Text = dr(3)
                Me.txtEmail.Text = dr(4)
                Try
                    Dim da As New SqlDataAdapter("select rut,nombres,apellidos,telefono,email from dbo.pacientes where rut= '" & rut & "' ", conexion)
                    Dim ds As New DataSet
                    da.Fill(ds, "pacientes")
                    Me.DataGridView1.DataSource = ds.Tables("pacientes")

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                txtNomApe.Enabled = True
                txtApellido.Enabled = True
                txtTel.Enabled = True
                txtEmail.Enabled = True
            Else
                MsgBox("Paciente no existe", MsgBoxStyle.Critical, "Acceso Denegado")
                txtRut.Text = ""
                txtNomApe.Text = ""
                txtApellido.Text = ""
                txtTel.Text = ""
                txtEmail.Text = ""
                Dim result As Integer = MessageBox.Show("¿ Desea Ingresar un Nuevo Paciente ?", "Busqueda Finalizada", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                    txtNomApe.Enabled = False
                    txtApellido.Enabled = False
                    txtEmail.Enabled = False
                    txtTel.Enabled = False
                ElseIf result = DialogResult.Yes Then
                    txtNomApe.Enabled = True
                    txtApellido.Enabled = True
                    txtTel.Enabled = True
                    txtEmail.Enabled = True
                End If
            End If
            coneccion.Close()

        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''TRATAMIENTOS.Show()
    End Sub

    Private Sub txtRut_MouseLeave(sender As Object, e As EventArgs) Handles txtRut.MouseLeave
        LEjemplo.Visible = False
    End Sub

    Private Sub txtRut_MouseHover(sender As Object, e As EventArgs) Handles txtRut.MouseHover
        LEjemplo.Visible = True
    End Sub

    Private Sub txtRut_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRut.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Button4.PerformClick()
                If txtRut.Text = Nothing Then

                    m1.Visible = True
                End If
                txtRut.Focus()
                '`'  txtTotal.Text = (txtTasaB.Text + txtComisionB.Text + txtGasto.Text + txtIva.Text + txtNotificacion.Text)
        End Select
    End Sub

    Private Sub txtNomApe_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNomApe.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Button1.PerformClick()
                If txtNomApe.Text = Nothing Then

                    m2.Visible = True
                End If
                txtNomApe.Focus()
                '`'  txtTotal.Text = (txtTasaB.Text + txtComisionB.Text + txtGasto.Text + txtIva.Text + txtNotificacion.Text)
        End Select
    End Sub

    Private Sub mApellido_KeyDown(sender As Object, e As KeyEventArgs)
        
    End Sub

    Private Sub txtTel_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTel.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Button1.PerformClick()
                If txtTel.Text = Nothing Then

                    'm4.Visible = True
                End If
                txtTel.Focus()
                '`'  txtTotal.Text = (txtTasaB.Text + txtComisionB.Text + txtGasto.Text + txtIva.Text + txtNotificacion.Text)
        End Select
    End Sub

    Private Sub txtEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Button1.PerformClick()
                If txtEmail.Text = Nothing Then

                    'm5.Visible = True
                End If
                txtEmail.Focus()
                '`'  txtTotal.Text = (txtTasaB.Text + txtComisionB.Text + txtGasto.Text + txtIva.Text + txtNotificacion.Text)
        End Select
    End Sub

    Private Sub txtRut_TextChanged(sender As Object, e As EventArgs) Handles txtRut.TextChanged
        m1.Visible = False
        If txtRut.Text = "" Then
            Try
                Dim da As New SqlDataAdapter("select rut,nombres,apellidos,telefono,email from dbo.pacientes", conexion)
                Dim ds As New DataSet
                da.Fill(ds, "pacientes")
                Me.DataGridView1.DataSource = ds.Tables("pacientes")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtRut.Text = ""
        txtNomApe.Text = ""
        txtApellido.Text = ""
        txtTel.Text = ""
        txtEmail.Text = ""
    End Sub

    Private Sub txtApellido_KeyDown(sender As Object, e As KeyEventArgs) Handles txtApellido.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Button1.PerformClick()
                If txtApellido.Text = Nothing Then

                    m3.Visible = True
                End If
                txtApellido.Focus()
                '`'  txtTotal.Text = (txtTasaB.Text + txtComisionB.Text + txtGasto.Text + txtIva.Text + txtNotificacion.Text)
        End Select
    End Sub

    Private Sub txtNomApe_MouseHover(sender As Object, e As EventArgs) Handles txtNomApe.MouseHover
        'Cursor.Current = Cursors.WaitCursor
    End Sub

    Private Sub txtNomApe_MouseLeave(sender As Object, e As EventArgs) Handles txtNomApe.MouseLeave
        'Cursor.Current = Cursors.WaitCursor
    End Sub
End Class