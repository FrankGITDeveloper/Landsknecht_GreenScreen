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
        Dim Filterstring As String
        Filterstring = "Vorgabe (" & My.Settings.setBackgroundImageFileFormat & ")|*." & (My.Settings.setBackgroundImageFileFormat.ToUpper) & "|Photoline (*.PLD)|*.PLD|Photoshop (*.PSD)|*.PSD|Alle Dateien (*.*)|*.*"

        openFileDialog1.InitialDirectory = My.Settings.setBackgroundImagePath   ' '"C:\Program Files"
        openFileDialog1.Filter = Filterstring
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                txtHintergrundbild.Text = openFileDialog1.FileName
                Hintergrundbild = openFileDialog1.FileName

                '       picPicture.ImageLocation = openFileDialog1.FileName
                picPicture.Image = Image.FromFile(openFileDialog1.FileName)


                Create_Thumbnail()


            Catch Ex As Exception
                MessageBox.Show(Err.Number & " - " & Err.Description, "Es Ist Ein Fehler Aufgetreten! btnHintergrundbild_Click")

            Finally

            End Try
        End If
    End Sub

    Private Sub Create_Thumbnail()
        Dim imgThumb As Image = Nothing


        Try
            Dim image As Image = Nothing
            'Hoch oder querformat
            If picPicture.Image.Size.Width > picPicture.Image.Size.Height Then
                imgThumb = picPicture.Image.GetThumbnailImage(200, 141, Nothing, New IntPtr())
            Else
                imgThumb = picPicture.Image.GetThumbnailImage(141, 200, Nothing, New IntPtr())
            End If

            ' Check if image exists
            '  If Not image Is Nothing Then

            Me.Refresh()
            '         End If
            picThumbnail.Image = imgThumb


            '      Button1.Image = imgThumb
            picThumbnail.Image.Save(Trim(txtHintergrundbild.Text) & My.Settings.setThumbnailImageSuffix, System.Drawing.Imaging.ImageFormat.Jpeg)

            txtHintergrundThumbnail.Text = Trim(txtHintergrundbild.Text) & My.Settings.setThumbnailImageSuffix
            HintergrundThumbnail = txtHintergrundThumbnail.Text
        Catch
            MessageBox.Show(Err.Number & " - " & Err.Description, "Es Ist Ein Fehler Aufgetreten! btnHintergrundbild_Click")
        End Try
    End Sub
    Private Sub btnHintergrundThumbnail_Click(sender As Object, e As EventArgs) Handles btnHintergrundThumbnail.Click
        Dim openFileDialog1 As New OpenFileDialog()

        Dim Filterstring As String
        Filterstring = "Vorgabe (" & My.Settings.setBackgroundImageFileFormat & ")|*." & (My.Settings.setBackgroundImageFileFormat.ToUpper) & "|Photoline (*.PLD)|*.PLD|Photoshop (*.PSD)|*.PSD|Alle Dateien (*.*)|*.*"

        openFileDialog1.InitialDirectory = My.Settings.setBackgroundImagePath   ' '"C:\Program Files"
        openFileDialog1.Filter = Filterstring
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
