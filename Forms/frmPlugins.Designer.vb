<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlugins
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
        Dim clhDescription As System.Windows.Forms.ColumnHeader
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlugins))
        Me.lstvPlugins = New System.Windows.Forms.ListView
        Me.clhLoaded = New System.Windows.Forms.ColumnHeader
        Me.clhName = New System.Windows.Forms.ColumnHeader
        Me.imglstMain = New System.Windows.Forms.ImageList(Me.components)
        Me.lblText = New System.Windows.Forms.Label
        Me.btnRun = New System.Windows.Forms.Button
        Me.btnStop = New System.Windows.Forms.Button
        Me.btnLoad = New System.Windows.Forms.Button
        clhDescription = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'clhDescription
        '
        clhDescription.Text = "Description"
        clhDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        clhDescription.Width = 235
        '
        'lstvPlugins
        '
        Me.lstvPlugins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstvPlugins.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clhLoaded, Me.clhName, clhDescription})
        Me.lstvPlugins.Dock = System.Windows.Forms.DockStyle.Top
        Me.lstvPlugins.FullRowSelect = True
        Me.lstvPlugins.GridLines = True
        Me.lstvPlugins.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvPlugins.Location = New System.Drawing.Point(0, 0)
        Me.lstvPlugins.MultiSelect = False
        Me.lstvPlugins.Name = "lstvPlugins"
        Me.lstvPlugins.ShowGroups = False
        Me.lstvPlugins.Size = New System.Drawing.Size(490, 291)
        Me.lstvPlugins.SmallImageList = Me.imglstMain
        Me.lstvPlugins.TabIndex = 0
        Me.lstvPlugins.UseCompatibleStateImageBehavior = False
        Me.lstvPlugins.View = System.Windows.Forms.View.Details
        '
        'clhLoaded
        '
        Me.clhLoaded.Text = "Loaded"
        Me.clhLoaded.Width = 100
        '
        'clhName
        '
        Me.clhName.Text = "Name"
        Me.clhName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clhName.Width = 130
        '
        'imglstMain
        '
        Me.imglstMain.ImageStream = CType(resources.GetObject("imglstMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglstMain.TransparentColor = System.Drawing.Color.Transparent
        Me.imglstMain.Images.SetKeyName(0, "loaded")
        Me.imglstMain.Images.SetKeyName(1, "not_loaded")
        Me.imglstMain.Images.SetKeyName(2, "running")
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(-3, 299)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(248, 13)
        Me.lblText.TabIndex = 1
        Me.lblText.Text = "Select a plugin from the list and click Run to start it."
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(251, 294)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(75, 23)
        Me.btnRun.TabIndex = 2
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Location = New System.Drawing.Point(413, 294)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 3
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Enabled = False
        Me.btnLoad.Location = New System.Drawing.Point(332, 294)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 4
        Me.btnLoad.Text = "Reload"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'frmPlugins
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 319)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.lstvPlugins)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPlugins"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Plugins - ProjectWords"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstvPlugins As System.Windows.Forms.ListView
    Friend WithEvents clhLoaded As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhName As System.Windows.Forms.ColumnHeader
    Friend WithEvents imglstMain As System.Windows.Forms.ImageList
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button

End Class
