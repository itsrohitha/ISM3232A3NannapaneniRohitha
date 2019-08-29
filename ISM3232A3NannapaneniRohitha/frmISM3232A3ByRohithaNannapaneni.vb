Public Class frmISM3232A3ByRohithaNannapaneni
    Private Sub btnArray_Click(sender As Object, e As EventArgs) Handles btnArray.Click
        Dim PrimeNumber(6) As Single
        PrimeNumber(1) = 1
        PrimeNumber(2) = 2
        PrimeNumber(3) = 3
        PrimeNumber(4) = 5
        PrimeNumber(5) = 7
        PrimeNumber(6) = 11
        Dim i = 0
        'LOOP Statements
        While i < 6
            i = i + 1
            MsgBox(PrimeNumber(i))
        End While

        ReDim Preserve PrimeNumber(8)
        PrimeNumber(7) = 13
        PrimeNumber(8) = 17
        'LOOP Statements
        Do While i < 8
            i = i + 1
            MsgBox(PrimeNumber(i))
        Loop
    End Sub

    Private Sub btnIF_Click(sender As Object, e As EventArgs) Handles btnIF.Click
        Dim Weight As Single
        Weight = InputBox("Please enter your weight in pounds(lbs)")
        Dim Height As Single
        Height = InputBox("Please enter your height in inches(in)")
        Dim BMI As Short
        BMI = Weight * 703 / (Height ^ 2)
        MsgBox("Your Body Mass Index is " & BMI)

        'IF-THEN-ELSE Statements
        If BMI < 18.5 Then
            MsgBox("You're underweight.")
        ElseIf BMI < 24.9999 Then
            MsgBox("You're normal weight.")
        ElseIf BMI < 29.999 Then
            MsgBox("You're overweight.")
        ElseIf BMI > 30 Then
            MsgBox("You're obese.")
        End If

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim Weight As Single
        Weight = InputBox("Please enter your weight in pounds(lbs)")
        Dim Height As Single
        Height = InputBox("Please enter your height in inches(in)")
        Dim BMI As Short
        BMI = Weight * 703 / (Height ^ 2)
        MsgBox("Your Body Mass Index is " & BMI)

        'SELECT-CASE Statements
        Select Case BMI
            Case Is < 18.5
                MsgBox("You're underweight.")
            Case Is < 24.9999
                MsgBox("You're normal weight.")
            Case Is < 29.9999
                MsgBox("You're overweight.")
            Case Is >= 30
                MsgBox("You're obese")
        End Select
    End Sub
End Class
