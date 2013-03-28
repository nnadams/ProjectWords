Public Class frmPrefs

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If rdbPretty.Checked = True Then
            My.Settings.PrettyTabs = True
            My.Settings.Xs = False
        Else
            My.Settings.PrettyTabs = False
            My.Settings.Xs = chkXs.Checked
        End If

        My.Settings.enabledPlugins = chkPlugin.Checked
        My.Settings.PluginDir = txtPlugin.Text

        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub frmPrefs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.PrettyTabs = True Then
            rdbPretty.Checked = True
            rdbUgly.Checked = False
            chkXs.Enabled = False
            chkXs.Checked = False
        Else
            rdbPretty.Checked = False
            rdbUgly.Checked = True
            chkXs.Checked = My.Settings.Xs
        End If

        chkPlugin.Checked = My.Settings.enabledPlugins

        If My.Settings.PluginDir = "" Then My.Settings.PluginDir = My.Application.Info.DirectoryPath()
        My.Settings.Save()
        txtPlugin.Text = My.Settings.PluginDir
    End Sub

    Private Sub rdbPretty_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbPretty.CheckedChanged
        If rdbPretty.Checked = True Then
            chkXs.Checked = False
            chkXs.Enabled = False
        Else
            chkXs.Checked = My.Settings.Xs
            chkXs.Enabled = True
        End If
    End Sub

    Private Sub chkPlugin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPlugin.CheckedChanged
        If chkPlugin.Checked = False Then
            lblPlugin.Enabled = False
            txtPlugin.Enabled = False
            btnOpen.Enabled = False
        Else
            lblPlugin.Enabled = True
            txtPlugin.Enabled = True
            btnOpen.Enabled = True
        End If
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        fDiaMain.SelectedPath = txtPlugin.Text
        If fDiaMain.ShowDialog() = Windows.Forms.DialogResult.OK Then txtPlugin.Text = fDiaMain.SelectedPath
    End Sub
End Class