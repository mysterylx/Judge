Public Class IUserDatabase

    Property problemNumber As Integer
    Function ClearDatabase() As Boolean
        Dim connection As SqlConnection
        connString = ""
        connection = New SqlConnection(connString)
        Dim Clear As Boolean
        Try
            connection.Open()
            Dim Objcommand As SqlCommand = New Sqlcommand("delete * from users", connection)
            Clear = Objcommand.ExecuteNonQuery()
        Catch OleDbExceptionErr As OleDbException
            Debug.WriteLine(OleDbExceptionErr.Message)
        Catch InvalidOperationExceptionErr As InvalidOperationException
            Debug.WriteLine(InvalidOperationExceptionErr.Message)
        End Try
        connection.Close()
        connection.Dispose()
        connection = Nothing
        Return Clear
    End Function
    Function RandomGenerateUser(ByVal userNumber As Integer) As Boolean
        Dim rand = New System.Random()
        Dim id As Integer
        Dim passwd As Integer
        Dim used(1000) As Boolean
        Dim connString As String
        Dim connection As SqlConnection
        connString = ""
        connection = New SqlConnection(connString)
        Try
            connection.Open()
            For id = 1 To userNumber Step 1
                While passwd = rand.next(1000)
                    If used(passwd) <> True Then
                        used(passwd) = True
                        Exit While
                    Else
                        Continue While
                    End If
                End While
                Try
                    Dim Objcommand As SqlCommand
                    Dim intRowAffect As Integer
                    Objcommand = New SqlCommand("insert into users (username, userpassword) values (@username, @userpassword)", connection)
                    Objcommand.Parameters.Add("@username", id)
                    Objcommand.Parameters.Add("@userpassword", passwd)
                    intRoeAffect = Objcommand.ExecuteNonQuery()
                    If intRowAffect = 0 Then
                        connection.Close()
                        connection.Dispose()
                        connection = Nothing
                        Throw New Exception("Update Failed")
                        Return False
                    End If
                Catch ExceptionErr As Exception
                    MessageBox.Show(ExceptionErr.Message)
                End Try
            Next id
        Catch OleDbExceptionErr As OleDbException
            connection.Close()
            connection.Dispose()
            connection = Nothing
            Debug.WriteLine(OleDbExceptionErr.Message)
            Return False
        Catch InvalidOperationExceptionErr As InvalidOperationException
            connection.Close()
            connection.Dispose()
            connection = Nothing
            Debug.WriteLine(InvalidOperationExceptionErr.Message)
            Return False
        End Try
        connection.Close()
        connection.Dispose()
        connection = Nothing
        Return True
    End Function
    Function IsUserValid(ByVal name As String, ByVal password As String) As Boolean
        Dim id As Integer
        Dim passwd As Integer
        Dim reader As Integer
        Dim Valid As Boolean
        id = Val(name)
        passwd = Val(password)
        Dim connection As SqlConnection
        connString = ""
        connection = New SqlConnection(connString)
        Try
            connection.Open()
            Dim Objcommand As SqlCommand = New Sqlcommand("select from users (username, userpassword) values (@username, @userpassword)", connection)
            Objcommand.Parameters.Add("@username", id)
            Objcommand.Parameters.Add("@userpassword", passwd)
            reader = Objcommand.ExecuteReader()
            If intAffect = 1 Then
                Valid = True
            Else
                Valid = False
            End If
        Catch OleDbExceptionErr As OleDbException
            Debug.WriteLine(OleDbExceptionErr.Message)
        Catch InvalidOperationExceptionErr As InvalidOperationException
            Debug.WriteLine(InvalidOperationExceptionErr.Message)
        End Try
        connection.Close()
        connection.Dispose()
        connection = Nothing
        Return Valid
    End Function

End Class
