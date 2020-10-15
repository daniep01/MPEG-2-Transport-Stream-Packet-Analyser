<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgMain))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.tbData = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.FileProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.status1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.File_Menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Open = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Close = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Menu_SavePacket = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Report = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_TableReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Demux = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.Menu_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tools_Menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_PIDlist = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnalysePacketSpacingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Check_CCount = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Check_Sync_Bytes = New System.Windows.Forms.ToolStripMenuItem()
        Me.Options_Menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.TablePIDListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Help_Menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_About = New System.Windows.Forms.ToolStripMenuItem()
        Me.LicenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Website = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeyboardShortcutsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_Open = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_First = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Prev = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Next = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Goto = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Stop = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_DropDownTables = New System.Windows.Forms.ToolStripDropDownButton()
        Me.PATToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CATToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SDTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TDTTOTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_PIDlist = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Check = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_About = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.btn_debug1 = New System.Windows.Forms.ToolStripButton()
        Me.btn_debug2 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbTSSync = New System.Windows.Forms.TextBox()
        Me.tbTScontinuity = New System.Windows.Forms.TextBox()
        Me.tbTSadaptation = New System.Windows.Forms.TextBox()
        Me.tbTSscrambling = New System.Windows.Forms.TextBox()
        Me.tbTSpid = New System.Windows.Forms.TextBox()
        Me.tbTSpriority = New System.Windows.Forms.TextBox()
        Me.tbTSpayloadstart = New System.Windows.Forms.TextBox()
        Me.tbTSerror = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.grp_packet = New System.Windows.Forms.GroupBox()
        Me.lbl_bytes = New System.Windows.Forms.Label()
        Me.tbPacketNote2 = New System.Windows.Forms.TextBox()
        Me.tbPacketNote1 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tbPayloadFilter = New System.Windows.Forms.TextBox()
        Me.tbPidFilter = New System.Windows.Forms.TextBox()
        Me.cboxPID = New System.Windows.Forms.CheckBox()
        Me.cboxPayloadStart = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbAdaptationLength = New System.Windows.Forms.TextBox()
        Me.tbAdaptationType = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbSize = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbPath = New System.Windows.Forms.TextBox()
        Me.viewer = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grp_packet.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Title = "Open transport stream"
        '
        'tbData
        '
        Me.tbData.BackColor = System.Drawing.SystemColors.Window
        Me.tbData.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbData.Location = New System.Drawing.Point(61, 21)
        Me.tbData.Multiline = True
        Me.tbData.Name = "tbData"
        Me.tbData.ReadOnly = True
        Me.tbData.Size = New System.Drawing.Size(360, 174)
        Me.tbData.TabIndex = 1
        Me.tbData.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.FileProgressBar, Me.status1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 412)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 15, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1016, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(74, 17)
        Me.ToolStripStatusLabel1.Text = "File position:"
        '
        'FileProgressBar
        '
        Me.FileProgressBar.AutoSize = False
        Me.FileProgressBar.ForeColor = System.Drawing.Color.ForestGreen
        Me.FileProgressBar.Name = "FileProgressBar"
        Me.FileProgressBar.Size = New System.Drawing.Size(217, 16)
        Me.FileProgressBar.Step = 1
        Me.FileProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'status1
        '
        Me.status1.Name = "status1"
        Me.status1.Size = New System.Drawing.Size(42, 17)
        Me.status1.Text = "Ready."
        Me.status1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.File_Menu, Me.Tools_Menu, Me.Options_Menu, Me.Help_Menu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(1016, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'File_Menu
        '
        Me.File_Menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Open, Me.Menu_Close, Me.ToolStripSeparator3, Me.Menu_SavePacket, Me.Menu_Report, Me.Menu_TableReport, Me.Menu_Demux, Me.ToolStripSeparator9, Me.Menu_Exit})
        Me.File_Menu.Name = "File_Menu"
        Me.File_Menu.Size = New System.Drawing.Size(37, 20)
        Me.File_Menu.Text = "&File"
        '
        'Menu_Open
        '
        Me.Menu_Open.Image = CType(resources.GetObject("Menu_Open.Image"), System.Drawing.Image)
        Me.Menu_Open.Name = "Menu_Open"
        Me.Menu_Open.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.Menu_Open.Size = New System.Drawing.Size(303, 22)
        Me.Menu_Open.Text = "&Open transport stream or packet  ..."
        '
        'Menu_Close
        '
        Me.Menu_Close.Enabled = False
        Me.Menu_Close.Name = "Menu_Close"
        Me.Menu_Close.Size = New System.Drawing.Size(303, 22)
        Me.Menu_Close.Text = "&Close"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(300, 6)
        '
        'Menu_SavePacket
        '
        Me.Menu_SavePacket.Enabled = False
        Me.Menu_SavePacket.Image = CType(resources.GetObject("Menu_SavePacket.Image"), System.Drawing.Image)
        Me.Menu_SavePacket.Name = "Menu_SavePacket"
        Me.Menu_SavePacket.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.Menu_SavePacket.Size = New System.Drawing.Size(303, 22)
        Me.Menu_SavePacket.Text = "&Save this packet ..."
        '
        'Menu_Report
        '
        Me.Menu_Report.Enabled = False
        Me.Menu_Report.Image = CType(resources.GetObject("Menu_Report.Image"), System.Drawing.Image)
        Me.Menu_Report.Name = "Menu_Report"
        Me.Menu_Report.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.Menu_Report.Size = New System.Drawing.Size(303, 22)
        Me.Menu_Report.Text = "Generate CS&V report ..."
        '
        'Menu_TableReport
        '
        Me.Menu_TableReport.Enabled = False
        Me.Menu_TableReport.Image = CType(resources.GetObject("Menu_TableReport.Image"), System.Drawing.Image)
        Me.Menu_TableReport.Name = "Menu_TableReport"
        Me.Menu_TableReport.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.Menu_TableReport.Size = New System.Drawing.Size(303, 22)
        Me.Menu_TableReport.Text = "Generate &Table report ..."
        '
        'Menu_Demux
        '
        Me.Menu_Demux.Enabled = False
        Me.Menu_Demux.Image = CType(resources.GetObject("Menu_Demux.Image"), System.Drawing.Image)
        Me.Menu_Demux.Name = "Menu_Demux"
        Me.Menu_Demux.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.Menu_Demux.Size = New System.Drawing.Size(303, 22)
        Me.Menu_Demux.Text = "Trim / &Demux stream ..."
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(300, 6)
        '
        'Menu_Exit
        '
        Me.Menu_Exit.Name = "Menu_Exit"
        Me.Menu_Exit.Size = New System.Drawing.Size(303, 22)
        Me.Menu_Exit.Text = "E&xit"
        '
        'Tools_Menu
        '
        Me.Tools_Menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_PIDlist, Me.AnalysePacketSpacingToolStripMenuItem, Me.Menu_Check_CCount, Me.Menu_Check_Sync_Bytes})
        Me.Tools_Menu.Enabled = False
        Me.Tools_Menu.Name = "Tools_Menu"
        Me.Tools_Menu.Size = New System.Drawing.Size(47, 20)
        Me.Tools_Menu.Text = "&Tools"
        '
        'Menu_PIDlist
        '
        Me.Menu_PIDlist.Image = CType(resources.GetObject("Menu_PIDlist.Image"), System.Drawing.Image)
        Me.Menu_PIDlist.Name = "Menu_PIDlist"
        Me.Menu_PIDlist.Size = New System.Drawing.Size(210, 22)
        Me.Menu_PIDlist.Text = "Show &PID list ..."
        '
        'AnalysePacketSpacingToolStripMenuItem
        '
        Me.AnalysePacketSpacingToolStripMenuItem.Name = "AnalysePacketSpacingToolStripMenuItem"
        Me.AnalysePacketSpacingToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.AnalysePacketSpacingToolStripMenuItem.Text = "&Analyse PID spacing ..."
        '
        'Menu_Check_CCount
        '
        Me.Menu_Check_CCount.ImageTransparentColor = System.Drawing.Color.Fuchsia
        Me.Menu_Check_CCount.Name = "Menu_Check_CCount"
        Me.Menu_Check_CCount.Size = New System.Drawing.Size(210, 22)
        Me.Menu_Check_CCount.Text = "&Check continuity count ..."
        Me.Menu_Check_CCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Menu_Check_Sync_Bytes
        '
        Me.Menu_Check_Sync_Bytes.Name = "Menu_Check_Sync_Bytes"
        Me.Menu_Check_Sync_Bytes.Size = New System.Drawing.Size(210, 22)
        Me.Menu_Check_Sync_Bytes.Text = "Check &sync bytes"
        '
        'Options_Menu
        '
        Me.Options_Menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TablePIDListToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.Options_Menu.Name = "Options_Menu"
        Me.Options_Menu.Size = New System.Drawing.Size(61, 20)
        Me.Options_Menu.Text = "&Options"
        '
        'TablePIDListToolStripMenuItem
        '
        Me.TablePIDListToolStripMenuItem.Name = "TablePIDListToolStripMenuItem"
        Me.TablePIDListToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.TablePIDListToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.TablePIDListToolStripMenuItem.Text = "&Table PID list ..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(194, 22)
        Me.ToolStripMenuItem1.Text = "&Display ..."
        '
        'Help_Menu
        '
        Me.Help_Menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_About, Me.LicenceToolStripMenuItem, Me.Menu_Website, Me.KeyboardShortcutsToolStripMenuItem})
        Me.Help_Menu.Name = "Help_Menu"
        Me.Help_Menu.Size = New System.Drawing.Size(44, 20)
        Me.Help_Menu.Text = "&Help"
        '
        'Menu_About
        '
        Me.Menu_About.Name = "Menu_About"
        Me.Menu_About.Size = New System.Drawing.Size(207, 22)
        Me.Menu_About.Text = "&About ..."
        '
        'LicenceToolStripMenuItem
        '
        Me.LicenceToolStripMenuItem.Name = "LicenceToolStripMenuItem"
        Me.LicenceToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.LicenceToolStripMenuItem.Text = "&Licence ..."
        '
        'Menu_Website
        '
        Me.Menu_Website.Name = "Menu_Website"
        Me.Menu_Website.Size = New System.Drawing.Size(207, 22)
        Me.Menu_Website.Text = "&Website ..."
        '
        'KeyboardShortcutsToolStripMenuItem
        '
        Me.KeyboardShortcutsToolStripMenuItem.Name = "KeyboardShortcutsToolStripMenuItem"
        Me.KeyboardShortcutsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.KeyboardShortcutsToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.KeyboardShortcutsToolStripMenuItem.Text = "&Keyboard shortcuts ..."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Open, Me.ToolStripSeparator1, Me.Tool_First, Me.Tool_Prev, Me.Tool_Next, Me.Tool_Goto, Me.Tool_Stop, Me.ToolStripSeparator2, Me.Tool_DropDownTables, Me.ToolStripSeparator8, Me.Tool_PIDlist, Me.Tool_Check, Me.ToolStripSeparator4, Me.ToolStripButton2, Me.ToolStripSeparator5, Me.Tool_About, Me.ToolStripButton1, Me.btn_debug1, Me.btn_debug2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(1016, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tool_Open
        '
        Me.Tool_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tool_Open.Image = CType(resources.GetObject("Tool_Open.Image"), System.Drawing.Image)
        Me.Tool_Open.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Open.Name = "Tool_Open"
        Me.Tool_Open.Size = New System.Drawing.Size(23, 22)
        Me.Tool_Open.Text = "Open"
        Me.Tool_Open.ToolTipText = "Open TS file ..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_First
        '
        Me.Tool_First.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tool_First.Enabled = False
        Me.Tool_First.Image = CType(resources.GetObject("Tool_First.Image"), System.Drawing.Image)
        Me.Tool_First.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_First.Name = "Tool_First"
        Me.Tool_First.Size = New System.Drawing.Size(23, 22)
        Me.Tool_First.Text = "Goto first packet"
        '
        'Tool_Prev
        '
        Me.Tool_Prev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tool_Prev.Enabled = False
        Me.Tool_Prev.Image = CType(resources.GetObject("Tool_Prev.Image"), System.Drawing.Image)
        Me.Tool_Prev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Prev.Name = "Tool_Prev"
        Me.Tool_Prev.Size = New System.Drawing.Size(23, 22)
        Me.Tool_Prev.Text = "Goto &previous packet"
        '
        'Tool_Next
        '
        Me.Tool_Next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tool_Next.Enabled = False
        Me.Tool_Next.Image = CType(resources.GetObject("Tool_Next.Image"), System.Drawing.Image)
        Me.Tool_Next.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Next.Name = "Tool_Next"
        Me.Tool_Next.Size = New System.Drawing.Size(23, 22)
        Me.Tool_Next.Text = "Goto &next packet"
        '
        'Tool_Goto
        '
        Me.Tool_Goto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tool_Goto.Enabled = False
        Me.Tool_Goto.Image = CType(resources.GetObject("Tool_Goto.Image"), System.Drawing.Image)
        Me.Tool_Goto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Goto.Name = "Tool_Goto"
        Me.Tool_Goto.Size = New System.Drawing.Size(23, 22)
        Me.Tool_Goto.Text = "ToolStripButton1"
        Me.Tool_Goto.ToolTipText = "Goto packet number ..."
        '
        'Tool_Stop
        '
        Me.Tool_Stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tool_Stop.Enabled = False
        Me.Tool_Stop.Image = CType(resources.GetObject("Tool_Stop.Image"), System.Drawing.Image)
        Me.Tool_Stop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Stop.Name = "Tool_Stop"
        Me.Tool_Stop.Size = New System.Drawing.Size(23, 22)
        Me.Tool_Stop.Text = "Stop search"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_DropDownTables
        '
        Me.Tool_DropDownTables.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tool_DropDownTables.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PATToolStripMenuItem, Me.CATToolStripMenuItem, Me.NITToolStripMenuItem, Me.SDTToolStripMenuItem, Me.EITToolStripMenuItem, Me.TDTTOTToolStripMenuItem})
        Me.Tool_DropDownTables.Enabled = False
        Me.Tool_DropDownTables.Image = CType(resources.GetObject("Tool_DropDownTables.Image"), System.Drawing.Image)
        Me.Tool_DropDownTables.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_DropDownTables.Name = "Tool_DropDownTables"
        Me.Tool_DropDownTables.Size = New System.Drawing.Size(29, 22)
        Me.Tool_DropDownTables.Text = "Find tables"
        '
        'PATToolStripMenuItem
        '
        Me.PATToolStripMenuItem.Name = "PATToolStripMenuItem"
        Me.PATToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.PATToolStripMenuItem.Text = "PAT (0)"
        '
        'CATToolStripMenuItem
        '
        Me.CATToolStripMenuItem.Name = "CATToolStripMenuItem"
        Me.CATToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CATToolStripMenuItem.Text = "CAT (1)"
        '
        'NITToolStripMenuItem
        '
        Me.NITToolStripMenuItem.Name = "NITToolStripMenuItem"
        Me.NITToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.NITToolStripMenuItem.Text = "NIT (16)"
        '
        'SDTToolStripMenuItem
        '
        Me.SDTToolStripMenuItem.Name = "SDTToolStripMenuItem"
        Me.SDTToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.SDTToolStripMenuItem.Text = "SDT/BAT (17)"
        '
        'EITToolStripMenuItem
        '
        Me.EITToolStripMenuItem.Name = "EITToolStripMenuItem"
        Me.EITToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.EITToolStripMenuItem.Text = "EIT (18)"
        '
        'TDTTOTToolStripMenuItem
        '
        Me.TDTTOTToolStripMenuItem.Name = "TDTTOTToolStripMenuItem"
        Me.TDTTOTToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.TDTTOTToolStripMenuItem.Text = "TDT/TOT (20)"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_PIDlist
        '
        Me.Tool_PIDlist.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tool_PIDlist.Enabled = False
        Me.Tool_PIDlist.Image = CType(resources.GetObject("Tool_PIDlist.Image"), System.Drawing.Image)
        Me.Tool_PIDlist.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_PIDlist.Name = "Tool_PIDlist"
        Me.Tool_PIDlist.Size = New System.Drawing.Size(23, 22)
        Me.Tool_PIDlist.Text = "PID list"
        Me.Tool_PIDlist.ToolTipText = "Show PID list ..."
        '
        'Tool_Check
        '
        Me.Tool_Check.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tool_Check.Enabled = False
        Me.Tool_Check.Image = CType(resources.GetObject("Tool_Check.Image"), System.Drawing.Image)
        Me.Tool_Check.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Check.Name = "Tool_Check"
        Me.Tool_Check.Size = New System.Drawing.Size(23, 22)
        Me.Tool_Check.Text = "ToolStripButton1"
        Me.Tool_Check.ToolTipText = "Check continuity count ..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Toggle hex/ascii view of packet data bytes"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_About
        '
        Me.Tool_About.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tool_About.Image = CType(resources.GetObject("Tool_About.Image"), System.Drawing.Image)
        Me.Tool_About.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_About.Name = "Tool_About"
        Me.Tool_About.Size = New System.Drawing.Size(23, 22)
        Me.Tool_About.Text = "About"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        Me.ToolStripButton1.ToolTipText = "Visit website to check for update"
        '
        'btn_debug1
        '
        Me.btn_debug1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_debug1.Enabled = False
        Me.btn_debug1.Image = CType(resources.GetObject("btn_debug1.Image"), System.Drawing.Image)
        Me.btn_debug1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_debug1.Name = "btn_debug1"
        Me.btn_debug1.Size = New System.Drawing.Size(23, 22)
        Me.btn_debug1.Text = "ToolStripButton2"
        Me.btn_debug1.Visible = False
        '
        'btn_debug2
        '
        Me.btn_debug2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_debug2.Enabled = False
        Me.btn_debug2.Image = CType(resources.GetObject("btn_debug2.Image"), System.Drawing.Image)
        Me.btn_debug2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_debug2.Name = "btn_debug2"
        Me.btn_debug2.Size = New System.Drawing.Size(23, 22)
        Me.btn_debug2.Text = "ToolStripButton2"
        Me.btn_debug2.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbTSSync)
        Me.GroupBox1.Controls.Add(Me.tbTScontinuity)
        Me.GroupBox1.Controls.Add(Me.tbTSadaptation)
        Me.GroupBox1.Controls.Add(Me.tbTSscrambling)
        Me.GroupBox1.Controls.Add(Me.tbTSpid)
        Me.GroupBox1.Controls.Add(Me.tbTSpriority)
        Me.GroupBox1.Controls.Add(Me.tbTSpayloadstart)
        Me.GroupBox1.Controls.Add(Me.tbTSerror)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 135)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(257, 192)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TS header"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Continuity counter"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(9, 145)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(151, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Adaptation field control"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(9, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Transport scrambling control"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(9, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "PID"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(9, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Transport priority"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(9, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Payload unit start indicator"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(9, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(151, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Transport error indicator"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(9, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sync byte"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbTSSync
        '
        Me.tbTSSync.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbTSSync.Location = New System.Drawing.Point(166, 22)
        Me.tbTSSync.Name = "tbTSSync"
        Me.tbTSSync.ReadOnly = True
        Me.tbTSSync.Size = New System.Drawing.Size(74, 20)
        Me.tbTSSync.TabIndex = 4
        Me.tbTSSync.TabStop = False
        '
        'tbTScontinuity
        '
        Me.tbTScontinuity.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbTScontinuity.Location = New System.Drawing.Point(166, 162)
        Me.tbTScontinuity.Name = "tbTScontinuity"
        Me.tbTScontinuity.ReadOnly = True
        Me.tbTScontinuity.Size = New System.Drawing.Size(74, 20)
        Me.tbTScontinuity.TabIndex = 4
        Me.tbTScontinuity.TabStop = False
        '
        'tbTSadaptation
        '
        Me.tbTSadaptation.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbTSadaptation.Location = New System.Drawing.Point(166, 142)
        Me.tbTSadaptation.Name = "tbTSadaptation"
        Me.tbTSadaptation.ReadOnly = True
        Me.tbTSadaptation.Size = New System.Drawing.Size(74, 20)
        Me.tbTSadaptation.TabIndex = 4
        Me.tbTSadaptation.TabStop = False
        '
        'tbTSscrambling
        '
        Me.tbTSscrambling.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbTSscrambling.Location = New System.Drawing.Point(166, 122)
        Me.tbTSscrambling.Name = "tbTSscrambling"
        Me.tbTSscrambling.ReadOnly = True
        Me.tbTSscrambling.Size = New System.Drawing.Size(74, 20)
        Me.tbTSscrambling.TabIndex = 4
        Me.tbTSscrambling.TabStop = False
        '
        'tbTSpid
        '
        Me.tbTSpid.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbTSpid.Location = New System.Drawing.Point(166, 102)
        Me.tbTSpid.Name = "tbTSpid"
        Me.tbTSpid.ReadOnly = True
        Me.tbTSpid.Size = New System.Drawing.Size(74, 20)
        Me.tbTSpid.TabIndex = 4
        Me.tbTSpid.TabStop = False
        '
        'tbTSpriority
        '
        Me.tbTSpriority.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbTSpriority.Location = New System.Drawing.Point(166, 82)
        Me.tbTSpriority.Name = "tbTSpriority"
        Me.tbTSpriority.ReadOnly = True
        Me.tbTSpriority.Size = New System.Drawing.Size(74, 20)
        Me.tbTSpriority.TabIndex = 4
        Me.tbTSpriority.TabStop = False
        '
        'tbTSpayloadstart
        '
        Me.tbTSpayloadstart.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbTSpayloadstart.Location = New System.Drawing.Point(166, 62)
        Me.tbTSpayloadstart.Name = "tbTSpayloadstart"
        Me.tbTSpayloadstart.ReadOnly = True
        Me.tbTSpayloadstart.Size = New System.Drawing.Size(74, 20)
        Me.tbTSpayloadstart.TabIndex = 4
        Me.tbTSpayloadstart.TabStop = False
        '
        'tbTSerror
        '
        Me.tbTSerror.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbTSerror.Location = New System.Drawing.Point(166, 42)
        Me.tbTSerror.Name = "tbTSerror"
        Me.tbTSerror.ReadOnly = True
        Me.tbTSerror.Size = New System.Drawing.Size(74, 20)
        Me.tbTSerror.TabIndex = 4
        Me.tbTSerror.TabStop = False
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Title = "Save As"
        '
        'grp_packet
        '
        Me.grp_packet.Controls.Add(Me.lbl_bytes)
        Me.grp_packet.Controls.Add(Me.tbPacketNote2)
        Me.grp_packet.Controls.Add(Me.tbPacketNote1)
        Me.grp_packet.Controls.Add(Me.tbData)
        Me.grp_packet.Location = New System.Drawing.Point(278, 135)
        Me.grp_packet.Name = "grp_packet"
        Me.grp_packet.Size = New System.Drawing.Size(442, 266)
        Me.grp_packet.TabIndex = 16
        Me.grp_packet.TabStop = False
        Me.grp_packet.Text = "TS packet "
        '
        'lbl_bytes
        '
        Me.lbl_bytes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_bytes.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bytes.Location = New System.Drawing.Point(17, 21)
        Me.lbl_bytes.Margin = New System.Windows.Forms.Padding(3)
        Me.lbl_bytes.Name = "lbl_bytes"
        Me.lbl_bytes.Size = New System.Drawing.Size(38, 174)
        Me.lbl_bytes.TabIndex = 24
        Me.lbl_bytes.Text = "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "16" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "32" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "48" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "64" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "80" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "96" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "112" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "128" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "144" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "160" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "176"
        Me.lbl_bytes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.lbl_bytes, "Click to toggle byte labelling")
        '
        'tbPacketNote2
        '
        Me.tbPacketNote2.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbPacketNote2.Location = New System.Drawing.Point(17, 236)
        Me.tbPacketNote2.Name = "tbPacketNote2"
        Me.tbPacketNote2.ReadOnly = True
        Me.tbPacketNote2.Size = New System.Drawing.Size(405, 20)
        Me.tbPacketNote2.TabIndex = 16
        Me.tbPacketNote2.TabStop = False
        '
        'tbPacketNote1
        '
        Me.tbPacketNote1.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbPacketNote1.Location = New System.Drawing.Point(17, 216)
        Me.tbPacketNote1.Name = "tbPacketNote1"
        Me.tbPacketNote1.ReadOnly = True
        Me.tbPacketNote1.Size = New System.Drawing.Size(405, 20)
        Me.tbPacketNote1.TabIndex = 15
        Me.tbPacketNote1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tbPayloadFilter)
        Me.GroupBox3.Controls.Add(Me.tbPidFilter)
        Me.GroupBox3.Controls.Add(Me.cboxPID)
        Me.GroupBox3.Controls.Add(Me.cboxPayloadStart)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 61)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(257, 68)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filter"
        Me.ToolTip1.SetToolTip(Me.GroupBox3, "Enable filters to help find interesting packets")
        '
        'tbPayloadFilter
        '
        Me.tbPayloadFilter.Enabled = False
        Me.tbPayloadFilter.Location = New System.Drawing.Point(166, 18)
        Me.tbPayloadFilter.MaxLength = 32
        Me.tbPayloadFilter.Name = "tbPayloadFilter"
        Me.tbPayloadFilter.Size = New System.Drawing.Size(74, 20)
        Me.tbPayloadFilter.TabIndex = 1
        Me.tbPayloadFilter.Text = "1"
        '
        'tbPidFilter
        '
        Me.tbPidFilter.Enabled = False
        Me.tbPidFilter.Location = New System.Drawing.Point(166, 38)
        Me.tbPidFilter.MaxLength = 32
        Me.tbPidFilter.Name = "tbPidFilter"
        Me.tbPidFilter.Size = New System.Drawing.Size(74, 20)
        Me.tbPidFilter.TabIndex = 3
        Me.tbPidFilter.Text = "0"
        '
        'cboxPID
        '
        Me.cboxPID.Location = New System.Drawing.Point(15, 40)
        Me.cboxPID.Name = "cboxPID"
        Me.cboxPID.Size = New System.Drawing.Size(147, 17)
        Me.cboxPID.TabIndex = 2
        Me.cboxPID.Text = "PID"
        Me.cboxPID.UseVisualStyleBackColor = True
        '
        'cboxPayloadStart
        '
        Me.cboxPayloadStart.Location = New System.Drawing.Point(15, 21)
        Me.cboxPayloadStart.Name = "cboxPayloadStart"
        Me.cboxPayloadStart.Size = New System.Drawing.Size(147, 17)
        Me.cboxPayloadStart.TabIndex = 0
        Me.cboxPayloadStart.Text = "Payload start indicator"
        Me.cboxPayloadStart.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.tbAdaptationLength)
        Me.GroupBox4.Controls.Add(Me.tbAdaptationType)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 333)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(257, 68)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Tag = ""
        Me.GroupBox4.Text = "Adaptation"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(12, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(148, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Adaptation byte count"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbAdaptationLength
        '
        Me.tbAdaptationLength.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbAdaptationLength.Location = New System.Drawing.Point(166, 18)
        Me.tbAdaptationLength.Name = "tbAdaptationLength"
        Me.tbAdaptationLength.ReadOnly = True
        Me.tbAdaptationLength.Size = New System.Drawing.Size(74, 20)
        Me.tbAdaptationLength.TabIndex = 7
        Me.tbAdaptationLength.TabStop = False
        '
        'tbAdaptationType
        '
        Me.tbAdaptationType.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbAdaptationType.Location = New System.Drawing.Point(14, 38)
        Me.tbAdaptationType.Name = "tbAdaptationType"
        Me.tbAdaptationType.ReadOnly = True
        Me.tbAdaptationType.Size = New System.Drawing.Size(226, 20)
        Me.tbAdaptationType.TabIndex = 5
        Me.tbAdaptationType.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbSize)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tbPath)
        Me.GroupBox2.Location = New System.Drawing.Point(278, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(442, 68)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TS file"
        '
        'tbSize
        '
        Me.tbSize.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbSize.Location = New System.Drawing.Point(61, 38)
        Me.tbSize.Name = "tbSize"
        Me.tbSize.ReadOnly = True
        Me.tbSize.Size = New System.Drawing.Size(360, 20)
        Me.tbSize.TabIndex = 8
        Me.tbSize.TabStop = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(9, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Info"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(9, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Path"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbPath
        '
        Me.tbPath.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbPath.Location = New System.Drawing.Point(61, 18)
        Me.tbPath.Name = "tbPath"
        Me.tbPath.ReadOnly = True
        Me.tbPath.Size = New System.Drawing.Size(360, 20)
        Me.tbPath.TabIndex = 6
        Me.tbPath.TabStop = False
        '
        'viewer
        '
        Me.viewer.BackColor = System.Drawing.SystemColors.Window
        Me.viewer.Location = New System.Drawing.Point(734, 66)
        Me.viewer.Multiline = True
        Me.viewer.Name = "viewer"
        Me.viewer.ReadOnly = True
        Me.viewer.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.viewer.Size = New System.Drawing.Size(270, 335)
        Me.viewer.TabIndex = 23
        Me.viewer.TabStop = False
        '
        'dlgMain
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1016, 434)
        Me.Controls.Add(Me.viewer)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.grp_packet)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(742, 461)
        Me.Name = "dlgMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ToolTip1.SetToolTip(Me, "Drag a TS file onto this window to open")
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grp_packet.ResumeLayout(False)
        Me.grp_packet.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tbData As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents File_Menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Exit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Open As System.Windows.Forms.ToolStripButton
    Friend WithEvents status1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Tool_First As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tools_Menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Help_Menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_About As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Prev As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Next As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_DropDownTables As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents PATToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CATToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SDTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TDTTOTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tool_PIDlist As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbTSSync As System.Windows.Forms.TextBox
    Friend WithEvents Menu_Open As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbTSscrambling As System.Windows.Forms.TextBox
    Friend WithEvents tbTSpid As System.Windows.Forms.TextBox
    Friend WithEvents tbTSpriority As System.Windows.Forms.TextBox
    Friend WithEvents tbTSpayloadstart As System.Windows.Forms.TextBox
    Friend WithEvents tbTSerror As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbTScontinuity As System.Windows.Forms.TextBox
    Friend WithEvents tbTSadaptation As System.Windows.Forms.TextBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FileProgressBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents grp_packet As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cboxPayloadStart As System.Windows.Forms.CheckBox
    Friend WithEvents Tool_About As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tbAdaptationLength As System.Windows.Forms.TextBox
    Friend WithEvents tbAdaptationType As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tbSize As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbPath As System.Windows.Forms.TextBox
    Friend WithEvents tbPacketNote2 As System.Windows.Forms.TextBox
    Friend WithEvents tbPacketNote1 As System.Windows.Forms.TextBox
    Friend WithEvents Menu_PIDlist As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cboxPID As System.Windows.Forms.CheckBox
    Friend WithEvents tbPidFilter As System.Windows.Forms.TextBox
    Friend WithEvents Menu_Check_CCount As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbPayloadFilter As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Goto As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Check As System.Windows.Forms.ToolStripButton
    Friend WithEvents Menu_Demux As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Menu_Website As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Check_Sync_Bytes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tool_Stop As System.Windows.Forms.ToolStripButton
    Friend WithEvents viewer As System.Windows.Forms.TextBox
    Friend WithEvents Menu_Report As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Menu_Close As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnalysePacketSpacingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_SavePacket As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Options_Menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TablePIDListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_bytes As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents KeyboardShortcutsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_TableReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LicenceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_debug1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_debug2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
End Class
