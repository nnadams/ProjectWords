<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStart
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
        Me.gbxMain = New System.Windows.Forms.GroupBox
        Me.lblDev = New System.Windows.Forms.Label
        Me.lblVersion = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.picLogo = New System.Windows.Forms.PictureBox
        Me.gbxMain.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxMain
        '
        Me.gbxMain.BackColor = System.Drawing.Color.Transparent
        Me.gbxMain.Controls.Add(Me.lblDev)
        Me.gbxMain.Controls.Add(Me.lblVersion)
        Me.gbxMain.Controls.Add(Me.lblTitle)
        Me.gbxMain.Controls.Add(Me.picLogo)
        Me.gbxMain.Location = New System.Drawing.Point(5, 0)
        Me.gbxMain.Name = "gbxMain"
        Me.gbxMain.Size = New System.Drawing.Size(539, 262)
        Me.gbxMain.TabIndex = 0
        Me.gbxMain.TabStop = False
        '
        'lblDev
        '
        Me.lblDev.AutoSize = True
        Me.lblDev.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDev.Location = New System.Drawing.Point(215, 221)
        Me.lblDev.Name = "lblDev"
        Me.lblDev.Size = New System.Drawing.Size(312, 29)
        Me.lblDev.TabIndex = 4
        Me.lblDev.Text = "Developed by Nick Adams"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(219, 71)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(0, 34)
        Me.lblVersion.TabIndex = 3
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 35.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(215, 16)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(328, 55)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "ProjectWords"
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Image = Global.ProjectWords.My.Resources.Resources.Logo
        Me.picLogo.Location = New System.Drawing.Point(-18, 9)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(227, 241)
        Me.picLogo.TabIndex = 1
        Me.picLogo.TabStop = False
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(549, 270)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbxMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStart"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStart"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Magenta
        Me.gbxMain.ResumeLayout(False)
        Me.gbxMain.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxMain As System.Windows.Forms.GroupBox
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents lblDev As System.Windows.Forms.Label

End Class
