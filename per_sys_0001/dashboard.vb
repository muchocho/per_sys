Imports MySql.Data.MySqlClient
Public Class dashboard
    Private WithEvents _usecon As New usecon
    Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        Dim cmd As New MySqlCommand("SELECT COUNT(name) FROM accounts", conbin)
        Dim sqlresult1 As Integer
        sqlresult1 = cmd.ExecuteScalar

        connect()
        Dim cmd1 As New MySqlDataAdapter("SELECT * FROM accounts", conbin)
        Dim table1 As New DataTable
        cmd1.Fill(table1)

        For q = 0 To sqlresult1 - 1
            _usecon = New usecon
            FlowLayoutPanel1.Controls.Add(_usecon)
            _usecon._ename = table1.Rows(q).Item(1).ToString
            _usecon._add = table1.Rows(q).Item(4).ToString
            _usecon._payy = table1.Rows(q).Item(7).ToString
        Next


        connect()
        Dim cmdred As New MySqlCommand("SELECT COUNT()")

    End Sub
End Class