Public Class users
    Private ename As String
    Private add As String
    Private payy As String

    Public Property _ename As String
        Get
            Return ename
        End Get
        Set(value As String)
            ename = value
            Label1.Text = value
        End Set
    End Property

    Public Property _add As String
        Get
            Return add
        End Get
        Set(value As String)
            add = value
            Label2.Text = value
        End Set
    End Property

    Public Property _payy As String
        Get
            Return payy
        End Get
        Set(value As String)
            payy = value
            Label3.Text = value
        End Set
    End Property


End Class
