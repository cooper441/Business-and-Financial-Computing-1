<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.grid1 = New System.Windows.Forms.DataGridView()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnVaule = New System.Windows.Forms.Button()
        Me.btnRtn = New System.Windows.Forms.Button()
        Me.cmbSelector = New System.Windows.Forms.ComboBox()
        Me.btnExportTxt = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.lblIndicator = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnWipe = New System.Windows.Forms.Button()
        Me.lblInput1 = New System.Windows.Forms.Label()
        Me.lblInput2 = New System.Windows.Forms.Label()
        Me.boxInput2 = New System.Windows.Forms.TextBox()
        Me.boxInput1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grid4 = New System.Windows.Forms.DataGridView()
        Me.grid2 = New System.Windows.Forms.DataGridView()
        Me.grid3 = New System.Windows.Forms.DataGridView()
        Me.picArrow = New System.Windows.Forms.PictureBox()
        Me.btnExportXLS = New System.Windows.Forms.Button()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.grid4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid1
        '
        Me.grid1.AllowUserToAddRows = False
        Me.grid1.AllowUserToDeleteRows = False
        Me.grid1.AllowUserToResizeColumns = False
        Me.grid1.AllowUserToResizeRows = False
        Me.grid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid1.Location = New System.Drawing.Point(85, 170)
        Me.grid1.MultiSelect = False
        Me.grid1.Name = "grid1"
        Me.grid1.ReadOnly = True
        Me.grid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.grid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.grid1.RowTemplate.Height = 25
        Me.grid1.Size = New System.Drawing.Size(600, 350)
        Me.grid1.TabIndex = 0
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(610, 526)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 14
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnVaule
        '
        Me.btnVaule.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnVaule.Location = New System.Drawing.Point(166, 526)
        Me.btnVaule.Name = "btnVaule"
        Me.btnVaule.Size = New System.Drawing.Size(115, 23)
        Me.btnVaule.TabIndex = 15
        Me.btnVaule.Text = "Vaule Calculator "
        Me.btnVaule.UseVisualStyleBackColor = True
        '
        'btnRtn
        '
        Me.btnRtn.Location = New System.Drawing.Point(85, 526)
        Me.btnRtn.Name = "btnRtn"
        Me.btnRtn.Size = New System.Drawing.Size(75, 23)
        Me.btnRtn.TabIndex = 16
        Me.btnRtn.Text = "Return"
        Me.btnRtn.UseVisualStyleBackColor = True
        '
        'cmbSelector
        '
        Me.cmbSelector.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound
        Me.cmbSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelector.Items.AddRange(New Object() {"Current ratio", "Debt to equity ", "Gross profit margin ", "Working captial ratio"})
        Me.cmbSelector.Location = New System.Drawing.Point(646, 62)
        Me.cmbSelector.Name = "cmbSelector"
        Me.cmbSelector.Size = New System.Drawing.Size(121, 23)
        Me.cmbSelector.TabIndex = 17
        '
        'btnExportTxt
        '
        Me.btnExportTxt.Location = New System.Drawing.Point(415, 526)
        Me.btnExportTxt.Name = "btnExportTxt"
        Me.btnExportTxt.Size = New System.Drawing.Size(91, 23)
        Me.btnExportTxt.TabIndex = 18
        Me.btnExportTxt.Text = "Export to Txt"
        Me.btnExportTxt.UseVisualStyleBackColor = True
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSelect.Location = New System.Drawing.Point(646, 38)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(88, 21)
        Me.lblSelect.TabIndex = 19
        Me.lblSelect.Text = "Select type:"
        '
        'lblIndicator
        '
        Me.lblIndicator.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.lblIndicator.Location = New System.Drawing.Point(163, 13)
        Me.lblIndicator.Name = "lblIndicator"
        Me.lblIndicator.Size = New System.Drawing.Size(446, 65)
        Me.lblIndicator.TabIndex = 20
        Me.lblIndicator.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(529, 139)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 25)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnWipe
        '
        Me.btnWipe.Location = New System.Drawing.Point(610, 139)
        Me.btnWipe.Name = "btnWipe"
        Me.btnWipe.Size = New System.Drawing.Size(75, 25)
        Me.btnWipe.TabIndex = 4
        Me.btnWipe.Text = "Clear"
        Me.btnWipe.UseVisualStyleBackColor = True
        '
        'lblInput1
        '
        Me.lblInput1.AutoSize = True
        Me.lblInput1.Location = New System.Drawing.Point(222, 121)
        Me.lblInput1.Name = "lblInput1"
        Me.lblInput1.Size = New System.Drawing.Size(0, 15)
        Me.lblInput1.TabIndex = 23
        '
        'lblInput2
        '
        Me.lblInput2.AutoSize = True
        Me.lblInput2.Location = New System.Drawing.Point(360, 121)
        Me.lblInput2.Name = "lblInput2"
        Me.lblInput2.Size = New System.Drawing.Size(0, 15)
        Me.lblInput2.TabIndex = 24
        '
        'boxInput2
        '
        Me.boxInput2.Location = New System.Drawing.Point(375, 139)
        Me.boxInput2.Name = "boxInput2"
        Me.boxInput2.Size = New System.Drawing.Size(100, 23)
        Me.boxInput2.TabIndex = 2
        '
        'boxInput1
        '
        Me.boxInput1.Location = New System.Drawing.Point(222, 139)
        Me.boxInput1.Name = "boxInput1"
        Me.boxInput1.Size = New System.Drawing.Size(100, 23)
        Me.boxInput1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.grid4)
        Me.Panel1.Location = New System.Drawing.Point(85, 170)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 350)
        Me.Panel1.TabIndex = 29
        '
        'grid4
        '
        Me.grid4.AllowUserToAddRows = False
        Me.grid4.AllowUserToDeleteRows = False
        Me.grid4.AllowUserToResizeColumns = False
        Me.grid4.AllowUserToResizeRows = False
        Me.grid4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grid4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grid4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid4.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grid4.Location = New System.Drawing.Point(0, 0)
        Me.grid4.MultiSelect = False
        Me.grid4.Name = "grid4"
        Me.grid4.ReadOnly = True
        Me.grid4.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.grid4.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.grid4.RowTemplate.Height = 25
        Me.grid4.Size = New System.Drawing.Size(600, 350)
        Me.grid4.TabIndex = 34
        '
        'grid2
        '
        Me.grid2.AllowUserToAddRows = False
        Me.grid2.AllowUserToDeleteRows = False
        Me.grid2.AllowUserToResizeColumns = False
        Me.grid2.AllowUserToResizeRows = False
        Me.grid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grid2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid2.Location = New System.Drawing.Point(85, 170)
        Me.grid2.MultiSelect = False
        Me.grid2.Name = "grid2"
        Me.grid2.ReadOnly = True
        Me.grid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.grid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.grid2.RowTemplate.Height = 25
        Me.grid2.Size = New System.Drawing.Size(600, 350)
        Me.grid2.TabIndex = 30
        '
        'grid3
        '
        Me.grid3.AllowUserToAddRows = False
        Me.grid3.AllowUserToDeleteRows = False
        Me.grid3.AllowUserToResizeColumns = False
        Me.grid3.AllowUserToResizeRows = False
        Me.grid3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grid3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grid3.Location = New System.Drawing.Point(85, 170)
        Me.grid3.MultiSelect = False
        Me.grid3.Name = "grid3"
        Me.grid3.ReadOnly = True
        Me.grid3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.grid3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.grid3.RowTemplate.Height = 25
        Me.grid3.Size = New System.Drawing.Size(600, 350)
        Me.grid3.TabIndex = 31
        '
        'picArrow
        '
        Me.picArrow.Image = CType(resources.GetObject("picArrow.Image"), System.Drawing.Image)
        Me.picArrow.Location = New System.Drawing.Point(445, 38)
        Me.picArrow.Name = "picArrow"
        Me.picArrow.Size = New System.Drawing.Size(195, 67)
        Me.picArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picArrow.TabIndex = 32
        Me.picArrow.TabStop = False
        '
        'btnExportXLS
        '
        Me.btnExportXLS.Location = New System.Drawing.Point(512, 526)
        Me.btnExportXLS.Name = "btnExportXLS"
        Me.btnExportXLS.Size = New System.Drawing.Size(92, 23)
        Me.btnExportXLS.TabIndex = 33
        Me.btnExportXLS.Text = "Export to XLS"
        Me.btnExportXLS.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AcceptButton = Me.btnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnQuit
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExportXLS)
        Me.Controls.Add(Me.picArrow)
        Me.Controls.Add(Me.grid3)
        Me.Controls.Add(Me.grid2)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.boxInput1)
        Me.Controls.Add(Me.boxInput2)
        Me.Controls.Add(Me.lblInput2)
        Me.Controls.Add(Me.lblInput1)
        Me.Controls.Add(Me.btnWipe)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblIndicator)
        Me.Controls.Add(Me.lblSelect)
        Me.Controls.Add(Me.btnExportTxt)
        Me.Controls.Add(Me.cmbSelector)
        Me.Controls.Add(Me.btnRtn)
        Me.Controls.Add(Me.btnVaule)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ratio Calc"
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.grid4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picArrow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grid1 As DataGridView
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnVaule As Button
    Friend WithEvents btnRtn As Button
    Friend WithEvents cmbSelector As ComboBox
    Friend WithEvents btnExportTxt As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents lblSelect As Label
    Friend WithEvents lblIndicator As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnWipe As Button
    Friend WithEvents lblInput1 As Label
    Friend WithEvents lblInput2 As Label
    Friend WithEvents boxInput2 As TextBox
    Friend WithEvents box As TextBox
    Friend WithEvents boxInput1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents grid2 As DataGridView
    Friend WithEvents grid3 As DataGridView
    Friend WithEvents picArrow As PictureBox
    Friend WithEvents btnExportXLS As Button
    Friend WithEvents grid4 As DataGridView
End Class
