﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.LabelNameIn = New System.Windows.Forms.Label()
        Me.LabelSurnameIn = New System.Windows.Forms.Label()
        Me.TextBoxSurname = New System.Windows.Forms.TextBox()
        Me.LabelFullName = New System.Windows.Forms.Label()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.LabelFullNameOut = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(146, 49)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(437, 20)
        Me.TextBoxName.TabIndex = 0
        Me.TextBoxName.Text = "( Input Your Name )"
        '
        'LabelNameIn
        '
        Me.LabelNameIn.AutoSize = True
        Me.LabelNameIn.Location = New System.Drawing.Point(76, 52)
        Me.LabelNameIn.Name = "LabelNameIn"
        Me.LabelNameIn.Size = New System.Drawing.Size(35, 13)
        Me.LabelNameIn.TabIndex = 1
        Me.LabelNameIn.Text = "Name"
        '
        'LabelSurnameIn
        '
        Me.LabelSurnameIn.AutoSize = True
        Me.LabelSurnameIn.Location = New System.Drawing.Point(76, 78)
        Me.LabelSurnameIn.Name = "LabelSurnameIn"
        Me.LabelSurnameIn.Size = New System.Drawing.Size(49, 13)
        Me.LabelSurnameIn.TabIndex = 3
        Me.LabelSurnameIn.Text = "Surname"
        '
        'TextBoxSurname
        '
        Me.TextBoxSurname.Location = New System.Drawing.Point(146, 75)
        Me.TextBoxSurname.Name = "TextBoxSurname"
        Me.TextBoxSurname.Size = New System.Drawing.Size(437, 20)
        Me.TextBoxSurname.TabIndex = 2
        Me.TextBoxSurname.Text = "( Input Your Surname ) "
        '
        'LabelFullName
        '
        Me.LabelFullName.AutoSize = True
        Me.LabelFullName.Location = New System.Drawing.Point(76, 162)
        Me.LabelFullName.Name = "LabelFullName"
        Me.LabelFullName.Size = New System.Drawing.Size(126, 13)
        Me.LabelFullName.TabIndex = 4
        Me.LabelFullName.Text = "Your Name and Surname"
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(79, 117)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOK.TabIndex = 5
        Me.ButtonOK.Text = "Ok"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'LabelFullNameOut
        '
        Me.LabelFullNameOut.AutoSize = True
        Me.LabelFullNameOut.Location = New System.Drawing.Point(243, 162)
        Me.LabelFullNameOut.Name = "LabelFullNameOut"
        Me.LabelFullNameOut.Size = New System.Drawing.Size(126, 13)
        Me.LabelFullNameOut.TabIndex = 6
        Me.LabelFullNameOut.Text = "Your Name and Surname"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LabelFullNameOut)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.LabelFullName)
        Me.Controls.Add(Me.LabelSurnameIn)
        Me.Controls.Add(Me.TextBoxSurname)
        Me.Controls.Add(Me.LabelNameIn)
        Me.Controls.Add(Me.TextBoxName)
        Me.Name = "Form1"
        Me.Text = "v"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents LabelNameIn As Label
    Friend WithEvents LabelSurnameIn As Label
    Friend WithEvents TextBoxSurname As TextBox
    Friend WithEvents LabelFullName As Label
    Friend WithEvents ButtonOK As Button
    Friend WithEvents LabelFullNameOut As Label
End Class
