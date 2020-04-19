Public Class lv4
    Sub mati()
        If hati = 0 Then
            Me.Hide()
            akhir.Show()
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub lb5_Click(sender As Object, e As EventArgs) Handles lb5.Click
        Me.Hide()
        lv5.Show()
    End Sub

    Private Sub lv4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label77_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        kurang()
        mati()
    End Sub

    Private Sub Label146_Click(sender As Object, e As EventArgs) Handles Label146.Click
        kurang()
        mati()
    End Sub

    Private Sub Label127_Click(sender As Object, e As EventArgs) Handles Label127.Click
        kurang()
        mati()
    End Sub

    Private Sub Label147_Click(sender As Object, e As EventArgs) Handles Label147.Click
        kurang()
        mati()
    End Sub

    Private Sub Label140_Click(sender As Object, e As EventArgs) Handles Label140.Click
        kurang()
        mati()
    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click
        kurang()
        mati()
    End Sub

    Private Sub Label124_Click(sender As Object, e As EventArgs) Handles Label124.Click
        kurang()
        mati()
    End Sub
End Class