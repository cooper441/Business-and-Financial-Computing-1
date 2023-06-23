


Public Class Form2

    Dim inputNumOfYears As Decimal
    Dim inputAmount As Decimal
    Dim inputAnnualInterest As Decimal
    Dim validateEmpty As Boolean
    Dim validateNumOfYears As Boolean
    Dim validateAmount As Boolean
    Dim validateInterest As Boolean
    Dim entryNum As Integer = 1
    Public btnToggle As Boolean = True
    Dim displayAmount As String
    Dim displayInterest As String
    Dim pReturn As String = "P"
    Dim fReturn As String = "F"
    Dim toExport As DataTable

    'Function to calculate time money value 
    Private Function CalculatorValue(years, amount, interest)
        Dim calcvalue As Decimal
        Dim toReturn As String
        If btnToggle Then
            calcvalue = amount * ((1 + (interest)) ^ years)
        Else
            calcvalue = amount / ((1 + (interest)) ^ years)
        End If
        toReturn = FormatCurrency(calcvalue)
        Return toReturn
    End Function

    'Wipes input fields
    Private Sub CleanInputs()
        boxAmount.Text = ""
        boxInterest.Text = ""
        boxNumOfYear.Text = ""
        inputNumOfYears = Nothing
        inputAmount = Nothing
        inputAnnualInterest = Nothing
        displayAmount = ""
        displayInterest = ""

    End Sub

    Public Function CheckPorF()
        If btnToggle Then
            Return fReturn
        Else
            Return pReturn
        End If
    End Function


    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        If String.IsNullOrEmpty(boxAmount.Text) Or String.IsNullOrEmpty(boxInterest.Text) Or String.IsNullOrEmpty(boxNumOfYear.Text) Then
            MsgBox("All fields must be complete to make a calculation", vbExclamation, "Fields not full")
            Exit Sub
        Else
            validateEmpty = True
        End If

        If validateEmpty Then
            If Decimal.TryParse(boxNumOfYear.Text, inputNumOfYears) Then
                validateNumOfYears = True
            Else
                MsgBox("The number of years must a decimal number" & vbCrLf & vbCrLf & "Example: 2 or 0.5", vbExclamation, "Entered incorrectly")
                Exit Sub
            End If

            If Decimal.TryParse(boxAmount.Text, inputAmount) Then
                displayAmount = FormatCurrency(inputAmount)
                validateAmount = True
            Else
                MsgBox("The amount must a decimal number." & vbCrLf & vbCrLf & "Example: 1546 or 124.214", vbExclamation, "Entered incorrectly")
                Exit Sub
            End If

            If Decimal.TryParse(boxInterest.Text, inputAnnualInterest) Then
                inputAnnualInterest /= 100
                displayInterest = FormatPercent(inputAnnualInterest)
                validateInterest = True
            Else
                MsgBox("The interest must a decimal number, with no %" & vbCrLf & vbCrLf & "Example: 1 or 0.5", vbExclamation, "Entered incorrectly")
                Exit Sub
            End If
        End If



        If validateEmpty And validateNumOfYears And validateAmount And validateInterest Then

            Dim newrow As DataRow = Main.interestTable.NewRow
            newrow("Entry #") = entryNum
            newrow("Number of Years") = inputNumOfYears
            newrow("Amount") = displayAmount
            newrow("Annual Interest") = displayInterest
            newrow("P or F") = CheckPorF()
            newrow("Value") = CalculatorValue(inputNumOfYears, inputAmount, inputAnnualInterest)
            entryNum += 1
            Main.interestTable.Rows.Add(newrow)
            CleanInputs()
            newrow = Nothing

        Else
            Exit Sub

        End If

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Main.Quitter(Me)
    End Sub

    Private Sub btnRtn_Click(sender As Object, e As EventArgs) Handles btnRtn.Click
        Main.Returner(Me)
    End Sub

    Private Sub btnWipe_Click(sender As Object, e As EventArgs) Handles btnWipe.Click
        CleanInputs()
    End Sub
    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click

        If btnToggle Then
            lblIndicator.Text = "Present"
            btnChange.Text = "Change to future"
            lblAmount.Text = "Enter the future value"
            btnToggle = False

        ElseIf Not btnToggle Then
            lblIndicator.Text = "Future"
            btnChange.Text = "Change to Present"
            lblAmount.Text = "Enter the current amount"
            btnToggle = True
        End If

    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExportTxt.Click
        toExport = Main.interestTable
        Main.ExportXLS(toExport, "txt")
    End Sub
    Private Sub btnExportXLS_Click(sender As Object, e As EventArgs) Handles btnExportXLS.Click
        toExport = Main.interestTable
        Main.ExportXLS(toExport, "XLS")
    End Sub


    Private Sub btnRatio_Click(sender As Object, e As EventArgs) Handles btnRatio.Click
        Main.MovetoRatioCalc(Me)
    End Sub


End Class