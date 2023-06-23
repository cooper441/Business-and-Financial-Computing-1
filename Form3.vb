Public Class Form3

    Public ratioCurrent As Boolean = False
    Public ratioDebt As Boolean = False
    Public ratioProfit As Boolean = False
    Public ratioCap As Boolean = False
    Dim input1 As Decimal
    Dim input2 As Decimal
    Dim validateEmpty As Boolean
    Dim validateInput1 As Boolean
    Dim validateInput2 As Boolean
    Dim entryNumCurrent As Integer = 1
    Dim entryNumDebt As Integer = 1
    Dim entryNumGross As Integer = 1
    Dim entryNumCap As Integer = 1
    Dim displayInput1 As String
    Dim displayInput2 As String
    Dim toExport As DataTable

    Private Sub CleanInputs()
        boxInput1.Text = ""
        boxInput2.Text = ""
        input1 = Nothing
        input2 = Nothing

    End Sub

    Private Function CalculatorRatio(input1, input2)
        Dim calcvalue As Decimal
        Dim toReturn As String


        If ratioCurrent Then
            calcvalue = input1 / input2
        ElseIf ratioDebt Then
            calcvalue = input1 / input2
        ElseIf ratioProfit Then
            calcvalue = input1 / input2
        ElseIf ratioCap Then
            calcvalue = input1 - input2
        End If

        If ratioCap Then
            toReturn = FormatCurrency(calcvalue)
        Else
            toReturn = Math.Round(calcvalue, 2)
        End If

        Return toReturn
    End Function

    Private Sub btnExportTxt_Click(sender As Object, e As EventArgs) Handles btnExportTxt.Click


        If ratioCurrent Then
            toExport = Main.ratioTableCurrent
        ElseIf ratioDebt Then
            toExport = Main.ratioTableDebt
        ElseIf ratioProfit Then
            toExport = Main.ratioTableGross
        End If

        Main.ExportXLS(toExport, "txt")
    End Sub

    Private Sub btnExportXLS_Click(sender As Object, e As EventArgs) Handles btnExportXLS.Click

        If ratioCurrent Then
            toExport = Main.ratioTableCurrent
        ElseIf ratioDebt Then
            toExport = Main.ratioTableDebt
        ElseIf ratioProfit Then
            toExport = Main.ratioTableGross
        ElseIf ratioCap Then
            toExport = Main.ratioTableCap
        End If

        Main.ExportXLS(toExport, "XLS")
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Main.Quitter(Me)
    End Sub

    Private Sub btnValue_Click(sender As Object, e As EventArgs) Handles btnVaule.Click
        Main.MoveToValueCalc(Me)
    End Sub

    Private Sub btnRtn_Click(sender As Object, e As EventArgs) Handles btnRtn.Click
        Main.Returner(Me)
    End Sub

    Private Sub cmbSelector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelector.SelectedIndexChanged
        picArrow.Visible = False
        If cmbSelector.SelectedIndex = 0 Then
            ratioCurrent = True
            ratioDebt = False
            ratioProfit = False
            lblIndicator.Text = "Current Ratio"
            lblInput1.Text = "Total current assets"
            lblInput2.Text = "Total current liabilities"
            grid1.Show()
            grid2.Hide()
            grid3.Hide()
            grid4.Hide()

        ElseIf cmbSelector.SelectedIndex = 1 Then
            ratioCurrent = False
            ratioDebt = True
            ratioProfit = False
            lblIndicator.Text = "Debt To Equity"
            lblInput1.Text = "Total debt"
            lblInput2.Text = "Total equity"
            grid1.Hide()
            grid2.Show()
            grid3.Hide()
            grid4.Hide()


        ElseIf cmbSelector.SelectedIndex = 2 Then
            ratioCurrent = False
            ratioDebt = False
            ratioProfit = True
            lblIndicator.Text = "Gross Profit Margin"
            lblInput1.Text = "Gross Profit"
            lblInput2.Text = "Revenue"
            grid1.Hide()
            grid2.Hide()
            grid3.Show()
            grid4.Hide()

        ElseIf cmbSelector.SelectedIndex = 3 Then
            ratioCurrent = False
            ratioDebt = False
            ratioProfit = False
            ratioCap = True
            lblIndicator.Text = "Working Capital"
            lblInput1.Text = "Current Assets"
            lblInput2.Text = "Current Liabilities"
            grid1.Hide()
            grid2.Hide()
            grid3.Hide()
            grid4.Show()

        End If

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        If String.IsNullOrEmpty(boxInput1.Text) Or String.IsNullOrEmpty(boxInput2.Text) Then
            MsgBox("All fields must be complete to make a calculation", vbExclamation, "Fields not full")
            Exit Sub
        Else
            validateEmpty = True
        End If

        If validateEmpty Then
            If Decimal.TryParse(boxInput1.Text, input1) Then
                validateInput1 = True
                displayInput1 = FormatCurrency(input1)

            Else
                MsgBox("The amount must a decimal number." & vbCrLf & vbCrLf & "Example: 1546 or 124.214", vbExclamation, "Entered incorrectly")
                Exit Sub
            End If



            If Decimal.TryParse(boxInput2.Text, input2) Then
                validateInput2 = True
                displayInput2 = FormatCurrency(input2)
            Else
                MsgBox("The amount must a decimal number." & vbCrLf & vbCrLf & "Example: 1546 or 124.214")
                Exit Sub
            End If

        End If


        If validateEmpty And validateInput1 And validateInput2 Then

            If ratioCurrent Then

                Dim newrow As DataRow = Main.ratioTableCurrent.NewRow
                newrow("Entry #") = entryNumCurrent
                newrow("Type") = "Current Ratio"
                newrow("Total Current Assets") = displayInput1
                newrow("Total Current Liabilities") = displayInput2
                newrow("Result") = CalculatorRatio(input1, input2)

                entryNumCurrent += 1
                Main.ratioTableCurrent.Rows.Add(newrow)
                CleanInputs()
                newrow = Nothing

            ElseIf ratioDebt Then

                Dim newrow As DataRow = Main.ratioTableDebt.NewRow
                newrow("Entry #") = entryNumDebt
                newrow("Type") = "Debt To Equity"
                newrow("Total Debt") = displayInput1
                newrow("Total Equity") = displayInput2
                newrow("Result") = CalculatorRatio(input1, input2)

                entryNumDebt += 1
                Main.ratioTableDebt.Rows.Add(newrow)
                CleanInputs()
                newrow = Nothing

            ElseIf ratioProfit Then

                Dim newrow As DataRow = Main.ratioTableGross.NewRow
                newrow("Entry #") = entryNumGross
                newrow("Type") = "Gross Profit Margin"
                newrow("Gross Profit") = displayInput1
                newrow("Revenue") = displayInput2
                newrow("Result") = CalculatorRatio(input1, input2)

                entryNumDebt += 1
                Main.ratioTableGross.Rows.Add(newrow)
                CleanInputs()
                newrow = Nothing

            ElseIf ratioCap Then

                Dim newrow As DataRow = Main.ratioTableCap.NewRow
                newrow("Entry #") = entryNumGross
                newrow("Type") = "Working Capital Ratio"
                newrow("Current Assets") = displayInput1
                newrow("Current Liabilities") = displayInput2
                newrow("Result") = CalculatorRatio(input1, input2)

                entryNumCap += 1
                Main.ratioTableCap.Rows.Add(newrow)
                CleanInputs()
                newrow = Nothing
            End If
        Else
            Exit Sub
        End If




    End Sub

    Private Sub btnWipe_Click(sender As Object, e As EventArgs) Handles btnWipe.Click
        CleanInputs()
    End Sub


End Class