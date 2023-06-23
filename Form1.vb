Public Class Form1

    Public Sub btnValue_Click(sender As Object, e As EventArgs) Handles btnValue.Click
        Main.MoveToValueCalc(Me)
    End Sub

    Private Sub btnRatio_Click(sender As Object, e As EventArgs) Handles btnRatio.Click
        Main.MoveToRatioCalc(Me)
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Main.Quitter(Me)
    End Sub
End Class
