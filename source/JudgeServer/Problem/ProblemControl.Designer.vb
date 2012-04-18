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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ProblemsLabel = New System.Windows.Forms.Label()
        Me.ProblemListView = New System.Windows.Forms.ListView()
        Me.ProblemName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Input = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Output = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TimeLimit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.ProblemNumberNumeric = New System.Windows.Forms.NumericUpDown()
        Me.ProblemNumberLabel = New System.Windows.Forms.Label()
        Me.EditGroupBox = New System.Windows.Forms.GroupBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.ProblemNameLabel = New System.Windows.Forms.Label()
        Me.ConfirmButton = New System.Windows.Forms.Button()
        Me.TimeUnitLabel = New System.Windows.Forms.Label()
        Me.TimeLimitNumberic = New System.Windows.Forms.NumericUpDown()
        Me.TimeLimitLabel = New System.Windows.Forms.Label()
        Me.OpenOutputFileButton = New System.Windows.Forms.Button()
        Me.OpenInputFileButton = New System.Windows.Forms.Button()
        Me.OutputTextBox = New System.Windows.Forms.TextBox()
        Me.InputTextBox = New System.Windows.Forms.TextBox()
        Me.StandaradOutputLabel = New System.Windows.Forms.Label()
        Me.StandardInputLabel = New System.Windows.Forms.Label()
        Me.RegisterAllButton = New System.Windows.Forms.Button()
        Me.ClearAllButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ProblemNumberNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EditGroupBox.SuspendLayout()
        CType(Me.TimeLimitNumberic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ProblemsLabel)
        Me.GroupBox1.Controls.Add(Me.ProblemListView)
        Me.GroupBox1.Controls.Add(Me.RefreshButton)
        Me.GroupBox1.Controls.Add(Me.ProblemNumberNumeric)
        Me.GroupBox1.Controls.Add(Me.ProblemNumberLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 182)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 256)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Manage Problem"
        '
        'ProblemsLabel
        '
        Me.ProblemsLabel.AutoSize = True
        Me.ProblemsLabel.Location = New System.Drawing.Point(7, 57)
        Me.ProblemsLabel.Name = "ProblemsLabel"
        Me.ProblemsLabel.Size = New System.Drawing.Size(56, 13)
        Me.ProblemsLabel.TabIndex = 4
        Me.ProblemsLabel.Text = "Problems: "
        '
        'ProblemListView
        '
        Me.ProblemListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProblemListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ProblemName, Me.Input, Me.Output, Me.TimeLimit})
        Me.ProblemListView.GridLines = True
        Me.ProblemListView.Location = New System.Drawing.Point(10, 73)
        Me.ProblemListView.Name = "ProblemListView"
        Me.ProblemListView.Size = New System.Drawing.Size(322, 177)
        Me.ProblemListView.TabIndex = 3
        Me.ProblemListView.UseCompatibleStateImageBehavior = False
        Me.ProblemListView.View = System.Windows.Forms.View.Details
        '
        'ProblemName
        '
        Me.ProblemName.Text = "Problem Name"
        Me.ProblemName.Width = 87
        '
        'Input
        '
        Me.Input.Text = "Input"
        Me.Input.Width = 77
        '
        'Output
        '
        Me.Output.Text = "Output"
        Me.Output.Width = 74
        '
        'TimeLimit
        '
        Me.TimeLimit.Text = "Time Limit"
        Me.TimeLimit.Width = 78
        '
        'RefreshButton
        '
        Me.RefreshButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RefreshButton.Location = New System.Drawing.Point(229, 23)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(103, 23)
        Me.RefreshButton.TabIndex = 2
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'ProblemNumberNumeric
        '
        Me.ProblemNumberNumeric.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProblemNumberNumeric.Location = New System.Drawing.Point(100, 26)
        Me.ProblemNumberNumeric.Name = "ProblemNumberNumeric"
        Me.ProblemNumberNumeric.Size = New System.Drawing.Size(120, 20)
        Me.ProblemNumberNumeric.TabIndex = 1
        Me.ProblemNumberNumeric.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'ProblemNumberLabel
        '
        Me.ProblemNumberLabel.AutoSize = True
        Me.ProblemNumberLabel.Location = New System.Drawing.Point(6, 28)
        Me.ProblemNumberLabel.Name = "ProblemNumberLabel"
        Me.ProblemNumberLabel.Size = New System.Drawing.Size(91, 13)
        Me.ProblemNumberLabel.TabIndex = 0
        Me.ProblemNumberLabel.Text = "Problem Number: "
        '
        'EditGroupBox
        '
        Me.EditGroupBox.Controls.Add(Me.ClearButton)
        Me.EditGroupBox.Controls.Add(Me.NameTextBox)
        Me.EditGroupBox.Controls.Add(Me.ProblemNameLabel)
        Me.EditGroupBox.Controls.Add(Me.ConfirmButton)
        Me.EditGroupBox.Controls.Add(Me.TimeUnitLabel)
        Me.EditGroupBox.Controls.Add(Me.TimeLimitNumberic)
        Me.EditGroupBox.Controls.Add(Me.TimeLimitLabel)
        Me.EditGroupBox.Controls.Add(Me.OpenOutputFileButton)
        Me.EditGroupBox.Controls.Add(Me.OpenInputFileButton)
        Me.EditGroupBox.Controls.Add(Me.OutputTextBox)
        Me.EditGroupBox.Controls.Add(Me.InputTextBox)
        Me.EditGroupBox.Controls.Add(Me.StandaradOutputLabel)
        Me.EditGroupBox.Controls.Add(Me.StandardInputLabel)
        Me.EditGroupBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.EditGroupBox.Location = New System.Drawing.Point(0, 0)
        Me.EditGroupBox.Name = "EditGroupBox"
        Me.EditGroupBox.Size = New System.Drawing.Size(463, 176)
        Me.EditGroupBox.TabIndex = 2
        Me.EditGroupBox.TabStop = False
        Me.EditGroupBox.Text = "Edit Problem"
        '
        'ClearButton
        '
        Me.ClearButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClearButton.Location = New System.Drawing.Point(365, 140)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(92, 30)
        Me.ClearButton.TabIndex = 12
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'NameTextBox
        '
        Me.NameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NameTextBox.Location = New System.Drawing.Point(104, 28)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(353, 20)
        Me.NameTextBox.TabIndex = 11
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
        'ConfirmButton
        '
        Me.ConfirmButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConfirmButton.Location = New System.Drawing.Point(267, 140)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(92, 30)
        Me.ConfirmButton.TabIndex = 9
        Me.ConfirmButton.Text = "Confirm"
        Me.ConfirmButton.UseVisualStyleBackColor = True
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
        'TimeLimitNumberic
        '
        Me.TimeLimitNumberic.Location = New System.Drawing.Point(104, 111)
        Me.TimeLimitNumberic.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.TimeLimitNumberic.Name = "TimeLimitNumberic"
        Me.TimeLimitNumberic.Size = New System.Drawing.Size(120, 20)
        Me.TimeLimitNumberic.TabIndex = 7
        Me.TimeLimitNumberic.Value = New Decimal(New Integer() {1000, 0, 0, 0})
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
        'OpenOutputFileButton
        '
        Me.OpenOutputFileButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OpenOutputFileButton.Location = New System.Drawing.Point(432, 83)
        Me.OpenOutputFileButton.Name = "OpenOutputFileButton"
        Me.OpenOutputFileButton.Size = New System.Drawing.Size(25, 23)
        Me.OpenOutputFileButton.TabIndex = 5
        Me.OpenOutputFileButton.Text = "..."
        Me.OpenOutputFileButton.UseVisualStyleBackColor = True
        '
        'OpenInputFileButton
        '
        Me.OpenInputFileButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OpenInputFileButton.Location = New System.Drawing.Point(432, 54)
        Me.OpenInputFileButton.Name = "OpenInputFileButton"
        Me.OpenInputFileButton.Size = New System.Drawing.Size(25, 23)
        Me.OpenInputFileButton.TabIndex = 4
        Me.OpenInputFileButton.Text = "..."
        Me.OpenInputFileButton.UseVisualStyleBackColor = True
        '
        'OutputTextBox
        '
        Me.OutputTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputTextBox.Location = New System.Drawing.Point(104, 85)
        Me.OutputTextBox.Name = "OutputTextBox"
        Me.OutputTextBox.Size = New System.Drawing.Size(322, 20)
        Me.OutputTextBox.TabIndex = 3
        '
        'InputTextBox
        '
        Me.InputTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InputTextBox.Location = New System.Drawing.Point(104, 56)
        Me.InputTextBox.Name = "InputTextBox"
        Me.InputTextBox.Size = New System.Drawing.Size(322, 20)
        Me.InputTextBox.TabIndex = 2
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
        'RegisterAllButton
        '
        Me.RegisterAllButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RegisterAllButton.Location = New System.Drawing.Point(348, 372)
        Me.RegisterAllButton.Name = "RegisterAllButton"
        Me.RegisterAllButton.Size = New System.Drawing.Size(109, 30)
        Me.RegisterAllButton.TabIndex = 4
        Me.RegisterAllButton.Text = "Register All"
        Me.RegisterAllButton.UseVisualStyleBackColor = True
        '
        'ClearAllButton
        '
        Me.ClearAllButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClearAllButton.Location = New System.Drawing.Point(348, 408)
        Me.ClearAllButton.Name = "ClearAllButton"
        Me.ClearAllButton.Size = New System.Drawing.Size(109, 30)
        Me.ClearAllButton.TabIndex = 5
        Me.ClearAllButton.Text = "Clear All"
        Me.ClearAllButton.UseVisualStyleBackColor = True
        '
        'ProblemControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ClearAllButton)
        Me.Controls.Add(Me.RegisterAllButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.EditGroupBox)
        Me.Name = "ProblemControl"
        Me.Size = New System.Drawing.Size(463, 441)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ProblemNumberNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EditGroupBox.ResumeLayout(False)
        Me.EditGroupBox.PerformLayout()
        CType(Me.TimeLimitNumberic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ProblemsLabel As System.Windows.Forms.Label
    Friend WithEvents ProblemListView As System.Windows.Forms.ListView
    Friend WithEvents ProblemName As System.Windows.Forms.ColumnHeader
    Friend WithEvents Input As System.Windows.Forms.ColumnHeader
    Friend WithEvents Output As System.Windows.Forms.ColumnHeader
    Friend WithEvents TimeLimit As System.Windows.Forms.ColumnHeader
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
    Friend WithEvents ProblemNumberNumeric As System.Windows.Forms.NumericUpDown
    Friend WithEvents ProblemNumberLabel As System.Windows.Forms.Label
    Friend WithEvents EditGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProblemNameLabel As System.Windows.Forms.Label
    Friend WithEvents ConfirmButton As System.Windows.Forms.Button
    Friend WithEvents TimeUnitLabel As System.Windows.Forms.Label
    Friend WithEvents TimeLimitNumberic As System.Windows.Forms.NumericUpDown
    Friend WithEvents TimeLimitLabel As System.Windows.Forms.Label
    Friend WithEvents OpenOutputFileButton As System.Windows.Forms.Button
    Friend WithEvents OpenInputFileButton As System.Windows.Forms.Button
    Friend WithEvents OutputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StandaradOutputLabel As System.Windows.Forms.Label
    Friend WithEvents StandardInputLabel As System.Windows.Forms.Label
    Friend WithEvents RegisterAllButton As System.Windows.Forms.Button
    Friend WithEvents ClearAllButton As System.Windows.Forms.Button

End Class
