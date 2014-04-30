Module Packet
    Private Declare Sub SendPacket870 Lib "tpacket870.dll" Alias "SendPacket" (ByVal ProcessID As Integer, ByRef Packet As Byte)
    Private Declare Sub SendPacket862 Lib "tpacket862.dll" Alias "SendPacket" (ByVal ProcessID As Integer, ByRef Packet As Byte)
    Private Declare Sub SendPacket860 Lib "tpacket860.dll" Alias "SendPacket" (ByVal ProcessID As Integer, ByRef Packet As Byte)
    Private Declare Sub SendPacket857 Lib "tpacket857.dll" Alias "SendPacket" (ByVal ProcessID As Integer, ByRef Packet As Byte)
    Private Declare Sub SendPacket854 Lib "tpacket854.dll" Alias "SendPacket" (ByVal ProcessID As Integer, ByRef Packet As Byte)
    Public Declare Function GetWindowThreadProcessId Lib "user32.dll" (ByVal hWnd As Integer, ByRef lpdwProcessId As Integer) As Integer
    Public Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
    Public Declare Function GetDesktopWindow Lib "user32" () As Integer
    Public Declare Function FindWindowEx Lib "user32" Alias "FindWindowExA" (ByVal hWnd1 As Integer, ByVal hWnd2 As Integer, ByVal lpsz1 As String, ByVal lpsz2 As String) As Integer

    Public Declare Function OpenProcess Lib "kernel32.dll" (ByVal dwDesiredAccess As Integer, ByVal bInheritHandle As Integer, ByVal dwProcessId As Integer) As Integer
    Public Declare Function CloseHandle Lib "kernel32.dll" (ByVal hObject As Integer) As Integer

    Public Declare Function WriteProcessMemory Lib "kernel32.dll" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As String, ByVal nSize As Long, ByRef lpNumberOfBytesWritten As Integer) As Integer
    Public Declare Function WriteProcessMemory Lib "kernel32.dll" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Long, ByVal nSize As Long, ByRef lpNumberOfBytesWritten As Integer) As Integer
    Public Declare Function WriteProcessMemory Lib "kernel32.dll" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Integer, ByVal nSize As Long, ByRef lpNumberOfBytesWritten As Integer) As Integer
    Public Declare Function WriteProcessMemory Lib "kernel32.dll" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Byte, ByVal nSize As Long, ByRef lpNumberOfBytesWritten As Integer) As Integer

    Public Declare Function ReadProcessMemory2 Lib "kernel32.dll" Alias "ReadProcessMemory" (ByVal hProcess As Int32, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Integer, ByVal nSize As Long, ByRef lpNumberOfBytesWritten As Integer) As Integer
    Public Declare Function ReadProcessMemory Lib "kernel32.dll" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Integer, ByVal nSize As Long, ByRef lpNumberOfBytesWritten As Integer) As Integer
    Public Declare Function ReadProcessMemory Lib "kernel32.dll" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Int16, ByVal nSize As Long, ByRef lpNumberOfBytesWritten As Integer) As Integer
    Public Declare Function ReadProcessMemory Lib "kernel32.dll" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Byte, ByVal nSize As Long, ByRef lpNumberOfBytesWritten As Integer) As Integer
    Public Declare Function ReadProcessMemory Lib "kernel32.dll" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As String, ByVal nSize As Long, ByRef lpNumberOfBytesWritten As Integer) As Integer
    Public Declare Function ReadProcessMemory Lib "kernel32.dll" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Long, ByVal nSize As Long, ByRef lpNumberOfBytesWritten As Integer) As Integer

    Private Delegate Sub DoListDelegate(ByVal InputStr As String, ByVal Action As String)
    Private Delegate Sub DoLogDelegate(ByVal InputStr As String)

    Public Const PROCESS_VM_READ = (&H10)
    Public Const PROCESS_VM_WRITE = (&H20)
    Public Const PROCESS_VM_OPERATION = (&H8)
    Public Const PROCESS_QUERY_INFORMATION = (&H400)
    Public Const PROCESS_READ_WRITE_QUERY = PROCESS_VM_READ + PROCESS_VM_WRITE + PROCESS_VM_OPERATION + PROCESS_QUERY_INFORMATION
    Public Const PROCESS_ALL_ACCESS = &H1F0FFF

    Public Tibia_PID As Long
    Public Tibia_Version As String

    Public BattleList_Start As Integer = 0
    Public BattleList_End As Integer = 0
    Public Distance_Characters As Integer = 0
    Public Distance_X As Integer = 32
    Public Distance_Y As Integer = 36
    Public Distance_Z As Integer = 40
    Public Player_ID As Integer = 0
    Public Player_Z As Integer = 0
    Public Player_Y As Integer = Player_Z + 4
    Public Player_X As Integer = Player_Z + 8
    Public Distance_ID As Integer = -4
    Public adrIsOnline As Integer = 0

    Public Enum enumTalkTypes As Byte
        tTalk = 1
        tWhisper = 2
        tYell = 3
    End Enum
    Public Enum enumOTChatChannels As Byte
        GuildChat = 0
        AmberaGameChat = 4
        GameChat = 5
        AmberaTrade = 5
        TradeChat = 6
        RookTradeChat = 7
        RLChat = 8
        HelpChat = 9
        OwnPrivateChannel = 14
        PrivateChannel1 = 17
    End Enum
    Public Enum Directions
        North = 0
        East = 1
        South = 2
        West = 3
        NorthEast = 4
        SouthEast = 5
        SouthWest = 6
        NorthWest = 7
        Center = 8

        FaceNorth = 0
        FaceEast = 1
        FaceSouth = 2
        FaceWest = 3
    End Enum
    'xx xx 96 07 05 00 02 00 68 69 - hi game chat
    'xx xx 96 07 06 00 02 00 68 69 - hi trade chat
    'xx xx 96 07 08 00 02 00 68 69 - hi rl chat
    'xx xx 96 07 09 00 02 00 68 69 - hi help
    Public Enum enumChatChannels870 As Byte
        GuildChat = 0
        WorldChat = 3
        EnglishChat = 4
        TradeChat = 5
        RookTradeChat = 6
        HelpChat = 7
        OwnPrivateChannel = 14
        PrivateChannel1 = 17
    End Enum

    Public Sub SendPacket(ByVal ProcessID As Integer, ByRef Packet As Byte, ByVal TVersion As String)
        Select Case TVersion
            Case "8.70", "8.71"
                SendPacket870(ProcessID, Packet)
            Case "8.62"
                SendPacket862(ProcessID, Packet)
            Case "8.60"
                SendPacket860(ProcessID, Packet)
            Case "8.57"
                SendPacket857(ProcessID, Packet)
            Case "8.54"
                SendPacket854(ProcessID, Packet)
        End Select
    End Sub



    Public Function SendMessage(ByVal TVersion As String, ByRef sMessage As String, Optional ByVal TalkType As enumTalkTypes = enumTalkTypes.tTalk) As Boolean
        On Error GoTo depErr
        If IsOnline() = False Then Exit Function
        SendMessage = True


        If sMessage.Length > 251 Then
            Exit Function
        End If

        Dim bPacket() As Byte 'packet to send
        Dim lMsg As Integer 'looping temps
        ReDim bPacket(5 + sMessage.Length) 'redo the packet's lenght, depending on the lenght of the message/charactername and so on.

        bPacket(0) = Len(sMessage) + 4 '# de caracteres + 4
        bPacket(1) = &H0
        bPacket(2) = &H96
        bPacket(3) = TalkType ' 1=say, 2=whisper, 3=yell, 4=npc chat
        bPacket(4) = sMessage.Length
        bPacket(5) = &H0
        For lMsg = 1 To sMessage.Length 'begin to feed our array with our message
            bPacket(5 + lMsg) = Asc(Mid(sMessage, lMsg, 1)) 'all letters of the message splitted into our array.
        Next

        Call SendPacket(Tibia_PID, bPacket(0), TVersion) 'Msg person! :D


        Exit Function
