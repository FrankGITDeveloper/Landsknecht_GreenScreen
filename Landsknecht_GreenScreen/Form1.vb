Public Class frmMain
    Public bolChanges As Boolean    'Änderungen am Ende speichern


    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtScanPath1.Text = My.Settings.setScanPath1
            chkScanSubDir1.Checked = My.Settings.setSubFolders1
            txtScanPath2.Text = My.Settings.setScanPath2

            chkScanSubDir2.Checked = My.Settings.setSubFolders2


            txtApplication1.Text = My.Settings.setApplication1
            txtApplication1Filter.Text = My.Settings.setApplication1Filter
            txtApplication1Arguments.Text = My.Settings.setApplication1Argument
            txtApplication2.Text = My.Settings.setApplication2
            txtApplication2Filter.Text = My.Settings.setApplication2Filter
            txtApplication2Arguments.Text = My.Settings.setApplication2Argument
            Me.Location = New Point(My.Settings.setPositionX, My.Settings.setPositionY)

            bolChanges = False


        Catch

            MessageBox.Show(Err.Number & " - " & Err.Description, "Es Ist Ein Fehler Aufgetreten!")
        End Try

    End Sub



    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click

        Try
            Dim answer As MsgBoxResult
            answer = MsgBox("Programm beenden?", MsgBoxStyle.YesNo)
            If answer = MsgBoxResult.Yes Then
                Try
                    If bolChanges = True Then
                        Dim speichern As Integer = MsgBox("Sollen die Änderungen als Vorgabe gespeichert werden", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Einstellungen übernehmen?")

                        If speichern = vbYes Then
                            My.Settings.setScanPath1 = txtScanPath1.Text
                            My.Settings.setSubFolders1 = chkScanSubDir1.Checked
                            My.Settings.setScanPath2 = txtScanPath2.Text
                            My.Settings.setSubFolders2 = chkScanSubDir2.Checked
                            My.Settings.setApplication1 = txtApplication1.Text
                            My.Settings.setApplication1Filter = txtApplication1Filter.Text
                            My.Settings.setApplication1Argument = txtApplication1Arguments.Text
                            My.Settings.setApplication2 = txtApplication2.Text
                            My.Settings.setApplication2Filter = txtApplication2Filter.Text
                            My.Settings.setApplication2Argument = txtApplication2Arguments.Text
                            My.Settings.setPositionX = Me.Location.X
                            My.Settings.setPositionY = Me.Location.Y
                            My.Settings.Save()

                        End If
                    End If
                    Try
                        'Überwachung stoppen
                        FileSystemWatcher1.EnableRaisingEvents = False
                        FileSystemWatcher2.EnableRaisingEvents = False
                        Me.Close()
                        End

                    Catch ex As Exception
                        MsgBox("fehler")
                    End Try


                Catch ex As Exception
                    MessageBox.Show(Err.Number & " - " & Err.Description, "Es Ist Ein Fehler Aufgetreten!")
                End Try
            End If

        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        'Start Event 1
        Try
            If txtApplication1Filter.TextLength > 0 And txtScanPath1.TextLength > 0 Then
                FileSystemWatcher1.Filter = txtApplication1Filter.Text
                FileSystemWatcher1.Path = txtScanPath1.Text
                FileSystemWatcher1.IncludeSubdirectories = chkScanSubDir1.Checked
                Me.BackColor = My.Settings.setBackgroundColorActive1

                FileSystemWatcher1.EnableRaisingEvents = True
            Else
                MsgBox("Bitte Felder Event 1 auf Vollständigkeit überprüfen", MsgBoxStyle.Information, "Fehler")

            End If
            Timer1.Enabled = False   'Blinken ausschalten (Nur 1 Folder wird gescannt)


            btnStop.Enabled = True

        Catch ex As Exception
            MessageBox.Show(Err.Number & " - " & Err.Description, "Es Ist Ein Fehler Aufgetreten!")
        End Try


        'Start Event 1
        Try
            If txtApplication2Filter.TextLength > 0 And txtScanPath2.TextLength > 0 Then
                FileSystemWatcher2.Filter = txtApplication2Filter.Text
                FileSystemWatcher2.Path = txtScanPath2.Text
                FileSystemWatcher2.IncludeSubdirectories = chkScanSubDir2.Checked
                Me.BackColor = My.Settings.setBackgroundColorActive2


                FileSystemWatcher2.EnableRaisingEvents = True

                Timer1.Enabled = True    'Blinken einschalten (2 Folder werden gescannt)

            Else
                MsgBox("Bitte Felder Event 2 auf Vollständigkeit überprüfen", MsgBoxStyle.Information, "Fehler")

            End If

            btnStop.Enabled = True

        Catch ex As Exception
            MessageBox.Show(Err.Number & " - " & Err.Description, "Es Ist Ein Fehler Aufgetreten!")
        End Try

    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        Try
            Me.BackColor = My.Settings.setBackgroundColorInactive
            FileSystemWatcher1.EnableRaisingEvents = False
            FileSystemWatcher2.EnableRaisingEvents = False
            Timer1.Enabled = False

        Catch ex As Exception

        End Try
    End Sub

    Private Sub FileSystemWatcher1_Created(ByVal sender As System.Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Created
        Try

            'MsgBox("File: " & e.FullPath & " " & e.ChangeType)
            'MsgBox(txtApplication1.Text)

            Process.Start(txtApplication1.Text, e.FullPath.ToString)

        Catch
            MessageBox.Show(Err.Number & " - " & Err.Description, "Es ist ein Fehler aufgetreten!")
        End Try
    End Sub



    Private Sub btnScanPath1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScanPath1.Click
        Try
            FolderBrowserDialog1.ShowDialog()

            txtScanPath1.Text = FolderBrowserDialog1.SelectedPath
        Catch
            MessageBox.Show(Err.Number & " - " & Err.Description, "Es ist ein Fehler aufgetreten!")
        End Try
    End Sub


    Private Sub btnScanPath2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScanPath2.Click
        Try
            FolderBrowserDialog1.ShowDialog()

            txtScanPath2.Text = FolderBrowserDialog1.SelectedPath
        Catch
            MessageBox.Show(Err.Number & " - " & Err.Description, "Es ist ein Fehler aufgetreten!")
        End Try
    End Sub



    Private Sub btnApplication2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApplication2.Click

        '  Dim myStream As Stream = Nothing
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = "C:\Program Files"
        openFileDialog1.Filter = "Programme (*.exe)|*.exe|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                txtApplication2.Text = openFileDialog1.FileName

                'If (myStream IsNot Nothing) Then
                '    ' Insert code to read the stream here.
                'End If
            Catch Ex As Exception
                MessageBox.Show(Err.Number & " - " & Err.Description, "Es Ist Ein Fehler Aufgetreten!")
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                '' Check this again, since we need to make sure we didn't throw an exception on open.
                'If (myStream IsNot Nothing) Then
                '    myStream.Close()
                'End If
            End Try
        End If
    End Sub


    Private Sub btnApplication1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApplication1.Click

        '  Dim myStream As Stream = Nothing
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = "C:\Program Files"
        openFileDialog1.Filter = "Programme (*.exe)|*.exe|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                txtApplication1.Text = openFileDialog1.FileName

                'If (myStream IsNot Nothing) Then
                '    ' Insert code to read the stream here.
                'End If
            Catch Ex As Exception
                MessageBox.Show(Err.Number & " - " & Err.Description, "Es Ist Ein Fehler Aufgetreten!")
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                '' Check this again, since we need to make sure we didn't throw an exception on open.
                'If (myStream IsNot Nothing) Then
                '    myStream.Close()
                'End If
            End Try
        End If
    End Sub


    Private Sub chkScanSubDir1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkScanSubDir1.CheckedChanged
        bolChanges = True
    End Sub

    Private Sub txtScanPath1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtScanPath1.TextChanged

        bolChanges = True
    End Sub

    Private Sub txtApplication1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtApplication1.TextChanged
        bolChanges = True
    End Sub

    Private Sub txtApplication1Filter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtApplication1Filter.TextChanged
        bolChanges = True
    End Sub

    Private Sub txtApplication1Arguments_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtApplication1Arguments.TextChanged
        bolChanges = True
    End Sub

    Private Sub chkScanSubDir2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkScanSubDir2.CheckedChanged
        bolChanges = True
    End Sub

    Private Sub txtScanPath2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtScanPath2.TextChanged
        bolChanges = True
    End Sub



    Private Sub txtApplication2Filter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtApplication2Filter.TextChanged
        bolChanges = True
    End Sub

    Private Sub txtApplication2Arguments_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtApplication2Arguments.TextChanged
        bolChanges = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If Me.BackColor = My.Settings.setBackgroundColorActive1 Then
                Me.BackColor = My.Settings.setBackgroundColorActive2
            Else
                Me.BackColor = My.Settings.setBackgroundColorActive1

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub FileSystemWatcher2_Created(sender As Object, e As IO.FileSystemEventArgs) Handles FileSystemWatcher2.Created
        Try

            '    MsgBox("File: " & e.FullPath & " " & e.ChangeType)
            '    MsgBox(txtApplication2.Text)

            Process.Start(txtApplication2.Text, e.FullPath.ToString)

        Catch
            MessageBox.Show(Err.Number & " - " & Err.Description, "Es ist ein Fehler aufgetreten!")
        End Try
    End Sub

    Private Sub txtApplication2_TextChanged(sender As Object, e As EventArgs) Handles txtApplication2.TextChanged
        bolChanges = True
    End Sub
End Class
