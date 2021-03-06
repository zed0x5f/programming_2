﻿Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        grpHousingUnit.Visible = False

    End Sub

    Private Sub btnCalcCosts_Click(sender As Object, e As EventArgs) Handles btnCalcCosts.Click

        Dim objStudent As Student
        Dim objCampusStudent As StudentOnCampus
        Dim inputError As Boolean = False

        If txtStudentName.TextLength < 1 Or txtStudentName.Text < "A" Then
            MsgBox("Enter your name in the Student Name Box", , "Error")
            txtStudentName.Clear()
            txtStudentName.Focus()
            inputError = True
        ElseIf Not IsNumeric(txtUnits.Text) Then
            MsgBox("Enter a unit in the Units Box", , "Error")
            txtUnits.Clear()
            txtUnits.Focus()
            inputError = True
        ElseIf Convert.ToInt32(txtUnits.Text) < 1 Or Convert.ToInt32(txtUnits.Text) > 24 Then
            MsgBox("Units must be between 1-24", , "Error")
            txtUnits.Clear()
            txtUnits.Focus()
            inputError = True
        ElseIf cbbMajor.SelectedIndex < 0 Then
            MsgBox("Select a Major", , "Error")
            cbbMajor.Focus()
            inputError = True
        End If

        If Not inputError Then
            If radOffCampus.Checked = True Then
                objStudent = New Student(txtStudentID.Text, txtStudentName.Text, cbbMajor.SelectedItem, txtUnits.Text)

                lblCosts.Text = "Total semester costs are: " & objStudent.ComputeCost().ToString("C2")
            Else
                objCampusStudent = New StudentOnCampus(txtStudentID.Text, txtStudentName.Text, cbbMajor.SelectedItem, txtUnits.Text, radCooper.Checked, radCraig.Checked, radJulian.Checked)
                lblCosts.Text = "Total semester costs are: " & objCampusStudent.ComputeCost().ToString("C2")
            End If
        End If

    End Sub

    Private Sub btnClearForm_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click

        txtStudentID.Clear()
        txtStudentName.Clear()
        txtUnits.Clear()
        cbbMajor.SelectedIndex = -1
        radOffCampus.Select()

    End Sub

    Private Sub radOffCampus_CheckedChanged(sender As Object, e As EventArgs) Handles radOffCampus.CheckedChanged

        grpHousingUnit.Visible = False

    End Sub

    Private Sub radOnCampus_CheckedChanged(sender As Object, e As EventArgs) Handles radOnCampus.CheckedChanged

        grpHousingUnit.Visible = True

    End Sub
End Class
