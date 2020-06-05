Public Class Form1
    Private listNama As New List(Of String)

    Private Sub tombolTambah_Click(sender As Object, e As EventArgs) Handles tombolTambah.Click
        'menambahkan nama ke List
        listNama.Add(teksNama.Text)

        'membersihkan kotak teks
        teksNama.Clear()
        teksNama.Focus()
    End Sub

    Private Sub tombolTampil_Click(sender As Object, e As EventArgs) Handles tombolTampil.Click
        'menampilkan semua nama pada kotak list
        Dim intIndeks As Integer = 0
        Dim strNama As String

        For intIndeks = 0 To listNama.Count - 1
            strNama = listNama(intIndeks)
            listTeman.Items.Add(strNama)
        Next
    End Sub

    Private Sub tombolCari_Click(sender As Object, e As EventArgs) Handles tombolCari.Click
        Dim intPosisi As Integer = listNama.IndexOf(teksCari.Text)

        'Apakah ditemukan di dalam List?
        If intPosisi <> -1 Then
            listTeman.SelectedItem = listTeman.Items(intPosisi)
            MessageBox.Show("Teman yang Anda cari ditemukan pada indeks " &
            intPosisi)
        Else
            MessageBox.Show("Teman yang Anda cari tidak ditemukan.")
        End If
    End Sub
End Class
