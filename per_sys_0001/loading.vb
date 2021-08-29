Imports MySql.Data.MySqlClient
Public Class loading
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToString("MM/dd/yy")
    End Sub

    Private Sub loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dstat As String = "overdue"
        Dim sstat As String = "due"
        Timer1.Enabled = True

        connect()
        Dim cmd As New MySqlCommand("SELECT COUNT(userIDL) FROM account_logs", conbin)
        Dim cmdresult As Integer
        cmdresult = cmd.ExecuteScalar

        connect()
        Dim cmd2 As New MySqlDataAdapter("SELECT * FROM account_logs", conbin)
        Dim acc_table As New DataTable
        cmd2.Fill(acc_table)
        Dim datenow As Date
        datenow = "9/30/21"
        Dim transdate As Date

        For q = 0 To cmdresult - 1
            transdate = acc_table.Rows(q).Item(8).ToString
            Dim id As Integer = acc_table.Rows(q).Item(0)

            If transdate < datenow Then
                connect()
                Dim cmd3 As New MySqlCommand("UPDATE acc_data SET duestatus='" & dstat & "' WHERE accountID = '" & id & "'", conbin)
                cmd3.ExecuteNonQuery()
            ElseIf transdate = datenow
                connect()
                Dim cmd4 As New MySqlCommand("UPDATE acc_data SET duestatus='" & sstat & "' WHERE accountID = '" & id & "'", conbin)
                cmd4.ExecuteNonQuery()
            End If
        Next


    End Sub

    Private Sub Label2_MouseClick(sender As Object, e As MouseEventArgs) Handles Label2.MouseClick
        Me.Hide()
        regform.Show()
    End Sub

    Private Sub Label3_MouseClick(sender As Object, e As MouseEventArgs) Handles Label3.MouseClick
        Me.Hide()
        useraccounts.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pass As String = "zxcvb"
        Dim ids As Integer = 1
        connect()
        Dim cmd As New MySqlCommand("UPDATE sample SET pass='" & pass & "' WHERE colid='" & ids & "'", conbin)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Successful")
    End Sub
End Class