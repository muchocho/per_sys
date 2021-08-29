Imports MySql.Data.MySqlClient
Public Class userinfo
    Private WithEvents _loglist As New loglist
    Private Sub userinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        Dim cmd As New MySqlDataAdapter("SELECT * FROM acc_data WHERE accountID = '" & userID & "'", conbin)
        Dim usershow As New DataTable
        cmd.Fill(usershow)

        Label1.Text = usershow.Rows(0).Item(1).ToString
        Label2.Text = usershow.Rows(0).Item(0).ToString
        Label3.Text = usershow.Rows(0).Item(6).ToString
        Label4.Text = usershow.Rows(0).Item(7).ToString
        Label5.Text = usershow.Rows(0).Item(8).ToString
        Label7.Text = usershow.Rows(0).Item(3).ToString
        Label8.Text = usershow.Rows(0).Item(2).ToString
        Label9.Text = usershow.Rows(0).Item(4).ToString
        Label10.Text = usershow.Rows(0).Item(5).ToString

        connect()
        Dim cmd3 As New MySqlCommand("SELECT COUNT(*) FROM account_logs WHERE userIDL = '" & userID & "'", conbin)
        Dim valcount As Integer
        valcount = cmd3.ExecuteScalar

        connect()
        Dim cmd2 As New MySqlDataAdapter("SELECT * FROM account_logs WHERE userIDL = '" & userID & "'", conbin)
        Dim userlogshow As New DataTable
        cmd2.Fill(userlogshow)

        Dim lastrow As Integer = valcount - 1
        Label6.Text = userlogshow.Rows(lastrow).Item(8).ToString
        Label11.Text = userlogshow.Rows(lastrow).Item(6).ToString
        Label12.Text = userlogshow.Rows(lastrow).Item(7).ToString

        For q = 0 To valcount - 1
            _loglist = New loglist
            FlowLayoutPanel1.Controls.Add(_loglist)
            _loglist._perin = userlogshow.Rows(q).Item(1).ToString
            _loglist._paym = userlogshow.Rows(q).Item(2).ToString
            _loglist._orno = userlogshow.Rows(q).Item(3).ToString
            _loglist._dte = userlogshow.Rows(q).Item(4).ToString
            _loglist._tme = userlogshow.Rows(q).Item(5).ToString
        Next


        If usershow.Rows(0).Item(10).ToString = "not_connected" Then
            Panel3.Show()
        Else
            Panel3.Hide()
        End If

    End Sub

    Private Sub Panel2_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel2.MouseClick
        Me.Close()
        useraccounts.Show()
    End Sub

    Private Sub Panel4_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel4.MouseClick
        Dim stat As String = "not_connected"
        Dim statc As String = "connected"
        Dim incharge As String = "ADMIN"

        connect()
        Dim command As New MySqlDataAdapter("SELECT * FROM acc_data WHERE accountID='" & userID & "'", conbin)
        Dim commandtable As New DataTable
        command.Fill(commandtable)

        If commandtable.Rows(0).Item(10).ToString = "not_connected" Then
            connect()
            Dim cmd As New MySqlCommand("UPDATE acc_data SET constatus='" & statc & "', tdate='" & useraccounts.Label1.Text & "' WHERE accountID='" & userID & "'", conbin)
            cmd.ExecuteNonQuery()

            connect()
            Dim cmd1 As New MySqlCommand("SELECT COUNT(*) FROM account_logs WHERE userIDL = '" & userID & "'", conbin)
            Dim count As Integer
            count = cmd1.ExecuteScalar
            Dim last As Integer = count - 1

            connect()
            Dim cmd2 As New MySqlDataAdapter("SELECT * FROM account_logs WHERE userIDL= '" & userID & "'", conbin)
            Dim cmd2table As New DataTable
            cmd2.Fill(cmd2table)

            Dim payy As String = cmd2table.Rows(last).Item(2).ToString
            Dim orNo As String = cmd2table.Rows(last).Item(3).ToString
            Dim datee As String = useraccounts.Label1.Text
            Dim ttime As String = useraccounts.Label2.Text
            Dim balancea As String = cmd2table.Rows(last).Item(6).ToString
            Dim advance As String = cmd2table.Rows(last).Item(7).ToString
            Dim duee As String = cmd2table.Rows(last).Item(8).ToString

            regusrlogs(userID, incharge, payy, orNo, datee, ttime, balancea, advance, duee)
            Panel3.Hide()

            FlowLayoutPanel1.Controls.Clear()
            connect()
            Dim cmd3 As New MySqlCommand("SELECT COUNT(*) FROM account_logs WHERE userIDL = '" & userID & "'", conbin)
            Dim valcount As Integer
            valcount = cmd3.ExecuteScalar

            connect()
            Dim cmd4 As New MySqlDataAdapter("SELECT * FROM account_logs WHERE userIDL = '" & userID & "'", conbin)
            Dim userlogshow As New DataTable
            cmd4.Fill(userlogshow)

            Dim lastrow As Integer = valcount - 1
            Label6.Text = userlogshow.Rows(lastrow).Item(8).ToString
            Label11.Text = userlogshow.Rows(lastrow).Item(6).ToString
            Label12.Text = userlogshow.Rows(lastrow).Item(7).ToString

            For q = 0 To valcount - 1
                _loglist = New loglist
                FlowLayoutPanel1.Controls.Add(_loglist)
                _loglist._perin = userlogshow.Rows(q).Item(1).ToString
                _loglist._paym = userlogshow.Rows(q).Item(2).ToString
                _loglist._orno = userlogshow.Rows(q).Item(3).ToString
                _loglist._dte = userlogshow.Rows(q).Item(4).ToString
                _loglist._tme = userlogshow.Rows(q).Item(5).ToString
            Next

            MessageBox.Show("Process successful!")

        Else
            connect()
            Dim cmd As New MySqlCommand("UPDATE acc_data SET constatus='" & stat & "', tdate='" & useraccounts.Label1.Text & "' WHERE accountID='" & userID & "'", conbin)
            cmd.ExecuteNonQuery()

            connect()
            Dim cmd1 As New MySqlCommand("SELECT COUNT(*) FROM account_logs WHERE userIDL = '" & userID & "'", conbin)
            Dim count As Integer
            count = cmd1.ExecuteScalar
            Dim last As Integer = count - 1

            connect()
            Dim cmd2 As New MySqlDataAdapter("SELECT * FROM account_logs WHERE userIDL= '" & userID & "'", conbin)
            Dim cmd2table As New DataTable
            cmd2.Fill(cmd2table)

            Dim payy As String = cmd2table.Rows(last).Item(2).ToString
            Dim orNo As String = cmd2table.Rows(last).Item(3).ToString
            Dim datee As String = useraccounts.Label1.Text
            Dim ttime As String = useraccounts.Label2.Text
            Dim balancea As String = cmd2table.Rows(last).Item(6).ToString
            Dim advance As String = cmd2table.Rows(last).Item(7).ToString
            Dim duee As String = cmd2table.Rows(last).Item(8).ToString

            regusrlogs(userID, incharge, payy, orNo, datee, ttime, balancea, advance, duee)
            Panel3.Show()

            FlowLayoutPanel1.Controls.Clear()
            connect()
            Dim cmd3 As New MySqlCommand("SELECT COUNT(*) FROM account_logs WHERE userIDL = '" & userID & "'", conbin)
            Dim valcount As Integer
            valcount = cmd3.ExecuteScalar

            connect()
            Dim cmd4 As New MySqlDataAdapter("SELECT * FROM account_logs WHERE userIDL = '" & userID & "'", conbin)
            Dim userlogshow As New DataTable
            cmd4.Fill(userlogshow)

            Dim lastrow As Integer = valcount - 1
            Label6.Text = userlogshow.Rows(lastrow).Item(8).ToString
            Label11.Text = userlogshow.Rows(lastrow).Item(6).ToString
            Label12.Text = userlogshow.Rows(lastrow).Item(7).ToString

            For q = 0 To valcount - 1
                _loglist = New loglist
                FlowLayoutPanel1.Controls.Add(_loglist)
                _loglist._perin = userlogshow.Rows(q).Item(1).ToString
                _loglist._paym = userlogshow.Rows(q).Item(2).ToString
                _loglist._orno = userlogshow.Rows(q).Item(3).ToString
                _loglist._dte = userlogshow.Rows(q).Item(4).ToString
                _loglist._tme = userlogshow.Rows(q).Item(5).ToString
            Next
            MessageBox.Show("Process successful!")
        End If



    End Sub
End Class