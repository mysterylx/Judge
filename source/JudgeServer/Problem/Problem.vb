Public Class Problem

    Private VName As String
    Private VInput As String
    Private VOutput As String
    Private VTimeLimit As Integer

    Public Property Name() As String
        Get
            If String.IsNullOrEmpty(VName) Then
                VName = ""
            End If
            Return VName
        End Get
        Set(ByVal value As String)
            VName = value
        End Set
    End Property

    Public Property Input() As String
        Get
            If String.IsNullOrEmpty(VInput) Then
                VInput = ""
            End If
            Return VInput
        End Get
        Set(ByVal value As String)
            VInput = value
        End Set
    End Property

    Public Property Output() As String
        Get
            If String.IsNullOrEmpty(VOutput) Then
                VOutput = ""
            End If
            Return VOutput
        End Get
        Set(ByVal value As String)
            VOutput = value
        End Set
    End Property

    Public Property TimeLimit() As Integer
        Get
            Return VTimeLimit
        End Get
        Set(ByVal value As Integer)
            If value > 0 Then
                VTimeLimit = value
            Else
                VTimeLimit = 1000
            End If
        End Set
    End Property

End Class
