Imports System.Data.SqlClient
Public Class AGENDA
    Public coneccion As SqlClient.SqlConnection
    Dim accion As String, rut As String, sql As String
    Dim res As Integer, nombres, apellidos, fecha, horas, minutos As String
    Dim com As SqlClient.SqlCommand, dr As SqlClient.SqlDataReader
    Dim da As SqlClient.SqlDataAdapter, cb As SqlClient.SqlCommandBuilder
    Dim ds As DataSet
    Dim conexion As New SqlConnection("server=LENOVO-PC; database=DRDENTAL; integrated security=true")
    Public Sub conectar()
        coneccion = New SqlClient.SqlConnection
        coneccion.ConnectionString = "server=LENOVO-PC; database=DRDENTAL; integrated security=true"
        coneccion.Open()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'lFechaHoy.Text = Date.Today
    End Sub
    Private Sub AGENDA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Timer1.Start()
        MessageBox.Show("Debe pedir el Rut al Paciente", " Antes de continuar...", MessageBoxButtons.OK, MessageBoxIcon.Error)
        PAGOS.Close()
        PRESUPUESTO.Close()
        Registro.Close()
        PACIENTES.Close()
        Me.WindowState = FormWindowState.Maximized

        txtrut.CharacterCasing = CharacterCasing.Upper

        Try
            Dim da As New SqlDataAdapter("select rut,nombres,apellidos,fecha,horas,minutos from dbo.citas where fecha = CAST(GETDATE() AS DATE) ", conexion)
            Dim ds As New DataSet
            da.Fill(ds, "citas")
            Me.DataGridView1.DataSource = ds.Tables("citas")
        Catch ex As Exception
            'MsgBox("Para agregar una cita debe ingresar un rut", MsgBoxStyle.Information, "Ingresar Citas")
        End Try
        txtrut.Select()

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub bGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bGuardar.Click
        verificarcita()
    End Sub
    Private Sub verificarcita()
        rut = txtrut.Text
        nombres = txtNombres.Text
        apellidos = txtApellidos.Text


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

        txtrut.Select()
        If txtrut.Text <> "" Then
            Call Me.registrarcita()


        End If
    End Sub
    Private Sub registrarcita()
        rut = txtrut.Text
        nombres = txtNombres.Text
        apellidos = txtApellidos.Text
        Dim fecha As DateTime = (MonthCalendar1.SelectionRange.Start)
        Me.MonthCalendar1.ShowToday = True
        horas = NumericUpDown1.Text
        minutos = NumericUpDown2.Text

        sql = "exec ver_citas '" + fecha + "', '" + horas + "', '" + minutos + "'"
        conectar()
        com = New SqlClient.SqlCommand(sql, coneccion)
        dr = com.ExecuteReader
        If dr.Read Then
            MessageBox.Show("La hora esta ocupada", "citas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dr.Close()
            coneccion.Close()
        Else
            Try
                sql = "exec guardar_citas" + "'" + rut + "','" + nombres + "','" + apellidos + "','" + fecha + "','" + horas + "','" + minutos + "'"
                conectar()
                com = New SqlClient.SqlCommand(sql, coneccion)
                res = com.ExecuteNonQuery

                '        sql = "exec ver_citas '" + fecha + "', '" + hora + "', '" + minutos + "'"
                '        conectar()
                '        com = New SqlClient.SqlCommand(sql, coneccion)
                '        dr = com.ExecuteReader
                '        If dr.Read Then

                '            Me.WindowState = FormWindowState.Normal
                '            PAGOS.txtRutPagos.Text = dr(1)
                '            PAGOS.txtNombres.Text = dr(2)
                '            PAGOS.Show()

                '        End If
                MsgBox("Cita Gardada !", MsgBoxStyle.Information, "Registrado Correctamente")
            Catch
                'MsgBox("Ya existe este codigo de cita", MsgBoxStyle.Exclamation)
            End Try

        End If

        Try
            Dim da As New SqlDataAdapter("select rut,nombres,apellidos,fecha,horas,minutos from dbo.citas where rut= '" & rut & "' ", conexion)
            Dim ds As New DataSet
            da.Fill(ds, "citas")
            Me.DataGridView1.DataSource = ds.Tables("citas")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub bBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bBuscar.Click
        verificarrut()
    End Sub
    Private Sub verificarrut()
        rut = txtrut.Text
        nombres = txtNombres.Text
        apellidos = txtApellidos.Text
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
                'MsgBox("Paciente encontrado", MsgBoxStyle.Exclamation, "Citas")
            Else
                MsgBox("Paciente no existe", MsgBoxStyle.Exclamation, "Acceso Denegado")
                txtrut.Text = ""
            End If
            coneccion.Close()
        End If

        Try
            Dim da As New SqlDataAdapter("select rut,nombres,apellidos,fecha,horas,minutos from dbo.citas where rut= '" & rut & "' ", conexion)
            Dim ds As New DataSet
            da.Fill(ds, "citas")
            Me.DataGridView1.DataSource = ds.Tables("citas")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim da As New SqlDataAdapter("select rut,nombres,apellidos,fecha,horas,minutos from dbo.citas ", conexion)
            Dim ds As New DataSet
            da.Fill(ds, "citas")
            Me.DataGridView1.DataSource = ds.Tables("citas")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim da As New SqlDataAdapter("select rut,nombres,apellidos,fecha,horas,minutos from dbo.citas where fecha = CAST(GETDATE() AS DATE) ", conexion)
            Dim ds As New DataSet
            da.Fill(ds, "citas")
            Me.DataGridView1.DataSource = ds.Tables("citas")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub trutcita_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrut.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub bmañana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bmañana.Click
        Try
            Dim da As New SqlDataAdapter("select rut,nombres,apellidos,fecha,horas,minutos from dbo.citas where fecha > CAST(GETDATE() AS DATE) ", conexion)
            Dim ds As New DataSet
            da.Fill(ds, "citas")
            Me.DataGridView1.DataSource = ds.Tables("citas")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        verificardatos()
    End Sub
    Private Sub verificardatos()

        rut = txtrut.Text
        nombres = txtNombres.Text
    
        If rut = "" Then
            m1.Visible = True
        Else
            m1.Visible = False
        End If
        'If nombres = "" Then
        '    m2.Visible = True
        'Else
        '    m2.Visible = False
        'End If
      
        If rut <> "" Then
            Call Me.cambiarcita()
        End If
    End Sub
    Private Sub cambiarcita()
        sql = "exec ver_citas '" + fecha + "','" + horas + "','" + minutos + "'"
        conectar()
        com = New SqlClient.SqlCommand(sql, coneccion)
        dr = com.ExecuteReader
        sql = "exec cambiar_citas" + "'" + rut + "','" + nombres + "','" + fecha + "','" + horas + "','" + minutos + "'"
        conectar()
        com = New SqlClient.SqlCommand(sql, coneccion)
        res = com.ExecuteNonQuery
        coneccion.Close()
        MsgBox("Paciente Actualizado ya puede Agregar una Cita", MsgBoxStyle.Information, "Actualizado Correctamente")
    End Sub

    Private Sub txtCod_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
    End Sub

    'Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
    '    verificarQUITAR()
    'End Sub
    'Private Sub verificarQUITAR()

    '    rut = txtrut.Text
    '    nombres = txtNombres.Text

    '    If rut = "" Then
    '        m1.Visible = True
    '    Else
    '        m1.Visible = False
    '    End If

    '    If cod_cita = "" Then
    '        m2.Visible = True
    '    Else
    '        m2.Visible = False
    '    End If
    '    If cod_cita <> "" And rut <> "" Then
    '        Call Me.QUITARcita()
    '    End If
    'End Sub
    'Private Sub QUITARcita()
    '    sql = "exec ver_citas '" + fecha + "','" + horas + "','" + minutos + "'"
    '    conectar()
    '    com = New SqlClient.SqlCommand(sql, coneccion)
    '    dr = com.ExecuteReader
    '    sql = "exec QUITAR_citas" + "'" + rut + "','" + cod_cita + "'"
    '    conectar()
    '    com = New SqlClient.SqlCommand(sql, coneccion)
    '    res = com.ExecuteNonQuery
    '    coneccion.Close()
    '    MsgBox("Nueva hora de Cita habilitada", MsgBoxStyle.Information, "Borrado Correctamente")
    '    Try
    '        Dim da As New SqlDataAdapter("select cod_cita,rut,nombre,fecha,hora from dbo.citas where rut= '" & rut & "' ", conexion)
    '        Dim ds As New DataSet
    '        da.Fill(ds, "citas")
    '        Me.DataGridView1.DataSource = ds.Tables("citas")

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        'txtCod.Text = Convert.ToString(DataGridView1.Rows.Count())
    End Sub

    Private Sub MonthCalendar1_MouseDown(sender As Object, e As MouseEventArgs) Handles MonthCalendar1.MouseDown
        '    Dim fecha As DateTime = (MonthCalendar1.SelectionRange.Start)
        '    Dim dt2 = Today

        '    Dim fecha = DateDiff(DateInterval.Day, dt, dt2)
        '    If fecha >= dt2.Date Then

        '        'NumericUpDown1.Text = a
        '    Else
        '        MsgBox("Ingrese una fecha valida", MsgBoxStyle.Critical, "Error fecha")
        '    End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub txtrut_KeyDown(sender As Object, e As KeyEventArgs) Handles txtrut.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                bBuscar.PerformClick()
                If txtrut.Text = Nothing Then

                    m1.Visible = True
                End If
                txtrut.Focus()
                '`'  txtTotal.Text = (txtTasaB.Text + txtComisionB.Text + txtGasto.Text + txtIva.Text + txtNotificacion.Text)
        End Select
    End Sub



    Private Sub txtrut_MouseLeave(sender As Object, e As EventArgs) Handles txtrut.MouseLeave

    End Sub

    Private Sub txtrut_MouseUp(sender As Object, e As MouseEventArgs) Handles txtrut.MouseUp
        'MsgBox("Recordar: PEDIR EL RUT O CARNET DE IDENTIDAD AL PACIENTE", MsgBoxStyle.Information, "Antes de Continuar ..")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim result As Integer = MessageBox.Show("¿ Desea quitar una cita ?", "Está seguro que..", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then

            Me.Close()
            IngresarID.MdiParent = ProyectoAdmin
            IngresarID.Show()
        End If
    End Sub
End Class