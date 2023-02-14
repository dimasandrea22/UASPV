Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bilanganPertama As Integer
        Dim bilanganKedua As Integer
        bilanganPertama = TextBox2.Text
        bilanganKedua = TextBox3.Text

        Dim hasilPerkalian As Integer
        hasilPerkalian = Perkalian(bilanganPertama, bilanganKedua)

        MsgBox("Hasil perkalian " & bilanganPertama & " x " & bilanganKedua & " = " & hasilPerkalian, MsgBoxStyle.Information, "Hasil Perkalian Adalah")
        If hasilPerkalian Mod 2 = 0 Then
            MsgBox("Hasil perkalian adalah bilangan genap.", MsgBoxStyle.Information, "Bilangan adalah...?")
        Else
            MsgBox("Hasil perkalian adalah bilangan ganjil.", MsgBoxStyle.Information, "Bilangan adalah...?")
        End If

        Dim i As Integer
        For i = 1 To hasilPerkalian
            MsgBox("Hello " & TextBox1.Text, MsgBoxStyle.Information & i, "Welcome")
        Next i
    End Sub

    Private Function Perkalian(ByVal bilanganPertama As Integer, ByVal bilanganKedua As Integer) As Integer
        Perkalian = bilanganPertama * bilanganKedua
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pesan As String
        pesan = MsgBox("Anda yakin ingin keluar ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Konfirmasi")
        If pesan = vbYes Then
            End
        Else
            Exit Sub
        End If
    End Sub

End Class
