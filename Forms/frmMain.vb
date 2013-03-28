Public Class frmMain
#Region "Private Declares"
    Private tabNumber As Long = 0, isOverX As Boolean, DragStartPosition As Point = Point.Empty
    Private cFrom As Integer = 0
    Private PrettyTabs As Boolean
#End Region
#Region "Events"
#Region "frmMain"
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If My.Settings.PrettyTabs Then tbcnMain.DrawMode = TabDrawMode.Normal
            If My.Application.CommandLineArgs.Count <> 0 Then
                For Each arg As String In My.Application.CommandLineArgs
                    AddTab()
                    If Strings.Right(arg, 3) = "rtf" Then
                        SelectedRTB.LoadFile(arg)
                        SelectedRTB.Tag = arg
                        tbcnMain.SelectedTab.Text = " " & RemovePath(arg)
                        Me.Text = RemovePath(arg) & " - ProjectWords"
                        nticoMain.Text = Me.Text
                    Else
                        SelectedRTB.Text = My.Computer.FileSystem.ReadAllText(arg)
                        SelectedRTB.Tag = arg
                        tbcnMain.SelectedTab.Text = " " & RemovePath(arg)
                        Me.Text = RemovePath(arg) & " - ProjectWords"
                        nticoMain.Text = Me.Text
                    End If
                    stsLabel.Text = "Loaded file: " & arg
                Next
            Else
                AddTab(True)
                stsLabel.Text = "Ready"
            End If

            CheckForPlugins()
        Catch ex As Exception
            My.Application.Log.DefaultFileLogWriter.Location = Logging.LogFileLocation.Custom
            My.Application.Log.DefaultFileLogWriter.CustomLocation = My.Computer.FileSystem.SpecialDirectories.Desktop
            My.Application.Log.WriteException(ex)
            MsgBox("Opps! It looks like there was the following error: " & vbCrLf & vbCrLf & ex.Message & vbCrLf & vbCrLf & "This error was logged!", MsgBoxStyle.Critical, "Error - ProjectWords")
        End Try
    End Sub

    Private Sub frmMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized AndAlso mnuView_MinimizetoTaskbar.Checked = True Then
            Me.Visible = False
            nticoMain.Visible = True
            nticoMain.Text = tbcnMain.SelectedTab.Text & " - ProjectWords"
        End If
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        mnuFile_Exit_Click(sender, e)
    End Sub
