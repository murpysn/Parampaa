Public Class lv10
    Sub mati()
        If hati = 0 Then
            Me.Hide()
            akhir.Show()
        End If
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.Click
        Me.Hide()
        lv11.show()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        kurang()
        mati()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        kurang()
        mati()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        kurang()
        mati()
    End Sub

    Private Sub lv10_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class