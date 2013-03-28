Imports System
Imports System.Text
Imports System.Drawing.Printing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Drawing

Public Class RichTextBoxPrinter
    '--- P/Invoke declarations
    <StructLayout(LayoutKind.Sequential)> _
    Private Structure CHARRANGE
        Public cpMin As Integer
        Public cpMax As Integer
    End Structure

    <StructLayout(LayoutKind.Sequential)> _
    Private Structure RECT
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer
    End Structure

    <StructLayout(LayoutKind.Sequential)> _
    Private Structure FORMATRANGE
        Public hdc As IntPtr
        Public hdcTarget As IntPtr
        Public rc As RECT
        Public rcPage As RECT
        Public chrg As CHARRANGE
    End Structure

    Private Const WM_USER As Integer = &H400
    Private Const EM_FORMATRANGE As Integer = WM_USER + 57
    Private Const Hundredth2Twips As Integer = 20 * 72 \ 100

    Private Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wp As IntPtr, ByVal lp As IntPtr) As IntPtr

    Public Shared Function Print(ByVal box As RichTextBox, ByRef charFrom As Integer, ByVal e As PrintPageEventArgs) As Integer
        '--- Prints text in <box>, starting at <charFrom>.  Returns <true> if more pages are needed
        If box.Text.Length = 0 Then Return False
        Dim fmtRange As FORMATRANGE
        '--- Allocate device context for output device
        Dim hdc As IntPtr = e.Graphics.GetHdc()
        fmtRange.hdc = hdc
        fmtRange.hdcTarget = hdc
        '--- Set printable area, converted from 0.01" to twips
        fmtRange.rc.Top = Convert.ToInt32(e.MarginBounds.Top * Hundredth2Twips)
        fmtRange.rc.Bottom = Convert.ToInt32(e.MarginBounds.Bottom * Hundredth2Twips)
        fmtRange.rc.Left = Convert.ToInt32(e.MarginBounds.Left * Hundredth2Twips)
        fmtRange.rc.Right = Convert.ToInt32(e.MarginBounds.Right * Hundredth2Twips)
        '--- Set page area, converted from 0.01" to twips
        fmtRange.rcPage.Top = Convert.ToInt32(e.PageBounds.Top * Hundredth2Twips)
        fmtRange.rcPage.Bottom = Convert.ToInt32(e.PageBounds.Bottom * Hundredth2Twips)
        fmtRange.rcPage.Left = Convert.ToInt32(e.PageBounds.Left * Hundredth2Twips)
        fmtRange.rcPage.Right = Convert.ToInt32(e.PageBounds.Right * Hundredth2Twips)
        '--- Set character range to print
        fmtRange.chrg.cpMin = charFrom
        fmtRange.chrg.cpMax = box.TextLength
        '--- Marshal to unmanaged memory
        Dim hdlRange As IntPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf(fmtRange))
        Marshal.StructureToPtr(fmtRange, hdlRange, False)
        '--- Send RichTextBox the EM_FORMATRANGE message to print the text
        Dim res As IntPtr = SendMessage(box.Handle, EM_FORMATRANGE, CType(1, IntPtr), hdlRange)
        Dim err As Integer = Marshal.GetLastWin32Error()
        '--- Release resources
        Marshal.FreeCoTaskMem(hdlRange)
        e.Graphics.ReleaseHdc(hdc)
        '--- Throw exception on error so we don't endlessly print an empty page
        If (res = IntPtr.Zero) Then Throw New ApplicationException(String.Format("Printing failed, error code={0}", err))
        '--- Update <charFrom> to next character to print, return <true> if more pages needed
        charFrom = res.ToInt32()
        Return IIf(charFrom < box.TextLength, charFrom, 0)
    End Function
End Class
