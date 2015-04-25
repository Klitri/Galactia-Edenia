Public Class frmMain

    Private Sub timGUT_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timGUT.Tick
        lblGUT.Text = intDay & "/" & intMonth & "/" & intYear
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblGUT.Text = intDay & "/" & intMonth & "/" & intYear
    End Sub

    Private Sub timSuitController_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timSuitController.Tick
        If dblOxygenSupply >= 0 And dblOxygenSupply <= 100 Then
            dblOxygenSupply -= 0.5
        End If
    End Sub

    Private Sub timMasterControl_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timMasterControl.Tick
        'Death
        If dblTotal <= 0 And bolDead = False And bolPlayerOnPlanet = True Then
            bolDead = True
            bolPlayerOnPlanet = False
            Ship.Show()
            Me.Hide()
        End If

        'This monster controls the oxygen provided by planet to suit.
        lblOxygen.Text = dblOxygenSupply

        If dblPlanetOxygen > 19.5 And bolSuitActive = False And dblOxygenSupply <= 100 Then 'Checks if the planet is suitable
            dblOxygenSupply += dblPlanetOxygen / 10 'Supplies the oxygen
        End If

        'End sub Module

        'Fancy Oxygen Tank
        If dblOxygenSupply > 100 Then 'Safety Checks oxygen supply
            dblOxygenSupply = 100 'Safety Checks oxygen supply
            lblOxygen.Text = "FULL"
        ElseIf dblOxygenSupply < 1 Then 'Safety Checks oxygen supply
            dblOxygenSupply = 1 'Safety Checks oxygen supply
            lblOxygen.Text = "EMPTY"
        End If
        'End Sub Module

        'Handles HP
        If dblPlanetToxic > 5 And bolSuitActive = False And bolPlayerOnPlanet = True Then
            dblTorso -= dblPlanetToxic / 100
            dblLArm -= dblPlanetToxic / 100
            dblRArm -= dblPlanetToxic / 100
            dblLLeg -= dblPlanetToxic / 100
            dblRLeg -= dblPlanetToxic / 100
            dblHead -= dblPlanetToxic / 100

            dblTotal = (dblTorso + dblHead + dblLArm + dblRArm + dblLLeg + dblRLeg)
        End If

        'Suffocation
        If bolSuffocation = True Then
            dblTorso -= 1
            dblLArm -= 1
            dblRArm -= 1
            dblLLeg -= 1
            dblRLeg -= 1
            dblHead -= 1

            dblTotal = (dblTorso + dblHead + dblLArm + dblRArm + dblLLeg + dblRLeg)
        End If
        'Handles lifesign
        lblLifesign.Text = Format(dblTotal, "Fixed")
    End Sub

    Private Sub btnPlanetDiagnose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If dblPlanetOxygen >= 19.5 Then
            If dblPlanetToxic < 5 Then
                lblHazardScan.Text = "SAFE"
                lblHazardScan.ForeColor = Color.Green
            Else
                lblHazardScan.Text = "UNSAFE"
                lblHazardScan.ForeColor = Color.Red
            End If
        Else
            lblHazardScan.Text = "UNSAFE"
            lblHazardScan.ForeColor = Color.Red
        End If
    End Sub

    Private Sub timBreath_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timBreath.Tick
        If dblPlanetOxygen >= 19.5 And bolSuitActive = False Then
            bolSuffocation = False
        Else
            bolSuffocation = True
        End If

        If bolSuitActive = True Then
            If dblOxygenSupply >= 19.5 Then
                bolSuffocation = False
            Else
                bolSuffocation = True
            End If
        End If
    End Sub

    Private Sub lstCities_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSites.DoubleClick
        Dim days As Integer
        Dim traveltime As Integer
        Dim travel As Integer

        If lstSites.SelectedNode.Tag <> Nothing Then
            travel = MsgBox("Traveling will take " & lstSites.SelectedNode.Tag & " Days. Really travel to this location?", MsgBoxStyle.YesNo, "Travel?")
            If travel = 6 Then
                traveltime = lstSites.SelectedNode.Tag
                days = traveltime


                For traveltime = 0 To days - 1
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

                If bolHumans = True Then
                    For count = 0 To intSites - 1
                        lstSites.Nodes(0).Nodes(count).Tag = Int(Rnd() * 100)
                    Next
                End If
                For adventurecount = 0 To intSitestoMake - 1
                    lstSites.Nodes(lstSites.Nodes.Count - 1).Nodes(adventurecount).Tag = Int(Rnd() * 100)
                Next

                lstSites.Nodes(lstSites.Nodes.Count - 2).Nodes(0).Tag = Int(Rnd() * 100)

                lstSites.SelectedNode.Tag = 0

                strSiteLocation = lstSites.SelectedNode.Text

                MsgBox("You've arrived at your destination.", MsgBoxStyle.OkOnly, "Travel")

                lblLocation.Text = strSiteLocation

                If strSiteLocation = "Ship" Then
                    btnToShip.Enabled = True
                Else
                    btnToShip.Enabled = False
                End If
            Else

            End If
        End If
    End Sub
    Private Sub timSuitSync_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timSuitSync.Tick
        If bolSuitActive = True Then
            chkSuit.Checked = True
        Else
            chkSuit.Checked = False
        End If
    End Sub

    Private Sub btnPlanetDiagnose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlanetDiagnose.Click
        If dblPlanetOxygen >= 19.5 Then
            If dblPlanetToxic < 5 Then
                lblHazardScan.Text = "SAFE"
                lblHazardScan.ForeColor = Color.Green
            Else
                lblHazardScan.Text = "UNSAFE"
                lblHazardScan.ForeColor = Color.Red
            End If
        Else
            lblHazardScan.Text = "UNSAFE"
            lblHazardScan.ForeColor = Color.Red
        End If
    End Sub

    Private Sub chkSuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSuit.Click
        If chkSuit.Checked = True Then
            timSuitController.Start()
            bolSuitActive = True
        Else
            timSuitController.Stop()
            bolSuitActive = False
        End If
    End Sub

    Private Sub btnScanSite_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScanSite.Click
        Dim planetcivs As Integer

        lstSites.Nodes.Clear()

        'Generates cities
        If bolHumans = True Then
            lstSites.Nodes.Add(strSpecies(0))
        End If
        If bolLizards = True Then
            lstSites.Nodes.Add(strSpecies(1))
        End If

        intSites = lonPopulation(0) / 1000000
        If lstSites.Nodes.Count >= 1 Then
            For count = 0 To intSites - 1
                lstSites.Nodes(0).Nodes.Add("City" & count)
                lstSites.Nodes(0).Nodes(count).Tag = Int(Rnd() * 100)
                lstSites.Nodes(0).Nodes(count).Text = "City " & count
            Next
        End If

        intSites = lonPopulation(1) / 1000000
        If lstSites.Nodes.Count >= 2 Then
            For count = 0 To intSites - 1
                lstSites.Nodes(1).Nodes.Add("City" & count)
                lstSites.Nodes(1).Nodes(count).Tag = Int(Rnd() * 100)
                lstSites.Nodes(1).Nodes(count).Text = "City " & count
            Next
        End If

        planetcivs = lstSites.Nodes.Count

        'Makes the launch site
        lstSites.Nodes.Add("Launch Site")
        lstSites.Nodes(lstSites.Nodes.Count - 1).Nodes.Add("Ship")
        If lstSites.Nodes.Count < 1 Then
            lstSites.Nodes(lstSites.Nodes.Count - planetcivs).Nodes(lstSites.Nodes.Count - 1).Tag = 0
        Else
            lstSites.Nodes(0).Nodes(0).Tag = 0
        End If
        'Makes adventure sites
        intSitestoMake = Int(Rnd() * 10)
        lstSites.Nodes.Add("Sites")

        For adventurecount = 0 To intSitestoMake - 1
            ruintype = Int(Rnd() * 3)
            If dblPlanetOxygen Then
                ruintype = Int(Rnd() * 5)
            End If

            lstSites.Nodes(lstSites.Nodes.Count - 1).Nodes.Add(strAdventures(ruintype))
        Next

        For adventurecount = 0 To intSitestoMake - 1
            lstSites.Nodes(lstSites.Nodes.Count - 1).Nodes(adventurecount).Tag = Int(Rnd() * 100)
        Next
    End Sub

    Private Sub btnEnterSite_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterSite.Click
        Call AdventureCave()
        Call AdventureRuins()
        Call AdventureMountain()
        Call AdventureShip()
        Call AdventureForest()
        Call CityPlay()
    End Sub

    Private Sub timWarnings_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timWarnings.Tick
        If dblTotal < 100 Then
            mnuLifesigns.BackColor = Color.Magenta
        Else
            mnuLifesigns.BackColor = Color.DarkGray
        End If

        If bolSuitActive = True Then
            If dblOxygenSupply >= 75 Then
                mnuSuit.BackColor = Color.Green
            ElseIf dblOxygenSupply <= 75 And dblOxygenSupply >= 50 Then
                mnuSuit.BackColor = Color.Yellow
            ElseIf dblOxygenSupply <= 50 And dblOxygenSupply >= 25 Then
                mnuSuit.BackColor = Color.Red
            ElseIf dblOxygenSupply <= 25 Then
                mnuSuit.BackColor = Color.Magenta
            End If
        Else
            mnuSuit.BackColor = Color.DarkGray
        End If

    End Sub

    Private Sub btnWarnings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWarnings.Click
        If btnWarnings.Checked = True Then
            timWarnings.Start()
        Else
            timWarnings.Stop()
            mnuSuit.BackColor = Color.DarkGray
        End If
    End Sub

    Private Sub btnToShip_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToShip.Click
        bolPlayerOnPlanet = False
        Ship.Show()
        Me.Hide()
    End Sub

    Private Sub mnuPlanetOptions_DropDownOpened(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPlanetOptions.DropDownOpened
        lblPlanetName.Text = strPlanetName
    End Sub
End Class
