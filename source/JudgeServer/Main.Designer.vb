<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ServerTab = New System.Windows.Forms.TabControl()
        Me.ProblemTabPage = New System.Windows.Forms.TabPage()
        Me.NetworkTabPage = New System.Windows.Forms.TabPage()
        Me.ServerTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'ServerTab
        '
        Me.ServerTab.Controls.Add(Me.ProblemTabPage)
        Me.ServerTab.Controls.Add(Me.NetworkTabPage)
        Me.ServerTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ServerTab.Location = New System.Drawing.Point(0, 0)
        Me.ServerTab.Name = "ServerTab"
        Me.ServerTab.SelectedIndex = 0
        Me.ServerTab.Size = New System.Drawing.Size(484, 447)
        Me.ServerTab.TabIndex = 0
        '
        'ProblemTabPage
        '
        Me.ProblemTabPage.Location = New System.Drawing.Point(4, 22)
        Me.ProblemTabPage.Name = "ProblemTabPage"
        Me.ProblemTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ProblemTabPage.Size = New System.Drawing.Size(476, 421)
        Me.ProblemTabPage.TabIndex = 0
        Me.ProblemTabPage.Text = "Problem Setting"
        Me.ProblemTabPage.UseVisualStyleBackColor = True
        '
        'NetworkTabPage
        '
        Me.NetworkTabPage.Location = New System.Drawing.Point(4, 22)
        Me.NetworkTabPage.Name = "NetworkTabPage"
        Me.NetworkTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.NetworkTabPage.Size = New System.Drawing.Size(476, 421)
        Me.NetworkTabPage.TabIndex = 1
        Me.NetworkTabPage.Text = "Network Setting"
        Me.NetworkTabPage.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 447)
        Me.Controls.Add(Me.ServerTab)
        Me.Name = "Main"
        Me.Text = "Judge Server"
        Me.ServerTab.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ServerTab As System.Windows.Forms.TabControl
    Friend WithEvents ProblemTabPage As System.Windows.Forms.TabPage
    Friend WithEvents NetworkTabPage As System.Windows.Forms.TabPage
End Class
