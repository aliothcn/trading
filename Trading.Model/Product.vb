Public Class Product
    Private _id As Integer
    Private _name As String
    Private _num As String
    Private _text As String
    Property id() As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Property name() As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property
    Property num As String
        Get
            Return _num
        End Get
        Set(value As String)
            _num = value
        End Set
    End Property
    Property text As String
        Get
            Return _text
        End Get
        Set(value As String)
            _text = value
        End Set
    End Property
End Class
