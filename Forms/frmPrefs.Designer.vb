<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrefs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrefs))
        Me.rdbPretty = New System.Windows.Forms.RadioButton
        Me.rdbUgly = New System.Windows.Forms.RadioButton
        Me.chkXs = New System.Windows.Forms.CheckBox
        Me.gbTabs = New System.Windows.Forms.GroupBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.gbPlugins = New System.Windows.Forms.GroupBox
        Me.chkPlugin = New System.Windows.Forms.CheckBox
        Me.txtPlugin = New System.Windows.Forms.TextBox
        Me.btnOpen = New System.Windows.Forms.Button
        Me.lblPlugin = New System.Windows.Forms.Label
        Me.fDiaMain = New System.Windows.Forms.FolderBrowserDialog
        Me.gbTabs.SuspendLayout()
        Me.gbPlugins.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdbPretty
        '
        Me.rdbPretty.AutoSize = True
        Me.rdbPretty.Location = New System.Drawing.Point(6, 42)
        Me.rdbPretty.Name = "rdbPretty"
        Me.rdbPretty.Size = New System.Drawing.Size(79, 17)
        Me.rdbPretty.TabIndex = 0
        Me.rdbPretty.Text = "Pretty Tabs"
        Me.rdbPretty.UseVisualStyleBackColor = True
        '
        'rdbUgly
        '
        Me.rdbUgly.AutoSize = True
        Me.rdbUgly.Checked = True
        Me.rdbUgly.Location = New System.Drawing.Point(6, 19)
        Me.rdbUgly.Name = "rdbUgly"
        Me.rdbUgly.Size = New System.Drawing.Size(74, 17)
        Me.rdbUgly.TabIndex = 1
        Me.rdbUgly.TabStop = True
        Me.rdbUgly.Text = "Gray Tabs"
        Me.rdbUgly.UseVisualStyleBackColor = True
        '
        'chkXs
        '
        Me.chkXs.AutoSize = True
        Me.chkXs.Checked = True
        Me.chkXs.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkXs.Location = New System.Drawing.Point(96, 19)
        Me.chkXs.Name = "chkXs"
        Me.chkXs.Size = New System.Drawing.Size(78, 17)
        Me.chkXs.TabIndex = 2
        Me.chkXs.Text = "X's on tabs"
        Me.chkXs.UseVisualStyleBackColor = True
        '
        'gbTabs
        '
        Me.gbTabs.Controls.Add(Me.rdbUgly)
        Me.gbTabs.Controls.Add(Me.chkXs)
        Me.gbTabs.Controls.Add(Me.rdbPretty)
        Me.gbTabs.Location = New System.Drawing.Point(3, 34)
        Me.gbTabs.Name = "gbTabs"
        Me.gbTabs.Size = New System.Drawing.Size(185, 71)
        Me.gbTabs.TabIndex = 3
        Me.gbTabs.TabStop = False
        Me.gbTabs.Text = "Tabs"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(439, 111)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.Location = New System.Drawing.Point(358, 111)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 5
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(1, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Restart ProjectWords to see any changes you made."
        '
        'gbPlugins
        '
        Me.gbPlugins.Controls.Add(Me.lblPlugin)
        Me.gbPlugins.Controls.Add(Me.btnOpen)
        Me.gbPlugins.Controls.Add(Me.txtPlugin)
        Me.gbPlugins.Controls.Add(Me.chkPlugin)
        Me.gbPlugins.Location = New System.Drawing.Point(195, 34)
        Me.gbPlugins.Name = "gbPlugins"
        Me.gbPlugins.Size = New System.Drawing.Size(319, 71)
        Me.gbPlugins.TabIndex = 8
        Me.gbPlugins.TabStop = False
        Me.gbPlugins.Text = "Plugins"
        '
        'chkPlugin
        '
        Me.chkPlugin.AutoSize = True
        Me.chkPlugin.Checked = True
        Me.chkPlugin.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPlugin.Location = New System.Drawing.Point(7, 20)
        Me.chkPlugin.Name = "chkPlugin"
        Me.chkPlugin.Size = New System.Drawing.Size(96, 17)
        Me.chkPlugin.TabIndex = 0
        Me.chkPlugin.Text = "Enable Plugins"
        Me.chkPlugin.UseVisualStyleBackColor = True
        '
        'txtPlugin
        '
        Me.txtPlugin.Location = New System.Drawing.Point(67, 45)
        Me.txtPlugin.Name = "txtPlugin"
        Me.txtPlugin.Size = New System.Drawing.Size(214, 20)
        Me.txtPlugin.TabIndex = 1
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(287, 43)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(26, 23)
        Me.btnOpen.TabIndex = 2
        Me.btnOpen.Text = "..."
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'lblPlugin
        '
        Me.lblPlugin.AutoSize = True
        Me.lblPlugin.Location = New System.Drawing.Point(6, 48)
        Me.lblPlugin.Name = "lblPlugin"
        Me.lblPlugin.Size = New System.Drawing.Size(55, 13)
        Me.lblPlugin.TabIndex = 3
        Me.lblPlugin.Text = "Plugin Dir:"
        '
        'fDiaMain
        '
        Me.fDiaMain.RootFolder = System.Environment.SpecialFolder.DesktopDirectory
        '
        'frmPrefs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 136)
        Me.Controls.Add(Me.gbPlugins)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.gbTabs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrefs"
        Me.ShowInTaskbar = False
        Me.Text = "Preferences - ProjectWords"
        Me.gbTabs.ResumeLayout(False)
        Me.gbTabs.PerformLayout()
        Me.gbPlugins.ResumeLayout(False)
        Me.gbPlugins.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdbPretty As System.Windows.Forms.RadioButton
    Friend WithEvents rdbUgly As System.Windows.Forms.RadioButton
    Friend WithEvents chkXs As System.Windows.Forms.CheckBox
    Friend WithEvents gbTabs As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbPlugins As System.Windows.Forms.GroupBox
    Friend WithEvents lblPlugin As System.Windows.Forms.Label
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents txtPlugin As System.Windows.Forms.TextBox
    Friend WithEvents chkPlugin As System.Windows.Forms.CheckBox
    Friend WithEvents fDiaMain As System.Windows.Forms.FolderBrowserDialog
End Class
