Public Class ProblemControl


    Private VProblemNumber As Integer
    Private VProblemSet() As Problem

    Public Property ProblemNumber() As Integer
        Get
            Return VProblemNumber
        End Get
        Set(ByVal value As Integer)
            ProblemListView.Items.Clear()
            If value > 0 Then
                VProblemNumber = value
                ReDim Preserve VProblemSet(VProblemNumber)
                For i = 1 To VProblemNumber
                    If VProblemSet(i) Is Nothing Then
                        VProblemSet(i) = New Problem
                        VProblemSet(i).Name = "Problem " + Str(i)
                        VProblemSet(i).Input = ""
                        VProblemSet(i).Output = ""
                        VProblemSet(i).TimeLimit = 1000
                    End If
                    Dim Item As New ListViewItem
                    Item.Text = VProblemSet(i).Name
                    Item.SubItems.Add(VProblemSet(i).Input)
                    Item.SubItems.Add(VProblemSet(i).Output)
                    Item.SubItems.Add(VProblemSet(i).TimeLimit)
                    ProblemListView.Items.Add(Item)
                Next
            Else
                VProblemNumber = 0
            End If
        End Set
    End Property

    Private Sub RefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButton.Click
        ProblemNumber = ProblemNumberNumeric.Value
    End Sub

    Private Sub ClearAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearAllButton.Click
        ProblemNumber = 0
    End Sub
End Class
