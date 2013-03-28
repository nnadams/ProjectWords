Module RichTextBoxHandler
    Public Declare Function LockWindowUpdate Lib "user32" Alias "LockWindowUpdate" (ByVal hwndLock As Long) As Long

    Public WithEvents SelectedRTB As RichTextBox
    Public isHighlighted As Boolean = False

    Public Sub TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SelectedRTB.Modified = True
    End Sub

    Public Sub DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs)
        If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then e.Effect = DragDropEffects.All Else e.Effect = DragDropEffects.None
    End Sub
End Module