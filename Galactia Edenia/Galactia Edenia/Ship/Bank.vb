Module Bank
    Public sinInterestRate As Single

    Sub InterestChanger()
        Static Dim intInterestMover As Single

        If intDay = 31 Then
            Randomize()
            intInterestMover = Int(Rnd() * 10)
        End If

        If intInterestMover >= 5 Then
            sinInterestRate += 0.001
        Else
            sinInterestRate -= 0.001
        End If
    End Sub

    Sub InterestGiver()
        Dim cashtogive As Single

        If intMonth = 12 And intDay = 30 Then
            cashtogive = sinBankCash * sinInterestRate
            sinBankCash += cashtogive
        End If
    End Sub
End Module
