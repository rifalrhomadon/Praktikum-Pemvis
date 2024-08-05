Imports System.Data.SqlClient
Public Class Form2
    Dim Conn As SqlConnection
    Dim Da As SqlDataAdapter
    Dim Ds As DataSet
    Dim MyDB As String
    Sub Koneksi()
        MyDB = "Data Source = RIFAL ; initial catalog = MakananBeku; integrated security = true"
        Conn = New SqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Da = New SqlDataAdapter("SELECT * FROM MakananBeku", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "MakananBeku")
        DataGridView1.DataSource = (Ds.Tables("MakananBeku"))
    End Sub
End Class