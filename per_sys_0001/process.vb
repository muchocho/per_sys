Imports MySql.Data.MySqlClient
Module process
    Public conbin As New MySqlConnection("server=localhost;database=per_sys;uid=root;pwd=root;")
    Public usconID As Integer
    Public tablesval As New DataTable
    Public userID1 As Integer
    Public userID2 As Integer
    Public userID3 As Integer
    Public userID4 As Integer
    Public userID5 As Integer
    Public userID6 As Integer
    Public userID7 As Integer
    Public userID8 As Integer
    Public userID9 As Integer
    Public userID10 As Integer
    Public userID11 As Integer
    Public userID12 As Integer
    Public userID13 As Integer
    Public userID14 As Integer
    Public userID15 As Integer
    Public userID As Integer
    Dim constat As String = "connected"
    Dim duestat As String = "paid"



    Public Sub connect()
        If conbin.State = ConnectionState.Open Then
            conbin.Close()
            conbin.Open()
        Else
            conbin.Open()
        End If
    End Sub
    Public Function register(_name As String, _email As String, _fb As String, _address As String, _conNum As String, _accType As String, _monthly As String, _ddate As String)
        connect()
        Dim cmd As New MySqlCommand("INSERT INTO acc_data(name,email,facebook,address,contactNO,accountType,monthly,tdate,duestatus,constatus)VALUES(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10)", conbin)
        With cmd
            .Parameters.AddWithValue("@1", _name)
            .Parameters.AddWithValue("@2", _email)
            .Parameters.AddWithValue("@3", _fb)
            .Parameters.AddWithValue("@4", _address)
            .Parameters.AddWithValue("@5", _conNum)
            .Parameters.AddWithValue("@6", _accType)
            .Parameters.AddWithValue("@7", _monthly)
            .Parameters.AddWithValue("@8", _ddate)
            .Parameters.AddWithValue("@9", duestat)
            .Parameters.AddWithValue("@10", constat)
            .ExecuteNonQuery()
        End With
        Return True
    End Function

    Public Function regusrlogs(_uid As Integer, _perIN As String, _payment As String, _orNo As String, _ddate As String, _ttime As String, _balance As String, _advance As String, _due As String)
        connect()
        Dim cmd As New MySqlCommand("INSERT INTO account_logs(userIDL,perIncharge,payment,orNum,lDate,lTime,balance,advance,dueDate)VALUES(@1,@2,@3,@4,@5,@6,@7,@8,@9)", conbin)
        With cmd
            .Parameters.AddWithValue("@1", _uid)
            .Parameters.AddWithValue("@2", _perIN)
            .Parameters.AddWithValue("@3", _payment)
            .Parameters.AddWithValue("@4", _orNo)
            .Parameters.AddWithValue("@5", _ddate)
            .Parameters.AddWithValue("@6", _ttime)
            .Parameters.AddWithValue("@7", _balance)
            .Parameters.AddWithValue("@8", _advance)
            .Parameters.AddWithValue("@9", _due)
            .ExecuteNonQuery()
        End With
        Return True
    End Function


End Module
