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
        btnStart = New Button()
        btnVariable = New Button()
        btnDatatype = New Button()
        btnInput = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        btnGo = New Button()
        SuspendLayout()
        ' 
        ' btnStart
        ' 
        btnStart.BackColor = Color.IndianRed
        btnStart.BackgroundImageLayout = ImageLayout.None
        btnStart.Location = New Point(204, 361)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(262, 71)
        btnStart.TabIndex = 0
        btnStart.Text = "MessageBox"
        btnStart.UseVisualStyleBackColor = False
        ' 
        ' btnVariable
        ' 
        btnVariable.BackColor = Color.RosyBrown
        btnVariable.Location = New Point(204, 284)
        btnVariable.Name = "btnVariable"
        btnVariable.Size = New Size(262, 71)
        btnVariable.TabIndex = 1
        btnVariable.Text = "Variables"
        btnVariable.UseVisualStyleBackColor = False
        ' 
        ' btnDatatype
        ' 
        btnDatatype.BackColor = Color.WhiteSmoke
        btnDatatype.Location = New Point(472, 284)
        btnDatatype.Name = "btnDatatype"
        btnDatatype.Size = New Size(262, 71)
        btnDatatype.TabIndex = 2
        btnDatatype.Text = "Datatypes"
        btnDatatype.UseVisualStyleBackColor = False
        ' 
        ' btnInput
        ' 
        btnInput.BackColor = Color.Gainsboro
        btnInput.Location = New Point(472, 361)
        btnInput.Name = "btnInput"
        btnInput.Size = New Size(262, 71)
        btnInput.TabIndex = 3
        btnInput.Text = "InputBox"
        btnInput.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(206, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 25)
        Label1.TabIndex = 4
        Label1.Text = "First Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(206, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 25)
        Label2.TabIndex = 5
        Label2.Text = "Last Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(568, 67)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 25)
        Label3.TabIndex = 6
        Label3.Text = "Gender"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(352, 61)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(352, 112)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(150, 31)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(687, 64)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(150, 31)
        TextBox3.TabIndex = 9
        ' 
        ' btnGo
        ' 
        btnGo.BackColor = Color.Lavender
        btnGo.Location = New Point(704, 115)
        btnGo.Name = "btnGo"
        btnGo.Size = New Size(112, 34)
        btnGo.TabIndex = 10
        btnGo.Text = "Go"
        btnGo.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(887, 450)
        Controls.Add(btnGo)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnInput)
        Controls.Add(btnDatatype)
        Controls.Add(btnVariable)
        Controls.Add(btnStart)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnVariable As Button
    Friend WithEvents btnDatatype As Button
    Friend WithEvents btnInput As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents btnGo As Button
End Class
