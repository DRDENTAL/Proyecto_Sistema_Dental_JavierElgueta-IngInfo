Imports System.Data.SqlClient
Public Class IngresarID
    Public coneccion As SqlClient.SqlConnection
    Dim accion As String, rut As String, sql As String
    Dim res As Integer, id As Integer

    Dim com As SqlClient.SqlCommand, dr As SqlClient.SqlDataReader
    Dim da As SqlClient.SqlDataAdapter, cb As SqlClient.SqlCommandBuilder
    Dim ds As DataSet
    Dim conexion As New SqlConnection("server=LENOVO-PC; database=DRDENTAL; integrated security=true")
    Public Sub conectar()
        coneccion = New SqlClient.SqlConnection
        coneccion.ConnectionString = "server=LENOVO-PC; database=DRDENTAL; integrated security=true"
        coneccion.Open()
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = Nothing Then
            TextBox2.Enabled = False
        Else
            TextBox2.Enabled = True

        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        'If Me.TextBox2.Text = "" Then
        '    Me.TextBox2.Enabled = False
        'Else
        '    Me.TextBox2.Enabled = True
        'End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Button2.PerformClick()
                'If TextBox1.Text = Nothing Then

                '    m1.Visible = True
                'End If
                TextBox2.Focus()

                '`'  txtTotal.Text = (txtTasaB.Text + txtComisionB.Text + txtGasto.Text + txtIva.Text + txtNotificacion.Text)
        End Select
    End Sub

    Private Sub IngresarID_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim da As New SqlDataAdapter("select id,nombres,apellidos,fecha,horas,minutos from dbo.citas where rut = '" + TextBox1.Text + "' ", conexion)
            Dim ds As New DataSet
            da.Fill(ds, "citas")
            Me.DataGridView1.DataSource = ds.Tables("citas")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        verificarQUITAR()
    End Sub
    Private Sub verificarQUITAR()
        If TextBox1.Text = "" Then
            m1.Visible = True
        Else
            m1.Visible = False
        End If

        If TextBox2.Text = "" Then
            m2.Visible = True
        Else
            m2.Visible = False
        End If
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            Call Me.quitarDefinitivo()
        End If
    End Sub
    Private Sub quitarDefinitivo()
        rut = TextBox1.Text
        id = TextBox2.Text
        Dim result As Integer = MessageBox.Show("¿ Está seguro que quiere borrar la cita ?", "Saliendo...", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            TextBox1.Select()
        ElseIf result = DialogResult.Yes Then
            If rut <> "" Then

                sql = "exec buscar_citas '" + TextBox2.Text + "','" + TextBox1.Text + "'"
                conectar()
                com = New SqlClient.SqlCommand(sql, coneccion)
                dr = com.ExecuteReader
                If dr.Read Then

                    sql = "exec Quitar_citas" + "'" + TextBox2.Text + "','" + TextBox1.Text + "'"
                    conectar()

                    com = New SqlClient.SqlCommand(sql, coneccion)
                    res = com.ExecuteNonQuery
                    coneccion.Close()

                    MsgBox("Nueva hora de Cita habilitada", MsgBoxStyle.Information, "Borrado Correctamente")
                    ''MsgBox("Paciente encontrado", MsgBoxStyle.Exclamation, "Citas")
                    'If TextBox2.Text <> dr(0) Then
                    'And TextBox1.Text = dr(1) Then

                Else
                    MsgBox("La cita " + "" + TextBox2.Text + "" + " no se encuentra")
                End If
            End If
            End If

            Try
                Dim da As New SqlDataAdapter("select id,nombres,apellidos,fecha,horas,minutos from dbo.citas where rut= '" & rut & "' ", conexion)
                Dim ds As New DataSet
                da.Fill(ds, "citas")
                Me.DataGridView1.DataSource = ds.Tables("citas")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        'Else

        '    MsgBox("Paciente o Cita no existe", MsgBoxStyle.Exclamation, "Acceso Denegado")
        '    TextBox1.Text = ""

        'End If

            'End If
            'End If


    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Button1.PerformClick()
                'If TextBox1.Text = Nothing Then

                '    m1.Visible = True
                'End If
                TextBox1.Focus()

                '`'  txtTotal.Text = (txtTasaB.Text + txtComisionB.Text + txtGasto.Text + txtIva.Text + txtNotificacion.Text)
        End Select
    End Sub
End Class