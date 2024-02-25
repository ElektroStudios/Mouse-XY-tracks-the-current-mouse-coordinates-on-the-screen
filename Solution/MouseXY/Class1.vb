' ***********************************************************************
' Author   : ElektroStudios
' Modified : 11-December-2015
' ***********************************************************************

#Region " Public Members Summary "

#Region " Constructors "

' WindowMagnetizer.New(IWin32Window)

#End Region

#Region " Properties "

' WindowMagnetizer.Handle As IntPtr
' WindowMagnetizer.OwnerWindow As IWin32Window
' WindowMagnetizer.Threshold As Integer
' WindowMagnetizer.Enabled As Boolean
' WindowMagnetizer.AllowOffscreen As Boolean

#End Region

#Region " Methods "

' WindowMagnetizer.Dispose()

#End Region

#End Region

#Region " Usage Examples "

'Private magnetizer As New WindowMagnetizer(Me) With
'    {
'        .Enabled = True,
'        .AllowOffscreen = True,
'        .Threshold = 30
'    }

#End Region

#Region " Option Statements "

Option Explicit On
Option Strict On
Option Infer Off

#End Region

#Region " Imports "

'Imports System.Linq
'Imports System.Drawing
Imports System.Runtime.InteropServices
'Imports System.Windows.Forms
'Imports DevCase.Win32
'Imports DevCase.Win32.Enums
'Imports DevCase.Win32.Structures
#If Not NETCOREAPP Then
'Imports DevCase.ProjectMigration
#Else
Imports System.Runtime.Versioning
#End If
#End Region

#Region " Window Magnetizer "

' ReSharper disable once CheckNamespace

Namespace DevCase.Core.Application.Forms

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Add magnetism to the edges of a window,
    ''' in this way, by bringing the window to a screen edge, the edge of the window adheres it to the edge of the screen.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <example> This is a code example.
    ''' <code language="VB.NET">
    ''' Private magnetizer As New WindowMagnetizer(Me) With
    '''     {
    '''         .Enabled = True,
    '''         .AllowOffscreen = True,
    '''         .Threshold = 30
    '''     }
    ''' </code>
    ''' </example>
    ''' ----------------------------------------------------------------------------------------------------
    Public Class WindowMagnetizer : Inherits NativeWindow : Implements IDisposable

#Region " Private Fields "

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Determines whether the owner window is being resized by one of its edges.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        Protected isResizing As Boolean

#End Region

#Region " Properties "

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Gets the window that owns this <see cref="WindowMagnetizer"/> instance.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <value>
        ''' The window.
        ''' </value>
        ''' ----------------------------------------------------------------------------------------------------
        Public Overridable ReadOnly Property OwnerWindow As IWin32Window
            <DebuggerStepThrough>
            Get
                Return Me.ownerWindowB
            End Get
        End Property
        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' ( Backing field )
        ''' The window that owns this <see cref="WindowMagnetizer"/> instance.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        Protected ownerWindowB As IWin32Window

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Gets the handle for the window that owns this <see cref="WindowMagnetizer"/> instance.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <value>
        ''' The handle.
        ''' </value>
        ''' ----------------------------------------------------------------------------------------------------
        Public Overridable Shadows ReadOnly Property Handle As IntPtr
            <DebuggerStepThrough>
            Get
                Return MyBase.Handle
            End Get
        End Property

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Gets or sets, in pixels, the minimum threshold that the magnetic window needs to dock it on the nearest window border.
        ''' <para></para>
        ''' (Default value is <c>20</c>))
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <value>
        ''' The minimum threshold that the magnetic window needs to dock it on the nearest window border.
        ''' </value>
        ''' ----------------------------------------------------------------------------------------------------
        Public Overridable Property Threshold As Integer
            <DebuggerStepThrough>
            Get
                Return Me.thresholdB
            End Get
            <DebuggerStepThrough>
            Set(value As Integer)
                Me.thresholdB = value
            End Set
        End Property
        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' ( Backing field )
        ''' The minimum threshold that the magnetic window needs to dock it on the nearest window border.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        Protected thresholdB As Integer

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Gets or sets a value indicating whether the magnetizer is enabled.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <value>
        ''' <see langword="True"/> if the magnetizer is enabled, otherwise, <see langword="False"/>.
        ''' </value>
        ''' ----------------------------------------------------------------------------------------------------
        Public Overridable Property Enabled As Boolean
            <DebuggerStepThrough>
            Get
                Return Me.enabledB
            End Get
            <DebuggerStepThrough>
            Set(value As Boolean)
                Me.enabledB = value
            End Set
        End Property
        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' ( Backing field )
        ''' A value indicating whether the magnetizer is enabled.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        Protected enabledB As Boolean

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Gets or sets a value indicating whether the window can be moved off-screen.
        ''' <para></para>
        ''' Default value is <see langword="True"/>.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <value>
        ''' <see langword="True"/> if the window can be moved off-screen, otherwise, <see langword="False"/>.
        ''' </value>
        ''' ----------------------------------------------------------------------------------------------------
        Public Overridable Property AllowOffscreen As Boolean
            <DebuggerStepThrough>
            Get
                Return Me.allowOffscreenB
            End Get
            <DebuggerStepThrough>
            Set(value As Boolean)
                Me.allowOffscreenB = value
            End Set
        End Property
        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' ( Backing field )
        ''' A value indicating whether the window can be moved off-screen.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        Protected allowOffscreenB As Boolean

