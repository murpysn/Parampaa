Public Class lv11
    Sub mati()
        If hati = 0 Then
            Me.Hide()
            akhir.Show()
        End If
    End Sub
    Dim pink, hijau, biru, merah, kuning, oranye As Integer
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If merah = 4 Then
            pink = 5
        Else
            kurang()
            mati()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        oranye = 1
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If oranye = 1 Then
            hijau = 2
        Else
            kurang()
            mati()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If hijau = 2 Then
            biru = 3
        Else
            kurang()
            mati()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If biru = 3 Then
            merah = 4
        Else
            kurang()
            mati()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If pink = 5 Then
            kuning = 6
            Me.Hide()
            lv12.Show()
        Else
            kurang()
            mati()
        End If
    End Sub

    Private Sub lv11_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class