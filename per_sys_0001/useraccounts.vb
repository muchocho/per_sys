Imports MySql.Data.MySqlClient
Public Class useraccounts
    Dim q As Integer
    Private Sub useraccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        connect()
        Dim cmd As New MySqlCommand("SELECT COUNT(name) FROM acc_data", conbin)
        Dim sqlresult1 As Integer
        sqlresult1 = cmd.ExecuteScalar

        connect()
        Dim cmd1 As New MySqlDataAdapter("SELECT * FROM acc_data", conbin)
        Dim table1 As New DataTable
        cmd1.Fill(table1)

        q = 0
        If q < sqlresult1 Then
            Users1.Label1.Text = table1.Rows(q).Item(1).ToString
            Users1.Label2.Text = table1.Rows(q).Item(4).ToString
            Users1.Label3.Text = table1.Rows(q).Item(7).ToString
            userID1 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users1.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users2.Label1.Text = table1.Rows(q).Item(1).ToString
            Users2.Label2.Text = table1.Rows(q).Item(4).ToString
            Users2.Label3.Text = table1.Rows(q).Item(7).ToString
            userID2 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users2.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users3.Label1.Text = table1.Rows(q).Item(1).ToString
            Users3.Label2.Text = table1.Rows(q).Item(4).ToString
            Users3.Label3.Text = table1.Rows(q).Item(7).ToString
            userID3 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users3.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users4.Label1.Text = table1.Rows(q).Item(1).ToString
            Users4.Label2.Text = table1.Rows(q).Item(4).ToString
            Users4.Label3.Text = table1.Rows(q).Item(7).ToString
            userID4 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users4.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users5.Label1.Text = table1.Rows(q).Item(1).ToString
            Users5.Label2.Text = table1.Rows(q).Item(4).ToString
            Users5.Label3.Text = table1.Rows(q).Item(7).ToString
            userID5 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users5.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users6.Label1.Text = table1.Rows(q).Item(1).ToString
            Users6.Label2.Text = table1.Rows(q).Item(4).ToString
            Users6.Label3.Text = table1.Rows(q).Item(7).ToString
            userID6 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users6.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users7.Label1.Text = table1.Rows(q).Item(1).ToString
            Users7.Label2.Text = table1.Rows(q).Item(4).ToString
            Users7.Label3.Text = table1.Rows(q).Item(7).ToString
            userID7 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users7.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users8.Label1.Text = table1.Rows(q).Item(1).ToString
            Users8.Label2.Text = table1.Rows(q).Item(4).ToString
            Users8.Label3.Text = table1.Rows(q).Item(7).ToString
            userID8 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users8.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users9.Label1.Text = table1.Rows(q).Item(1).ToString
            Users9.Label2.Text = table1.Rows(q).Item(4).ToString
            Users9.Label3.Text = table1.Rows(q).Item(7).ToString
            userID9 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users9.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users10.Label1.Text = table1.Rows(q).Item(1).ToString
            Users10.Label2.Text = table1.Rows(q).Item(4).ToString
            Users10.Label3.Text = table1.Rows(q).Item(7).ToString
            userID10 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users10.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users11.Label1.Text = table1.Rows(q).Item(1).ToString
            Users11.Label2.Text = table1.Rows(q).Item(4).ToString
            Users11.Label3.Text = table1.Rows(q).Item(7).ToString
            userID11 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users11.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users12.Label1.Text = table1.Rows(q).Item(1).ToString
            Users12.Label2.Text = table1.Rows(q).Item(4).ToString
            Users12.Label3.Text = table1.Rows(q).Item(7).ToString
            userID12 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users12.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users13.Label1.Text = table1.Rows(q).Item(1).ToString
            Users13.Label2.Text = table1.Rows(q).Item(4).ToString
            Users13.Label3.Text = table1.Rows(q).Item(7).ToString
            userID13 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users13.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users14.Label1.Text = table1.Rows(q).Item(1).ToString
            Users14.Label2.Text = table1.Rows(q).Item(4).ToString
            Users14.Label3.Text = table1.Rows(q).Item(7).ToString
            userID14 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users14.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users15.Label1.Text = table1.Rows(q).Item(1).ToString
            Users15.Label2.Text = table1.Rows(q).Item(4).ToString
            Users15.Label3.Text = table1.Rows(q).Item(7).ToString
            userID15 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users15.Hide()
            q = q + 1
        End If

        Menus1.Show()
        Menus2.Hide()
        Menus3.Hide()
        Menus4.Hide()
        Menus5.Hide()
        Menus6.Hide()
    End Sub

    Private Sub Panel2_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel2.MouseClick
        Menus1.Show()
        Menus2.Hide()
        Menus3.Hide()
        Menus4.Hide()
        Menus5.Hide()
        Menus6.Hide()

        Users1.Show()
        Users2.Show()
        Users3.Show()
        Users4.Show()
        Users5.Show()
        Users6.Show()
        Users7.Show()
        Users8.Show()
        Users9.Show()
        Users10.Show()
        Users11.Show()
        Users12.Show()
        Users13.Show()
        Users14.Show()
        Users15.Show()


        connect()
        Dim cmd As New MySqlCommand("SELECT COUNT(name) FROM acc_data", conbin)
        Dim sqlresult1 As Integer
        sqlresult1 = cmd.ExecuteScalar

        connect()
        Dim cmd1 As New MySqlDataAdapter("SELECT * FROM acc_data", conbin)
        Dim table1 As New DataTable
        cmd1.Fill(table1)

        q = 0
        If q < sqlresult1 Then
            Users1.Label1.Text = table1.Rows(q).Item(1).ToString
            Users1.Label2.Text = table1.Rows(q).Item(4).ToString
            Users1.Label3.Text = table1.Rows(q).Item(7).ToString
            userID1 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users1.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users2.Label1.Text = table1.Rows(q).Item(1).ToString
            Users2.Label2.Text = table1.Rows(q).Item(4).ToString
            Users2.Label3.Text = table1.Rows(q).Item(7).ToString
            userID2 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users2.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users3.Label1.Text = table1.Rows(q).Item(1).ToString
            Users3.Label2.Text = table1.Rows(q).Item(4).ToString
            Users3.Label3.Text = table1.Rows(q).Item(7).ToString
            userID3 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users3.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users4.Label1.Text = table1.Rows(q).Item(1).ToString
            Users4.Label2.Text = table1.Rows(q).Item(4).ToString
            Users4.Label3.Text = table1.Rows(q).Item(7).ToString
            userID4 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users4.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users5.Label1.Text = table1.Rows(q).Item(1).ToString
            Users5.Label2.Text = table1.Rows(q).Item(4).ToString
            Users5.Label3.Text = table1.Rows(q).Item(7).ToString
            userID5 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users5.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users6.Label1.Text = table1.Rows(q).Item(1).ToString
            Users6.Label2.Text = table1.Rows(q).Item(4).ToString
            Users6.Label3.Text = table1.Rows(q).Item(7).ToString
            userID6 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users6.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users7.Label1.Text = table1.Rows(q).Item(1).ToString
            Users7.Label2.Text = table1.Rows(q).Item(4).ToString
            Users7.Label3.Text = table1.Rows(q).Item(7).ToString
            userID7 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users7.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users8.Label1.Text = table1.Rows(q).Item(1).ToString
            Users8.Label2.Text = table1.Rows(q).Item(4).ToString
            Users8.Label3.Text = table1.Rows(q).Item(7).ToString
            userID8 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users8.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users9.Label1.Text = table1.Rows(q).Item(1).ToString
            Users9.Label2.Text = table1.Rows(q).Item(4).ToString
            Users9.Label3.Text = table1.Rows(q).Item(7).ToString
            userID9 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users9.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users10.Label1.Text = table1.Rows(q).Item(1).ToString
            Users10.Label2.Text = table1.Rows(q).Item(4).ToString
            Users10.Label3.Text = table1.Rows(q).Item(7).ToString
            userID10 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users10.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users11.Label1.Text = table1.Rows(q).Item(1).ToString
            Users11.Label2.Text = table1.Rows(q).Item(4).ToString
            Users11.Label3.Text = table1.Rows(q).Item(7).ToString
            userID11 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users11.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users12.Label1.Text = table1.Rows(q).Item(1).ToString
            Users12.Label2.Text = table1.Rows(q).Item(4).ToString
            Users12.Label3.Text = table1.Rows(q).Item(7).ToString
            userID12 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users12.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users13.Label1.Text = table1.Rows(q).Item(1).ToString
            Users13.Label2.Text = table1.Rows(q).Item(4).ToString
            Users13.Label3.Text = table1.Rows(q).Item(7).ToString
            userID13 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users13.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users14.Label1.Text = table1.Rows(q).Item(1).ToString
            Users14.Label2.Text = table1.Rows(q).Item(4).ToString
            Users14.Label3.Text = table1.Rows(q).Item(7).ToString
            userID14 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users14.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users15.Label1.Text = table1.Rows(q).Item(1).ToString
            Users15.Label2.Text = table1.Rows(q).Item(4).ToString
            Users15.Label3.Text = table1.Rows(q).Item(7).ToString
            userID15 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users15.Hide()
            q = q + 1
        End If

    End Sub

    Private Sub Panel3_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel3.MouseClick
        Dim duestat As String = "due"
        Menus1.Hide()
        Menus2.Show()
        Menus3.Hide()
        Menus4.Hide()
        Menus5.Hide()
        Menus6.Hide()

        Users1.Show()
        Users2.Show()
        Users3.Show()
        Users4.Show()
        Users5.Show()
        Users6.Show()
        Users7.Show()
        Users8.Show()
        Users9.Show()
        Users10.Show()
        Users11.Show()
        Users12.Show()
        Users13.Show()
        Users14.Show()
        Users15.Show()


        connect()
        Dim cmd As New MySqlCommand("SELECT COUNT(accountID) FROM acc_data WHERE duestatus='" & duestat & "'", conbin)
        Dim sqlresult1 As Integer
        sqlresult1 = cmd.ExecuteScalar

        Dim cmd1 As New MySqlDataAdapter("SELECT * FROM acc_data WHERE duestatus='" & duestat & "'", conbin)
        Dim table1 As New DataTable
        cmd1.Fill(table1)

        q = 0
        If q < sqlresult1 Then
            Users1.Label1.Text = table1.Rows(q).Item(1).ToString
            Users1.Label2.Text = table1.Rows(q).Item(4).ToString
            Users1.Label3.Text = table1.Rows(q).Item(7).ToString
            userID1 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users1.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users2.Label1.Text = table1.Rows(q).Item(1).ToString
            Users2.Label2.Text = table1.Rows(q).Item(4).ToString
            Users2.Label3.Text = table1.Rows(q).Item(7).ToString
            userID2 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users2.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users3.Label1.Text = table1.Rows(q).Item(1).ToString
            Users3.Label2.Text = table1.Rows(q).Item(4).ToString
            Users3.Label3.Text = table1.Rows(q).Item(7).ToString
            userID3 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users3.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users4.Label1.Text = table1.Rows(q).Item(1).ToString
            Users4.Label2.Text = table1.Rows(q).Item(4).ToString
            Users4.Label3.Text = table1.Rows(q).Item(7).ToString
            userID4 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users4.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users5.Label1.Text = table1.Rows(q).Item(1).ToString
            Users5.Label2.Text = table1.Rows(q).Item(4).ToString
            Users5.Label3.Text = table1.Rows(q).Item(7).ToString
            userID5 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users5.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users6.Label1.Text = table1.Rows(q).Item(1).ToString
            Users6.Label2.Text = table1.Rows(q).Item(4).ToString
            Users6.Label3.Text = table1.Rows(q).Item(7).ToString
            userID6 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users6.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users7.Label1.Text = table1.Rows(q).Item(1).ToString
            Users7.Label2.Text = table1.Rows(q).Item(4).ToString
            Users7.Label3.Text = table1.Rows(q).Item(7).ToString
            userID7 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users7.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users8.Label1.Text = table1.Rows(q).Item(1).ToString
            Users8.Label2.Text = table1.Rows(q).Item(4).ToString
            Users8.Label3.Text = table1.Rows(q).Item(7).ToString
            userID8 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users8.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users9.Label1.Text = table1.Rows(q).Item(1).ToString
            Users9.Label2.Text = table1.Rows(q).Item(4).ToString
            Users9.Label3.Text = table1.Rows(q).Item(7).ToString
            userID9 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users9.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users10.Label1.Text = table1.Rows(q).Item(1).ToString
            Users10.Label2.Text = table1.Rows(q).Item(4).ToString
            Users10.Label3.Text = table1.Rows(q).Item(7).ToString
            userID10 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users10.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users11.Label1.Text = table1.Rows(q).Item(1).ToString
            Users11.Label2.Text = table1.Rows(q).Item(4).ToString
            Users11.Label3.Text = table1.Rows(q).Item(7).ToString
            userID11 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users11.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users12.Label1.Text = table1.Rows(q).Item(1).ToString
            Users12.Label2.Text = table1.Rows(q).Item(4).ToString
            Users12.Label3.Text = table1.Rows(q).Item(7).ToString
            userID12 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users12.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users13.Label1.Text = table1.Rows(q).Item(1).ToString
            Users13.Label2.Text = table1.Rows(q).Item(4).ToString
            Users13.Label3.Text = table1.Rows(q).Item(7).ToString
            userID13 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users13.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users14.Label1.Text = table1.Rows(q).Item(1).ToString
            Users14.Label2.Text = table1.Rows(q).Item(4).ToString
            Users14.Label3.Text = table1.Rows(q).Item(7).ToString
            userID14 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users14.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users15.Label1.Text = table1.Rows(q).Item(1).ToString
            Users15.Label2.Text = table1.Rows(q).Item(4).ToString
            Users15.Label3.Text = table1.Rows(q).Item(7).ToString
            userID15 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users15.Hide()
            q = q + 1
        End If






    End Sub

    Private Sub Panel4_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel4.MouseClick
        Dim stat As String = "overdue"
        Menus1.Hide()
        Menus2.Hide()
        Menus3.Show()
        Menus4.Hide()
        Menus5.Hide()
        Menus6.Hide()

        Users1.Show()
        Users2.Show()
        Users3.Show()
        Users4.Show()
        Users5.Show()
        Users6.Show()
        Users7.Show()
        Users8.Show()
        Users9.Show()
        Users10.Show()
        Users11.Show()
        Users12.Show()
        Users13.Show()
        Users14.Show()
        Users15.Show()
        connect()
        Dim cmd As New MySqlCommand("SELECT COUNT(accountID) FROM acc_data WHERE duestatus='" & stat & "'", conbin)
        Dim sqlresult1 As Integer
        sqlresult1 = cmd.ExecuteScalar

        Dim cmd1 As New MySqlDataAdapter("SELECT * FROM acc_data WHERE duestatus='" & stat & "'", conbin)
        Dim table1 As New DataTable
        cmd1.Fill(table1)

        q = 0
        If q < sqlresult1 Then
            Users1.Label1.Text = table1.Rows(q).Item(1).ToString
            Users1.Label2.Text = table1.Rows(q).Item(4).ToString
            Users1.Label3.Text = table1.Rows(q).Item(7).ToString
            userID1 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users1.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users2.Label1.Text = table1.Rows(q).Item(1).ToString
            Users2.Label2.Text = table1.Rows(q).Item(4).ToString
            Users2.Label3.Text = table1.Rows(q).Item(7).ToString
            userID2 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users2.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users3.Label1.Text = table1.Rows(q).Item(1).ToString
            Users3.Label2.Text = table1.Rows(q).Item(4).ToString
            Users3.Label3.Text = table1.Rows(q).Item(7).ToString
            userID3 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users3.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users4.Label1.Text = table1.Rows(q).Item(1).ToString
            Users4.Label2.Text = table1.Rows(q).Item(4).ToString
            Users4.Label3.Text = table1.Rows(q).Item(7).ToString
            userID4 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users4.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users5.Label1.Text = table1.Rows(q).Item(1).ToString
            Users5.Label2.Text = table1.Rows(q).Item(4).ToString
            Users5.Label3.Text = table1.Rows(q).Item(7).ToString
            userID5 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users5.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users6.Label1.Text = table1.Rows(q).Item(1).ToString
            Users6.Label2.Text = table1.Rows(q).Item(4).ToString
            Users6.Label3.Text = table1.Rows(q).Item(7).ToString
            userID6 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users6.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users7.Label1.Text = table1.Rows(q).Item(1).ToString
            Users7.Label2.Text = table1.Rows(q).Item(4).ToString
            Users7.Label3.Text = table1.Rows(q).Item(7).ToString
            userID7 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users7.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users8.Label1.Text = table1.Rows(q).Item(1).ToString
            Users8.Label2.Text = table1.Rows(q).Item(4).ToString
            Users8.Label3.Text = table1.Rows(q).Item(7).ToString
            userID8 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users8.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users9.Label1.Text = table1.Rows(q).Item(1).ToString
            Users9.Label2.Text = table1.Rows(q).Item(4).ToString
            Users9.Label3.Text = table1.Rows(q).Item(7).ToString
            userID9 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users9.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users10.Label1.Text = table1.Rows(q).Item(1).ToString
            Users10.Label2.Text = table1.Rows(q).Item(4).ToString
            Users10.Label3.Text = table1.Rows(q).Item(7).ToString
            userID10 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users10.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users11.Label1.Text = table1.Rows(q).Item(1).ToString
            Users11.Label2.Text = table1.Rows(q).Item(4).ToString
            Users11.Label3.Text = table1.Rows(q).Item(7).ToString
            userID11 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users11.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users12.Label1.Text = table1.Rows(q).Item(1).ToString
            Users12.Label2.Text = table1.Rows(q).Item(4).ToString
            Users12.Label3.Text = table1.Rows(q).Item(7).ToString
            userID12 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users12.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users13.Label1.Text = table1.Rows(q).Item(1).ToString
            Users13.Label2.Text = table1.Rows(q).Item(4).ToString
            Users13.Label3.Text = table1.Rows(q).Item(7).ToString
            userID13 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users13.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users14.Label1.Text = table1.Rows(q).Item(1).ToString
            Users14.Label2.Text = table1.Rows(q).Item(4).ToString
            Users14.Label3.Text = table1.Rows(q).Item(7).ToString
            userID14 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users14.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users15.Label1.Text = table1.Rows(q).Item(1).ToString
            Users15.Label2.Text = table1.Rows(q).Item(4).ToString
            Users15.Label3.Text = table1.Rows(q).Item(7).ToString
            userID15 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users15.Hide()
            q = q + 1
        End If

    End Sub

    Private Sub Panel5_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel5.MouseClick
        Dim stat As String = "connected"
        Menus1.Hide()
        Menus2.Hide()
        Menus3.Hide()
        Menus4.Hide()
        Menus5.Hide()
        Menus6.Show()

        Users1.Show()
        Users2.Show()
        Users3.Show()
        Users4.Show()
        Users5.Show()
        Users6.Show()
        Users7.Show()
        Users8.Show()
        Users9.Show()
        Users10.Show()
        Users11.Show()
        Users12.Show()
        Users13.Show()
        Users14.Show()
        Users15.Show()
        connect()
        Dim cmd As New MySqlCommand("SELECT COUNT(accountID) FROM acc_data WHERE constatus='" & stat & "'", conbin)
        Dim sqlresult1 As Integer
        sqlresult1 = cmd.ExecuteScalar

        Dim cmd1 As New MySqlDataAdapter("SELECT * FROM acc_data WHERE constatus='" & stat & "'", conbin)
        Dim table1 As New DataTable
        cmd1.Fill(table1)

        q = 0
        If q < sqlresult1 Then
            Users1.Label1.Text = table1.Rows(q).Item(1).ToString
            Users1.Label2.Text = table1.Rows(q).Item(4).ToString
            Users1.Label3.Text = table1.Rows(q).Item(7).ToString
            userID1 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users1.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users2.Label1.Text = table1.Rows(q).Item(1).ToString
            Users2.Label2.Text = table1.Rows(q).Item(4).ToString
            Users2.Label3.Text = table1.Rows(q).Item(7).ToString
            userID2 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users2.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users3.Label1.Text = table1.Rows(q).Item(1).ToString
            Users3.Label2.Text = table1.Rows(q).Item(4).ToString
            Users3.Label3.Text = table1.Rows(q).Item(7).ToString
            userID3 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users3.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users4.Label1.Text = table1.Rows(q).Item(1).ToString
            Users4.Label2.Text = table1.Rows(q).Item(4).ToString
            Users4.Label3.Text = table1.Rows(q).Item(7).ToString
            userID4 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users4.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users5.Label1.Text = table1.Rows(q).Item(1).ToString
            Users5.Label2.Text = table1.Rows(q).Item(4).ToString
            Users5.Label3.Text = table1.Rows(q).Item(7).ToString
            userID5 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users5.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users6.Label1.Text = table1.Rows(q).Item(1).ToString
            Users6.Label2.Text = table1.Rows(q).Item(4).ToString
            Users6.Label3.Text = table1.Rows(q).Item(7).ToString
            userID6 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users6.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users7.Label1.Text = table1.Rows(q).Item(1).ToString
            Users7.Label2.Text = table1.Rows(q).Item(4).ToString
            Users7.Label3.Text = table1.Rows(q).Item(7).ToString
            userID7 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users7.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users8.Label1.Text = table1.Rows(q).Item(1).ToString
            Users8.Label2.Text = table1.Rows(q).Item(4).ToString
            Users8.Label3.Text = table1.Rows(q).Item(7).ToString
            userID8 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users8.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users9.Label1.Text = table1.Rows(q).Item(1).ToString
            Users9.Label2.Text = table1.Rows(q).Item(4).ToString
            Users9.Label3.Text = table1.Rows(q).Item(7).ToString
            userID9 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users9.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users10.Label1.Text = table1.Rows(q).Item(1).ToString
            Users10.Label2.Text = table1.Rows(q).Item(4).ToString
            Users10.Label3.Text = table1.Rows(q).Item(7).ToString
            userID10 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users10.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users11.Label1.Text = table1.Rows(q).Item(1).ToString
            Users11.Label2.Text = table1.Rows(q).Item(4).ToString
            Users11.Label3.Text = table1.Rows(q).Item(7).ToString
            userID11 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users11.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users12.Label1.Text = table1.Rows(q).Item(1).ToString
            Users12.Label2.Text = table1.Rows(q).Item(4).ToString
            Users12.Label3.Text = table1.Rows(q).Item(7).ToString
            userID12 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users12.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users13.Label1.Text = table1.Rows(q).Item(1).ToString
            Users13.Label2.Text = table1.Rows(q).Item(4).ToString
            Users13.Label3.Text = table1.Rows(q).Item(7).ToString
            userID13 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users13.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users14.Label1.Text = table1.Rows(q).Item(1).ToString
            Users14.Label2.Text = table1.Rows(q).Item(4).ToString
            Users14.Label3.Text = table1.Rows(q).Item(7).ToString
            userID14 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users14.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users15.Label1.Text = table1.Rows(q).Item(1).ToString
            Users15.Label2.Text = table1.Rows(q).Item(4).ToString
            Users15.Label3.Text = table1.Rows(q).Item(7).ToString
            userID15 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users15.Hide()
            q = q + 1
        End If

    End Sub

    Private Sub Panel6_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel6.MouseClick
        Dim stat As String = "not_connected"
        Menus1.Hide()
        Menus2.Hide()
        Menus3.Hide()
        Menus4.Hide()
        Menus5.Show()
        Menus6.Hide()

        Users1.Show()
        Users2.Show()
        Users3.Show()
        Users4.Show()
        Users5.Show()
        Users6.Show()
        Users7.Show()
        Users8.Show()
        Users9.Show()
        Users10.Show()
        Users11.Show()
        Users12.Show()
        Users13.Show()
        Users14.Show()
        Users15.Show()
        connect()
        Dim cmd As New MySqlCommand("SELECT COUNT(accountID) FROM acc_data WHERE constatus='" & stat & "'", conbin)
        Dim sqlresult1 As Integer
        sqlresult1 = cmd.ExecuteScalar

        Dim cmd1 As New MySqlDataAdapter("SELECT * FROM acc_data WHERE constatus='" & stat & "'", conbin)
        Dim table1 As New DataTable
        cmd1.Fill(table1)

        q = 0
        If q < sqlresult1 Then
            Users1.Label1.Text = table1.Rows(q).Item(1).ToString
            Users1.Label2.Text = table1.Rows(q).Item(4).ToString
            Users1.Label3.Text = table1.Rows(q).Item(7).ToString
            userID1 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users1.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users2.Label1.Text = table1.Rows(q).Item(1).ToString
            Users2.Label2.Text = table1.Rows(q).Item(4).ToString
            Users2.Label3.Text = table1.Rows(q).Item(7).ToString
            userID2 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users2.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users3.Label1.Text = table1.Rows(q).Item(1).ToString
            Users3.Label2.Text = table1.Rows(q).Item(4).ToString
            Users3.Label3.Text = table1.Rows(q).Item(7).ToString
            userID3 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users3.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users4.Label1.Text = table1.Rows(q).Item(1).ToString
            Users4.Label2.Text = table1.Rows(q).Item(4).ToString
            Users4.Label3.Text = table1.Rows(q).Item(7).ToString
            userID4 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users4.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users5.Label1.Text = table1.Rows(q).Item(1).ToString
            Users5.Label2.Text = table1.Rows(q).Item(4).ToString
            Users5.Label3.Text = table1.Rows(q).Item(7).ToString
            userID5 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users5.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users6.Label1.Text = table1.Rows(q).Item(1).ToString
            Users6.Label2.Text = table1.Rows(q).Item(4).ToString
            Users6.Label3.Text = table1.Rows(q).Item(7).ToString
            userID6 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users6.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users7.Label1.Text = table1.Rows(q).Item(1).ToString
            Users7.Label2.Text = table1.Rows(q).Item(4).ToString
            Users7.Label3.Text = table1.Rows(q).Item(7).ToString
            userID7 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users7.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users8.Label1.Text = table1.Rows(q).Item(1).ToString
            Users8.Label2.Text = table1.Rows(q).Item(4).ToString
            Users8.Label3.Text = table1.Rows(q).Item(7).ToString
            userID8 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users8.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users9.Label1.Text = table1.Rows(q).Item(1).ToString
            Users9.Label2.Text = table1.Rows(q).Item(4).ToString
            Users9.Label3.Text = table1.Rows(q).Item(7).ToString
            userID9 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users9.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users10.Label1.Text = table1.Rows(q).Item(1).ToString
            Users10.Label2.Text = table1.Rows(q).Item(4).ToString
            Users10.Label3.Text = table1.Rows(q).Item(7).ToString
            userID10 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users10.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users11.Label1.Text = table1.Rows(q).Item(1).ToString
            Users11.Label2.Text = table1.Rows(q).Item(4).ToString
            Users11.Label3.Text = table1.Rows(q).Item(7).ToString
            userID11 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users11.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users12.Label1.Text = table1.Rows(q).Item(1).ToString
            Users12.Label2.Text = table1.Rows(q).Item(4).ToString
            Users12.Label3.Text = table1.Rows(q).Item(7).ToString
            userID12 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users12.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users13.Label1.Text = table1.Rows(q).Item(1).ToString
            Users13.Label2.Text = table1.Rows(q).Item(4).ToString
            Users13.Label3.Text = table1.Rows(q).Item(7).ToString
            userID13 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users13.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users14.Label1.Text = table1.Rows(q).Item(1).ToString
            Users14.Label2.Text = table1.Rows(q).Item(4).ToString
            Users14.Label3.Text = table1.Rows(q).Item(7).ToString
            userID14 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users14.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users15.Label1.Text = table1.Rows(q).Item(1).ToString
            Users15.Label2.Text = table1.Rows(q).Item(4).ToString
            Users15.Label3.Text = table1.Rows(q).Item(7).ToString
            userID15 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users15.Hide()
            q = q + 1
        End If
    End Sub

    Private Sub Panel7_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel7.MouseClick
        Dim stat As String = "paid"
        Menus1.Hide()
        Menus2.Hide()
        Menus3.Hide()
        Menus4.Show()
        Menus5.Hide()
        Menus6.Hide()

        Users1.Show()
        Users2.Show()
        Users3.Show()
        Users4.Show()
        Users5.Show()
        Users6.Show()
        Users7.Show()
        Users8.Show()
        Users9.Show()
        Users10.Show()
        Users11.Show()
        Users12.Show()
        Users13.Show()
        Users14.Show()
        Users15.Show()
        connect()
        Dim cmd As New MySqlCommand("SELECT COUNT(accountID) FROM acc_data WHERE duestatus='" & stat & "'", conbin)
        Dim sqlresult1 As Integer
        sqlresult1 = cmd.ExecuteScalar

        Dim cmd1 As New MySqlDataAdapter("SELECT * FROM acc_data WHERE duestatus='" & stat & "'", conbin)
        Dim table1 As New DataTable
        cmd1.Fill(table1)

        q = 0
        If q < sqlresult1 Then
            Users1.Label1.Text = table1.Rows(q).Item(1).ToString
            Users1.Label2.Text = table1.Rows(q).Item(4).ToString
            Users1.Label3.Text = table1.Rows(q).Item(7).ToString
            userID1 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users1.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users2.Label1.Text = table1.Rows(q).Item(1).ToString
            Users2.Label2.Text = table1.Rows(q).Item(4).ToString
            Users2.Label3.Text = table1.Rows(q).Item(7).ToString
            userID2 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users2.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users3.Label1.Text = table1.Rows(q).Item(1).ToString
            Users3.Label2.Text = table1.Rows(q).Item(4).ToString
            Users3.Label3.Text = table1.Rows(q).Item(7).ToString
            userID3 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users3.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users4.Label1.Text = table1.Rows(q).Item(1).ToString
            Users4.Label2.Text = table1.Rows(q).Item(4).ToString
            Users4.Label3.Text = table1.Rows(q).Item(7).ToString
            userID4 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users4.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users5.Label1.Text = table1.Rows(q).Item(1).ToString
            Users5.Label2.Text = table1.Rows(q).Item(4).ToString
            Users5.Label3.Text = table1.Rows(q).Item(7).ToString
            userID5 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users5.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users6.Label1.Text = table1.Rows(q).Item(1).ToString
            Users6.Label2.Text = table1.Rows(q).Item(4).ToString
            Users6.Label3.Text = table1.Rows(q).Item(7).ToString
            userID6 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users6.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users7.Label1.Text = table1.Rows(q).Item(1).ToString
            Users7.Label2.Text = table1.Rows(q).Item(4).ToString
            Users7.Label3.Text = table1.Rows(q).Item(7).ToString
            userID7 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users7.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users8.Label1.Text = table1.Rows(q).Item(1).ToString
            Users8.Label2.Text = table1.Rows(q).Item(4).ToString
            Users8.Label3.Text = table1.Rows(q).Item(7).ToString
            userID8 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users8.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users9.Label1.Text = table1.Rows(q).Item(1).ToString
            Users9.Label2.Text = table1.Rows(q).Item(4).ToString
            Users9.Label3.Text = table1.Rows(q).Item(7).ToString
            userID9 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users9.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users10.Label1.Text = table1.Rows(q).Item(1).ToString
            Users10.Label2.Text = table1.Rows(q).Item(4).ToString
            Users10.Label3.Text = table1.Rows(q).Item(7).ToString
            userID10 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users10.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users11.Label1.Text = table1.Rows(q).Item(1).ToString
            Users11.Label2.Text = table1.Rows(q).Item(4).ToString
            Users11.Label3.Text = table1.Rows(q).Item(7).ToString
            userID11 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users11.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users12.Label1.Text = table1.Rows(q).Item(1).ToString
            Users12.Label2.Text = table1.Rows(q).Item(4).ToString
            Users12.Label3.Text = table1.Rows(q).Item(7).ToString
            userID12 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users12.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users13.Label1.Text = table1.Rows(q).Item(1).ToString
            Users13.Label2.Text = table1.Rows(q).Item(4).ToString
            Users13.Label3.Text = table1.Rows(q).Item(7).ToString
            userID13 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users13.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users14.Label1.Text = table1.Rows(q).Item(1).ToString
            Users14.Label2.Text = table1.Rows(q).Item(4).ToString
            Users14.Label3.Text = table1.Rows(q).Item(7).ToString
            userID14 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users14.Hide()
            q = q + 1
        End If

        If q < sqlresult1 Then
            Users15.Label1.Text = table1.Rows(q).Item(1).ToString
            Users15.Label2.Text = table1.Rows(q).Item(4).ToString
            Users15.Label3.Text = table1.Rows(q).Item(7).ToString
            userID15 = table1.Rows(q).Item(0)
            q = q + 1
        Else
            Users15.Hide()
            q = q + 1
        End If
    End Sub

    Private Sub Users1_MouseClick(sender As Object, e As MouseEventArgs) Handles Users1.MouseClick
        userID = userID1
        userinfo.Show()
        Me.Hide()

    End Sub

    Private Sub Users2_MouseClick(sender As Object, e As MouseEventArgs) Handles Users2.MouseClick
        userID = userID2
        userinfo.Show()
        Me.Hide()
    End Sub

    Private Sub Users3_MouseClick(sender As Object, e As MouseEventArgs) Handles Users3.MouseClick
        userID = userID3
        userinfo.Show()
        Me.Hide()
    End Sub

    Private Sub Users4_MouseClick(sender As Object, e As MouseEventArgs) Handles Users4.MouseClick
        userID = userID4
        userinfo.Show()
        Me.Hide()
    End Sub

    Private Sub Users5_MouseClick(sender As Object, e As MouseEventArgs) Handles Users5.MouseClick
        userID = userID5
        userinfo.Show()
        Me.Hide()
    End Sub

    Private Sub Users6_MouseClick(sender As Object, e As MouseEventArgs) Handles Users6.MouseClick
        userID = userID6
        userinfo.Show()
        Me.Hide()
    End Sub

    Private Sub Users7_MouseClick(sender As Object, e As MouseEventArgs) Handles Users7.MouseClick
        userID = userID7
        userinfo.Show()
        Me.Hide()
    End Sub

    Private Sub Users8_MouseClick(sender As Object, e As MouseEventArgs) Handles Users8.MouseClick
        userID = userID8
        userinfo.Show()
        Me.Hide()
    End Sub

    Private Sub Users9_MouseClick(sender As Object, e As MouseEventArgs) Handles Users9.MouseClick
        userID = userID9
        userinfo.Show()
        Me.Hide()
    End Sub

    Private Sub Users10_MouseClick(sender As Object, e As MouseEventArgs) Handles Users10.MouseClick
        userID = userID10
        userinfo.Show()
        Me.Hide()
    End Sub

    Private Sub Users11_MouseClick(sender As Object, e As MouseEventArgs) Handles Users11.MouseClick
        userID = userID11
        userinfo.Show()
        Me.Hide()
    End Sub

    Private Sub Users12_MouseClick(sender As Object, e As MouseEventArgs) Handles Users12.MouseClick
        userID = userID12
        userinfo.Show()
        Me.Hide()
    End Sub

    Private Sub Users13_MouseClick(sender As Object, e As MouseEventArgs) Handles Users13.MouseClick
        userID = userID13
        userinfo.Show()
        Me.Hide()
    End Sub

    Private Sub Users14_MouseClick(sender As Object, e As MouseEventArgs) Handles Users14.MouseClick
        userID = userID14
        userinfo.Show()
        Me.Hide()
    End Sub

    Private Sub Users15_MouseClick(sender As Object, e As MouseEventArgs) Handles Users15.MouseClick
        userID = userID15
        userinfo.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToString("MM/dd/yy")
        Label2.Text = Date.Now.ToString("hh:mm")
    End Sub

    Private Sub Panel10_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel10.MouseClick
        Me.Close()
        loading.Show()
    End Sub
End Class