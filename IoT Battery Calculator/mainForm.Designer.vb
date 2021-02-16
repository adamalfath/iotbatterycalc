<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbActiveCurrentUnit = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbSleepCurrentUnit = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPowerAvail = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPowerPerHour = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtPowerPerDay = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.numActiveDuration = New System.Windows.Forms.NumericUpDown()
        Me.numActiveCurrent = New System.Windows.Forms.NumericUpDown()
        Me.numSleepDuration = New System.Windows.Forms.NumericUpDown()
        Me.numSleepCurrent = New System.Windows.Forms.NumericUpDown()
        Me.numBatteryCapacity = New System.Windows.Forms.NumericUpDown()
        Me.numBatteryLimit = New System.Windows.Forms.NumericUpDown()
        Me.numPVCurrent = New System.Windows.Forms.NumericUpDown()
        Me.numPVSunTime = New System.Windows.Forms.NumericUpDown()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtPVGen = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtRunTime = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtEnergyBal = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numActiveDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numActiveCurrent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSleepDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSleepCurrent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numBatteryCapacity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numBatteryLimit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPVCurrent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPVSunTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Active Duration"
        Me.ToolTip1.SetToolTip(Me.Label1, "How long device run the task")
        '
        'cbActiveCurrentUnit
        '
        Me.cbActiveCurrentUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbActiveCurrentUnit.FormattingEnabled = True
        Me.cbActiveCurrentUnit.Items.AddRange(New Object() {"uA", "mA"})
        Me.cbActiveCurrentUnit.Location = New System.Drawing.Point(182, 47)
        Me.cbActiveCurrentUnit.Name = "cbActiveCurrentUnit"
        Me.cbActiveCurrentUnit.Size = New System.Drawing.Size(44, 21)
        Me.cbActiveCurrentUnit.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sleep Duration"
        Me.ToolTip1.SetToolTip(Me.Label2, "How long device idle/sleep until next cycle" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Zero (0) means device always On")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Active Current"
        Me.ToolTip1.SetToolTip(Me.Label3, "Device current consumption during active mode")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Sleep Current"
        Me.ToolTip1.SetToolTip(Me.Label4, "Device current consumption during sleep mode")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(179, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "seconds"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(179, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "seconds"
        '
        'cbSleepCurrentUnit
        '
        Me.cbSleepCurrentUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSleepCurrentUnit.FormattingEnabled = True
        Me.cbSleepCurrentUnit.Items.AddRange(New Object() {"uA", "mA"})
        Me.cbSleepCurrentUnit.Location = New System.Drawing.Point(182, 99)
        Me.cbSleepCurrentUnit.Name = "cbSleepCurrentUnit"
        Me.cbSleepCurrentUnit.Size = New System.Drawing.Size(44, 21)
        Me.cbSleepCurrentUnit.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(179, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "mAh"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Battery Capacity"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(179, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "%"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Discharge Limit"
        Me.ToolTip1.SetToolTip(Me.Label10, "Safety limit before over-discharge")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(179, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "mA"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "PV Rated Current"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(179, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "hours"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Peak Sun Hour"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(231, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "SENTSOR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Author: Adam Alfath" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Web: sentsor.net" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Repo: github.com/adamalfath/sents" &
        "or")
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(207, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(28, 13)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "mAh"
        '
        'txtPowerAvail
        '
        Me.txtPowerAvail.Location = New System.Drawing.Point(132, 21)
        Me.txtPowerAvail.Name = "txtPowerAvail"
        Me.txtPowerAvail.ReadOnly = True
        Me.txtPowerAvail.Size = New System.Drawing.Size(65, 20)
        Me.txtPowerAvail.TabIndex = 25
        Me.txtPowerAvail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(120, 13)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Usable Battery Capacity"
        Me.ToolTip1.SetToolTip(Me.Label16, "Total usable capacity")
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(207, 77)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(28, 13)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "mAh"
        '
        'txtPowerPerHour
        '
        Me.txtPowerPerHour.Location = New System.Drawing.Point(132, 73)
        Me.txtPowerPerHour.Name = "txtPowerPerHour"
        Me.txtPowerPerHour.ReadOnly = True
        Me.txtPowerPerHour.Size = New System.Drawing.Size(65, 20)
        Me.txtPowerPerHour.TabIndex = 28
        Me.txtPowerPerHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 77)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(112, 13)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "Consumption per Hour"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(207, 103)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(28, 13)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "mAh"
        '
        'txtPowerPerDay
        '
        Me.txtPowerPerDay.Location = New System.Drawing.Point(132, 99)
        Me.txtPowerPerDay.Name = "txtPowerPerDay"
        Me.txtPowerPerDay.ReadOnly = True
        Me.txtPowerPerDay.Size = New System.Drawing.Size(65, 20)
        Me.txtPowerPerDay.TabIndex = 31
        Me.txtPowerPerDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 103)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(108, 13)
        Me.Label20.TabIndex = 32
        Me.Label20.Text = "Consumption per Day"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 128)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(102, 13)
        Me.Label22.TabIndex = 35
        Me.Label22.Text = "Estimated Run Time"
        Me.ToolTip1.SetToolTip(Me.Label22, "Run time estimation without battery recharge")
        '
        'numActiveDuration
        '
        Me.numActiveDuration.Location = New System.Drawing.Point(104, 21)
        Me.numActiveDuration.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.numActiveDuration.Name = "numActiveDuration"
        Me.numActiveDuration.Size = New System.Drawing.Size(65, 20)
        Me.numActiveDuration.TabIndex = 36
        Me.numActiveDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numActiveCurrent
        '
        Me.numActiveCurrent.DecimalPlaces = 1
        Me.numActiveCurrent.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numActiveCurrent.Location = New System.Drawing.Point(104, 47)
        Me.numActiveCurrent.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.numActiveCurrent.Name = "numActiveCurrent"
        Me.numActiveCurrent.Size = New System.Drawing.Size(65, 20)
        Me.numActiveCurrent.TabIndex = 37
        Me.numActiveCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numSleepDuration
        '
        Me.numSleepDuration.Location = New System.Drawing.Point(104, 73)
        Me.numSleepDuration.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.numSleepDuration.Name = "numSleepDuration"
        Me.numSleepDuration.Size = New System.Drawing.Size(65, 20)
        Me.numSleepDuration.TabIndex = 38
        Me.numSleepDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numSleepCurrent
        '
        Me.numSleepCurrent.DecimalPlaces = 1
        Me.numSleepCurrent.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numSleepCurrent.Location = New System.Drawing.Point(104, 99)
        Me.numSleepCurrent.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.numSleepCurrent.Name = "numSleepCurrent"
        Me.numSleepCurrent.Size = New System.Drawing.Size(65, 20)
        Me.numSleepCurrent.TabIndex = 39
        Me.numSleepCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numBatteryCapacity
        '
        Me.numBatteryCapacity.Location = New System.Drawing.Point(104, 22)
        Me.numBatteryCapacity.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.numBatteryCapacity.Name = "numBatteryCapacity"
        Me.numBatteryCapacity.Size = New System.Drawing.Size(65, 20)
        Me.numBatteryCapacity.TabIndex = 40
        Me.numBatteryCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numBatteryLimit
        '
        Me.numBatteryLimit.Location = New System.Drawing.Point(104, 48)
        Me.numBatteryLimit.Name = "numBatteryLimit"
        Me.numBatteryLimit.Size = New System.Drawing.Size(65, 20)
        Me.numBatteryLimit.TabIndex = 41
        Me.numBatteryLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numBatteryLimit.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'numPVCurrent
        '
        Me.numPVCurrent.Location = New System.Drawing.Point(104, 23)
        Me.numPVCurrent.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.numPVCurrent.Name = "numPVCurrent"
        Me.numPVCurrent.Size = New System.Drawing.Size(65, 20)
        Me.numPVCurrent.TabIndex = 42
        Me.numPVCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numPVSunTime
        '
        Me.numPVSunTime.DecimalPlaces = 1
        Me.numPVSunTime.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numPVSunTime.Location = New System.Drawing.Point(104, 48)
        Me.numPVSunTime.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.numPVSunTime.Name = "numPVSunTime"
        Me.numPVSunTime.Size = New System.Drawing.Size(65, 20)
        Me.numPVSunTime.TabIndex = 43
        Me.numPVSunTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numPVSunTime.Value = New Decimal(New Integer() {45, 0, 0, 65536})
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(207, 51)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(28, 13)
        Me.Label21.TabIndex = 46
        Me.Label21.Text = "mAh"
        '
        'txtPVGen
        '
        Me.txtPVGen.Location = New System.Drawing.Point(132, 47)
        Me.txtPVGen.Name = "txtPVGen"
        Me.txtPVGen.ReadOnly = True
        Me.txtPVGen.Size = New System.Drawing.Size(65, 20)
        Me.txtPVGen.TabIndex = 44
        Me.txtPVGen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 51)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(107, 13)
        Me.Label23.TabIndex = 45
        Me.Label23.Text = "PV Power Generated"
        Me.ToolTip1.SetToolTip(Me.Label23, "Power generated per day")
        '
        'txtRunTime
        '
        Me.txtRunTime.Location = New System.Drawing.Point(132, 125)
        Me.txtRunTime.Name = "txtRunTime"
        Me.txtRunTime.ReadOnly = True
        Me.txtRunTime.Size = New System.Drawing.Size(99, 20)
        Me.txtRunTime.TabIndex = 50
        Me.txtRunTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.numActiveDuration)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbActiveCurrentUnit)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbSleepCurrentUnit)
        Me.GroupBox1.Controls.Add(Me.numActiveCurrent)
        Me.GroupBox1.Controls.Add(Me.numSleepDuration)
        Me.GroupBox1.Controls.Add(Me.numSleepCurrent)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(237, 133)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Device Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.numBatteryCapacity)
        Me.GroupBox2.Controls.Add(Me.numBatteryLimit)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 155)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(237, 82)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Battery Information"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.numPVCurrent)
        Me.GroupBox3.Controls.Add(Me.numPVSunTime)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 245)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(237, 82)
        Me.GroupBox3.TabIndex = 53
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Solar Panel Information"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.txtEnergyBal)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.txtPowerAvail)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.txtRunTime)
        Me.GroupBox4.Controls.Add(Me.txtPowerPerHour)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.txtPowerPerDay)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.txtPVGen)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Location = New System.Drawing.Point(261, 11)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(241, 226)
        Me.GroupBox4.TabIndex = 54
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Results"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 154)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(82, 13)
        Me.Label24.TabIndex = 53
        Me.Label24.Text = "Energy Balance"
        Me.ToolTip1.SetToolTip(Me.Label24, "Difference between current generated vs. consumed" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positive (+) means device powe" &
        "r is self-sustained" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Negative (-) means device will be Off when battery capacity" &
        " reach 0")
        '
        'txtEnergyBal
        '
        Me.txtEnergyBal.Location = New System.Drawing.Point(132, 151)
        Me.txtEnergyBal.Name = "txtEnergyBal"
        Me.txtEnergyBal.ReadOnly = True
        Me.txtEnergyBal.Size = New System.Drawing.Size(65, 20)
        Me.txtEnergyBal.TabIndex = 52
        Me.txtEnergyBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(207, 154)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(28, 13)
        Me.Label25.TabIndex = 54
        Me.Label25.Text = "mAh"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(35, 203)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(172, 13)
        Me.Label26.TabIndex = 51
        Me.Label26.Text = "Results may vary from real situation"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.PictureBox1)
        Me.GroupBox5.Location = New System.Drawing.Point(261, 245)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(241, 83)
        Me.GroupBox5.TabIndex = 55
        Me.GroupBox5.TabStop = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 10000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 100
        '
        'mainForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(514, 340)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IoT Battery Calculator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numActiveDuration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numActiveCurrent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSleepDuration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSleepCurrent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numBatteryCapacity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numBatteryLimit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPVCurrent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPVSunTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents cbActiveCurrentUnit As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbSleepCurrentUnit As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtPowerAvail As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtPowerPerHour As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtPowerPerDay As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents numActiveDuration As NumericUpDown
    Friend WithEvents numActiveCurrent As NumericUpDown
    Friend WithEvents numSleepDuration As NumericUpDown
    Friend WithEvents numSleepCurrent As NumericUpDown
    Friend WithEvents numBatteryCapacity As NumericUpDown
    Friend WithEvents numBatteryLimit As NumericUpDown
    Friend WithEvents numPVCurrent As NumericUpDown
    Friend WithEvents numPVSunTime As NumericUpDown
    Friend WithEvents Label21 As Label
    Friend WithEvents txtPVGen As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtRunTime As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label26 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label24 As Label
    Friend WithEvents txtEnergyBal As TextBox
    Friend WithEvents Label25 As Label
End Class