#End Region

#Region " Constructors "

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Prevents a default instance of the <see cref="WindowMagnetizer"/> class from being created.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerNonUserCode>
        Private Sub New()
        End Sub

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Initializes a new instance of the <see cref="WindowMagnetizer"/> class.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="window">
        ''' The <see cref="IWin32Window"/> window that owns this instance (eg. a <see cref="Form"/> window).
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerStepThrough>
        Public Sub New(window As IWin32Window)

            Me.allowOffscreenB = True
            Me.thresholdB = 20
            Me.ownerWindowB = window

            MyBase.AssignHandle(window.Handle)

        End Sub

#End Region

#Region " Private Methods "

        ' For further implementation.
        '
        ' ''' ----------------------------------------------------------------------------------------------------
        ' ''' <summary>
        ' ''' If the margin between the specified <paramref name="window"/> 
        ' ''' and the nearest border of the active screeen is lower than the value specified in <paramref name="threshold"/>,
        ' ''' then it docks the window to the border. 
        ' ''' </summary>
        ' ''' ----------------------------------------------------------------------------------------------------
        ' ''' <param name="window">
        ' ''' The magnetic window.
        ' ''' </param>
        ' ''' 
        ' ''' <param name="windowPosHandle">
        ' ''' A pointer to a <see cref="DevCase.Win32.Structures.WindowPos"/> structure that contains the 
        ' ''' new size and position of the <paramref name="window"/>.
        ' ''' </param>
        ' ''' 
        ' ''' <param name="threshold">
        ' ''' The minimum threshold that the window needs to dock it on the nearest desktop border.
        ' ''' </param>
        ' ''' ----------------------------------------------------------------------------------------------------
        'Protected Overridable Sub DockToNearestWindowBorder(ByVal window As IWin32Window,
        '                                                    ByVal windowPosHandle As IntPtr,
        '                                                    ByVal threshold As Integer)

        '    Dim windowPos As WindowPos =
        '        CType(Marshal.PtrToStructure(windowPosHandle, GetType(WindowPos)), WindowPos)

        '    If (windowPos.Y = 0) OrElse (windowPos.X = 0) Then
        '        ' Nothing to do.
        '        Exit Sub
        '    End If

        '    ' Enumerate all the visible windows in the current desktop.
        '    Dim windows As New List(Of IntPtr)()
        '    Dim wpl As New WindowPlacement

        '    Dim callBack As EnumWindowsProc =
        '        Function(hwnd As IntPtr, lParam As IntPtr) As Boolean
        '            NativeMethods.GetWindowPlacement(hwnd, wpl)
        '            If (NativeMethods.IsWindowVisible(hwnd)) AndAlso
        '               (wpl.WindowState = NativeWindowState.Normal) Then
        '                windows.Add(hwnd)
        '            End If
        '            Return True
        '        End Function

        '    If (NativeMethods.EnumDesktopWindows(IntPtr.Zero, callBack, IntPtr.Zero)) Then

        '        ' Window rectangles
        '        Dim srcRect As Rectangle
        '        Dim tgtRect As Rectangle

        '        NativeMethods.GetWindowRect(window.Handle, srcRect)

        '        For Each hwnd As IntPtr In windows

        '            ' This is just for testing purposes.
        '            Dim pid As Integer
        '            NativeMethods.GetWindowThreadProcessId(hwnd, pid)
        '            If Process.GetProcessById(pid).ProcessName.EndsWith("vshost") Then
        '                Continue For
        '            End If

        '            NativeMethods.GetWindowRect(hwnd, tgtRect)


        '            '' Top border

        '            '' Left border

        '            ' Right border of the source window
        '            If ((windowPos.X + srcRect.Width) <= (tgtRect.Left + threshold)) AndAlso
        '               ((windowPos.X + srcRect.Width) >= (tgtRect.Left - threshold)) AndAlso
        '               ((windowPos.Y) <= (tgtRect.Y + tgtRect.Height)) AndAlso
        '               ((windowPos.Y + srcRect.Height) >= (tgtRect.Y)) Then

        '                Console.WriteLine("Window adhered to: " & Process.GetProcessById(pid).ProcessName)
        '                '  Console.WriteLine(GetZOrder(hwnd))

        '                windowPos.X = (tgtRect.Left - srcRect.Width)
        '                Exit For

        '                ' Console.WriteLine(hwnd)
        '                ' Console.WriteLine(NativeMethods.GetWindow(window.Handle, GetWindowCmd.HwndNext))
        '                If window.Handle.ToInt32 = NativeMethods.GetWindow(window.Handle, GetWindowCmd.HwndPrev).ToInt32 Then
        '                    windowPos.X = (tgtRect.Left - srcRect.Width)
        '                    Exit For

        '                End If

        '            End If

        '            '' Bottom border.


        '        Next hwnd

        '    End If

        '    ' Marshal it back.
        '    Marshal.StructureToPtr(structure:=windowPos, ptr:=windowPosHandle, fDeleteOld:=True)

        'End Sub

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' If the margin between the specified <paramref name="window"/> 
        ''' and the nearest border of the active screeen is lower than the value specified in <paramref name="threshold"/>,
        ''' then it docks the window to the border. 
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="window">
        ''' The magnetic window.
        ''' </param>
        ''' 
        ''' <param name="windowPosHandle">
        ''' A pointer to a <see cref="WindowPos"/> structure that contains the 
        ''' new size and position of the <paramref name="window"/>.
        ''' </param>
        ''' 
        ''' <param name="threshold">
        ''' The minimum threshold that the window needs to dock it on the nearest desktop border.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        Protected Overridable Sub DockToNearestScreenBorder(window As IWin32Window,
                                                            windowPosHandle As IntPtr,
                                                            Optional threshold As Integer = 0I)

            ' Deprecated.
            ' Dim workingArea As Rectangle = Rectangle.Empty
            ' Screen.AllScreens.ToList.ForEach(
            '     Sub(scr As Screen)
            '         workingArea = Rectangle.Union(workingArea, scr.WorkingArea)
            '     End Sub)

            Dim workingArea As Rectangle = Screen.FromHandle(window.Handle).WorkingArea ' Active screen.
            workingArea.Width = 0
            workingArea.Height = 0

            Screen.AllScreens.ToList.ForEach(
                Sub(scr As Screen)
                    workingArea.Width += scr.WorkingArea.Width
                    workingArea.Height += scr.WorkingArea.Height
                End Sub)

            Dim windowPos As WindowPos =
                DirectCast(Marshal.PtrToStructure(windowPosHandle, GetType(WindowPos)), WindowPos)

            If (windowPos.Y = 0) OrElse (windowPos.X = 0) Then
                ' Nothing to do.
                Exit Sub
            End If

            Dim win32Rect As NativeRectangle
            Dim rect As Rectangle
            GetWindowRect(window.Handle, win32Rect)
            rect = New Rectangle(win32Rect.Left, win32Rect.Top, win32Rect.Right - win32Rect.Left, win32Rect.Bottom - win32Rect.Top)

            ' Top border
            If ((windowPos.Y >= -threshold) AndAlso
               (workingArea.Y > 0) AndAlso (windowPos.Y <= (threshold + workingArea.Y))) _
            OrElse ((workingArea.Y <= 0) AndAlso (windowPos.Y <= threshold)) Then

                windowPos.Y = workingArea.Y

            End If

            ' Left border
            If (windowPos.X >= (workingArea.X - threshold)) AndAlso
               (windowPos.X <= (workingArea.X + threshold)) Then

                windowPos.X = workingArea.X

            ElseIf (windowPos.X <= (workingArea.X - threshold)) AndAlso
                   Not Me.allowOffscreenB Then

                windowPos.X = workingArea.X

            End If

            ' Right border.
            If ((windowPos.X + rect.Width) <= (workingArea.Right + threshold)) AndAlso
               ((windowPos.X + rect.Width) >= (workingArea.Right - threshold)) Then

                windowPos.X = workingArea.Right - rect.Width

            ElseIf ((windowPos.X + rect.Width) >= (workingArea.Right + threshold)) AndAlso
                   Not Me.allowOffscreenB Then

                windowPos.X = workingArea.Right - rect.Width

            End If

            ' Bottom border.
            If ((windowPos.Y + rect.Height) <= (workingArea.Bottom + threshold)) AndAlso
               ((windowPos.Y + rect.Height) >= (workingArea.Bottom - threshold)) Then

                windowPos.Y = workingArea.Bottom - rect.Height

            ElseIf ((windowPos.Y + rect.Height) >= (workingArea.Bottom + threshold)) AndAlso
                   Not Me.allowOffscreenB Then

                windowPos.Y = workingArea.Bottom - rect.Height

            End If

            ' Marshal it back.
            Marshal.StructureToPtr(structure:=windowPos, ptr:=windowPosHandle, fDeleteOld:=True)

        End Sub

