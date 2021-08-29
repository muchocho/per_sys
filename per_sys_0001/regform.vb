Imports MySql.Data.MySqlClient
Public Class regform
    Dim uname As String
    Dim usrbal As Integer
    Dim usrad As Integer
    Dim ldate As Date
    Dim duedate As String


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Panel2_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel2.MouseClick

        uname = TextBox1.Text + " " + TextBox2.Text

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox10.Text = "" Or TextBox11.Text = "" Then
            MessageBox.Show("Please fill-out the neccessary information needed!")
        Else

            If TextBox10.Text > TextBox9.Text Then
                usrad = TextBox10.Text - TextBox9.Text
                usrbal = 0
            ElseIf TextBox10.Text < TextBox9.Text
                usrbal = TextBox9.Text - TextBox10.Text
                usrad = 0
            End If

            ldate = Label1.Text
            duedate = DateAdd(DateInterval.Day, 32, ldate)

            register(uname, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, Label1.Text)

            connect()
            Dim cmd As New MySqlDataAdapter("SELECT * FROM acc_data WHERE name = '" & uname & "'", conbin)
            Dim usrid As New DataTable
            cmd.Fill(usrid)
            Dim userIDd As Integer = usrid.Rows(0).Item(0)

            regusrlogs(userIDd, TextBox11.Text, TextBox10.Text, TextBox12.Text, Label1.Text, Label2.Text, usrbal, usrad, duedate)
            MessageBox.Show("Success!")
            TextBox1.Focus()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            TextBox8.Clear()
            TextBox9.Clear()
            TextBox10.Clear()
            TextBox11.Clear()
            TextBox12.Clear()

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToString("MM/dd/yy")
        Label2.Text = Date.Now.ToString("hh:mm")
    End Sub

    Private Sub regform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Panel3_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel3.MouseClick
        Me.Close()
        loading.Show()
    End Sub
End Class