Public Class Form3

    
    Dim angka1, angka2 As String
    Dim hasil As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        angka1.Split(" ")
        angka2.Split(" ")
        If operasi.Text = "Tambah" Then
            hasil = angka1 + angka2
        Else
            hasil = angka1 - angka2
        End If
        hasilBox.Text = hasil
    End Sub
End Class