Module PlanetVars
    'Planet Name
    Public strPlanetName As String
    'Handles basic gases
    Public dblPlanetOxygen As Double
    Public dblPlanetNitrogen As Double
    Public dblPlanetToxic As Double
    'Pressure
    Public dblPlanetPressure As Double
    'Handles planet resources
    Public dblPlanetWater As Double
    Public dblPlanetPlant As Double
    'Handles civilizations - WIP
    Public strPlanetSpecies As String
    Public lonPopulation(1) As Long
    Public intSites As Integer

    Public strSpecies(2) As String
    Public strSpeciesDescription(1) As String
    Sub DebugSpawnSpecies()
        strSpecies(0) = "Human"
        strSpeciesDescription(0) = "Humans. Bipedal creatures capable of achieving great progress."

        strSpecies(1) = "Lizard"
        strSpeciesDescription(1) = "Lizards. Discovered in the year 2324, lizards and humans quickly formed a powerful alliance."

        strSpecies(2) = "TestCiv"
    End Sub
    'World Generation
    Public bolHumans As Boolean
    Public bolLizards As Boolean

    Sub GeneratePlanet()
        'Name the planet
        strPlanetName = "X - " & Int(Rnd() * 1000000)
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
        'Planet
        dblPlanetOxygen = Int(Rnd() * 100)
        dblPlanetNitrogen = Int(Rnd() * 100)
        dblPlanetToxic = Int(Rnd() * 100)
        dblPlanetWater = Int(Rnd() * 100)
        dblPlanetPlant = Int(Rnd() * 100)
        dblPlanetPressure = dblPlanetOxygen + dblPlanetNitrogen + dblPlanetToxic
        'Planet Civilization
        If dblPlanetOxygen >= 19.5 And dblPlanetToxic < 5 And dblPlanetPressure >= 40 And dblPlanetWater >= 30 And dblPlanetPlant >= 25 Then
            bolHumans = True
            bolLizards = True
        Else
            bolHumans = False
            bolLizards = False
        End If

        If bolHumans = True Then
            lonPopulation(0) = Int(Rnd() * 9000000)
        End If
        If bolLizards = True Then
            lonPopulation(1) = Int(Rnd() * 9000000)
        End If
    End Sub
End Module
