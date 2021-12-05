﻿Public Class Pizza102
    'set up a record or "class" for a student
    Class STUDENT
        Public studID As Int16
        Public firstName As String
        Public lastName As String
        Public deliveryDate As Date
        Public postcode As String
        Public avMk As Byte '+ve # < 255
    End Class
    Dim students(9) As STUDENT
    Dim studentCount As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'allocate memory
        For i = 0 To 9
            students(i) = New STUDENT
        Next
        'load 4 test records
        students(0).studID = 1
        students(0).firstName = "Johnny"
        students(0).lastName = "Depp"
        students(0).deliveryDate = "9/6/63"
        students(0).postcode = "m"
        students(0).avMk = 78.2
        students(1).studID = 2
        students(1).firstName = "Jennifer"
        students(1).lastName = "Lawrence"
        students(1).deliveryDate = "15/8/90"
        students(1).postcode = "f"
        students(1).avMk = 88.2
        students(2).studID = 3
        students(2).firstName = "George"
        students(2).lastName = "Clooney"
        students(2).deliveryDate = "6/5/61"
        students(2).postcode = "m"
        students(2).avMk = 68.2
        students(3).studID = 4
        students(3).firstName = "Scarlett"
        students(3).lastName = "Johansson"
        students(3).deliveryDate = "22/11/84"
        students(3).postcode = "f"
        students(3).avMk = 72.2
        'set the student count to the number of students which have been entered
        studentCount = 4
        displayList()
    End Sub
    Private Sub btnAddStud_Click(sender As Object, e As EventArgs) Handles btnAddStud.Click
        students(studentCount).studID = studentCount + 1 'allocate the new student ID to an incremented value
        'place text from text boxes into the array - first students(0), then students(1), students(2) etc
        students(studentCount).firstName = txtFirstName.Text
        students(studentCount).lastName = txtLastName.Text
        students(studentCount).deliveryDate = txtDelDate.Text
        students(studentCount).postcode = txtPostcode.Text
        students(studentCount).avMk = txtAvMk.Text
        studentCount += 1
        'return text boxes to blank ready for next entry
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtDelDate.Text = ""
        txtPostcode.Text = ""
        txtAvMk.Text = ""
        displayList()
    End Sub
    Private Sub displayList()
        'clear the list box as it keeps the earlier loop
        txtStList.Items.Clear()
        'loop through the array to print all rows
        For i = 0 To studentCount - 1
            txtStList.Items.Add(students(i).studID & " - " & students(i).firstName & " - " &
                              UCase(students(i).lastName) & " - " & students(i).deliveryDate & " - " &
                              students(i).postcode & " - " & students(i).avMk)
        Next
    End Sub

End Class
