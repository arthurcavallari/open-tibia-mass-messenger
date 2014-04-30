
Public Class Winsock

    Private Sock As Net.Sockets.Socket
    Private MonitorThread As Threading.Thread

    Private StopMonitoring As Boolean = False               'Causes the socket to stop monitoring for data

    Public Event Connected()
    Public Event ConnectionError(ByVal Message As String)
    Public Event Disconnected()
    Public Event DisconnectError(ByVal Message As String)
    Public Event IncomingData(ByRef Data As String)
    Public Event IncomingDataBin(ByRef Data() As Byte)
    Public Event IncomingDataError(ByVal Message As String)
    Public Event SendDataError(ByVal Message As String)
    Public Event BytesReceived(ByVal Bytes As Integer)
    Public Event BytesSent(ByVal Bytes As Integer)

    Public Function isConnected() As Boolean
        If Sock IsNot Nothing Then
            Return Sock.Connected
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Connects to a remote IP or hostname on the port provided with a TCP socket over IPv4.
    ''' </summary>
    ''' <param name="Address"></param>
    ''' <param name="Port"></param>
    ''' <remarks></remarks>
    Public Sub Connect(ByVal Address As String, ByVal Port As Integer)
        If Sock IsNot Nothing Then
            If Sock.Connected Then
                RaiseEvent ConnectionError("This socket is already connected.")
                Exit Sub
            End If
        End If

        If Address = Nothing Or Port < 0 Or Port > 65536 Then
            RaiseEvent ConnectionError("Bad address or port provided.")
        End If

        Sock = New Net.Sockets.Socket(Net.Sockets.AddressFamily.InterNetwork, Net.Sockets.SocketType.Stream, Net.Sockets.ProtocolType.Tcp)
        Sock.ReceiveBufferSize = 65536
        Sock.SendBufferSize = 65536

        Try
            Sock.Connect(Address, Port)
        Catch ex As Exception
            RaiseEvent ConnectionError(ex.Message)
        End Try

        If Sock.Connected = False Then
            Try
                Sock.Close(5000)
                Sock = Nothing
            Catch ex As Exception
            End Try

            RaiseEvent ConnectionError("Unable to connect to remote host.")
        Else
            StopMonitoring = False

            RaiseEvent Connected()

            MonitorThread = New Threading.Thread(AddressOf MonitorSocketForData)
            MonitorThread.Start()

        End If
    End Sub

    ''' <summary>
    ''' Begins the disconnection process by telling the socket monitor to quit.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Disconnect()
        StopMonitoring = True
    End Sub

    ''' <summary>
    ''' Finishes the disconnection process by closing the socket.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FinishDisconnect()
        If Sock IsNot Nothing Then
            Try
                'Sock.Disconnect(False)
                Sock.Close()
                Sock = Nothing
                RaiseEvent Disconnected()
            Catch ex As Exception
                RaiseEvent DisconnectError(ex.Message)
            End Try
        End If
    End Sub

    ''' <summary>
    ''' Sends a string.
    ''' </summary>
    ''' <param name="Data"></param>
    ''' <remarks></remarks>
    Public Sub Send(ByRef Data As String)
        Send(getBytesFromRealString(Data))
    End Sub

    ''' <summary>
    ''' Sends a byte array.
    ''' </summary>
    ''' <param name="Data"></param>
    ''' <remarks></remarks>
    Public Sub Send(ByRef Data() As Byte)
        If Sock IsNot Nothing Then
            If Sock.Connected Then
                Try
                    Sock.Send(Data)
                    RaiseEvent BytesSent(Data.Length)
                Catch ex As Exception
                    RaiseEvent SendDataError(ex.Message)
                End Try
            Else
                RaiseEvent SendDataError("This socket is not connected to a remote host.")
            End If
        Else
            RaiseEvent SendDataError("This socket hasn't yet been connected to anything.")
        End If
    End Sub

    ''' <summary>
    ''' Monitors the socket for available data and also if it is blatantly disconnected.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub MonitorSocketForData()
        Dim LastPollLoops As Integer = 0

        While Not StopMonitoring
            If Sock IsNot Nothing Then
                If Sock.Connected Then
                    If Sock.Available > 0 Then
                        Try
                            Dim CurrentBytes As Integer = Sock.Available

                            Dim Buffer(CurrentBytes - 1) As Byte
                            Sock.Receive(Buffer, CurrentBytes, Net.Sockets.SocketFlags.None)

                            'Dim TempStr As String = getRealStringFromBytes(Buffer)

                            RaiseEvent BytesReceived(Buffer.Length)
                            RaiseEvent IncomingData(getRealStringFromBytes(Buffer))
                            RaiseEvent IncomingDataBin(Buffer)
                        Catch ex As Exception
                            RaiseEvent IncomingDataError(ex.Message)
                        End Try
                    End If
                Else
                    Disconnect()
                End If
            Else
                Disconnect()
            End If

            LastPollLoops += 1

            If LastPollLoops >= 500 And Sock.Connected Then
                Try
                    If Sock.Poll(-1, Net.Sockets.SelectMode.SelectRead) And Sock.Available <= 0 Then
                        Disconnect()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                LastPollLoops = 0
            End If

            Threading.Thread.Sleep(25)
        End While

        FinishDisconnect()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Public Sub New()

    End Sub
End Class