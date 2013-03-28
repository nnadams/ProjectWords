Imports System.Windows.Forms
Imports System.Reflection

Public Class frmPlugins

    Private Sub frmPlugins_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each plugin As Type In thePlugins
            If plugin Is Nothing Then Continue For
            Dim mFlags As BindingFlags, mArg As New ArrayList, mObj As Object, args As New ArrayList, wasLoaded As Boolean
            mFlags = BindingFlags.DeclaredOnly Or BindingFlags.Public Or BindingFlags.NonPublic Or BindingFlags.Instance
            mObj = plugin.InvokeMember(Nothing, mFlags Or BindingFlags.CreateInstance, Nothing, Nothing, Nothing)
            args.Add(frmMain)
            wasLoaded = plugin.InvokeMember("Load", mFlags Or BindingFlags.InvokeMethod, Nothing, mObj, args.ToArray)
            Dim Item As ListViewItem = lstvPlugins.Items.Add(IIf(wasLoaded, "Loaded", "Could Not Load"), IIf(wasLoaded, 0, 1))
            If PluginIsRunning(Item.Index) = True AndAlso Item.Text = "Loaded" Then
                Item.ImageKey = "running"
                Item.Text = "Running"
                btnRun.Enabled = False
                btnStop.Enabled = True
            End If
            Item.SubItems.Add(plugin.Namespace)
            Item.SubItems.Add(plugin.InvokeMember("GetDescription", mFlags Or BindingFlags.InvokeMethod, Nothing, mObj, Nothing))
        Next
    End Sub

    Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click
        On Error Resume Next
        If lstvPlugins.SelectedItems.Item(0).Tag <> "Running" Then
            If lstvPlugins.SelectedItems(0).Text = "Not Loaded" Or lstvPlugins.SelectedItems(0).Text = "Could Not Load" Then Exit Sub
            RunPlugin(lstvPlugins.SelectedItems.Item(0).Index)
            PluginIsRunning(lstvPlugins.SelectedItems.Item(0).Index) = True
            lstvPlugins.SelectedItems.Item(0).ImageIndex = 2
            lstvPlugins.SelectedItems.Item(0).Text = "Running"
            lstvPlugins.SelectedItems.Item(0).Tag = "Running"

            btnRun.Enabled = False
            btnStop.Enabled = True
        Else
            MsgBox("This plugin is already running!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub lstvPlugins_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstvPlugins.DoubleClick
        On Error Resume Next
        If lstvPlugins.SelectedItems.Item(0).Tag <> "Running" Then
            If lstvPlugins.SelectedItems(0).Text = "Not Loaded" Or lstvPlugins.SelectedItems(0).Text = "Could Not Load" Then Exit Sub
            RunPlugin(lstvPlugins.SelectedItems.Item(0).Index)
            PluginIsRunning(lstvPlugins.SelectedItems.Item(0).Index) = True
            lstvPlugins.SelectedItems.Item(0).ImageIndex = 2
            lstvPlugins.SelectedItems.Item(0).Text = "Running"
            lstvPlugins.SelectedItems.Item(0).Tag = "Running"

            btnRun.Enabled = False
            btnStop.Enabled = True
        Else
            MsgBox("This plugin is already running!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub lstvPlugins_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstvPlugins.SelectedIndexChanged
        On Error Resume Next
        If lstvPlugins.SelectedItems.Count = 0 Then
            btnRun.Enabled = False
            btnLoad.Enabled = False
            btnStop.Enabled = False
        ElseIf lstvPlugins.SelectedItems(0).Text = "Running" Then
            btnRun.Enabled = False
            btnLoad.Enabled = False
            btnStop.Enabled = True
        ElseIf lstvPlugins.SelectedItems(0).Text = "Not Loaded" Or lstvPlugins.SelectedItems(0).Text = "Could Not Load" Then
            btnRun.Enabled = False
            btnLoad.Enabled = True
            btnStop.Enabled = False
        Else
            btnRun.Enabled = True
            btnLoad.Enabled = False
            btnStop.Enabled = False
        End If
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        If lstvPlugins.SelectedItems.Item(0).Text <> "Running" Then Exit Sub
        Dim mFlags As BindingFlags, mArg As New ArrayList, mObj As Object, args As New ArrayList
        mFlags = BindingFlags.DeclaredOnly Or BindingFlags.Public Or BindingFlags.NonPublic Or BindingFlags.Instance
        mObj = thePlugins(lstvPlugins.SelectedItems.Item(0).Index).InvokeMember(Nothing, mFlags Or BindingFlags.CreateInstance, Nothing, Nothing, Nothing)
        args.Add(frmMain)
        thePlugins(lstvPlugins.SelectedItems.Item(0).Index).InvokeMember("Load", mFlags Or BindingFlags.InvokeMethod, Nothing, mObj, args.ToArray)
        thePlugins(lstvPlugins.SelectedItems.Item(0).Index).InvokeMember("EndPlugin", mFlags Or BindingFlags.InvokeMethod, Nothing, mObj, Nothing)

        PluginIsRunning(lstvPlugins.SelectedItems.Item(0).Index) = False
        lstvPlugins.SelectedItems.Item(0).ImageIndex = 1
        lstvPlugins.SelectedItems.Item(0).Text = "Not Loaded"
        lstvPlugins.SelectedItems.Item(0).Tag = ""

        btnRun.Enabled = False
        btnStop.Enabled = False
        btnLoad.Enabled = True
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        Dim mFlags As BindingFlags, mArg As New ArrayList, mObj As Object, args As New ArrayList, wasLoaded As Boolean
        mFlags = BindingFlags.DeclaredOnly Or BindingFlags.Public Or BindingFlags.NonPublic Or BindingFlags.Instance
        mObj = thePlugins(lstvPlugins.SelectedItems.Item(0).Index).InvokeMember(Nothing, mFlags Or BindingFlags.CreateInstance, Nothing, Nothing, Nothing)
        args.Add(frmMain)
        wasLoaded = thePlugins(lstvPlugins.SelectedItems.Item(0).Index).InvokeMember("Load", mFlags Or BindingFlags.InvokeMethod, Nothing, mObj, args.ToArray)
        lstvPlugins.SelectedItems.Item(0).Text = IIf(wasLoaded, "Loaded", "Could Not Load")
        lstvPlugins.SelectedItems.Item(0).ImageKey = IIf(wasLoaded, "loaded", "not_loaded")
        lstvPlugins.SelectedItems.Item(0).SubItems.Item(1).Text = thePlugins(lstvPlugins.SelectedItems.Item(0).Index).Namespace
        lstvPlugins.SelectedItems.Item(0).SubItems.Item(2).Text = thePlugins(lstvPlugins.SelectedItems.Item(0).Index).InvokeMember("GetDescription", mFlags Or BindingFlags.InvokeMethod, Nothing, mObj, Nothing)
        PluginIsRunning(lstvPlugins.SelectedItems.Item(0).Index) = False

        btnRun.Enabled = True
        btnLoad.Enabled = False
        btnStop.Enabled = False
    End Sub
End Class
