Public Class frmBackroundSelector


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DialogResult = 1

        Me.Dispose()

        'Me.Hide()
        'intBackgroundPicSelected = 1

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DialogResult = 2

        Me.Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.DialogResult = 3

        Me.Dispose()
    End Sub
End Class