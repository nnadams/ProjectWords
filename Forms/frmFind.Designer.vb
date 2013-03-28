<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFind
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFind))
        Me.tbcnMain = New System.Windows.Forms.TabControl
        Me.tpFind = New System.Windows.Forms.TabPage
        Me.chkCase = New System.Windows.Forms.CheckBox
        Me.btnFind = New System.Windows.Forms.Button
        Me.txtFind = New System.Windows.Forms.TextBox
        Me.lblFind = New System.Windows.Forms.Label
        Me.tpReplace = New System.Windows.Forms.TabPage
        Me.txtReplace = New System.Windows.Forms.TextBox
        Me.lblReplace = New System.Windows.Forms.Label
        Me.chkrCase = New System.Windows.Forms.CheckBox
        Me.txtfReplace = New System.Windows.Forms.TextBox
        Me.btnReplace = New System.Windows.Forms.Button
        Me.btnReplaceAll = New System.Windows.Forms.Button
        Me.lblfReplace = New System.Windows.Forms.Label
        Me.tbGoto = New System.Windows.Forms.TabPage
        Me.btnGo = New System.Windows.Forms.Button
        Me.lblLine = New System.Windows.Forms.Label
        Me.udLine = New System.Windows.Forms.NumericUpDown
        Me.tbcnMain.SuspendLayout()
        Me.tpFind.SuspendLayout()
        Me.tpReplace.SuspendLayout()
        Me.tbGoto.SuspendLayout()
        CType(Me.udLine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcnMain
        '
        Me.tbcnMain.Controls.Add(Me.tpFind)
        Me.tbcnMain.Controls.Add(Me.tpReplace)
        Me.tbcnMain.Controls.Add(Me.tbGoto)
        Me.tbcnMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcnMain.Location = New System.Drawing.Point(0, 0)
        Me.tbcnMain.Name = "tbcnMain"
        Me.tbcnMain.SelectedIndex = 0
        Me.tbcnMain.Size = New System.Drawing.Size(330, 97)
        Me.tbcnMain.TabIndex = 0
        '
        'tpFind
        '
        Me.tpFind.Controls.Add(Me.chkCase)
        Me.tpFind.Controls.Add(Me.btnFind)
        Me.tpFind.Controls.Add(Me.txtFind)
        Me.tpFind.Controls.Add(Me.lblFind)
        Me.tpFind.Location = New System.Drawing.Point(4, 22)
        Me.tpFind.Margin = New System.Windows.Forms.Padding(0)
        Me.tpFind.Name = "tpFind"
        Me.tpFind.Size = New System.Drawing.Size(322, 71)
        Me.tpFind.TabIndex = 0
        Me.tpFind.Text = "Find"
        Me.tpFind.UseVisualStyleBackColor = True
        '
        'chkCase
        '
        Me.chkCase.AutoSize = True
        Me.chkCase.Location = New System.Drawing.Point(8, 49)
        Me.chkCase.Name = "chkCase"
        Me.chkCase.Size = New System.Drawing.Size(83, 17)
        Me.chkCase.TabIndex = 3
        Me.chkCase.Text = "Match Case"
        Me.chkCase.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(238, 45)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(75, 23)
        Me.btnFind.TabIndex = 2
        Me.btnFind.Text = "Find Next"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(72, 18)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(242, 20)
        Me.txtFind.TabIndex = 1
        '
        'lblFind
        '
        Me.lblFind.AutoSize = True
        Me.lblFind.Location = New System.Drawing.Point(3, 21)
        Me.lblFind.Name = "lblFind"
        Me.lblFind.Size = New System.Drawing.Size(63, 13)
        Me.lblFind.TabIndex = 0
        Me.lblFind.Text = "Text to find:"
        '
        'tpReplace
        '
        Me.tpReplace.Controls.Add(Me.txtReplace)
        Me.tpReplace.Controls.Add(Me.lblReplace)
        Me.tpReplace.Controls.Add(Me.chkrCase)
        Me.tpReplace.Controls.Add(Me.txtfReplace)
        Me.tpReplace.Controls.Add(Me.btnReplace)
        Me.tpReplace.Controls.Add(Me.btnReplaceAll)
        Me.tpReplace.Controls.Add(Me.lblfReplace)
        Me.tpReplace.Location = New System.Drawing.Point(4, 22)
        Me.tpReplace.Margin = New System.Windows.Forms.Padding(0)
        Me.tpReplace.Name = "tpReplace"
        Me.tpReplace.Size = New System.Drawing.Size(322, 71)
        Me.tpReplace.TabIndex = 1
        Me.tpReplace.Text = "Replace"
        Me.tpReplace.UseVisualStyleBackColor = True
        '
        'txtReplace
        '
        Me.txtReplace.Location = New System.Drawing.Point(90, 29)
        Me.txtReplace.Name = "txtReplace"
        Me.txtReplace.Size = New System.Drawing.Size(224, 20)
        Me.txtReplace.TabIndex = 9
        '
        'lblReplace
        '
        Me.lblReplace.AutoSize = True
        Me.lblReplace.Location = New System.Drawing.Point(3, 32)
        Me.lblReplace.Name = "lblReplace"
        Me.lblReplace.Size = New System.Drawing.Size(81, 13)
        Me.lblReplace.TabIndex = 8
        Me.lblReplace.Text = "Text to replace:"
        '
        'chkrCase
        '
        Me.chkrCase.AutoSize = True
        Me.chkrCase.Location = New System.Drawing.Point(6, 64)
        Me.chkrCase.Name = "chkrCase"
        Me.chkrCase.Size = New System.Drawing.Size(83, 17)
        Me.chkrCase.TabIndex = 7
        Me.chkrCase.Text = "Match Case"
        Me.chkrCase.UseVisualStyleBackColor = True
        '
        'txtfReplace
        '
        Me.txtfReplace.Location = New System.Drawing.Point(90, 3)
        Me.txtfReplace.Name = "txtfReplace"
        Me.txtfReplace.Size = New System.Drawing.Size(224, 20)
        Me.txtfReplace.TabIndex = 5
        '
        'btnReplace
        '
        Me.btnReplace.Location = New System.Drawing.Point(158, 60)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(75, 23)
        Me.btnReplace.TabIndex = 6
        Me.btnReplace.Text = "Replace"
        Me.btnReplace.UseVisualStyleBackColor = True
        '
        'btnReplaceAll
        '
        Me.btnReplaceAll.Location = New System.Drawing.Point(239, 60)
        Me.btnReplaceAll.Name = "btnReplaceAll"
        Me.btnReplaceAll.Size = New System.Drawing.Size(75, 23)
        Me.btnReplaceAll.TabIndex = 6
        Me.btnReplaceAll.Text = "Replace All"
        Me.btnReplaceAll.UseVisualStyleBackColor = True
        '
        'lblfReplace
        '
        Me.lblfReplace.AutoSize = True
        Me.lblfReplace.Location = New System.Drawing.Point(3, 6)
        Me.lblfReplace.Name = "lblfReplace"
        Me.lblfReplace.Size = New System.Drawing.Size(63, 13)
        Me.lblfReplace.TabIndex = 4
        Me.lblfReplace.Text = "Text to find:"
        '
        'tbGoto
        '
        Me.tbGoto.Controls.Add(Me.btnGo)
        Me.tbGoto.Controls.Add(Me.lblLine)
        Me.tbGoto.Controls.Add(Me.udLine)
        Me.tbGoto.Location = New System.Drawing.Point(4, 22)
        Me.tbGoto.Margin = New System.Windows.Forms.Padding(0)
        Me.tbGoto.Name = "tbGoto"
        Me.tbGoto.Size = New System.Drawing.Size(322, 71)
        Me.tbGoto.TabIndex = 2
        Me.tbGoto.Text = "GoTo"
        Me.tbGoto.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(192, 43)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 2
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'lblLine
        '
        Me.lblLine.AutoSize = True
        Me.lblLine.Location = New System.Drawing.Point(35, 19)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(106, 13)
        Me.lblLine.TabIndex = 1
        Me.lblLine.Text = "Select a line number:"
        '
        'udLine
        '
        Me.udLine.Location = New System.Drawing.Point(147, 17)
        Me.udLine.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.udLine.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.udLine.Name = "udLine"
        Me.udLine.Size = New System.Drawing.Size(120, 20)
        Me.udLine.TabIndex = 0
        Me.udLine.ThousandsSeparator = True
        Me.udLine.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'frmFind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 97)
        Me.Controls.Add(Me.tbcnMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFind"
        Me.ShowInTaskbar = False
        Me.Text = "Find - ProjectWords"
        Me.TopMost = True
        Me.tbcnMain.ResumeLayout(False)
        Me.tpFind.ResumeLayout(False)
        Me.tpFind.PerformLayout()
        Me.tpReplace.ResumeLayout(False)
        Me.tpReplace.PerformLayout()
        Me.tbGoto.ResumeLayout(False)
        Me.tbGoto.PerformLayout()
        CType(Me.udLine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbcnMain As System.Windows.Forms.TabControl
    Friend WithEvents tpFind As System.Windows.Forms.TabPage
    Friend WithEvents tpReplace As System.Windows.Forms.TabPage
    Friend WithEvents tbGoto As System.Windows.Forms.TabPage
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents lblLine As System.Windows.Forms.Label
    Friend WithEvents udLine As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtFind As System.Windows.Forms.TextBox
    Friend WithEvents lblFind As System.Windows.Forms.Label
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents chkCase As System.Windows.Forms.CheckBox
    Friend WithEvents txtReplace As System.Windows.Forms.TextBox
    Friend WithEvents lblReplace As System.Windows.Forms.Label
    Friend WithEvents chkrCase As System.Windows.Forms.CheckBox
    Friend WithEvents txtfReplace As System.Windows.Forms.TextBox
    Friend WithEvents btnReplaceAll As System.Windows.Forms.Button
    Friend WithEvents lblfReplace As System.Windows.Forms.Label
    Friend WithEvents btnReplace As System.Windows.Forms.Button
End Class
