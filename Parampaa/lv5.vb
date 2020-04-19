Public Class lv5
    Sub mati()
        If hati = 0 Then
            Me.Hide()
            akhir.Show()
        End If
    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = 5 Then
            Me.Hide()
            lv6.Show()
        Else
            kurang()
            mati()
        End If
    End Sub

    Private Sub lv5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
