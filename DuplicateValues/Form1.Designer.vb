<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnInputNumbers = New System.Windows.Forms.Button()
        Me.lblDuplicate = New System.Windows.Forms.Label()
        Me.lstValues = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnInputNumbers
        '
        Me.btnInputNumbers.Location = New System.Drawing.Point(12, 12)
        Me.btnInputNumbers.Name = "btnInputNumbers"
        Me.btnInputNumbers.Size = New System.Drawing.Size(85, 23)
        Me.btnInputNumbers.TabIndex = 0
        Me.btnInputNumbers.Text = "Input Numbers"
        Me.btnInputNumbers.UseVisualStyleBackColor = True
        '
        'lblDuplicate
        '
        Me.lblDuplicate.Location = New System.Drawing.Point(103, 12)
        Me.lblDuplicate.Name = "lblDuplicate"
        Me.lblDuplicate.Size = New System.Drawing.Size(102, 36)
        Me.lblDuplicate.TabIndex = 1
        '
        'lstValues
        '
        Me.lstValues.FormattingEnabled = True
        Me.lstValues.Location = New System.Drawing.Point(12, 51)
        Me.lstValues.Name = "lstValues"
        Me.lstValues.Size = New System.Drawing.Size(193, 160)
        Me.lstValues.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(217, 223)
        Me.Controls.Add(Me.lstValues)
        Me.Controls.Add(Me.lblDuplicate)
        Me.Controls.Add(Me.btnInputNumbers)
        Me.Name = "Form1"
        Me.Text = "Duplicate Values"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnInputNumbers As System.Windows.Forms.Button
    Friend WithEvents lblDuplicate As System.Windows.Forms.Label
    Friend WithEvents lstValues As System.Windows.Forms.ListBox

End Class
