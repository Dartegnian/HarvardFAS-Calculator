Public Class Organizations
    Shared selectedOrgsPrice As Integer
    Shared selectedOrgs As Integer

    Public Shared Function GetOrgsPrice() As Integer
        Return selectedOrgsPrice
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OrgsPrice.Text = "$" + selectedOrgsPrice.ToString()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Select Case (True)
            Case CheckBox1.Checked = True
                selectedOrgs += 1
                selectedOrgsPrice += 20
            Case CheckBox1.Checked = False
                selectedOrgs -= 1
                selectedOrgsPrice -= 20
        End Select
        OrgsSelected.Text = selectedOrgs
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Select Case (True)
            Case CheckBox2.Checked = True
                selectedOrgs += 1
                selectedOrgsPrice += 300
            Case CheckBox2.Checked = False
                selectedOrgs -= 1
                selectedOrgsPrice -= 300
        End Select
        OrgsSelected.Text = selectedOrgs
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        Select Case (True)
            Case CheckBox3.Checked = True
                selectedOrgs += 1
                selectedOrgsPrice += 80
            Case CheckBox3.Checked = False
                selectedOrgs -= 1
                selectedOrgsPrice -= 80
        End Select
        OrgsSelected.Text = selectedOrgs
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        Select Case (True)
            Case CheckBox4.Checked = True
                selectedOrgs += 1
                selectedOrgsPrice += 200
            Case CheckBox4.Checked = False
                selectedOrgs -= 1
                selectedOrgsPrice -= 200
        End Select
        OrgsSelected.Text = selectedOrgs
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        Select Case (True)
            Case CheckBox5.Checked = True
                selectedOrgs += 1
                selectedOrgsPrice += 400
            Case CheckBox5.Checked = False
                selectedOrgs -= 1
                selectedOrgsPrice -= 400
        End Select
        OrgsSelected.Text = selectedOrgs
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        Select Case (True)
            Case CheckBox6.Checked = True
                selectedOrgs += 1
                selectedOrgsPrice += 600
            Case CheckBox6.Checked = False
                selectedOrgs -= 1
                selectedOrgsPrice -= 600
        End Select
        OrgsSelected.Text = selectedOrgs
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        Select Case (True)
            Case CheckBox7.Checked = True
                selectedOrgs += 1
                selectedOrgsPrice += 400
            Case CheckBox7.Checked = False
                selectedOrgs -= 1
                selectedOrgsPrice -= 400
        End Select
        OrgsSelected.Text = selectedOrgs
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        Select Case (True)
            Case CheckBox8.Checked = True
                selectedOrgs += 1
                selectedOrgsPrice += 90
            Case CheckBox8.Checked = False
                selectedOrgs -= 1
                selectedOrgsPrice -= 90
        End Select
        OrgsSelected.Text = selectedOrgs
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        Select Case (True)
            Case CheckBox9.Checked = True
                selectedOrgs += 1
                selectedOrgsPrice += 50
            Case CheckBox9.Checked = False
                selectedOrgs -= 1
                selectedOrgsPrice -= 50
        End Select
        OrgsSelected.Text = selectedOrgs
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        Select Case (True)
            Case CheckBox10.Checked = True
                selectedOrgs += 1
                selectedOrgsPrice += 600
            Case CheckBox10.Checked = False
                selectedOrgs -= 1
                selectedOrgsPrice -= 600
        End Select
        OrgsSelected.Text = selectedOrgs
    End Sub
End Class