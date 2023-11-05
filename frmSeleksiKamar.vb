'Nama Program:  Seleksi Kamar Hotel
'Programmer  :  Christopher
'Tanggal     :  Mei 18, 2014

Public Class frmSeleksiKamar     'Nama Class sama dengan nama Form

    Private Sub btnStandar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStandar.Click
        'Kode ini dijalankan ketika tombol btnStandar diklik
        picStandar.Visible = True
        picDeluxe.Visible = False
    End Sub

    Private Sub btnDeluxe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeluxe.Click
        'Kode ini dijalankan ketika tombol btnDeluxe diklik
        picDeluxe.Visible = True : picStandar.Visible = False
    End Sub

    Private Sub btnKonfirmasi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKonfirmasi.Click
        'Prosedur ini menutup aplikasi ketika tombol Konfirmasi diklik
        Close()
    End Sub
End Class
