Public Class frmBackroundSelector

    Public intImageSelected As Integer
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


    '    Me.DialogResult = vbOK
    '    intImageSelected = 1
    '    Me.Dispose()


    'End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    Me.DialogResult = vbOK
    '    intImageSelected = 2
    '    Me.Dispose()
    'End Sub

    'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    '    Me.DialogResult = vbOK
    '    intImageSelected = 3
    '    Me.Dispose()
    'End Sub


    Private Sub frmBackroundSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        Dim Filename As String = ""

        'Filename = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground1 & My.Settings.setThumbnailImageSuffix
        'Button1.Image = Image.FromFile(Filename)
        '' Align the image and text on the button.

        ''Button 2
        'Filename = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground2 & My.Settings.setThumbnailImageSuffix
        'Button2.Image = Image.FromFile(Filename)

        ''Button 3
        'Filename = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground3 & My.Settings.setThumbnailImageSuffix
        'Button3.Image = Image.FromFile(Filename)

        ''Button 4
        'Filename = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground4 & My.Settings.setThumbnailImageSuffix
        'Button4.Image = Image.FromFile(Filename)
        ''Button 5
        'Filename = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground5 & My.Settings.setThumbnailImageSuffix
        'Button5.Image = Image.FromFile(Filename)
        ''Button 6
        'Filename = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground6 & My.Settings.setThumbnailImageSuffix
        'Button6.Image = Image.FromFile(Filename)
        ''Button 7
        'Filename = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground7 & My.Settings.setThumbnailImageSuffix
        'Button7.Image = Image.FromFile(Filename)
        ''Button 2
        'Filename = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground8 & My.Settings.setThumbnailImageSuffix
        'Button8.Image = Image.FromFile(Filename)
        ''Button 2
        'Filename = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground9 & My.Settings.setThumbnailImageSuffix
        'Button9.Image = Image.FromFile(Filename)
        ''Button 2
        'Filename = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground10 & My.Settings.setThumbnailImageSuffix
        'Button10.Image = Image.FromFile(Filename)

        ''Button 
        'Filename = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground11 & My.Settings.setThumbnailImageSuffix
        'Button11.Image = Image.FromFile(Filename)

        ''Button 
        'Filename = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground12 & My.Settings.setThumbnailImageSuffix
        'Button12.Image = Image.FromFile(Filename)

        ''Button 
        'Filename = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground13 & My.Settings.setThumbnailImageSuffix
        'Button13.Image = Image.FromFile(Filename)

        ''Button 
        'Filename = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground14 & My.Settings.setThumbnailImageSuffix
        'Button14.Image = Image.FromFile(Filename)

        ''Button 
        'Filename = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground15 & My.Settings.setThumbnailImageSuffix
        'Button15.Image = Image.FromFile(Filename)

        ''Button 
        'Filename = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground16 & My.Settings.setThumbnailImageSuffix
        'Button16.Image = Image.FromFile(Filename)

        ''Button 
        'Filename = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground17 & My.Settings.setThumbnailImageSuffix
        'Button17.Image = Image.FromFile(Filename)


        Button1.Image = Image.FromFile(My.Settings.setBackgrundThumbnail1)
        Button2.Image = Image.FromFile(My.Settings.setBackgrundThumbnail2)
        Button3.Image = Image.FromFile(My.Settings.setBackgrundThumbnail3)
        Button4.Image = Image.FromFile(My.Settings.setBackgrundThumbnail4)
        Button5.Image = Image.FromFile(My.Settings.setBackgrundThumbnail5)
        Button6.Image = Image.FromFile(My.Settings.setBackgrundThumbnail6)
        Button7.Image = Image.FromFile(My.Settings.setBackgrundThumbnail7)
        Button8.Image = Image.FromFile(My.Settings.setBackgrundThumbnail8)
        Button9.Image = Image.FromFile(My.Settings.setBackgrundThumbnail9)
        Button10.Image = Image.FromFile(My.Settings.setBackgrundThumbnail10)
        Button11.Image = Image.FromFile(My.Settings.setBackgrundThumbnail11)
        Button12.Image = Image.FromFile(My.Settings.setBackgrundThumbnail12)
        Button13.Image = Image.FromFile(My.Settings.setBackgrundThumbnail13)
        Button14.Image = Image.FromFile(My.Settings.setBackgrundThumbnail14)
        Button15.Image = Image.FromFile(My.Settings.setBackgrundThumbnail15)
        Button16.Image = Image.FromFile(My.Settings.setBackgrundThumbnail16)
        Button17.Image = Image.FromFile(My.Settings.setBackgrundThumbnail17)



    End Sub

    'Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
    '    Me.DialogResult = vbOK
    '    intImageSelected = 11
    '    Me.Dispose()

    'End Sub

    'Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    '    Me.DialogResult = vbOK
    '    intImageSelected = 4
    '    Me.Dispose()

    'End Sub

    'Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
    '    Me.DialogResult = vbOK
    '    intImageSelected = 5
    '    Me.Dispose()

    'End Sub

    'Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
    '    Me.DialogResult = vbOK
    '    intImageSelected = 6
    '    Me.Dispose()
    'End Sub

    'Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
    '    Me.DialogResult = vbOK
    '    intImageSelected = 7
    '    Me.Dispose()

    'End Sub

    'Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
    '    Me.DialogResult = vbOK
    '    intImageSelected = 8
    '    Me.Dispose()
    'End Sub

    'Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
    '    Me.DialogResult = vbOK
    '    intImageSelected = 9
    '    Me.Dispose()
    'End Sub

    'Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
    '    Me.DialogResult = vbOK
    '    intImageSelected = 10
    '    Me.Dispose()

    'End Sub

    'Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
    '    Me.DialogResult = vbOK
    '    intImageSelected = 12
    '    Me.Dispose()
    'End Sub

    'Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
    '    Me.DialogResult = vbOK
    '    intImageSelected = 13
    '    Me.Dispose()
    'End Sub

    'Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
    '    Me.DialogResult = vbOK
    '    intImageSelected = 14
    '    Me.Dispose()
    'End Sub

    'Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
    '    Me.DialogResult = vbOK
    '    intImageSelected = 15
    '    Me.Dispose()
    'End Sub

    'Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
    '    Me.DialogResult = vbOK
    '    intImageSelected = 16
    '    Me.Dispose()
    'End Sub

    'Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
    '    Me.DialogResult = vbOK
    '    intImageSelected = 17
    '    Me.Dispose()
    'End Sub


    Private Sub frmBackroundSelector_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Try
            Select Case intImageSelected
                Case 1
                    'My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground1 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    'My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground1 & My.Settings.setThumbnailImageSuffix  ' Define source file name.
                    My.Settings.setTempBackgroundImage = My.Settings.setBackground1
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgrundThumbnail1
                Case 2
                    'My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground2 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    'My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground2 & My.Settings.setThumbnailImageSuffix  ' Define source file name.
                    My.Settings.setTempBackgroundImage = My.Settings.setBackground2
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgrundThumbnail2
                Case 3
                    'My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground3 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    'My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground3 & My.Settings.setThumbnailImageSuffix  ' Define source file name.
                    My.Settings.setTempBackgroundImage = My.Settings.setBackground3
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgrundThumbnail3
                Case 4
                    'My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground4 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    'My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground4 & My.Settings.setThumbnailImageSuffix  ' Define source file name.
                    My.Settings.setTempBackgroundImage = My.Settings.setBackground4
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgrundThumbnail4
                Case 5
                    'My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground5 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    'My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground5 & My.Settings.setThumbnailImageSuffix  ' Define source file name.
                    My.Settings.setTempBackgroundImage = My.Settings.setBackground5
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgrundThumbnail5
                Case 6
                    'My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground6 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    'My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground6 & My.Settings.setThumbnailImageSuffix  ' Define source file name.
                    My.Settings.setTempBackgroundImage = My.Settings.setBackground6
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgrundThumbnail6
                Case 7
                    'My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground7 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    'My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground7 & My.Settings.setThumbnailImageSuffix  ' Define source file name.
                    My.Settings.setTempBackgroundImage = My.Settings.setBackground7
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgrundThumbnail7
                Case 8
                    'My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground8 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    'My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground8 & My.Settings.setThumbnailImageSuffix  ' Define source file name.
                    My.Settings.setTempBackgroundImage = My.Settings.setBackground8
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgrundThumbnail8
                Case 9
                    'My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground9 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    'My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & " \" & My.Settings.setBackground9 & My.Settings.setThumbnailImageSuffix  ' Define source file name.

                    My.Settings.setTempBackgroundImage = My.Settings.setBackground9
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgrundThumbnail9
                Case 10
                    'My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground10 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    'My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground10 & My.Settings.setThumbnailImageSuffix  ' Define source file name.
                    My.Settings.setTempBackgroundImage = My.Settings.setBackground10
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgrundThumbnail10
                Case 11
                    'My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground11 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    'My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground11 & My.Settings.setThumbnailImageSuffix  ' Define source file name.
                    My.Settings.setTempBackgroundImage = My.Settings.setBackground11
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgrundThumbnail11
                Case 12
                    'My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground12 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    'My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground12 & My.Settings.setThumbnailImageSuffix  ' Define source file name.
                    My.Settings.setTempBackgroundImage = My.Settings.setBackground12
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgrundThumbnail12
                Case 13
                    'My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground13 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    'My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground13 & My.Settings.setThumbnailImageSuffix  ' Define source file name.
                    My.Settings.setTempBackgroundImage = My.Settings.setBackground13
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgrundThumbnail13
                Case 14
                    'My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground14 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    'My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground14 & My.Settings.setThumbnailImageSuffix  ' Define source file name.
                    My.Settings.setTempBackgroundImage = My.Settings.setBackground14
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgrundThumbnail14
                Case 15
                    'My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground15 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    'My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground15 & My.Settings.setThumbnailImageSuffix  ' Define source file name.
                    My.Settings.setTempBackgroundImage = My.Settings.setBackground15
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgrundThumbnail15
                Case 16
                    My.Settings.setTempBackgroundImage = My.Settings.setBackground16
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgrundThumbnail16
                    'My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground16 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    'My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground16 & My.Settings.setThumbnailImageSuffix  ' Define source file name.
                Case 17
                    'My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground17 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    'My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground17 & My.Settings.setThumbnailImageSuffix  ' Define source file name.
                    My.Settings.setTempBackgroundImage = My.Settings.setBackground17
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgrundThumbnail7
                Case Else

            End Select


        Catch ex As Exception

        End Try

        frmMain.picPreview.Image = Image.FromFile(My.Settings.setTempBackgroundImagePreview)

        Me.Dispose()

        'Dim Ergebnis As Integer = Me.DialogResult
        'MsgBox("Disposed", 0, Ergebnis.ToString)

        'Select Case ImageSelected
        'Try
        '    My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground1 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
        '    Me.DialogResult = vbOK

        '    frmMain.btnPreview.Image = Image.FromFile(My.Settings.setTempBackgroundImage)

        '    Me.Dispose()
        'Catch ex As Exception
        '    MessageBox.Show(Err.Number & " - " & Err.Description, "Es ist ein Fehler aufgetreten!")
        '    Me.DialogResult = vbQuestion
        'End Try



        'Try

        '  My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Beep)
        '  frmBackroundSelector.Visible = False
        '  ' ShowDialog(frmBackroundSelector)
        '  Dim x As Integer = frmBackroundSelector.ShowDialog()

        '  Dim SourceFile As String = ""
        '  Dim DestinationFile As String = ""
        '  'Background1q.jpg
        '  'Msgbox in echtem Programm muss der Pfad in eine Configdatei


        '  Select Case x
        '      Case 1
        '          SourceFile = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground1 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
        '      Case 2
        '          SourceFile = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground2 & My.Settings.setBackgroundImageFileFormat' Define source file name.
        '      Case 3
        '          SourceFile = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground3 & My.Settings.setBackgroundImageFileFormat' Define source file name.
        '      Case 4
        '          SourceFile = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground4 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
        '      Case 5
        '          SourceFile = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground5 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
        '      Case 6
        '          SourceFile = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground6 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
        '      Case 7
        '          SourceFile = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground7 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
        '      Case 8
        '          SourceFile = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground8 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
        '      Case 9
        '          SourceFile = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground9 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
        '      Case 10
        '          SourceFile = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground10 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
        '      Case 11
        '          SourceFile = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground11 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
        '      Case 12
        '          SourceFile = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground12 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
        '      Case 13
        '          SourceFile = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground13 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
        '      Case 14
        '          SourceFile = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground14 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
        '      Case 15
        '          SourceFile = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground15 & My.Settings.setBackgroundImageFileFormat' Define source file name.
        '      Case 16
        '          SourceFile = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground16 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
        '      Case 17
        '          SourceFile = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground17 & My.Settings.setBackgroundImageFileFormat  ' Define source file name.
        '      Case Else

        '  End Select

        '  MsgBox(SourceFile)

    End Sub



    Private Sub SelectImageAndStore(Button As Integer)


        'Dim openFileDialog1 As New OpenFileDialog()

        'openFileDialog1.InitialDirectory = '"C:\Program Files"
        'openFileDialog1.Filter = "Bilder (*.JPG)|*.jpg|All files (*.*)|*.*|Photoline (*.PLD)|*.PLD"
        'openFileDialog1.FilterIndex = 1
        'openFileDialog1.RestoreDirectory = True

        'If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        '    Try
        '        If openFileDialog1.FileName <> "" Then

        '        End If
        '        ' txtBackground1.Text = openFileDialog1.FileName

        '        'If (myStream IsNot Nothing) Then
        '        '    ' Insert code to read the stream here.
        '        'End If
        '    Catch Ex As Exception
        '        MessageBox.Show(Err.Number & " - " & Err.Description, "Es Ist Ein Fehler Aufgetreten! btnApplication1_Click")
        '        '     MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
        '    Finally
        '        '' Check this again, since we need to make sure we didn't throw an exception on open.
        '        'If (myStream IsNot Nothing) Then
        '        '    myStream.Close()
        '        'End If
        '    End Try
        'End If
        Dim x As New frmSelectPicture
        x.Hintergrundbild = ""
        x.HintergrundThumbnail = ""

        x.ShowDialog()

        '      MsgBox(x.Hintergrundbild, 0, x.HintergrundThumbnail)

        Select Case Button
            Case 1
                My.Settings.setBackground1 = x.Hintergrundbild
                My.Settings.setBackgrundThumbnail1 = x.HintergrundThumbnail
            Case 2
                My.Settings.setBackground2 = x.Hintergrundbild
                My.Settings.setBackgrundThumbnail2 = x.HintergrundThumbnail
            Case 3
                My.Settings.setBackground3 = x.Hintergrundbild
                My.Settings.setBackgrundThumbnail3 = x.HintergrundThumbnail
            Case 4
                My.Settings.setBackground4 = x.Hintergrundbild
                My.Settings.setBackgrundThumbnail4 = x.HintergrundThumbnail
            Case 5
                My.Settings.setBackground5 = x.Hintergrundbild
                My.Settings.setBackgrundThumbnail5 = x.HintergrundThumbnail
            Case 6
                My.Settings.setBackground6 = x.Hintergrundbild
                My.Settings.setBackgrundThumbnail6 = x.HintergrundThumbnail
            Case 7
                My.Settings.setBackground7 = x.Hintergrundbild
                My.Settings.setBackgrundThumbnail7 = x.HintergrundThumbnail
            Case 8
                My.Settings.setBackground8 = x.Hintergrundbild
                My.Settings.setBackgrundThumbnail8 = x.HintergrundThumbnail
            Case 9
                My.Settings.setBackground9 = x.Hintergrundbild
                My.Settings.setBackgrundThumbnail9 = x.HintergrundThumbnail
            Case 10
                My.Settings.setBackground10 = x.Hintergrundbild
                My.Settings.setBackgrundThumbnail10 = x.HintergrundThumbnail
            Case 11
                My.Settings.setBackground11 = x.Hintergrundbild
                My.Settings.setBackgrundThumbnail11 = x.HintergrundThumbnail
            Case 12
                My.Settings.setBackground12 = x.Hintergrundbild
                My.Settings.setBackgrundThumbnail12 = x.HintergrundThumbnail
            Case 13
                My.Settings.setBackground13 = x.Hintergrundbild
                My.Settings.setBackgrundThumbnail13 = x.HintergrundThumbnail
            Case 14
                My.Settings.setBackground14 = x.Hintergrundbild
                My.Settings.setBackgrundThumbnail14 = x.HintergrundThumbnail
            Case 15
                My.Settings.setBackground15 = x.Hintergrundbild
                My.Settings.setBackgrundThumbnail15 = x.HintergrundThumbnail
            Case 16
                My.Settings.setBackground16 = x.Hintergrundbild
                My.Settings.setBackgrundThumbnail16 = x.HintergrundThumbnail
            Case 17
                My.Settings.setBackground17 = x.Hintergrundbild
                My.Settings.setBackgrundThumbnail17 = x.HintergrundThumbnail
        End Select

        My.Settings.Save()


    End Sub
    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown


        Try
            Select Case e.Button
                Case MouseButtons.Right
                    SelectImageAndStore(1)

                    Button1.Image = Image.FromFile(My.Settings.setBackgrundThumbnail1)
                Case MouseButtons.Left
                    Me.DialogResult = vbOK
                    intImageSelected = 1
                    Me.Dispose()

            End Select
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_MouseDown(sender As Object, e As MouseEventArgs) Handles Button2.MouseDown

        Try
            Select Case e.Button
                Case MouseButtons.Right
                    SelectImageAndStore(2)

                    Button2.Image = Image.FromFile(My.Settings.setBackgrundThumbnail2)
                Case MouseButtons.Left
                    Me.DialogResult = vbOK
                    intImageSelected = 2
                    Me.Dispose()

            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_MouseDown(sender As Object, e As MouseEventArgs) Handles Button3.MouseDown
        Try
            Select Case e.Button
                Case MouseButtons.Right
                    SelectImageAndStore(3)

                    Button3.Image = Image.FromFile(My.Settings.setBackgrundThumbnail3)
                Case MouseButtons.Left
                    Me.DialogResult = vbOK
                    intImageSelected = 3
                    Me.Dispose()

            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_MouseDown(sender As Object, e As MouseEventArgs) Handles Button4.MouseDown
        Try
            Select Case e.Button
                Case MouseButtons.Right
                    SelectImageAndStore(4)

                    Button4.Image = Image.FromFile(My.Settings.setBackgrundThumbnail4)
                Case MouseButtons.Left
                    Me.DialogResult = vbOK
                    intImageSelected = 4
                    Me.Dispose()

            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button5_MouseDown(sender As Object, e As MouseEventArgs) Handles Button5.MouseDown
        Try
            Select Case e.Button
                Case MouseButtons.Right
                    SelectImageAndStore(5)

                    Button5.Image = Image.FromFile(My.Settings.setBackgrundThumbnail5)
                Case MouseButtons.Left
                    Me.DialogResult = vbOK
                    intImageSelected = 5
                    Me.Dispose()

            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button6_MouseDown(sender As Object, e As MouseEventArgs) Handles Button6.MouseDown
        Try
            Select Case e.Button
                Case MouseButtons.Right
                    SelectImageAndStore(6)

                    Button6.Image = Image.FromFile(My.Settings.setBackgrundThumbnail6)
                Case MouseButtons.Left
                    Me.DialogResult = vbOK
                    intImageSelected = 6
                    Me.Dispose()

            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button7_MouseDown(sender As Object, e As MouseEventArgs) Handles Button7.MouseDown
        Try
            Select Case e.Button
                Case MouseButtons.Right
                    SelectImageAndStore(7)

                    Button7.Image = Image.FromFile(My.Settings.setBackgrundThumbnail7)
                Case MouseButtons.Left
                    Me.DialogResult = vbOK
                    intImageSelected = 7
                    Me.Dispose()

            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button8_MouseDown(sender As Object, e As MouseEventArgs) Handles Button8.MouseDown
        Try
            Select Case e.Button
                Case MouseButtons.Right
                    SelectImageAndStore(8)

                    Button8.Image = Image.FromFile(My.Settings.setBackgrundThumbnail8)
                Case MouseButtons.Left
                    Me.DialogResult = vbOK
                    intImageSelected = 8
                    Me.Dispose()

            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button9_MouseDown(sender As Object, e As MouseEventArgs) Handles Button9.MouseDown
        Try
            Select Case e.Button
                Case MouseButtons.Right
                    SelectImageAndStore(9)

                    Button9.Image = Image.FromFile(My.Settings.setBackgrundThumbnail9)
                Case MouseButtons.Left
                    Me.DialogResult = vbOK
                    intImageSelected = 9
                    Me.Dispose()

            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button10_MouseDown(sender As Object, e As MouseEventArgs) Handles Button10.MouseDown
        Try
            Select Case e.Button
                Case MouseButtons.Right
                    SelectImageAndStore(10)

                    Button10.Image = Image.FromFile(My.Settings.setBackgrundThumbnail10)
                Case MouseButtons.Left
                    Me.DialogResult = vbOK
                    intImageSelected = 10
                    Me.Dispose()

            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button11_MouseDown(sender As Object, e As MouseEventArgs) Handles Button11.MouseDown
        Try
            Select Case e.Button
                Case MouseButtons.Right
                    SelectImageAndStore(11)

                    Button11.Image = Image.FromFile(My.Settings.setBackgrundThumbnail11)
                Case MouseButtons.Left
                    Me.DialogResult = vbOK
                    intImageSelected = 11
                    Me.Dispose()

            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button12_MouseDown(sender As Object, e As MouseEventArgs) Handles Button12.MouseDown
        Try
            Select Case e.Button
                Case MouseButtons.Right
                    SelectImageAndStore(12)

                    Button12.Image = Image.FromFile(My.Settings.setBackgrundThumbnail12)
                Case MouseButtons.Left
                    Me.DialogResult = vbOK
                    intImageSelected = 12
                    Me.Dispose()

            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button13_MouseDown(sender As Object, e As MouseEventArgs) Handles Button13.MouseDown
        Try
            Select Case e.Button
                Case MouseButtons.Right
                    SelectImageAndStore(13)

                    Button13.Image = Image.FromFile(My.Settings.setBackgrundThumbnail13)
                Case MouseButtons.Left
                    Me.DialogResult = vbOK
                    intImageSelected = 13
                    Me.Dispose()

            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button14_MouseDown(sender As Object, e As MouseEventArgs) Handles Button14.MouseDown
        Try
            Select Case e.Button
                Case MouseButtons.Right
                    SelectImageAndStore(14)

                    Button14.Image = Image.FromFile(My.Settings.setBackgrundThumbnail14)
                Case MouseButtons.Left
                    Me.DialogResult = vbOK
                    intImageSelected = 14
                    Me.Dispose()

            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button15_MouseDown(sender As Object, e As MouseEventArgs) Handles Button15.MouseDown
        Try
            Select Case e.Button
                Case MouseButtons.Right
                    SelectImageAndStore(15)

                    Button15.Image = Image.FromFile(My.Settings.setBackgrundThumbnail15)
                Case MouseButtons.Left
                    Me.DialogResult = vbOK
                    intImageSelected = 15
                    Me.Dispose()

            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button16_MouseDown(sender As Object, e As MouseEventArgs) Handles Button16.MouseDown
        Try
            Select Case e.Button
                Case MouseButtons.Right
                    SelectImageAndStore(16)

                    Button16.Image = Image.FromFile(My.Settings.setBackgrundThumbnail16)
                Case MouseButtons.Left
                    Me.DialogResult = vbOK
                    intImageSelected = 16
                    Me.Dispose()

            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button17_MouseDown(sender As Object, e As MouseEventArgs) Handles Button17.MouseDown
        Try
            Select Case e.Button
                Case MouseButtons.Right
                    SelectImageAndStore(17)

                    Button17.Image = Image.FromFile(My.Settings.setBackgrundThumbnail17)
                Case MouseButtons.Left
                    Me.DialogResult = vbOK
                    intImageSelected = 17
                    Me.Dispose()

            End Select
        Catch ex As Exception

        End Try
    End Sub


End Class