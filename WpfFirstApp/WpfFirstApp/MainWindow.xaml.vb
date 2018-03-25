Class MainWindow
    Private Sub myButton_Click(sender As Object, e As RoutedEventArgs) Handles myButton.Click
        Dim enteredvalue As String = myTextBox.Text
        enteredvalue = "You typed: " + enteredvalue
        myLabel.Content = enteredvalue
    End Sub
End Class
