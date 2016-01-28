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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FileSystemWatcher2 = New System.IO.FileSystemWatcher()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.grpApp1 = New System.Windows.Forms.GroupBox()
        Me.chkPhotolineArtguments = New System.Windows.Forms.CheckBox()
        Me.txtApplication1Arguments = New System.Windows.Forms.TextBox()
        Me.txtApplication1 = New System.Windows.Forms.TextBox()
        Me.lblApp1 = New System.Windows.Forms.Label()
        Me.btnApplication1 = New System.Windows.Forms.Button()
        Me.lblArgumentApp1 = New System.Windows.Forms.Label()
        Me.grpScanApp1 = New System.Windows.Forms.GroupBox()
        Me.chkScanSubDir1 = New System.Windows.Forms.CheckBox()
        Me.lblScanPath1 = New System.Windows.Forms.Label()
        Me.txtScanPath1 = New System.Windows.Forms.TextBox()
        Me.btnScanPath1 = New System.Windows.Forms.Button()
        Me.lblFilterApp1 = New System.Windows.Forms.Label()
        Me.txtApplication1Filter = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtApplication2Arguments = New System.Windows.Forms.TextBox()
        Me.txtApplication2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnApplication2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkScanSubDir2 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtScanPath2 = New System.Windows.Forms.TextBox()
        Me.btnScanPath2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtApplication2Filter = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KonfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HintergrundAuswahlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HilfeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÜberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.picPreview = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.chkPhotolineArtguments2 = New System.Windows.Forms.CheckBox()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.grpApp1.SuspendLayout()
        Me.grpScanApp1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'btnEnd
        '
        Me.btnEnd.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEnd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEnd.Location = New System.Drawing.Point(519, 360)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(202, 36)
        Me.btnEnd.TabIndex = 10
        Me.btnEnd.Text = "Programm beenden"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnStop.Location = New System.Drawing.Point(111, 364)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(93, 36)
        Me.btnStop.TabIndex = 9
        Me.btnStop.Text = "Überwachung beenden"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnStart.Location = New System.Drawing.Point(12, 364)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(93, 36)
        Me.btnStart.TabIndex = 8
        Me.btnStart.Text = "Überwachung starten"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(501, 255)
        Me.TabControl1.TabIndex = 35
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.grpApp1)
        Me.TabPage1.Controls.Add(Me.grpScanApp1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(493, 229)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Anwendung 1"
        '
        'grpApp1
        '
        Me.grpApp1.BackColor = System.Drawing.Color.Transparent
        Me.grpApp1.Controls.Add(Me.chkPhotolineArtguments)
        Me.grpApp1.Controls.Add(Me.txtApplication1Arguments)
        Me.grpApp1.Controls.Add(Me.txtApplication1)
        Me.grpApp1.Controls.Add(Me.lblApp1)
        Me.grpApp1.Controls.Add(Me.btnApplication1)
        Me.grpApp1.Controls.Add(Me.lblArgumentApp1)
        Me.grpApp1.Location = New System.Drawing.Point(9, 104)
        Me.grpApp1.Name = "grpApp1"
        Me.grpApp1.Size = New System.Drawing.Size(474, 118)
        Me.grpApp1.TabIndex = 41
        Me.grpApp1.TabStop = False
        '
        'chkPhotolineArtguments
        '
        Me.chkPhotolineArtguments.Location = New System.Drawing.Point(239, 68)
        Me.chkPhotolineArtguments.Name = "chkPhotolineArtguments"
        Me.chkPhotolineArtguments.Size = New System.Drawing.Size(216, 17)
        Me.chkPhotolineArtguments.TabIndex = 39
        Me.chkPhotolineArtguments.Text = "Photoline Übergabeargumente nutzen"
        Me.chkPhotolineArtguments.UseVisualStyleBackColor = True
        '
        'txtApplication1Arguments
        '
        Me.txtApplication1Arguments.Location = New System.Drawing.Point(6, 85)
        Me.txtApplication1Arguments.Name = "txtApplication1Arguments"
        Me.txtApplication1Arguments.Size = New System.Drawing.Size(430, 20)
        Me.txtApplication1Arguments.TabIndex = 7
        '
        'txtApplication1
        '
        Me.txtApplication1.Location = New System.Drawing.Point(6, 35)
        Me.txtApplication1.Name = "txtApplication1"
        Me.txtApplication1.Size = New System.Drawing.Size(430, 20)
        Me.txtApplication1.TabIndex = 5
        '
        'lblApp1
        '
        Me.lblApp1.AutoSize = True
        Me.lblApp1.ForeColor = System.Drawing.Color.Black
        Me.lblApp1.Location = New System.Drawing.Point(6, 19)
        Me.lblApp1.Name = "lblApp1"
        Me.lblApp1.Size = New System.Drawing.Size(259, 13)
        Me.lblApp1.TabIndex = 44
        Me.lblApp1.Text = "Anwendung, die bei neuer Datei gestartet werden soll"
        '
        'btnApplication1
        '
        Me.btnApplication1.Location = New System.Drawing.Point(442, 35)
        Me.btnApplication1.Name = "btnApplication1"
        Me.btnApplication1.Size = New System.Drawing.Size(25, 20)
        Me.btnApplication1.TabIndex = 6
        Me.btnApplication1.Text = "..."
        Me.btnApplication1.UseVisualStyleBackColor = True
        '
        'lblArgumentApp1
        '
        Me.lblArgumentApp1.AutoSize = True
        Me.lblArgumentApp1.Location = New System.Drawing.Point(6, 69)
        Me.lblArgumentApp1.Name = "lblArgumentApp1"
        Me.lblArgumentApp1.Size = New System.Drawing.Size(188, 13)
        Me.lblArgumentApp1.TabIndex = 43
        Me.lblArgumentApp1.Text = "Zusätzliche Argumente für Application "
        '
        'grpScanApp1
        '
        Me.grpScanApp1.BackColor = System.Drawing.Color.Transparent
        Me.grpScanApp1.Controls.Add(Me.chkScanSubDir1)
        Me.grpScanApp1.Controls.Add(Me.lblScanPath1)
        Me.grpScanApp1.Controls.Add(Me.txtScanPath1)
        Me.grpScanApp1.Controls.Add(Me.btnScanPath1)
        Me.grpScanApp1.Controls.Add(Me.lblFilterApp1)
        Me.grpScanApp1.Controls.Add(Me.txtApplication1Filter)
        Me.grpScanApp1.Location = New System.Drawing.Point(9, 6)
        Me.grpScanApp1.Name = "grpScanApp1"
        Me.grpScanApp1.Size = New System.Drawing.Size(474, 92)
        Me.grpScanApp1.TabIndex = 34
        Me.grpScanApp1.TabStop = False
        '
        'chkScanSubDir1
        '
        Me.chkScanSubDir1.Location = New System.Drawing.Point(220, 19)
        Me.chkScanSubDir1.Name = "chkScanSubDir1"
        Me.chkScanSubDir1.Size = New System.Drawing.Size(216, 17)
        Me.chkScanSubDir1.TabIndex = 1
        Me.chkScanSubDir1.Text = "Auch Unterverzeichnisse überwachen"
        Me.chkScanSubDir1.UseVisualStyleBackColor = True
        '
        'lblScanPath1
        '
        Me.lblScanPath1.AutoSize = True
        Me.lblScanPath1.Location = New System.Drawing.Point(6, 18)
        Me.lblScanPath1.Name = "lblScanPath1"
        Me.lblScanPath1.Size = New System.Drawing.Size(169, 13)
        Me.lblScanPath1.TabIndex = 38
        Me.lblScanPath1.Text = "Pfad zum prüfen auf neue Dateien"
        '
        'txtScanPath1
        '
        Me.txtScanPath1.Location = New System.Drawing.Point(6, 37)
        Me.txtScanPath1.Name = "txtScanPath1"
        Me.txtScanPath1.Size = New System.Drawing.Size(430, 20)
        Me.txtScanPath1.TabIndex = 2
        '
        'btnScanPath1
        '
        Me.btnScanPath1.Location = New System.Drawing.Point(442, 36)
        Me.btnScanPath1.Name = "btnScanPath1"
        Me.btnScanPath1.Size = New System.Drawing.Size(25, 20)
        Me.btnScanPath1.TabIndex = 3
        Me.btnScanPath1.Text = "..."
        Me.btnScanPath1.UseVisualStyleBackColor = True
        '
        'lblFilterApp1
        '
        Me.lblFilterApp1.AutoSize = True
        Me.lblFilterApp1.Location = New System.Drawing.Point(6, 66)
        Me.lblFilterApp1.Name = "lblFilterApp1"
        Me.lblFilterApp1.Size = New System.Drawing.Size(353, 13)
        Me.lblFilterApp1.TabIndex = 33
        Me.lblFilterApp1.Text = "Filter (Bei welchtem Dateiformat soll das Programm starten? Beispiel *.JPG"
        '
        'txtApplication1Filter
        '
        Me.txtApplication1Filter.Location = New System.Drawing.Point(393, 63)
        Me.txtApplication1Filter.Name = "txtApplication1Filter"
        Me.txtApplication1Filter.Size = New System.Drawing.Size(43, 20)
        Me.txtApplication1Filter.TabIndex = 4
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(493, 229)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Anwendung 2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.chkPhotolineArtguments2)
        Me.GroupBox2.Controls.Add(Me.txtApplication2Arguments)
        Me.GroupBox2.Controls.Add(Me.txtApplication2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnApplication2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(474, 118)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        '
        'txtApplication2Arguments
        '
        Me.txtApplication2Arguments.Location = New System.Drawing.Point(6, 85)
        Me.txtApplication2Arguments.Name = "txtApplication2Arguments"
        Me.txtApplication2Arguments.Size = New System.Drawing.Size(430, 20)
        Me.txtApplication2Arguments.TabIndex = 17
        '
        'txtApplication2
        '
        Me.txtApplication2.Location = New System.Drawing.Point(6, 35)
        Me.txtApplication2.Name = "txtApplication2"
        Me.txtApplication2.Size = New System.Drawing.Size(430, 20)
        Me.txtApplication2.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(259, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Anwendung, die bei neuer Datei gestartet werden soll"
        '
        'btnApplication2
        '
        Me.btnApplication2.Location = New System.Drawing.Point(442, 35)
        Me.btnApplication2.Name = "btnApplication2"
        Me.btnApplication2.Size = New System.Drawing.Size(25, 20)
        Me.btnApplication2.TabIndex = 16
        Me.btnApplication2.Text = "..."
        Me.btnApplication2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(188, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Zusätzliche Argumente für Application "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.chkScanSubDir2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtScanPath2)
        Me.GroupBox1.Controls.Add(Me.btnScanPath2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtApplication2Filter)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(474, 92)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'chkScanSubDir2
        '
        Me.chkScanSubDir2.Location = New System.Drawing.Point(220, 19)
        Me.chkScanSubDir2.Name = "chkScanSubDir2"
        Me.chkScanSubDir2.Size = New System.Drawing.Size(216, 17)
        Me.chkScanSubDir2.TabIndex = 11
        Me.chkScanSubDir2.Text = "Auch Unterverzeichnisse überwachen"
        Me.chkScanSubDir2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Pfad zum prüfen auf neue Dateien"
        '
        'txtScanPath2
        '
        Me.txtScanPath2.Location = New System.Drawing.Point(6, 37)
        Me.txtScanPath2.Name = "txtScanPath2"
        Me.txtScanPath2.Size = New System.Drawing.Size(430, 20)
        Me.txtScanPath2.TabIndex = 12
        '
        'btnScanPath2
        '
        Me.btnScanPath2.Location = New System.Drawing.Point(442, 36)
        Me.btnScanPath2.Name = "btnScanPath2"
        Me.btnScanPath2.Size = New System.Drawing.Size(25, 20)
        Me.btnScanPath2.TabIndex = 13
        Me.btnScanPath2.Text = "..."
        Me.btnScanPath2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(353, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Filter (Bei welchtem Dateiformat soll das Programm starten? Beispiel *.JPG"
        '
        'txtApplication2Filter
        '
        Me.txtApplication2Filter.Location = New System.Drawing.Point(393, 63)
        Me.txtApplication2Filter.Name = "txtApplication2Filter"
        Me.txtApplication2Filter.Size = New System.Drawing.Size(43, 20)
        Me.txtApplication2Filter.TabIndex = 14
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.HilfeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(730, 24)
        Me.MenuStrip1.TabIndex = 37
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KonfigurationToolStripMenuItem, Me.HintergrundAuswahlToolStripMenuItem, Me.ToolStripMenuItem1, Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "&Datei"
        '
        'KonfigurationToolStripMenuItem
        '
        Me.KonfigurationToolStripMenuItem.Name = "KonfigurationToolStripMenuItem"
        Me.KonfigurationToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.KonfigurationToolStripMenuItem.Text = "Konfiguration"
        '
        'HintergrundAuswahlToolStripMenuItem
        '
        Me.HintergrundAuswahlToolStripMenuItem.Name = "HintergrundAuswahlToolStripMenuItem"
        Me.HintergrundAuswahlToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.HintergrundAuswahlToolStripMenuItem.Text = "Hintergrund Auswahl"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(184, 6)
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.BeendenToolStripMenuItem.Text = "&Beenden"
        '
        'HilfeToolStripMenuItem
        '
        Me.HilfeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÜberToolStripMenuItem})
        Me.HilfeToolStripMenuItem.Name = "HilfeToolStripMenuItem"
        Me.HilfeToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HilfeToolStripMenuItem.Text = "Hilfe"
        '
        'ÜberToolStripMenuItem
        '
        Me.ÜberToolStripMenuItem.Name = "ÜberToolStripMenuItem"
        Me.ÜberToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ÜberToolStripMenuItem.Text = "Über"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(516, 188)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(202, 132)
        Me.PictureBox2.TabIndex = 42
        Me.PictureBox2.TabStop = False
        '
        'picPreview
        '
        Me.picPreview.Location = New System.Drawing.Point(516, 49)
        Me.picPreview.Name = "picPreview"
        Me.picPreview.Size = New System.Drawing.Size(202, 132)
        Me.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPreview.TabIndex = 41
        Me.picPreview.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Landsknecht_GreenScreen.My.Resources.Resources.RZ_Landsnecht_RGB_transparent
        Me.PictureBox1.Location = New System.Drawing.Point(263, 292)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(229, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'chkPhotolineArtguments2
        '
        Me.chkPhotolineArtguments2.Location = New System.Drawing.Point(238, 67)
        Me.chkPhotolineArtguments2.Name = "chkPhotolineArtguments2"
        Me.chkPhotolineArtguments2.Size = New System.Drawing.Size(216, 17)
        Me.chkPhotolineArtguments2.TabIndex = 45
        Me.chkPhotolineArtguments2.Text = "Photoline Übergabeargumente nutzen"
        Me.chkPhotolineArtguments2.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 412)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.picPreview)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Partyhaus Landsknecht -  GreenScreen Shooting"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.grpApp1.ResumeLayout(False)
        Me.grpApp1.PerformLayout()
        Me.grpScanApp1.ResumeLayout(False)
        Me.grpScanApp1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Private WithEvents btnEnd As System.Windows.Forms.Button
    Private WithEvents btnStop As System.Windows.Forms.Button
    Private WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FileSystemWatcher2 As System.IO.FileSystemWatcher
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents grpScanApp1 As GroupBox
    Friend WithEvents chkScanSubDir1 As CheckBox
    Friend WithEvents lblScanPath1 As Label
    Friend WithEvents txtScanPath1 As TextBox
    Friend WithEvents btnScanPath1 As Button
    Private WithEvents lblFilterApp1 As Label
    Private WithEvents txtApplication1Filter As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents grpApp1 As GroupBox
    Private WithEvents txtApplication1Arguments As TextBox
    Private WithEvents txtApplication1 As TextBox
    Friend WithEvents lblApp1 As Label
    Private WithEvents btnApplication1 As Button
    Private WithEvents lblArgumentApp1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Private WithEvents txtApplication2Arguments As TextBox
    Private WithEvents txtApplication2 As TextBox
    Friend WithEvents Label3 As Label
    Private WithEvents btnApplication2 As Button
    Private WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkScanSubDir2 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtScanPath2 As TextBox
    Friend WithEvents btnScanPath2 As Button
    Private WithEvents Label2 As Label
    Private WithEvents txtApplication2Filter As TextBox
    Friend WithEvents chkPhotolineArtguments As CheckBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DateiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KonfigurationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HintergrundAuswahlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents BeendenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HilfeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÜberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents picPreview As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents chkPhotolineArtguments2 As CheckBox
End Class