#End Region

#Region " Window Procedure (WndProc) "

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Invokes the default window procedure associated with this window to process windows messages.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="m">
        ''' A <see cref="Message"/> that is associated with the current Windows message.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerStepThrough>
        Protected Overrides Sub WndProc(ByRef m As Message)

            Select Case m.Msg

                Case &H214 ' WindowMessages.WM_Sizing
                    Me.isResizing = True

                Case &H232 ' WindowMessages.WM_ExitSizeMove
                    Me.isResizing = False

                Case &H46 'WindowMessages.WM_WindowPosChanging
                    If Not Me.isResizing AndAlso Me.enabledB Then
                        Me.DockToNearestScreenBorder(window:=Me.ownerWindowB,
                                                     windowPosHandle:=m.LParam,
                                                     threshold:=Me.thresholdB)

                        ' For further implementation.
                        '
                        'Me.DockToNearestWindowBorder(window:=Me.ownerWindowB,
                        '     windowPosHandle:=m.LParam,
                        '     threshold:=Me.thresholdB)

                    End If

            End Select

            MyBase.WndProc(m)

        End Sub

#End Region

#Region " IDisposable Implementation "

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Flag to detect redundant calls when disposing.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        Protected isDisposed As Boolean

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Releases all the resources used by this instance.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerStepThrough>
        Public Sub Dispose() Implements IDisposable.Dispose

            Me.Dispose(isDisposing:=True)
            GC.SuppressFinalize(Me)

        End Sub

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        ''' Releases unmanaged and, optionally, managed resources.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="isDisposing">
        ''' <see langword="True"/>  to release both managed and unmanaged resources; 
        ''' <see langword="False"/> to release only unmanaged resources.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerStepThrough>
        Protected Overridable Sub Dispose(isDisposing As Boolean)

            If (Not Me.isDisposed) AndAlso isDisposing Then

                With Me
                    .enabledB = False
                    .AllowOffscreen = True
                    .thresholdB = 0
                End With

                MyBase.ReleaseHandle()
                MyBase.DestroyHandle()

            End If

            Me.isDisposed = True

        End Sub

#End Region

#Region " P/Invokes "

        <DllImport("user32.dll")>
        Private Shared Function GetWindowRect(hWnd As IntPtr, ByRef lpRect As NativeRectangle) As Boolean
        End Function

        <StructLayout(LayoutKind.Sequential)>
        Private Structure NativeRectangle
            Public Left As Integer
            Public Top As Integer
            Public Right As Integer
            Public Bottom As Integer
        End Structure

        <StructLayout(LayoutKind.Sequential)>
        Private Structure WINDOWPOS
            Public hwnd As IntPtr
            Public hwndInsertAfter As IntPtr
            Public x As Integer
            Public y As Integer
            Public cx As Integer
            Public cy As Integer
            Public flags As UInteger
        End Structure

#End Region

    End Class

End Namespace

#End Region
