Public Class loglist
    Private perin As String
    Private paym As String
    Private orno As String
    Private dte As String
    Private tme As String

    Public Property _perin As String
        Get
            Return perin
        End Get
        Set(value As String)
            perin = value
            Label1.Text = value
        End Set
    End Property

    Public Property _paym As String
        Get
            Return paym
        End Get
        Set(value As String)
            paym = value
            Label2.Text = value
        End Set
    End Property

    Public Property _orno As String
        Get
            Return orno
        End Get
        Set(value As String)
            orno = value
            Label3.Text = value
        End Set
    End Property
    Public Property _dte As String
        Get
            Return dte
        End Get
        Set(value As String)
            dte = value
            Label4.Text = value
        End Set
    End Property

    Public Property _tme As String
        Get
            Return tme
        End Get
        Set(value As String)
            tme = value
            Label5.Text = value
        End Set
    End Property
End Class
