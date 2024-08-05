Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.GridLines = True
        ListView1.View = View.Details
        ListView1.Columns.Add("Kode Barang", 90)
        ListView1.Columns.Add("Nama Barang", 90)
        ListView1.Columns.Add("Jenis Barang", 90)
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim Arr(2) As String
        Dim listitem As ListViewItem
        If tbKode.Text <> "" AndAlso tbNama.Text <> "" AndAlso tbJenis.Text <> "" Then
            Arr(0) = tbKode.Text
            Arr(1) = tbNama.Text
            Arr(2) = tbJenis.Text
            listitem = ListView1.Items.Add(Arr(0))
            listitem.SubItems.Add(Arr(1))
            listitem.SubItems.Add(Arr(2))
            tbNama.Text = ""
            tbKode.Text = ""
            tbJenis.Text = ""
            tbKode.Focus()
        Else
            MessageBox.Show("Semua kolom harus diisi sebelum menambahkan item.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
