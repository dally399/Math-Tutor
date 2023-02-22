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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtNum1 = New TextBox()
        txtNum2 = New TextBox()
        txtAnswer = New TextBox()
        btnShowAnswer = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(118, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 20)
        Label1.TabIndex = 0
        Label1.Text = "Enter First Number"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(118, 130)
        Label2.Name = "Label2"
        Label2.Size = New Size(154, 20)
        Label2.TabIndex = 1
        Label2.Text = "Enter Second Number"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(118, 175)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 20)
        Label3.TabIndex = 2
        Label3.Text = "Answer"' 
        ' txtNum1
        ' 
        txtNum1.Location = New Point(293, 78)
        txtNum1.Name = "txtNum1"
        txtNum1.Size = New Size(197, 27)
        txtNum1.TabIndex = 3
        ' 
        ' txtNum2
        ' 
        txtNum2.Location = New Point(293, 123)
        txtNum2.Name = "txtNum2"
        txtNum2.Size = New Size(197, 27)
        txtNum2.TabIndex = 4
        ' 
        ' txtAnswer
        ' 
        txtAnswer.Location = New Point(293, 168)
        txtAnswer.Name = "txtAnswer"
        txtAnswer.Size = New Size(197, 27)
        txtAnswer.TabIndex = 5
        ' 
        ' btnShowAnswer
        ' 
        btnShowAnswer.Location = New Point(155, 280)
        btnShowAnswer.Name = "btnShowAnswer"
        btnShowAnswer.Size = New Size(147, 29)
        btnShowAnswer.TabIndex = 6
        btnShowAnswer.Text = "Show Answer"
        btnShowAnswer.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(350, 280)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 29)
        btnExit.TabIndex = 7
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnExit)
        Controls.Add(btnShowAnswer)
        Controls.Add(txtAnswer)
        Controls.Add(txtNum2)
        Controls.Add(txtNum1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents btnShowAnswer As Button
    Friend WithEvents btnExit As Button
End Class
