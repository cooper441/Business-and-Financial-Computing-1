Imports System.IO
Imports ClosedXML.Excel



Public Class Main

    Public Shared interestTable As New DataTable
    Public Shared ratioTableCurrent As New DataTable
    Public Shared ratioTableDebt As New DataTable
    Public Shared ratioTableGross As New DataTable
    Public Shared ratioTableCap As New DataTable

    'Creates value datatable
    Public Shared Sub DtValueCreate()
        With interestTable
            .Columns.Add("Entry #", System.Type.GetType("System.String"))
            .Columns.Add("Number of Years", System.Type.GetType("System.String"))
            .Columns.Add("Amount", System.Type.GetType("System.String"))
            .Columns.Add("Annual Interest", System.Type.GetType("System.String"))
            .Columns.Add("P or F", System.Type.GetType("System.String"))
            .Columns.Add("Value", System.Type.GetType("System.String"))
        End With
        Form2.grid1.DataSource = interestTable
    End Sub

    'Creates ratio datatable ---- put into movement buttons 
    Public Shared Sub DtRatioCreate()
        With ratioTableCurrent
            .Columns.Add("Entry #", System.Type.GetType("System.String"))
            .Columns.Add("Type", System.Type.GetType("System.String"))
            .Columns.Add("Total Current Assets", System.Type.GetType("System.String"))
            .Columns.Add("Total Current Liabilities", System.Type.GetType("System.String"))
            .Columns.Add("Result", System.Type.GetType("System.String"))
        End With
        Form3.grid1.DataSource = ratioTableCurrent

        With ratioTableDebt
            .Columns.Add("Entry #", System.Type.GetType("System.String"))
            .Columns.Add("Type", System.Type.GetType("System.String"))
            .Columns.Add("Total Debt", System.Type.GetType("System.String"))
            .Columns.Add("Total Equity", System.Type.GetType("System.String"))
            .Columns.Add("Result", System.Type.GetType("System.String"))
        End With
        Form3.grid2.DataSource = ratioTableDebt


        With ratioTableGross
            .Columns.Add("Entry #", System.Type.GetType("System.String"))
            .Columns.Add("Type", System.Type.GetType("System.String"))
            .Columns.Add("Gross Profit", System.Type.GetType("System.String"))
            .Columns.Add("Revenue", System.Type.GetType("System.String"))
            .Columns.Add("Result", System.Type.GetType("System.String"))
        End With
        Form3.grid3.DataSource = ratioTableGross


        With ratioTableCap
            .Columns.Add("Entry #", System.Type.GetType("System.String"))
            .Columns.Add("Type", System.Type.GetType("System.String"))
            .Columns.Add("Current Assets", System.Type.GetType("System.String"))
            .Columns.Add("Current Liabilities", System.Type.GetType("System.String"))
            .Columns.Add("Result", System.Type.GetType("System.String"))
        End With
        Form3.grid4.DataSource = ratioTableCap

        Form3.grid1.Hide()
        Form3.grid2.Hide()
        Form3.grid3.Hide()
        Form3.grid4.Hide()
    End Sub

    'Confirms if the user truly wishes to move page, warms of data loss if move proceeds
    Public Shared Function CheckMove()
        Dim answer As Int32
        answer = MsgBox("Are you sure you want to leave?" & vbCrLf & "All unexported data will be lost", vbCritical + MsgBoxStyle.YesNo + vbDefaultButton2, "Leaving page!")
        If answer = vbYes Then
            Return True
        Else
            Return False
        End If
    End Function

    'Table wipe when calc pages
    Public Shared Sub TableWipe(grid, table)
        Dim i As Int16
        i = table.Columns.Count - 1
        While i >= 0
            table.Columns.RemoveAt(i)
            i -= 1
        End While
        table = Nothing
        grid.DataSource = Nothing
        grid.Rows.Clear()
        grid.Columns.Clear()
        grid.Refresh()
    End Sub
    ' Sub for  quit buttons 
    Public Shared Sub Quitter(form)
        If Not Main.CheckMove() Then
            Exit Sub
        End If
        form.Close()
        Application.Exit()
    End Sub

    ' Sub for movement to Ratio Calc
    Public Shared Sub MoveToRatioCalc(form)
        If form Is Form1 Then
            TableWipe(Form2.grid1, interestTable)
            DtRatioCreate()
            form.Hide()
            Form3.Show()
        ElseIf Not Main.CheckMove() Then
            Exit Sub
        Else
            TableWipe(Form2.grid1, interestTable)
            DtRatioCreate()
            form.Hide()
            Form3.Show()
        End If

    End Sub


    ' Sub for movement to Value Calc
    Public Shared Sub MoveToValueCalc(form)
        If form Is Form1 Then
            TableWipe(Form3.grid1, ratioTableCurrent)
            TableWipe(Form3.grid2, ratioTableDebt)
            TableWipe(Form3.grid3, ratioTableGross)
            DtValueCreate()
            form.Hide()
            Form2.Show()
        ElseIf Not Main.CheckMove() Then
            Exit Sub
        Else
            TableWipe(Form3.grid1, ratioTableCurrent)
            TableWipe(Form3.grid2, ratioTableDebt)
            TableWipe(Form3.grid3, ratioTableGross)
            DtValueCreate()
            form.Hide()
            Form2.Show()
        End If
    End Sub

    ' Sub for button when returning to main menu
    Public Shared Sub Returner(form)
        If Not CheckMove() Then
            Exit Sub
        End If
        TableWipe(Form2.grid1, interestTable)
        TableWipe(Form3.grid1, ratioTableCurrent)
        TableWipe(Form3.grid2, ratioTableDebt)
        TableWipe(Form3.grid3, ratioTableGross)
        form.Close()
        Form1.Show()
    End Sub

    'Function to export data to an Excel fileformat.
    Public Shared Sub ExportXLS(inputDataTable, type)
        Dim fileCounter As Int32 = 1
        Dim defaultName As String = ""
        Dim inputPath As String = ""
        Dim checkNum As Int16


        If inputDataTable.rows.Count <= 0 Then
            MsgBox("Nothing to export", vbExclamation, "Empty Table")
            Exit Sub
        End If

        If Form2.btnToggle Then
            checkNum = 0
        End If

        If Not Form2.btnToggle Then
            checkNum = 1
        End If

        If Form3.ratioCurrent Then
            checkNum = 2
        End If
        If Form3.ratioDebt Then
            checkNum = 3
        End If
        If Form3.ratioProfit Then
            checkNum = 4
        End If
        If Form3.ratioCap Then
            checkNum = 5
        End If

        Select Case checkNum
            Case 0
                defaultName = "FutureCalc"
                inputPath = "C:\FinanceCalc\TimeValue\"
            Case 1
                defaultName = "PresetCalc"
                inputPath = "C:\FinanceCalc\TimeValue\"
            Case 2
                defaultName = "CurrentRatioCalc"
                inputPath = "C:\FinanceCalc\RatioCalc\"
            Case 3
                defaultName = "DebtCalc"
                inputPath = "C:\FinanceCalc\RatioCalc\"
            Case 4
                defaultName = "GrossMarginCalc"
                inputPath = "C:\FinanceCalc\RatioCalc\"
            Case 5
                defaultName = "WorkingCap"
                inputPath = "C:\FinanceCalc\RatioCalc\"

        End Select

        ' Takes input data table and assings to dt
        Dim dt As New DataTable()
        dt = inputDataTable

        ' Asks user from the desired filename, if left blank will create default name of "calcuation" plus the number (to be incremented to prevent overwrite)
        Dim fileName As String = InputBox("Enter filename or leave blank")
        fileName.Trim()
        If fileName = "" Then
            fileName = defaultName & fileCounter
            fileCounter += 1
        End If

        ' Creates (if required) a folder in C:\FinanceCalc\ for file to save to. 
        Dim folderPath As String = inputPath
        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
        End If


        If type Is "txt" Then
            ' Creates and saves txt file
            Dim txtfileName As String = folderPath + fileName + ".txt"
            Using sw As New StreamWriter(txtfileName, False)
                For Each drow As DataRow In inputDataTable.Rows
                    Dim lineoftext = String.Join(", ", drow.ItemArray.Select(Function(s) s.ToString).ToArray)
                    sw.WriteLine(lineoftext)
                Next
            End Using
            MsgBox("File Saved Successfully in " & folderPath, vbInformation, "Sucessful")
        End If

        If type Is "XLS" Then
            ' Creates a new XL workbook using CloseXML library, add dt to it and saves it at previously determined dir and filename. Alerts user of sucess and file location
            Using wb As New XLWorkbook()
                wb.Worksheets.Add(dt, "Sheet")
                wb.SaveAs(folderPath & Convert.ToString(fileName & ".xlsx"))
            End Using
            MsgBox("File Saved Successfully in " & folderPath, vbInformation, "Sucessful")
        End If
    End Sub
End Class
