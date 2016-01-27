Public Class frmConfiguration
    Private Sub frmConfiguration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPLAktion1.Text = My.Settings.setPLAktion1
        txtBackgroundImagePath.Text = My.Settings.setBackgroundImagePath
        txtPLAktion1.Text = My.Settings.setPLAktion1
        txtPLAktion2.Text = My.Settings.setPLAktion2
        txtThumbnailSuffix.Text = My.Settings.setThumbnailImageSuffix

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
        txtBackground18.Text = My.Settings.setBackground18
        txtBackground19.Text = My.Settings.setBackground19
        txtBackground20.Text = My.Settings.setBackground20


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
        My.Settings.setBackground18 = txtBackground18.Text
        My.Settings.setBackground19 = txtBackground19.Text
        My.Settings.setBackground20 = txtBackground20.Text

        My.Settings.Save()
        Me.Dispose()
    End Sub
End Class