Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arr(3, 1) As String
        arr(0, 0) = "NIM"
        arr(0, 1) = "Nama"
        arr(1, 0) = "Jenis Kelamin"
        arr(1, 1) = "Status"
        arr(2, 0) = "Laki-laki"
        arr(2, 1) = "Perempuan"
        arr(3, 0) = "Aktif"
        arr(3, 1) = "Non-Aktif"
        ListView1.GridLines = True
        ListView1.View = View.Details
        For baris = 0 To 1
            For kolom = 0 To 1
                ListView1.Columns.Add(arr(baris, kolom), 100)
            Next
        Next
        For Baris = 2 To 2
            For kolom = 0 To 1
                ComboBox1.Items.Add(arr(Baris, kolom))
            Next
        Next
        For Baris = 3 To 3
            For kolom = 0 To 1
                ComboBox2.Items.Add(arr(Baris, kolom))
            Next
        Next
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim arr(4) As String
        arr(0) = tbNim.Text
        arr(1) = tbNama.Text
        arr(2) = ComboBox1.Text
        arr(3) = ComboBox2.Text
        Dim list As New ListViewItem
        list = ListView1.Items.Add(arr(0))
        list.SubItems.Add(arr(1))
        list.SubItems.Add(arr(2))
        list.SubItems.Add(arr(3))
        tbNim.Text = ""
        tbNama.Text = ""
    End Sub
End Class