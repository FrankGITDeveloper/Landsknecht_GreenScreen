﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Dieser Code wurde von einem Tool generiert.
'     Laufzeitversion:4.0.30319.42000
'
'     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
'     der Code erneut generiert wird.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "Funktion zum automatischen Speichern von My.Settings"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("D:\Eye-Fi")>  _
        Public Property setScanPath1() As String
            Get
                Return CType(Me("setScanPath1"),String)
            End Get
            Set
                Me("setScanPath1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property setSubFolders1() As Boolean
            Get
                Return CType(Me("setSubFolders1"),Boolean)
            End Get
            Set
                Me("setSubFolders1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("D:\PortableApps\Photoline\PhotoLine64.exe")>  _
        Public Property setApplication1() As String
            Get
                Return CType(Me("setApplication1"),String)
            End Get
            Set
                Me("setApplication1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setApplication2() As String
            Get
                Return CType(Me("setApplication2"),String)
            End Get
            Set
                Me("setApplication2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setApplication1Filter() As String
            Get
                Return CType(Me("setApplication1Filter"),String)
            End Get
            Set
                Me("setApplication1Filter") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setApplication2Filter() As String
            Get
                Return CType(Me("setApplication2Filter"),String)
            End Get
            Set
                Me("setApplication2Filter") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setApplication1Argument() As String
            Get
                Return CType(Me("setApplication1Argument"),String)
            End Get
            Set
                Me("setApplication1Argument") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setApplication2Argument() As String
            Get
                Return CType(Me("setApplication2Argument"),String)
            End Get
            Set
                Me("setApplication2Argument") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Control")>  _
        Public Property setBackgroundColorInactive() As Global.System.Drawing.Color
            Get
                Return CType(Me("setBackgroundColorInactive"),Global.System.Drawing.Color)
            End Get
            Set
                Me("setBackgroundColorInactive") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Lime")>  _
        Public Property setBackgroundColorActive1() As Global.System.Drawing.Color
            Get
                Return CType(Me("setBackgroundColorActive1"),Global.System.Drawing.Color)
            End Get
            Set
                Me("setBackgroundColorActive1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property setPositionX() As Integer
            Get
                Return CType(Me("setPositionX"),Integer)
            End Get
            Set
                Me("setPositionX") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property setPositionY() As Integer
            Get
                Return CType(Me("setPositionY"),Integer)
            End Get
            Set
                Me("setPositionY") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setScanPath2() As String
            Get
                Return CType(Me("setScanPath2"),String)
            End Get
            Set
                Me("setScanPath2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property setSubFolders2() As Boolean
            Get
                Return CType(Me("setSubFolders2"),Boolean)
            End Get
            Set
                Me("setSubFolders2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("128, 255, 128")>  _
        Public Property setBackgroundColorActive2() As Global.System.Drawing.Color
            Get
                Return CType(Me("setBackgroundColorActive2"),Global.System.Drawing.Color)
            End Get
            Set
                Me("setBackgroundColorActive2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property setPhotolineArguments() As Boolean
            Get
                Return CType(Me("setPhotolineArguments"),Boolean)
            End Get
            Set
                Me("setPhotolineArguments") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("D:\Eye-Fi\Hintergründe_GreenScreen")>  _
        Public Property setBackgroundImagePath() As String
            Get
                Return CType(Me("setBackgroundImagePath"),String)
            End Get
            Set
                Me("setBackgroundImagePath") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Thumbnail")>  _
        Public Property setThumbnailImageSuffix() As String
            Get
                Return CType(Me("setThumbnailImageSuffix"),String)
            End Get
            Set
                Me("setThumbnailImageSuffix") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("GreenScreenKomplett")>  _
        Public Property setPLAktion1() As String
            Get
                Return CType(Me("setPLAktion1"),String)
            End Get
            Set
                Me("setPLAktion1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setPLAktion2() As String
            Get
                Return CType(Me("setPLAktion2"),String)
            End Get
            Set
                Me("setPLAktion2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setBackground1() As String
            Get
                Return CType(Me("setBackground1"),String)
            End Get
            Set
                Me("setBackground1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setBackground2() As String
            Get
                Return CType(Me("setBackground2"),String)
            End Get
            Set
                Me("setBackground2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setBackground3() As String
            Get
                Return CType(Me("setBackground3"),String)
            End Get
            Set
                Me("setBackground3") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setBackground4() As String
            Get
                Return CType(Me("setBackground4"),String)
            End Get
            Set
                Me("setBackground4") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setBackground5() As String
            Get
                Return CType(Me("setBackground5"),String)
            End Get
            Set
                Me("setBackground5") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setBackground6() As String
            Get
                Return CType(Me("setBackground6"),String)
            End Get
            Set
                Me("setBackground6") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setBackground7() As String
            Get
                Return CType(Me("setBackground7"),String)
            End Get
            Set
                Me("setBackground7") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setBackground8() As String
            Get
                Return CType(Me("setBackground8"),String)
            End Get
            Set
                Me("setBackground8") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setBackground9() As String
            Get
                Return CType(Me("setBackground9"),String)
            End Get
            Set
                Me("setBackground9") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setBackground10() As String
            Get
                Return CType(Me("setBackground10"),String)
            End Get
            Set
                Me("setBackground10") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setBackground11() As String
            Get
                Return CType(Me("setBackground11"),String)
            End Get
            Set
                Me("setBackground11") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setBackground12() As String
            Get
                Return CType(Me("setBackground12"),String)
            End Get
            Set
                Me("setBackground12") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setBackground13() As String
            Get
                Return CType(Me("setBackground13"),String)
            End Get
            Set
                Me("setBackground13") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setBackground14() As String
            Get
                Return CType(Me("setBackground14"),String)
            End Get
            Set
                Me("setBackground14") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setBackground15() As String
            Get
                Return CType(Me("setBackground15"),String)
            End Get
            Set
                Me("setBackground15") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setBackground16() As String
            Get
                Return CType(Me("setBackground16"),String)
            End Get
            Set
                Me("setBackground16") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setBackground17() As String
            Get
                Return CType(Me("setBackground17"),String)
            End Get
            Set
                Me("setBackground17") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("JPG")>  _
        Public Property setBackgroundImageFileFormat() As String
            Get
                Return CType(Me("setBackgroundImageFileFormat"),String)
            End Get
            Set
                Me("setBackgroundImageFileFormat") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setTempBackgroundImage() As String
            Get
                Return CType(Me("setTempBackgroundImage"),String)
            End Get
            Set
                Me("setTempBackgroundImage") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setTempBackgroundImagePreview() As String
            Get
                Return CType(Me("setTempBackgroundImagePreview"),String)
            End Get
            Set
                Me("setTempBackgroundImagePreview") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property setPhotolineArguments2() As Boolean
            Get
                Return CType(Me("setPhotolineArguments2"),Boolean)
            End Get
            Set
                Me("setPhotolineArguments2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setBackgroundThumbnail1() As String
            Get
                Return CType(Me("setBackgroundThumbnail1"),String)
            End Get
            Set
                Me("setBackgroundThumbnail1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setBackgroundThumbnail2() As String
            Get
                Return CType(Me("setBackgroundThumbnail2"),String)
            End Get
            Set
                Me("setBackgroundThumbnail2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setBackgroundThumbnail3() As String
            Get
                Return CType(Me("setBackgroundThumbnail3"),String)
            End Get
            Set
                Me("setBackgroundThumbnail3") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setBackgroundThumbnail4() As String
            Get
                Return CType(Me("setBackgroundThumbnail4"),String)
            End Get
            Set
                Me("setBackgroundThumbnail4") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setBackgroundThumbnail5() As String
            Get
                Return CType(Me("setBackgroundThumbnail5"),String)
            End Get
            Set
                Me("setBackgroundThumbnail5") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setBackgroundThumbnail6() As String
            Get
                Return CType(Me("setBackgroundThumbnail6"),String)
            End Get
            Set
                Me("setBackgroundThumbnail6") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setBackgroundThumbnail7() As String
            Get
                Return CType(Me("setBackgroundThumbnail7"),String)
            End Get
            Set
                Me("setBackgroundThumbnail7") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setBackgroundThumbnail8() As String
            Get
                Return CType(Me("setBackgroundThumbnail8"),String)
            End Get
            Set
                Me("setBackgroundThumbnail8") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setBackgroundThumbnail9() As String
            Get
                Return CType(Me("setBackgroundThumbnail9"),String)
            End Get
            Set
                Me("setBackgroundThumbnail9") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setBackgroundThumbnail10() As String
            Get
                Return CType(Me("setBackgroundThumbnail10"),String)
            End Get
            Set
                Me("setBackgroundThumbnail10") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setBackgroundThumbnail11() As String
            Get
                Return CType(Me("setBackgroundThumbnail11"),String)
            End Get
            Set
                Me("setBackgroundThumbnail11") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setBackgroundThumbnail12() As String
            Get
                Return CType(Me("setBackgroundThumbnail12"),String)
            End Get
            Set
                Me("setBackgroundThumbnail12") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setBackgroundThumbnail13() As String
            Get
                Return CType(Me("setBackgroundThumbnail13"),String)
            End Get
            Set
                Me("setBackgroundThumbnail13") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setBackgroundThumbnail14() As String
            Get
                Return CType(Me("setBackgroundThumbnail14"),String)
            End Get
            Set
                Me("setBackgroundThumbnail14") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setBackgroundThumbnail15() As String
            Get
                Return CType(Me("setBackgroundThumbnail15"),String)
            End Get
            Set
                Me("setBackgroundThumbnail15") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setBackgroundThumbnail16() As String
            Get
                Return CType(Me("setBackgroundThumbnail16"),String)
            End Get
            Set
                Me("setBackgroundThumbnail16") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property setBackgroundThumbnail17() As String
            Get
                Return CType(Me("setBackgroundThumbnail17"),String)
            End Get
            Set
                Me("setBackgroundThumbnail17") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property setLoadLastBackgroundOnStart() As Boolean
            Get
                Return CType(Me("setLoadLastBackgroundOnStart"),Boolean)
            End Get
            Set
                Me("setLoadLastBackgroundOnStart") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.Landsknecht_GreenScreen.My.MySettings
            Get
                Return Global.Landsknecht_GreenScreen.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
