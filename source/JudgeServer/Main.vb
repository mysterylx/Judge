Public Class Main
    Private ProblemControler As ProblemControl

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProblemControler = New ProblemControl
        ProblemControler.Dock = DockStyle.Fill
        Me.ProblemTabPage.Controls.Add(ProblemControler)
    End Sub

End Class