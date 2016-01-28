﻿Public Class frmConfiguration
    Private Sub frmConfiguration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPLAktion1.Text = My.Settings.setPLAktion1
        txtBackgroundImagePath.Text = My.Settings.setBackgroundImagePath
        txtPLAktion1.Text = My.Settings.setPLAktion1
        txtPLAktion2.Text = My.Settings.setPLAktion2
        txtThumbnailSuffix.Text = My.Settings.setThumbnailImageSuffix
        txtBackgrundImageFileFormat.Text = My.Settings.setBackgroundImageFileFormat
        txtBackground1.Text = My.Settings.setBackground1
        txtBackground2.Text = My.Settings.setBackground2
        txtBackground3.Text = My.Settings.setBackground3
        txtBackground4.Text = My.Settings.setBackground4
        txtBackground5.Text = My.Settings.setBackground5
        txtBackground6.Text = My.Settings.setBackground6
        txtBackground7.Text = My.Settings.setBackground7
        txtBackground8.Text = My.Settings.setBackground8
        txtBackground9.Text = My.Settings.setBackground9
        txtBackground10.Text = My.Settings.setBackground10
        txtBackground11.Text = My.Settings.setBackground11
        txtBackground12.Text = My.Settings.setBackground12
        txtBackground13.Text = My.Settings.setBackground13
        txtBackground14.Text = My.Settings.setBackground14
        txtBackground15.Text = My.Settings.setBackground15
        txtBackground16.Text = My.Settings.setBackground16
        txtBackground17.Text = My.Settings.setBackground17

        txtThumbnail1.Text = My.Settings.setBackgroundThumbnail1
        txtThumbnail2.Text = My.Settings.setBackgroundThumbnail2
        txtThumbnail3.Text = My.Settings.setBackgroundThumbnail3
        txtThumbnail4.Text = My.Settings.setBackgroundThumbnail4
        txtThumbnail5.Text = My.Settings.setBackgroundThumbnail5
        txtThumbnail6.Text = My.Settings.setBackgroundThumbnail6
        txtThumbnail7.Text = My.Settings.setBackgroundThumbnail7
        txtThumbnail8.Text = My.Settings.setBackgroundThumbnail8
        txtThumbnail9.Text = My.Settings.setBackgroundThumbnail9
        txtThumbnail10.Text = My.Settings.setBackgroundThumbnail10
        txtThumbnail11.Text = My.Settings.setBackgroundThumbnail11
        txtThumbnail12.Text = My.Settings.setBackgroundThumbnail12
        txtThumbnail13.Text = My.Settings.setBackgroundThumbnail13
        txtThumbnail14.Text = My.Settings.setBackgroundThumbnail14
        txtThumbnail15.Text = My.Settings.setBackgroundThumbnail15
        txtThumbnail16.Text = My.Settings.setBackgroundThumbnail16
        txtThumbnail17.Text = My.Settings.setBackgroundThumbnail17

        btnBackgroundColorActive1.BackColor = My.Settings.setBackgroundColorActive1
        btnBackgroundColorActive2.BackColor = My.Settings.setBackgroundColorActive2

        chkLoadLastBackgroundOnStart.Checked = My.Settings.setLoadLastBackgroundOnStart


    End Sub

    Private Sub btnBackgroundImageDir_Click(sender As Object, e As EventArgs) Handles btnBackgroundImageDir.Click
        Try
            FolderBrowserDialog1.ShowDialog()

            txtBackgroundImagePath.Text = FolderBrowserDialog1.SelectedPath
        Catch
            MessageBox.Show(Err.Number & " - " & Err.Description, "Es ist ein Fehler aufgetreten!")
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.setPLAktion1 = txtPLAktion1.Text
        My.Settings.setBackgroundImagePath = txtBackgroundImagePath.Text
        My.Settings.setPLAktion1 = txtPLAktion1.Text
        My.Settings.setPLAktion2 = txtPLAktion2.Text
        My.Settings.setThumbnailImageSuffix = txtThumbnailSuffix.Text
        My.Settings.setBackgroundImageFileFormat = txtBackgrundImageFileFormat.Text

        My.Settings.setBackground1 = txtBackground1.Text
        My.Settings.setBackground2 = txtBackground2.Text
        My.Settings.setBackground3 = txtBackground3.Text
        My.Settings.setBackground4 = txtBackground4.Text
        My.Settings.setBackground5 = txtBackground5.Text
        My.Settings.setBackground6 = txtBackground6.Text
        My.Settings.setBackground7 = txtBackground7.Text
        My.Settings.setBackground8 = txtBackground8.Text
        My.Settings.setBackground9 = txtBackground9.Text
        My.Settings.setBackground10 = txtBackground10.Text
        My.Settings.setBackground11 = txtBackground11.Text
        My.Settings.setBackground12 = txtBackground12.Text
        My.Settings.setBackground13 = txtBackground13.Text
        My.Settings.setBackground14 = txtBackground14.Text
        My.Settings.setBackground15 = txtBackground15.Text
        My.Settings.setBackground16 = txtBackground16.Text
        My.Settings.setBackground17 = txtBackground17.Text

        My.Settings.setBackgroundThumbnail1 = txtThumbnail1.Text
        My.Settings.setBackgroundThumbnail2 = txtThumbnail2.Text
        My.Settings.setBackgroundThumbnail3 = txtThumbnail3.Text
        My.Settings.setBackgroundThumbnail4 = txtThumbnail4.Text
        My.Settings.setBackgroundThumbnail5 = txtThumbnail5.Text
        My.Settings.setBackgroundThumbnail6 = txtThumbnail6.Text
        My.Settings.setBackgroundThumbnail7 = txtThumbnail7.Text
        My.Settings.setBackgroundThumbnail8 = txtThumbnail8.Text
        My.Settings.setBackgroundThumbnail9 = txtThumbnail9.Text
        My.Settings.setBackgroundThumbnail10 = txtThumbnail10.Text
        My.Settings.setBackgroundThumbnail11 = txtThumbnail11.Text
        My.Settings.setBackgroundThumbnail12 = txtThumbnail12.Text
        My.Settings.setBackgroundThumbnail13 = txtThumbnail13.Text
        My.Settings.setBackgroundThumbnail14 = txtThumbnail14.Text
        My.Settings.setBackgroundThumbnail15 = txtThumbnail15.Text
        My.Settings.setBackgroundThumbnail16 = txtThumbnail16.Text
        My.Settings.setBackgroundThumbnail17 = txtThumbnail17.Text

        My.Settings.setBackgroundColorActive1 = btnBackgroundColorActive1.BackColor
        My.Settings.setBackgroundColorActive2 = btnBackgroundColorActive2.BackColor

        My.Settings.setLoadLastBackgroundOnStart = chkLoadLastBackgroundOnStart.Checked

        My.Settings.Save()
        Me.Dispose()
    End Sub

    Private Sub btnBackgroundColorActive1_Click(sender As Object, e As EventArgs) Handles btnBackgroundColorActive1.Click
        Try
            Dim MyDialog As New ColorDialog()

            ' Update the text box color if the user clicks OK 
            If (MyDialog.ShowDialog() = DialogResult.OK) Then
                btnBackgroundColorActive1.BackColor = MyDialog.Color
            End If
        Catch ex As Exception

        End Try



    End Sub

    Private Sub btnBackgroundColorActive2_Click(sender As Object, e As EventArgs) Handles btnBackgroundColorActive2.Click
        Try
            Dim MyDialog As New ColorDialog()

            ' Update the text box color if the user clicks OK 
            If (MyDialog.ShowDialog() = DialogResult.OK) Then
                btnBackgroundColorActive2.BackColor = MyDialog.Color
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class