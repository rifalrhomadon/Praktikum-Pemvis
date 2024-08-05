Imports System.Data.SqlClient
Public Class Form2
    Dim Conn As SqlConnection
    Dim Da As SqlDataAdapter
    Dim Cmd As SqlCommand
    Dim Ds As DataSet
    Dim Rd As SqlDataReader
    Dim MyDb As String

    Sub Koneksi()
        MyDb = "Data Source=RIFAL; initial catalog=MakananBeku;integrated security=true"
        Conn = New SqlConnection(MyDb)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub

    Sub Clear()
        txtId.Clear()
        txtNama.Clear()
        txtJenis.Clear()
        txtHarga.Clear()
        txtStok.Clear()
    End Sub

    Private Sub KondisiAwal()
        Call Koneksi()
        Call Clear()
        Da = New SqlDataAdapter("select * from MakananBeku", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "MakananBeku")
        DataGridView1.DataSource = Ds.Tables("MakananBeku")
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Da = New SqlDataAdapter("select * from MakananBeku", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "MakananBeku")
        DataGridView1.DataSource = Ds.Tables("MakananBeku")
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        If txtId.Text = "" Or txtNama.Text = "" Or txtJenis.Text = "" Or txtHarga.Text = "" Or txtStok.Text = "" Then
            MsgBox("Lengkapi data terlebih dahulu", MsgBoxStyle.Critical, "Failed")
        Else
            Call Koneksi()
            Dim inputData As String = "INSERT INTO MakananBeku VALUES ('" & txtId.Text & "','" & txtNama.Text & "','" & txtJenis.Text & "','" & txtHarga.Text & "','" & txtStok.Text & "')"
            Cmd = New SqlCommand(inputData, Conn)
            Try
                Cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Di Input", MsgBoxStyle.Information, "Information")
                Call KondisiAwal()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Failed")
            End Try
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If txtId.Text = "" Or txtNama.Text = "" Or txtJenis.Text = "" Or txtHarga.Text = "" Or txtStok.Text = "" Then
            MsgBox("Lengkapi data terlebih dahulu", MsgBoxStyle.Critical, "Failed")
        Else
            Call Koneksi()
            Dim updateData As String = "UPDATE MakananBeku SET Id_Makanan = '" & txtId.Text & "','" & txtNama.Text & "','" & txtJenis.Text & "','" & txtHarga.Text & "','" & txtStok.Text & "' WHERE Id_Makanan = '" & txtId.Text & "'"
            Cmd = New SqlCommand(updateData, Conn)
            Try
                Cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Di Update", MsgBoxStyle.Information, "Information")
                Call KondisiAwal()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Failed")
            End Try
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If txtId.Text = "" Then
            MsgBox("Data Id tidak di temukan", MsgBoxStyle.Critical, "Failed")
        Else
            Call Koneksi()
            Dim deleteData As String = "DELETE MakananBeku WHERE Id_Makanan='" & txtId.Text & "'"
            Cmd = New SqlCommand(deleteData, Conn)
            Try
                Cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Di Hapus", MsgBoxStyle.Information, "Information")
                Call KondisiAwal()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Failed")
            End Try
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Call Clear()
    End Sub

    Private Sub btn_cari_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        Call Koneksi()
        Cmd = New SqlCommand("SELECT * FROM MakananBeku WHERE Id_Makanan='" & txtCari.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            txtId.Text = Rd.Item("Id_Makanan")
            txtNama.Text = Rd.Item("Nama_Makanan")
            txtJenis.Text = Rd.Item("Jenis_Makanan")
            txtHarga.Text = Rd.Item("Harga")
            txtStok.Text = Rd.Item("Stok")
        Else
            MsgBox("Data tidak di temukan!", MsgBoxStyle.Critical, "Failed!")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
    End Sub
End Class