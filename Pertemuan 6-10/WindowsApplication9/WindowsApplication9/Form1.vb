Imports System.Data.SqlClient
Public Class Form1
    Dim Conn As SqlConnection
    Dim Da As SqlDataAdapter
    Dim Cmd As SqlCommand
    Dim Ds As DataSet
    Dim Rd As SqlDataReader
    Dim MyDb As String
    Sub Koneksi()
        MyDb = "Data Source = RIFAL ; initial catalog = db_barang; integrated security = true"
        Conn = New SqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
    Sub Clear()
        txt_kode.Clear()
        txt_nama.Clear()
        txt_harga.Clear()
        txt_stok.Clear()
    End Sub

    Private Sub KondisiAwal()
        Call Koneksi()
        Call Clear()
        Da = New SqlDataAdapter("select * from tb_barang", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "tb_barang")
        DataGridView1.DataSource = Ds.Tables("tb_barang")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Da = New SqlDataAdapter("select * from tb_barang", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "tb_barang")
        DataGridView1.DataSource = Ds.Tables("tb_barang")
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        If txt_kode.Text = "" Or txt_nama.Text = "" Or txt_harga.Text = "" Or txt_stok.Text = "" Then
            MsgBox("Lengkapi data terlebih dahulu", MsgBoxStyle.Critical, "Failed")
        Else
            Call Koneksi()
            Dim inputData As String = "INSERT INTO tb_barang VALUES ('" & txt_kode.Text & "','" & txt_nama.Text & "','" & txt_harga.Text & "','" & txt_stok.Text & "')"
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
        If txt_kode.Text = "" Or txt_nama.Text = "" Or txt_harga.Text = "" Or txt_stok.Text = "" Then
            MsgBox("Lengkapi data terlebih dahulu", MsgBoxStyle.Critical, "Failed")
        Else
            Call Koneksi()
            Dim updateData As String = "UPDATE tb_barang SET Kode_Barang = '" & txt_kode.Text & "','" & txt_nama.Text & "','" & txt_harga.Text & "','" & txt_stok.Text & "' WHERE Kode_Barang = '" & txt_kode.Text & "'"
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
        If txt_kode.Text = "" Then
            MsgBox("Data Id tidak di temukan", MsgBoxStyle.Critical, "Failed")
        Else
            Call Koneksi()
            Dim deleteData As String = "DELETE tb_barang WHERE Kode_Barang='" & txt_kode.Text & "'"
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
        Cmd = New SqlCommand("SELECT * FROM tb_barang WHERE Kode_Barang='" & txt_cari.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            txt_kode.Text = Rd.Item("Kode_Barang")
            txt_nama.Text = Rd.Item("Nama_Barang")
            txt_harga.Text = Rd.Item("Harga")
            txt_stok.Text = Rd.Item("Stok")
        Else
            MsgBox("Data tidak di temukan!", MsgBoxStyle.Critical, "Failed!")
        End If
    End Sub

    Private Sub btn_report_Click(sender As Object, e As EventArgs) Handles btn_report.Click
        Form2.Show()
    End Sub
End Class
