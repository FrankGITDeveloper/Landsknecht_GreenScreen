<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPreview
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ImageBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.ImageBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageBox1
        '
        Me.ImageBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImageBox1.Enabled = False
        Me.ImageBox1.Location = New System.Drawing.Point(0, 0)
        Me.ImageBox1.Name = "ImageBox1"
        Me.ImageBox1.Size = New System.Drawing.Size(607, 415)
        Me.ImageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImageBox1.TabIndex = 0
        Me.ImageBox1.TabStop = False
        Me.ImageBox1.WaitOnLoad = True
        '
        'frmPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 415)
        Me.Controls.Add(Me.ImageBox1)
        Me.Name = "frmPreview"
        Me.Text = "frmPreview"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ImageBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ImageBox1 As PictureBox
End Class
