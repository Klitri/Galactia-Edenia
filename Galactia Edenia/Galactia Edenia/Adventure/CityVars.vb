Module CityVars
    'City
    Sub CityPlay()
        Dim playerleft As Boolean
        Dim Choice(4) As String
        Dim playerchoice As String
        Dim shopchoice As String
        Dim decision As String

        For scan = 0 To (lonPopulation(0) / 1000000) - 1
            If strSiteLocation = "City " & scan Then

                MsgBox("You enter the city. To navigate, type your choices. KEYWORDS: Help - Opens the keyword display")
                Do
                    playerchoice = InputBox("What do you want to do? Type 'Help' for keywords.", "City View")

                    If playerchoice = "Help" Then
                        MsgBox("Keywords will be displayed.")
                        MsgBox("Help - Opens the help prompt.")
                        MsgBox("Shop - Opens the shop.")
                        MsgBox("Talk - Let's you speak to people on the street.")
                        MsgBox("Explore - Explores the city.")
                        MsgBox("Leave - Exit the city.")
                    End If

                    If playerchoice = "Shop" Then
                        MsgBox("Welcome to the shop, what do you want to buy?")
                        shopchoice = InputBox("To buy health, type '+'.")

                        If shopchoice = "+" Then
                            decision = MsgBox("That'll cost $10", MsgBoxStyle.YesNo, "Health")

                            If sinCash >= 10 And decision = 6 Then
                                healPlayer()
                                sinCash -= 10
                            End If

                        End If
                        MsgBox("Thanks for coming!")
                    End If

                    If playerchoice = "Talk" Then
                        MsgBox("You wander around and bump into a person.")
                        MsgBox("You: Hello!")
                        MsgBox("Them: Hello.")
                    End If

                    If playerchoice = "Explore" Then
                        MsgBox("You admire the city.")
                    End If

                    If playerchoice = "Leave" Then
                        MsgBox("You finalize your departure and leave the city.")
                        playerleft = True
                    End If

                Loop Until playerleft = True

                playerleft = False
            End If
        Next

    End Sub
End Module
