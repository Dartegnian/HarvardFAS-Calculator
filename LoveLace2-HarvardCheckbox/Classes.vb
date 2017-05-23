Public Class Classes

    Shared selectedClassessPrice As Integer
    Shared selectedClasses As Integer

    Public Shared Function GetClassesPrice() As Integer
        Return selectedClassessPrice
    End Function

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Select Case (True)
            Case CheckBox1.Checked = True
                selectedClasses += 1
                selectedClassessPrice += 2500
            Case CheckBox1.Checked = False
                selectedClasses -= 1
                selectedClassessPrice -= 2500
        End Select
        ClassesSelected.Text = selectedClasses
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Select Case (True)
            Case CheckBox2.Checked = True
                selectedClasses += 1
                selectedClassessPrice += 2800
            Case CheckBox2.Checked = False
                selectedClasses -= 1
                selectedClassessPrice -= 2800
        End Select
        ClassesSelected.Text = selectedClasses
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        Select Case (True)
            Case CheckBox9.Checked = True
                selectedClasses += 1
                selectedClassessPrice += 2300
            Case CheckBox9.Checked = False
                selectedClasses -= 1
                selectedClassessPrice -= 2300
        End Select
        ClassesSelected.Text = selectedClasses
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        Select Case (True)
            Case CheckBox8.Checked = True
                selectedClasses += 1
                selectedClassessPrice += 2650
            Case CheckBox8.Checked = False
                selectedClasses -= 1
                selectedClassessPrice -= 2650
        End Select
        ClassesSelected.Text = selectedClasses
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        Select Case (True)
            Case CheckBox7.Checked = True
                selectedClasses += 1
                selectedClassessPrice += 2950
            Case CheckBox7.Checked = False
                selectedClasses -= 1
                selectedClassessPrice -= 2950
        End Select
        ClassesSelected.Text = selectedClasses
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        Select Case (True)
            Case CheckBox6.Checked = True
                selectedClasses += 1
                selectedClassessPrice += 1950
            Case CheckBox6.Checked = False
                selectedClasses -= 1
                selectedClassessPrice -= 1950
        End Select
        ClassesSelected.Text = selectedClasses
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        Select Case (True)
            Case CheckBox5.Checked = True
                selectedClasses += 1
                selectedClassessPrice += 2350
            Case CheckBox5.Checked = False
                selectedClasses -= 1
                selectedClassessPrice -= 2350
        End Select
        ClassesSelected.Text = selectedClasses
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        Select Case (True)
            Case CheckBox4.Checked = True
                selectedClasses += 1
                selectedClassessPrice += 2900
            Case CheckBox4.Checked = False
                selectedClasses -= 1
                selectedClassessPrice -= 2900
        End Select
        ClassesSelected.Text = selectedClasses
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        Select Case (True)
            Case CheckBox3.Checked = True
                selectedClasses += 1
                selectedClassessPrice += 3000
            Case CheckBox3.Checked = False
                selectedClasses -= 1
                selectedClassessPrice += 3000
        End Select
        ClassesSelected.Text = selectedClasses
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        Select Case (True)
            Case CheckBox10.Checked = True
                selectedClasses += 1
                selectedClassessPrice += 2750
            Case CheckBox10.Checked = False
                selectedClasses -= 1
                selectedClassessPrice -= 2750
        End Select
        ClassesSelected.Text = selectedClasses
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ClassesPrice.Text = "$" + selectedClassessPrice.ToString()
    End Sub
End Class