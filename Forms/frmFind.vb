Public Class frmFind

    Private Sub tbcnMain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbcnMain.SelectedIndexChanged
        Me.Text = tbcnMain.SelectedTab.Text & " - ProjectWords"

        If tbcnMain.SelectedIndex = 2 Then
            Me.Width = 325
            Me.Height = 125
            tbcnMain.Dock = DockStyle.Fill
            tbcnMain.Refresh()
        ElseIf tbcnMain.SelectedIndex = 1 Then
            Me.Width = 336
            Me.Height = 142
            tbcnMain.Dock = DockStyle.Fill
            tbcnMain.Refresh()
        ElseIf tbcnMain.SelectedIndex = 0 Then
            Me.Width = 336
            Me.Height = 125
            tbcnMain.Dock = DockStyle.Fill
            tbcnMain.Refresh()
        End If
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        SelectedRTB.Focus()
        SelectedRTB.SelectionStart = SelectedRTB.GetFirstCharIndexFromLine(udLine.Value - 1)
        SelectedRTB.SelectionLength = 0
        SelectedRTB.ScrollToCaret()
    End Sub

    Private Sub frmFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        udLine.Maximum = SelectedRTB.Lines.Length
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Static Start As Integer, Type As CompareMethod

        If txtFind.Text = "" Then Exit Sub

        If chkCase.Checked = True Then Type = CompareMethod.Binary Else Type = CompareMethod.Text
        If Start = 0 Then Start = 1 Else Start += 1

        Start = InStr(Start, SelectedRTB.Text, txtFind.Text, Type)
        If Start = 0 Then
            SelectedRTB.SelectionLength = 0
            MsgBox("No match found! Press 'Find' again to start from the top.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Find - ProjectWords")
            Exit Sub
        End If

        SelectedRTB.Select(Start - 1, txtFind.Text.Length)
        SelectedRTB.ScrollToCaret()
    End Sub

    Private Sub btnReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReplace.Click
        Static rStart As Integer, rType As CompareMethod

        If txtfReplace.Text = "" Then Exit Sub

        If chkrCase.Checked = True Then rType = CompareMethod.Binary Else rType = CompareMethod.Text
        If rStart = 0 Then rStart = 1 Else rStart += 1

        rStart = InStr(rStart, SelectedRTB.Text, txtfReplace.Text, rType)
        If rStart = 0 Then
            SelectedRTB.SelectionLength = 0
            MsgBox("No more matches found!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Replace - ProjectWords")
            Exit Sub
        End If

        SelectedRTB.Select(rStart - 1, txtfReplace.Text.Length)
        SelectedRTB.SelectedText = txtReplace.Text

        SelectedRTB.Select(rStart - 1, txtReplace.Text.Length)
        SelectedRTB.ScrollToCaret()
    End Sub

    Private Sub btnReplaceAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReplaceAll.Click
        If txtfReplace.Text = "" Then Exit Sub

        Dim theStart As Integer = 1, theType As CompareMethod, Counter As Integer = 0
        If chkrCase.Checked = True Then theType = CompareMethod.Binary Else theType = CompareMethod.Text

        Do
            theStart = InStr(theStart, SelectedRTB.Text, txtfReplace.Text, theType)
            If theStart Then
                SelectedRTB.Select(theStart - 1, txtfReplace.Text.Length)
                SelectedRTB.SelectedText = txtReplace.Text
                SelectedRTB.ScrollToCaret()
                Counter += 1
                theStart += txtfReplace.Text.Length
            Else
                Exit Do
            End If
        Loop While (True)

        MsgBox("No more matches! Replaced " & Counter & IIf(Counter = 1, " word.", " words."), MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Replace - ProjectWords")
    End Sub
End Class