<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.grid1 = New System.Windows.Forms.DataGridView()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.boxNumOfYear = New System.Windows.Forms.TextBox()
        Me.boxAmount = New System.Windows.Forms.TextBox()
        Me.boxInterest = New System.Windows.Forms.TextBox()
        Me.lblYears = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblInterest = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnRtn = New System.Windows.Forms.Button()
        Me.btnRatio = New System.Windows.Forms.Button()
        Me.btnExportTxt = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnWipe = New System.Windows.Forms.Button()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.lblIndicator = New System.Windows.Forms.Label()
        Me.btnExportXLS = New System.Windows.Forms.Button()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid1
        '
        Me.grid1.AllowUserToAddRows = False
        Me.grid1.AllowUserToDeleteRows = False
        Me.grid1.AllowUserToResizeColumns = False
        Me.grid1.AllowUserToResizeRows = False
        Me.grid1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.grid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid1.Location = New System.Drawing.Point(85, 170)
        Me.grid1.Name = "grid1"
        Me.grid1.ReadOnly = True
        Me.grid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.grid1.RowTemplate.Height = 25
        Me.grid1.Size = New System.Drawing.Size(600, 350)
        Me.grid1.TabIndex = 0
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(529, 139)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 25)
        Me.btnCalc.TabIndex = 1
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'boxNumOfYear
        '
        Me.boxNumOfYear.Location = New System.Drawing.Point(123, 141)
        Me.boxNumOfYear.Name = "boxNumOfYear"
        Me.boxNumOfYear.Size = New System.Drawing.Size(100, 23)
        Me.boxNumOfYear.TabIndex = 4
        '
        'boxAmount
        '
        Me.boxAmount.Location = New System.Drawing.Point(263, 141)
        Me.boxAmount.Name = "boxAmount"
        Me.boxAmount.Size = New System.Drawing.Size(100, 23)
        Me.boxAmount.TabIndex = 5
        '
        'boxInterest
        '
        Me.boxInterest.Location = New System.Drawing.Point(410, 141)
        Me.boxInterest.Name = "boxInterest"
        Me.boxInterest.Size = New System.Drawing.Size(100, 23)
        Me.boxInterest.TabIndex = 6
        '
        'lblYears
        '
        Me.lblYears.AutoSize = True
        Me.lblYears.Location = New System.Drawing.Point(114, 123)
        Me.lblYears.Name = "lblYears"
        Me.lblYears.Size = New System.Drawing.Size(115, 15)
        Me.lblYears.TabIndex = 7
        Me.lblYears.Text = "Enter period of years"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(240, 123)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(140, 15)
        Me.lblAmount.TabIndex = 8
        Me.lblAmount.Text = "Enter the current amount"
        '
        'lblInterest
        '
        Me.lblInterest.AutoSize = True
        Me.lblInterest.Location = New System.Drawing.Point(386, 124)
        Me.lblInterest.Name = "lblInterest"
        Me.lblInterest.Size = New System.Drawing.Size(135, 15)
        Me.lblInterest.TabIndex = 9
        Me.lblInterest.Text = "Enter the annual interest"
        '
        'btnRtn
        '
        Me.btnRtn.Location = New System.Drawing.Point(85, 524)
        Me.btnRtn.Name = "btnRtn"
        Me.btnRtn.Size = New System.Drawing.Size(75, 25)
        Me.btnRtn.TabIndex = 10
        Me.btnRtn.Text = "Return"
        Me.btnRtn.UseVisualStyleBackColor = True
        '
        'btnRatio
        '
        Me.btnRatio.Location = New System.Drawing.Point(166, 524)
        Me.btnRatio.Name = "btnRatio"
        Me.btnRatio.Size = New System.Drawing.Size(120, 25)
        Me.btnRatio.TabIndex = 11
        Me.btnRatio.Text = "Ratio Calculator "
        Me.btnRatio.UseVisualStyleBackColor = True
        '
        'btnExportTxt
        '
        Me.btnExportTxt.Location = New System.Drawing.Point(424, 526)
        Me.btnExportTxt.Name = "btnExportTxt"
        Me.btnExportTxt.Size = New System.Drawing.Size(87, 25)
        Me.btnExportTxt.TabIndex = 12
        Me.btnExportTxt.Text = "Export to Txt"
        Me.btnExportTxt.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(610, 524)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 25)
        Me.btnQuit.TabIndex = 13
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnWipe
        '
        Me.btnWipe.Location = New System.Drawing.Point(610, 139)
        Me.btnWipe.Name = "btnWipe"
        Me.btnWipe.Size = New System.Drawing.Size(75, 25)
        Me.btnWipe.TabIndex = 14
        Me.btnWipe.Text = "Clear"
        Me.btnWipe.UseVisualStyleBackColor = True
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(546, 108)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(125, 25)
        Me.btnChange.TabIndex = 15
        Me.btnChange.Text = "Change to Present"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'lblIndicator
        '
        Me.lblIndicator.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.lblIndicator.Location = New System.Drawing.Point(297, 20)
        Me.lblIndicator.Name = "lblIndicator"
        Me.lblIndicator.Size = New System.Drawing.Size(200, 65)
        Me.lblIndicator.TabIndex = 16
        Me.lblIndicator.Text = "Future"
        Me.lblIndicator.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnExportXLS
        '
        Me.btnExportXLS.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExportXLS.Location = New System.Drawing.Point(517, 526)
        Me.btnExportXLS.Name = "btnExportXLS"
        Me.btnExportXLS.Size = New System.Drawing.Size(87, 25)
        Me.btnExportXLS.TabIndex = 17
        Me.btnExportXLS.Text = "Export to XLS"
        Me.btnExportXLS.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AcceptButton = Me.btnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.btnQuit
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExportXLS)
        Me.Controls.Add(Me.lblIndicator)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.btnWipe)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnExportTxt)
        Me.Controls.Add(Me.btnRatio)
        Me.Controls.Add(Me.btnRtn)
        Me.Controls.Add(Me.lblInterest)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblYears)
        Me.Controls.Add(Me.boxInterest)
        Me.Controls.Add(Me.boxAmount)
        Me.Controls.Add(Me.boxNumOfYear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.grid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finanace Calculator "
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnCalc As Button
    Friend WithEvents grid1 As DataGridView
    Friend WithEvents boxNumOfYear As TextBox
    Friend WithEvents boxAmount As TextBox
    Friend WithEvents boxInterest As TextBox
    Friend WithEvents lblYears As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblInterest As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnRtn As Button
    Friend WithEvents btnRatio As Button
    Friend WithEvents btnExportTxt As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnWipe As Button
    Friend WithEvents btnChange As Button
    Friend WithEvents lblIndicator As Label
    Friend WithEvents btnExportXLS As Button
End Class
