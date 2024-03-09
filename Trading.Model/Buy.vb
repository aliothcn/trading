Public Class Buy
    Private _id As Integer
    Private _sid As Integer
    Private _sday As Date
    Private _money As Decimal
    Private _ispay As Boolean
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
    Property sday() As Date
        Get
            Return _sday
        End Get
        Set(value As Date)
            _sday = value
        End Set
    End Property
    Property money() As Decimal
        Get
            Return _money
        End Get
        Set(value As Decimal)
            _money = value
        End Set
    End Property
    Property ispay() As Boolean
        Get
            Return _ispay
        End Get
        Set(value As Boolean)
            _ispay = value
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
