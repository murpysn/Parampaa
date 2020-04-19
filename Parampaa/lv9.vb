Public Class lv9

    Private Sub lv9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Label2_MouseMove(sender As Object, e As EventArgs) Handles Label2.MouseHover
        Label2.ForeColor = Color.DarkSeaGreen
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        lv10.show()
    End Sub

End Class