﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.btnok = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Meiryo", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(92, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOG IN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "USERNAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PASSWORD"
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(99, 83)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(186, 20)
        Me.txtusername.TabIndex = 3
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(99, 120)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(124)
        Me.txtpassword.Size = New System.Drawing.Size(186, 20)
        Me.txtpassword.TabIndex = 4
        '
        'btnok
        '
        Me.btnok.Location = New System.Drawing.Point(15, 14)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(107, 23)
        Me.btnok.TabIndex = 5
        Me.btnok.Text = "OK"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(151, 14)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(107, 23)
        Me.btnclose.TabIndex = 6
        Me.btnclose.Text = "CLOSE"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnok)
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Location = New System.Drawing.Point(12, 169)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(273, 52)
        Me.Panel1.TabIndex = 7
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 242)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
