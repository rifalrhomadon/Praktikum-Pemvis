Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arr(7, 1) As String
        arr(0, 0) = "Nomor Induk"
        arr(0, 1) = "Nama Karyawan"
        arr(1, 0) = "Jenis Kelamin"
        arr(1, 1) = "Jabatan"
        arr(2, 0) = "Alamat"
        arr(2, 2) = "Tanggal Lahir"
        arr(3, 0) = "Nomor Telepon"
        arr(3, 3) = "Email"
        arr(4, 0) = "Laki-Laki"
        arr(4, 1) = "Perempuan"
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
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim arr(4) As String
        arr(0) = tbNI.Text
        arr(1) = tbKarya.Text
        arr(2) = ComboBox1.Text
        arr(3) = tbJaba.Text
        arr(4) = tbAlam.Text
        arr(5) = tbTang.Text
        arr(6) = tbNom.Text
        arr(7) = tbEm.Text
        Dim list As New ListViewItem
        list = ListView1.Items.Add(arr(0))
        list.SubItems.Add(arr(1))
        list.SubItems.Add(arr(2))
        list.SubItems.Add(arr(3))
        list.SubItems.Add(arr(4))
        list.SubItems.Add(arr(5))
        list.SubItems.Add(arr(6))
        list.SubItems.Add(arr(7))
        tbNI.Text = ""
        tbKarya.Text = ""
        tbJaba.Text = ""
        tbAlam.Text = ""
        tbTang.Text = ""
        tbNom.Text = ""
        tbEm.Text = ""
    End Sub
End Class