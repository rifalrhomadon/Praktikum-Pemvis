Public Class Form2
    Sub Bersih()
        txt_kode.Clear()
        txt_barang.Clear()
        txt_jumlah.Clear()
        txt_harga.Clear()
        txt_total.Clear()
    End Sub

    Function hitung()
        If IsNumeric(txt_harga.Text) AndAlso IsNumeric(txt_jumlah.Text) Then
            Dim harga, jumlah, total As Integer
            harga = CInt(txt_harga.Text)
            jumlah = CInt(txt_jumlah.Text)
            total = harga * jumlah
            txt_total.Text = total.ToString()
            MessageBox.Show("Hasil Perhitungan : " & total)
            Return total
        Else
            MessageBox.Show("Harga dan Jumlah harus berupa angka", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return 0
        End If
    End Function
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_total.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(txt_kode.Text) Then
            MessageBox.Show("Kode Barang Harus Diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_kode.Focus()
        ElseIf String.IsNullOrEmpty(txt_jumlah.Text) Then
            MessageBox.Show("Nama Barang Harus Diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_barang.Focus()
        ElseIf String.IsNullOrEmpty(txt_jumlah.Text) Then
            MessageBox.Show("Satuan Barang Harus Diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_jumlah.Focus()
        ElseIf String.IsNullOrEmpty(txt_jumlah.Text) Then
            MessageBox.Show("Harga Barang Harus Diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_harga.Focus()
        Else
            hitung()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call Bersih()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class