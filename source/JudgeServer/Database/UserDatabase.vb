Public Class UserDatabase

    Dim VProblemNumber As Integer

    Property ProblemNumber() As Integer
        Get
            Return VProblemNumber
        End Get
        Set(ByVal value As Integer)
            VProblemNumber = value
        End Set
    End Property

    Function ClearDatabase() As Boolean
        Dim connection As SqlConnection
        Dim Clear As Boolean
        Dim reader As SqlDataReader
        connString = "Data Source = localhost;Initial Catalog = MatchInformation;integrated security=true"
        connection = New SqlConnection(connString)
        Try
            connection.Open()
            Dim sqlstring As String = "delete  from users"
            Dim command As New SqlCommand(sqlstring, connection)
            command.ExecuteNonQuery()
        Catch OleDbExceptionErr As OleDbException
            Debug.WriteLine(OleDbExceptionErr.Message)
        Catch InvalidOperationExceptionErr As InvalidOperationException
            Debug.WriteLine(InvalidOperationExceptionErr.Message)
        Catch sqlExceptionErr As SqlException
            Debug.WriteLine(sqlExceptionErr.Message)
        End Try
        connection.Close()
        connection.Dispose()
        connection = Nothing
        Return Clear
    End Function

    Function RandomGenerateUser(ByVal userNumber As Integer) As Boolean
        Dim rand = New System.Random()
        Dim i As Integer
        Dim randnum As Integer
        Dim name As String
        Dim passwd As String
        Dim used(1000) As Boolean
        Dim connString As String
        Dim connection As SqlConnection
        connString = "Data Source = localhost;Initial Catalog = MatchInformation;integrated security=true"
        connection = New SqlConnection(connString)
        Try
            connection.Open()
            For i = 1 To VProblemNumber Step 1
                While randnum = rand.next(1000, 9999)
                    If used(randnum) <> True Then
                        used(randnum) = True
                        Exit While
                    Else
                        Continue While
                    End If
                End While
                Try
                    name = "Team" & Str(i)
                    passwd = Str(randnum)
                    Dim sqlstring As String = "insert into users (username,userpassword) values ('" & name & "','" & passwd & "')"
                    Dim cmd As New SqlCommand(sqlstring, connection)
                    Try
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                Catch ExceptionErr As Exception
                    MessageBox.Show(ExceptionErr.Message)
                End Try
            Next id
        Catch OleDbExceptionErr As OleDbException
            Debug.WriteLine(OleDbExceptionErr.Message)
        Catch InvalidOperationExceptionErr As InvalidOperationException
            Debug.WriteLine(InvalidOperationExceptionErr.Message)
        Catch sqlExceptionErr As SqlException
            Debug.WriteLine(sqlExceptionErr.Message)
        End Try
        connection.Close()
        connection.Dispose()
        connection = Nothing
    End Function

    Function IsUserValid(ByVal name As String, ByVal password As String) As Boolean
        Dim Valid As Boolean
        Dim id As Integer
        Dim passwd As Integer
        Dim reader As SqlDataReader
        Dim connection As SqlConnection
        connString = "Data Source = localhost;Initial Catalog = MatchInformation;integrated security=true"
        connection = New SqlConnection(connString)
        Try
            connection.Open()
            Dim sqlstring As String = "select * from users where username = '" & name & "'And userpassword ='" & password & "'"
            Dim command As New SqlCommand(sqlstring, connection)
            reader = command.ExecuteReader
            If reader.Read() = True Then
                Valid = True
            End If
        Catch OleDbExceptionErr As OleDbException
            Debug.WriteLine(OleDbExceptionErr.Message)
        Catch InvalidOperationExceptionErr As InvalidOperationException
            Debug.WriteLine(InvalidOperationExceptionErr.Message)
        Catch sqlExceptionErr As SqlException
            Debug.WriteLine(sqlExceptionErr.Message)
        End Try
        connection.Close()
        connection.Dispose()
        connection = Nothing
        Return Valid
    End Function

    Function ChangePassword(ByVal name As String, ByVal password As String) As Boolean
        Dim Change As Boolean
        Dim connString As String
        connString = "Data Source = localhost;Initial Catalog = MatchInformation;integrated security=true"
        Dim connection = New SqlConnection(connString)
        Try
            connection.Open()
            Dim sqlsearch As String = "select * from users where username = '" & name & "' "
            Dim sqlupdate As String = "update users set userpassword = '" & passwd & " ' where username = ' " & name & " ' "
            Dim cmdsearch As New SqlCommand(sqlsearch, connection)
            Dim cmdupdate As New SqlCommand(sqlupdate, connection)
            Dim reader As SqlDataReader = cmdsearch.ExecuteReader
            If reader.Read() = True Then
                reader.Close()
                cmdupdate.ExecuteNonQuery()
            End If
        Catch OleDbExceptionErr As OleDbException
            Debug.WriteLine(OleDbExceptionErr.Message)
        Catch InvalidOperationExceptionErr As InvalidOperationException
            Debug.WriteLine(InvalidOperationExceptionErr.Message)
        Catch sqlExceptionErr As SqlException
            Debug.WriteLine(sqlExceptionErr.Message)
        End Try
        Return Change
    End Function
End Class
