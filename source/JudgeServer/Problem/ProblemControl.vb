﻿Public Class ProblemControl

    Private VProblemNumber As Integer
    Private VProblemSet() As Problem
    Private VProblemIndex As Integer
<<<<<<< HEAD
=======
    Private VProblemSubmitted As Boolean
>>>>>>> e50492065777bda4d6cb6ef433c415ad47f070a8

    Public Property ProblemNumber() As Integer
        Get
            Return VProblemNumber
        End Get
        Set(ByVal value As Integer)
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
                Next
                ProblemIndex = 1
            Else
                VProblemNumber = 0
            End If
            CreateList()
        End Set
    End Property

    Public Property ProblemIndex() As Integer
        Get
            Return VProblemIndex
        End Get
        Set(ByVal value As Integer)
            VProblemIndex = value
            RefreshInput()
        End Set
    End Property

<<<<<<< HEAD
=======
    Public ReadOnly Property ProblemSubmitted() As Boolean
        Get
            Return VProblemSubmitted
        End Get
    End Property

>>>>>>> e50492065777bda4d6cb6ef433c415ad47f070a8
    Private Sub CreateList()
        ProblemListView.Items.Clear()
        For i = 1 To VProblemNumber
            Dim Item As New ListViewItem
            Item.Text = VProblemSet(i).Name
            Item.SubItems.Add(VProblemSet(i).Input)
            Item.SubItems.Add(VProblemSet(i).Output)
            Item.SubItems.Add(VProblemSet(i).TimeLimit)
            ProblemListView.Items.Add(Item)
        Next
    End Sub

    Private Sub RefreshInput()
        If ProblemIndex >= 1 And ProblemIndex <= ProblemNumber Then
            NameTextBox.Text = VProblemSet(ProblemIndex).Name
            InputTextBox.Text = VProblemSet(ProblemIndex).Input
            OutputTextBox.Text = VProblemSet(ProblemIndex).Output
            TimeLimitNumberic.Value = VProblemSet(ProblemIndex).TimeLimit
        End If
    End Sub

    Private Function GetOpenFileName() As String
        Dim FileName As String
        Dim Dialog As OpenFileDialog = New OpenFileDialog()
        Dialog.Title = "Select Data File"
        Dialog.Multiselect = False
        Dialog.ShowDialog()
        FileName = Dialog.FileName
        Return FileName
    End Function

    Private Sub RefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButton.Click
        ProblemNumber = ProblemNumberNumeric.Value
    End Sub

    Private Sub ClearAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearAllButton.Click
        ProblemNumber = 0
    End Sub

    Private Sub ConfirmButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfirmButton.Click
        If ProblemIndex >= 1 And ProblemIndex <= ProblemNumber Then
            VProblemSet(ProblemIndex).Name = NameTextBox.Text
            VProblemSet(ProblemIndex).Input = InputTextBox.Text
            VProblemSet(ProblemIndex).Output = OutputTextBox.Text
            VProblemSet(ProblemIndex).TimeLimit = TimeLimitNumberic.Value
            Dim Item As New ListViewItem
            Item.Text = VProblemSet(ProblemIndex).Name
            Item.SubItems.Add(VProblemSet(ProblemIndex).Input)
            Item.SubItems.Add(VProblemSet(ProblemIndex).Output)
            Item.SubItems.Add(VProblemSet(ProblemIndex).TimeLimit)
            ProblemListView.Items.Item(ProblemIndex - 1) = Item
        End If
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        If ProblemIndex >= 1 And ProblemIndex <= ProblemNumber Then
            NameTextBox.Text = "Problem " + Str(ProblemIndex)
            InputTextBox.Text = ""
            OutputTextBox.Text = ""
            TimeLimitNumberic.Value = 1000
        End If
    End Sub

<<<<<<< HEAD
    Private Sub RegisterAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterAllButton.Click
        'TODO
    End Sub

=======
>>>>>>> e50492065777bda4d6cb6ef433c415ad47f070a8
    Private Sub ProblemListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProblemListView.SelectedIndexChanged
        If ProblemListView.SelectedIndices.Count > 0 Then
            ProblemIndex = ProblemListView.SelectedIndices.Item(0) + 1
        End If
    End Sub

    Private Sub OpenInputFileButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenInputFileButton.Click
        InputTextBox.Text = GetOpenFileName()
    End Sub

    Private Sub OpenOutputFileButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenOutputFileButton.Click
        OutputTextBox.Text = GetOpenFileName()
<<<<<<< HEAD
=======
    End Sub

    Private Sub RegisterAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterAllButton.Click
        Dim Info As System.IO.FileInfo
        For i = 1 To ProblemNumber
            If String.IsNullOrEmpty(VProblemSet(i).Name) Then
                MessageBox.Show("The problem name cannot be empty.")
                Exit Sub
            End If
            Try
                Info = New System.IO.FileInfo(VProblemSet(i).Input)
                If Not Info.Exists Then
                    MessageBox.Show("The input file does not exist.")
                    Exit Sub
                End If
                Info = New System.IO.FileInfo(VProblemSet(i).Output)
                If Not Info.Exists Then
                    MessageBox.Show("The output file does not exist.")
                    Exit Sub
                End If
            Catch
                MessageBox.Show("The file path is not illegal.")
                Exit Sub
            End Try
        Next
        'Register Problem
>>>>>>> e50492065777bda4d6cb6ef433c415ad47f070a8
    End Sub
End Class
