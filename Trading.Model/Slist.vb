Public Class slist
    Private _id As Integer
    Private _sid As Integer
    Private _pid As Integer
    Private _price As Decimal
    Private _num As String
    Private _unit As String
    Private _text As String
    Property id() As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Property sid() As Integer
        Get
            Return _sid
        End Get
        Set(value As Integer)
            _sid = value
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
    Property price() As Decimal
        Get
            Return _price
        End Get
        Set(value As Decimal)
            _price = value
        End Set
    End Property
    Property num() As String
        Get
            Return _num
        End Get
        Set(value As String)
            _num = value
        End Set
    End Property
    Property unit() As String
        Get
            Return _unit
        End Get
        Set(value As String)
            _unit = value
        End Set
    End Property
    Property text() As String
        Get
            Return _text
        End Get
        Set(value As String)
            _text = value
        End Set
    End Property

End Class
