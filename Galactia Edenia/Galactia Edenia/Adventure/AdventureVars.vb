Module AdventureVars
    Public strAdventures(4) As String
    Public intSitestoMake As Integer
    Public ruintype As Integer
    'Adventure: Cave
    Sub AdventureCave()
        Dim decision As Integer
        Dim AI As Integer
        Dim exitadventure As Boolean

        'Adventure Site Definition: Cave
        If strSiteLocation = "Cave" Then

            'Cave Adventure
            decision = MsgBox("Enter the cave?", MsgBoxStyle.YesNo, "Enter")

            If decision = 6 Then
                MsgBox("You enter the cave. It's very dark.")

                'Begins the story AI for Cave
                Do
                    AI = Int(Rnd() * 10)
                    If AI = 1 Then
                        MsgBox("You hit a dead end, and turn back to go a different way.", MsgBoxStyle.Information, "Adventure")
                    ElseIf AI = 2 Then
                        decision = MsgBox("You discover a hidden passage, enter it?", MsgBoxStyle.YesNo, "Adventure")
                        If decision = 6 Then

                        Else
                            MsgBox("You don't enter.", MsgBoxStyle.Information, "Adventure")
                        End If
                    ElseIf AI = 3 Then
                        MsgBox("You think you see something move in the dark.", MsgBoxStyle.Information, "Adventure")
                    ElseIf AI = 4 Then
                        decision = MsgBox("You find money! Grab a handful of money?", MsgBoxStyle.YesNo, "Treasure")
                        If decision = 6 Then
                            sinCash += (Rnd() * 5)
                        Else

                        End If
                    ElseIf AI = 5 Then
                        decision = MsgBox("You discover an exit. Leave?", MsgBoxStyle.YesNo, "Exit")
                        If decision = 6 Then
                            exitadventure = True
                        Else

                        End If
                    ElseIf AI = 6 Then
                        MsgBox("It's getting warmer.", MsgBoxStyle.Information, "Adventure")
                    ElseIf AI = 7 Then
                        MsgBox("It's getting colder.", MsgBoxStyle.Information, "Adventure")
                    ElseIf AI = 8 Then
                        Dim attackedpart As Integer
                        Dim attackedpartstring As String
                        attackedpart = Int(Rnd() * 7)
                        If attackedpart = 1 Then
                            attackedpartstring = "head"
                            dblHead -= Int(Rnd() * 5)
                        ElseIf attackedpart = 2 Then
                            attackedpartstring = "torso"
                            dblTorso -= Int(Rnd() * 5)
                        ElseIf attackedpart = 3 Then
                            attackedpartstring = "right arm"
                            dblRArm -= Int(Rnd() * 5)
                        ElseIf attackedpart = 4 Then
                            attackedpartstring = "left arm"
                            dblLArm -= Int(Rnd() * 5)
                        ElseIf attackedpart = 5 Then
                            attackedpartstring = "right leg"
                            dblRLeg -= Int(Rnd() * 5)
                        ElseIf attackedpart = 6 Then
                            attackedpartstring = "left leg"
                            dblLLeg -= Int(Rnd() * 5)
                        Else
                            attackedpartstring = "clothes"
                        End If
                        MsgBox("You're attacked by something! It's hit your " & attackedpartstring & "!")
                    ElseIf AI = 9 Then
                        MsgBox("You hear crying.", MsgBoxStyle.Information, "Adventure")
                    ElseIf AI = 10 Then
                        MsgBox("The cave shakes violently!", MsgBoxStyle.Information, "Adventure")
                    End If
                Loop Until exitadventure = True
                'End Cave Adventure
            End If
            Else

            End If

    End Sub
    'Adventure: Ruins
    Sub AdventureRuins()
        Dim decision As Integer
        Dim AI As Integer
        Dim exitadventure As Boolean

        'Adventure Site Definition: Ruins
        If strSiteLocation = "Ruins" Then

            'Ruins Adventure
            decision = MsgBox("Enter the ruins?", MsgBoxStyle.YesNo, "Enter")

            If decision = 6 Then
                MsgBox("You enter the ruins. The entrance is beautiful.")

                Do
                    AI = Int(Rnd() * 10)
                    If AI = 1 Then
                        MsgBox("The path you were taking is blocked by a gigantic statue. After some thinking, you see a skull sitting on a table. You pick up the skull, and the statue splits in two and opens, revealing a door.", MsgBoxStyle.Information, "Adventure")
                    ElseIf AI = 2 Then
                        decision = MsgBox("You discover a hidden passage, enter it?", MsgBoxStyle.YesNo, "Adventure")
                        If decision = 6 Then

                        Else
                            MsgBox("You don't enter.", MsgBoxStyle.Information, "Adventure")
                        End If
                    ElseIf AI = 3 Then
                        MsgBox("You hear moaning coming from the end up the hall. You decide to take a different path.", MsgBoxStyle.Information, "Adventure")
                    ElseIf AI = 4 Then
                        decision = MsgBox("You find money! Take it?", MsgBoxStyle.YesNo, "Treasure")
                        If decision = 6 Then
                            sinCash += (Rnd() * 75)
                        Else

                        End If
                    ElseIf AI = 5 Then
                        decision = MsgBox("You discover an exit to the ruins. Leave?", MsgBoxStyle.YesNo, "Exit")
                        If decision = 6 Then
                            exitadventure = True
                        Else

                        End If
                    ElseIf AI = 6 Then
                        MsgBox("You walk into a vast open room, with six pillars in a circle. You walk into the center of the circle, and notice some money. Before you get to the table, the floor below you collapses and you fall into a room.", MsgBoxStyle.Information, "Adventure")
                    ElseIf AI = 7 Then
                        MsgBox("The ruins are very beautiful. The images on the wall are hard to read, but they're very detailed. You wander around a bit, admiring the craftsmanship.", MsgBoxStyle.Information, "Adventure")
                    ElseIf AI = 8 Then
                        Dim attackedpart As Integer
                        Dim attackedpartstring As String
                        attackedpart = Int(Rnd() * 7)
                        If attackedpart = 1 Then
                            attackedpartstring = "head"
                            dblHead -= Int(Rnd() * 5)
                        ElseIf attackedpart = 2 Then
                            attackedpartstring = "torso"
                            dblTorso -= Int(Rnd() * 5)
                        ElseIf attackedpart = 3 Then
                            attackedpartstring = "right arm"
                            dblRArm -= Int(Rnd() * 5)
                        ElseIf attackedpart = 4 Then
                            attackedpartstring = "left arm"
                            dblLArm -= Int(Rnd() * 5)
                        ElseIf attackedpart = 5 Then
                            attackedpartstring = "right leg"
                            dblRLeg -= Int(Rnd() * 5)
                        ElseIf attackedpart = 6 Then
                            attackedpartstring = "left leg"
                            dblLLeg -= Int(Rnd() * 5)
                        Else
                            attackedpartstring = "clothes"
                        End If
                        MsgBox("You're attacked by something! It's hit your " & attackedpartstring & "!")
                    ElseIf AI = 9 Then
                        Dim strDepictions(5) As String
                        Dim strDepictions2(5) As String
                        Dim strDepictions3(5) As String
                        Dim randomizer As Integer
                        Dim randomizer2 As Integer
                        Dim randomizer3 As Integer

                        strDepictions(0) = "humans"
                        strDepictions(1) = "animals"
                        strDepictions(2) = "skeletons"
                        strDepictions(3) = "demons"
                        strDepictions(4) = "monsters"
                        strDepictions(5) = "a god"

                        strDepictions2(0) = "worshiping"
                        strDepictions2(1) = "killing"
                        strDepictions2(2) = "healing"
                        strDepictions2(3) = "enslaving"
                        strDepictions2(4) = "banishing"
                        strDepictions2(5) = "begging"

                        strDepictions3(0) = "humans"
                        strDepictions3(1) = "animals"
                        strDepictions3(2) = "skeletons"
                        strDepictions3(3) = "demons"
                        strDepictions3(4) = "monsters"
                        strDepictions3(5) = "a god"

                        randomizer = Int(Rnd() * 5)
                        randomizer2 = Int(Rnd() * 5)
                        randomizer3 = Int(Rnd() * 5)

                        MsgBox("You discover an ancient story hall. It depicts " & strDepictions(randomizer) & " " & strDepictions2(randomizer2) & " " & strDepictions3(randomizer3), MsgBoxStyle.Information, "Adventure")
                    ElseIf AI = 10 Then
                        MsgBox("The ruins begin to shake violently!", MsgBoxStyle.Information, "Adventure")
                    End If
                Loop Until exitadventure = True
                'End Ruin Adventure
            End If
        Else

        End If
    End Sub
    'Adventure: Mountain
    Sub AdventureMountain()
        Dim decision As Integer
        Dim AI As Integer
        Dim exitadventure As Boolean

        'Adventure Site Definition: Mountain
        If strSiteLocation = "Mountain" Then

            'Mountain Adventure
            decision = MsgBox("Enter the mountain?", MsgBoxStyle.YesNo, "Enter")

            If decision = 6 Then
                MsgBox("You enter the mountain. You feel uneasy.")

                'Begins the story AI for Mountain
                Do
                    AI = Int(Rnd() * 10)
                    If AI = 1 Then
                        MsgBox("The end of the hall is just a wall. You search for another way.", MsgBoxStyle.Information, "Adventure")
                    ElseIf AI = 2 Then
                        decision = MsgBox("You discover a hidden passage, enter it?", MsgBoxStyle.YesNo, "Adventure")
                        If decision = 6 Then

                        Else
                            MsgBox("You don't enter.", MsgBoxStyle.Information, "Adventure")
                        End If
                    ElseIf AI = 3 Then
                        MsgBox("You think you see something move in the dark.", MsgBoxStyle.Information, "Adventure")
                    ElseIf AI = 4 Then
                        decision = MsgBox("You find money! Grab a handful of money?", MsgBoxStyle.YesNo, "Treasure")
                        If decision = 6 Then
                            sinCash += (Rnd() * 15)
                        Else

                        End If
                    ElseIf AI = 5 Then
                        decision = MsgBox("You discover an exit. Leave?", MsgBoxStyle.YesNo, "Exit")
                        If decision = 6 Then
                            exitadventure = True
                        Else

                        End If
                    ElseIf AI = 6 Then
                        MsgBox("A gust of wind pushes past you.", MsgBoxStyle.Information, "Adventure")
                    ElseIf AI = 7 Then
                        MsgBox("As you're walking by a ledge, a huge burst of wind throws you off the edge. You fall into water and swim up to a nearby ledge.", MsgBoxStyle.Information, "Adventure")
                    ElseIf AI = 8 Then
                        Dim attackedpart As Integer
                        Dim attackedpartstring As String
                        attackedpart = Int(Rnd() * 7)
                        If attackedpart = 1 Then
                            attackedpartstring = "head"
                            dblHead -= Int(Rnd() * 5)
                        ElseIf attackedpart = 2 Then
                            attackedpartstring = "torso"
                            dblTorso -= Int(Rnd() * 5)
                        ElseIf attackedpart = 3 Then
                            attackedpartstring = "right arm"
                            dblRArm -= Int(Rnd() * 5)
                        ElseIf attackedpart = 4 Then
                            attackedpartstring = "left arm"
                            dblLArm -= Int(Rnd() * 5)
                        ElseIf attackedpart = 5 Then
                            attackedpartstring = "right leg"
                            dblRLeg -= Int(Rnd() * 5)
                        ElseIf attackedpart = 6 Then
                            attackedpartstring = "left leg"
                            dblLLeg -= Int(Rnd() * 5)
                        Else
                            attackedpartstring = "clothes"
                        End If
                        MsgBox("You're attacked by something! It's hit your " & attackedpartstring & "!")
                    ElseIf AI = 9 Then
                        Dim strDepictions(5) As String
                        Dim strDepictions2(5) As String
                        Dim strDepictions3(5) As String
                        Dim randomizer As Integer
                        Dim randomizer2 As Integer
                        Dim randomizer3 As Integer

                        strDepictions(0) = "humans"
                        strDepictions(1) = "animals"
                        strDepictions(2) = "skeletons"
                        strDepictions(3) = "demons"
                        strDepictions(4) = "monsters"
                        strDepictions(5) = "a god"

                        strDepictions2(0) = "worshiping"
                        strDepictions2(1) = "killing"
                        strDepictions2(2) = "healing"
                        strDepictions2(3) = "enslaving"
                        strDepictions2(4) = "banishing"
                        strDepictions2(5) = "begging"

                        strDepictions3(0) = "humans"
                        strDepictions3(1) = "animals"
                        strDepictions3(2) = "skeletons"
                        strDepictions3(3) = "demons"
                        strDepictions3(4) = "monsters"
                        strDepictions3(5) = "a god"

                        randomizer = Int(Rnd() * 5)
                        randomizer2 = Int(Rnd() * 5)
                        randomizer3 = Int(Rnd() * 5)

                        MsgBox("You walk into a gigantic mountain hall. The construction looks extremely old, and you wonder what exactly could have built this. You walk around, eventually stumbling into a story hall. The images on the wall are faded, but from what you can make out, they depict " & strDepictions(randomizer) & " " & strDepictions2(randomizer2) & " " & strDepictions3(randomizer3), MsgBoxStyle.Information, "Adventure")
                    ElseIf AI = 10 Then
                        MsgBox("The mountains begin to shake violently!", MsgBoxStyle.Information, "Adventure")
                    End If
                Loop Until exitadventure = True
                'End Mountain Adventure
            End If
            Else

            End If

    End Sub
    'Adventure: Ship
    Sub AdventureShip()
        Dim decision As Integer
        Dim AI As Integer
        Dim exitadventure As Boolean

        'Adventure Site Definition: Ship
        If strSiteLocation = "Space Ship Wreck" Then

            'Cave Adventure
            decision = MsgBox("Enter the wreckage?", MsgBoxStyle.YesNo, "Enter")

            If decision = 6 Then
                MsgBox("You enter the wreckage. The holes in the hull lets in small amounts of sunlight, but the structure is massive.")

                'Begins the story AI for Ship
                Do
                    AI = Int(Rnd() * 10)
                    If AI = 1 Then
                        MsgBox("You try to open the airlock, but it's not budging. You search for a way past. You find a vent, and crawl into the room.", MsgBoxStyle.Information, "Adventure")
                    ElseIf AI = 2 Then
                        decision = MsgBox("An airlock is stuck open, enter it?", MsgBoxStyle.YesNo, "Adventure")
                        If decision = 6 Then

                        Else
                            MsgBox("You don't enter.", MsgBoxStyle.Information, "Adventure")
                        End If
                    ElseIf AI = 3 Then
                        MsgBox("You think you see something move in the dark.", MsgBoxStyle.Information, "Adventure")
                    ElseIf AI = 4 Then
                        decision = MsgBox("You find money! Grab a handful of money?", MsgBoxStyle.YesNo, "Treasure")
                        If decision = 6 Then
                            sinCash += (Rnd() * 50)
                        Else

                        End If
                    ElseIf AI = 5 Then
                        decision = MsgBox("You discover an exit. Leave?", MsgBoxStyle.YesNo, "Exit")
                        If decision = 6 Then
                            exitadventure = True
                        Else

                        End If
                    ElseIf AI = 6 Then
                        MsgBox("Some of the electronics are still blinking.", MsgBoxStyle.Information, "Adventure")
                    ElseIf AI = 7 Then
                        MsgBox("Everything is destroyed, but you find a few notes that date back to " & Int(Rnd() * intYear) & ". There's nothing of interest.", MsgBoxStyle.Information, "Adventure")
                    ElseIf AI = 8 Then
                        Dim attackedpart As Integer
                        Dim attackedpartstring As String
                        attackedpart = Int(Rnd() * 7)
                        If attackedpart = 1 Then
                            attackedpartstring = "head"
                            dblHead -= Int(Rnd() * 5)
                        ElseIf attackedpart = 2 Then
                            attackedpartstring = "torso"
                            dblTorso -= Int(Rnd() * 5)
                        ElseIf attackedpart = 3 Then
                            attackedpartstring = "right arm"
                            dblRArm -= Int(Rnd() * 5)
                        ElseIf attackedpart = 4 Then
                            attackedpartstring = "left arm"
                            dblLArm -= Int(Rnd() * 5)
                        ElseIf attackedpart = 5 Then
                            attackedpartstring = "right leg"
                            dblRLeg -= Int(Rnd() * 5)
                        ElseIf attackedpart = 6 Then
                            attackedpartstring = "left leg"
                            dblLLeg -= Int(Rnd() * 5)
                        Else
                            attackedpartstring = "clothes"
                        End If
                        MsgBox("You're attacked by a security drone! It's hit your " & attackedpartstring & "!")
                    ElseIf AI = 9 Then
                        Dim crashyear As Integer
                        Dim crewstatus As Integer
                        Dim crewstatusstring As String

                        crashyear = Int(Rnd() * intYear)
                        crewstatus = Int(Rnd() * 4)
                        crewstatusstring = " performing a mission"

                        If crewstatus = 1 Then
                            crewstatusstring = " crash landing"
                        ElseIf crewstatus = 2 Then
                            crewstatusstring = " landing"
                        ElseIf crewstatus = 3 Then
                            crewstatusstring = " being stranded"
                        ElseIf crewstatus = 4 Then
                            crewstatusstring = "'s crew was kidnapped, the kidnappers left the ship"
                        End If

                        MsgBox("A computer is still operational. it's got information from the year " & crashyear & ". You find an old log, which tells the tale of a ship's crew" & crewstatusstring & " here.", MsgBoxStyle.Information, "Adventure")
                    ElseIf AI = 10 Then
                        MsgBox("The ship creaks!", MsgBoxStyle.Information, "Adventure")
                    End If
                Loop Until exitadventure = True
                'End Ship Adventure
            End If
            Else

            End If

    End Sub
    'Adventure: Forest
    Sub AdventureForest()
        Dim decision As Integer
        Dim AI As Integer
        Dim exitadventure As Boolean

        'Adventure Site Definition: Forest
        If strSiteLocation = "Forest" Then

            'Forest Adventure
            decision = MsgBox("Enter the forest?", MsgBoxStyle.YesNo, "Enter")

            If decision = 6 Then
                MsgBox("You enter the forest. The tall trees allow only small amounts of sunlight to pass through.")

                'Begins the story AI for Cave
                Do
                    AI = Int(Rnd() * 10)
                    If AI = 1 Then
                        MsgBox("You get lost.", MsgBoxStyle.Information, "Adventure")
                    ElseIf AI = 2 Then
                        decision = MsgBox("You discover a trail going down, follow it?", MsgBoxStyle.YesNo, "Adventure")
                        If decision = 6 Then

                        Else
                            MsgBox("You decide not to follow the trail.", MsgBoxStyle.Information, "Adventure")
                        End If
                    ElseIf AI = 3 Then
                        MsgBox("You think you see something move in the bushes.", MsgBoxStyle.Information, "Adventure")
                    ElseIf AI = 4 Then
                        decision = MsgBox("You found money, grab it?", MsgBoxStyle.YesNo, "Treasure")
                        If decision = 6 Then
                            sinCash += (Rnd() * 5)
                        Else

                        End If
                    ElseIf AI = 5 Then
                        decision = MsgBox("You find the edge of the forest. Leave?", MsgBoxStyle.YesNo, "Exit")
                        If decision = 6 Then
                            exitadventure = True
                        Else

                        End If
                    ElseIf AI = 6 Then
                        MsgBox("The only sound you can hear is the trees swaying as the wind pushes them.", MsgBoxStyle.Information, "Adventure")
                    ElseIf AI = 7 Then
                        MsgBox("You feel like you're being watched.", MsgBoxStyle.Information, "Adventure")
                    ElseIf AI = 8 Then
                        Dim attackedpart As Integer
                        Dim attackedpartstring As String
                        attackedpart = Int(Rnd() * 7)
                        If attackedpart = 1 Then
                            attackedpartstring = "head"
                            dblHead -= Int(Rnd() * 5)
                        ElseIf attackedpart = 2 Then
                            attackedpartstring = "torso"
                            dblTorso -= Int(Rnd() * 5)
                        ElseIf attackedpart = 3 Then
                            attackedpartstring = "right arm"
                            dblRArm -= Int(Rnd() * 5)
                        ElseIf attackedpart = 4 Then
                            attackedpartstring = "left arm"
                            dblLArm -= Int(Rnd() * 5)
                        ElseIf attackedpart = 5 Then
                            attackedpartstring = "right leg"
                            dblRLeg -= Int(Rnd() * 5)
                        ElseIf attackedpart = 6 Then
                            attackedpartstring = "left leg"
                            dblLLeg -= Int(Rnd() * 5)
                        Else
                            attackedpartstring = "clothes"
                        End If
                        MsgBox("You're attacked by something! It's hit your " & attackedpartstring & "!")
                    ElseIf AI = 9 Then
                        MsgBox("You hear animal calls.", MsgBoxStyle.Information, "Adventure")
                    ElseIf AI = 10 Then
                        MsgBox("Something brushes in the bushes!", MsgBoxStyle.Information, "Adventure")
                    End If
                Loop Until exitadventure = True
                'End Forest Adventure
            End If
            Else

            End If

    End Sub
End Module
