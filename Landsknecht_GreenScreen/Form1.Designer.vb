<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.grpApplikation1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkScanSubDir1 = New System.Windows.Forms.CheckBox()
        Me.lblScanPath1 = New System.Windows.Forms.Label()
        Me.txtScanPath1 = New System.Windows.Forms.TextBox()
        Me.btnScanPath1 = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtApplication1Arguments = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtApplication1Filter = New System.Windows.Forms.TextBox()
        Me.btnApplication1 = New System.Windows.Forms.Button()
        Me.txtApplication1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkScanSubDir2 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtScanPath2 = New System.Windows.Forms.TextBox()
        Me.btnScanPath2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtApplication2Arguments = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtApplication2Filter = New System.Windows.Forms.TextBox()
        Me.btnApplication2 = New System.Windows.Forms.Button()
        Me.txtApplication2 = New System.Windows.Forms.TextBox()
        Me.FileSystemWatcher2 = New System.IO.FileSystemWatcher()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpApplikation1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.FileSystemWatcher2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'btnEnd
        '
        Me.btnEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEnd.Location = New System.Drawing.Point(293, 360)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(92, 36)
        Me.btnEnd.TabIndex = 32
        Me.btnEnd.Text = "Programm beenden"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnStop.Location = New System.Drawing.Point(113, 360)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(93, 36)
        Me.btnStop.TabIndex = 31
        Me.btnStop.Text = "Überwachung beenden"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnStart.Location = New System.Drawing.Point(12, 360)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(93, 36)
        Me.btnStart.TabIndex = 30
        Me.btnStart.Text = "Überwachung starten"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'grpApplikation1
        '
        Me.grpApplikation1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpApplikation1.Controls.Add(Me.Label5)
        Me.grpApplikation1.Controls.Add(Me.chkScanSubDir1)
        Me.grpApplikation1.Controls.Add(Me.lblScanPath1)
        Me.grpApplikation1.Controls.Add(Me.txtScanPath1)
        Me.grpApplikation1.Controls.Add(Me.btnScanPath1)
        Me.grpApplikation1.Controls.Add(Me.label3)
        Me.grpApplikation1.Controls.Add(Me.txtApplication1Arguments)
        Me.grpApplikation1.Controls.Add(Me.label2)
        Me.grpApplikation1.Controls.Add(Me.txtApplication1Filter)
        Me.grpApplikation1.Controls.Add(Me.btnApplication1)
        Me.grpApplikation1.Controls.Add(Me.txtApplication1)
        Me.grpApplikation1.Location = New System.Drawing.Point(12, 8)
        Me.grpApplikation1.Name = "grpApplikation1"
        Me.grpApplikation1.Size = New System.Drawing.Size(373, 162)
        Me.grpApplikation1.TabIndex = 33
        Me.grpApplikation1.TabStop = False
        Me.grpApplikation1.Text = "Event 1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(263, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Applikation 1, die bei neuer Datei gestartet werden soll"
        '
        'chkScanSubDir1
        '
        Me.chkScanSubDir1.AutoSize = True
        Me.chkScanSubDir1.Location = New System.Drawing.Point(200, 21)
        Me.chkScanSubDir1.Name = "chkScanSubDir1"
        Me.chkScanSubDir1.Size = New System.Drawing.Size(144, 17)
        Me.chkScanSubDir1.TabIndex = 39
        Me.chkScanSubDir1.Text = "Auch Unterverzeichnisse"
        Me.chkScanSubDir1.UseVisualStyleBackColor = True
        '
        'lblScanPath1
        '
        Me.lblScanPath1.AutoSize = True
        Me.lblScanPath1.Location = New System.Drawing.Point(6, 23)
        Me.lblScanPath1.Name = "lblScanPath1"
        Me.lblScanPath1.Size = New System.Drawing.Size(167, 13)
        Me.lblScanPath1.TabIndex = 38
        Me.lblScanPath1.Text = "Pfad 1 zum prüfen auf neue Fotos"
        '
        'txtScanPath1
        '
        Me.txtScanPath1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtScanPath1.Location = New System.Drawing.Point(7, 39)
        Me.txtScanPath1.Name = "txtScanPath1"
        Me.txtScanPath1.Size = New System.Drawing.Size(333, 20)
        Me.txtScanPath1.TabIndex = 37
        '
        'btnScanPath1
        '
        Me.btnScanPath1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnScanPath1.Location = New System.Drawing.Point(340, 38)
        Me.btnScanPath1.Name = "btnScanPath1"
        Me.btnScanPath1.Size = New System.Drawing.Size(25, 20)
        Me.btnScanPath1.TabIndex = 36
        Me.btnScanPath1.Text = "..."
        Me.btnScanPath1.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(6, 138)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(188, 13)
        Me.label3.TabIndex = 35
        Me.label3.Text = "Zusätzliche Argumente für Application "
        '
        'txtApplication1Arguments
        '
        Me.txtApplication1Arguments.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtApplication1Arguments.Location = New System.Drawing.Point(200, 135)
        Me.txtApplication1Arguments.Name = "txtApplication1Arguments"
        Me.txtApplication1Arguments.Size = New System.Drawing.Size(140, 20)
        Me.txtApplication1Arguments.TabIndex = 34
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(3, 112)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(284, 13)
        Me.label2.TabIndex = 33
        Me.label2.Text = "Filter (Bei welchtem Dateiformat soll das Programm starten?"
        '
        'txtApplication1Filter
        '
        Me.txtApplication1Filter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtApplication1Filter.Location = New System.Drawing.Point(297, 109)
        Me.txtApplication1Filter.Name = "txtApplication1Filter"
        Me.txtApplication1Filter.Size = New System.Drawing.Size(43, 20)
        Me.txtApplication1Filter.TabIndex = 32
        '
        'btnApplication1
        '
        Me.btnApplication1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApplication1.Location = New System.Drawing.Point(340, 84)
        Me.btnApplication1.Name = "btnApplication1"
        Me.btnApplication1.Size = New System.Drawing.Size(25, 20)
        Me.btnApplication1.TabIndex = 31
        Me.btnApplication1.Text = "..."
        Me.btnApplication1.UseVisualStyleBackColor = True
        '
        'txtApplication1
        '
        Me.txtApplication1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtApplication1.Location = New System.Drawing.Point(6, 83)
        Me.txtApplication1.Name = "txtApplication1"
        Me.txtApplication1.Size = New System.Drawing.Size(334, 20)
        Me.txtApplication1.TabIndex = 30
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.chkScanSubDir2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtScanPath2)
        Me.GroupBox1.Controls.Add(Me.btnScanPath2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtApplication2Arguments)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtApplication2Filter)
        Me.GroupBox1.Controls.Add(Me.btnApplication2)
        Me.GroupBox1.Controls.Add(Me.txtApplication2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 176)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(373, 175)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Event 2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(6, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(263, 13)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Applikation 2, die bei neuer Datei gestartet werden soll"
        '
        'chkScanSubDir2
        '
        Me.chkScanSubDir2.AutoSize = True
        Me.chkScanSubDir2.Location = New System.Drawing.Point(201, 23)
        Me.chkScanSubDir2.Name = "chkScanSubDir2"
        Me.chkScanSubDir2.Size = New System.Drawing.Size(144, 17)
        Me.chkScanSubDir2.TabIndex = 43
        Me.chkScanSubDir2.Text = "Auch Unterverzeichnisse"
        Me.chkScanSubDir2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 13)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Pfad 2 zum prüfen auf neue Fotos"
        '
        'txtScanPath2
        '
        Me.txtScanPath2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtScanPath2.Location = New System.Drawing.Point(7, 41)
        Me.txtScanPath2.Name = "txtScanPath2"
        Me.txtScanPath2.Size = New System.Drawing.Size(333, 20)
        Me.txtScanPath2.TabIndex = 41
        '
        'btnScanPath2
        '
        Me.btnScanPath2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnScanPath2.Location = New System.Drawing.Point(342, 41)
        Me.btnScanPath2.Name = "btnScanPath2"
        Me.btnScanPath2.Size = New System.Drawing.Size(25, 20)
        Me.btnScanPath2.TabIndex = 40
        Me.btnScanPath2.Text = "..."
        Me.btnScanPath2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Zusätzliche Argumente für Application "
        '
        'txtApplication2Arguments
        '
        Me.txtApplication2Arguments.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtApplication2Arguments.Location = New System.Drawing.Point(200, 138)
        Me.txtApplication2Arguments.Name = "txtApplication2Arguments"
        Me.txtApplication2Arguments.Size = New System.Drawing.Size(140, 20)
        Me.txtApplication2Arguments.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(284, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Filter (Bei welchtem Dateiformat soll das Programm starten?"
        '
        'txtApplication2Filter
        '
        Me.txtApplication2Filter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtApplication2Filter.Location = New System.Drawing.Point(288, 112)
        Me.txtApplication2Filter.Name = "txtApplication2Filter"
        Me.txtApplication2Filter.Size = New System.Drawing.Size(52, 20)
        Me.txtApplication2Filter.TabIndex = 32
        '
        'btnApplication2
        '
        Me.btnApplication2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApplication2.Location = New System.Drawing.Point(340, 85)
        Me.btnApplication2.Name = "btnApplication2"
        Me.btnApplication2.Size = New System.Drawing.Size(27, 20)
        Me.btnApplication2.TabIndex = 31
        Me.btnApplication2.Text = "..."
        Me.btnApplication2.UseVisualStyleBackColor = True
        '
        'txtApplication2
        '
        Me.txtApplication2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtApplication2.Location = New System.Drawing.Point(6, 86)
        Me.txtApplication2.Name = "txtApplication2"
        Me.txtApplication2.Size = New System.Drawing.Size(334, 20)
        Me.txtApplication2.TabIndex = 30
        '
        'FileSystemWatcher2
        '
        Me.FileSystemWatcher2.EnableRaisingEvents = True
        Me.FileSystemWatcher2.SynchronizingObject = Me
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 408)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpApplikation1)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Partyhaus Landsknecht -  GreenScreen Shooting"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpApplikation1.ResumeLayout(False)
        Me.grpApplikation1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.FileSystemWatcher2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Private WithEvents btnEnd As System.Windows.Forms.Button
    Private WithEvents btnStop As System.Windows.Forms.Button
    Private WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents grpApplikation1 As System.Windows.Forms.GroupBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents txtApplication1Arguments As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents txtApplication1Filter As System.Windows.Forms.TextBox
    Private WithEvents btnApplication1 As System.Windows.Forms.Button
    Private WithEvents txtApplication1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents txtApplication2Arguments As System.Windows.Forms.TextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents txtApplication2Filter As System.Windows.Forms.TextBox
    Private WithEvents btnApplication2 As System.Windows.Forms.Button
    Private WithEvents txtApplication2 As System.Windows.Forms.TextBox
    Friend WithEvents FileSystemWatcher2 As System.IO.FileSystemWatcher
    Friend WithEvents chkScanSubDir1 As System.Windows.Forms.CheckBox
    Friend WithEvents lblScanPath1 As System.Windows.Forms.Label
    Friend WithEvents txtScanPath1 As System.Windows.Forms.TextBox
    Friend WithEvents btnScanPath1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chkScanSubDir2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtScanPath2 As System.Windows.Forms.TextBox
    Friend WithEvents btnScanPath2 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
