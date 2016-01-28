Module modelAccounts

    Private _accounts As List(Of modelAccount) = New List(Of modelAccount)

    Public ReadOnly Property Count As Long
        Get
            Return _accounts.Count
        End Get
    End Property

    Public ReadOnly Property Item(AccountID As Long) As modelAccount
        Get
            Dim result As modelAccount = Nothing

            For Each k As modelAccount In _accounts
                If k.AccountID = AccountID Then
                    result = _accounts(AccountID)
                    Exit For
                End If
            Next
            Return Nothing
        End Get

    End Property

    Public Function Add(Account As modelAccount) As Boolean
        Dim result As Boolean = True
        For Each k As modelAccount In _accounts
            If k.AccountID = Account.AccountID Then
                result = False
                Exit For
            End If
        Next

        If result = True Then
            _accounts.Add(Account)
        End If
        Return result
    End Function

    Public Function Remove(Account As modelAccount) As Boolean

        Dim result As Boolean = False
        For Each k As modelAccount In _accounts
            If k.AccountID = Account.AccountID Then
                _accounts.Remove(k)
                result = True
                Exit For
            End If
        Next
        Return result

    End Function


End Module
