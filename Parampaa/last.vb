Public Class last

    Private Structure POINTAPI
        Dim x As Integer
        Dim y As Integer
    End Structure

    Private Declare Function ClientToScreen Lib "user32.dll" (ByVal hwnd As Integer, ByRef lpPoint As POINTAPI) As Integer
    Private Declare Function SetCursorPos Lib "user32.dll" (ByVal x As Integer, ByVal y As Integer) As Integer
    Private Declare Function GetPixel Lib "gdi32.dll" (ByVal hdc As Integer, ByVal x As Integer, ByVal y As Integer) As Integer
    Private Declare Function GetDC Lib "user32.dll" (ByVal hwnd As Integer) As Integer

    Sub SetUlang()
        Dim p As POINTAPI
        ClientToScreen(Me.Handle, p)
        SetCursorPos(p.x, p.y) 'mengarahkan mouse
    End Sub

    Private Sub last_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetUlang()
    End Sub
    Private Sub last_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        Select Case ColorTranslator.FromWin32(GetPixel(GetDC(Me.Handle), e.X, e.Y))

            Case Color.Green 'untuk jalan

            Case Color.White 'untuk finish
                Me.Hide()
                menang.Show()
            Case Color.Black
                Me.Hide()
                akhir.Show()
        End Select
    End Sub
End Class