#End Region
#Region "Tabs"
    Private Sub tbcnMain_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles tbcnMain.DrawItem
        Dim Fmt1 As New StringFormat, Fmt2 As New StringFormat
        Fmt1.LineAlignment = StringAlignment.Center
        Fmt1.Alignment = StringAlignment.Near

        Fmt2.LineAlignment = StringAlignment.Center
        Fmt2.Alignment = StringAlignment.Far

        If e.Index = tbcnMain.SelectedIndex Then
            e.Graphics.FillRectangle(Brushes.Transparent, e.Bounds)
            e.Graphics.DrawString(tbcnMain.TabPages(e.Index).Text, tbcnMain.Font, Brushes.Blue, e.Bounds, Fmt1)
        Else
            e.Graphics.DrawString(tbcnMain.TabPages(e.Index).Text, tbcnMain.Font, Brushes.Black, e.Bounds, Fmt1)
        End If

        If Not My.Settings.Xs Then Exit Sub

        Dim R As New Rectangle(e.Bounds.Right - 11, e.Bounds.Y + 8, 10, e.Bounds.Height - 15)
        If e.Index = tbcnMain.SelectedIndex Then
            If isOverX Then
                e.Graphics.FillRectangle(Brushes.Transparent, R)
                e.Graphics.DrawString("X", tbcnMain.Font, Brushes.Red, R, Fmt2)
            Else
                e.Graphics.DrawString("X", tbcnMain.Font, Brushes.Black, R, Fmt2)
            End If
        End If
    End Sub

    Private Sub tbcnMain_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbcnMain.MouseLeave
        If Not My.Settings.Xs Then Exit Sub
        If isOverX Then
            isOverX = False
            tbcnMain.Invalidate()
        End If
    End Sub

    Private Sub tbcnMain_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbcnMain.MouseMove
        If Not My.Settings.Xs And e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        Dim R As Rectangle
        Dim TabNumber As Integer

        For count As Integer = 0 To tbcnMain.TabPages.Count - 1
            R = tbcnMain.GetTabRect(count)
            If R.Contains(e.Location) Then
                TabNumber = count
                Exit For
            End If
        Next

        Dim R1 As New Rectangle(R.Right - 11, R.Y, 10, R.Height)
        If TabNumber <> tbcnMain.SelectedIndex Then
            If isOverX Then
                isOverX = False
                tbcnMain.Invalidate(R1)
            End If
            Exit Sub
        End If

        If R1.Contains(e.Location) Then
            If Not isOverX Then
                isOverX = True
                tbcnMain.Invalidate(R1)
            End If
        Else
            If isOverX Then
                isOverX = False
                tbcnMain.Invalidate(R1)
            End If
        End If

        If e.Button <> MouseButtons.Left Then Exit Sub

        R = New Rectangle(DragStartPosition, Size.Empty)
        R.Inflate(SystemInformation.DragSize)

        Dim tp As TabPage = HoverTab()

        If Not tp Is Nothing Then
            If Not R.Contains(e.X, e.Y) Then
                tbcnMain.DoDragDrop(tp, DragDropEffects.All)
            End If
        End If

        DragStartPosition = Point.Empty
    End Sub

    Private Sub tbcnMain_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbcnMain.MouseClick
        Try
            If (isOverX AndAlso e.Button = Windows.Forms.MouseButtons.Left) Or e.Button = Windows.Forms.MouseButtons.Middle Then
                If e.Button = Windows.Forms.MouseButtons.Middle Then tbcnMain.SelectTab(HoverTab)
                If SelectedRTB.Modified = True Then
                    Select Case MsgBox("You haven't saved your work in this tab. Do you want to save?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Exclamation, "Unsaved Work - ProjectWords")
                        Case MsgBoxResult.Yes
                            mnuFile_Save_Click(sender, e)
                            If tbcnMain.TabPages.Count = 1 Then
                                tbcnMain.SelectedTab.Text = IIf(Not My.Settings.PrettyTabs, " ", "") & "Untitled" & tabNumber
                                tabNumber += 1
                                SelectedRTB.Clear()
                                tbcnMain_SelectedIndexChanged(sender, e)
                            Else
                                tbcnMain.TabPages.Remove(tbcnMain.SelectedTab)
                                tbcnMain_SelectedIndexChanged(sender, e)
                            End If
                        Case MsgBoxResult.No
                            If tbcnMain.TabPages.Count = 1 Then
                                tbcnMain.SelectedTab.Text = IIf(Not My.Settings.PrettyTabs, " ", "") & "Untitled" & tabNumber
                                tabNumber += 1
                                SelectedRTB.Clear()
                                tbcnMain_SelectedIndexChanged(sender, e)
                            Else
                                tbcnMain.TabPages.Remove(tbcnMain.SelectedTab)
                                tbcnMain_SelectedIndexChanged(sender, e)
                            End If
                        Case Else
                            Exit Sub
                    End Select
                Else
                    If tbcnMain.TabPages.Count = 1 Then
                        tbcnMain.SelectedTab.Text = IIf(Not My.Settings.PrettyTabs, " ", "") & "Untitled" & tabNumber
                        tabNumber += 1
                        SelectedRTB.Clear()
                        tbcnMain_SelectedIndexChanged(sender, e)
                    Else
                        tbcnMain.TabPages.Remove(tbcnMain.SelectedTab)
                        tbcnMain_SelectedIndexChanged(sender, e)
                    End If
                End If
            End If
        Catch ex As Exception
            My.Application.Log.DefaultFileLogWriter.Location = Logging.LogFileLocation.Custom
            My.Application.Log.DefaultFileLogWriter.CustomLocation = My.Computer.FileSystem.SpecialDirectories.Desktop
            My.Application.Log.WriteException(ex)
            MsgBox("Opps! It looks like there was the following error: " & vbCrLf & vbCrLf & ex.Message & vbCrLf & vbCrLf & "This error was logged!", MsgBoxStyle.Critical, "Error - ProjectWords")
        End Try
    End Sub

    Private Sub tbcnMain_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbcnMain.MouseDown
        If isOverX Then Exit Sub
        DragStartPosition = New Point(e.X, e.Y)
    End Sub

    Private Sub tbcnMain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbcnMain.SelectedIndexChanged
        Me.Text = tbcnMain.SelectedTab.Text & " - ProjectWords"
        nticoMain.Text = Me.Text
        SelectedRTB = tbcnMain.SelectedTab.Controls(0)

        AddHandler SelectedRTB.TextChanged, AddressOf RichTextBoxHandler.TextChanged
        AddHandler SelectedRTB.DragEnter, AddressOf RichTextBoxHandler.DragEnter
    End Sub

    Private Sub tbcnMain_DragOver(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles tbcnMain.DragOver
        Dim hover_Tab As TabPage = HoverTab()
        If hover_Tab Is Nothing Then
            e.Effect = DragDropEffects.None
        Else
            If e.Data.GetDataPresent(GetType(TabPage)) Then

                e.Effect = DragDropEffects.Move
                Dim drag_tab As TabPage = DirectCast(e.Data.GetData(GetType(TabPage)), TabPage)

                If hover_Tab Is drag_tab Then Return

                Dim TabRect As Rectangle = tbcnMain.GetTabRect(tbcnMain.TabPages.IndexOf(hover_Tab))
                TabRect.Inflate(-3, -3)
                If TabRect.Contains(tbcnMain.PointToClient(New Point(e.X, e.Y))) Then
                    SwapTabPages(drag_tab, hover_Tab)
                    tbcnMain.SelectedTab = drag_tab
                End If
            End If
        End If

    End Sub
#End Region
#Region "ToolBars"
    Private Sub tlZIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlZIn.Click
        On Error Resume Next
        SelectedRTB.ZoomFactor += 0.35
    End Sub

    Private Sub tlZOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlZOut.Click
        On Error Resume Next
        SelectedRTB.ZoomFactor -= 0.35
    End Sub

    Private Sub tlFullScreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlFullScreen.Click
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        Me.WindowState = CInt(Me.Tag)
        Me.TopMost = False

        tlSep6.Visible = False
        tlFullScreen.Visible = False
        mnuStrip.Visible = CBool(mnuStrip.Tag)
        stsStrip.Visible = CBool(stsStrip.Tag)
        Call frmMain_Resize(sender, e)
    End Sub

    Private Sub tlFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlFont.Click
        mnuOptions_Font_Click(sender, e)
    End Sub

    Private Sub tlNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlNew.Click
        mnuFile_New_Click(sender, e)
    End Sub

    Private Sub tlAddTab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlAddTab.Click
        AddTab()
        stsLabel.Text = "New tab opened"
    End Sub

    Private Sub tlSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlSave.Click
        mnuFile_Save_Click(sender, e)
    End Sub

    Private Sub tlOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlOpen.Click
        mnuFile_Open_Click(sender, e)
    End Sub

    Private Sub tlPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlPrint.Click
        pDoc.Print()
    End Sub

    Private Sub tlFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlFind.Click
        LockWindowUpdate(SelectedRTB.Handle.ToInt32)
        Dim osStart As Integer = SelectedRTB.SelectionStart
        SelectedRTB.SelectAll()
        SelectedRTB.SelectionBackColor = Color.White

        If tlTxtFind.Text = "" Then Exit Sub

        Dim Start As Integer = 1, Pos As Integer
        Do While True
            Pos = InStr(Start, SelectedRTB.Text, tlTxtFind.Text, CompareMethod.Text)
            If Pos = 0 Then Exit Do
            SelectedRTB.Select(Pos - 1, tlTxtFind.TextLength)
            SelectedRTB.SelectionBackColor = Color.Yellow
            Start = Pos + 1
        Loop

        SelectedRTB.SelectionStart = osStart
        SelectedRTB.SelectionLength = 0
        SelectedRTB.Focus()
        tbcnMain.SelectedTab.Tag = "True"
        LockWindowUpdate(0)
    End Sub

    Private Sub tlTxtFind_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tlTxtFind.KeyPress
        If e.KeyChar = Chr(Keys.Return) Then
            tlFind_Click(sender, e)
        End If
    End Sub
#End Region
#Region "Menus"
    Private Sub mnuEdit_Undo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit_Undo.Click
        SelectedRTB.Undo()
    End Sub

    Private Sub mnuEdit_Redo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit_Redo.Click
        SelectedRTB.Redo()
    End Sub

    Private Sub mnuEdit_Cut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit_Cut.Click
        SelectedRTB.Cut()
    End Sub

    Private Sub mnuEdit_Copy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit_Copy.Click
        SelectedRTB.Copy()
    End Sub

    Private Sub mnuEdit_Paste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit_Paste.Click
        SelectedRTB.Paste()
    End Sub

    Private Sub mnuEdit_SelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit_SelectAll.Click
        SelectedRTB.SelectAll()
    End Sub

    Private Sub mnuFile_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFile_Exit.Click
        Dim RTB As RichTextBox
        For Each aPage As TabPage In tbcnMain.TabPages
            RTB = aPage.Controls(0)
            If RTB.Modified = True Then
                Select Case MsgBox("You haven't saved your work in '" & Trim(aPage.Text) & "'. Do you want to save it?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Unsaved Work - ProjectWords")
                    Case MsgBoxResult.Yes
                        tbcnMain.SelectTab(aPage)
                        mnuFile_Save_Click(sender, e)
                        Continue For
                    Case MsgBoxResult.No
                        Continue For
                End Select
            Else
                Continue For
            End If
        Next
        nticoMain.Visible = False
        End
    End Sub

    Private Sub mnuFile_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFile_New.Click
        Try
            If SelectedRTB.Modified = True Then
                Select Case MsgBox("You haven't saved your work in this tab. Do you want to save?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Exclamation, "Unsaved Work - ProjectWords")
                    Case MsgBoxResult.Yes
                        mnuFile_Save_Click(sender, e)
                        tbcnMain.SelectedTab.Text = IIf(Not My.Settings.PrettyTabs, " ", "") & "Untitled" & tabNumber
                        tabNumber += 1
                        SelectedRTB.Clear()
                        SelectedRTB.Tag = ""
                        stsLabel.Text = "New file created"
                    Case MsgBoxResult.No
                        tbcnMain.SelectedTab.Text = IIf(Not My.Settings.PrettyTabs, " ", "") & "Untitled" & tabNumber
                        tabNumber += 1
                        SelectedRTB.Clear()
                        SelectedRTB.Tag = ""
                        stsLabel.Text = "New file created"
                    Case Else
                        stsLabel.Text = "Ready"
                        Exit Sub
                End Select
            Else
                tbcnMain.SelectedTab.Text = IIf(Not My.Settings.PrettyTabs, " ", "") & "Untitled" & tabNumber
                tabNumber += 1
                SelectedRTB.Clear()
                SelectedRTB.Tag = ""
                stsLabel.Text = "New file created"
            End If
        Catch ex As Exception
            My.Application.Log.DefaultFileLogWriter.Location = Logging.LogFileLocation.Custom
            My.Application.Log.DefaultFileLogWriter.CustomLocation = My.Computer.FileSystem.SpecialDirectories.Desktop
            My.Application.Log.WriteException(ex)
            MsgBox("Opps! It looks like there was the following error: " & vbCrLf & vbCrLf & ex.Message & vbCrLf & vbCrLf & "This error was logged!", MsgBoxStyle.Critical, "Error - ProjectWords")
        End Try
    End Sub

    Private Sub mnuView_MenuBarMoveable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuView_MenuBarMoveable.Click
        If mnuView_MenuBarMoveable.Checked = True Then
            mnuView_MenuBarMoveable.Checked = False
            mnuStrip.GripStyle = ToolStripGripStyle.Hidden
            stsLabel.Text = "Menubar is now not moveable"
        Else
            mnuView_MenuBarMoveable.Checked = True
            mnuStrip.GripStyle = ToolStripGripStyle.Visible
            stsLabel.Text = "Menubar is now moveable"
        End If
    End Sub

    Private Sub mnuView_StatusBarShowing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuView_StatusBarShowing.Click
        If mnuView_StatusBarShowing.Checked = True Then
            mnuView_StatusBarShowing.Checked = False
            stsStrip.Visible = False
            stsLabel.Text = "Ready"
        Else
            mnuView_StatusBarShowing.Checked = True
            stsStrip.Visible = True
            stsLabel.Text = "Ready"
        End If
    End Sub

    Private Sub mnuView_Toolbar_Showing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuView_Toolbar_Showing.Click
        If mnuView_Toolbar_Showing.Checked = True Then
            mnuView_Toolbar_Showing.Checked = False
            tlStrip.Visible = False
            stsLabel.Text = "Toolbar is now hidden"
        Else
            mnuView_Toolbar_Showing.Checked = True
            tlStrip.Visible = True
            stsLabel.Text = "Toolbar is now visible"
        End If
    End Sub

    Private Sub mnuView_Toolbar_Moveable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuView_Toolbar_Moveable.Click
        If mnuView_Toolbar_Moveable.Checked = True Then
            mnuView_Toolbar_Moveable.Checked = False
            tlStrip.GripStyle = ToolStripGripStyle.Hidden
            stsLabel.Text = "Toolbar is now not moveable"
        Else
            mnuView_Toolbar_Moveable.Checked = True
            tlStrip.GripStyle = ToolStripGripStyle.Visible
            stsLabel.Text = "Toolbar is now moveable"
        End If
    End Sub

    Private Sub mnuView_MinimizetoTaskbar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuView_MinimizetoTaskbar.Click
        If mnuView_MinimizetoTaskbar.Checked = True Then
            mnuView_MinimizetoTaskbar.Checked = False
            stsLabel.Text = "Main window will not minimize to the taskbar"
        Else
            mnuView_MinimizetoTaskbar.Checked = True
            stsLabel.Text = "Main window will minimize to the taskbar"
        End If
    End Sub

    Private Sub mnuView_Fullscreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuView_Fullscreen.Click
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.Tag = Me.WindowState
        If Me.WindowState = FormWindowState.Maximized Then Me.WindowState = FormWindowState.Normal
        Me.WindowState = FormWindowState.Maximized
        Me.TopMost = True

        tlSep6.Visible = True
        tlFullScreen.Visible = True
        mnuStrip.Tag = mnuStrip.Visible
        mnuStrip.Visible = False
        stsStrip.Tag = stsStrip.Visible
        stsStrip.Visible = False
    End Sub

    Private Sub mnuOptions_Font_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOptions_Font.Click
        stsLabel.Text = "Show font dialog..."
        Dim diaResult As DialogResult = fDiaMain.ShowDialog
        stsLabel.Text = "Ready"
        If diaResult = DialogResult.OK AndAlso SelectedRTB.SelectionLength = 0 Then
            SelectedRTB.Font = fDiaMain.Font
        ElseIf diaResult = DialogResult.OK AndAlso SelectedRTB.SelectionLength <> 0 Then
            SelectedRTB.SelectionFont = fDiaMain.Font
        End If
    End Sub

    Private Sub mnuOptions_Plugins_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOptions_Plugins.Click
        frmPlugins.Show()
        stsLabel.Text = "Ready"
    End Sub

    Private Sub mnuFile_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFile_Save.Click
        If SelectedRTB.Tag = "" Then
            mnuFile_SaveAs_Click(sender, e)
        Else
            If Strings.Right(SelectedRTB.Tag, 3) = "rtf" Then
                SelectedRTB.SaveFile(SelectedRTB.Tag, RichTextBoxStreamType.RichText)
                SelectedRTB.Modified = False
                stsLabel.Text = tbcnMain.SelectedTab.Text & " was saved"
            Else
                My.Computer.FileSystem.WriteAllText(SelectedRTB.Tag, SelectedRTB.Text, True)
                SelectedRTB.Modified = False
                stsLabel.Text = tbcnMain.SelectedTab.Text & " was saved"
            End If
        End If
    End Sub

    Private Sub mnuFile_SaveAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFile_SaveAs.Click
        sDiaMain.OverwritePrompt = True
        sDiaMain.Title = "Save - ProjectWords"
        sDiaMain.FileName = ""
        sDiaMain.Filter = "Plain Text Format|*.txt|RichText Format|*.rtf"
        If sDiaMain.ShowDialog = Windows.Forms.DialogResult.OK Then
            If Strings.Right(sDiaMain.FileName, 3) = "rtf" Then
                SelectedRTB.SaveFile(sDiaMain.FileName, RichTextBoxStreamType.RichText)
                SelectedRTB.Modified = False
                SelectedRTB.Tag = sDiaMain.FileName
                Me.Text = RemovePath(sDiaMain.FileName) & " - ProjectWords"
                tbcnMain.SelectedTab.Text = " " & RemovePath(sDiaMain.FileName)
                nticoMain.Text = Me.Text
                stsLabel.Text = "Saved file: " & sDiaMain.FileName
            Else
                My.Computer.FileSystem.WriteAllText(sDiaMain.FileName, SelectedRTB.Text, False)
                SelectedRTB.Modified = False
                SelectedRTB.Tag = sDiaMain.FileName
                Me.Text = RemovePath(sDiaMain.FileName) & " - ProjectWords"
                tbcnMain.SelectedTab.Text = " " & RemovePath(sDiaMain.FileName)
                nticoMain.Text = Me.Text
                stsLabel.Text = "Saved file: " & sDiaMain.FileName
            End If
        End If
    End Sub

    Private Sub mnuFile_Open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFile_Open.Click
        Try
            LoadFile()
        Catch ex As Exception
            My.Application.Log.DefaultFileLogWriter.Location = Logging.LogFileLocation.Custom
            My.Application.Log.DefaultFileLogWriter.CustomLocation = My.Computer.FileSystem.SpecialDirectories.Desktop
            My.Application.Log.WriteException(ex)
            MsgBox("Opps! It looks like there was the following error: " & vbCrLf & vbCrLf & ex.Message & vbCrLf & vbCrLf & "This error was logged!", MsgBoxStyle.Critical, "Error - ProjectWords")
        End Try
    End Sub

    Private Sub mnuFile_PrintSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFile_PrintSetup.Click
        Try
            psDiaMain.ShowDialog()
        Catch ex As Exception
            My.Application.Log.DefaultFileLogWriter.Location = Logging.LogFileLocation.Custom
            My.Application.Log.DefaultFileLogWriter.CustomLocation = My.Computer.FileSystem.SpecialDirectories.Desktop
            My.Application.Log.WriteException(ex)
            MsgBox("Opps! It looks like there was the following error: " & vbCrLf & vbCrLf & ex.Message & vbCrLf & vbCrLf & "This error was logged!", MsgBoxStyle.Critical, "Error - ProjectWords")
        End Try
    End Sub

    Private Sub mnuFile_PrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFile_PrintPreview.Click
        Try
            ppDiaMain.ShowDialog()
        Catch ex As Exception
            My.Application.Log.DefaultFileLogWriter.Location = Logging.LogFileLocation.Custom
            My.Application.Log.DefaultFileLogWriter.CustomLocation = My.Computer.FileSystem.SpecialDirectories.Desktop
            My.Application.Log.WriteException(ex)
            MsgBox("Opps! It looks like there was the following error: " & vbCrLf & vbCrLf & ex.Message & vbCrLf & vbCrLf & "This error was logged!", MsgBoxStyle.Critical, "Error - ProjectWords")
        End Try
    End Sub

    Private Sub mnuFile_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFile_Print.Click
        Try
            pDiaMain.Document = pDoc
            pDiaMain.AllowPrintToFile = False
            If pDiaMain.ShowDialog = Windows.Forms.DialogResult.OK Then pDoc.Print()
        Catch ex As Exception
            My.Application.Log.DefaultFileLogWriter.Location = Logging.LogFileLocation.Custom
            My.Application.Log.DefaultFileLogWriter.CustomLocation = My.Computer.FileSystem.SpecialDirectories.Desktop
            My.Application.Log.WriteException(ex)
            MsgBox("Opps! It looks like there was the following error: " & vbCrLf & vbCrLf & ex.Message & vbCrLf & vbCrLf & "This error was logged!", MsgBoxStyle.Critical, "Error - ProjectWords")
        End Try
    End Sub

    Private Sub mnuFile_SaveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFile_SaveAll.Click
        Dim RTB As RichTextBox
        For Each aPage As TabPage In tbcnMain.TabPages
            RTB = aPage.Controls(0)
            If RTB.Modified = True Then
                tbcnMain.SelectTab(aPage)
                mnuFile_Save_Click(sender, e)
            Else
                Continue For
            End If
        Next
    End Sub

    Private Sub mnuOptions_Pref_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOptions_Pref.Click
        frmPrefs.Show()
    End Sub

    Private Sub mnuEdit_Find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit_Find.Click
        RemoveHighlight()
        frmFind.Show()
        frmFind.tbcnMain.SelectTab(0)
    End Sub

    Private Sub mnuEdit_Replace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit_Replace.Click
        RemoveHighlight()
        frmFind.Show()
        frmFind.tbcnMain.SelectTab(1)
    End Sub
#End Region
#Region "cMenus"
    Private Sub cmnuCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuCut.Click
        SelectedRTB.Cut()
    End Sub

    Private Sub cmnuCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuCopy.Click
        SelectedRTB.Copy()
    End Sub

    Private Sub cmnuPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuPaste.Click
        SelectedRTB.Paste()
    End Sub

    Private Sub cmnuSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuSelectAll.Click
        SelectedRTB.SelectAll()
    End Sub

    Private Sub cmnuHighlight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuHighlight.Click
        RemoveHighlight()
    End Sub

    Private Sub cmnuRTB_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmnuRTB.Opening
        If CBool(tbcnMain.SelectedTab.Tag) = True Then
            cmnuSep2.Visible = True
            cmnuHighlight.Visible = True
        Else
            cmnuSep2.Visible = False
            cmnuHighlight.Visible = False
        End If
    End Sub
#End Region
#Region "Other"
    Private Sub nticoMain_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles nticoMain.MouseDoubleClick
        nticoMain.Visible = False
        Me.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub
    Private Sub pDoc_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles pDoc.PrintPage
        Try
            cFrom = RichTextBoxPrinter.Print(SelectedRTB, cFrom, e)
            If cFrom > 0 Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
                cFrom = 0
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Printing failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True
        End Try
    End Sub
#End Region
#End Region
#Region "Subroutines"
    Private Sub LoadFile()
        oDiaMain.Multiselect = True
        oDiaMain.Title = "Open - ProjectWords"
        oDiaMain.FileName = ""
        oDiaMain.Filter = "Text Files|*.txt;*.log;*.ini;*.dat|RichText Format|*.rtf|Web Files|*.html;*.htm;*.php;*.css;*.xml|All Files|*.*"
        If oDiaMain.ShowDialog <> Windows.Forms.DialogResult.OK Then Exit Sub
        For i As Integer = 0 To UBound(oDiaMain.FileNames)
            For Each atab As TabPage In tbcnMain.TabPages
                If atab.Controls(0).Tag = oDiaMain.FileNames(i) Then
                    tbcnMain.SelectedTab = atab
                    GoTo NextFor
                End If
            Next
            AddTab()
            If Strings.Right(oDiaMain.SafeFileNames(i), 3) = "rtf" Then
                SelectedRTB.LoadFile(oDiaMain.FileNames(i))
                SelectedRTB.Tag = oDiaMain.FileNames(i)
                tbcnMain.SelectedTab.Text = " " & oDiaMain.SafeFileNames(i)
                Me.Text = oDiaMain.SafeFileNames(i) & " - ProjectWords"
                nticoMain.Text = Me.Text
                stsLabel.Text = "Opened file: " & oDiaMain.FileNames(i)
            Else
                SelectedRTB.Text = My.Computer.FileSystem.ReadAllText(oDiaMain.FileNames(i))
                SelectedRTB.Tag = oDiaMain.FileNames(i)
                tbcnMain.SelectedTab.Text = " " & oDiaMain.SafeFileNames(i)
                Me.Text = oDiaMain.SafeFileNames(i) & " - ProjectWords"
                nticoMain.Text = Me.Text
                stsLabel.Text = "Opened file: " & oDiaMain.FileNames(i)
            End If
NextFor:
        Next i
    End Sub

    Private Sub AddTab(Optional ByVal Loaded As Boolean = False)
        Dim newRTB As New RichTextBox, newTabPage As New TabPage(IIf(Not My.Settings.PrettyTabs, " ", "") & "Untitled" & IIf(Loaded, "", tabNumber))
        tabNumber += 1
        newTabPage.Controls.Add(newRTB)
        newTabPage.AutoScroll = True
        newTabPage.Select()
        newRTB.Dock = DockStyle.Fill
        tbcnMain.TabPages.Add(newTabPage)
        tbcnMain.SelectTab(newTabPage)

        newRTB.Multiline = True
        newRTB.ContextMenuStrip = cmnuRTB
        newRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both
        newRTB.WordWrap = True
        newRTB.AcceptsTab = True
        newRTB.Font = New System.Drawing.Font("Lucida Console", 13.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        newRTB.AllowDrop = True
        newRTB.HideSelection = False
        tbcnMain.Font = New Font("Arial", 8.25F, FontStyle.Bold)

        AddHandler newRTB.TextChanged, AddressOf RichTextBoxHandler.TextChanged
        AddHandler newRTB.DragEnter, AddressOf RichTextBoxHandler.DragEnter

        Me.Text = tbcnMain.SelectedTab.Text & " - ProjectWords"
        nticoMain.Text = Me.Text
        SelectedRTB = newRTB
        SelectedRTB.Modified = False
    End Sub

    Private Function HoverTab() As TabPage
        For index As Int32 = 0 To tbcnMain.TabCount - 1
            If tbcnMain.GetTabRect(index).Contains(tbcnMain.PointToClient(Cursor.Position)) Then
                Return tbcnMain.TabPages(index)
                Exit Function
            End If
        Next
        Return tbcnMain.SelectedTab
    End Function

    Private Sub SwapTabPages(ByVal tp1 As TabPage, ByVal tp2 As TabPage)
        Dim Index1 As Integer = tbcnMain.TabPages.IndexOf(tp1)
        Dim Index2 As Integer = tbcnMain.TabPages.IndexOf(tp2)
        tbcnMain.TabPages(Index1) = tp2
        tbcnMain.TabPages(Index2) = tp1
    End Sub

    Private Sub RemoveHighlight()
        If Not CBool(tbcnMain.SelectedTab.Tag) Then Exit Sub Else tbcnMain.SelectedTab.Tag = CStr(False)

        Dim tmp As Integer = SelectedRTB.SelectionStart
        LockWindowUpdate(SelectedRTB.Handle.ToInt32)
        SelectedRTB.SelectAll()
        SelectedRTB.SelectionBackColor = Color.White

        SelectedRTB.SelectionStart = tmp
        SelectedRTB.SelectionLength = 0
        LockWindowUpdate(0)
    End Sub
#End Region
End Class