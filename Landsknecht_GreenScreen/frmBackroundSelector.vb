Public Class frmBackroundSelector

    Public intImageSelected As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DialogResult = vbOK
        intImageSelected = 1
        Me.Dispose()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DialogResult = vbOK
        intImageSelected = 2
        Me.Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.DialogResult = vbOK
        intImageSelected = 3
        Me.Dispose()
    End Sub


    Private Sub frmBackroundSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        Dim Filename As String = ""

        Filename = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground1 & My.Settings.setThumbnailImageSuffix
        Button1.Image = Image.FromFile(Filename)
        ' Align the image and text on the button.

        'Button 2
        Filename = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground2 & My.Settings.setThumbnailImageSuffix
        Button2.Image = Image.FromFile(Filename)

        'Button 3
        Filename = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground3 & My.Settings.setThumbnailImageSuffix
        Button3.Image = Image.FromFile(Filename)

        'Button 4
        Filename = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground4 & My.Settings.setThumbnailImageSuffix
        Button4.Image = Image.FromFile(Filename)
        'Button 5
        Filename = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground5 & My.Settings.setThumbnailImageSuffix
        Button5.Image = Image.FromFile(Filename)
        'Button 6
        Filename = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground6 & My.Settings.setThumbnailImageSuffix
        Button6.Image = Image.FromFile(Filename)
        'Button 7
        Filename = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground7 & My.Settings.setThumbnailImageSuffix
        Button7.Image = Image.FromFile(Filename)
        'Button 2
        Filename = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground8 & My.Settings.setThumbnailImageSuffix
        Button8.Image = Image.FromFile(Filename)
        'Button 2
        Filename = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground9 & My.Settings.setThumbnailImageSuffix
        Button9.Image = Image.FromFile(Filename)
        'Button 2
        Filename = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground10 & My.Settings.setThumbnailImageSuffix
        Button10.Image = Image.FromFile(Filename)

        'Button 
        Filename = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground11 & My.Settings.setThumbnailImageSuffix
        Button11.Image = Image.FromFile(Filename)

        'Button 
        Filename = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground12 & My.Settings.setThumbnailImageSuffix
        Button12.Image = Image.FromFile(Filename)

        'Button 
        Filename = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground13 & My.Settings.setThumbnailImageSuffix
        Button13.Image = Image.FromFile(Filename)

        'Button 
        Filename = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground14 & My.Settings.setThumbnailImageSuffix
        Button14.Image = Image.FromFile(Filename)

        'Button 
        Filename = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground15 & My.Settings.setThumbnailImageSuffix
        Button15.Image = Image.FromFile(Filename)

        'Button 
        Filename = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground16 & My.Settings.setThumbnailImageSuffix
        Button16.Image = Image.FromFile(Filename)

        'Button 
        Filename = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground17 & My.Settings.setThumbnailImageSuffix
        Button17.Image = Image.FromFile(Filename)



        '   Catch ex As Exception
        '   MessageBox.Show(Err.Number & " - " & Err.Description, "Es ist ein Fehler aufgetreten!")
        '  Resume Next
        ' End Try

        ' Assign an image to the button.



    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.DialogResult = vbOK
        intImageSelected = 11
        Me.Dispose()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.DialogResult = vbOK
        intImageSelected = 4
        Me.Dispose()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.DialogResult = vbOK
        intImageSelected = 5
        Me.Dispose()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.DialogResult = vbOK
        intImageSelected = 6
        Me.Dispose()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.DialogResult = vbOK
        intImageSelected = 7
        Me.Dispose()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.DialogResult = vbOK
        intImageSelected = 8
        Me.Dispose()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.DialogResult = vbOK
        intImageSelected = 9
        Me.Dispose()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.DialogResult = vbOK
        intImageSelected = 10
        Me.Dispose()

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.DialogResult = vbOK
        intImageSelected = 12
        Me.Dispose()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.DialogResult = vbOK
        intImageSelected = 13
        Me.Dispose()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Me.DialogResult = vbOK
        intImageSelected = 14
        Me.Dispose()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Me.DialogResult = vbOK
        intImageSelected = 15
        Me.Dispose()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Me.DialogResult = vbOK
        intImageSelected = 16
        Me.Dispose()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Me.DialogResult = vbOK
        intImageSelected = 17
        Me.Dispose()
    End Sub


    Private Sub frmBackroundSelector_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Try
            Select Case intImageSelected
                Case 1
                    My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground1 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground1 & My.Settings.setThumbnailImageSuffix  ' Define source file name.

                Case 2
                    My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground2 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground2 & My.Settings.setThumbnailImageSuffix  ' Define source file name.

                Case 3
                    My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground3 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground3 & My.Settings.setThumbnailImageSuffix  ' Define source file name.

                Case 4
                    My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground4 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground4 & My.Settings.setThumbnailImageSuffix  ' Define source file name.

                Case 5
                    My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground5 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground5 & My.Settings.setThumbnailImageSuffix  ' Define source file name.

                Case 6
                    My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground6 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground6 & My.Settings.setThumbnailImageSuffix  ' Define source file name.

                Case 7
                    My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground7 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground7 & My.Settings.setThumbnailImageSuffix  ' Define source file name.

                Case 8
                    My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground8 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground8 & My.Settings.setThumbnailImageSuffix  ' Define source file name.

                Case 9
                    My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground9 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground9 & My.Settings.setThumbnailImageSuffix  ' Define source file name.


                Case 10
                    My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground10 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground10 & My.Settings.setThumbnailImageSuffix  ' Define source file name.

                Case 11
                    My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground11 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground11 & My.Settings.setThumbnailImageSuffix  ' Define source file name.

                Case 12
                    My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground12 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground12 & My.Settings.setThumbnailImageSuffix  ' Define source file name.

                Case 13
                    My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground13 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground13 & My.Settings.setThumbnailImageSuffix  ' Define source file name.

                Case 14
                    My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground14 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground14 & My.Settings.setThumbnailImageSuffix  ' Define source file name.

                Case 15
                    My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground15 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground15 & My.Settings.setThumbnailImageSuffix  ' Define source file name.

                Case 16

                    My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground16 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground16 & My.Settings.setThumbnailImageSuffix  ' Define source file name.
                Case 17
                    My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground17 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground17 & My.Settings.setThumbnailImageSuffix  ' Define source file name.

                Case Else

            End Select







        Catch ex As Exception

        End Try


        Me.Dispose()

        Dim Ergebnis As Integer = Me.DialogResult
        MsgBox("Disposed", 0, Ergebnis.ToString)

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
End Class