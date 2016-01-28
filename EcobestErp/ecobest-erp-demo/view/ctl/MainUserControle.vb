Public Class MainUserControle

    Private _account As AccountModel = Nothing

    Public Property Account As AccountModel
        Get
            Return _account
        End Get
        Set(value As AccountModel)
            _account = value
        End Set
    End Property



End Class
