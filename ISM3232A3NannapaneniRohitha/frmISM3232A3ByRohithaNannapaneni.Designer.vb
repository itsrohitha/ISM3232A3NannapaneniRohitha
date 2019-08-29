<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmISM3232A3ByRohithaNannapaneni
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnArray = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnIF = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(99, 63)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(425, 24)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "ISM 3232, Assignment 3 By Rohitha Nannapaneni"
        '
        'btnArray
        '
        Me.btnArray.BackColor = System.Drawing.Color.Coral
        Me.btnArray.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArray.Location = New System.Drawing.Point(224, 126)
        Me.btnArray.Name = "btnArray"
        Me.btnArray.Size = New System.Drawing.Size(211, 51)
        Me.btnArray.TabIndex = 1
        Me.btnArray.Text = "Prime Number Array"
        Me.btnArray.UseVisualStyleBackColor = False
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.Plum
        Me.btnSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(367, 253)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(188, 81)
        Me.btnSelect.TabIndex = 2
        Me.btnSelect.Text = "BMI and Select Case Statement"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'btnIF
        '
        Me.btnIF.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnIF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIF.Location = New System.Drawing.Point(103, 253)
        Me.btnIF.Name = "btnIF"
        Me.btnIF.Size = New System.Drawing.Size(188, 81)
        Me.btnIF.TabIndex = 3
        Me.btnIF.Text = "BMI and IF Statement"
        Me.btnIF.UseVisualStyleBackColor = False
        '
        'frmISM3232A3ByRohithaNannapaneni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 484)
        Me.Controls.Add(Me.btnIF)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnArray)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmISM3232A3ByRohithaNannapaneni"
        Me.Text = "ISM 3232 Assignment 3 By Rohitha Nannapaneni"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnArray As Button
    Friend WithEvents btnSelect As Button
    Friend WithEvents btnIF As Button
End Class
