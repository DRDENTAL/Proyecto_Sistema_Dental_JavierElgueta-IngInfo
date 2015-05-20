Imports System.Data.SqlClient
Imports System.IO
Imports System.Data
Imports System.Configuration
Imports System.Text

Public Class PRESUPUESTO
    Public coneccion As SqlClient.SqlConnection
    Dim accion As String, nombre As String, sql As String
    Dim res As Integer, arancel As String
    Dim com As SqlClient.SqlCommand, dr As SqlClient.SqlDataReader
    Dim da As SqlClient.SqlDataAdapter, cb As SqlClient.SqlCommandBuilder
    Dim ds As DataSet
    'Dim conexion As New SqlConnection("server=LENOVO-PC; database=DRDENTAL; integrated security=true")
    Public Sub conectar()
        coneccion = New SqlClient.SqlConnection
        coneccion.ConnectionString = "server=LENOVO-PC; database=DRDENTAL; integrated security=true"
        coneccion.Open()
    End Sub
    Dim AM, CS, CC, EA, EP, ES, D, ETM, S, V, H, FP, UD, R As String
    Dim conexion As New SqlConnection("server=LENOVO-PC; database=DRDENTAL; integrated security=true")
    Public Sub soloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo Numeros", MsgBoxStyle.Information, "Error al ingresar")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'If CheckBox1.Checked = True Then
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            registrarpresupuesto()
            'Button1.Enabled = False
            'CheckBox1.Checked = False
            'MsgBox("Guardado exitosamente ", MsgBoxStyle.Exclamation, "Hecho")

        Else
            'MsgBox("Es necesario que escriba el precio ", MsgBoxStyle.Critical, "Error. Falta un Precio")
            'Button1.Enabled = True
        End If
        'Else
        'MsgBox("Debe seleccionar el tratamiento ", MsgBoxStyle.Question, "Error. No ha Seleccionado")
        'End If
        arancel = TextBox1.Text
        nombre = TextBox2.Text
        'Select Case e.KeyData
        '    Case Keys.Enter
        If TextBox2.Text = Nothing And TextBox1.Text = Nothing Then

            TextBox2.Focus()
            MsgBox("Falta ingresar el Nombre de un Tratamiento o el valor", MessageBoxButtons.OK, "Falta Informacion")
            Try
                Dim da As New SqlDataAdapter("select id,arancel,nombre from dbo.presupuesto", conexion)
                Dim ds As New DataSet
                da.Fill(ds, "presupuesto")
                Me.DataGridView1.DataSource = ds.Tables("presupuesto")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            'Button1.PerformClick()
            TextBox1.Focus()
            Try
                Dim da As New SqlDataAdapter("select id,nombre,arancel from dbo.presupuesto where nombre= '" & nombre & "' ", conexion)
                Dim ds As New DataSet
                da.Fill(ds, "presupuesto")
                Me.DataGridView1.DataSource = ds.Tables("presupuesto")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            'MsgBox("Falta valor")
        End If
        'TextBox2.Focus()
        '`'  txtTotal.Text = (txtTasaB.Text + txtComisionB.Text + txtGasto.Text + txtIva.Text + txtNotificacion.Text)
        'End Select
    End Sub
    'Private Sub GuardarAM()
    Private Sub registrarpresupuesto()
        arancel = TextBox1.Text
        nombre = TextBox2.Text

        sql = "exec ver_presupuesto '" + nombre + "'"
        conectar()
        com = New SqlClient.SqlCommand(sql, coneccion)
        dr = com.ExecuteReader
        If dr.Read Then
            com = New SqlClient.SqlCommand(sql, coneccion)
            sql = "exec editar_presupuesto" + "'" + arancel + "','" + nombre + "'"
            conectar()
            com = New SqlClient.SqlCommand(sql, coneccion)
            res = com.ExecuteNonQuery
            MessageBox.Show("Ha guardado exitosamente", "presupuesto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            coneccion.Close()
            Try
                Dim da As New SqlDataAdapter("select id,arancel,nombre from dbo.presupuesto where nombre= '" & nombre & "' ", conexion)
                Dim ds As New DataSet
                da.Fill(ds, "presupuesto")
                Me.DataGridView1.DataSource = ds.Tables("presupuesto")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            sql = "exec ingresar_presupuesto '" + arancel + "','" + nombre + "'"
            conectar()
            com = New SqlClient.SqlCommand(sql, coneccion)
            res = com.ExecuteNonQuery
            coneccion.Close()

            Try
                Dim da As New SqlDataAdapter("select id,arancel,nombre from dbo.presupuesto where nombre= '" & nombre & "' ", conexion)
                Dim ds As New DataSet
                da.Fill(ds, "presupuesto")
                Me.DataGridView1.DataSource = ds.Tables("presupuesto")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            MsgBox("Paciente Guardado", MsgBoxStyle.Information, "Ingreso Correcto")
        End If
    End Sub
    'Dim cmd As New SqlCommand
    'conexion.Open()
    'cmd.Connection = conexion
    ''cmd.CommandText = "update dbo.presupuesto set arancel ='" & TextBox1.Text.Trim & "' where nombre='" & TextBox2.Text.Trim & "'"
    'cmd.CommandText = "insert nombre= nombre='" & TextBox2.Text & "' into presupuesto where "
    'cmd.ExecuteReader()


    'MsgBox("Dato Registrado Satisfactoriamente", MsgBoxStyle.Exclamation, "Agregado Correctamente.")
    'conexion.Close()
    'End Sub



    'Private Sub registrarpaciente()
    '    rut = txtRut.Text
    '    nombres = txtNomApe.Text
    '    apellidos = txtApellido.Text
    '    telefono = txtTel.Text
    '    email = txtEmail.Text
    '    sql = "exec ver_pacientes '" + rut + "'"
    '    conectar()
    '    com = New SqlClient.SqlCommand(sql, coneccion)
    '    dr = com.ExecuteReader
    '    If dr.Read Then
    '        com = New SqlClient.SqlCommand(sql, coneccion)
    '        sql = "exec editar_pacientes" + "'" + rut + "','" + nombres + "','" + apellidos + "','" + telefono + "','" + email + "'"
    '        conectar()
    '        com = New SqlClient.SqlCommand(sql, coneccion)
    '        res = com.ExecuteNonQuery
    '        MessageBox.Show("Ha guardado exitosamente", "pacientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        coneccion.Close()
    '        Try
    '            Dim da As New SqlDataAdapter("select rut,nombres,apellidos,telefono,email from dbo.pacientes where rut= '" & rut & "' ", conexion)
    '            Dim ds As New DataSet
    '            da.Fill(ds, "pacientes")
    '            Me.DataGridView1.DataSource = ds.Tables("pacientes")

    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    Else
    '        sql = "exec ingresar_pacientes '" + rut + "','" + nombres + "','" + apellidos + "','" + telefono + "','" + email + "'"
    '        conectar()
    '        com = New SqlClient.SqlCommand(sql, coneccion)
    '        res = com.ExecuteNonQuery
    '        coneccion.Close()

    '        Try
    '            Dim da As New SqlDataAdapter("select rut,nombres,apellidos,telefono,email from dbo.pacientes where rut= '" & rut & "' ", conexion)
    '            Dim ds As New DataSet
    '            da.Fill(ds, "pacientes")
    '            Me.DataGridView1.DataSource = ds.Tables("pacientes")

    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '        MsgBox("Paciente Guardado", MsgBoxStyle.Information, "Ingreso Correcto")
    '    End If
    'End Sub



    'Private Sub GuardarCS()
    '    Dim cmd As New SqlCommand
    '    conexion.Open()
    '    cmd.Connection = conexion
    '    cmd.CommandText = "update dbo.presupuesto set arancel ='" & TextBox2.Text.Trim & "' where nombre='CS'"
    '    cmd.ExecuteReader()
    '    MsgBox("Dato Registrado Satisfactoriamente", MsgBoxStyle.Exclamation, "Agregado Correctamente.")
    '    conexion.Close()
    'End Sub
    'Private Sub GuardarCC()
    '    Dim cmd As New SqlCommand
    '    conexion.Open()
    '    cmd.Connection = conexion
    '    cmd.CommandText = "update dbo.presupuesto set arancel ='" & TextBox3.Text.Trim & "' where nombre='CC'"
    '    cmd.ExecuteReader()
    '    MsgBox("Dato Registrado Satisfactoriamente", MsgBoxStyle.Exclamation, "Agregado Correctamente.")
    '    conexion.Close()
    'End Sub
    'Private Sub GuardarEA()
    '    Dim cmd As New SqlCommand
    '    conexion.Open()
    '    cmd.Connection = conexion
    '    cmd.CommandText = "update dbo.presupuesto set arancel ='" & TextBox4.Text.Trim & "' where nombre='EA'"
    '    cmd.ExecuteReader()
    '    MsgBox("Dato Registrado Satisfactoriamente", MsgBoxStyle.Exclamation, "Agregado Correctamente.")
    '    conexion.Close()
    'End Sub
    'Private Sub GuardarEP()
    '    Dim cmd As New SqlCommand
    '    conexion.Open()
    '    cmd.Connection = conexion
    '    cmd.CommandText = "update dbo.presupuesto set arancel ='" & TextBox5.Text.Trim & "' where nombre='EP'"
    '    cmd.ExecuteReader()
    '    MsgBox("Dato Registrado Satisfactoriamente", MsgBoxStyle.Exclamation, "Agregado Correctamente.")
    '    conexion.Close()
    'End Sub
    'Private Sub GuardarES()
    '    Dim cmd As New SqlCommand
    '    conexion.Open()
    '    cmd.Connection = conexion
    '    cmd.CommandText = "update dbo.presupuesto set arancel ='" & TextBox6.Text.Trim & "' where nombre='ES'"
    '    cmd.ExecuteReader()
    '    MsgBox("Dato Registrado Satisfactoriamente", MsgBoxStyle.Exclamation, "Agregado Correctamente.")
    '    conexion.Close()
    'End Sub
    'Private Sub GuardarD()
    '    Dim cmd As New SqlCommand
    '    conexion.Open()
    '    cmd.Connection = conexion
    '    cmd.CommandText = "update dbo.presupuesto set arancel ='" & TextBox7.Text.Trim & "' where nombre='D'"
    '    cmd.ExecuteReader()
    '    MsgBox("Dato Registrado Satisfactoriamente", MsgBoxStyle.Exclamation, "Agregado Correctamente.")
    '    conexion.Close()
    'End Sub
    'Private Sub GuardarETM()
    '    Dim cmd As New SqlCommand
    '    conexion.Open()
    '    cmd.Connection = conexion
    '    cmd.CommandText = "update dbo.presupuesto set arancel ='" & TextBox8.Text.Trim & "' where nombre='ETM'"
    '    cmd.ExecuteReader()
    '    MsgBox("Dato Registrado Satisfactoriamente", MsgBoxStyle.Exclamation, "Agregado Correctamente.")
    '    conexion.Close()
    'End Sub
    'Private Sub GuardarS()
    '    Dim cmd As New SqlCommand
    '    conexion.Open()
    '    cmd.Connection = conexion
    '    cmd.CommandText = "update dbo.presupuesto set arancel ='" & TextBox9.Text.Trim & "' where nombre='S'"
    '    cmd.ExecuteReader()
    '    MsgBox("Dato Registrado Satisfactoriamente", MsgBoxStyle.Exclamation, "Agregado Correctamente.")
    '    conexion.Close()
    'End Sub
    'Private Sub GuardarV()
    '    Dim cmd As New SqlCommand
    '    conexion.Open()
    '    cmd.Connection = conexion
    '    cmd.CommandText = "update dbo.presupuesto set arancel ='" & TextBox10.Text.Trim & "' where nombre='V'"
    '    cmd.ExecuteReader()
    '    MsgBox("Dato Registrado Satisfactoriamente", MsgBoxStyle.Exclamation, "Agregado Correctamente.")
    '    conexion.Close()
    'End Sub
    'Private Sub GuardarH()
    '    Dim cmd As New SqlCommand
    '    conexion.Open()
    '    cmd.Connection = conexion
    '    cmd.CommandText = "update dbo.presupuesto set arancel ='" & TextBox11.Text.Trim & "' where nombre='H'"
    '    cmd.ExecuteReader()
    '    MsgBox("Dato Registrado Satisfactoriamente", MsgBoxStyle.Exclamation, "Agregado Correctamente.")
    '    conexion.Close()
    'End Sub
    'Private Sub GuardarFP()
    '    Dim cmd As New SqlCommand
    '    conexion.Open()
    '    cmd.Connection = conexion
    '    cmd.CommandText = "update dbo.presupuesto set arancel ='" & TextBox12.Text.Trim & "' where nombre='FP'"
    '    cmd.ExecuteReader()
    '    MsgBox("Dato Registrado Satisfactoriamente", MsgBoxStyle.Exclamation, "Agregado Correctamente.")
    '    conexion.Close()
    'End Sub
    'Private Sub GuardarUD()
    '    Dim cmd As New SqlCommand
    '    conexion.Open()
    '    cmd.Connection = conexion
    '    cmd.CommandText = "update dbo.presupuesto set arancel ='" & TextBox13.Text.Trim & "' where nombre='UD'"
    '    cmd.ExecuteReader()
    '    MsgBox("Dato Registrado Satisfactoriamente", MsgBoxStyle.Exclamation, "Agregado Correctamente.")
    '    conexion.Close()
    'End Sub
    'Private Sub GuardarR()
    '    Dim cmd As New SqlCommand
    '    conexion.Open()
    '    cmd.Connection = conexion
    '    cmd.CommandText = "update dbo.presupuesto set arancel ='" & TextBox14.Text.Trim & "' where nombre='R'"
    '    cmd.ExecuteReader()
    '    MsgBox("Dato Registrado Satisfactoriamente", MsgBoxStyle.Exclamation, "Agregado Correctamente.")
    '    conexion.Close()
    'End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        soloNumeros(e)
    End Sub

    'Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    soloNumeros(e)
    'End Sub

    'Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    soloNumeros(e)
    'End Sub

    'Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    soloNumeros(e)
    'End Sub

    'Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    soloNumeros(e)
    'End Sub

    'Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    soloNumeros(e)
    'End Sub

    'Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    soloNumeros(e)
    'End Sub

    'Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    soloNumeros(e)
    'End Sub

    'Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    soloNumeros(e)
    'End Sub

    'Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    soloNumeros(e)
    'End Sub

    'Private Sub TextBox11_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    soloNumeros(e)
    'End Sub

    'Private Sub TextBox12_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    soloNumeros(e)
    'End Sub

    'Private Sub TextBox13_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    soloNumeros(e)
    'End Sub

    'Private Sub TextBox14_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    soloNumeros(e)
    'End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs)
    '    If CheckBox2.Checked = True Then
    '        If TextBox2.Text <> "" Then
    '            GuardarCS()
    '            Button2.Enabled = False
    '            CheckBox2.Checked = False
    '        Else
    '            MsgBox("Falta el precio ", MsgBoxStyle.Information, "Información")
    '        End If
    '    Else
    '        MsgBox("Debe seleccionar ", MsgBoxStyle.Information, "Información")
    '    End If
    'End Sub

    'Private Sub Button4_Click(sender As Object, e As EventArgs)
    '    If CheckBox3.Checked = True Then
    '        If TextBox3.Text <> "" Then
    '            GuardarCC()
    '            Button4.Enabled = False
    '            CheckBox3.Checked = False
    '        Else
    '            MsgBox("Falta el precio ", MsgBoxStyle.Information, "Información")
    '        End If
    '    Else
    '        MsgBox("Debe seleccionar ", MsgBoxStyle.Information, "Información")
    '    End If
    'End Sub

    'Private Sub Button5_Click(sender As Object, e As EventArgs)
    '    If CheckBox4.Checked = True Then
    '        If TextBox4.Text <> "" Then
    '            GuardarEA()
    '            Button5.Enabled = False
    '            CheckBox4.Checked = False
    '        Else
    '            MsgBox("Falta el precio ", MsgBoxStyle.Information, "Información")
    '        End If
    '    Else
    '        MsgBox("Debe seleccionar ", MsgBoxStyle.Information, "Información")
    '    End If
    'End Sub

    'Private Sub Button6_Click(sender As Object, e As EventArgs)
    '    If CheckBox5.Checked = True Then
    '        If TextBox5.Text <> "" Then
    '            GuardarEP()
    '            Button6.Enabled = False
    '            CheckBox5.Checked = False
    '        Else
    '            MsgBox("Falta el precio ", MsgBoxStyle.Information, "Información")
    '        End If
    '    Else
    '        MsgBox("Debe seleccionar ", MsgBoxStyle.Information, "Información")
    '    End If
    'End Sub

    'Private Sub Button7_Click(sender As Object, e As EventArgs)
    '    If CheckBox6.Checked = True Then
    '        If TextBox6.Text <> "" Then
    '            GuardarES()
    '            Button7.Enabled = False
    '            CheckBox6.Checked = False
    '        Else
    '            MsgBox("Falta el precio ", MsgBoxStyle.Information, "Información")
    '        End If
    '    Else
    '        MsgBox("Debe seleccionar ", MsgBoxStyle.Information, "Información")
    '    End If
    'End Sub

    'Private Sub Button8_Click(sender As Object, e As EventArgs)
    '    If CheckBox7.Checked = True Then
    '        If TextBox7.Text <> "" Then
    '            GuardarD()
    '            Button8.Enabled = False
    '            CheckBox7.Checked = False
    '        Else
    '            MsgBox("Falta el precio ", MsgBoxStyle.Information, "Información")
    '        End If
    '    Else
    '        MsgBox("Debe seleccionar ", MsgBoxStyle.Information, "Información")
    '    End If
    'End Sub

    'Private Sub Button9_Click(sender As Object, e As EventArgs)
    '    If CheckBox8.Checked = True Then
    '        If TextBox8.Text <> "" Then
    '            GuardarETM()
    '            Button9.Enabled = False
    '            CheckBox8.Checked = False
    '        Else
    '            MsgBox("Falta el precio ", MsgBoxStyle.Information, "Información")
    '        End If
    '    Else
    '        MsgBox("Debe seleccionar ", MsgBoxStyle.Information, "Información")
    '    End If
    'End Sub

    'Private Sub Button10_Click(sender As Object, e As EventArgs)
    '    If CheckBox9.Checked = True Then
    '        If TextBox9.Text <> "" Then
    '            GuardarS()
    '            Button10.Enabled = False
    '            CheckBox9.Checked = False
    '        Else
    '            MsgBox("Falta el precio ", MsgBoxStyle.Information, "Información")
    '        End If
    '    Else
    '        MsgBox("Debe seleccionar ", MsgBoxStyle.Information, "Información")
    '    End If
    'End Sub

    'Private Sub Button11_Click(sender As Object, e As EventArgs)
    '    If CheckBox10.Checked = True Then
    '        If TextBox10.Text <> "" Then
    '            GuardarV()
    '            Button11.Enabled = False
    '            CheckBox10.Checked = False
    '        Else
    '            MsgBox("Falta el precio ", MsgBoxStyle.Information, "Información")
    '        End If
    '    Else
    '        MsgBox("Debe seleccionar ", MsgBoxStyle.Information, "Información")
    '    End If
    'End Sub

    'Private Sub Button12_Click(sender As Object, e As EventArgs)
    '    If CheckBox11.Checked = True Then
    '        If TextBox11.Text <> "" Then
    '            GuardarH()
    '            Button12.Enabled = False
    '            CheckBox11.Checked = False
    '        Else
    '            MsgBox("Falta el precio ", MsgBoxStyle.Information, "Información")
    '        End If
    '    Else
    '        MsgBox("Debe seleccionar ", MsgBoxStyle.Information, "Información")
    '    End If
    'End Sub

    'Private Sub Button13_Click(sender As Object, e As EventArgs)
    '    If CheckBox12.Checked = True Then
    '        If TextBox12.Text <> "" Then
    '            GuardarFP()
    '            Button13.Enabled = False
    '            CheckBox12.Checked = False
    '        Else
    '            MsgBox("Falta el precio ", MsgBoxStyle.Information, "Información")
    '        End If
    '    Else
    '        MsgBox("Debe seleccionar ", MsgBoxStyle.Information, "Información")
    '    End If
    'End Sub

    'Private Sub Button14_Click(sender As Object, e As EventArgs)
    '    If CheckBox13.Checked = True Then
    '        If TextBox13.Text <> "" Then
    '            GuardarUD()
    '            Button14.Enabled = False
    '            CheckBox13.Checked = False
    '        Else
    '            MsgBox("Falta el precio ", MsgBoxStyle.Information, "Información")
    '        End If
    '    Else
    '        MsgBox("Debe seleccionar ", MsgBoxStyle.Information, "Información")
    '    End If
    'End Sub

    'Private Sub Button15_Click(sender As Object, e As EventArgs)
    '    If CheckBox14.Checked = True Then
    '        If TextBox14.Text <> "" Then
    '            GuardarR()
    '            Button15.Enabled = False
    '            CheckBox14.Checked = False
    '        Else
    '            MsgBox("Falta el precio ", MsgBoxStyle.Information, "Información")
    '        End If
    '    Else
    '        MsgBox("Debe seleccionar ", MsgBoxStyle.Information, "Información")
    '    End If
    'End Sub

    Private Sub PRESUPUESTO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Select()
        'CheckBox1.Checked = False
        'CheckBox2.Checked = False
        'CheckBox3.Checked = False
        'CheckBox4.Checked = False
        'CheckBox5.Checked = False
        'CheckBox6.Checked = False
        'CheckBox7.Checked = False
        'CheckBox8.Checked = False
        'CheckBox9.Checked = False
        'CheckBox10.Checked = False
        'CheckBox11.Checked = False
        'CheckBox12.Checked = False
        'CheckBox13.Checked = False
        'CheckBox14.Checked = False
        'AM = TextBox1.Text
        'CS = TextBox2.Text
        'CC = TextBox3.Text
        'EA = TextBox4.Text
        'EP = TextBox5.Text
        'ES = TextBox6.Text
        'D = TextBox7.Text
        'ETM = TextBox8.Text
        'S = TextBox9.Text
        'V = TextBox10.Text
        'H = TextBox11.Text
        'FP = TextBox12.Text
        'UD = TextBox13.Text
        'R = TextBox14.Text
        '1
        'Try
        '    conexion.Open()
        '    Dim sql As New StringBuilder()
        '    sql.Append("select arancel ")
        '    sql.Append("from presupuesto ")
        '    sql.Append("where nombre=@nombre ")
        '    Dim Comando As New SqlCommand(sql.ToString, conexion)
        '    With Comando
        '        .Parameters.Add(New SqlParameter("@nombre", SqlDbType.VarChar, 12)).Value = "'" & TextBox2.Text.Trim & "'"
        '    End With
        '    Dim drrut As SqlDataReader
        '    drrut = Comando.ExecuteReader
        '    While drrut.Read
        '        'TextBox1.Text = IIf(IsDBNull(drrut("arancel")), Nothing, drrut("arancel"))
        '        TextBox2.Text = IIf(IsDBNull(drrut("arancel")), Nothing, drrut("arancel"))
        '    End While
        '    conexion.Close()
        'Catch sqlExc As SqlException
        '    MessageBox.Show(sqlExc.ToString, "SQL Exception Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        'End Try
        ''2
        'Try
        '    conexion.Open()
        '    Dim sql As New StringBuilder()
        '    sql.Append("select arancel ")
        '    sql.Append("from presupuesto ")
        '    sql.Append("where nombre=@nombre ")
        '    Dim Comando As New SqlCommand(sql.ToString, conexion)
        '    With Comando
        '        .Parameters.Add(New SqlParameter("@nombre", SqlDbType.VarChar, 12)).Value = "CS"
        '    End With
        '    Dim drrut As SqlDataReader
        '    drrut = Comando.ExecuteReader
        '    While drrut.Read
        '        TextBox2.Text = IIf(IsDBNull(drrut("arancel")), Nothing, drrut("arancel"))
        '    End While
        '    conexion.Close()
        'Catch sqlExc As SqlException
        '    MessageBox.Show(sqlExc.ToString, "SQL Exception Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
        ''3
        'Try
        '    conexion.Open()
        '    Dim sql As New StringBuilder()
        '    sql.Append("select arancel ")
        '    sql.Append("from presupuesto ")
        '    sql.Append("where nombre=@nombre ")
        '    Dim Comando As New SqlCommand(sql.ToString, conexion)
        '    With Comando
        '        .Parameters.Add(New SqlParameter("@nombre", SqlDbType.VarChar, 12)).Value = "CC"
        '    End With
        '    Dim drrut As SqlDataReader
        '    drrut = Comando.ExecuteReader
        '    While drrut.Read
        '        TextBox3.Text = IIf(IsDBNull(drrut("arancel")), Nothing, drrut("arancel"))
        '    End While
        '    conexion.Close()
        'Catch sqlExc As SqlException
        '    MessageBox.Show(sqlExc.ToString, "SQL Exception Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
        ''4
        'Try
        '    conexion.Open()
        '    Dim sql As New StringBuilder()
        '    sql.Append("select arancel ")
        '    sql.Append("from presupuesto ")
        '    sql.Append("where nombre=@nombre ")
        '    Dim Comando As New SqlCommand(sql.ToString, conexion)
        '    With Comando
        '        .Parameters.Add(New SqlParameter("@nombre", SqlDbType.VarChar, 12)).Value = "EA"
        '    End With
        '    Dim drrut As SqlDataReader
        '    drrut = Comando.ExecuteReader
        '    While drrut.Read
        '        TextBox4.Text = IIf(IsDBNull(drrut("arancel")), Nothing, drrut("arancel"))
        '    End While
        '    conexion.Close()
        'Catch sqlExc As SqlException
        '    MessageBox.Show(sqlExc.ToString, "SQL Exception Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
        ''5
        'Try
        '    conexion.Open()
        '    Dim sql As New StringBuilder()
        '    sql.Append("select arancel ")
        '    sql.Append("from presupuesto ")
        '    sql.Append("where nombre=@nombre ")
        '    Dim Comando As New SqlCommand(sql.ToString, conexion)
        '    With Comando
        '        .Parameters.Add(New SqlParameter("@nombre", SqlDbType.VarChar, 12)).Value = "EP"
        '    End With
        '    Dim drrut As SqlDataReader
        '    drrut = Comando.ExecuteReader
        '    While drrut.Read
        '        TextBox5.Text = IIf(IsDBNull(drrut("arancel")), Nothing, drrut("arancel"))
        '    End While
        '    conexion.Close()
        'Catch sqlExc As SqlException
        '    MessageBox.Show(sqlExc.ToString, "SQL Exception Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
        ''6
        'Try
        '    conexion.Open()
        '    Dim sql As New StringBuilder()
        '    sql.Append("select arancel ")
        '    sql.Append("from presupuesto ")
        '    sql.Append("where nombre=@nombre ")
        '    Dim Comando As New SqlCommand(sql.ToString, conexion)
        '    With Comando
        '        .Parameters.Add(New SqlParameter("@nombre", SqlDbType.VarChar, 12)).Value = "ES"
        '    End With
        '    Dim drrut As SqlDataReader
        '    drrut = Comando.ExecuteReader
        '    While drrut.Read
        '        TextBox6.Text = IIf(IsDBNull(drrut("arancel")), Nothing, drrut("arancel"))
        '    End While
        '    conexion.Close()
        'Catch sqlExc As SqlException
        '    MessageBox.Show(sqlExc.ToString, "SQL Exception Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
        ''7
        'Try
        '    conexion.Open()
        '    Dim sql As New StringBuilder()
        '    sql.Append("select arancel ")
        '    sql.Append("from presupuesto ")
        '    sql.Append("where nombre=@nombre ")
        '    Dim Comando As New SqlCommand(sql.ToString, conexion)
        '    With Comando
        '        .Parameters.Add(New SqlParameter("@nombre", SqlDbType.VarChar, 12)).Value = "D"
        '    End With
        '    Dim drrut As SqlDataReader
        '    drrut = Comando.ExecuteReader
        '    While drrut.Read
        '        TextBox7.Text = IIf(IsDBNull(drrut("arancel")), Nothing, drrut("arancel"))
        '    End While
        '    conexion.Close()
        'Catch sqlExc As SqlException
        '    MessageBox.Show(sqlExc.ToString, "SQL Exception Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
        ''8
        'Try
        '    conexion.Open()
        '    Dim sql As New StringBuilder()
        '    sql.Append("select arancel ")
        '    sql.Append("from presupuesto ")
        '    sql.Append("where nombre=@nombre ")
        '    Dim Comando As New SqlCommand(sql.ToString, conexion)
        '    With Comando
        '        .Parameters.Add(New SqlParameter("@nombre", SqlDbType.VarChar, 12)).Value = "ETM"
        '    End With
        '    Dim drrut As SqlDataReader
        '    drrut = Comando.ExecuteReader
        '    While drrut.Read
        '        TextBox8.Text = IIf(IsDBNull(drrut("arancel")), Nothing, drrut("arancel"))
        '    End While
        '    conexion.Close()
        'Catch sqlExc As SqlException
        '    MessageBox.Show(sqlExc.ToString, "SQL Exception Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
        ''9
        'Try
        '    conexion.Open()
        '    Dim sql As New StringBuilder()
        '    sql.Append("select arancel ")
        '    sql.Append("from presupuesto ")
        '    sql.Append("where nombre=@nombre ")
        '    Dim Comando As New SqlCommand(sql.ToString, conexion)
        '    With Comando
        '        .Parameters.Add(New SqlParameter("@nombre", SqlDbType.VarChar, 12)).Value = "S"

        '    End With
        '    Dim drrut As SqlDataReader
        '    drrut = Comando.ExecuteReader
        '    While drrut.Read
        '        TextBox9.Text = IIf(IsDBNull(drrut("arancel")), Nothing, drrut("arancel"))
        '    End While
        '    conexion.Close()
        'Catch sqlExc As SqlException
        '    MessageBox.Show(sqlExc.ToString, "SQL Exception Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
        ''10
        'Try
        '    conexion.Open()
        '    Dim sql As New StringBuilder()
        '    sql.Append("select arancel ")
        '    sql.Append("from presupuesto ")
        '    sql.Append("where nombre=@nombre ")
        '    Dim Comando As New SqlCommand(sql.ToString, conexion)
        '    With Comando
        '        .Parameters.Add(New SqlParameter("@nombre", SqlDbType.VarChar, 12)).Value = "V"
        '    End With
        '    Dim drrut As SqlDataReader
        '    drrut = Comando.ExecuteReader
        '    While drrut.Read
        '        TextBox10.Text = IIf(IsDBNull(drrut("arancel")), Nothing, drrut("arancel"))
        '    End While
        '    conexion.Close()
        'Catch sqlExc As SqlException
        '    MessageBox.Show(sqlExc.ToString, "SQL Exception Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
        ''11
        'Try
        '    conexion.Open()
        '    Dim sql As New StringBuilder()
        '    sql.Append("select arancel ")
        '    sql.Append("from presupuesto ")
        '    sql.Append("where nombre=@nombre ")
        '    Dim Comando As New SqlCommand(sql.ToString, conexion)
        '    With Comando
        '        .Parameters.Add(New SqlParameter("@nombre", SqlDbType.VarChar, 12)).Value = "H"
        '    End With
        '    Dim drrut As SqlDataReader
        '    drrut = Comando.ExecuteReader
        '    While drrut.Read
        '        TextBox11.Text = IIf(IsDBNull(drrut("arancel")), Nothing, drrut("arancel"))
        '    End While
        '    conexion.Close()
        'Catch sqlExc As SqlException
        '    MessageBox.Show(sqlExc.ToString, "SQL Exception Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
        ''12
        'Try
        '    conexion.Open()
        '    Dim sql As New StringBuilder()
        '    sql.Append("select arancel ")
        '    sql.Append("from presupuesto ")
        '    sql.Append("where nombre=@nombre ")
        '    Dim Comando As New SqlCommand(sql.ToString, conexion)
        '    With Comando
        '        .Parameters.Add(New SqlParameter("@nombre", SqlDbType.VarChar, 12)).Value = "FP"
        '    End With
        '    Dim drrut As SqlDataReader
        '    drrut = Comando.ExecuteReader
        '    While drrut.Read
        '        TextBox12.Text = IIf(IsDBNull(drrut("arancel")), Nothing, drrut("arancel"))
        '    End While
        '    conexion.Close()
        'Catch sqlExc As SqlException
        '    MessageBox.Show(sqlExc.ToString, "SQL Exception Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
        ''13
        'Try
        '    conexion.Open()
        '    Dim sql As New StringBuilder()
        '    sql.Append("select arancel ")
        '    sql.Append("from presupuesto ")
        '    sql.Append("where nombre=@nombre ")
        '    Dim Comando As New SqlCommand(sql.ToString, conexion)
        '    With Comando
        '        .Parameters.Add(New SqlParameter("@nombre", SqlDbType.VarChar, 12)).Value = "UD"
        '    End With
        '    Dim drrut As SqlDataReader
        '    drrut = Comando.ExecuteReader
        '    While drrut.Read
        '        TextBox13.Text = IIf(IsDBNull(drrut("arancel")), Nothing, drrut("arancel"))
        '    End While
        '    conexion.Close()
        'Catch sqlExc As SqlException
        '    MessageBox.Show(sqlExc.ToString, "SQL Exception Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
        ''14
        'Try
        '    conexion.Open()
        '    Dim sql As New StringBuilder()
        '    sql.Append("select arancel ")
        '    sql.Append("from presupuesto ")
        '    sql.Append("where nombre=@nombre ")
        '    Dim Comando As New SqlCommand(sql.ToString, conexion)
        '    With Comando
        '        .Parameters.Add(New SqlParameter("@nombre", SqlDbType.VarChar, 12)).Value = "R"
        '    End With
        '    Dim drrut As SqlDataReader
        '    drrut = Comando.ExecuteReader
        '    While drrut.Read
        '        TextBox14.Text = IIf(IsDBNull(drrut("arancel")), Nothing, drrut("arancel"))
        '    End While
        '    conexion.Close()
        'Catch sqlExc As SqlException
        '    MessageBox.Show(sqlExc.ToString, "SQL Exception Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
        Try
            Dim da As New SqlDataAdapter("select id,arancel,nombre from dbo.presupuesto", conexion)
            Dim ds As New DataSet
            da.Fill(ds, "presupuesto")
            Me.DataGridView1.DataSource = ds.Tables("presupuesto")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        arancel = TextBox1.Text
        nombre = TextBox2.Text
        Select Case e.KeyData
            Case Keys.Enter
                If TextBox1.Text <> "" And TextBox2.Text <> "" Then
                    registrarpresupuesto()
                    'Button1.Enabled = False
                    'CheckBox1.Checked = False
                    'MsgBox("Guardado exitosamente ", MsgBoxStyle.Exclamation, "Hecho")

                Else
                    'MsgBox("Es necesario que escriba el precio ", MsgBoxStyle.Critical, "Error. Falta un Precio")
                    'Button1.Enabled = True
                End If
                If TextBox2.Text = Nothing Then

                    TextBox2.Focus()
                    MsgBox("Debe ingresar el Nombre de un Tratamiento", MessageBoxButtons.OK, "Falta Informacion")
                    Try
                        Dim da As New SqlDataAdapter("select id,arancel,nombre from dbo.presupuesto", conexion)
                        Dim ds As New DataSet
                        da.Fill(ds, "presupuesto")
                        Me.DataGridView1.DataSource = ds.Tables("presupuesto")

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    Button1.PerformClick()
                    TextBox1.Focus()
                    Try
                        Dim da As New SqlDataAdapter("select id,arancel,nombre from dbo.presupuesto where nombre= '" & nombre & "' ", conexion)
                        Dim ds As New DataSet
                        da.Fill(ds, "presupuesto")
                        Me.DataGridView1.DataSource = ds.Tables("presupuesto")

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    'MsgBox("Falta valor")
                End If
                'TextBox2.Focus()
                '`'  txtTotal.Text = (txtTasaB.Text + txtComisionB.Text + txtGasto.Text + txtIva.Text + txtNotificacion.Text)
        End Select
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        arancel = TextBox1.Text
        nombre = TextBox2.Text
        Select Case e.KeyData
            Case Keys.Enter
                If TextBox1.Text <> "" And TextBox2.Text <> "" Then
                    registrarpresupuesto()
                    'Button1.Enabled = False
                    'CheckBox1.Checked = False
                    'MsgBox("Guardado exitosamente ", MsgBoxStyle.Exclamation, "Hecho")

                Else
                    'MsgBox("Es necesario que escriba el precio ", MsgBoxStyle.Critical, "Error. Falta un Precio")
                    'Button1.Enabled = True
                End If
                If TextBox1.Text = Nothing Then

                    TextBox1.Focus()
                    MsgBox("Debe ingresar el Nombre de un Tratamiento", MessageBoxButtons.OK, "Falta Informacion")
                    Try
                        Dim da As New SqlDataAdapter("select id,arancel,nombre from dbo.presupuesto", conexion)
                        Dim ds As New DataSet
                        da.Fill(ds, "presupuesto")
                        Me.DataGridView1.DataSource = ds.Tables("presupuesto")

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    Button1.PerformClick()
                    TextBox2.Focus()
                    Try
                        Dim da As New SqlDataAdapter("select id,arancel,nombre from dbo.presupuesto where nombre= '" & nombre & "' ", conexion)
                        Dim ds As New DataSet
                        da.Fill(ds, "presupuesto")
                        Me.DataGridView1.DataSource = ds.Tables("presupuesto")

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    'MsgBox("Falta valor")
                End If
                'TextBox2.Focus()
                '`'  txtTotal.Text = (txtTasaB.Text + txtComisionB.Text + txtGasto.Text + txtIva.Text + txtNotificacion.Text)
        End Select
    End Sub
End Class