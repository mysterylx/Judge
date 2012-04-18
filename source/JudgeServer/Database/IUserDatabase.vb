Public Interface IUserDatabase

    Property problemNumber As Integer

    Function ClearDatabase() As Boolean
    Function RandomGenerateUser(ByVal userNumber As Integer) As Boolean
    Function IsUserValid(ByVal name As String, ByVal password As String) As Boolean

End Interface
