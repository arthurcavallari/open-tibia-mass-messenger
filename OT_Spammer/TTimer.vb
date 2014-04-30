Imports System.Threading
''' <summary>
    ''' Provides the definition to create timers within their own threads and within critical sections.
    ''' </summary>
    <Serializable()> _
    Public Class TTimer
        Inherits System.ComponentModel.Component
        Private timer As System.Threading.Timer
        Private timerInterval As Long
        Private timerState As TimerState

        ''' <summary>
        ''' The function prototype for timer executions.
        ''' </summary>
        Public Delegate Sub TimerExecution()

        ''' <summary>
        ''' Called when the timer is executed.
        ''' </summary>
        Public Event Execute As TimerExecution


        ''' <summary>
        ''' Creates a timer with a specified interval, and starts after the specified delay.
        ''' </summary>
        Public Sub New()
            timerInterval = 100
            timerState = TimerState.Stopped
            timer = New System.Threading.Timer(New TimerCallback(AddressOf Tick), Nothing, Timeout.Infinite, timerInterval)
        End Sub


        ''' <summary>
        ''' Creates a timer with a specified interval, and starts after the specified delay.
        ''' </summary>
        ''' <param name="interval">Interval in milliseconds at which the timer will execute.</param>
        ''' <param name="startDelay"></param>
        Public Sub New(ByVal interval As Long, ByVal startDelay As Integer)
            timerInterval = interval
            timerState = If((startDelay = Timeout.Infinite), TimerState.Stopped, TimerState.Running)
            timer = New System.Threading.Timer(New TimerCallback(AddressOf Tick), Nothing, startDelay, interval)
        End Sub

        ''' <summary>
        ''' Creates a timer with a specified interval.
        ''' </summary>
        ''' <param name="interval"></param>
        Public Sub New(ByVal interval As Long, ByVal start As Boolean)
            timerInterval = interval
            timerState = If((Not start), TimerState.Stopped, TimerState.Running)
            timer = New System.Threading.Timer(New TimerCallback(AddressOf Tick), Nothing, 0, interval)
        End Sub

        ''' <summary>
        ''' Starts the timer with a specified delay.
        ''' </summary>
        ''' <param name="delayBeforeStart"></param>
        Public Sub Start(ByVal delayBeforeStart As Integer)
            timerState = TimerState.Running
            timer.Change(delayBeforeStart, timerInterval)
        End Sub

        ''' <summary>
        ''' Starts the timer instantly.
        ''' </summary>
        Public Sub Start()
            timerState = TimerState.Running
            timer.Change(0, timerInterval)
        End Sub

        ''' <summary>
        ''' Pauses the timer.
        ''' Note: Running threads won't be closed.
        ''' </summary>
        Public Sub Pause()
            timerState = TimerState.Paused
            timer.Change(Timeout.Infinite, timerInterval)
        End Sub

        ''' <summary>
        ''' Stops the timer.
        ''' Note: Running threads won't be closed.
        ''' </summary>
        Public Sub [Stop]()
            timerState = TimerState.Stopped
            timer.Change(Timeout.Infinite, timerInterval)
        End Sub

        Public Sub Tick(ByVal obj As Object)
        If timerState = timerState.Running Then
            SyncLock Me
                RaiseEvent Execute()
            End SyncLock
        End If
        End Sub

        ''' <summary>
        ''' Gets the state of the timer.
        ''' </summary>
        Public ReadOnly Property State() As TimerState
            Get
                Return timerState
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the timer interval.
        ''' </summary>
        Public Property Interval() As Long
            Get
                Return timerInterval
            End Get
            Set(ByVal value As Long)
            timer.Change((If((timerState = timerState.Running), value, Timeout.Infinite)), value)
            timerInterval = value
            End Set
        End Property

        Private Sub InitializeComponent()

        End Sub
    End Class

    Public Enum TimerState
        Stopped
        Running
        Paused
    End Enum

