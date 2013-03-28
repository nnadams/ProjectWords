Imports System.Text.RegularExpressions
Imports System.Reflection

Module Plugins
    Public thePlugins(0 To 100) As Type, numPlugin As Integer, PluginIsRunning(0 To 100) As Boolean

    Public Sub CheckForPlugins()
        If Not My.Settings.enabledPlugins Or My.Settings.PluginDir = "" Then Exit Sub
        If My.Computer.FileSystem.DirectoryExists(My.Settings.PluginDir) = False Then My.Computer.FileSystem.CreateDirectory(My.Settings.PluginDir) : Exit Sub

        For Each file As String In My.Computer.FileSystem.GetFiles(My.Settings.PluginDir)
            My.Application.Log.DefaultFileLogWriter.Location = Logging.LogFileLocation.Custom
            My.Application.Log.DefaultFileLogWriter.CustomLocation = My.Computer.FileSystem.SpecialDirectories.Desktop
            If Right(RemovePath(file), 4) = "plug" Then
                Try
                    My.Application.Log.WriteEntry(RemovePath(file))
                    Debug.Print(RemovePath(file))
                    Dim mAssembly As Assembly, mType As Type
                    My.Application.Log.WriteEntry("1")
                    mAssembly = Assembly.LoadFrom(file)
                    My.Application.Log.WriteEntry("2")
                    mType = mAssembly.GetType(mAssembly.GetName().Name & ".Plugin")
                    My.Application.Log.WriteEntry("3")
                    If mType Is Nothing Then Continue For
                    My.Application.Log.WriteEntry("valid")
                    thePlugins(numPlugin) = mType
                    numPlugin += 1
                Catch ex As Exception
                    My.Application.Log.DefaultFileLogWriter.Location = Logging.LogFileLocation.Custom
                    My.Application.Log.DefaultFileLogWriter.CustomLocation = My.Computer.FileSystem.SpecialDirectories.Desktop
                    My.Application.Log.WriteException(ex)
                    MsgBox("Opps! There was an error loading plugin: " & file & vbCrLf & vbCrLf & ex.Message & vbCrLf & vbCrLf & "This error was logged!", MsgBoxStyle.Critical, "Error - ProjectWords")
                    Continue For
                Finally
                    frmMain.mnuOptions_Plugins.Enabled = True
                    My.Application.Log.WriteEntry("...")
                End Try
            End If
        Next
        My.Application.Log.WriteEntry("done")
    End Sub

    Public Sub RunPlugin(ByVal PluginNumber As Integer)
        Dim mFlags As BindingFlags, mArg As New ArrayList, mObj As Object
        mFlags = BindingFlags.DeclaredOnly Or BindingFlags.Public Or BindingFlags.NonPublic Or BindingFlags.Instance
        mObj = thePlugins(PluginNumber).InvokeMember(Nothing, mFlags Or BindingFlags.CreateInstance, Nothing, Nothing, Nothing)
        mArg.Add(frmMain)
        thePlugins(PluginNumber).InvokeMember("Main", mFlags Or BindingFlags.InvokeMethod, Nothing, mObj, mArg.ToArray)
    End Sub

    Public Function RemovePath(ByVal Path As String)
        Path = Regex.Replace(Path, ".*\\", "")
        Return Path
    End Function
End Module