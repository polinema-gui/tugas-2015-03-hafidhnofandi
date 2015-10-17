Public Class FormBintang

    Dim hasil As String = String.Empty

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As String = "Pyramid"
        Dim b As String = "Hollow Pyramid"
        Dim c As String = "Inverted Pyramid"
        Dim d As String = "Hollow Inverted Pyramid"
        Try
            Select Case ComboBox1.Text
                Case a
                    pyramid()
                Case b
                    hollowpyramid()
                Case c
                    invertedpyramid()
                Case d
                    hollowinvertedpyramid()
                Case Else
                    MessageBox.Show("Silahkan pilih pola terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
        Catch ex As Exception
            TextBox2.Text = "Masukan Bukan Angka"
        End Try
    End Sub

    Private Sub pyramid()
        Dim input As Integer = TextBox1.Text
        Dim baris As Integer = 0
        While (baris <= input)
            Dim spasi As Integer = input - 1
            While (spasi >= baris)
                hasil &= " "
                spasi -= 1
            End While
            Dim bintang As Integer = 0
            While (bintang < 2 * baris - 1)
                hasil &= "*"
                bintang += 1
            End While
            baris += 1
            hasil &= vbCrLf
        End While
        TextBox2.Text = hasil
        hasil = " "
    End Sub

    Private Sub hollowpyramid()
        hasil &= vbCrLf
        Dim input As Integer = TextBox1.Text
        Dim i As Integer = 0
        While (i < input)
            Dim j As Integer = input - 1
            While (j > i)
                hasil &= " "
                j -= 1
            End While
            j = 0
            While (j < (2 * i) + 1)
                If (i = 0 Or i = input - 1) Then
                    hasil &= "*"
                Else
                    If (j = 0 Or j = 2 * i) Then
                        hasil &= "*"
                    Else
                        hasil &= " "
                    End If
                End If
                j += 1
            End While
            i += 1
            hasil &= vbCrLf
        End While
        TextBox2.Text = hasil
        hasil = ""
    End Sub

    Private Sub invertedpyramid()
        hasil &= vbCrLf
        Dim input As Integer = TextBox1.Text
        Dim i As Integer = 1
        While (i <= input)
            Dim j As Integer = 1
            While (j < i)
                hasil &= " "
                j += 1
            End While
            Dim k As Integer = 1
            While (k > i - input)
                hasil &= "*"
                k -= 1
            End While
            k = 0
            While (k < input - i)
                hasil &= "*"
                k += 1
            End While
            hasil &= vbCrLf
            i += 1
        End While
        TextBox2.Text = hasil
        hasil = " "
    End Sub

    Private Sub hollowinvertedpyramid()
        hasil &= vbCrLf
        Dim input As Integer = TextBox1.Text
        Dim batas As Integer = 1
        Dim batas2 As Integer = input * 2 - 1
        Dim baris As Integer = 1
        While (baris <= input)
            Dim kolom As Integer = 1
            While (kolom <= input * 2 - 1)
                If (baris = 1) Then
                    hasil &= "*"
                Else
                    If (kolom = batas Or kolom = batas2) Then
                        hasil &= "*"
                    Else
                        hasil &= " "
                    End If
                End If
                kolom += 1
            End While
            baris += 1
            batas += 1
            batas2 -= 1
            hasil &= vbCrLf
        End While
        TextBox2.Text = hasil
        hasil = ""
    End Sub
End Class