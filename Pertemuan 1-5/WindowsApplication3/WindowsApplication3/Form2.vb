Public Class Form2

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pilihan, a, b As Integer
        Dim c As Double, phi As Double = 3.14
        a = CInt(txt_n1.Text)
        b = CInt(txt_n2.Text)
        pilihan = InputBox("Pilih Daftar Bangun data : ", "Pilih Bangun Datar", 0)
        Select pilihan
            Case 1
                c = phi * a * a
                MessageBox.Show("Anda Memilih Daftar No " & pilihan, "Konfirmasi Pilihan", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MessageBox.Show("jari-jari Lingkaran : " & a & ", Hasil : " & c, "Penerapan Rumus Luas Lingkaran", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 2
                c = a * b
                MessageBox.Show("Anda Memilih Daftar No " & pilihan, "Konfirmasi Pilihan", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MessageBox.Show("Panjang : " & a & ", Lebar : " & b & ", hasil : " & c, "Penerapan Rumus Luas Persegi Panjang", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 3
                c = a * a
                MessageBox.Show("Anda Memilih Daftar No " & pilihan, "Konfirmasi Pilihan", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MessageBox.Show("Panjang Sisi : " & a & ", hasil : " & c, "Penerapan Rumus Luas Persegi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 4
                c = a * b
                MessageBox.Show("Anda Memilih Daftar No " & pilihan, "Konfirmasi Pilihan", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MessageBox.Show("Alas : " & a & ", Tinggi : " & b & ", hasil : " & c, "Penerapan Rumus Luas Jajar Genjang", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 5
                c = 0.5 * a * b
                MessageBox.Show("Anda Memilih Daftar No " & pilihan, "Konfirmasi Pilihan", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MessageBox.Show("Diagonal 1 : " & a & ", Diagonal 2 : " & b & ", hasil : " & c, "Penerapan Rumus Luas belah ketpuat",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case Else
                MessageBox.Show("Pilihan Anda Tidak Tersedia", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Select
    End Sub
End Class