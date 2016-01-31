Public Class frmBackroundSelector

    Public intImageSelected As Integer


    Private Sub frmBackroundSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        Dim Filename As String = ""


        Button1.Image = Image.FromFile(My.Settings.setBackgroundThumbnail1)
        Button2.Image = Image.FromFile(My.Settings.setBackgroundThumbnail2)
        Button3.Image = Image.FromFile(My.Settings.setBackgroundThumbnail3)
        Button4.Image = Image.FromFile(My.Settings.setBackgroundThumbnail4)
        Button5.Image = Image.FromFile(My.Settings.setBackgroundThumbnail5)
        Button6.Image = Image.FromFile(My.Settings.setBackgroundThumbnail6)
        Button7.Image = Image.FromFile(My.Settings.setBackgroundThumbnail7)
        Button8.Image = Image.FromFile(My.Settings.setBackgroundThumbnail8)
        Button9.Image = Image.FromFile(My.Settings.setBackgroundThumbnail9)
        Button10.Image = Image.FromFile(My.Settings.setBackgroundThumbnail10)
        Button11.Image = Image.FromFile(My.Settings.setBackgroundThumbnail11)
        Button12.Image = Image.FromFile(My.Settings.setBackgroundThumbnail12)
        Button13.Image = Image.FromFile(My.Settings.setBackgroundThumbnail13)
        Button14.Image = Image.FromFile(My.Settings.setBackgroundThumbnail14)
        Button15.Image = Image.FromFile(My.Settings.setBackgroundThumbnail15)
        Button16.Image = Image.FromFile(My.Settings.setBackgroundThumbnail16)
        Button17.Image = Image.FromFile(My.Settings.setBackgroundThumbnail17)



    End Sub


    Private Sub frmBackroundSelector_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Try
            Select Case intImageSelected
                Case 1
                    'My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground1 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    'My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground1 & My.Settings.setThumbnailImageSuffix  ' Define source file name.
                    My.Settings.setTempBackgroundImage = My.Settings.setBackground1
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundThumbnail1
                Case 2
                    'My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground2 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    'My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground2 & My.Settings.setThumbnailImageSuffix  ' Define source file name.
                    My.Settings.setTempBackgroundImage = My.Settings.setBackground2
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundThumbnail2
                Case 3
                    'My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground3 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    'My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground3 & My.Settings.setThumbnailImageSuffix  ' Define source file name.
                    My.Settings.setTempBackgroundImage = My.Settings.setBackground3
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundThumbnail3
                Case 4
                    'My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground4 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    'My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground4 & My.Settings.setThumbnailImageSuffix  ' Define source file name.
                    My.Settings.setTempBackgroundImage = My.Settings.setBackground4
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundThumbnail4
                Case 5
                    'My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground5 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    'My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground5 & My.Settings.setThumbnailImageSuffix  ' Define source file name.
                    My.Settings.setTempBackgroundImage = My.Settings.setBackground5
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundThumbnail5
                Case 6
                    'My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground6 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    'My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground6 & My.Settings.setThumbnailImageSuffix  ' Define source file name.
                    My.Settings.setTempBackgroundImage = My.Settings.setBackground6
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundThumbnail6
                Case 7
                    'My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground7 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    'My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground7 & My.Settings.setThumbnailImageSuffix  ' Define source file name.
                    My.Settings.setTempBackgroundImage = My.Settings.setBackground7
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundThumbnail7
                Case 8
                    'My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground8 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    'My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground8 & My.Settings.setThumbnailImageSuffix  ' Define source file name.
                    My.Settings.setTempBackgroundImage = My.Settings.setBackground8
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundThumbnail8
                Case 9
                    'My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground9 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    'My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & " \" & My.Settings.setBackground9 & My.Settings.setThumbnailImageSuffix  ' Define source file name.

                    My.Settings.setTempBackgroundImage = My.Settings.setBackground9
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundThumbnail9
                Case 10
                    'My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground10 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    'My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground10 & My.Settings.setThumbnailImageSuffix  ' Define source file name.
                    My.Settings.setTempBackgroundImage = My.Settings.setBackground10
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundThumbnail10
                Case 11
                    'My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground11 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    'My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground11 & My.Settings.setThumbnailImageSuffix  ' Define source file name.
                    My.Settings.setTempBackgroundImage = My.Settings.setBackground11
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundThumbnail11
                Case 12
                    'My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground12 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    'My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground12 & My.Settings.setThumbnailImageSuffix  ' Define source file name.
                    My.Settings.setTempBackgroundImage = My.Settings.setBackground12
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundThumbnail12
                Case 13
                    'My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground13 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    'My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground13 & My.Settings.setThumbnailImageSuffix  ' Define source file name.
                    My.Settings.setTempBackgroundImage = My.Settings.setBackground13
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundThumbnail13
                Case 14
                    'My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground14 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    'My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground14 & My.Settings.setThumbnailImageSuffix  ' Define source file name.
                    My.Settings.setTempBackgroundImage = My.Settings.setBackground14
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundThumbnail14
                Case 15
                    'My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground15 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    'My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground15 & My.Settings.setThumbnailImageSuffix  ' Define source file name.
                    My.Settings.setTempBackgroundImage = My.Settings.setBackground15
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundThumbnail15
                Case 16
                    My.Settings.setTempBackgroundImage = My.Settings.setBackground16
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundThumbnail16
                    'My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground16 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    'My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground16 & My.Settings.setThumbnailImageSuffix  ' Define source file name.
                Case 17
                    'My.Settings.setTempBackgroundImage = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground17 & My.Settings.setBackgroundImageFileFormat ' Define source file name.
                    'My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundImagePath & "\" & My.Settings.setBackground17 & My.Settings.setThumbnailImageSuffix  ' Define source file name.
                    My.Settings.setTempBackgroundImage = My.Settings.setBackground17
                    My.Settings.setTempBackgroundImagePreview = My.Settings.setBackgroundThumbnail7
                Case Else

            End Select


        Catch ex As Exception

        End Try

        frmMain.picPreview.Image = Image.FromFile(My.Settings.setTempBackgroundImagePreview)

        Me.Dispose()



    End Sub



    Private Sub SelectImageAndStore(Button As Integer)

        Dim x As New frmSelectPicture
        x.Hintergrundbild = ""
        x.HintergrundThumbnail = ""

        x.ShowDialog()

        '      MsgBox(x.Hintergrundbild, 0, x.HintergrundThumbnail)

        Select Case Button
            Case 1
                My.Settings.setBackground1 = x.Hintergrundbild
                My.Settings.setBackgroundThumbnail1 = x.HintergrundThumbnail
            Case 2
                My.Settings.setBackground2 = x.Hintergrundbild
                My.Settings.setBackgroundThumbnail2 = x.HintergrundThumbnail
            Case 3
                My.Settings.setBackground3 = x.Hintergrundbild
                My.Settings.setBackgroundThumbnail3 = x.HintergrundThumbnail
            Case 4
                My.Settings.setBackground4 = x.Hintergrundbild
                My.Settings.setBackgroundThumbnail4 = x.HintergrundThumbnail
            Case 5
                My.Settings.setBackground5 = x.Hintergrundbild
                My.Settings.setBackgroundThumbnail5 = x.HintergrundThumbnail
            Case 6
                My.Settings.setBackground6 = x.Hintergrundbild
                My.Settings.setBackgroundThumbnail6 = x.HintergrundThumbnail
            Case 7
                My.Settings.setBackground7 = x.Hintergrundbild
                My.Settings.setBackgroundThumbnail7 = x.HintergrundThumbnail
            Case 8
                My.Settings.setBackground8 = x.Hintergrundbild
                My.Settings.setBackgroundThumbnail8 = x.HintergrundThumbnail
            Case 9
                My.Settings.setBackground9 = x.Hintergrundbild
                My.Settings.setBackgroundThumbnail9 = x.HintergrundThumbnail
            Case 10
                My.Settings.setBackground10 = x.Hintergrundbild
                My.Settings.setBackgroundThumbnail10 = x.HintergrundThumbnail
            Case 11
                My.Settings.setBackground11 = x.Hintergrundbild
                My.Settings.setBackgroundThumbnail11 = x.HintergrundThumbnail
            Case 12
                My.Settings.setBackground12 = x.Hintergrundbild
                My.Settings.setBackgroundThumbnail12 = x.HintergrundThumbnail
            Case 13
                My.Settings.setBackground13 = x.Hintergrundbild
                My.Settings.setBackgroundThumbnail13 = x.HintergrundThumbnail
            Case 14
                My.Settings.setBackground14 = x.Hintergrundbild
                My.Settings.setBackgroundThumbnail14 = x.HintergrundThumbnail
            Case 15
                My.Settings.setBackground15 = x.Hintergrundbild
                My.Settings.setBackgroundThumbnail15 = x.HintergrundThumbnail
            Case 16
                My.Settings.setBackground16 = x.Hintergrundbild
                My.Settings.setBackgroundThumbnail16 = x.HintergrundThumbnail
            Case 17
                My.Settings.setBackground17 = x.Hintergrundbild
                My.Settings.setBackgroundThumbnail17 = x.HintergrundThumbnail
        End Select

        My.Settings.Save()


    End Sub
    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown


        Try
            Select Case e.Button
                Case MouseButtons.Right
                    SelectImageAndStore(1)

                    Button1.Image = Image.FromFile(My.Settings.setBackgroundThumbnail1)
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

                    Button2.Image = Image.FromFile(My.Settings.setBackgroundThumbnail2)
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

                    Button3.Image = Image.FromFile(My.Settings.setBackgroundThumbnail3)
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

                    Button4.Image = Image.FromFile(My.Settings.setBackgroundThumbnail4)
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

                    Button5.Image = Image.FromFile(My.Settings.setBackgroundThumbnail5)
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

                    Button6.Image = Image.FromFile(My.Settings.setBackgroundThumbnail6)
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

                    Button7.Image = Image.FromFile(My.Settings.setBackgroundThumbnail7)
                Case MouseButtons.Left
                    Me.DialogResult = vbOK
                    intImageSelected = 7
                    Me.Dispose()

            End Select
        Catch ex As Exception
            MsgBox("Fehler")

        End Try
    End Sub

    Private Sub Button8_MouseDown(sender As Object, e As MouseEventArgs) Handles Button8.MouseDown
        Try
            Select Case e.Button
                Case MouseButtons.Right
                    SelectImageAndStore(8)

                    Button8.Image = Image.FromFile(My.Settings.setBackgroundThumbnail8)
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

                    Button9.Image = Image.FromFile(My.Settings.setBackgroundThumbnail9)
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

                    Button10.Image = Image.FromFile(My.Settings.setBackgroundThumbnail10)
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

                    Button11.Image = Image.FromFile(My.Settings.setBackgroundThumbnail11)
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

                    Button12.Image = Image.FromFile(My.Settings.setBackgroundThumbnail12)
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

                    Button13.Image = Image.FromFile(My.Settings.setBackgroundThumbnail13)
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

                    Button14.Image = Image.FromFile(My.Settings.setBackgroundThumbnail14)
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

                    Button15.Image = Image.FromFile(My.Settings.setBackgroundThumbnail15)
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

                    Button16.Image = Image.FromFile(My.Settings.setBackgroundThumbnail16)
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

                    Button17.Image = Image.FromFile(My.Settings.setBackgroundThumbnail17)
                Case MouseButtons.Left
                    Me.DialogResult = vbOK
                    intImageSelected = 17
                    Me.Dispose()

            End Select
        Catch ex As Exception

        End Try
    End Sub


End Class