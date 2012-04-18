Public Class NetworkControl

    Private Sub PortTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PortTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = Chr(Keys.Back) Then
            Return
        End If
        e.Handled = True
    End Sub

End Class
