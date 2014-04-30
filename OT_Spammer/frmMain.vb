Imports System
Imports System.Text
Imports System.IO
Imports System.Net
Imports System.Buffer
Imports System.Net.Sockets
Imports Microsoft.VisualBasic
Imports System.Threading
Imports System.Runtime.InteropServices




Public Class frmMain
    Public Declare Function GetDesktopWindow Lib "user32" () As Integer
    Public Declare Function FindWindowEx Lib "user32" Alias "FindWindowExA" (ByVal hWnd1 As Integer, ByVal hWnd2 As Integer, ByVal lpsz1 As String, ByVal lpsz2 As String) As Integer

    Public Declare Function OpenProcess Lib "kernel32.dll" (ByVal dwDesiredAccess As Integer, ByVal bInheritHandle As Integer, ByVal dwProcessId As Integer) As Integer
    Public Declare Function CloseHandle Lib "kernel32.dll" (ByVal hObject As Integer) As Integer

    Public Declare Function WriteProcessMemory Lib "kernel32.dll" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As String, ByVal nSize As Long, ByRef lpNumberOfBytesWritten As Integer) As Integer
    Public Declare Function WriteProcessMemory Lib "kernel32.dll" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Long, ByVal nSize As Long, ByRef lpNumberOfBytesWritten As Integer) As Integer
    Public Declare Function WriteProcessMemory Lib "kernel32.dll" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Integer, ByVal nSize As Long, ByRef lpNumberOfBytesWritten As Integer) As Integer
    Public Declare Function WriteProcessMemory Lib "kernel32.dll" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Byte, ByVal nSize As Long, ByRef lpNumberOfBytesWritten As Integer) As Integer

    Public Declare Function ReadProcessMemory Lib "kernel32.dll" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Integer, ByVal nSize As Long, ByRef lpNumberOfBytesWritten As Integer) As Integer
    Public Declare Function ReadProcessMemory Lib "kernel32.dll" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Int16, ByVal nSize As Long, ByRef lpNumberOfBytesWritten As Integer) As Integer
    Public Declare Function ReadProcessMemory Lib "kernel32.dll" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Byte, ByVal nSize As Long, ByRef lpNumberOfBytesWritten As Integer) As Integer
    Public Declare Function ReadProcessMemory Lib "kernel32.dll" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As String, ByVal nSize As Long, ByRef lpNumberOfBytesWritten As Integer) As Integer
    Public Declare Function ReadProcessMemory Lib "kernel32.dll" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Long, ByVal nSize As Long, ByRef lpNumberOfBytesWritten As Integer) As Integer

    Private Delegate Sub DoListDelegate(ByVal InputStr As String, ByVal Action As String)
    Private Delegate Sub DoLogDelegate(ByVal InputStr As String)
    Private Delegate Sub DoErrorLogDelegate(ByVal InputStr As String)

    Public Const PROCESS_VM_READ = (&H10)
    Public Const PROCESS_VM_WRITE = (&H20)
    Public Const PROCESS_VM_OPERATION = (&H8)
    Public Const PROCESS_QUERY_INFORMATION = (&H400)
    Public Const PROCESS_READ_WRITE_QUERY = PROCESS_VM_READ + PROCESS_VM_WRITE + PROCESS_VM_OPERATION + PROCESS_QUERY_INFORMATION
    Public Const PROCESS_ALL_ACCESS = &H1F0FFF

    Public PMs_Countdown As Integer = 0
    Public PMs_Player_Countdown As Integer = 0
    Public Default_Countdown As Integer = 0
    Public GameChat_Countdown As Integer = 0
    Public Trade_Countdown As Integer = 0
    Public Help_Countdown As Integer = 0
    Public AntiIdle_Countdown As Integer = 0
    Public PMs_CurrentPlayer As Integer = 0
    Public PMs_MaxPlayers As Integer = 0

    Private sckClient As Winsock
    Public Settings As Settings
    Public PMs() As String = {"", "", ""}
    Public Shared FormLoaded As Boolean = False



    Private Sub btnAddIgnore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddIgnore.Click
        If txtIgnore.Text <> "" Then
            lstIgnore.Items.Add(txtIgnore.Text)
            txtIgnore.Text = ""

            Settings.SetSetting("IgnoreList", ListToString(lstIgnore))
        End If
    End Sub

    Private Sub btnRmIgnore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRmIgnore.Click
        txtIgnore.Text = lstIgnore.Text
        If lstIgnore.SelectedIndex <> -1 Then lstIgnore.Items.RemoveAt(lstIgnore.SelectedIndex)

        Settings.SetSetting("IgnoreList", ListToString(lstIgnore))
    End Sub


    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click


        sckClient.Connect(txtIP.Text, 7171)

    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Settings.SetSetting("PM0", PMs(0).ToString)
        Settings.SetSetting("PM1", PMs(1).ToString)
        Settings.SetSetting("PM2", PMs(2).ToString)

        Settings.SetSetting("PM_Delay", txtDelayPMs.Text)
        Settings.SetSetting("PM_MsgsDelay", txtDelayMsgs.Text)

        Settings.SetSetting("Default", txtDefault.Text)
        Settings.SetSetting("Default_Yell", chkYell.CheckState)
        Settings.SetSetting("Default_Delay", txtDelayDefault.Text)

        Settings.SetSetting("Trade", txtTrade.Text)
        Settings.SetSetting("Trade_Delay", txtDelayTrade.Text)

        Settings.SetSetting("GameChat", txtGameChat.Text)
        Settings.SetSetting("GameChat_Delay", txtDelayGameChat.Text)

        Settings.SetSetting("Help", txtHelp.Text)
        Settings.SetSetting("Help_Delay", txtDelayHelp.Text)

        Settings.SetSetting("IgnoreList", ListToString(lstIgnore))
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sckClient = New Winsock()
        Settings = New Settings()

        If System.IO.File.Exists(Application.LocalUserAppDataPath & "\Settings.xml") Then
            PMs(0) = Settings.GetSetting("PM0")
            PMs(1) = Settings.GetSetting("PM1")
            PMs(2) = Settings.GetSetting("PM2")
            txtDelayPMs.Text = Settings.GetSetting("PM_Delay")
            txtDelayMsgs.Text = Val(Settings.GetSetting("PM_MsgsDelay"))

            txtDefault.Text = Settings.GetSetting("Default")
            chkYell.CheckState = Val(Settings.GetSetting("Default_Yell"))
            txtDelayDefault.Text = Settings.GetSetting("Default_Delay")

            txtTrade.Text = Settings.GetSetting("Trade")
            txtDelayTrade.Text = Settings.GetSetting("Trade_Delay")

            txtGameChat.Text = Settings.GetSetting("GameChat")
            txtDelayGameChat.Text = Settings.GetSetting("GameChat_Delay")

            txtHelp.Text = Settings.GetSetting("Help")
            txtDelayHelp.Text = Settings.GetSetting("Help_Delay")

            StringToList(Settings.GetSetting("IgnoreList"), lstIgnore)
        End If

        cmbPMs.SelectedIndex = 0
        cmbChannelHelp.SelectedIndex = 6
        cmbChannelTrade.SelectedIndex = 3
        cmbChannelGameChat.SelectedIndex = 2
        

        AddHandler sckClient.Connected, AddressOf sckClient_Connected
        AddHandler sckClient.ConnectionError, AddressOf sckClient_ConnectionError
        AddHandler sckClient.Disconnected, AddressOf sckClient_Disconnected
        AddHandler sckClient.DisconnectError, AddressOf sckClient_DisconnectError
        AddHandler sckClient.IncomingData, AddressOf sckClient_IncomingData
        AddHandler sckClient.IncomingDataBin, AddressOf sckClient_IncomingDataBin
        AddHandler sckClient.IncomingDataError, AddressOf sckClient_IncomingDataError
        AddHandler sckClient.SendDataError, AddressOf sckClient_SendDataError

        FormLoaded = True
    End Sub
    '************************************************************
    'Primary Socket Functionality
    '************************************************************
    Private Sub sckClient_Connected()
        sckClient.Send(Chr(3) & Chr(0) & Chr(255) & Chr(1) & Chr(40))
    End Sub

    Private Sub sckClient_Disconnected()

    End Sub

    Private Sub sckClient_IncomingData(ByRef Data As String)
        If Data.Length > 0 Then

        End If
    End Sub
    Private Sub sckClient_IncomingDataBin(ByRef Data() As Byte)
        If Data.Length > 0 Then
            sckClient.Disconnect()
            DoLog("")
            DoList("", "clear")
            DoLog("Server: " & txtIP.Text)
            Dim sckError As Boolean = False
            Dim bpos As Integer = 0
            Dim blen As Integer = 0
            Dim plen As Integer = 0
            Dim pid As Byte = 0
            Dim ponline As Integer = 0
            Dim pmax As Integer = 0
            Dim precord As Integer = 0
            Dim plistsize As Integer = 0
            Dim j As Integer = 0
            Dim lenpname As Integer = 0
            Dim pname As String = ""
            Dim plevel As Integer = 0
            Dim Message As String = ""

            blen = Data.Length
            DoLog("Packet Size: " & blen)

            ByteToLong(Data, plen, bpos, 2)
            DoLog("Packet Length: " & plen)
            bpos = bpos + 2
            If plen <> blen - 2 Then DoLog("This packet seems faulty!")

            ByteToLong(Data, pid, bpos, 1)
            DoLog("PacketID: 0x" & Hex(pid))
            bpos = bpos + 1


            ByteToLong(Data, ponline, bpos, 4)
            DoLog("Players Online: " & ponline)
            bpos = bpos + 4


            ByteToLong(Data, pmax, bpos, 4)
            DoLog("Player Limit: " & pmax)
            bpos = bpos + 4


            ByteToLong(Data, precord, bpos, 4)
            DoLog("Players Online Record: " & precord)
            bpos = bpos + 4

            ByteToLong(Data, pid, bpos, 1)
            DoLog("PacketID: 0x" & Hex(pid))
            bpos = bpos + 1

            ByteToLong(Data, plistsize, bpos, 4)
            DoLog("List size: " & plistsize)
            bpos = bpos + 4

            DoList("", "clear")
            Try
                While bpos < blen - 2
                    ByteToLong(Data, lenpname, bpos, 2)
                    bpos = bpos + 2

                    ByteToString(Data, pname, bpos, lenpname)
                    bpos = bpos + lenpname

                    ByteToLong(Data, plevel, bpos, 4)
                    bpos = bpos + 4

                    DoList(Replace(pname, Chr(0), "") & " - L:" & plevel, "add")

                End While
            Catch ex As Exception
                Message = "ERROR #" & Err.Number & " - Source: " & Err.Source & " - Description: " & Err.Description
                DoErrorLog(Message)
                sckError = True
            Finally
                DoLog("Players retrieved: " & List1.Items.Count)
                PMs_MaxPlayers = List1.Items.Count
                If Not sckError Then
                    DoLog("SUCCESS!")
                Else
                    DoLog("It seems that an error occured while fetching the list, please check the results!")
                End If

            End Try

            'Err.Raise(Err.Number, Err.Source, Err.Description)


        End If
    End Sub


    '************************************************************
    'Functional Error Reporting (Below)
    '************************************************************
    Private Sub sckClient_ConnectionError(ByVal Message As String)
        DoErrorLog(Message)
    End Sub

    Private Sub sckClient_DisconnectError(ByVal Message As String)
        DoErrorLog(Message)
    End Sub

    Private Sub sckClient_IncomingDataError(ByVal Message As String)
        DoErrorLog(Message)
    End Sub

    Private Sub sckClient_SendDataError(ByVal Message As String)
        DoErrorLog(Message)
    End Sub


    Private Sub DoList(ByVal InputStr As String, ByVal Action As String)
        If Me.InvokeRequired Then
            Me.Invoke(New DoListDelegate(AddressOf DoList), InputStr, Action)
        Else
            If Action.ToLower = "add" Then
                Me.List1.Items.Add(InputStr)
                Me.ListBox1.Items.Add(InputStr)
            ElseIf Action.ToLower = "clear" Then
                Me.List1.Items.Clear()
                Me.ListBox1.Items.Clear()
            End If
        End If
    End Sub

    Private Sub DoLog(ByVal InputStr As String)
        If Me.InvokeRequired Then
            Me.Invoke(New DoLogDelegate(AddressOf DoLog), InputStr)
        Else
            txtLog.Text = txtLog.Text & InputStr & vbNewLine
            If InputStr = "" Then txtLog.Text = ""
        End If
    End Sub

    Private Sub DoErrorLog(ByVal InputStr As String)
        If Me.InvokeRequired Then
            Me.Invoke(New DoErrorLogDelegate(AddressOf DoErrorLog), InputStr)
        Else
            txtPM_Log.Text += InputStr & vbNewLine
        End If
    End Sub

    Private Function ByteToLong(ByRef Source As Byte(), ByRef Destination As Integer, ByVal StartIndex As Integer, ByVal Length As Integer) As Boolean
        ByteToLong = True
        Dim MyGC As GCHandle
        Dim DestPointer As IntPtr
        Try
            MyGC = GCHandle.Alloc(Destination, GCHandleType.Pinned)
            DestPointer = MyGC.AddrOfPinnedObject()
            Marshal.Copy(Source, StartIndex, DestPointer, Length)
            Destination = Marshal.ReadInt32(DestPointer)

        Catch ex As Exception
            Err.Raise(Err.Number, Err.Source, Err.Description)
            ByteToLong = False
        Finally
            MyGC.Free()
        End Try
    End Function
    Private Function ByteToString(ByRef Source As Byte(), ByRef Destination As String, ByVal StartIndex As Integer, ByVal Length As Integer) As Boolean
        ByteToString = True
        Dim TempArray(255) As Byte
        Dim enc As New System.Text.UTF8Encoding()
        Try
            Array.ConstrainedCopy(Source, StartIndex, TempArray, 0, Length)
            Destination = enc.GetString(TempArray)

        Catch ex As Exception
            Err.Raise(Err.Number, Err.Source, Err.Description)
            ByteToString = False
        End Try
    End Function

    Private Sub chkPMs_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPMs.CheckedChanged
        If chkPMs.Checked Then
            If Tibia_PID = 0 Then chkPMs.Checked = False : MsgBox("Please first select a client!") : Exit Sub
            PMs_Countdown = 0
            PMs_Player_Countdown = 0
            tmrPMs.Start()
        Else
            tmrPMs.Stop()
        End If
    End Sub

    Private Sub chkDefault_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDefault.CheckedChanged
        If chkDefault.Checked Then
            If Tibia_PID = 0 Then chkDefault.Checked = False : MsgBox("Please first select a client!") : Exit Sub
            Default_Countdown = 0
            tmrDefault.Start()
        Else
            tmrDefault.Stop()

        End If
    End Sub

    Private Sub chkTrade_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTrade.CheckedChanged
        If chkTrade.Checked Then
            If Tibia_PID = 0 Then chkTrade.Checked = False : MsgBox("Please first select a client!") : Exit Sub
            Trade_Countdown = 0
            tmrTrade.Start()
        Else
            tmrTrade.Stop()
        End If
    End Sub

    Private Sub chkGameChat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGameChat.CheckedChanged
        If chkGameChat.Checked Then
            If Tibia_PID = 0 Then chkGameChat.Checked = False : MsgBox("Please first select a client!") : Exit Sub
            GameChat_Countdown = 0
            tmrGameChat.Start()
        Else
            tmrGameChat.Stop()
        End If
    End Sub

    Private Sub chkHelp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHelp.CheckedChanged
        If chkHelp.Checked Then
            If Tibia_PID = 0 Then chkHelp.Checked = False : MsgBox("Please first select a client!") : Exit Sub
            Help_Countdown = 0
            tmrHelp.Start()
        Else
            tmrHelp.Stop()
        End If
    End Sub

    Private Sub tmrPMs_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPMs.Tick
        If Tibia_PID = 0 Then chkPMs.Checked = False : tmrPMs.Stop()
        If txtPM.TextLength = 0 Then Exit Sub
        If PMs_Countdown > 0 Then
            PMs_Countdown -= 1
            lblCycle.Text = PMs_Countdown.ToString
        Else
            ' Send PM
            If PMs_Player_Countdown > 0 Then
                PMs_Player_Countdown -= 1
                lblMsg.Text = PMs_Player_Countdown.ToString
            Else
                Dim i As Integer = 0
                Dim pFound As Boolean

                Try
                    List1.SelectedIndex = PMs_CurrentPlayer
                    Dim sName() As String = Split(List1.Text, " - L:")

                    For i = 0 To lstIgnore.Items.Count - 1
                        If sName(0).ToLower.Contains(lstIgnore.Items.Item(i).tolower.ToString) Then pFound = True : Exit For
                    Next

                    If pFound = False Then
                        SendPM(Tibia_Version, sName(0), Replace(txtPM.Text, "$playername", sName(0), , , CompareMethod.Text))
                        txtPM_Log.Text += vbNewLine & sName(0)
                        PMs_Player_Countdown = CInt(txtDelayMsgs.Text)
                    Else
                        txtPM_Log.Text += vbNewLine & "'" & sName(0) & "' was skipped! Matched:" & lstIgnore.Items.Item(i).tolower.ToString 'SendPM(Tibia_Version, sName(0), txtPM.Text)
                    End If

                Catch ex As Exception
                    DoLog("ERROR_tmrPM: " & ex.Message)
                Finally
                    PMs_CurrentPlayer += 1
                    lblPlayer.Text = "Player " & PMs_CurrentPlayer.ToString & " out of " & PMs_MaxPlayers

                    If PMs_CurrentPlayer = PMs_MaxPlayers Then
                        PMs_Countdown = CInt(txtDelayPMs.Text)
                        PMs_CurrentPlayer = 0
                        PMs_Player_Countdown = 0

                        If cmbPMs.SelectedIndex < 2 Then
                            cmbPMs.SelectedIndex += 1
                        Else
                            cmbPMs.SelectedIndex = 0
                        End If

                        If chkRefreshList.Checked Then sckClient.Connect(txtIP.Text, 7171)
                    End If
                End Try
        End If
        End If
    End Sub

    Private Sub tmrDefault_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDefault.Tick
        If Tibia_PID = 0 Then chkDefault.Checked = False : tmrDefault.Stop()
        If txtDefault.TextLength = 0 Then Exit Sub
        If Default_Countdown > 0 Then
            Default_Countdown -= 1
        Else
            Try
                ' Send Msg
                SendMessage(Tibia_Version, txtDefault.Text, IIf(chkYell.Checked = True, enumTalkTypes.tYell, enumTalkTypes.tTalk))
            Catch ex As Exception
                DoLog("ERROR_tmrDefault: " & ex.Message)
            Finally
                Default_Countdown = CInt(txtDelayDefault.Text)
            End Try
        End If

    End Sub

    Private Sub tmrTrade_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTrade.Tick
        If Tibia_PID = 0 Then chkTrade.Checked = False : tmrTrade.Stop()
        If txtTrade.TextLength = 0 Then Exit Sub
        If Trade_Countdown > 0 Then
            Trade_Countdown -= 1
        Else
            ' Send Trade Msg
            Try
                SendMsgChannel(Tibia_Version, txtTrade.Text, GetChannelID(cmbChannelTrade.Text))
            Catch ex As Exception
                DoLog("ERROR_tmrTrade: " & ex.Message)
            Finally
                Trade_Countdown = CInt(txtDelayTrade.Text)
            End Try
        End If

    End Sub

    Private Sub tmrGameChat_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGameChat.Tick
        If Tibia_PID = 0 Then chkGameChat.Checked = False : tmrGameChat.Stop()
        If txtGameChat.TextLength = 0 Then Exit Sub
        If GameChat_Countdown > 0 Then
            GameChat_Countdown -= 1
        Else
            ' Send Trade Msg
            Try
                SendMsgChannel(Tibia_Version, txtGameChat.Text, GetChannelID(cmbChannelGameChat.Text))
            Catch ex As Exception
                DoLog("ERROR_tmrGameChat: " & ex.Message)
            Finally
                GameChat_Countdown = CInt(txtDelayGameChat.Text)
            End Try
        End If

    End Sub

    Private Sub tmrHelp_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrHelp.Tick
        If Tibia_PID = 0 Then chkHelp.Checked = False : tmrHelp.Stop()
        If txtHelp.TextLength = 0 Then Exit Sub
        If Help_Countdown > 0 Then
            Help_Countdown -= 1
        Else
            ' Send Trade Msg
            Try
                SendMsgChannel(Tibia_Version, txtHelp.Text, GetChannelID(cmbChannelHelp.Text))
            Catch ex As Exception
                DoLog("ERROR_tmrHelp: " & ex.Message)
            Finally
                Help_Countdown = CInt(txtDelayHelp.Text)
            End Try
        End If

    End Sub

    Private Sub txtDelayDefault_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDelayDefault.TextChanged
        If IsNumeric(txtDelayDefault.Text) Then
            If txtDelayDefault.Text = 0 Then txtDelayDefault.Text = 1
            Default_Countdown = CInt(txtDelayDefault.Text)
            Settings.SetSetting("Default_Delay", txtDelayDefault.Text)
        Else
            If Not FormLoaded Then
                txtDelayDefault.Text = 20
            Else
                MessageBox.Show("Please enter a valid number", "Error")
            End If
        End If
    End Sub


    Private Sub btnRefreshClientList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshClientList.Click
        Tibia_PID = 0

        lstClients.Items.Clear()



        Dim tempX As Integer
        Dim tempY As Integer
        Dim tempZ As Integer
        Dim tempID As Integer
        Dim tempX2 As Integer
        Dim tempY2 As Integer
        Dim tempZ2 As Integer
        Dim tempID2 As Integer
        Dim tempOnline As Integer
        Dim tibiaclient As Integer
        Dim hWndDesktop As Integer
        Dim lName As Integer
        Dim str_Renamed(255) As Byte
        Dim sName As String
        Dim PID As Integer
        Dim phandle As Integer
        Dim p As Process
        Dim v As String
        Dim enc As New System.Text.UTF8Encoding()
        Dim BattleList_Address As Integer = 0


        ' First get desktop hwnd with this API:
        ' Public Declare Function GetDesktopWindow Lib "user32" () As Long

        hWndDesktop = GetDesktopWindow()
        tibiaclient = 0

        ' Now get all the process IDs of Tibia mcs:
        Do
            tibiaclient = FindWindowEx(hWndDesktop, tibiaclient, "tibiaclient", vbNullString)

            If tibiaclient = 0 Then
                Exit Do
            Else

                GetWindowThreadProcessId(tibiaclient, PID)
                p = Process.GetProcessById(PID)
                v = p.MainModule.FileVersionInfo.FileVersion
                Select Case v
                    Case "8.71"
                        BattleList_Start = &H63FDEC
                        BattleList_End = &H64A5E4
                        Distance_Characters = 172
                        Player_Z = &H67BA30
                        Player_ID = &H63FD60
                        adrIsOnline = &H7C928C
                    Case "8.70"
                        BattleList_Start = &H63FDEC
                        BattleList_End = &H64A5E4
                        Distance_Characters = 172
                        Player_Z = &H67BA30
                        Player_ID = &H63FD60
                        adrIsOnline = &H7C928C
                    Case "8.62"
                        BattleList_Start = &H637CE4
                        BattleList_End = &H6420F4
                        Distance_Characters = 168
                        Player_Z = &H672428
                        Player_ID = &H637C58
                        adrIsOnline = &H7BFC84
                    Case "8.60"
                        BattleList_Start = &H63FEFC
                        BattleList_End = &H64A30C
                        Distance_Characters = 168
                        Player_Z = &H64F600
                        Player_ID = &H63FE98
                        adrIsOnline = &H79CF28
                    Case "8.57"
                        BattleList_Start = &H63FEF4
                        BattleList_End = &H64A304
                        Distance_Characters = 168
                        Player_Z = &H64F5F8
                        Player_ID = &H63FE90
                        adrIsOnline = &H79CF20
                    Case "8.54"
                        BattleList_Start = &H635F74
                        BattleList_End = &H640384
                        Distance_Characters = 168
                        Player_Z = &H645530
                        Player_ID = &H635F10
                        adrIsOnline = &H792E50
                    Case Else

                End Select
                Player_Y = Player_Z + 4
                Player_X = Player_Z + 8


                phandle = OpenProcess(PROCESS_ALL_ACCESS, False, PID)
                'For loop through the addresses

                ReadProcessMemory(phandle, adrIsOnline, tempOnline, 4, 0)

                If tempOnline = 8 Then
                    For BattleList_Address = BattleList_Start To BattleList_End Step Distance_Characters

                        'Read Current Address for X, Y, Z


                        ReadProcessMemory(phandle, BattleList_Address + Distance_X, tempX, 4, 0)
                        ReadProcessMemory(phandle, BattleList_Address + Distance_Y, tempY, 4, 0)
                        ReadProcessMemory(phandle, BattleList_Address + Distance_Z, tempZ, 4, 0)
                        ReadProcessMemory(phandle, BattleList_Address + Distance_ID, tempID, 4, 0)

                        ReadProcessMemory(phandle, Player_X, tempX2, 4, 0)
                        ReadProcessMemory(phandle, Player_Y, tempY2, 4, 0)
                        ReadProcessMemory(phandle, Player_Z, tempZ2, 4, 0)
                        ReadProcessMemory(phandle, Player_ID, tempID2, 4, 0)


                        'Compare to see if it is your Player X, Y, Z

                        If tempX = tempX2 And tempY = tempY2 And tempZ = tempZ2 And tempID = tempID2 Then

                            ReadProcessMemory(phandle, BattleList_Address, lName, 4, 0)
                            ReadProcessMemory(phandle, BattleList_Address, str_Renamed(0), 255, 0)


                            sName = enc.GetString(str_Renamed)

                            'Player has been found; assign to the X value since its first
                            If str_Renamed(0) = 0 Then
                                lstClients.Items.Add("[" & PID & "] Unknown " & v)
                            Else
                                lstClients.Items.Add("[" & PID & "] " & sName)
                            End If

                            Exit For
                        End If

                    Next BattleList_Address
                Else
                    lstClients.Items.Add("[" & PID & "] Not logged in " & v)
                End If
            End If

        Loop  ' loop until no more tibia mcs are found






    End Sub

    Private Sub lstClients_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstClients.SelectedIndexChanged
        On Error Resume Next
        Dim rpid As New System.Text.RegularExpressions.Regex("\b.\d*")
        Dim pid As Integer = (rpid.Match(lstClients.SelectedItem).ToString)
        Dim v As String = Process.GetProcessById(pid).MainModule.FileVersionInfo.FileVersion
        Tibia_PID = pid
        Tibia_Version = v

        Select Case v
            Case "8.71"
                BattleList_Start = &H63FDEC
                BattleList_End = &H64A5E4
                Distance_Characters = 172
                Player_Z = &H67BA30
                Player_ID = &H63FD60
                adrIsOnline = &H7C928C
            Case "8.70"
                BattleList_Start = &H63FDEC
                BattleList_End = &H64A5E4
                Distance_Characters = 172
                Player_Z = &H67BA30
                Player_ID = &H63FD60
                adrIsOnline = &H7C928C
            Case "8.62"
                BattleList_Start = &H637CE4
                BattleList_End = &H6420F4
                Distance_Characters = 168
                Player_Z = &H672428
                Player_ID = &H637C58
                adrIsOnline = &H7BFC84
            Case "8.60"
                BattleList_Start = &H63FEFC
                BattleList_End = &H64A30C
                Distance_Characters = 168
                Player_Z = &H64F600
                Player_ID = &H63FE98
                adrIsOnline = &H79CF28
            Case "8.57"
                BattleList_Start = &H63FEF4
                BattleList_End = &H64A304
                Distance_Characters = 168
                Player_Z = &H64F5F8
                Player_ID = &H63FE90
                adrIsOnline = &H79CF20
            Case "8.54"
                BattleList_Start = &H635F74
                BattleList_End = &H640384
                Distance_Characters = 168
                Player_Z = &H645530
                Player_ID = &H635F10
                adrIsOnline = &H792E50
            Case Else

        End Select
        Player_Y = Player_Z + 4
        Player_X = Player_Z + 8

        Me.Text = "[" & Tibia_Version & "] OT Spammer"
        cmbTibiaVersion.SelectedIndex = cmbTibiaVersion.FindString(v)
    End Sub


    Private Sub txtDelayTrade_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDelayTrade.TextChanged
        If IsNumeric(txtDelayTrade.Text) Then
            If txtDelayTrade.Text = 0 Then txtDelayTrade.Text = 1
            Trade_Countdown = CInt(txtDelayTrade.Text)
            Settings.SetSetting("Trade_Delay", txtDelayTrade.Text)
        Else
            If Not FormLoaded Then
                txtDelayTrade.Text = 120
            Else
                MessageBox.Show("Please enter a valid number", "Error - Trade Channel Delay")
            End If
        End If
    End Sub

    Private Sub txtDelayGameChat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDelayGameChat.TextChanged
        If IsNumeric(txtDelayGameChat.Text) Then
            If txtDelayGameChat.Text = 0 Then txtDelayGameChat.Text = 1
            GameChat_Countdown = CInt(txtDelayGameChat.Text)
            Settings.SetSetting("GameChat_Delay", txtDelayGameChat.Text)
        Else
            If Not FormLoaded Then
                txtDelayGameChat.Text = 120
            Else
                MessageBox.Show("Please enter a valid number", "Error - Game Chat Delay")
            End If
        End If
    End Sub

    Private Sub txtDelayHelp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDelayHelp.TextChanged
        If IsNumeric(txtDelayHelp.Text) Then
            If txtDelayHelp.Text = 0 Then txtDelayHelp.Text = 1
            Help_Countdown = CInt(txtDelayHelp.Text)
            Settings.SetSetting("Help_Delay", txtDelayHelp.Text)
        Else
            If Not FormLoaded Then
                txtDelayHelp.Text = 120
            Else
                MessageBox.Show("Please enter a valid number", "Error - Help Channel Delay")
            End If
        End If
    End Sub

    Private Sub txtDelayPMs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDelayPMs.TextChanged
        If IsNumeric(txtDelayPMs.Text) Then
            If txtDelayPMs.Text = 0 Then txtDelayPMs.Text = 1
            PMs_Countdown = CInt(txtDelayPMs.Text)
            Settings.SetSetting("PM_Delay", txtDelayPMs.Text)
        Else
            If Not FormLoaded Then
                txtDelayPMs.Text = 5
            Else
                MessageBox.Show("Please enter a valid number", "Error - PM Delay")
            End If

        End If
    End Sub


    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        PMs_CurrentPlayer = 0
        PMs_Player_Countdown = 0
        PMs_Countdown = 0
        PMs_MaxPlayers = List1.Items.Count

        lblCycle.Text = 0
        lblMsg.Text = 0
        lblPlayer.Text = "Player 0 out of " & PMs_MaxPlayers

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        txtPM_Log.Text = "Log cleared!" & vbNewLine & "-------------------------------------------------------" & vbNewLine
    End Sub
    Private Function GetChannelID(ByVal sString As String) As Integer
        On Error Resume Next
        Dim sSplit() As String
        sSplit = Split(sString, "=")

        GetChannelID = sSplit(1)
    End Function

    Private Sub btnTestGameChat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestGameChat.Click
        On Error Resume Next

        SendMsgChannel(Tibia_Version, txtGameChat.Text, GetChannelID(cmbChannelGameChat.Text))
    End Sub

    Private Sub btnTestHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestHelp.Click
        On Error Resume Next

        SendMsgChannel(Tibia_Version, txtHelp.Text, GetChannelID(cmbChannelHelp.Text))
    End Sub

    Private Sub btnTestTrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestTrade.Click
        On Error Resume Next

        SendMsgChannel(Tibia_Version, txtTrade.Text, GetChannelID(cmbChannelTrade.Text))
    End Sub

    Private Sub chkAntiIdle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAntiIdle.CheckedChanged
        If chkAntiIdle.Checked Then
            AntiIdle_Countdown = 0
            tmrAntiIdle.Start()
        Else
            tmrAntiIdle.Stop()
        End If
    End Sub

    Private Sub tmrAntiIdle_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAntiIdle.Tick
        If AntiIdle_Countdown > 0 Then
            AntiIdle_Countdown -= 1
        Else
            AntiIdle_Countdown = 10 * 60
            Dance()
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub


    Private Sub cmbPMs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPMs.SelectedIndexChanged
        Try
            txtPM.Text = PMs(cmbPMs.SelectedIndex)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPM_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPM.Leave
        PMs(cmbPMs.SelectedIndex) = txtPM.Text
        Settings.SetSetting("PM" & cmbPMs.SelectedIndex, txtPM.Text)
    End Sub

    Private Sub txtPM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPM.TextChanged
        'PMs(cmbPMs.SelectedIndex) = txtPM.Text
    End Sub


    Private Sub txtDelayMsgs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDelayMsgs.TextChanged
        Settings.SetSetting("PM_MsgsDelay", Val(txtDelayMsgs.Text))
    End Sub

    Private Sub chkYell_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkYell.CheckedChanged
        Settings.SetSetting("Default_Yell", chkYell.CheckState)
    End Sub

    Public Function ListToString(ByRef List As Object, Optional ByVal Separator As String = "\\") As String
        Try
            Dim i As Integer = 0
            Dim j As Integer = List.items.count - 1
            Dim sTmp As String = ""

            For i = 0 To j
                sTmp += List.items.item(i).ToString & Separator
            Next

            Return sTmp
        Catch ex As Exception
            MsgBox(ex.Message)
            Return "Error!"
        End Try
    End Function

    Public Function StringToList(ByRef sTmp As String, ByRef List As Object, Optional ByVal Separator As String = "\\") As Boolean
        Try

            List.Items.Clear()
            Dim sSplit() As String = Split(sTmp, Separator)
            Dim i As Integer = 0
            Dim j As Integer = UBound(sSplit)

            For i = 0 To j - 1
                If Not List.Items.Contains(sSplit(i).ToString) Then List.items.add(sSplit(i).ToString)
            Next
            StringToList = True
        Catch ex As Exception
            'ex.Message
            StringToList = False
        End Try
    End Function


