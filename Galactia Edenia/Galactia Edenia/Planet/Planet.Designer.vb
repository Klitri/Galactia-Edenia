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
        Me.components = New System.ComponentModel.Container()
        Me.grpTimeSystem = New System.Windows.Forms.GroupBox()
        Me.lblGUT = New System.Windows.Forms.Label()
        Me.timGUT = New System.Windows.Forms.Timer(Me.components)
        Me.timSuitController = New System.Windows.Forms.Timer(Me.components)
        Me.timMasterControl = New System.Windows.Forms.Timer(Me.components)
        Me.timBreath = New System.Windows.Forms.Timer(Me.components)
        Me.lstSites = New System.Windows.Forms.TreeView()
        Me.lblCurrentLocation = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.timSuitSync = New System.Windows.Forms.Timer(Me.components)
        Me.mnuOptions = New System.Windows.Forms.MenuStrip()
        Me.mnuPlanetOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblPlanetName = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblHazardScan = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPlanetDiagnose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnToShip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.chkSuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnWarnings = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblOxygen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLifesigns = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblLifesign = New System.Windows.Forms.ToolStripMenuItem()
        Me.SitesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnScanSite = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnEnterSite = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpSites = New System.Windows.Forms.GroupBox()
        Me.timWarnings = New System.Windows.Forms.Timer(Me.components)
        Me.grpTimeSystem.SuspendLayout()
        Me.mnuOptions.SuspendLayout()
        Me.grpSites.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpTimeSystem
        '
        Me.grpTimeSystem.Controls.Add(Me.lblGUT)
        Me.grpTimeSystem.Location = New System.Drawing.Point(515, 2)
        Me.grpTimeSystem.Name = "grpTimeSystem"
        Me.grpTimeSystem.Size = New System.Drawing.Size(66, 35)
        Me.grpTimeSystem.TabIndex = 1
        Me.grpTimeSystem.TabStop = False
        Me.grpTimeSystem.Text = "GUT"
        '
        'lblGUT
        '
        Me.lblGUT.AutoSize = True
        Me.lblGUT.Location = New System.Drawing.Point(6, 16)
        Me.lblGUT.Name = "lblGUT"
        Me.lblGUT.Size = New System.Drawing.Size(53, 13)
        Me.lblGUT.TabIndex = 0
        Me.lblGUT.Text = "1/1/2500"
        '
        'timGUT
        '
        Me.timGUT.Enabled = True
        Me.timGUT.Interval = 1000
        '
        'timSuitController
        '
        '
        'timMasterControl
        '
        Me.timMasterControl.Enabled = True
        '
        'timBreath
        '
        Me.timBreath.Enabled = True
        Me.timBreath.Interval = 150
        '
        'lstSites
        '
        Me.lstSites.Location = New System.Drawing.Point(6, 34)
        Me.lstSites.Name = "lstSites"
        Me.lstSites.Size = New System.Drawing.Size(188, 125)
        Me.lstSites.TabIndex = 4
        '
        'lblCurrentLocation
        '
        Me.lblCurrentLocation.AutoSize = True
        Me.lblCurrentLocation.Location = New System.Drawing.Point(6, 18)
        Me.lblCurrentLocation.Name = "lblCurrentLocation"
        Me.lblCurrentLocation.Size = New System.Drawing.Size(88, 13)
        Me.lblCurrentLocation.TabIndex = 5
        Me.lblCurrentLocation.Text = "Current Location:"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(100, 18)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(28, 13)
        Me.lblLocation.TabIndex = 6
        Me.lblLocation.Text = "Ship"
        '
        'timSuitSync
        '
        Me.timSuitSync.Enabled = True
        '
        'mnuOptions
        '
        Me.mnuOptions.BackColor = System.Drawing.SystemColors.ControlDark
        Me.mnuOptions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.mnuOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPlanetOptions, Me.mnuSuit, Me.mnuLifesigns, Me.SitesToolStripMenuItem})
        Me.mnuOptions.Location = New System.Drawing.Point(0, 336)
        Me.mnuOptions.Name = "mnuOptions"
        Me.mnuOptions.Size = New System.Drawing.Size(584, 25)
        Me.mnuOptions.TabIndex = 8
        Me.mnuOptions.Text = "MenuStrip1"
        '
        'mnuPlanetOptions
        '
        Me.mnuPlanetOptions.AutoSize = False
        Me.mnuPlanetOptions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblPlanetName, Me.lblHazardScan, Me.btnPlanetDiagnose})
        Me.mnuPlanetOptions.Name = "mnuPlanetOptions"
        Me.mnuPlanetOptions.Size = New System.Drawing.Size(55, 21)
        Me.mnuPlanetOptions.Text = "Planet"
        '
        'lblPlanetName
        '
        Me.lblPlanetName.AutoSize = False
        Me.lblPlanetName.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblPlanetName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlanetName.ForeColor = System.Drawing.Color.Black
        Me.lblPlanetName.Name = "lblPlanetName"
        Me.lblPlanetName.Size = New System.Drawing.Size(178, 26)
        Me.lblPlanetName.Text = "Earth"
        '
        'lblHazardScan
        '
        Me.lblHazardScan.AutoSize = False
        Me.lblHazardScan.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblHazardScan.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHazardScan.ForeColor = System.Drawing.Color.Yellow
        Me.lblHazardScan.Name = "lblHazardScan"
        Me.lblHazardScan.Size = New System.Drawing.Size(178, 26)
        Me.lblHazardScan.Text = "Unknown"
        '
        'btnPlanetDiagnose
        '
        Me.btnPlanetDiagnose.AutoSize = False
        Me.btnPlanetDiagnose.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnPlanetDiagnose.Name = "btnPlanetDiagnose"
        Me.btnPlanetDiagnose.Size = New System.Drawing.Size(178, 26)
        Me.btnPlanetDiagnose.Text = "Scan Atmosphere"
        '
        'mnuSuit
        '
        Me.mnuSuit.BackColor = System.Drawing.Color.Green
        Me.mnuSuit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnToShip, Me.ToolStripSeparator1, Me.chkSuit, Me.lblOxygen})
        Me.mnuSuit.Name = "mnuSuit"
        Me.mnuSuit.Size = New System.Drawing.Size(41, 21)
        Me.mnuSuit.Text = "Suit"
        '
        'btnToShip
        '
        Me.btnToShip.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnToShip.Name = "btnToShip"
        Me.btnToShip.Size = New System.Drawing.Size(115, 26)
        Me.btnToShip.Text = "Ship"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ToolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(112, 6)
        '
        'chkSuit
        '
        Me.chkSuit.BackColor = System.Drawing.SystemColors.ControlDark
        Me.chkSuit.CheckOnClick = True
        Me.chkSuit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnWarnings})
        Me.chkSuit.Name = "chkSuit"
        Me.chkSuit.Size = New System.Drawing.Size(115, 26)
        Me.chkSuit.Text = "Suit"
        '
        'btnWarnings
        '
        Me.btnWarnings.BackColor = System.Drawing.Color.Silver
        Me.btnWarnings.Checked = True
        Me.btnWarnings.CheckOnClick = True
        Me.btnWarnings.CheckState = System.Windows.Forms.CheckState.Checked
        Me.btnWarnings.Name = "btnWarnings"
        Me.btnWarnings.Size = New System.Drawing.Size(174, 22)
        Me.btnWarnings.Text = "Enable Warnings"
        '
        'lblOxygen
        '
        Me.lblOxygen.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblOxygen.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOxygen.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblOxygen.Name = "lblOxygen"
        Me.lblOxygen.Size = New System.Drawing.Size(115, 26)
        Me.lblOxygen.Text = "100%"
        '
        'mnuLifesigns
        '
        Me.mnuLifesigns.AutoSize = False
        Me.mnuLifesigns.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblLifesign})
        Me.mnuLifesigns.Name = "mnuLifesigns"
        Me.mnuLifesigns.Size = New System.Drawing.Size(70, 21)
        Me.mnuLifesigns.Text = "Lifesigns"
        '
        'lblLifesign
        '
        Me.lblLifesign.AutoSize = False
        Me.lblLifesign.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblLifesign.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLifesign.Name = "lblLifesign"
        Me.lblLifesign.Size = New System.Drawing.Size(152, 30)
        Me.lblLifesign.Text = "100%"
        '
        'SitesToolStripMenuItem
        '
        Me.SitesToolStripMenuItem.AutoSize = False
        Me.SitesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnScanSite, Me.ToolStripSeparator2, Me.btnEnterSite})
        Me.SitesToolStripMenuItem.Name = "SitesToolStripMenuItem"
        Me.SitesToolStripMenuItem.Size = New System.Drawing.Size(47, 21)
        Me.SitesToolStripMenuItem.Text = "Sites"
        '
        'btnScanSite
        '
        Me.btnScanSite.AutoSize = False
        Me.btnScanSite.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnScanSite.Name = "btnScanSite"
        Me.btnScanSite.Size = New System.Drawing.Size(152, 22)
        Me.btnScanSite.Text = "Scan Sites"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.AutoSize = False
        Me.ToolStripSeparator2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'btnEnterSite
        '
        Me.btnEnterSite.AutoSize = False
        Me.btnEnterSite.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnEnterSite.Name = "btnEnterSite"
        Me.btnEnterSite.Size = New System.Drawing.Size(152, 22)
        Me.btnEnterSite.Text = "Enter"
        '
        'grpSites
        '
        Me.grpSites.Controls.Add(Me.lstSites)
        Me.grpSites.Controls.Add(Me.lblCurrentLocation)
        Me.grpSites.Controls.Add(Me.lblLocation)
        Me.grpSites.Location = New System.Drawing.Point(12, 12)
        Me.grpSites.Name = "grpSites"
        Me.grpSites.Size = New System.Drawing.Size(200, 165)
        Me.grpSites.TabIndex = 9
        Me.grpSites.TabStop = False
        Me.grpSites.Text = "Planet Sites"
        '
        'timWarnings
        '
        Me.timWarnings.Enabled = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.grpSites)
        Me.Controls.Add(Me.grpTimeSystem)
        Me.Controls.Add(Me.mnuOptions)
        Me.MainMenuStrip = Me.mnuOptions
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Planet"
        Me.grpTimeSystem.ResumeLayout(False)
        Me.grpTimeSystem.PerformLayout()
        Me.mnuOptions.ResumeLayout(False)
        Me.mnuOptions.PerformLayout()
        Me.grpSites.ResumeLayout(False)
        Me.grpSites.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpTimeSystem As System.Windows.Forms.GroupBox
    Friend WithEvents lblGUT As System.Windows.Forms.Label
    Friend WithEvents timGUT As System.Windows.Forms.Timer
    Friend WithEvents timSuitController As System.Windows.Forms.Timer
    Friend WithEvents timMasterControl As System.Windows.Forms.Timer
    Friend WithEvents timBreath As System.Windows.Forms.Timer
    Friend WithEvents lstSites As System.Windows.Forms.TreeView
    Friend WithEvents lblCurrentLocation As System.Windows.Forms.Label
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents timSuitSync As System.Windows.Forms.Timer
    Friend WithEvents mnuOptions As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuPlanetOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblPlanetName As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblHazardScan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSuit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnToShip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLifesigns As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblLifesign As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPlanetDiagnose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkSuit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblOxygen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SitesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnScanSite As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEnterSite As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpSites As System.Windows.Forms.GroupBox
    Friend WithEvents timWarnings As System.Windows.Forms.Timer
    Friend WithEvents btnWarnings As System.Windows.Forms.ToolStripMenuItem

End Class
