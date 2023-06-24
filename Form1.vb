Imports System.ComponentModel.Design.Serialization
Imports System.Windows.Forms.Design
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        MsgBox("Welcome to the VB.NET programming course")
        MessageBox.Show(" New Message ")

    End Sub

    Private Sub btnVariable_Click(sender As Object, e As EventArgs) Handles btnVariable.Click


        Dim stFirstName As String
        Dim stLastName As String

        stFirstName = "Riya"
        stLastName = "Saxena"
        MessageBox.Show("My name is " & stFirstName & ". " & stLastName & " I hope you are well")


    End Sub

    Private Sub btnDatatype_Click(sender As Object, e As EventArgs) Handles btnDatatype.Click

        Dim stMake As String
        Dim stModel As String
        Dim iDoors As Integer
        Dim stColor As String
        Dim bTaxed As Boolean
        Dim decPrice As Decimal
        Dim dtDateRegistration As Date

        stMake = "Ford"
        stModel = "Escort"
        iDoors = 5
        stColor = "Red"
        bTaxed = True
        decPrice = 9999.99
        dtDateRegistration = #12/31/2002#


        MsgBox("The car is " & stMake & " " & stModel & vbCrLf &
               iDoors & vbCrLf & stColor & vbCrLf &
               bTaxed & vbCrLf & decPrice & vbCrLf & dtDateRegistration)



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnInput.Click

        'how to ask for input in pop up input box
        Dim stFirstName As String
        stFirstName = InputBox("Enter your first name ")
        MsgBox("Hello " & stFirstName)


    End Sub



    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim stFName As String
        Dim stLName As String
        Dim gender As String

        stFName = TextBox1.Text
        stLName = TextBox2.Text
        gender = TextBox3.Text

        MsgBox("Hello " & stFName & " " & stLName & " .Gender " & gender)


    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim iNum1 As Double
        Dim iNum2 As Double

        Dim iRes As Double

        iNum1 = txtNum1.Text
        iNum2 = txtNum2.Text
        iRes = iNum1 + iNum2
        MsgBox("The sum is " & iRes)

        iRes = iNum1 - iNum2
        MsgBox("The subtraction is " & iRes)

        iRes = iNum1 * iNum2
        MsgBox("The product is " & iRes)

        iRes = iNum1 / iNum2
        MsgBox("The division is " & iRes)

        'only whole number part remains
        iRes = iNum1 \ iNum2
        MsgBox("The whole no on division is " & iRes)

        iRes = iNum1 ^ iNum2
        MsgBox("Number1 raised to the power of Number2 " & iRes)

        'for multiple operands
        'BO(DM)(AS) - Brackets Order Division Multiplication Addition Subtraction
        'PE(MD)(AS) - Parenthesis Exponentiation Multiplcation Division Addition Subtraction
        'Please excuse my dear aunt sally - to remember the above rule

    End Sub

    Private Sub btnIf_Click(sender As Object, e As EventArgs) Handles btnIf.Click

        Dim stCountry As String
        stCountry = lstCntry.SelectedItem
        '= is used instead of == unlike in c++
        If stCountry.ToUpper = "AUSTRALIA" Then
            MsgBox("Hello Mate")
        ElseIf stCountry.ToUpper = "JAPAN" Then
            MsgBox("Konnichiwa")
        ElseIf stCountry.ToUpper = "INDIA" Then
            MsgBox("Namaste")
        Else
            MsgBox("Hello There")
        End If


    End Sub

    Private Sub btnScore_Click(sender As Object, e As EventArgs) Handles btnScore.Click

        Dim iScore As Integer

        If IsNumeric(tbScore.Text) = True Then
            iScore = CInt(tbScore.Text)
        Else
            MsgBox("You must enter a number")
            Exit Sub

        End If


        If Not (iScore >= 0 And iScore <= 100) Then
            MsgBox("Not a valid score")
        ElseIf iScore <= 20 Then
            MsgBox("Grade F")
        ElseIf iScore > 20 And iScore <= 30 Then
            MsgBox("Grade E")
        ElseIf iScore > 30 And iScore <= 40 Then
            MsgBox("Grade D")
        ElseIf iScore > 40 And iScore <= 60 Then
            MsgBox("Grade C")
        ElseIf iScore > 60 And iScore <= 70 Then
            MsgBox("Grade B")
        Else
            MsgBox("Grade A")
        End If

        MsgBox("All done")

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click


        Dim iTemp As Integer
        iTemp = CInt(tbTemp.Text)
        Dim iWindSpeed As Integer
        iWindSpeed = 30


        Select Case iTemp
            Case Is = 0
                MsgBox("Freezing")
                MsgBox("Water will freeze")
            Case Is < 0
                MsgBox("Sub Zero")
                If (iWindSpeed > 20) Then
                    MsgBox("Wind is above 20mph")
                End If
            Case 1, 2, 3, 4, 5, 6, 7, 8
                MsgBox("cold")
            Case 9 To 11
                MsgBox("warm")
            Case Else
                MsgBox("Above 11")
        End Select




    End Sub

    Private Sub btnPattern_Click(sender As Object, e As EventArgs) Handles btnPattern.Click
        ' for loop

        Dim icount As Integer
        Dim stcount As String
        'for next loop count controll loop
        For icount = 1 To 5
            Beep()
            Threading.Thread.Sleep(1000)
            'MsgBox("*")
        Next
        'step is like i++ in c++ 
        'For icount = 0 To 50 Step 10
        'MsgBox("Hello " & icount)
        'Next
        For icount = 0 To 50 Step 10
            stcount = stcount & icount & vbNewLine
            'all output in one msgbox 
        Next
        MsgBox(stcount)
        'do loop is called conditon controlled loop
        icount = 0
        'do while loop
        Do While icount <= 5
            icount = icount + 1
            MsgBox("hello " & icount)
        Loop
        icount = 0
        Do Until icount = 5
            icount = icount + 1
            MsgBox("hello * " & icount)
        Loop
        ' to run the condition ateast once 
        icount = 0
        Do
            icount = icount + 1
            MsgBox("hello #  " & icount)
        Loop Until icount = 5

        icount = 0
        Do
            icount = icount + 1
            MsgBox("hello ^ " & icount)
        Loop While icount < 5



        MsgBox("all done")

    End Sub

    Private Sub btnEvenOdd_Click(sender As Object, e As EventArgs) Handles btnEvenOdd.Click


        Dim iNum As Integer
        Dim iCount As Integer
        Dim stNum As String
        Dim stOutput As String

        iNum = InputBox("What no you want to count upto? ")
        stNum = InputBox("odd/even")

        If (stNum = "odd") Then
            For iCount = 1 To iNum Step 2
                stOutput = stOutput & iCount & vbNewLine
            Next
        Else
            For iCount = 2 To iNum Step 2
                stOutput = stOutput & iCount & vbNewLine
            Next
        End If

        MsgBox(stOutput)

    End Sub
End Class
