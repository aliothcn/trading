Public Class Supplier '供应商
    Private _id As Integer
    Private _name As String
    Private _address As String
    Private _person As String
    Private _tel As String
    Private _phone As String
    Private _scope As String
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
    Property address() As String
        Get
            Return _address
        End Get
        Set(value As String)
            _address = value
        End Set
    End Property
    Property person() As String
        Get
            Return _person
        End Get
        Set(value As String)
            _person = value
        End Set
    End Property
    Property tel() As String
        Get
            Return _tel
        End Get
        Set(value As String)
            _tel = value
        End Set
    End Property
    Property phone() As String
        Get
            Return _phone
        End Get
        Set(value As String)
            _phone = value
        End Set
    End Property
    Property scope() As String
        Get
            Return _scope
        End Get
        Set(value As String)
            _scope = value
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
