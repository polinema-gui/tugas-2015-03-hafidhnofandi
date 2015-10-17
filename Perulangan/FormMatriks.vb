Public Class FormMatriks
    Dim lihatkolom As Boolean

    Private Sub btHitung_Click(sender As Object, e As EventArgs) Handles btHitung.Click
        Try
            Dim barMat1 As Integer = tbMatriks1.Lines.Count
            Dim kolMat1 As Integer = tbMatriks1.Lines.ElementAt(0).Split(" ").Length
            Dim barMat2 As Integer = tbMatriks2.Lines.Count
            Dim kolMat2 As Integer = tbMatriks2.Lines.ElementAt(0).Split(" ").Length
            Dim copyMat1(barMat1, kolMat1) As Integer
            Dim copyMat2(barMat2, kolMat2) As Integer
            cek(barMat1, barMat2, kolMat1, kolMat2)
            toArray(barMat1, barMat2, kolMat1, kolMat2, copyMat1, copyMat2)
            operasi(copyMat1, copyMat2, barMat1, kolMat2)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub toArray(ByVal brs1 As Integer, brs2 As Integer, kol1 As Integer, kol2 As Integer, ByRef nilai1(,) As Integer, ByRef nilai2(,) As Integer)
        If (lihatkolom) Then
            For baris As Integer = 0 To brs1 - 1
                For kolom As Integer = 0 To kol1 - 1
                    nilai1(baris, kolom) = tbMatriks1.Lines.ElementAt(baris).Split(" ").ElementAt(kolom)
                    nilai2(baris, kolom) = tbMatriks2.Lines.ElementAt(baris).Split(" ").ElementAt(kolom)
                Next
            Next
        End If
    End Sub

    Private Sub cek(ByVal brs1 As Integer, brs2 As Integer, kol1 As Integer, kol2 As Integer)
        Dim tmp As Boolean = True
        For baris = 0 To brs1 - 2
            If (tbMatriks1.Lines.ElementAt(baris).Split(" ").Length <> tbMatriks1.Lines.ElementAt(baris + 1).Split(" ").Length) Then
                tmp = False
            End If
        Next
        For baris = 0 To brs2 - 2
            If (tbMatriks2.Lines.ElementAt(baris).Split(" ").Length <> tbMatriks2.Lines.ElementAt(baris + 1).Split(" ").Length) Then
                tmp = False
            End If
        Next
        If (tmp = False) Then
            lihatkolom = False
            Convert.ToInt32(tbMatriks1.Text)
            Convert.ToInt32(tbMatriks2.Text)
            MsgBox("Matriks Tidak Valid")
        ElseIf (brs1 = brs2 And kol1 = kol2) Then
            lihatkolom = True
        Else
            lihatkolom = False
            MessageBox.Show("Baris dan Kolom Semua Matriks Harus Sama", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub operasi(ByVal matriks1(,) As Integer, matriks2(,) As Integer, batBaris As Integer, batKolom As Integer)
        Dim hasil As String = ""
        If (lihatkolom) Then
            Select Case ComboBox1.Text
                Case "Tambah"
                    For brs As Integer = 0 To batBaris - 1
                        For kol As Integer = 0 To batKolom - 1
                            hasil &= (matriks1(brs, kol) + matriks2(brs, kol)).ToString & vbTab
                        Next
                        hasil &= vbNewLine
                    Next
                Case "Kurang"
                    For brs As Integer = 0 To batBaris - 1
                        For kol As Integer = 0 To batKolom - 1
                            hasil &= (matriks1(brs, kol) - matriks2(brs, kol)).ToString & vbTab
                        Next
                        hasil &= vbNewLine
                    Next
                Case Else
                    MessageBox.Show("Silahkan pilih operasi terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
            TextBox3.Text = hasil
        End If
    End Sub
End Class