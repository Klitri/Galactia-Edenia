Public Class Ship

    Private Sub timGUT_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timGUT.Tick
        If intDay < 31 Then
            intDay += 1
        Else
            intMonth += 1
            intDay = 1
        End If

        If intMonth = 13 Then
            intYear += 1
            intMonth = 1
        End If

        lblGUT.Text = intDay & "/" & intMonth & "/" & intYear
    End Sub

    Private Sub Ship_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Alive
        bolDead = False
        'Shuffle
        Randomize()
        'Loads Universe Species
        Call DebugSpawnSpecies()
        ' Loads Adventures
        strAdventures(0) = "Cave"
        strAdventures(1) = "Ruins"
        strAdventures(2) = "Mountain"
        strAdventures(3) = "Space Ship Wreck"
        strAdventures(4) = "Forest"
        'PlanetModder.Show()
        'Name your ship, cappy!
        'Dim strshipname As String
        'MsgBox("You just got a new ship! What do you want to name it?")
        'strshipname = InputBox("Ship name", "Name your ship", "Ship")
        'Me.Text = strshipname
        'Universal Constants
        intYear = 2500
        intMonth = 1
        intDay = 1
        'Suit Constants
        dblOxygenSupply = 100
        bolSuitActive = False
        'Planet Earth Constants
        dblPlanetOxygen = 80.75
        dblPlanetNitrogen = 20.75
        dblPlanetToxic = 0
        dblPlanetWater = 70
        dblPlanetPlant = 100
        dblPlanetPressure = dblPlanetOxygen + dblPlanetNitrogen + dblPlanetToxic
        'Planet Civilization
        lonPopulation(1) = 5000000
        lonPopulation(0) = 7000000
        'Player Constant at Start
        sinCash = 100
        sinInterestRate = 0.04
    End Sub
    Private Sub btnBeam_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBeam.Click
        bolPlayerOnPlanet = True
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub PrintPlanetReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintReport.Click
        btnPrintReport.Text = "Printing..."
        MsgBox("PLANET SUMMARY REPORT: " & strPlanetName & " O2: " & dblPlanetOxygen & "|N2: " & dblPlanetNitrogen & "|TOXIN: " & dblPlanetToxic & "|H20: " & dblPlanetWater & "|BIODIVERSITY: " & dblPlanetPlant & "|PSI: " & dblPlanetPressure, MsgBoxStyle.Information, "Information Report")
        btnPrintReport.Text = "Print Planet Report"
    End Sub

    Private Sub timHyperDrive_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timHyperDrive.Tick
        If intFTL >= 100 Then
            Call GeneratePlanet()
            timHyperDrive.Stop()
            intFTL = 0
            FTL.Text = "Activate"
            btnBeam.Enabled = True
        Else
            intFTL += 5
        End If
        FTLCharge.Text = intFTL & "%"
    End Sub

    Private Sub FTL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FTL.Click
        If bolFTL = True Then
            timHyperDrive.Stop()
            intFTL = 0
            FTL.Text = "FTL"
            FTL.Text = "Activate"
            bolFTL = False
            FTLCharge.Text = "0%"
            btnBeam.Enabled = True
        ElseIf bolFTL = False Then
            timHyperDrive.Start()
            FTL.Text = "Cancel"
            bolFTL = True
            btnBeam.Enabled = False
        End If
    End Sub

    Private Sub btnCryostasis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCryostasis.Click
        Dim sleep As Integer
        Dim days As Integer
        Dim monthes As Integer
        Dim years As Integer

        sleep = MsgBox("Enter cryostasis and sleep?", MsgBoxStyle.YesNo, "Cryostasis")
        If sleep = 6 Then
            Me.Enabled = False
            timGUT.Stop()
            timBank.Stop()
            days = InputBox("How much days do you want to sleep for? (0 to choose different choice)", "Cryostasis", 0)
            If days <> 0 Then
                For sleeptime = 0 To days - 1
                    If intMonth = 12 And intDay = 30 Then
                        InterestGiver()
                    End If

                    InterestChanger()

                    If sinBankCash > 1000000000 Then
                        sinBankCash = 1000000000
                    End If

                    intDay += 1
                    If intDay > 31 Then
                        intMonth += 1
                        intDay = 1
                    End If
                    If intMonth > 12 Then
                        intYear += 1
                        intMonth = 1
                    End If
                Next
            End If

            monthes = InputBox("How much monthes do you want to sleep for? (0 to choose different choice)", "Cryostasis", 0)
            If monthes <> 0 Then
                For sleeptime = 0 To 31 * monthes - 1
                    If intMonth = 12 And intDay = 30 Then
                        InterestGiver()
                    End If

                    InterestChanger()

                    If sinBankCash > 1000000000 Then
                        sinBankCash = 1000000000
                    End If

                    intDay += 1
                    If intDay > 31 Then
                        intDay = 1
                        intMonth += 1
                    End If
                    If intMonth > 12 Then
                        intMonth = 1
                        intYear += 1
                    End If
                Next
            End If

            years = InputBox("How much years do you want to sleep for? (0 to choose different choice)", "Cryostasis", 0)
            If years <> 0 Then
                For sleeptime = 0 To 372 * years - 1
                    If intMonth = 12 And intDay = 30 Then
                        InterestGiver()
                    End If

                    InterestChanger()

                    If sinBankCash > 1000000000 Then
                        sinBankCash = 1000000000
                    End If

                    intDay += 1
                    If intDay > 31 Then
                        intDay = 1
                        intMonth += 1
                    End If
                    If intMonth > 12 Then
                        intMonth = 1
                        intYear += 1
                    End If
                Next
            End If
        End If

        MsgBox("Putting to sleep.")
        MsgBox("Initiating wakeup procedures.")
        timGUT.Start()
        timBank.Start()
        Me.Enabled = True
    End Sub

    Private Sub btnCheckStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckStatus.Click
        dblTotal = (dblTorso + dblHead + dblLArm + dblRArm + dblLLeg + dblRLeg)

        MsgBox("Assesment complete, printing analysis: Torso: " & dblTorso & "% / Head: " & dblHead & "% / Right Arm: " & dblRArm & "% / Left Arm: " & dblLArm & "% / Right Leg: " & dblRLeg & "% / Left Leg: " & dblLLeg & "% / Overall: " & dblTotal & "%")

    End Sub

    Private Sub timBreath_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timBreath.Tick
        'SHIP OXYGEN
    End Sub

    Private Sub btnActivatedSuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivatedSuit.Click
        If btnActivatedSuit.Checked = True Then
            bolSuitActive = True
        Else
            bolSuitActive = False
        End If
    End Sub

    Private Sub timSuitSync_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timSuitSync.Tick
        If bolSuitActive = True Then
            btnActivatedSuit.Checked = True
        Else
            btnActivatedSuit.Checked = False
        End If

        lblAir.Text = Format(dblOxygenSupply, "Fixed") & "%"
    End Sub

    Private Sub btnHeal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHeal.Click
        MsgBox("Initiating healing.")
        dblHead = dblMaxHead
        dblTorso = dblMaxTorso
        dblLArm = dblMaxLArm
        dblRArm = dblMaxRArm
        dblLLeg = dblMaxLLeg
        dblRLeg = dblMaxRLeg
        dblTotal = 100
        MsgBox("Healing complete.")
    End Sub

    Private Sub timCloning_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timCloning.Tick
        If bolDead = True Then
            mnuShipControls.Enabled = False
        Else
            mnuShipControls.Enabled = True
        End If
        If bolDead = True And bolPlayerOnPlanet = False Then
            timCloning.Stop()
            Dim days As Integer
            Dim clonetime As Integer

            clonetime = 100 * Int(Rnd() * 100)

            days = clonetime

            MsgBox("Warning. No lifesigns detected. Initiating revival process. Estimated time until revival: " & days & " days.")

            For clonetime = 0 To days - 1
                If intDay < 31 Then
                    intDay += 1
                Else
                    intMonth += 1
                    intDay = 1
                End If

                If intMonth = 13 Then
                    intYear += 1
                    intMonth = 1
                End If
            Next

            dblHead = dblMaxHead
            dblTorso = dblMaxTorso
            dblLArm = dblMaxLArm
            dblRArm = dblMaxRArm
            dblLLeg = dblMaxLLeg
            dblRLeg = dblMaxRLeg
            dblTotal = 100

            bolDead = False
            MsgBox("Revival complete.")
            timCloning.Start()
        End If

    End Sub

    Private Sub btnCloning_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloning.Click
        If btnCloning.Checked = True Then
            timCloning.Enabled = True
        Else
            timCloning.Enabled = False
        End If
    End Sub

    Private Sub btnPin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPin.Click
        Dim requestedchange As Integer
        Const maxnums As Integer = 9999
        Const minnums As Integer = 1111

        requestedchange = InputBox("What would you like your new pin to be?", "Reset Pin", "0000")

        If requestedchange > maxnums Or requestedchange < minnums Then
            MsgBox("Invalid.")
        Else
            intBankPin = Conversion.Int(requestedchange)
            lblPin.Text = intBankPin
        End If
    End Sub

    Private Sub btnBalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBalance.Click
        Dim enteredpin As Integer

        enteredpin = InputBox("Please enter your pin.", "Log-in")

        If enteredpin <> intBankPin Then
            MsgBox("Invalid pin.")
        Else
            MsgBox("You have $" & Format(sinBankCash, "Fixed") & " in your account.")
        End If
    End Sub

    Private Sub btnDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeposit.Click
        Dim enteredpin As Integer
        Dim amounttodeposit As String

        enteredpin = InputBox("Please enter your pin.", "Log-in")

        If enteredpin <> intBankPin Then
            MsgBox("Invalid pin.")
        Else
            amounttodeposit = InputBox("How much money do you wish to deposit? ( Type 'All' if you wish to withdraw all )", "Deposit")

            If amounttodeposit = "All" Then
                Conversion.Val(amounttodeposit)
                amounttodeposit = sinCash
                sinCash -= amounttodeposit
                sinBankCash += amounttodeposit
            Else
                If amounttodeposit > sinCash Or amounttodeposit < 0 Then
                    MsgBox("Invalid.")
                Else
                    sinCash -= amounttodeposit
                    sinBankCash += amounttodeposit
                End If
            End If
        End If
    End Sub

    Private Sub btnWithdraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWithdraw.Click
        Dim enteredpin As Integer
        Dim amounttowithdraw As String

        enteredpin = InputBox("Please enter your pin.", "Log-in")

        If enteredpin <> intBankPin Then
            MsgBox("Invalid pin.")
        Else

            amounttowithdraw = InputBox("How much money do you wish to deposit? ( Type 'All' if you wish to withdraw all )", "Deposit")

            If amounttowithdraw = "All" Then
                Conversion.Val(amounttowithdraw)
                amounttowithdraw = sinBankCash
                sinCash += amounttowithdraw
                sinBankCash -= amounttowithdraw
            Else
                If amounttowithdraw > sinBankCash Or amounttowithdraw < 0 Then
                    MsgBox("Invalid.")
                Else
                    sinCash += amounttowithdraw
                    sinBankCash -= amounttowithdraw
                End If
            End If
        End If
    End Sub

    Private Sub mnuCash_DropDownOpened(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCash.DropDownOpened
        lblCash.Text = "$" & Format(sinCash, "Fixed")
    End Sub

    Private Sub timBank_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timBank.Tick
        InterestChanger()

        If intMonth = 12 And intDay = 30 Then
            InterestGiver()
        End If

        lblInterest.Text = Format(sinInterestRate, "Fixed")

        If sinBankCash > 1000000000 Then
            sinBankCash = 1000000000
        End If
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Dim decision As Integer

        decision = MsgBox("Are you sure? You should only do this if your bank account is errored. You'll be refunded $1000 if your account is over the limit.", MsgBoxStyle.YesNo, "Reset Bank")

        If decision = 6 Then
            If sinBankCash >= 1000 Then
                sinBankCash = 1000
                MsgBox("Refunded funds. We apologize for the inconvenience.")
            Else
                sinBankCash = 0
            End If
            MsgBox("Account reset")
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim identifier As String

        MsgBox("Saving coordinates...")

        identifier = InputBox("Please input a special name for the planet.", "Name")

        SaveFile.DefaultExt = ".pla"
        SaveFile.FileName = identifier
        SaveFile.InitialDirectory = "C:\Users\Kyle\Desktop\Galactia Edenia Project Core\Planets"

        SaveFile.ShowDialog()
    End Sub
End Class