Public Class Form2

    Dim kolom, batasBawah, batasAtas, banyakKolom, banyakBaris As Integer
    Dim hasil As String
    Dim baris As Integer = 1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        hasil = ""
        banyakBaris = Convert.ToInt64(barisString.Text)
        banyakKolom = (banyakBaris * 2) - 1
        If Pola.Text = "Piramid" Then
            batasAtas = banyakBaris + 1
            batasBawah = banyakBaris - 1
            For baris As Integer = 1 To banyakBaris
                kolom = 1
                For kolom As Integer = 1 To banyakKolom
                    If kolom > batasBawah And kolom < batasAtas Then
                        hasil &= "*"
                    Else
                        hasil &= " "
                    End If
                Next
                batasBawah -= 1
                batasAtas += 1
                hasil &= vbCrLf

            Next

        ElseIf Pola.Text = "Hollow Piramid" Then
            batasAtas = banyakBaris
            batasBawah = banyakBaris
            For baris As Integer = 1 To banyakBaris
                kolom = 1
                If baris = banyakBaris Then
                    For kolom As Integer = 1 To banyakKolom
                        hasil &= "*"
                    Next
                Else
                    For kolom As Integer = 1 To banyakKolom
                        If kolom = batasBawah Or kolom = batasAtas Then
                            hasil &= "*"
                        Else
                            hasil &= " "
                        End If
                    Next
                End If
                batasBawah -= 1
                batasAtas += 1
                hasil &= vbCrLf
            Next

        ElseIf Pola.Text = "Inverted Piramid" Then
            batasAtas = banyakKolom
            batasBawah = 1
            For baris As Integer = 1 To banyakBaris
                kolom = 1
                For kolom As Integer = 1 To banyakKolom
                    If kolom >= batasBawah And kolom <= batasAtas Then
                        hasil &= "*"
                    Else
                        hasil &= " "
                    End If
                Next
                batasBawah += 1
                batasAtas -= 1
                hasil &= vbCrLf

            Next
        ElseIf Pola.Text = "Hollow Inverted Piramid" Then
            batasAtas = banyakKolom
            batasBawah = 1
            For baris As Integer = 1 To banyakBaris
                kolom = 1
                If baris = 1 Then
                    For kolom As Integer = 1 To banyakKolom
                        hasil &= "*"
                    Next
                Else
                    For kolom As Integer = 1 To banyakKolom
                        If kolom = batasBawah Or kolom = batasAtas Then
                            hasil &= "*"
                        Else
                            hasil &= " "
                        End If
                    Next
                End If
                batasBawah += 1
                batasAtas -= 1
                hasil &= vbCrLf

            Next
        End If
        hasilBox.Text = hasil
    End Sub

End Class