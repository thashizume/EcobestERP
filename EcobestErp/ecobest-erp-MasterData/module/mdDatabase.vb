Module mdDatabase

    Private Const _userName As String = "sa"
    Private Const _userPass As String = "12qwaszx"
    Private Const _server As String = "ECOBEST-X250\SQLEXPRESS"
    Private Const _catalog As String = "ecobest"
    Private Const _dsn As String = "ecobest"


    Public ReadOnly Property ConnectionString As String
        Get
            Dim builder As SqlClient.SqlConnectionStringBuilder = New SqlClient.SqlConnectionStringBuilder

            builder.DataSource = _server
            builder.InitialCatalog = _catalog
            builder.UserID = _userName
            builder.Password = _userPass

            Return builder.ConnectionString
        End Get
    End Property

End Module
