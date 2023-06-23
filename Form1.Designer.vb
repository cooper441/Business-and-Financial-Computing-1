<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.welcomeLbl = New System.Windows.Forms.Label()
        Me.btnValue = New System.Windows.Forms.Button()
        Me.btnRatio = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'welcomeLbl
        '
        Me.welcomeLbl.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.welcomeLbl.Image = CType(resources.GetObject("welcomeLbl.Image"), System.Drawing.Image)
        Me.welcomeLbl.Location = New System.Drawing.Point(0, 0)
        Me.welcomeLbl.Name = "welcomeLbl"
        Me.welcomeLbl.Size = New System.Drawing.Size(800, 600)
        Me.welcomeLbl.TabIndex = 1
        Me.welcomeLbl.Text = "Welcome to the Finance Calculator"
        Me.welcomeLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnValue
        '
        Me.btnValue.Location = New System.Drawing.Point(251, 357)
        Me.btnValue.Name = "btnValue"
        Me.btnValue.Size = New System.Drawing.Size(124, 25)
        Me.btnValue.TabIndex = 2
        Me.btnValue.Text = "Value Calculator "
        Me.btnValue.UseVisualStyleBackColor = True
        '
        'btnRatio
        '
        Me.btnRatio.Location = New System.Drawing.Point(415, 357)
        Me.btnRatio.Name = "btnRatio"
        Me.btnRatio.Size = New System.Drawing.Size(132, 25)
        Me.btnRatio.TabIndex = 3
        Me.btnRatio.Text = "Ratio Calculator"
        Me.btnRatio.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(354, 388)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 25)
        Me.btnQuit.TabIndex = 14
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnRatio)
        Me.Controls.Add(Me.btnValue)
        Me.Controls.Add(Me.welcomeLbl)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finance Calculator "
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents welcomeLbl As Label
    Friend WithEvents btnValue As Button
    Friend WithEvents btnRatio As Button
    Friend WithEvents btnQuit As Button
End Class
