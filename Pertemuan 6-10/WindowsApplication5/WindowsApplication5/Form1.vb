Imports System.Data.SqlClient
Public Class Form1
    Dim Conn As SqlConnection
    Dim Da As SqlDataAdapter
    Dim Ds As DataSet
    Dim MyDB As String
    Sub Koneksi()
        MyDB = "Data Source = RIFAL; initial catalog = Bab7; integrated security = true"
        Conn = New SqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Da = New SqlDataAdapter("SELECT * FROM db_jurusan", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "db_jurusan")
        DataGridView1.DataSource = (Ds.Tables("db_jurusan"))
    End Sub
End Class
