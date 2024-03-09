Public Class Price
    Private _id As Integer
    Private _pid As Integer
    Private _cname As String
    Private _price As Decimal
    Private _sday As DateTime

    Property id() As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Property pid() As Integer
        Get
            Return _pid
        End Get
        Set(value As Integer)
            _pid = value
        End Set
    End Property
    Property cname() As String
        Get
            Return _cname
        End Get
        Set(value As String)
            _cname = value
        End Set
    End Property
    Property price() As Decimal
        Get
            Return _price
        End Get
        Set(value As Decimal)
            _price = value
        End Set
    End Property
    Property sday() As DateTime
        Get
            Return _sday
        End Get
        Set(value As DateTime)
            _sday = value
        End Set
    End Property

End Class