depErr:
        SendMessage = False
        Err.Raise(Err.Number, Err.Source, Err.Description)
    End Function
    Public Sub SendPM(ByVal TVersion As String, ByRef sCharName As String, ByRef sMessage As String) 'Sends a message to anyone [Broadcaster].
        If IsOnline() = False Then Exit Sub
        Dim bPacket() As Byte 'packet to sendDim
        Dim lChar As Long
        Dim lMsg As Long 'looping temps
        ReDim bPacket(5 + sMessage.Length + 2 + sCharName.Length) 'redo the packet's lenght, depending on the lenght of the message/charactername and so on.
        bPacket(0) = sCharName.Length + sMessage.Length + 6 'total lenght of packet
        bPacket(1) = &H0
        bPacket(2) = &H96
        bPacket(3) = &H6
        bPacket(4) = sCharName.Length 'lenght of receivers name
        bPacket(5) = &H0

        For lChar = 1 To sCharName.Length 'a simple For loop, to feed our array with the character's name
            bPacket(5 + lChar) = Asc(Mid$(sCharName, lChar, 1)) 'convert from ordinary letters (also known as unicode) to ascii numbers with VB's "Asc" function.
        Next

        bPacket(5 + lChar + 0) = sMessage.Length 'the lenght of the message to be sent
        bPacket(5 + lChar + 1) = &H0

        For lMsg = 1 To sMessage.Length 'begin to feed our array with our message
            bPacket(6 + lChar + lMsg) = Asc(Mid$(sMessage, lMsg, 1)) 'all letters of the message splitted into our array.
        Next

        Call SendPacket(Tibia_PID, bPacket(0), TVersion) 'Msg person! :D
    End Sub

    Public Sub SendMsgChannel(ByVal TVersion As String, ByVal TextToSay As String, _
                              ByVal WhichChat As enumOTChatChannels)
        If IsOnline() = False Then Exit Sub
        '4 Game Chat
        '5 Trade Chat
        '6 RL Chat
        '7 Help Chat
        '11 00 96 05 00 00 0B 00 48 65 6C 6C 6F 20 47 75 69 6C 64
        '0B 00 96 05 08 00 05 00 48 65 6C 6C 6F

        '871
        'xx xx 96 07 03 00 02 00 68 69 - hi world chat
        'xx xx 96 07 04 00 02 00 68 69 - hi english chat
        'xx xx 96 07 05 00 02 00 68 69 - hi advertising channel
        'xx xx 96 07 07 00 02 00 68 69 - hi help channel
        '


        '860
        'xx xx 96 07 05 00 02 00 68 69 - hi game chat
        'xx xx 96 07 06 00 02 00 68 69 - hi trade chat
        'xx xx 96 07 08 00 02 00 68 69 - hi rl chat
        'xx xx 96 07 09 00 02 00 68 69 - hi help
        Dim X As Long
        Dim n As Long
        Dim bPacket() As Byte
        X = 8 + TextToSay.Length
        ReDim bPacket(X + 1)
        bPacket(0) = X
        bPacket(1) = &H0
        bPacket(2) = &H96
        bPacket(3) = &H7  '1 reg talk, 2 whisper, 3 yell, 4 pm, 5(old?) channel talk, 7 channels
        bPacket(4) = WhichChat
        bPacket(5) = &H0
        bPacket(6) = TextToSay.Length
        bPacket(7) = &H0

        For n = 0 To TextToSay.Length - 1
            bPacket(8 + n) = Asc(Mid(TextToSay, n + 1, 1))
        Next

        Call SendPacket(Tibia_PID, bPacket(0), TVersion) 'Msg person! :D
    End Sub
    Public Sub Dance()
        LookTo(Directions.North)
        Threading.Thread.Sleep(500)
        LookTo(Directions.South)
    End Sub

    Public Sub LookTo(ByVal sDirection As Directions)
        If Not IsOnline() Then Exit Sub
        Dim bPacket(2) As Byte

        bPacket(0) = 1
        bPacket(1) = &H0
        bPacket(2) = &H6F + sDirection

        Call SendPacket(Tibia_PID, bPacket(0), Tibia_Version)
    End Sub
    Public Function IsOnline() As Boolean
        Dim Buffer As Integer
        If Tibia_PID = 0 Then Exit Function
        Try
            ReadProcessMemory2(Process.GetProcessById(Tibia_PID).Handle, adrIsOnline, Buffer, 4, 0)
            If Buffer = 8 Then IsOnline = True
        Catch
            IsOnline = False
        Finally

        End Try
    End Function
End Module
