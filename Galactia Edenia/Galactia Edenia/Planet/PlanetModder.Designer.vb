<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlanetModder
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
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.txtOxygen = New System.Windows.Forms.TextBox()
        Me.txtNitrogen = New System.Windows.Forms.TextBox()
        Me.txtToxin = New System.Windows.Forms.TextBox()
        Me.txtWater = New System.Windows.Forms.TextBox()
        Me.txtPlant = New System.Windows.Forms.TextBox()
        Me.lblPressure = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(12, 226)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(260, 23)
        Me.btnCreate.TabIndex = 0
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'txtOxygen
        '
        Me.txtOxygen.Location = New System.Drawing.Point(12, 12)
        Me.txtOxygen.Name = "txtOxygen"
        Me.txtOxygen.Size = New System.Drawing.Size(100, 20)
        Me.txtOxygen.TabIndex = 1
        Me.txtOxygen.Text = "0"
        '
        'txtNitrogen
        '
        Me.txtNitrogen.Location = New System.Drawing.Point(12, 38)
        Me.txtNitrogen.Name = "txtNitrogen"
        Me.txtNitrogen.Size = New System.Drawing.Size(100, 20)
        Me.txtNitrogen.TabIndex = 2
        Me.txtNitrogen.Text = "0"
        '
        'txtToxin
        '
        Me.txtToxin.Location = New System.Drawing.Point(12, 64)
        Me.txtToxin.Name = "txtToxin"
        Me.txtToxin.Size = New System.Drawing.Size(100, 20)
        Me.txtToxin.TabIndex = 3
        Me.txtToxin.Text = "0"
        '
        'txtWater
        '
        Me.txtWater.Location = New System.Drawing.Point(12, 90)
        Me.txtWater.Name = "txtWater"
        Me.txtWater.Size = New System.Drawing.Size(100, 20)
        Me.txtWater.TabIndex = 4
        Me.txtWater.Text = "0"
        '
        'txtPlant
        '
        Me.txtPlant.Location = New System.Drawing.Point(12, 116)
        Me.txtPlant.Name = "txtPlant"
        Me.txtPlant.Size = New System.Drawing.Size(100, 20)
        Me.txtPlant.TabIndex = 5
        Me.txtPlant.Text = "0"
        '
        'lblPressure
        '
        Me.lblPressure.Location = New System.Drawing.Point(12, 139)
        Me.lblPressure.Name = "lblPressure"
        Me.lblPressure.Size = New System.Drawing.Size(100, 21)
        Me.lblPressure.TabIndex = 6
        Me.lblPressure.Text = "Pressure: Null"
        Me.lblPressure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(118, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Oxygen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(118, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nitrogen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(118, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Toxin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(118, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "H20 / Water"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(118, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Plant / Biodiversity"
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(12, 198)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(260, 22)
        Me.btnHelp.TabIndex = 12
        Me.btnHelp.Text = "Help!"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(12, 172)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(260, 20)
        Me.txtPath.TabIndex = 13
        Me.txtPath.Text = "C:\Users\USERNAMEHERE\Desktop"
        Me.txtPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PlanetModder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPressure)
        Me.Controls.Add(Me.txtPlant)
        Me.Controls.Add(Me.txtWater)
        Me.Controls.Add(Me.txtToxin)
        Me.Controls.Add(Me.txtNitrogen)
        Me.Controls.Add(Me.txtOxygen)
        Me.Controls.Add(Me.btnCreate)
        Me.Name = "PlanetModder"
        Me.Text = "PlanetModder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents txtOxygen As System.Windows.Forms.TextBox
    Friend WithEvents txtNitrogen As System.Windows.Forms.TextBox
    Friend WithEvents txtToxin As System.Windows.Forms.TextBox
    Friend WithEvents txtWater As System.Windows.Forms.TextBox
    Friend WithEvents txtPlant As System.Windows.Forms.TextBox
    Friend WithEvents lblPressure As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
End Class
