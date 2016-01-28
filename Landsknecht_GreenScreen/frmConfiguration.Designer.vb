<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguration
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtBackgrundImageFileFormat = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtPLAktion2 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtThumbnailSuffix = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnBackgroundImageDir = New System.Windows.Forms.Button()
        Me.txtBackgroundImagePath = New System.Windows.Forms.TextBox()
        Me.lblBackgroundImagePath = New System.Windows.Forms.Label()
        Me.txtPLAktion1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBackground20 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtBackground19 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtBackground18 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtBackground17 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtBackground16 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtBackground15 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtBackground14 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtBackground13 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtBackground12 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtBackground11 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBackground10 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBackground9 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBackground8 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBackground7 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBackground6 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBackground5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBackground4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBackground3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBackground2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBackground1 = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.btnBackgroundColorActive1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 11)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(793, 342)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnBackgroundColorActive1)
        Me.TabPage1.Controls.Add(Me.txtBackgrundImageFileFormat)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.txtPLAktion2)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.txtThumbnailSuffix)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.btnBackgroundImageDir)
        Me.TabPage1.Controls.Add(Me.txtBackgroundImagePath)
        Me.TabPage1.Controls.Add(Me.lblBackgroundImagePath)
        Me.TabPage1.Controls.Add(Me.txtPLAktion1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(785, 316)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Standard Einstellungen"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtBackgrundImageFileFormat
        '
        Me.txtBackgrundImageFileFormat.Location = New System.Drawing.Point(9, 250)
        Me.txtBackgrundImageFileFormat.Name = "txtBackgrundImageFileFormat"
        Me.txtBackgrundImageFileFormat.Size = New System.Drawing.Size(430, 20)
        Me.txtBackgrundImageFileFormat.TabIndex = 34
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 233)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(135, 13)
        Me.Label24.TabIndex = 33
        Me.Label24.Text = "Hintergrundbild Dateiformat"
        '
        'txtPLAktion2
        '
        Me.txtPLAktion2.Location = New System.Drawing.Point(9, 80)
        Me.txtPLAktion2.Name = "txtPLAktion2"
        Me.txtPLAktion2.Size = New System.Drawing.Size(430, 20)
        Me.txtPLAktion2.TabIndex = 32
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 63)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(173, 13)
        Me.Label23.TabIndex = 31
        Me.Label23.Text = "Name der Photoline Aktion Event 2"
        '
        'txtThumbnailSuffix
        '
        Me.txtThumbnailSuffix.Location = New System.Drawing.Point(9, 200)
        Me.txtThumbnailSuffix.Name = "txtThumbnailSuffix"
        Me.txtThumbnailSuffix.Size = New System.Drawing.Size(430, 20)
        Me.txtThumbnailSuffix.TabIndex = 30
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 183)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(304, 13)
        Me.Label22.TabIndex = 29
        Me.Label22.Text = "Thumbnail Suffix (zum einlesen in Hintergrund Auswahlformular)"
        '
        'btnBackgroundImageDir
        '
        Me.btnBackgroundImageDir.Location = New System.Drawing.Point(453, 154)
        Me.btnBackgroundImageDir.Name = "btnBackgroundImageDir"
        Me.btnBackgroundImageDir.Size = New System.Drawing.Size(26, 19)
        Me.btnBackgroundImageDir.TabIndex = 28
        Me.btnBackgroundImageDir.Text = "..."
        Me.btnBackgroundImageDir.UseVisualStyleBackColor = True
        '
        'txtBackgroundImagePath
        '
        Me.txtBackgroundImagePath.Location = New System.Drawing.Point(9, 154)
        Me.txtBackgroundImagePath.Name = "txtBackgroundImagePath"
        Me.txtBackgroundImagePath.Size = New System.Drawing.Size(430, 20)
        Me.txtBackgroundImagePath.TabIndex = 27
        '
        'lblBackgroundImagePath
        '
        Me.lblBackgroundImagePath.AutoSize = True
        Me.lblBackgroundImagePath.Location = New System.Drawing.Point(6, 137)
        Me.lblBackgroundImagePath.Name = "lblBackgroundImagePath"
        Me.lblBackgroundImagePath.Size = New System.Drawing.Size(162, 13)
        Me.lblBackgroundImagePath.TabIndex = 26
        Me.lblBackgroundImagePath.Text = "Verzeichnis der Hintergrundbilder"
        '
        'txtPLAktion1
        '
        Me.txtPLAktion1.Location = New System.Drawing.Point(9, 34)
        Me.txtPLAktion1.Name = "txtPLAktion1"
        Me.txtPLAktion1.Size = New System.Drawing.Size(430, 20)
        Me.txtPLAktion1.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Name der Photoline Aktion Event 1"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(785, 316)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Hintergrund Bilder"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtBackground20)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtBackground19)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtBackground18)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtBackground17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtBackground16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtBackground15)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtBackground14)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.txtBackground13)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.txtBackground12)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.txtBackground11)
        Me.GroupBox2.Location = New System.Drawing.Point(407, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 299)
        Me.GroupBox2.TabIndex = 88
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hintergrund im Querformat"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 265)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 13)
        Me.Label12.TabIndex = 87
        Me.Label12.Text = "Hintergrund 20"
        '
        'txtBackground20
        '
        Me.txtBackground20.Location = New System.Drawing.Point(90, 262)
        Me.txtBackground20.Name = "txtBackground20"
        Me.txtBackground20.Size = New System.Drawing.Size(250, 20)
        Me.txtBackground20.TabIndex = 86
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 239)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 13)
        Me.Label13.TabIndex = 85
        Me.Label13.Text = "Hintergrund 19"
        '
        'txtBackground19
        '
        Me.txtBackground19.Location = New System.Drawing.Point(90, 236)
        Me.txtBackground19.Name = "txtBackground19"
        Me.txtBackground19.Size = New System.Drawing.Size(250, 20)
        Me.txtBackground19.TabIndex = 84
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 213)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 13)
        Me.Label14.TabIndex = 83
        Me.Label14.Text = "Hintergrund 18"
        '
        'txtBackground18
        '
        Me.txtBackground18.Location = New System.Drawing.Point(90, 210)
        Me.txtBackground18.Name = "txtBackground18"
        Me.txtBackground18.Size = New System.Drawing.Size(250, 20)
        Me.txtBackground18.TabIndex = 82
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 187)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 13)
        Me.Label15.TabIndex = 81
        Me.Label15.Text = "Hintergrund 17"
        '
        'txtBackground17
        '
        Me.txtBackground17.Location = New System.Drawing.Point(90, 184)
        Me.txtBackground17.Name = "txtBackground17"
        Me.txtBackground17.Size = New System.Drawing.Size(250, 20)
        Me.txtBackground17.TabIndex = 80
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(10, 161)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 13)
        Me.Label16.TabIndex = 79
        Me.Label16.Text = "Hintergrund 16"
        '
        'txtBackground16
        '
        Me.txtBackground16.Location = New System.Drawing.Point(90, 158)
        Me.txtBackground16.Name = "txtBackground16"
        Me.txtBackground16.Size = New System.Drawing.Size(250, 20)
        Me.txtBackground16.TabIndex = 78
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(10, 135)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 13)
        Me.Label17.TabIndex = 77
        Me.Label17.Text = "Hintergrund 15"
        '
        'txtBackground15
        '
        Me.txtBackground15.Location = New System.Drawing.Point(90, 132)
        Me.txtBackground15.Name = "txtBackground15"
        Me.txtBackground15.Size = New System.Drawing.Size(250, 20)
        Me.txtBackground15.TabIndex = 76
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(10, 109)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(77, 13)
        Me.Label18.TabIndex = 75
        Me.Label18.Text = "Hintergrund 14"
        '
        'txtBackground14
        '
        Me.txtBackground14.Location = New System.Drawing.Point(90, 106)
        Me.txtBackground14.Name = "txtBackground14"
        Me.txtBackground14.Size = New System.Drawing.Size(250, 20)
        Me.txtBackground14.TabIndex = 74
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(10, 83)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(77, 13)
        Me.Label19.TabIndex = 73
        Me.Label19.Text = "Hintergrund 13"
        '
        'txtBackground13
        '
        Me.txtBackground13.Location = New System.Drawing.Point(90, 80)
        Me.txtBackground13.Name = "txtBackground13"
        Me.txtBackground13.Size = New System.Drawing.Size(250, 20)
        Me.txtBackground13.TabIndex = 72
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(10, 57)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(77, 13)
        Me.Label20.TabIndex = 71
        Me.Label20.Text = "Hintergrund 12"
        '
        'txtBackground12
        '
        Me.txtBackground12.Location = New System.Drawing.Point(90, 54)
        Me.txtBackground12.Name = "txtBackground12"
        Me.txtBackground12.Size = New System.Drawing.Size(250, 20)
        Me.txtBackground12.TabIndex = 70
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(10, 31)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(77, 13)
        Me.Label21.TabIndex = 69
        Me.Label21.Text = "Hintergrund 11"
        '
        'txtBackground11
        '
        Me.txtBackground11.Location = New System.Drawing.Point(90, 28)
        Me.txtBackground11.Name = "txtBackground11"
        Me.txtBackground11.Size = New System.Drawing.Size(250, 20)
        Me.txtBackground11.TabIndex = 68
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtBackground10)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtBackground9)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtBackground8)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtBackground7)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtBackground6)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtBackground5)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtBackground4)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtBackground3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtBackground2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtBackground1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 299)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hintergrund im Querformat"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 265)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 13)
        Me.Label11.TabIndex = 87
        Me.Label11.Text = "Hintergrund 10"
        '
        'txtBackground10
        '
        Me.txtBackground10.Location = New System.Drawing.Point(90, 262)
        Me.txtBackground10.Name = "txtBackground10"
        Me.txtBackground10.Size = New System.Drawing.Size(250, 20)
        Me.txtBackground10.TabIndex = 86
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 239)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 85
        Me.Label10.Text = "Hintergrund 9"
        '
        'txtBackground9
        '
        Me.txtBackground9.Location = New System.Drawing.Point(90, 236)
        Me.txtBackground9.Name = "txtBackground9"
        Me.txtBackground9.Size = New System.Drawing.Size(250, 20)
        Me.txtBackground9.TabIndex = 84
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 213)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 83
        Me.Label9.Text = "Hintergrund 8"
        '
        'txtBackground8
        '
        Me.txtBackground8.Location = New System.Drawing.Point(90, 210)
        Me.txtBackground8.Name = "txtBackground8"
        Me.txtBackground8.Size = New System.Drawing.Size(250, 20)
        Me.txtBackground8.TabIndex = 82
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 187)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "Hintergrund 7"
        '
        'txtBackground7
        '
        Me.txtBackground7.Location = New System.Drawing.Point(90, 184)
        Me.txtBackground7.Name = "txtBackground7"
        Me.txtBackground7.Size = New System.Drawing.Size(250, 20)
        Me.txtBackground7.TabIndex = 80
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Hintergrund 6"
        '
        'txtBackground6
        '
        Me.txtBackground6.Location = New System.Drawing.Point(90, 158)
        Me.txtBackground6.Name = "txtBackground6"
        Me.txtBackground6.Size = New System.Drawing.Size(250, 20)
        Me.txtBackground6.TabIndex = 78
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "Hintergrund 5"
        '
        'txtBackground5
        '
        Me.txtBackground5.Location = New System.Drawing.Point(90, 132)
        Me.txtBackground5.Name = "txtBackground5"
        Me.txtBackground5.Size = New System.Drawing.Size(250, 20)
        Me.txtBackground5.TabIndex = 76
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Hintergrund 4"
        '
        'txtBackground4
        '
        Me.txtBackground4.Location = New System.Drawing.Point(90, 106)
        Me.txtBackground4.Name = "txtBackground4"
        Me.txtBackground4.Size = New System.Drawing.Size(250, 20)
        Me.txtBackground4.TabIndex = 74
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Hintergrund 3"
        '
        'txtBackground3
        '
        Me.txtBackground3.Location = New System.Drawing.Point(90, 80)
        Me.txtBackground3.Name = "txtBackground3"
        Me.txtBackground3.Size = New System.Drawing.Size(250, 20)
        Me.txtBackground3.TabIndex = 72
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Hintergrund 2"
        '
        'txtBackground2
        '
        Me.txtBackground2.Location = New System.Drawing.Point(90, 54)
        Me.txtBackground2.Name = "txtBackground2"
        Me.txtBackground2.Size = New System.Drawing.Size(250, 20)
        Me.txtBackground2.TabIndex = 70
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Hintergrund 1"
        '
        'txtBackground1
        '
        Me.txtBackground1.Location = New System.Drawing.Point(90, 28)
        Me.txtBackground1.Name = "txtBackground1"
        Me.txtBackground1.Size = New System.Drawing.Size(250, 20)
        Me.txtBackground1.TabIndex = 68
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(678, 386)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(127, 31)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Änderungen &Speichern"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(523, 386)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(127, 31)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Änderungen &verwerfen"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnBackgroundColorActive1
        '
        Me.btnBackgroundColorActive1.Location = New System.Drawing.Point(555, 30)
        Me.btnBackgroundColorActive1.Name = "btnBackgroundColorActive1"
        Me.btnBackgroundColorActive1.Size = New System.Drawing.Size(153, 27)
        Me.btnBackgroundColorActive1.TabIndex = 35
        Me.btnBackgroundColorActive1.Text = "Event 1 Farbe"
        Me.btnBackgroundColorActive1.UseVisualStyleBackColor = True
        '
        'frmConfiguration
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(817, 425)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmConfiguration"
        Me.Text = "Einstellungen"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnBackgroundImageDir As Button
    Friend WithEvents txtBackgroundImagePath As TextBox
    Friend WithEvents lblBackgroundImagePath As Label
    Friend WithEvents txtPLAktion1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtBackground20 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtBackground19 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtBackground18 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtBackground17 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtBackground16 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtBackground15 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtBackground14 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtBackground13 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtBackground12 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtBackground11 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtBackground10 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBackground9 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBackground8 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtBackground7 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBackground6 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBackground5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBackground4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBackground3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBackground2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBackground1 As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtThumbnailSuffix As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtPLAktion2 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtBackgrundImageFileFormat As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents btnBackgroundColorActive1 As Button
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
