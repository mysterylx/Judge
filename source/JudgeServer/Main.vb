Public Class Main
    Private ProblemControler As ProblemControl
    Private NetworkControler As NetworkControl

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProblemControler = New ProblemControl
        ProblemControler.Dock = DockStyle.Fill
        ProblemTabPage.Controls.Add(ProblemControler)
        NetworkControler = New NetworkControl
        NetworkControler.Dock = DockStyle.Fill
        NetworkTabPage.Controls.Add(NetworkControler)
    End Sub

End Class