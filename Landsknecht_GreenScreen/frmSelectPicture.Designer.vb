<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectPicture
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.btnHintergrundbild = New System.Windows.Forms.Button()
        Me.txtHintergrundbild = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHintergrundThumbnail = New System.Windows.Forms.TextBox()
        Me.btnHintergrundThumbnail = New System.Windows.Forms.Button()
        Me.picThumbnail = New System.Windows.Forms.PictureBox()
        Me.picPicture = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.picThumbnail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(531, 253)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Abbrechen"
        '
        'btnHintergrundbild
        '
        Me.btnHintergrundbild.Location = New System.Drawing.Point(650, 31)
        Me.btnHintergrundbild.Name = "btnHintergrundbild"
        Me.btnHintergrundbild.Size = New System.Drawing.Size(27, 20)
        Me.btnHintergrundbild.TabIndex = 1
        Me.btnHintergrundbild.Text = "..."
        Me.btnHintergrundbild.UseVisualStyleBackColor = True
        '
        'txtHintergrundbild
        '
        Me.txtHintergrundbild.Location = New System.Drawing.Point(12, 31)
        Me.txtHintergrundbild.Name = "txtHintergrundbild"
        Me.txtHintergrundbild.Size = New System.Drawing.Size(632, 20)
        Me.txtHintergrundbild.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Bitte wählen sie das Hintergrundbild aus"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(269, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Bitte wählen sie das Thumbnail zum Hintergrundbild aus"
        '
        'txtHintergrundThumbnail
        '
        Me.txtHintergrundThumbnail.Location = New System.Drawing.Point(12, 88)
        Me.txtHintergrundThumbnail.Name = "txtHintergrundThumbnail"
        Me.txtHintergrundThumbnail.Size = New System.Drawing.Size(632, 20)
        Me.txtHintergrundThumbnail.TabIndex = 5
        '
        'btnHintergrundThumbnail
        '
        Me.btnHintergrundThumbnail.Location = New System.Drawing.Point(650, 88)
        Me.btnHintergrundThumbnail.Name = "btnHintergrundThumbnail"
        Me.btnHintergrundThumbnail.Size = New System.Drawing.Size(27, 20)
        Me.btnHintergrundThumbnail.TabIndex = 4
        Me.btnHintergrundThumbnail.Text = "..."
        Me.btnHintergrundThumbnail.UseVisualStyleBackColor = True
        Me.btnHintergrundThumbnail.Visible = False
        '
        'picThumbnail
        '
        Me.picThumbnail.Location = New System.Drawing.Point(218, 143)
        Me.picThumbnail.Name = "picThumbnail"
        Me.picThumbnail.Size = New System.Drawing.Size(200, 141)
        Me.picThumbnail.TabIndex = 7
        Me.picThumbnail.TabStop = False
        '
        'picPicture
        '
        Me.picPicture.Location = New System.Drawing.Point(12, 143)
        Me.picPicture.Name = "picPicture"
        Me.picPicture.Size = New System.Drawing.Size(200, 141)
        Me.picPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPicture.TabIndex = 8
        Me.picPicture.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Original"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(218, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Berechnete Miniatur"
        '
        'frmSelectPicture
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(689, 294)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.picPicture)
        Me.Controls.Add(Me.picThumbnail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtHintergrundThumbnail)
        Me.Controls.Add(Me.btnHintergrundThumbnail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHintergrundbild)
        Me.Controls.Add(Me.btnHintergrundbild)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSelectPicture"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Bild und Vorschauversion auswählen"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.picThumbnail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents btnHintergrundbild As Button
    Friend WithEvents txtHintergrundbild As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHintergrundThumbnail As TextBox
    Friend WithEvents btnHintergrundThumbnail As Button
    Friend WithEvents picThumbnail As PictureBox
    Friend WithEvents picPicture As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
