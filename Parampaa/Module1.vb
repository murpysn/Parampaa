Imports System.Data.OleDb
Module Module1
    Public str As String
    Public conn As OleDbConnection
    Public cmd As OleDbCommand
    Public rd As OleDbDataReader
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public dt As DataTable

    Sub koneksi()
        str = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\data.accdb"
        conn = New OleDbConnection(str)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        Else
            MsgBox("Koneksi Gagal")
        End If
    End Sub
End Module
