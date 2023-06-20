Imports System.Windows.Forms.Design

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
End Class
