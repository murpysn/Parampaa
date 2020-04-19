Public Class lv7

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Hide()
        lv8.Show()
        Timer1.Stop()
    End Sub

    Private Sub lv7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class