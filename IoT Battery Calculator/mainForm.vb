' ========================================================================
'   __  __      _____  ______  _   _  _______   _____   ____   _____ 
'   \ \ \ \    / ____||  ____|| \ | ||__   __| / ____| / __ \ |  __ \    
' __ \ \ \ \  | (___  | |__   |  \| |   | |   | (___  | |  | || |__) |   
' \ \ \ \ \_\  \___ \ |  __|  |     |   | |    \___ \ | |  | ||  _  /    
'  \ \ \ \     ____) || |____ | |\  |   | |    ____) || |__| || | \ \    
'   \_\ \_\   |_____/ |______||_| \_|   |_|   |_____/  \____/ |_|  \_\      
'
' Project: IoT Battery Calculator
' Description: Easy tools to estimate run time of battery powered device
' Author: SENTSOR
' Started Date : 19 April 2020
' ========================================================================

Public Class mainForm
    Dim activeCurrent, activeDuration, activeCurrentUnit, sleepCurrent, sleepDuration, sleepCurrentUnit As Double
    Dim batteryCapacity, batteryLimit, PVCurrent, PVSunTime As Double

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbActiveCurrentUnit.SelectedIndex = 1
        cbSleepCurrentUnit.SelectedIndex = 1
    End Sub

    Private Sub NewInputHandler(sender As Object, e As EventArgs) Handles _
        numActiveDuration.ValueChanged, cbActiveCurrentUnit.SelectedIndexChanged, numActiveCurrent.ValueChanged,
        numSleepDuration.ValueChanged, cbSleepCurrentUnit.SelectedIndexChanged, numSleepCurrent.ValueChanged,
        numBatteryCapacity.ValueChanged, numBatteryLimit.ValueChanged, numPVCurrent.ValueChanged, numPVSunTime.ValueChanged

        ' Get value
        activeDuration = numActiveDuration.Value
        activeCurrentUnit = If(cbActiveCurrentUnit.SelectedIndex = 0, 0.001, 1)
        activeCurrent = numActiveCurrent.Value * activeCurrentUnit
        sleepDuration = numSleepDuration.Value
        sleepCurrentUnit = If(cbSleepCurrentUnit.SelectedIndex = 0, 0.001, 1)
        sleepCurrent = numSleepCurrent.Value * sleepCurrentUnit
        batteryCapacity = numBatteryCapacity.Value
        batteryLimit = numBatteryLimit.Value
        PVCurrent = numPVCurrent.Value
        PVSunTime = numPVSunTime.Value

        Calculate()
    End Sub

    Private Sub Calculate()
        Dim activeDurationPerHour, sleepDurationPerHour, powerConsumptionPerHour, powerConsumptionPerDay As Double
        Dim powerAvail, PVGen, energyBal, runTimeHour As Double
        Dim rt As Long
        Dim runTimeText As String = ""

        ' Calculate result
        activeDurationPerHour = activeDuration / (activeDuration + sleepDuration) * 3600
        sleepDurationPerHour = sleepDuration / (activeDuration + sleepDuration) * 3600
        powerConsumptionPerHour = (activeDurationPerHour / 3600 * activeCurrent) + (sleepDurationPerHour / 3600 * sleepCurrent)
        powerConsumptionPerDay = powerConsumptionPerHour * 24
        powerAvail = batteryCapacity * (100 - batteryLimit) / 100
        PVGen = PVCurrent * PVSunTime
        energyBal = PVGen - powerConsumptionPerDay
        runTimeHour = powerAvail / powerConsumptionPerHour

        If (powerConsumptionPerHour > 0 And runTimeHour > 0) Then
            If (runTimeHour < (1000 * 24)) Then
                rt = runTimeHour * 3600
                Dim rtDay As Integer = rt \ 86400
                runTimeText += rtDay.ToString + "d "

                rt = rt Mod 86400
                Dim rtHour As Integer = rt \ 3600
                runTimeText += rtHour.ToString + "h "

                rt = rt Mod 3600
                Dim rtMinute As Integer = rt \ 60
                runTimeText += rtMinute.ToString + "m "

                rt = rt Mod 60
                Dim rtSecond As Integer = rt
                runTimeText += rtSecond.ToString + "s"
            Else
                rt = runTimeHour
                Dim rtYear As Integer = rt \ 8760
                runTimeText += rtYear.ToString + "y "

                rt = rt Mod 8760
                Dim rtMonth As Integer = rt \ 730
                runTimeText += rtMonth.ToString + "m "

                rt = rt Mod 730
                Dim rtDay As Integer = rt \ 24
                runTimeText += rtDay.ToString + "d"
            End If
        Else
            runTimeText = "-"
        End If

        ' Update result
        txtPowerAvail.Text = Format(powerAvail, "0.00")
        txtPVGen.Text = Format(PVGen, "0.00")
        txtPowerPerHour.Text = Format(powerConsumptionPerHour, "0.00")
        txtPowerPerDay.Text = Format(powerConsumptionPerDay, "0.00")
        txtEnergyBal.Text = If(energyBal >= 0, "+", "") + Format(energyBal, "0.00")
        txtRunTime.Text = runTimeText
    End Sub
End Class

' End of File [SENTSOR]