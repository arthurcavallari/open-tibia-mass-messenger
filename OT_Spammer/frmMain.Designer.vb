<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkAntiIdle = New System.Windows.Forms.CheckBox
        Me.btnRefreshClientList = New System.Windows.Forms.Button
        Me.txtLog = New System.Windows.Forms.TextBox
        Me.List1 = New System.Windows.Forms.ListBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.btnConnect = New System.Windows.Forms.Button
        Me.lstClients = New System.Windows.Forms.ListBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbTibiaVersion = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtIP = New System.Windows.Forms.TextBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.cmbPMs = New System.Windows.Forms.ComboBox
        Me.chkRefreshList = New System.Windows.Forms.CheckBox
        Me.btnReset = New System.Windows.Forms.Button
        Me.lblPlayer = New System.Windows.Forms.Label
        Me.lblMsg = New System.Windows.Forms.Label
        Me.lblCycle = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.chkPMs = New System.Windows.Forms.CheckBox
        Me.btnRmIgnore = New System.Windows.Forms.Button
        Me.btnAddIgnore = New System.Windows.Forms.Button
        Me.txtIgnore = New System.Windows.Forms.TextBox
        Me.lstIgnore = New System.Windows.Forms.ListBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDelayPMs = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDelayMsgs = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPM = New System.Windows.Forms.TextBox
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.chkYell = New System.Windows.Forms.CheckBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtDefault = New System.Windows.Forms.TextBox
        Me.txtDelayDefault = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.chkDefault = New System.Windows.Forms.CheckBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.btnTestTrade = New System.Windows.Forms.Button
        Me.cmbChannelTrade = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtTrade = New System.Windows.Forms.TextBox
        Me.txtDelayTrade = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.chkTrade = New System.Windows.Forms.CheckBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.btnTestGameChat = New System.Windows.Forms.Button
        Me.cmbChannelGameChat = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtGameChat = New System.Windows.Forms.TextBox
        Me.txtDelayGameChat = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.chkGameChat = New System.Windows.Forms.CheckBox
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.btnTestHelp = New System.Windows.Forms.Button
        Me.cmbChannelHelp = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtHelp = New System.Windows.Forms.TextBox
        Me.txtDelayHelp = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.chkHelp = New System.Windows.Forms.CheckBox
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.Button3 = New System.Windows.Forms.Button
        Me.txtPM_Log = New System.Windows.Forms.TextBox
        Me.tmrPMs = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDefault = New System.Windows.Forms.Timer(Me.components)
        Me.tmrTrade = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGameChat = New System.Windows.Forms.Timer(Me.components)
        Me.tmrHelp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAntiIdle = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.chkAntiIdle)
        Me.GroupBox1.Controls.Add(Me.btnRefreshClientList)
        Me.GroupBox1.Controls.Add(Me.txtLog)
        Me.GroupBox1.Controls.Add(Me.List1)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.btnConnect)
        Me.GroupBox1.Controls.Add(Me.lstClients)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmbTibiaVersion)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtIP)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(564, 251)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Settings"
        '
        'chkAntiIdle
        '
        Me.chkAntiIdle.AutoSize = True
        Me.chkAntiIdle.Checked = True
        Me.chkAntiIdle.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAntiIdle.Location = New System.Drawing.Point(16, 229)
        Me.chkAntiIdle.Name = "chkAntiIdle"
        Me.chkAntiIdle.Size = New System.Drawing.Size(64, 17)
        Me.chkAntiIdle.TabIndex = 12
        Me.chkAntiIdle.Text = "Anti-Idle"
        Me.chkAntiIdle.UseVisualStyleBackColor = True
        '
        'btnRefreshClientList
        '
        Me.btnRefreshClientList.Location = New System.Drawing.Point(421, 215)
        Me.btnRefreshClientList.Name = "btnRefreshClientList"
        Me.btnRefreshClientList.Size = New System.Drawing.Size(136, 25)
        Me.btnRefreshClientList.TabIndex = 11
        Me.btnRefreshClientList.Text = "Refresh List"
        Me.btnRefreshClientList.UseVisualStyleBackColor = True
        '
        'txtLog
        '
        Me.txtLog.BackColor = System.Drawing.SystemColors.Control
        Me.txtLog.Location = New System.Drawing.Point(210, 44)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLog.Size = New System.Drawing.Size(187, 202)
        Me.txtLog.TabIndex = 10
        '
        'List1
        '
        Me.List1.FormattingEnabled = True
        Me.List1.Location = New System.Drawing.Point(16, 80)
        Me.List1.Name = "List1"
        Me.List1.Size = New System.Drawing.Size(183, 147)
        Me.List1.TabIndex = 8
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(16, 80)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(183, 95)
        Me.ListBox1.TabIndex = 9
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(16, 41)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(181, 33)
        Me.btnConnect.TabIndex = 7
        Me.btnConnect.Text = "Retrieve players online"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'lstClients
        '
        Me.lstClients.FormattingEnabled = True
        Me.lstClients.Location = New System.Drawing.Point(421, 36)
        Me.lstClients.Name = "lstClients"
        Me.lstClients.Size = New System.Drawing.Size(136, 173)
        Me.lstClients.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(418, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Choose a client below:"
        '
        'cmbTibiaVersion
        '
        Me.cmbTibiaVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTibiaVersion.FormattingEnabled = True
        Me.cmbTibiaVersion.Items.AddRange(New Object() {"8.54", "8.57", "8.60", "8.62", "8.70", "8.71"})
        Me.cmbTibiaVersion.Location = New System.Drawing.Point(335, 16)
        Me.cmbTibiaVersion.Name = "cmbTibiaVersion"
        Me.cmbTibiaVersion.Size = New System.Drawing.Size(63, 21)
        Me.cmbTibiaVersion.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(258, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Tibia Version:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Server IP or Hostname:"
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(135, 16)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(110, 20)
        Me.txtIP.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(12, 265)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(565, 251)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cmbPMs)
        Me.TabPage1.Controls.Add(Me.chkRefreshList)
        Me.TabPage1.Controls.Add(Me.btnReset)
        Me.TabPage1.Controls.Add(Me.lblPlayer)
        Me.TabPage1.Controls.Add(Me.lblMsg)
        Me.TabPage1.Controls.Add(Me.lblCycle)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.chkPMs)
        Me.TabPage1.Controls.Add(Me.btnRmIgnore)
        Me.TabPage1.Controls.Add(Me.btnAddIgnore)
        Me.TabPage1.Controls.Add(Me.txtIgnore)
        Me.TabPage1.Controls.Add(Me.lstIgnore)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtDelayPMs)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtDelayMsgs)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtPM)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(557, 225)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Private Message"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cmbPMs
        '
        Me.cmbPMs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPMs.FormattingEnabled = True
        Me.cmbPMs.Items.AddRange(New Object() {"PM0", "PM1", "PM2"})
        Me.cmbPMs.Location = New System.Drawing.Point(4, 85)
        Me.cmbPMs.Name = "cmbPMs"
        Me.cmbPMs.Size = New System.Drawing.Size(50, 21)
        Me.cmbPMs.TabIndex = 32
        '
        'chkRefreshList
        '
        Me.chkRefreshList.AutoSize = True
        Me.chkRefreshList.Checked = True
        Me.chkRefreshList.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRefreshList.Location = New System.Drawing.Point(203, 10)
        Me.chkRefreshList.Name = "chkRefreshList"
        Me.chkRefreshList.Size = New System.Drawing.Size(157, 17)
        Me.chkRefreshList.TabIndex = 31
        Me.chkRefreshList.Text = "Refresh list after each cycle"
        Me.chkRefreshList.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(373, 6)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(107, 23)
        Me.btnReset.TabIndex = 30
        Me.btnReset.Text = "Reset cycle"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblPlayer
        '
        Me.lblPlayer.AutoSize = True
        Me.lblPlayer.Location = New System.Drawing.Point(370, 68)
        Me.lblPlayer.Name = "lblPlayer"
        Me.lblPlayer.Size = New System.Drawing.Size(84, 13)
        Me.lblPlayer.TabIndex = 29
        Me.lblPlayer.Text = "Player 0 out of 0"
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Location = New System.Drawing.Point(518, 51)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(13, 13)
        Me.lblMsg.TabIndex = 28
        Me.lblMsg.Text = "0"
        '
        'lblCycle
        '
        Me.lblCycle.AutoSize = True
        Me.lblCycle.Location = New System.Drawing.Point(518, 38)
        Me.lblCycle.Name = "lblCycle"
        Me.lblCycle.Size = New System.Drawing.Size(13, 13)
        Me.lblCycle.TabIndex = 27
        Me.lblCycle.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(370, 51)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(142, 13)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Seconds until next message:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(370, 34)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(125, 13)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Seconds until next cycle:"
        '
        'chkPMs
        '
        Me.chkPMs.AutoSize = True
        Me.chkPMs.Location = New System.Drawing.Point(486, 6)
        Me.chkPMs.Name = "chkPMs"
        Me.chkPMs.Size = New System.Drawing.Size(65, 17)
        Me.chkPMs.TabIndex = 23
        Me.chkPMs.Text = "Activate"
        Me.chkPMs.UseVisualStyleBackColor = True
        '
        'btnRmIgnore
        '
        Me.btnRmIgnore.Location = New System.Drawing.Point(301, 140)
        Me.btnRmIgnore.Name = "btnRmIgnore"
        Me.btnRmIgnore.Size = New System.Drawing.Size(66, 24)
        Me.btnRmIgnore.TabIndex = 22
        Me.btnRmIgnore.Text = "Remove"
        Me.btnRmIgnore.UseVisualStyleBackColor = True
        '
        'btnAddIgnore
        '
        Me.btnAddIgnore.Location = New System.Drawing.Point(301, 110)
        Me.btnAddIgnore.Name = "btnAddIgnore"
        Me.btnAddIgnore.Size = New System.Drawing.Size(66, 24)
        Me.btnAddIgnore.TabIndex = 21
        Me.btnAddIgnore.Text = "Add"
        Me.btnAddIgnore.UseVisualStyleBackColor = True
        '
        'txtIgnore
        '
        Me.txtIgnore.Location = New System.Drawing.Point(373, 88)
        Me.txtIgnore.Name = "txtIgnore"
        Me.txtIgnore.Size = New System.Drawing.Size(178, 20)
        Me.txtIgnore.TabIndex = 20
        '
        'lstIgnore
        '
        Me.lstIgnore.FormattingEnabled = True
        Me.lstIgnore.Items.AddRange(New Object() {"GM", "God", "CM", "Admin"})
        Me.lstIgnore.Location = New System.Drawing.Point(373, 111)
        Me.lstIgnore.Name = "lstIgnore"
        Me.lstIgnore.Size = New System.Drawing.Size(178, 108)
        Me.lstIgnore.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(244, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Ignore names containing:"
        '
        'txtDelayPMs
        '
        Me.txtDelayPMs.Location = New System.Drawing.Point(134, 7)
        Me.txtDelayPMs.Name = "txtDelayPMs"
        Me.txtDelayPMs.Size = New System.Drawing.Size(57, 20)
        Me.txtDelayPMs.TabIndex = 17
        Me.txtDelayPMs.Text = "5"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Delay in between cycles:"
        '
        'txtDelayMsgs
        '
        Me.txtDelayMsgs.Location = New System.Drawing.Point(134, 33)
        Me.txtDelayMsgs.Name = "txtDelayMsgs"
        Me.txtDelayMsgs.Size = New System.Drawing.Size(57, 20)
        Me.txtDelayMsgs.TabIndex = 15
        Me.txtDelayMsgs.Text = "3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Delay in between players:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Message:"
        '
        'txtPM
        '
        Me.txtPM.Location = New System.Drawing.Point(60, 69)
        Me.txtPM.Multiline = True
        Me.txtPM.Name = "txtPM"
        Me.txtPM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPM.Size = New System.Drawing.Size(178, 140)
        Me.txtPM.TabIndex = 5
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.chkYell)
        Me.TabPage5.Controls.Add(Me.Label12)
        Me.TabPage5.Controls.Add(Me.txtDefault)
        Me.TabPage5.Controls.Add(Me.txtDelayDefault)
        Me.TabPage5.Controls.Add(Me.Label8)
        Me.TabPage5.Controls.Add(Me.chkDefault)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(557, 225)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Default Channel"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'chkYell
        '
        Me.chkYell.AutoSize = True
        Me.chkYell.Checked = True
        Me.chkYell.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkYell.Location = New System.Drawing.Point(4, 37)
        Me.chkYell.Name = "chkYell"
        Me.chkYell.Size = New System.Drawing.Size(43, 17)
        Me.chkYell.TabIndex = 29
        Me.chkYell.Text = "Yell"
        Me.chkYell.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(1, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Message:"
        '
        'txtDefault
        '
        Me.txtDefault.Location = New System.Drawing.Point(60, 69)
        Me.txtDefault.Multiline = True
        Me.txtDefault.Name = "txtDefault"
        Me.txtDefault.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDefault.Size = New System.Drawing.Size(178, 140)
        Me.txtDefault.TabIndex = 27
        '
        'txtDelayDefault
        '
        Me.txtDelayDefault.Location = New System.Drawing.Point(134, 7)
        Me.txtDelayDefault.Name = "txtDelayDefault"
        Me.txtDelayDefault.Size = New System.Drawing.Size(33, 20)
        Me.txtDelayDefault.TabIndex = 26
        Me.txtDelayDefault.Text = "20"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Delay in between cycles:"
        '
        'chkDefault
        '
        Me.chkDefault.AutoSize = True
        Me.chkDefault.Location = New System.Drawing.Point(486, 6)
        Me.chkDefault.Name = "chkDefault"
        Me.chkDefault.Size = New System.Drawing.Size(65, 17)
        Me.chkDefault.TabIndex = 24
        Me.chkDefault.Text = "Activate"
        Me.chkDefault.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnTestTrade)
        Me.TabPage2.Controls.Add(Me.cmbChannelTrade)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.txtTrade)
        Me.TabPage2.Controls.Add(Me.txtDelayTrade)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.chkTrade)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(557, 225)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Trade Channel"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnTestTrade
        '
        Me.btnTestTrade.Location = New System.Drawing.Point(173, 7)
        Me.btnTestTrade.Name = "btnTestTrade"
        Me.btnTestTrade.Size = New System.Drawing.Size(65, 20)
        Me.btnTestTrade.TabIndex = 34
        Me.btnTestTrade.Text = "Test MSG"
        Me.btnTestTrade.UseVisualStyleBackColor = True
        '
        'cmbChannelTrade
        '
        Me.cmbChannelTrade.FormattingEnabled = True
        Me.cmbChannelTrade.Items.AddRange(New Object() {"AmberaGameChat=4", "AmberaTrade=5", "GameChat=5", "TradeChat=6", "RookTradeChat=7", "RLChat=8", "HelpChat=9"})
        Me.cmbChannelTrade.Location = New System.Drawing.Point(84, 33)
        Me.cmbChannelTrade.Name = "cmbChannelTrade"
        Me.cmbChannelTrade.Size = New System.Drawing.Size(154, 21)
        Me.cmbChannelTrade.TabIndex = 33
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(15, 36)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 13)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "Channel ID:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(1, 69)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Message:"
        '
        'txtTrade
        '
        Me.txtTrade.Location = New System.Drawing.Point(60, 69)
        Me.txtTrade.Multiline = True
        Me.txtTrade.Name = "txtTrade"
        Me.txtTrade.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTrade.Size = New System.Drawing.Size(178, 140)
        Me.txtTrade.TabIndex = 28
        '
        'txtDelayTrade
        '
        Me.txtDelayTrade.Location = New System.Drawing.Point(134, 7)
        Me.txtDelayTrade.Name = "txtDelayTrade"
        Me.txtDelayTrade.Size = New System.Drawing.Size(33, 20)
        Me.txtDelayTrade.TabIndex = 27
        Me.txtDelayTrade.Text = "120"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Delay in between cycles:"
        '
        'chkTrade
        '
        Me.chkTrade.AutoSize = True
        Me.chkTrade.Location = New System.Drawing.Point(486, 6)
        Me.chkTrade.Name = "chkTrade"
        Me.chkTrade.Size = New System.Drawing.Size(65, 17)
        Me.chkTrade.TabIndex = 25
        Me.chkTrade.Text = "Activate"
        Me.chkTrade.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnTestGameChat)
        Me.TabPage3.Controls.Add(Me.cmbChannelGameChat)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.txtGameChat)
        Me.TabPage3.Controls.Add(Me.txtDelayGameChat)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.chkGameChat)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(557, 225)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Game-Chat"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnTestGameChat
        '
        Me.btnTestGameChat.Location = New System.Drawing.Point(173, 7)
        Me.btnTestGameChat.Name = "btnTestGameChat"
        Me.btnTestGameChat.Size = New System.Drawing.Size(65, 20)
        Me.btnTestGameChat.TabIndex = 32
        Me.btnTestGameChat.Text = "Test MSG"
        Me.btnTestGameChat.UseVisualStyleBackColor = True
        '
        'cmbChannelGameChat
        '
        Me.cmbChannelGameChat.FormattingEnabled = True
        Me.cmbChannelGameChat.Items.AddRange(New Object() {"AmberaGameChat=4", "AmberaTrade=5", "GameChat=5", "TradeChat=6", "RookTradeChat=7", "RLChat=8", "HelpChat=9"})
        Me.cmbChannelGameChat.Location = New System.Drawing.Point(84, 33)
        Me.cmbChannelGameChat.Name = "cmbChannelGameChat"
        Me.cmbChannelGameChat.Size = New System.Drawing.Size(154, 21)
        Me.cmbChannelGameChat.TabIndex = 31
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(15, 36)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 13)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "Channel ID:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(1, 69)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Message:"
        '
        'txtGameChat
        '
        Me.txtGameChat.Location = New System.Drawing.Point(60, 69)
        Me.txtGameChat.Multiline = True
        Me.txtGameChat.Name = "txtGameChat"
        Me.txtGameChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGameChat.Size = New System.Drawing.Size(178, 140)
        Me.txtGameChat.TabIndex = 28
        '
        'txtDelayGameChat
        '
        Me.txtDelayGameChat.Location = New System.Drawing.Point(134, 7)
        Me.txtDelayGameChat.Name = "txtDelayGameChat"
        Me.txtDelayGameChat.Size = New System.Drawing.Size(33, 20)
        Me.txtDelayGameChat.TabIndex = 27
        Me.txtDelayGameChat.Text = "120"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Delay in between cycles:"
        '
        'chkGameChat
        '
        Me.chkGameChat.AutoSize = True
        Me.chkGameChat.Location = New System.Drawing.Point(486, 6)
        Me.chkGameChat.Name = "chkGameChat"
        Me.chkGameChat.Size = New System.Drawing.Size(65, 17)
        Me.chkGameChat.TabIndex = 25
        Me.chkGameChat.Text = "Activate"
        Me.chkGameChat.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btnTestHelp)
        Me.TabPage4.Controls.Add(Me.cmbChannelHelp)
        Me.TabPage4.Controls.Add(Me.Label20)
        Me.TabPage4.Controls.Add(Me.Label15)
        Me.TabPage4.Controls.Add(Me.txtHelp)
        Me.TabPage4.Controls.Add(Me.txtDelayHelp)
        Me.TabPage4.Controls.Add(Me.Label11)
        Me.TabPage4.Controls.Add(Me.chkHelp)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(557, 225)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Help Channel"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'btnTestHelp
        '
        Me.btnTestHelp.Location = New System.Drawing.Point(173, 7)
        Me.btnTestHelp.Name = "btnTestHelp"
        Me.btnTestHelp.Size = New System.Drawing.Size(65, 20)
        Me.btnTestHelp.TabIndex = 34
        Me.btnTestHelp.Text = "Test MSG"
        Me.btnTestHelp.UseVisualStyleBackColor = True
        '
        'cmbChannelHelp
        '
        Me.cmbChannelHelp.FormattingEnabled = True
        Me.cmbChannelHelp.Items.AddRange(New Object() {"AmberaGameChat=4", "AmberaTrade=5", "GameChat=5", "TradeChat=6", "RookTradeChat=7", "RLChat=8", "HelpChat=9"})
        Me.cmbChannelHelp.Location = New System.Drawing.Point(84, 33)
        Me.cmbChannelHelp.Name = "cmbChannelHelp"
        Me.cmbChannelHelp.Size = New System.Drawing.Size(154, 21)
        Me.cmbChannelHelp.TabIndex = 33
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(15, 36)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(63, 13)
        Me.Label20.TabIndex = 32
        Me.Label20.Text = "Channel ID:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(1, 69)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Message:"
        '
        'txtHelp
        '
        Me.txtHelp.Location = New System.Drawing.Point(60, 69)
        Me.txtHelp.Multiline = True
        Me.txtHelp.Name = "txtHelp"
        Me.txtHelp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHelp.Size = New System.Drawing.Size(178, 140)
        Me.txtHelp.TabIndex = 28
        '
        'txtDelayHelp
        '
        Me.txtDelayHelp.Location = New System.Drawing.Point(134, 7)
        Me.txtDelayHelp.Name = "txtDelayHelp"
        Me.txtDelayHelp.Size = New System.Drawing.Size(33, 20)
        Me.txtDelayHelp.TabIndex = 27
        Me.txtDelayHelp.Text = "120"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Delay in between cycles:"
        '
        'chkHelp
        '
        Me.chkHelp.AutoSize = True
        Me.chkHelp.Location = New System.Drawing.Point(486, 6)
        Me.chkHelp.Name = "chkHelp"
        Me.chkHelp.Size = New System.Drawing.Size(65, 17)
        Me.chkHelp.TabIndex = 25
        Me.chkHelp.Text = "Activate"
        Me.chkHelp.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Button3)
        Me.TabPage6.Controls.Add(Me.txtPM_Log)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(557, 225)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Log"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(9, 198)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 22)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Clear log"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtPM_Log
        '
        Me.txtPM_Log.Location = New System.Drawing.Point(3, 3)
        Me.txtPM_Log.Multiline = True
        Me.txtPM_Log.Name = "txtPM_Log"
        Me.txtPM_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPM_Log.Size = New System.Drawing.Size(551, 190)
        Me.txtPM_Log.TabIndex = 6
        Me.txtPM_Log.Text = "OT Spammer loaded successfully." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "------------------------------------------------" & _
            "-------" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'tmrPMs
        '
        Me.tmrPMs.Interval = 1000
        '
        'tmrDefault
        '
        Me.tmrDefault.Interval = 1000
        '
        'tmrTrade
        '
        Me.tmrTrade.Interval = 1000
        '
        'tmrGameChat
        '
        Me.tmrGameChat.Interval = 1000
        '
        'tmrHelp
        '
        Me.tmrHelp.Interval = 1000
        '
        'tmrAntiIdle
        '
        Me.tmrAntiIdle.Enabled = True
        Me.tmrAntiIdle.Interval = 1000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 528)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMain"
        Me.Text = "OT Spammer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnRmIgnore As System.Windows.Forms.Button
    Friend WithEvents btnAddIgnore As System.Windows.Forms.Button
    Friend WithEvents txtIgnore As System.Windows.Forms.TextBox
    Friend WithEvents lstIgnore As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDelayPMs As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDelayMsgs As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPM As System.Windows.Forms.TextBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents chkPMs As System.Windows.Forms.CheckBox
    Friend WithEvents chkDefault As System.Windows.Forms.CheckBox
    Friend WithEvents chkTrade As System.Windows.Forms.CheckBox
    Friend WithEvents chkGameChat As System.Windows.Forms.CheckBox
    Friend WithEvents chkHelp As System.Windows.Forms.CheckBox
    Friend WithEvents tmrPMs As System.Windows.Forms.Timer
    Friend WithEvents tmrDefault As System.Windows.Forms.Timer
    Friend WithEvents tmrTrade As System.Windows.Forms.Timer
    Friend WithEvents tmrGameChat As System.Windows.Forms.Timer
    Friend WithEvents tmrHelp As System.Windows.Forms.Timer
    Friend WithEvents lstClients As System.Windows.Forms.ListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbTibiaVersion As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDelayDefault As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDelayTrade As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDelayGameChat As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDelayHelp As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents List1 As System.Windows.Forms.ListBox
    Friend WithEvents chkYell As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDefault As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTrade As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtGameChat As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtHelp As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents txtLog As System.Windows.Forms.TextBox
    Friend WithEvents btnRefreshClientList As System.Windows.Forms.Button
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents lblCycle As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblPlayer As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents chkRefreshList As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtPM_Log As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmbChannelGameChat As System.Windows.Forms.ComboBox
    Friend WithEvents cmbChannelTrade As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmbChannelHelp As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btnTestGameChat As System.Windows.Forms.Button
    Friend WithEvents btnTestTrade As System.Windows.Forms.Button
    Friend WithEvents btnTestHelp As System.Windows.Forms.Button
    Friend WithEvents chkAntiIdle As System.Windows.Forms.CheckBox
    Friend WithEvents tmrAntiIdle As System.Windows.Forms.Timer
    Friend WithEvents cmbPMs As System.Windows.Forms.ComboBox

End Class
