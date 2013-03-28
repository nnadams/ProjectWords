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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.cntMain = New System.Windows.Forms.ToolStripContainer
        Me.stsStrip = New System.Windows.Forms.StatusStrip
        Me.stsLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.tbcnMain = New System.Windows.Forms.TabControl
        Me.mnuStrip = New System.Windows.Forms.MenuStrip
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFile_New = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFile_Open = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSep = New System.Windows.Forms.ToolStripSeparator
        Me.mnuFile_Save = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFile_SaveAs = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFile_SaveAll = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSep1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuFile_PrintSetup = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFile_Print = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFile_PrintPreview = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSep2 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuFile_Exit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEdit_Undo = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEdit_Redo = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSep3 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuEdit_Cut = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEdit_Copy = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEdit_Paste = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSep4 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuEdit_Find = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEdit_Replace = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSep8 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuEdit_SelectAll = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuView = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuView_Fullscreen = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSep6 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuView_MenuBarMoveable = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuView_StatusBarShowing = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuView_Toolbar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuView_Toolbar_Showing = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuView_Toolbar_Moveable = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSep7 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuView_MinimizetoTaskbar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuOptions = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuOptions_Font = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuOptions_Plugins = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSep9 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuOptions_Pref = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHelp_About = New System.Windows.Forms.ToolStripMenuItem
        Me.tlStrip = New System.Windows.Forms.ToolStrip
        Me.tlAddTab = New System.Windows.Forms.ToolStripButton
        Me.tlSep = New System.Windows.Forms.ToolStripSeparator
        Me.tlNew = New System.Windows.Forms.ToolStripButton
        Me.tlOpen = New System.Windows.Forms.ToolStripButton
        Me.tlSave = New System.Windows.Forms.ToolStripButton
        Me.tlSep2 = New System.Windows.Forms.ToolStripSeparator
        Me.tlPrint = New System.Windows.Forms.ToolStripButton
        Me.tlSep3 = New System.Windows.Forms.ToolStripSeparator
        Me.tlZIn = New System.Windows.Forms.ToolStripButton
        Me.tlZOut = New System.Windows.Forms.ToolStripButton
        Me.tlSep5 = New System.Windows.Forms.ToolStripSeparator
        Me.tlFont = New System.Windows.Forms.ToolStripButton
        Me.tlSep4 = New System.Windows.Forms.ToolStripSeparator
        Me.tlFind = New System.Windows.Forms.ToolStripButton
        Me.tlTxtFind = New System.Windows.Forms.ToolStripTextBox
        Me.tlSep6 = New System.Windows.Forms.ToolStripSeparator
        Me.tlFullScreen = New System.Windows.Forms.ToolStripButton
        Me.nticoMain = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cmnuNIcon = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.fDiaMain = New System.Windows.Forms.FontDialog
        Me.sDiaMain = New System.Windows.Forms.SaveFileDialog
        Me.oDiaMain = New System.Windows.Forms.OpenFileDialog
        Me.cmnuRTB = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmnuCut = New System.Windows.Forms.ToolStripMenuItem
        Me.cmnuCopy = New System.Windows.Forms.ToolStripMenuItem
        Me.cmnuPaste = New System.Windows.Forms.ToolStripMenuItem
        Me.cmnuSep = New System.Windows.Forms.ToolStripSeparator
        Me.cmnuSelectAll = New System.Windows.Forms.ToolStripMenuItem
        Me.cmnuSep2 = New System.Windows.Forms.ToolStripSeparator
        Me.cmnuHighlight = New System.Windows.Forms.ToolStripMenuItem
        Me.psDiaMain = New System.Windows.Forms.PageSetupDialog
        Me.pDoc = New System.Drawing.Printing.PrintDocument
        Me.ppDiaMain = New System.Windows.Forms.PrintPreviewDialog
        Me.pDiaMain = New System.Windows.Forms.PrintDialog
        Me.cntMain.BottomToolStripPanel.SuspendLayout()
        Me.cntMain.ContentPanel.SuspendLayout()
        Me.cntMain.TopToolStripPanel.SuspendLayout()
        Me.cntMain.SuspendLayout()
        Me.stsStrip.SuspendLayout()
        Me.mnuStrip.SuspendLayout()
        Me.tlStrip.SuspendLayout()
        Me.cmnuRTB.SuspendLayout()
        Me.SuspendLayout()
        '
        'cntMain
        '
        '
        'cntMain.BottomToolStripPanel
        '
        Me.cntMain.BottomToolStripPanel.Controls.Add(Me.stsStrip)
        '
        'cntMain.ContentPanel
        '
        Me.cntMain.ContentPanel.Controls.Add(Me.tbcnMain)
        Me.cntMain.ContentPanel.Size = New System.Drawing.Size(630, 375)
        Me.cntMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cntMain.Location = New System.Drawing.Point(0, 0)
        Me.cntMain.Name = "cntMain"
        Me.cntMain.Size = New System.Drawing.Size(630, 446)
        Me.cntMain.TabIndex = 0
        Me.cntMain.Text = "ToolStripContainer1"
        '
        'cntMain.TopToolStripPanel
        '
        Me.cntMain.TopToolStripPanel.Controls.Add(Me.tlStrip)
        Me.cntMain.TopToolStripPanel.Controls.Add(Me.mnuStrip)
        '
        'stsStrip
        '
        Me.stsStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.stsStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsLabel})
        Me.stsStrip.Location = New System.Drawing.Point(0, 0)
        Me.stsStrip.Name = "stsStrip"
        Me.stsStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.stsStrip.Size = New System.Drawing.Size(630, 22)
        Me.stsStrip.TabIndex = 0
        '
        'stsLabel
        '
        Me.stsLabel.Name = "stsLabel"
        Me.stsLabel.Size = New System.Drawing.Size(39, 17)
        Me.stsLabel.Text = "Ready"
        '
        'tbcnMain
        '
        Me.tbcnMain.AllowDrop = True
        Me.tbcnMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcnMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.tbcnMain.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcnMain.Location = New System.Drawing.Point(0, 0)
        Me.tbcnMain.Name = "tbcnMain"
        Me.tbcnMain.SelectedIndex = 0
        Me.tbcnMain.ShowToolTips = True
        Me.tbcnMain.Size = New System.Drawing.Size(630, 375)
        Me.tbcnMain.TabIndex = 0
        Me.tbcnMain.TabStop = False
        '
        'mnuStrip
        '
        Me.mnuStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.mnuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuView, Me.mnuOptions, Me.mnuHelp})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 25)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.mnuStrip.Size = New System.Drawing.Size(630, 24)
        Me.mnuStrip.TabIndex = 0
        Me.mnuStrip.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile_New, Me.mnuFile_Open, Me.mnuSep, Me.mnuFile_Save, Me.mnuFile_SaveAs, Me.mnuFile_SaveAll, Me.mnuSep1, Me.mnuFile_PrintSetup, Me.mnuFile_Print, Me.mnuFile_PrintPreview, Me.mnuSep2, Me.mnuFile_Exit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFile_New
        '
        Me.mnuFile_New.Image = Global.ProjectWords.My.Resources.Resources.page_white_text
        Me.mnuFile_New.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuFile_New.Name = "mnuFile_New"
        Me.mnuFile_New.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuFile_New.Size = New System.Drawing.Size(216, 22)
        Me.mnuFile_New.Text = "&New"
        '
        'mnuFile_Open
        '
        Me.mnuFile_Open.Image = Global.ProjectWords.My.Resources.Resources.folder
        Me.mnuFile_Open.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuFile_Open.Name = "mnuFile_Open"
        Me.mnuFile_Open.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuFile_Open.Size = New System.Drawing.Size(216, 22)
        Me.mnuFile_Open.Text = "&Open"
        '
        'mnuSep
        '
        Me.mnuSep.Name = "mnuSep"
        Me.mnuSep.Size = New System.Drawing.Size(213, 6)
        '
        'mnuFile_Save
        '
        Me.mnuFile_Save.Image = Global.ProjectWords.My.Resources.Resources.disk
        Me.mnuFile_Save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuFile_Save.Name = "mnuFile_Save"
        Me.mnuFile_Save.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuFile_Save.Size = New System.Drawing.Size(216, 22)
        Me.mnuFile_Save.Text = "&Save"
        '
        'mnuFile_SaveAs
        '
        Me.mnuFile_SaveAs.Name = "mnuFile_SaveAs"
        Me.mnuFile_SaveAs.Size = New System.Drawing.Size(216, 22)
        Me.mnuFile_SaveAs.Text = "Save &As..."
        '
        'mnuFile_SaveAll
        '
        Me.mnuFile_SaveAll.Image = Global.ProjectWords.My.Resources.Resources.disk_multiple
        Me.mnuFile_SaveAll.Name = "mnuFile_SaveAll"
        Me.mnuFile_SaveAll.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuFile_SaveAll.Size = New System.Drawing.Size(216, 22)
        Me.mnuFile_SaveAll.Text = "Save All"
        '
        'mnuSep1
        '
        Me.mnuSep1.Name = "mnuSep1"
        Me.mnuSep1.Size = New System.Drawing.Size(213, 6)
        '
        'mnuFile_PrintSetup
        '
        Me.mnuFile_PrintSetup.Name = "mnuFile_PrintSetup"
        Me.mnuFile_PrintSetup.Size = New System.Drawing.Size(216, 22)
        Me.mnuFile_PrintSetup.Text = "Print Setup"
        '
        'mnuFile_Print
        '
        Me.mnuFile_Print.Image = Global.ProjectWords.My.Resources.Resources.printer
        Me.mnuFile_Print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuFile_Print.Name = "mnuFile_Print"
        Me.mnuFile_Print.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuFile_Print.Size = New System.Drawing.Size(216, 22)
        Me.mnuFile_Print.Text = "&Print"
        '
        'mnuFile_PrintPreview
        '
        Me.mnuFile_PrintPreview.Image = Global.ProjectWords.My.Resources.Resources.page_white_magnify
        Me.mnuFile_PrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuFile_PrintPreview.Name = "mnuFile_PrintPreview"
        Me.mnuFile_PrintPreview.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuFile_PrintPreview.Size = New System.Drawing.Size(216, 22)
        Me.mnuFile_PrintPreview.Text = "Print Pre&view"
        '
        'mnuSep2
        '
        Me.mnuSep2.Name = "mnuSep2"
        Me.mnuSep2.Size = New System.Drawing.Size(213, 6)
        '
        'mnuFile_Exit
        '
        Me.mnuFile_Exit.Image = Global.ProjectWords.My.Resources.Resources.cross
        Me.mnuFile_Exit.Name = "mnuFile_Exit"
        Me.mnuFile_Exit.Size = New System.Drawing.Size(216, 22)
        Me.mnuFile_Exit.Text = "E&xit"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEdit_Undo, Me.mnuEdit_Redo, Me.mnuSep3, Me.mnuEdit_Cut, Me.mnuEdit_Copy, Me.mnuEdit_Paste, Me.mnuSep4, Me.mnuEdit_Find, Me.mnuEdit_Replace, Me.mnuSep8, Me.mnuEdit_SelectAll})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(39, 20)
        Me.mnuEdit.Text = "&Edit"
        '
        'mnuEdit_Undo
        '
        Me.mnuEdit_Undo.Image = Global.ProjectWords.My.Resources.Resources.arrow_undo
        Me.mnuEdit_Undo.Name = "mnuEdit_Undo"
        Me.mnuEdit_Undo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.mnuEdit_Undo.Size = New System.Drawing.Size(164, 22)
        Me.mnuEdit_Undo.Text = "&Undo"
        '
        'mnuEdit_Redo
        '
        Me.mnuEdit_Redo.Image = Global.ProjectWords.My.Resources.Resources.arrow_redo
        Me.mnuEdit_Redo.Name = "mnuEdit_Redo"
        Me.mnuEdit_Redo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.mnuEdit_Redo.Size = New System.Drawing.Size(164, 22)
        Me.mnuEdit_Redo.Text = "&Redo"
        '
        'mnuSep3
        '
        Me.mnuSep3.Name = "mnuSep3"
        Me.mnuSep3.Size = New System.Drawing.Size(161, 6)
        '
        'mnuEdit_Cut
        '
        Me.mnuEdit_Cut.Image = Global.ProjectWords.My.Resources.Resources.cut
        Me.mnuEdit_Cut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuEdit_Cut.Name = "mnuEdit_Cut"
        Me.mnuEdit_Cut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuEdit_Cut.Size = New System.Drawing.Size(164, 22)
        Me.mnuEdit_Cut.Text = "Cu&t"
        '
        'mnuEdit_Copy
        '
        Me.mnuEdit_Copy.Image = Global.ProjectWords.My.Resources.Resources.page_white_copy
        Me.mnuEdit_Copy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuEdit_Copy.Name = "mnuEdit_Copy"
        Me.mnuEdit_Copy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuEdit_Copy.Size = New System.Drawing.Size(164, 22)
        Me.mnuEdit_Copy.Text = "&Copy"
        '
        'mnuEdit_Paste
        '
        Me.mnuEdit_Paste.Image = Global.ProjectWords.My.Resources.Resources.page_paste
        Me.mnuEdit_Paste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuEdit_Paste.Name = "mnuEdit_Paste"
        Me.mnuEdit_Paste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuEdit_Paste.Size = New System.Drawing.Size(164, 22)
        Me.mnuEdit_Paste.Text = "&Paste"
        '
        'mnuSep4
        '
        Me.mnuSep4.Name = "mnuSep4"
        Me.mnuSep4.Size = New System.Drawing.Size(161, 6)
        '
        'mnuEdit_Find
        '
        Me.mnuEdit_Find.Image = Global.ProjectWords.My.Resources.Resources.find
        Me.mnuEdit_Find.Name = "mnuEdit_Find"
        Me.mnuEdit_Find.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.mnuEdit_Find.Size = New System.Drawing.Size(164, 22)
        Me.mnuEdit_Find.Text = "&Find"
        '
        'mnuEdit_Replace
        '
        Me.mnuEdit_Replace.Image = Global.ProjectWords.My.Resources.Resources.text_replace
        Me.mnuEdit_Replace.Name = "mnuEdit_Replace"
        Me.mnuEdit_Replace.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.mnuEdit_Replace.Size = New System.Drawing.Size(164, 22)
        Me.mnuEdit_Replace.Text = "R&eplace"
        '
        'mnuSep8
        '
        Me.mnuSep8.Name = "mnuSep8"
        Me.mnuSep8.Size = New System.Drawing.Size(161, 6)
        '
        'mnuEdit_SelectAll
        '
        Me.mnuEdit_SelectAll.Name = "mnuEdit_SelectAll"
        Me.mnuEdit_SelectAll.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuEdit_SelectAll.Size = New System.Drawing.Size(164, 22)
        Me.mnuEdit_SelectAll.Text = "Select &All"
        '
        'mnuView
        '
        Me.mnuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuView_Fullscreen, Me.mnuSep6, Me.mnuView_MenuBarMoveable, Me.mnuView_StatusBarShowing, Me.mnuView_Toolbar, Me.mnuSep7, Me.mnuView_MinimizetoTaskbar})
        Me.mnuView.Name = "mnuView"
        Me.mnuView.Size = New System.Drawing.Size(44, 20)
        Me.mnuView.Text = "&View"
        '
        'mnuView_Fullscreen
        '
        Me.mnuView_Fullscreen.Image = Global.ProjectWords.My.Resources.Resources.arrow_out
        Me.mnuView_Fullscreen.Name = "mnuView_Fullscreen"
        Me.mnuView_Fullscreen.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.mnuView_Fullscreen.Size = New System.Drawing.Size(181, 22)
        Me.mnuView_Fullscreen.Text = "Fu&llscreen"
        '
        'mnuSep6
        '
        Me.mnuSep6.Name = "mnuSep6"
        Me.mnuSep6.Size = New System.Drawing.Size(178, 6)
        '
        'mnuView_MenuBarMoveable
        '
        Me.mnuView_MenuBarMoveable.Checked = True
        Me.mnuView_MenuBarMoveable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuView_MenuBarMoveable.Name = "mnuView_MenuBarMoveable"
        Me.mnuView_MenuBarMoveable.Size = New System.Drawing.Size(181, 22)
        Me.mnuView_MenuBarMoveable.Text = "Menu Bar Moveable"
        '
        'mnuView_StatusBarShowing
        '
        Me.mnuView_StatusBarShowing.Checked = True
        Me.mnuView_StatusBarShowing.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuView_StatusBarShowing.Name = "mnuView_StatusBarShowing"
        Me.mnuView_StatusBarShowing.Size = New System.Drawing.Size(181, 22)
        Me.mnuView_StatusBarShowing.Text = "Status Bar Showing"
        '
        'mnuView_Toolbar
        '
        Me.mnuView_Toolbar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuView_Toolbar_Showing, Me.mnuView_Toolbar_Moveable})
        Me.mnuView_Toolbar.Name = "mnuView_Toolbar"
        Me.mnuView_Toolbar.Size = New System.Drawing.Size(181, 22)
        Me.mnuView_Toolbar.Text = "Toolbar"
        '
        'mnuView_Toolbar_Showing
        '
        Me.mnuView_Toolbar_Showing.Checked = True
        Me.mnuView_Toolbar_Showing.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuView_Toolbar_Showing.Name = "mnuView_Toolbar_Showing"
        Me.mnuView_Toolbar_Showing.Size = New System.Drawing.Size(126, 22)
        Me.mnuView_Toolbar_Showing.Text = "Showing"
        '
        'mnuView_Toolbar_Moveable
        '
        Me.mnuView_Toolbar_Moveable.Checked = True
        Me.mnuView_Toolbar_Moveable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuView_Toolbar_Moveable.Name = "mnuView_Toolbar_Moveable"
        Me.mnuView_Toolbar_Moveable.Size = New System.Drawing.Size(126, 22)
        Me.mnuView_Toolbar_Moveable.Text = "Moveable"
        '
        'mnuSep7
        '
        Me.mnuSep7.Name = "mnuSep7"
        Me.mnuSep7.Size = New System.Drawing.Size(178, 6)
        '
        'mnuView_MinimizetoTaskbar
        '
        Me.mnuView_MinimizetoTaskbar.Name = "mnuView_MinimizetoTaskbar"
        Me.mnuView_MinimizetoTaskbar.Size = New System.Drawing.Size(181, 22)
        Me.mnuView_MinimizetoTaskbar.Text = "Minimize to Taskbar"
        '
        'mnuOptions
        '
        Me.mnuOptions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptions_Font, Me.mnuOptions_Plugins, Me.mnuSep9, Me.mnuOptions_Pref})
        Me.mnuOptions.Name = "mnuOptions"
        Me.mnuOptions.Size = New System.Drawing.Size(61, 20)
        Me.mnuOptions.Text = "Opt&ions"
        '
        'mnuOptions_Font
        '
        Me.mnuOptions_Font.Image = Global.ProjectWords.My.Resources.Resources.font
        Me.mnuOptions_Font.Name = "mnuOptions_Font"
        Me.mnuOptions_Font.Size = New System.Drawing.Size(152, 22)
        Me.mnuOptions_Font.Text = "Fonts"
        '
        'mnuOptions_Plugins
        '
        Me.mnuOptions_Plugins.Enabled = False
        Me.mnuOptions_Plugins.Image = Global.ProjectWords.My.Resources.Resources.plugin
        Me.mnuOptions_Plugins.Name = "mnuOptions_Plugins"
        Me.mnuOptions_Plugins.Size = New System.Drawing.Size(152, 22)
        Me.mnuOptions_Plugins.Text = "Plugins"
        '
        'mnuSep9
        '
        Me.mnuSep9.Name = "mnuSep9"
        Me.mnuSep9.Size = New System.Drawing.Size(149, 6)
        '
        'mnuOptions_Pref
        '
        Me.mnuOptions_Pref.Name = "mnuOptions_Pref"
        Me.mnuOptions_Pref.Size = New System.Drawing.Size(152, 22)
        Me.mnuOptions_Pref.Text = "Preferences..."
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelp_About})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuHelp_About
        '
        Me.mnuHelp_About.Enabled = False
        Me.mnuHelp_About.Image = Global.ProjectWords.My.Resources.Resources.help
        Me.mnuHelp_About.Name = "mnuHelp_About"
        Me.mnuHelp_About.ShortcutKeyDisplayString = ""
        Me.mnuHelp_About.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mnuHelp_About.Size = New System.Drawing.Size(135, 22)
        Me.mnuHelp_About.Text = "A&bout..."
        '
        'tlStrip
        '
        Me.tlStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.tlStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlAddTab, Me.tlSep, Me.tlNew, Me.tlOpen, Me.tlSave, Me.tlSep2, Me.tlPrint, Me.tlSep3, Me.tlZIn, Me.tlZOut, Me.tlSep5, Me.tlFont, Me.tlSep4, Me.tlFind, Me.tlTxtFind, Me.tlSep6, Me.tlFullScreen})
        Me.tlStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.tlStrip.Location = New System.Drawing.Point(3, 0)
        Me.tlStrip.Name = "tlStrip"
        Me.tlStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.tlStrip.Size = New System.Drawing.Size(351, 25)
        Me.tlStrip.TabIndex = 1
        '
        'tlAddTab
        '
        Me.tlAddTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlAddTab.Image = Global.ProjectWords.My.Resources.Resources.tab_add
        Me.tlAddTab.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlAddTab.Name = "tlAddTab"
        Me.tlAddTab.Size = New System.Drawing.Size(23, 22)
        Me.tlAddTab.Text = "New Tab"
        '
        'tlSep
        '
        Me.tlSep.Name = "tlSep"
        Me.tlSep.Size = New System.Drawing.Size(6, 25)
        '
        'tlNew
        '
        Me.tlNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlNew.Image = Global.ProjectWords.My.Resources.Resources.page_white_text
        Me.tlNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlNew.Name = "tlNew"
        Me.tlNew.Size = New System.Drawing.Size(23, 22)
        Me.tlNew.Text = "New"
        '
        'tlOpen
        '
        Me.tlOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlOpen.Image = Global.ProjectWords.My.Resources.Resources.folder
        Me.tlOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlOpen.Name = "tlOpen"
        Me.tlOpen.Size = New System.Drawing.Size(23, 22)
        Me.tlOpen.Text = "Open"
        '
        'tlSave
        '
        Me.tlSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlSave.Image = Global.ProjectWords.My.Resources.Resources.disk
        Me.tlSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlSave.Name = "tlSave"
        Me.tlSave.Size = New System.Drawing.Size(23, 22)
        Me.tlSave.Text = "Save"
        '
        'tlSep2
        '
        Me.tlSep2.Name = "tlSep2"
        Me.tlSep2.Size = New System.Drawing.Size(6, 25)
        '
        'tlPrint
        '
        Me.tlPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlPrint.Image = Global.ProjectWords.My.Resources.Resources.printer
        Me.tlPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlPrint.Name = "tlPrint"
        Me.tlPrint.Size = New System.Drawing.Size(23, 22)
        Me.tlPrint.Text = "Print"
        '
        'tlSep3
        '
        Me.tlSep3.Name = "tlSep3"
        Me.tlSep3.Size = New System.Drawing.Size(6, 25)
        '
        'tlZIn
        '
        Me.tlZIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlZIn.Image = Global.ProjectWords.My.Resources.Resources.magnifier_zoom_in
        Me.tlZIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlZIn.Name = "tlZIn"
        Me.tlZIn.Size = New System.Drawing.Size(23, 22)
        Me.tlZIn.Text = "Zoom In"
        '
        'tlZOut
        '
        Me.tlZOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlZOut.Image = Global.ProjectWords.My.Resources.Resources.magifier_zoom_out
        Me.tlZOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlZOut.Name = "tlZOut"
        Me.tlZOut.Size = New System.Drawing.Size(23, 22)
        Me.tlZOut.Text = "Zoom Out"
        '
        'tlSep5
        '
        Me.tlSep5.Name = "tlSep5"
        Me.tlSep5.Size = New System.Drawing.Size(6, 25)
        '
        'tlFont
        '
        Me.tlFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlFont.Image = Global.ProjectWords.My.Resources.Resources.font
        Me.tlFont.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlFont.Name = "tlFont"
        Me.tlFont.Size = New System.Drawing.Size(23, 22)
        Me.tlFont.Text = "Font"
        '
        'tlSep4
        '
        Me.tlSep4.Name = "tlSep4"
        Me.tlSep4.Size = New System.Drawing.Size(6, 25)
        '
        'tlFind
        '
        Me.tlFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlFind.Image = Global.ProjectWords.My.Resources.Resources.find
        Me.tlFind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlFind.Name = "tlFind"
        Me.tlFind.Size = New System.Drawing.Size(23, 22)
        Me.tlFind.Text = "Find"
        '
        'tlTxtFind
        '
        Me.tlTxtFind.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.tlTxtFind.Name = "tlTxtFind"
        Me.tlTxtFind.Size = New System.Drawing.Size(100, 25)
        Me.tlTxtFind.ToolTipText = "Enter Text to Find"
        '
        'tlSep6
        '
        Me.tlSep6.Name = "tlSep6"
        Me.tlSep6.Size = New System.Drawing.Size(6, 25)
        Me.tlSep6.Visible = False
        '
        'tlFullScreen
        '
        Me.tlFullScreen.Image = Global.ProjectWords.My.Resources.Resources.arrow_in
        Me.tlFullScreen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlFullScreen.Name = "tlFullScreen"
        Me.tlFullScreen.Size = New System.Drawing.Size(112, 22)
        Me.tlFullScreen.Text = "Close Fullscreen"
        Me.tlFullScreen.Visible = False
        '
        'nticoMain
        '
        Me.nticoMain.ContextMenuStrip = Me.cmnuNIcon
        Me.nticoMain.Icon = CType(resources.GetObject("nticoMain.Icon"), System.Drawing.Icon)
        Me.nticoMain.Text = "ProjectWords"
        '
        'cmnuNIcon
        '
        Me.cmnuNIcon.Name = "cmnuNIcon"
        Me.cmnuNIcon.Size = New System.Drawing.Size(61, 4)
        '
        'oDiaMain
        '
        Me.oDiaMain.FileName = "OpenFileDialog1"
        '
        'cmnuRTB
        '
        Me.cmnuRTB.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuCut, Me.cmnuCopy, Me.cmnuPaste, Me.cmnuSep, Me.cmnuSelectAll, Me.cmnuSep2, Me.cmnuHighlight})
        Me.cmnuRTB.Name = "cmnuRTB"
        Me.cmnuRTB.Size = New System.Drawing.Size(172, 126)
        '
        'cmnuCut
        '
        Me.cmnuCut.Name = "cmnuCut"
        Me.cmnuCut.Size = New System.Drawing.Size(171, 22)
        Me.cmnuCut.Text = "Cut"
        '
        'cmnuCopy
        '
        Me.cmnuCopy.Name = "cmnuCopy"
        Me.cmnuCopy.Size = New System.Drawing.Size(171, 22)
        Me.cmnuCopy.Text = "Copy"
        '
        'cmnuPaste
        '
        Me.cmnuPaste.Name = "cmnuPaste"
        Me.cmnuPaste.Size = New System.Drawing.Size(171, 22)
        Me.cmnuPaste.Text = "Paste"
        '
        'cmnuSep
        '
        Me.cmnuSep.Name = "cmnuSep"
        Me.cmnuSep.Size = New System.Drawing.Size(168, 6)
        '
        'cmnuSelectAll
        '
        Me.cmnuSelectAll.Name = "cmnuSelectAll"
        Me.cmnuSelectAll.Size = New System.Drawing.Size(171, 22)
        Me.cmnuSelectAll.Text = "Select All"
        '
        'cmnuSep2
        '
        Me.cmnuSep2.Name = "cmnuSep2"
        Me.cmnuSep2.Size = New System.Drawing.Size(168, 6)
        Me.cmnuSep2.Visible = False
        '
        'cmnuHighlight
        '
        Me.cmnuHighlight.Name = "cmnuHighlight"
        Me.cmnuHighlight.Size = New System.Drawing.Size(171, 22)
        Me.cmnuHighlight.Text = "Clear Highlighting"
        Me.cmnuHighlight.Visible = False
        '
        'psDiaMain
        '
        Me.psDiaMain.Document = Me.pDoc
        Me.psDiaMain.MinMargins = New System.Drawing.Printing.Margins(1, 1, 1, 1)
        '
        'pDoc
        '
        '
        'ppDiaMain
        '
        Me.ppDiaMain.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.ppDiaMain.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.ppDiaMain.ClientSize = New System.Drawing.Size(400, 300)
        Me.ppDiaMain.Document = Me.pDoc
        Me.ppDiaMain.Enabled = True
        Me.ppDiaMain.Icon = CType(resources.GetObject("ppDiaMain.Icon"), System.Drawing.Icon)
        Me.ppDiaMain.Name = "ppDiaMain"
        Me.ppDiaMain.UseAntiAlias = True
        Me.ppDiaMain.Visible = False
        '
        'pDiaMain
        '
        Me.pDiaMain.UseEXDialog = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 446)
        Me.Controls.Add(Me.cntMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuStrip
        Me.Name = "frmMain"
        Me.Text = "ProjectWords"
        Me.cntMain.BottomToolStripPanel.ResumeLayout(False)
        Me.cntMain.BottomToolStripPanel.PerformLayout()
        Me.cntMain.ContentPanel.ResumeLayout(False)
        Me.cntMain.TopToolStripPanel.ResumeLayout(False)
        Me.cntMain.TopToolStripPanel.PerformLayout()
        Me.cntMain.ResumeLayout(False)
        Me.cntMain.PerformLayout()
        Me.stsStrip.ResumeLayout(False)
        Me.stsStrip.PerformLayout()
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        Me.tlStrip.ResumeLayout(False)
        Me.tlStrip.PerformLayout()
        Me.cmnuRTB.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cntMain As System.Windows.Forms.ToolStripContainer
    Friend WithEvents mnuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFile_New As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFile_Open As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFile_Save As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFile_SaveAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSep1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFile_Print As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFile_PrintPreview As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFile_Exit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit_Undo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit_Redo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSep3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuEdit_Cut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit_Copy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit_Paste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSep4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuEdit_SelectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents stsStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents stsLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mnuFile_SaveAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp_About As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOptions_Font As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOptions_Plugins As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlAddTab As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlSep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlSep3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlZIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlZOut As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlSep4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlFind As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlTxtFind As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents mnuView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuView_Fullscreen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlFullScreen As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuSep6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuView_MenuBarMoveable As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuView_StatusBarShowing As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuView_Toolbar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuView_Toolbar_Showing As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuView_Toolbar_Moveable As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSep7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuView_MinimizetoTaskbar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlSep5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlFont As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuEdit_Find As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit_Replace As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSep8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFile_PrintSetup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents nticoMain As System.Windows.Forms.NotifyIcon
    Friend WithEvents cmnuNIcon As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents fDiaMain As System.Windows.Forms.FontDialog
    Friend WithEvents sDiaMain As System.Windows.Forms.SaveFileDialog
    Friend WithEvents oDiaMain As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tlSep6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbcnMain As System.Windows.Forms.TabControl
    Friend WithEvents cmnuRTB As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmnuCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmnuSelectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ppDiaMain As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents pDiaMain As System.Windows.Forms.PrintDialog
    Friend WithEvents pDoc As System.Drawing.Printing.PrintDocument
    Friend WithEvents psDiaMain As System.Windows.Forms.PageSetupDialog
    Friend WithEvents mnuSep9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuOptions_Pref As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuSep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmnuHighlight As System.Windows.Forms.ToolStripMenuItem
End Class
