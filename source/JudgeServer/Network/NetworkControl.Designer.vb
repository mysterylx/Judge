<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NetworkControl
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
        Me.IPAddressTextBox = New System.Windows.Forms.TextBox()
        Me.PortTextBox = New System.Windows.Forms.TextBox()
        Me.IPAddressLabel = New System.Windows.Forms.Label()
        Me.PortLabel = New System.Windows.Forms.Label()
        Me.NetworkInfoTextBox = New System.Windows.Forms.TextBox()
        Me.StartServerButton = New System.Windows.Forms.Button()
        Me.StopServerButton = New System.Windows.Forms.Button()
        Me.NetworkInformationLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'IPAddressTextBox
        '
        Me.IPAddressTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IPAddressTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.IPAddressTextBox.Location = New System.Drawing.Point(90, 14)
        Me.IPAddressTextBox.Name = "IPAddressTextBox"
        Me.IPAddressTextBox.Size = New System.Drawing.Size(143, 20)
        Me.IPAddressTextBox.TabIndex = 0
        '
        'PortTextBox
        '
        Me.PortTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PortTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.PortTextBox.Location = New System.Drawing.Point(90, 41)
        Me.PortTextBox.Name = "PortTextBox"
        Me.PortTextBox.Size = New System.Drawing.Size(143, 20)
        Me.PortTextBox.TabIndex = 1
        '
        'IPAddressLabel
        '
        Me.IPAddressLabel.AutoSize = True
        Me.IPAddressLabel.Location = New System.Drawing.Point(20, 17)
        Me.IPAddressLabel.Name = "IPAddressLabel"
        Me.IPAddressLabel.Size = New System.Drawing.Size(64, 13)
        Me.IPAddressLabel.TabIndex = 2
        Me.IPAddressLabel.Text = "IP Address: "
        Me.IPAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PortLabel
        '
        Me.PortLabel.AutoSize = True
        Me.PortLabel.Location = New System.Drawing.Point(52, 44)
        Me.PortLabel.Name = "PortLabel"
        Me.PortLabel.Size = New System.Drawing.Size(32, 13)
        Me.PortLabel.TabIndex = 3
        Me.PortLabel.Text = "Port: "
        Me.PortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NetworkInfoTextBox
        '
        Me.NetworkInfoTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NetworkInfoTextBox.Location = New System.Drawing.Point(6, 120)
        Me.NetworkInfoTextBox.Multiline = True
        Me.NetworkInfoTextBox.Name = "NetworkInfoTextBox"
        Me.NetworkInfoTextBox.ReadOnly = True
        Me.NetworkInfoTextBox.Size = New System.Drawing.Size(227, 127)
        Me.NetworkInfoTextBox.TabIndex = 4
        '
        'StartServerButton
        '
        Me.StartServerButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartServerButton.Location = New System.Drawing.Point(33, 67)
        Me.StartServerButton.Name = "StartServerButton"
        Me.StartServerButton.Size = New System.Drawing.Size(97, 34)
        Me.StartServerButton.TabIndex = 5
        Me.StartServerButton.Text = "Start Server"
        Me.StartServerButton.UseVisualStyleBackColor = True
        '
        'StopServerButton
        '
        Me.StopServerButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StopServerButton.Location = New System.Drawing.Point(136, 67)
        Me.StopServerButton.Name = "StopServerButton"
        Me.StopServerButton.Size = New System.Drawing.Size(97, 34)
        Me.StopServerButton.TabIndex = 6
        Me.StopServerButton.Text = "Stop Server"
        Me.StopServerButton.UseVisualStyleBackColor = True
        '
        'NetworkInformationLabel
        '
        Me.NetworkInformationLabel.AutoSize = True
        Me.NetworkInformationLabel.Location = New System.Drawing.Point(3, 104)
        Me.NetworkInformationLabel.Name = "NetworkInformationLabel"
        Me.NetworkInformationLabel.Size = New System.Drawing.Size(108, 13)
        Me.NetworkInformationLabel.TabIndex = 7
        Me.NetworkInformationLabel.Text = "Network Information: "
        '
        'NetworkControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.NetworkInformationLabel)
        Me.Controls.Add(Me.StopServerButton)
        Me.Controls.Add(Me.StartServerButton)
        Me.Controls.Add(Me.NetworkInfoTextBox)
        Me.Controls.Add(Me.PortLabel)
        Me.Controls.Add(Me.IPAddressLabel)
        Me.Controls.Add(Me.PortTextBox)
        Me.Controls.Add(Me.IPAddressTextBox)
        Me.Name = "NetworkControl"
        Me.Size = New System.Drawing.Size(243, 259)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IPAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PortTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IPAddressLabel As System.Windows.Forms.Label
    Friend WithEvents PortLabel As System.Windows.Forms.Label
    Friend WithEvents NetworkInfoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StartServerButton As System.Windows.Forms.Button
    Friend WithEvents StopServerButton As System.Windows.Forms.Button
    Friend WithEvents NetworkInformationLabel As System.Windows.Forms.Label

End Class
