Module PlayerVars
    'Alive?
    Public bolDead As Boolean
    'Asphyxiation
    Public dblAirAmount As Double
    Public bolSuffocation As Boolean
    'Planet Variables
    Public strSiteLocation As String
    Public bolPlayerOnPlanet As Boolean
    'Suit Variables
    Public dblOxygenSupply As Double
    Public bolSuitActive As Boolean
    'Body Variables Max
    Public Const dblMaxTorso As Double = 20
    Public Const dblMaxRLeg As Double = 15
    Public Const dblMaxRArm As Double = 15
    Public Const dblMaxLLeg As Double = 15
    Public Const dblMaxLArm As Double = 15
    Public Const dblMaxHead As Double = 20
    'Body Defaults
    Public dblTorso As Double = dblMaxTorso
    Public dblRLeg As Double = dblMaxRLeg
    Public dblRArm As Double = dblMaxRArm
    Public dblLLeg As Double = dblMaxLLeg
    Public dblLArm As Double = dblMaxLArm
    Public dblHead As Double = dblMaxHead

    Public dblTotal As Double = 100
    'Body Healing Function
    Sub healPlayer()
        dblTorso = dblMaxTorso
        dblRLeg = dblMaxRLeg
        dblRArm = dblMaxRArm
        dblLLeg = dblMaxLLeg
        dblLArm = dblMaxLArm
        dblHead = dblMaxHead
    End Sub
    'Money
    Public sinCash As Single
    Public sinBankCash As Single
    Public intBankPin As Integer
End Module
