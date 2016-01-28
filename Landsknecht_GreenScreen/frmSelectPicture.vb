Imports System.Windows.Forms

Public Class frmSelectPicture
    Public Property Hintergrundbild As String
    Public Property HintergrundThumbnail As String


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnHintergrundbild_Click(sender As Object, e As EventArgs) Handles btnHintergrundbild.Click
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = My.Settings.setBackgroundImagePath   ' '"C:\Program Files"
        openFileDialog1.Filter = "Bilder (*.JPG)|*.jpg|All files (*.*)|*.*|Photoline (*.PLD)|*.PLD"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                txtHintergrundbild.Text = openFileDialog1.FileName
                Hintergrundbild = openFileDialog1.FileName

            Catch Ex As Exception
                MessageBox.Show(Err.Number & " - " & Err.Description, "Es Ist Ein Fehler Aufgetreten! btnHintergrundbild_Click")

            Finally

            End Try
        End If
    End Sub

    Private Sub btnHintergrundThumbnail_Click(sender As Object, e As EventArgs) Handles btnHintergrundThumbnail.Click
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = My.Settings.setBackgroundImagePath   ' '"C:\Program Files"
        openFileDialog1.Filter = "Bilder (*.JPG)|*.jpg|All files (*.*)|*.*|Photoline (*.PLD)|*.PLD"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                txtHintergrundThumbnail.Text = openFileDialog1.FileName
                HintergrundThumbnail = openFileDialog1.FileName

            Catch Ex As Exception
                MessageBox.Show(Err.Number & " - " & Err.Description, "Es Ist Ein Fehler Aufgetreten! btnHintergrundbild_Click")

            Finally

            End Try
        End If
    End Sub
End Class
