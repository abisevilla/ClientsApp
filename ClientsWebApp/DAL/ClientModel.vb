Public Class ClientModel
    Private _clientId As Integer

    Public Property ClientId() As Integer

        Get
            Return _clientId
        End Get
        Set(ByVal value As Integer)
            _clientId = value
        End Set
    End Property

    Private _firstName As String
    Public Property FirstName() As String
        Get
            Return _firstName
        End Get
        Set(ByVal value As String)
            _firstName = value
        End Set
    End Property

    Private _lastName As String
    Public Property LastName() As String
        Get
            Return _lastName
        End Get
        Set(ByVal value As String)
            _lastName = value
        End Set
    End Property
    Private _email As String
    Public Property Email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    Private _phone As String
    Public Property Phone() As String
        Get
            Return _phone
        End Get
        Set(ByVal value As String)
            _phone = value
        End Set
    End Property

    Private _OfficeAddress As String
    Public Property OfficeAddress() As String
        Get
            Return _OfficeAddress
        End Get
        Set(ByVal value As String)
            _OfficeAddress = value
        End Set
    End Property


End Class
