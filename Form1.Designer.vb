﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.BtnLevel = New System.Windows.Forms.Button()
        Me.BtnCostumes = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnLevel
        '
        Me.BtnLevel.Location = New System.Drawing.Point(298, 156)
        Me.BtnLevel.Name = "BtnLevel"
        Me.BtnLevel.Size = New System.Drawing.Size(163, 61)
        Me.BtnLevel.TabIndex = 0
        Me.BtnLevel.Text = "Levels"
        Me.BtnLevel.UseVisualStyleBackColor = True
        '
        'BtnCostumes
        '
        Me.BtnCostumes.Location = New System.Drawing.Point(298, 236)
        Me.BtnCostumes.Name = "BtnCostumes"
        Me.BtnCostumes.Size = New System.Drawing.Size(163, 61)
        Me.BtnCostumes.TabIndex = 1
        Me.BtnCostumes.Text = "Costumes"
        Me.BtnCostumes.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(298, 326)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(163, 61)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.BtnCostumes)
        Me.Controls.Add(Me.BtnLevel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnLevel As Button
    Friend WithEvents BtnCostumes As Button
    Friend WithEvents Button3 As Button
End Class
