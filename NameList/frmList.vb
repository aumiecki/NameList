Public Class frmList
    ' Add  button
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim fullname As String

        fullname = tbLast.Text & ", " & tbFirst.Text
        listboxNames.Items.Add(fullname)
    End Sub

    ' Clear button
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tbFirst.Clear()
        tbLast.Clear()
        listboxNames.Items.Clear()

        tbFirst.Focus()
    End Sub

    ' Delete button
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If listboxNames.SelectedIndex < 0 Then
            Return
        End If

        listboxNames.Items.Remove(listboxNames.SelectedItem)
    End Sub

    ' Exit button
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        System.Environment.Exit(0)
    End Sub

    ' Firsn Name Validation
    Private Sub tbFirst_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbFirst.Validating
        If (tbFirst.Text.Length = 0) Then
            e.Cancel = True
            NameError.SetError(tbFirst, "First Name cannot be blank")
        Else
            e.Cancel = False
            NameError.SetError(tbFirst, "")
        End If
    End Sub

    ' Last Name Validation
    Private Sub tbLast_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbLast.Validating
        If (tbLast.Text.Length = 0) Then
            e.Cancel = True
            NameError.SetError(tbLast, "Last Name cannot be blank")
        Else
            e.Cancel = False
            NameError.SetError(tbLast, "")
        End If
    End Sub

    ' Cancel validation on Exit
    Private Sub frmList_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = False
    End Sub
End Class
