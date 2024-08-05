Imports System.Data.SqlClient
Public Class Form1
    Dim Conn As SqlConnection
    Dim Da As SqlDataAdapter
    Dim Cmd As SqlCommand
    Dim Ds As DataSet
    Dim Rd As SqlDataReader
    Dim MyDb As String

    Sub Koneksi()
        MyDb = "Data Source=RIFAL; initial catalog=bab7;integrated security=true"
        Conn = New SqlConnection(MyDb)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub

    Sub Clear()
        txtNIM.Clear()
        txtNama.Clear()
        txt_jurusan.Clear()
        txt_angkatan.Clear()
    End Sub

    Private Sub KondisiAwal()
        Call Koneksi()
        Call Clear()
        Da = New SqlDataAdapter("select * from tb_mahasiswa", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "tb_mahasiswa")
        DataGridView1.DataSource = Ds.Tables("tb_mahasiswa")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Da = New SqlDataAdapter("select * from tb_mahasiswa", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "tb_mahasiswa")
        DataGridView1.DataSource = Ds.Tables("tb_mahasiswa")
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        If txtNIM.Text = "" Or txtNama.Text = "" Or txt_jurusan.Text = "" Or txt_angkatan.Text = "" Then
            MsgBox("Lengkapi data terlebih dahulu", MsgBoxStyle.Critical, "Failed")
        Else
            Call Koneksi()
            Dim inputData As String = "INSERT INTO tb_mahasiswa VALUES ('" & txtNIM.Text & "','" & txtNama.Text & "','" & txt_jurusan.Text & "','" & txt_angkatan.Text & "')"
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
        If txtNIM.Text = "" Or txtNama.Text = "" Or txt_jurusan.Text = "" Or txt_angkatan.Text = "" Then
            MsgBox("Lengkapi data terlebih dahulu", MsgBoxStyle.Critical, "Failed")
        Else
            Call Koneksi()
            Dim updateData As String = "UPDATE tb_mahasiswa SET nim = '" & txtNIM.Text & "', nama='" & txtNama.Text & "', angkatan='" & txt_angkatan.Text & "', jurusan='" & txt_jurusan.Text & "' WHERE nim = '" & txtNIM.Text & "'"
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
        If txtNIM.Text = "" Then
            MsgBox("Data NIM tidak di temukan", MsgBoxStyle.Critical, "Failed")
        Else
            Call Koneksi()
            Dim deleteData As String = "DELETE tb_mahasiswa WHERE nim='" & txtNIM.Text & "'"
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

    Private Sub btn_cari_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        Call Koneksi()
        Cmd = New SqlCommand("SELECT * FROM tb_mahasiswa WHERE nim='" & txtCari.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            txtNIM.Text = Rd.Item("nim")
            txtNama.Text = Rd.Item("nama")
            txt_jurusan.Text = Rd.Item("jurusan")
            txt_angkatan.Text = Rd.Item("angkatan")
        Else
            MsgBox("Data tidak di temukan!", MsgBoxStyle.Critical, "Failed!")
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Call Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
    End Sub
End Class
