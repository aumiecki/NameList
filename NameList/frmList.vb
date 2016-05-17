Public Class frmList
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim fullname As String

        fullname = tbLast.Text & ", " & tbFirst.Text
        listboxNames.Items.Add(fullname)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tbFirst.Clear()
        tbLast.Clear()
        listboxNames.Items.Clear()

        tbFirst.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If listboxNames.SelectedIndex < 0 Then
            Return
        End If

        listboxNames.Items.Remove(listboxNames.SelectedItem)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        System.Environment.Exit(0)
    End Sub
End Class
