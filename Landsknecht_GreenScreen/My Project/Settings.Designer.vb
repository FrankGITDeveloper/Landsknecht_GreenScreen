﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Dieser Code wurde von einem Tool generiert.
'     Laufzeitversion:4.0.30319.34209
'
'     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
'     der Code erneut generiert wird.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0"),  _
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
        Public Property setPhotolineArguments() As String
            Get
                Return CType(Me("setPhotolineArguments"),String)
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
         Global.System.Configuration.DefaultSettingValueAttribute("Q")>  _
        Public Property setBackgroundImageSuffixQ() As String
            Get
                Return CType(Me("setBackgroundImageSuffixQ"),String)
            End Get
            Set
                Me("setBackgroundImageSuffixQ") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Background")>  _
        Public Property setBackgroundImagePrefix() As String
            Get
                Return CType(Me("setBackgroundImagePrefix"),String)
            End Get
            Set
                Me("setBackgroundImagePrefix") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("H")>  _
        Public Property setBackgroundImageSuffixH() As String
            Get
                Return CType(Me("setBackgroundImageSuffixH"),String)
            End Get
            Set
                Me("setBackgroundImageSuffixH") = value
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
