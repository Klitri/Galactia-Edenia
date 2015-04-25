Public Class PlanetModder
    Private strPath As String
    Private strName As String
    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        MsgBox("Oxygen is air, and is important for whether or not the player can breathe on this planet.")
        MsgBox("Nitrogen is useless for any player purposes, but is used to fill the atmosphere with pressure.")
        MsgBox("Toxin harms players over time, you shouldn't put any in if you're making an earthlike planet.")
        MsgBox("Water / H2O is the concentration (%) of water on the planet. For reference, earth is 70% water.")
        MsgBox("Plant / Biodiversity is also in %. There's no point in explaining this, but the higher the %, the more animals and plants are on the planet.")
        MsgBox("Remember that the maximum Water / Plant % is 100, and the minimum is 0.")
        MsgBox("Finally, name your planet and set the file path to anywhere you want. Desktop is recommended.")
        MsgBox("Hit create, when you're done making lots of planets, you can either send them to me or use them when the game is done.")
    End Sub

    Private Sub txtOxygen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOxygen.TextChanged
        lblPressure.Text = Conversion.Val(txtOxygen.Text) + Conversion.Val(txtNitrogen.Text) + Conversion.Val(txtToxin.Text)
    End Sub

    Private Sub txtNitrogen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNitrogen.TextChanged
        lblPressure.Text = Conversion.Val(txtOxygen.Text) + Conversion.Val(txtNitrogen.Text) + Conversion.Val(txtToxin.Text)
    End Sub

    Private Sub txtToxin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtToxin.TextChanged
        lblPressure.Text = Conversion.Val(txtOxygen.Text) + Conversion.Val(txtNitrogen.Text) + Conversion.Val(txtToxin.Text)
    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        strName = InputBox("Name the planet!", "Name")
        strPath = txtPath.Text
        My.Computer.FileSystem.WriteAllText(strPath & "/" & strName, txtOxygen.Text & "." & txtNitrogen.Text & "." & txtToxin.Text & "." & txtWater.Text & "." & txtPlant.Text, True)
    End Sub
End Class