End Class

Public Class Settings
    Public Shared Function GetSetting(ByVal Key As String) As String
        Dim sReturn As String = String.Empty
        Dim dsSettings As New DataSet
        If System.IO.File.Exists(Application.LocalUserAppDataPath & "\Settings.xml") Then
            dsSettings.ReadXml(Application.LocalUserAppDataPath & "\Settings.xml")
        Else
            dsSettings.Tables.Add("Settings")
            dsSettings.Tables(0).Columns.Add("Key", GetType(String))
            dsSettings.Tables(0).Columns.Add("Value", GetType(String))
        End If

        Dim dr() As DataRow = dsSettings.Tables("Settings").Select("Key = '" & Key & "'")
        If dr.Length = 1 Then sReturn = dr(0)("Value").ToString

        Return sReturn
    End Function

    Public Shared Sub SetSetting(ByVal Key As String, ByVal Value As String)
        If frmMain.FormLoaded = False Then Exit Sub
        Dim dsSettings As New DataSet
        If System.IO.File.Exists(Application.LocalUserAppDataPath & "\Settings.xml") Then
            dsSettings.ReadXml(Application.LocalUserAppDataPath & "\Settings.xml")
        Else
            dsSettings.Tables.Add("Settings")
            dsSettings.Tables(0).Columns.Add("Key", GetType(String))
            dsSettings.Tables(0).Columns.Add("Value", GetType(String))
        End If

        Dim dr() As DataRow = dsSettings.Tables(0).Select("Key = '" & Key & "'")
        If dr.Length = 1 Then
            dr(0)("Value") = Value
        Else
            Dim drSetting As DataRow = dsSettings.Tables("Settings").NewRow
            drSetting("Key") = Key
            drSetting("Value") = Value
            dsSettings.Tables("Settings").Rows.Add(drSetting)
        End If
        dsSettings.WriteXml(Application.LocalUserAppDataPath & "\Settings.xml")
    End Sub
End Class