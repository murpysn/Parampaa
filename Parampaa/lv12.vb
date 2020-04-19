Public Class lv12

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        lbP.Text = "P"
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        lbO.Text = "O"
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        lbL.Text = "L"
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        lbI.Text = "I"
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        lbJ.Text = "J"
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        lbE.Text = "E"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        lbSIP.Text = "SIP"
    End Sub
    Private Sub lbSIP_Click(sender As Object, e As EventArgs) Handles lbSIP.Click
        Me.Hide()
        last.Show()
    End Sub

    Private Sub lv12_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class