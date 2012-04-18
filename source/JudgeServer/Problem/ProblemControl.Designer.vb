<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProblemControl
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写 Dispose，以清理组件列表。
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
        Me.ProblemTabControl = New System.Windows.Forms.TabControl()
        Me.MainTabPage = New System.Windows.Forms.TabPage()
        Me.AddGroupBox = New System.Windows.Forms.GroupBox()
        Me.StandardInputLabel = New System.Windows.Forms.Label()
        Me.StandaradOutputLabel = New System.Windows.Forms.Label()
        Me.InputTextBox = New System.Windows.Forms.TextBox()
        Me.OutputTextBox = New System.Windows.Forms.TextBox()
        Me.OpenInputFileButton = New System.Windows.Forms.Button()
        Me.OpenOutputFileButton = New System.Windows.Forms.Button()
        Me.TimeLimitLabel = New System.Windows.Forms.Label()
        Me.TimePicker = New System.Windows.Forms.NumericUpDown()
        Me.TimeUnitLabel = New System.Windows.Forms.Label()
        Me.ConfirmButton = New System.Windows.Forms.Button()
        Me.ProblemNameLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ProblemTabControl.SuspendLayout()
        Me.MainTabPage.SuspendLayout()
        Me.AddGroupBox.SuspendLayout()
        CType(Me.TimePicker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProblemTabControl
        '
        Me.ProblemTabControl.Controls.Add(Me.MainTabPage)
        Me.ProblemTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProblemTabControl.Location = New System.Drawing.Point(0, 0)
        Me.ProblemTabControl.Name = "ProblemTabControl"
        Me.ProblemTabControl.SelectedIndex = 0
        Me.ProblemTabControl.Size = New System.Drawing.Size(397, 394)
        Me.ProblemTabControl.TabIndex = 0
        '
        'MainTabPage
        '
        Me.MainTabPage.Controls.Add(Me.AddGroupBox)
        Me.MainTabPage.Location = New System.Drawing.Point(4, 22)
        Me.MainTabPage.Name = "MainTabPage"
        Me.MainTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.MainTabPage.Size = New System.Drawing.Size(389, 368)
        Me.MainTabPage.TabIndex = 0
        Me.MainTabPage.Text = "Problem Control"
        Me.MainTabPage.UseVisualStyleBackColor = True
        '
        'AddGroupBox
        '
        Me.AddGroupBox.Controls.Add(Me.ClearButton)
        Me.AddGroupBox.Controls.Add(Me.NameTextBox)
        Me.AddGroupBox.Controls.Add(Me.ProblemNameLabel)
        Me.AddGroupBox.Controls.Add(Me.ConfirmButton)
        Me.AddGroupBox.Controls.Add(Me.TimeUnitLabel)
        Me.AddGroupBox.Controls.Add(Me.TimePicker)
        Me.AddGroupBox.Controls.Add(Me.TimeLimitLabel)
        Me.AddGroupBox.Controls.Add(Me.OpenOutputFileButton)
        Me.AddGroupBox.Controls.Add(Me.OpenInputFileButton)
        Me.AddGroupBox.Controls.Add(Me.OutputTextBox)
        Me.AddGroupBox.Controls.Add(Me.InputTextBox)
        Me.AddGroupBox.Controls.Add(Me.StandaradOutputLabel)
        Me.AddGroupBox.Controls.Add(Me.StandardInputLabel)
        Me.AddGroupBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.AddGroupBox.Location = New System.Drawing.Point(3, 3)
        Me.AddGroupBox.Name = "AddGroupBox"
        Me.AddGroupBox.Size = New System.Drawing.Size(383, 176)
        Me.AddGroupBox.TabIndex = 0
        Me.AddGroupBox.TabStop = False
        Me.AddGroupBox.Text = "Add Problem"
        '
        'StandardInputLabel
        '
        Me.StandardInputLabel.AutoSize = True
        Me.StandardInputLabel.Location = New System.Drawing.Point(15, 59)
        Me.StandardInputLabel.Name = "StandardInputLabel"
        Me.StandardInputLabel.Size = New System.Drawing.Size(83, 13)
        Me.StandardInputLabel.TabIndex = 0
        Me.StandardInputLabel.Text = "Standard Input: "
        Me.StandardInputLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'StandaradOutputLabel
        '
        Me.StandaradOutputLabel.AutoSize = True
        Me.StandaradOutputLabel.Location = New System.Drawing.Point(7, 88)
        Me.StandaradOutputLabel.Name = "StandaradOutputLabel"
        Me.StandaradOutputLabel.Size = New System.Drawing.Size(91, 13)
        Me.StandaradOutputLabel.TabIndex = 1
        Me.StandaradOutputLabel.Text = "Standard Output: "
        Me.StandaradOutputLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'InputTextBox
        '
        Me.InputTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InputTextBox.Location = New System.Drawing.Point(104, 56)
        Me.InputTextBox.Name = "InputTextBox"
        Me.InputTextBox.Size = New System.Drawing.Size(242, 20)
        Me.InputTextBox.TabIndex = 2
        '
        'OutputTextBox
        '
        Me.OutputTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputTextBox.Location = New System.Drawing.Point(104, 85)
        Me.OutputTextBox.Name = "OutputTextBox"
        Me.OutputTextBox.Size = New System.Drawing.Size(242, 20)
        Me.OutputTextBox.TabIndex = 3
        '
        'OpenInputFileButton
        '
        Me.OpenInputFileButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OpenInputFileButton.Location = New System.Drawing.Point(352, 54)
        Me.OpenInputFileButton.Name = "OpenInputFileButton"
        Me.OpenInputFileButton.Size = New System.Drawing.Size(25, 23)
        Me.OpenInputFileButton.TabIndex = 4
        Me.OpenInputFileButton.Text = "..."
        Me.OpenInputFileButton.UseVisualStyleBackColor = True
        '
        'OpenOutputFileButton
        '
        Me.OpenOutputFileButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OpenOutputFileButton.Location = New System.Drawing.Point(352, 83)
        Me.OpenOutputFileButton.Name = "OpenOutputFileButton"
        Me.OpenOutputFileButton.Size = New System.Drawing.Size(25, 23)
        Me.OpenOutputFileButton.TabIndex = 5
        Me.OpenOutputFileButton.Text = "..."
        Me.OpenOutputFileButton.UseVisualStyleBackColor = True
        '
        'TimeLimitLabel
        '
        Me.TimeLimitLabel.AutoSize = True
        Me.TimeLimitLabel.Location = New System.Drawing.Point(38, 113)
        Me.TimeLimitLabel.Name = "TimeLimitLabel"
        Me.TimeLimitLabel.Size = New System.Drawing.Size(60, 13)
        Me.TimeLimitLabel.TabIndex = 6
        Me.TimeLimitLabel.Text = "Time Limit: "
        Me.TimeLimitLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TimePicker
        '
        Me.TimePicker.Location = New System.Drawing.Point(104, 111)
        Me.TimePicker.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.TimePicker.Name = "TimePicker"
        Me.TimePicker.Size = New System.Drawing.Size(120, 20)
        Me.TimePicker.TabIndex = 7
        Me.TimePicker.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'TimeUnitLabel
        '
        Me.TimeUnitLabel.AutoSize = True
        Me.TimeUnitLabel.Location = New System.Drawing.Point(230, 118)
        Me.TimeUnitLabel.Name = "TimeUnitLabel"
        Me.TimeUnitLabel.Size = New System.Drawing.Size(20, 13)
        Me.TimeUnitLabel.TabIndex = 8
        Me.TimeUnitLabel.Text = "ms"
        '
        'ConfirmButton
        '
        Me.ConfirmButton.Location = New System.Drawing.Point(187, 137)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(92, 30)
        Me.ConfirmButton.TabIndex = 9
        Me.ConfirmButton.Text = "Confirm"
        Me.ConfirmButton.UseVisualStyleBackColor = True
        '
        'ProblemNameLabel
        '
        Me.ProblemNameLabel.AutoSize = True
        Me.ProblemNameLabel.Location = New System.Drawing.Point(16, 31)
        Me.ProblemNameLabel.Name = "ProblemNameLabel"
        Me.ProblemNameLabel.Size = New System.Drawing.Size(82, 13)
        Me.ProblemNameLabel.TabIndex = 10
        Me.ProblemNameLabel.Text = "Problem Name: "
        Me.ProblemNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'NameTextBox
        '
        Me.NameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NameTextBox.Location = New System.Drawing.Point(104, 28)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(273, 20)
        Me.NameTextBox.TabIndex = 11
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(285, 137)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(92, 30)
        Me.ClearButton.TabIndex = 12
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ProblemControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ProblemTabControl)
        Me.Name = "ProblemControl"
        Me.Size = New System.Drawing.Size(397, 394)
        Me.ProblemTabControl.ResumeLayout(False)
        Me.MainTabPage.ResumeLayout(False)
        Me.AddGroupBox.ResumeLayout(False)
        Me.AddGroupBox.PerformLayout()
        CType(Me.TimePicker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProblemTabControl As System.Windows.Forms.TabControl
    Friend WithEvents MainTabPage As System.Windows.Forms.TabPage
    Friend WithEvents AddGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProblemNameLabel As System.Windows.Forms.Label
    Friend WithEvents ConfirmButton As System.Windows.Forms.Button
    Friend WithEvents TimeUnitLabel As System.Windows.Forms.Label
    Friend WithEvents TimePicker As System.Windows.Forms.NumericUpDown
    Friend WithEvents TimeLimitLabel As System.Windows.Forms.Label
    Friend WithEvents OpenOutputFileButton As System.Windows.Forms.Button
    Friend WithEvents OpenInputFileButton As System.Windows.Forms.Button
    Friend WithEvents OutputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StandaradOutputLabel As System.Windows.Forms.Label
    Friend WithEvents StandardInputLabel As System.Windows.Forms.Label

End Class
