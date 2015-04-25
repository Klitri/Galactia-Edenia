<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ship
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
        Me.timGUT = New System.Windows.Forms.Timer(Me.components)
        Me.mnuShipControls = New System.Windows.Forms.MenuStrip()
        Me.lblGUT = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnBeam = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnActivatedSuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblAir = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPrintReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.HyperDriveMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.FTL = New System.Windows.Forms.ToolStripMenuItem()
        Me.FTLCharge = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCryostasis = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicalStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCheckStatus = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnHeal = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCloning = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnBank = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnBalance = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDeposit = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnWithdraw = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblInterest = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPin = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblPin = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPin = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCash = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCash = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReadTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.timHyperDrive = New System.Windows.Forms.Timer(Me.components)
        Me.timBreath = New System.Windows.Forms.Timer(Me.components)
        Me.timSuitSync = New System.Windows.Forms.Timer(Me.components)
        Me.timCloning = New System.Windows.Forms.Timer(Me.components)
        Me.timBank = New System.Windows.Forms.Timer(Me.components)
        Me.btnReset = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShipControls.SuspendLayout()
        Me.SuspendLayout()
        '
        'timGUT
        '
        Me.timGUT.Enabled = True
        Me.timGUT.Interval = 1000
        '
        'mnuShipControls
        '
        Me.mnuShipControls.AutoSize = False
        Me.mnuShipControls.BackColor = System.Drawing.SystemColors.ControlDark
        Me.mnuShipControls.Dock = System.Windows.Forms.DockStyle.Left
        Me.mnuShipControls.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblGUT, Me.btnBeam, Me.mnuSuit, Me.btnPrintReport, Me.HyperDriveMenu, Me.btnCryostasis, Me.MedicalStatusToolStripMenuItem, Me.btnBank, Me.mnuInfo, Me.ReadTestToolStripMenuItem})
        Me.mnuShipControls.Location = New System.Drawing.Point(0, 0)
        Me.mnuShipControls.Name = "mnuShipControls"
        Me.mnuShipControls.Size = New System.Drawing.Size(135, 261)
        Me.mnuShipControls.TabIndex = 5
        Me.mnuShipControls.Text = "Ship"
        '
        'lblGUT
        '
        Me.lblGUT.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGUT.Name = "lblGUT"
        Me.lblGUT.Size = New System.Drawing.Size(128, 25)
        Me.lblGUT.Text = "1/1/2500"
        '
        'btnBeam
        '
        Me.btnBeam.Name = "btnBeam"
        Me.btnBeam.Size = New System.Drawing.Size(128, 21)
        Me.btnBeam.Text = "Beam Down"
        '
        'mnuSuit
        '
        Me.mnuSuit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnActivatedSuit, Me.lblAir})
        Me.mnuSuit.Name = "mnuSuit"
        Me.mnuSuit.Size = New System.Drawing.Size(128, 21)
        Me.mnuSuit.Text = "Suit"
        '
        'btnActivatedSuit
        '
        Me.btnActivatedSuit.CheckOnClick = True
        Me.btnActivatedSuit.Name = "btnActivatedSuit"
        Me.btnActivatedSuit.Size = New System.Drawing.Size(129, 22)
        Me.btnActivatedSuit.Text = "Activated"
        '
        'lblAir
        '
        Me.lblAir.Name = "lblAir"
        Me.lblAir.Size = New System.Drawing.Size(129, 22)
        Me.lblAir.Text = "100%"
        '
        'btnPrintReport
        '
        Me.btnPrintReport.Name = "btnPrintReport"
        Me.btnPrintReport.Size = New System.Drawing.Size(128, 21)
        Me.btnPrintReport.Text = "Print Planet Report"
        '
        'HyperDriveMenu
        '
        Me.HyperDriveMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FTL, Me.FTLCharge})
        Me.HyperDriveMenu.Name = "HyperDriveMenu"
        Me.HyperDriveMenu.Size = New System.Drawing.Size(128, 21)
        Me.HyperDriveMenu.Text = "HyperDrive"
        '
        'FTL
        '
        Me.FTL.Name = "FTL"
        Me.FTL.Size = New System.Drawing.Size(121, 22)
        Me.FTL.Text = "Activate"
        '
        'FTLCharge
        '
        Me.FTLCharge.Name = "FTLCharge"
        Me.FTLCharge.Size = New System.Drawing.Size(121, 22)
        Me.FTLCharge.Text = "0%"
        '
        'btnCryostasis
        '
        Me.btnCryostasis.Name = "btnCryostasis"
        Me.btnCryostasis.Size = New System.Drawing.Size(128, 21)
        Me.btnCryostasis.Text = "Cryostasis"
        '
        'MedicalStatusToolStripMenuItem
        '
        Me.MedicalStatusToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCheckStatus, Me.btnHeal, Me.btnCloning})
        Me.MedicalStatusToolStripMenuItem.Name = "MedicalStatusToolStripMenuItem"
        Me.MedicalStatusToolStripMenuItem.Size = New System.Drawing.Size(128, 21)
        Me.MedicalStatusToolStripMenuItem.Text = "Medical Bay"
        '
        'btnCheckStatus
        '
        Me.btnCheckStatus.Name = "btnCheckStatus"
        Me.btnCheckStatus.Size = New System.Drawing.Size(165, 22)
        Me.btnCheckStatus.Text = "Check Status"
        '
        'btnHeal
        '
        Me.btnHeal.Name = "btnHeal"
        Me.btnHeal.Size = New System.Drawing.Size(165, 22)
        Me.btnHeal.Text = "Heal"
        '
        'btnCloning
        '
        Me.btnCloning.Checked = True
        Me.btnCloning.CheckOnClick = True
        Me.btnCloning.CheckState = System.Windows.Forms.CheckState.Checked
        Me.btnCloning.Name = "btnCloning"
        Me.btnCloning.Size = New System.Drawing.Size(165, 22)
        Me.btnCloning.Text = "Cloning System"
        '
        'btnBank
        '
        Me.btnBank.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBalance, Me.ToolStripSeparator2, Me.btnDeposit, Me.btnWithdraw, Me.ToolStripSeparator1, Me.lblInterest, Me.btnReset})
        Me.btnBank.Name = "btnBank"
        Me.btnBank.Size = New System.Drawing.Size(128, 21)
        Me.btnBank.Text = "Galactic Bank"
        '
        'btnBalance
        '
        Me.btnBalance.Name = "btnBalance"
        Me.btnBalance.Size = New System.Drawing.Size(189, 22)
        Me.btnBalance.Text = "Check Balance"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(186, 6)
        '
        'btnDeposit
        '
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(189, 22)
        Me.btnDeposit.Text = "Deposit"
        '
        'btnWithdraw
        '
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(189, 22)
        Me.btnWithdraw.Text = "Withdraw"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(186, 6)
        '
        'lblInterest
        '
        Me.lblInterest.Name = "lblInterest"
        Me.lblInterest.Size = New System.Drawing.Size(189, 22)
        Me.lblInterest.Text = "Interest Rate"
        '
        'mnuInfo
        '
        Me.mnuInfo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPin, Me.mnuCash})
        Me.mnuInfo.Name = "mnuInfo"
        Me.mnuInfo.Size = New System.Drawing.Size(128, 21)
        Me.mnuInfo.Text = "Personal Information"
        '
        'mnuPin
        '
        Me.mnuPin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblPin, Me.btnPin})
        Me.mnuPin.Name = "mnuPin"
        Me.mnuPin.Size = New System.Drawing.Size(152, 22)
        Me.mnuPin.Text = "Bank Pin"
        '
        'lblPin
        '
        Me.lblPin.Name = "lblPin"
        Me.lblPin.Size = New System.Drawing.Size(108, 22)
        Me.lblPin.Text = "0000"
        '
        'btnPin
        '
        Me.btnPin.Name = "btnPin"
        Me.btnPin.Size = New System.Drawing.Size(108, 22)
        Me.btnPin.Text = "Reset"
        '
        'mnuCash
        '
        Me.mnuCash.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblCash})
        Me.mnuCash.Name = "mnuCash"
        Me.mnuCash.Size = New System.Drawing.Size(152, 22)
        Me.mnuCash.Text = "Cash"
        '
        'lblCash
        '
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(90, 22)
        Me.lblCash.Text = "$0"
        '
        'ReadTestToolStripMenuItem
        '
        Me.ReadTestToolStripMenuItem.Enabled = False
        Me.ReadTestToolStripMenuItem.Name = "ReadTestToolStripMenuItem"
        Me.ReadTestToolStripMenuItem.Size = New System.Drawing.Size(128, 21)
        Me.ReadTestToolStripMenuItem.Text = "ReadTest WIP"
        '
        'timHyperDrive
        '
        Me.timHyperDrive.Interval = 500
        '
        'timBreath
        '
        Me.timBreath.Interval = 150
        '
        'timSuitSync
        '
        Me.timSuitSync.Enabled = True
        '
        'timCloning
        '
        Me.timCloning.Enabled = True
        '
        'timBank
        '
        Me.timBank.Enabled = True
        Me.timBank.Interval = 1000
        '
        'btnReset
        '
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(189, 22)
        Me.btnReset.Text = "Reset Bank Account"
        '
        'Ship
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 261)
        Me.Controls.Add(Me.mnuShipControls)
        Me.MainMenuStrip = Me.mnuShipControls
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ship"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Ship"
        Me.mnuShipControls.ResumeLayout(False)
        Me.mnuShipControls.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents timGUT As System.Windows.Forms.Timer
    Friend WithEvents mnuShipControls As System.Windows.Forms.MenuStrip
    Friend WithEvents btnBeam As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPrintReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HyperDriveMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FTL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FTLCharge As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents timHyperDrive As System.Windows.Forms.Timer
    Friend WithEvents lblGUT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReadTestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCryostasis As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MedicalStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCheckStatus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnHeal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents timBreath As System.Windows.Forms.Timer
    Friend WithEvents mnuSuit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnActivatedSuit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents timSuitSync As System.Windows.Forms.Timer
    Friend WithEvents lblAir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents timCloning As System.Windows.Forms.Timer
    Friend WithEvents btnCloning As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnBank As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuInfo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblPin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnBalance As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDeposit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnWithdraw As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCash As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblCash As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblInterest As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents timBank As System.Windows.Forms.Timer
    Friend WithEvents btnReset As System.Windows.Forms.ToolStripMenuItem
End Class
