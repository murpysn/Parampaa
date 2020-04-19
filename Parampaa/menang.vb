Imports System.Data.OleDb
Public Class menang
    Sub Tampil()
        str = "select * from daftarlist"
        da = New OleDbDataAdapter(str, conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "pemenang")
        DataGridView1.DataSource = (ds.Tables("pemenang"))
        DataGridView1.ReadOnly = True
        DataGridView1.Columns(0).Width = 180

    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Me.Hide()
        frmMenu.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub menang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        Tampil()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim tambah As String = "insert into daftarlist(pemenang) values" & "('" & TextBox1.Text & "')"
        cmd = New OleDbCommand(tambah, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Success..!!!", MsgBoxStyle.Information, "Berhasil")
        TextBox1.Clear()
        TextBox1.ReadOnly = True
        Tampil()
    End Sub
End Class