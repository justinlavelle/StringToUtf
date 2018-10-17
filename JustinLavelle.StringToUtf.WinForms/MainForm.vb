Public Class MainForm
    Private Sub ConvertToUtfButton_Click(sender As Object, e As EventArgs) Handles ConvertToUtfButton.Click
        Dim StringText As String
        StringText = ConvertToUTF16(StringTextBox.Text)             ' Call Function in Module
        UtfTextBox.Text = StringText
        UtfTextBox.Select()                                         ' Set Focus to the second TextBox & Selects Contents
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        StringTextBox.Select()                                      ' Set Focus to the initial TextBox
    End Sub
End Class
