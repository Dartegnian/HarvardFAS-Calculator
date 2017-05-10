Public Class Houses
    Shared selectedHouse As String
    Shared selectedHousePrice As Integer
    Public Shared Function GetHousePrice() As Integer
        Return selectedHousePrice
    End Function

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked = True) Then
            selectedHouse = "Adams House"
            CurrentHouse.Text = selectedHouse

            CheckBox10.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = False
            CheckBox9.Checked = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked = True) Then
            selectedHouse = "Mather House"
            CurrentHouse.Text = selectedHouse

            CheckBox1.Checked = False
            CheckBox10.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = False
            CheckBox9.Checked = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If (CheckBox3.Checked = True) Then
            selectedHouse = "Kirkland House"
            CurrentHouse.Text = selectedHouse

            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox10.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = False
            CheckBox9.Checked = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If (CheckBox4.Checked = True) Then
            selectedHouse = "Pforzheimer House"
            CurrentHouse.Text = selectedHouse

            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox10.Checked = False
            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = False
            CheckBox9.Checked = False
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If (CheckBox5.Checked = True) Then
            selectedHouse = "Lowell House"
            CurrentHouse.Text = selectedHouse

            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox10.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = False
            CheckBox9.Checked = False
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If (CheckBox10.Checked = True) Then
            selectedHouse = "Eliot House"
            CurrentHouse.Text = selectedHouse

            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = False
            CheckBox9.Checked = False
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If (CheckBox9.Checked = True) Then
            selectedHouse = "Dunster House"
            CurrentHouse.Text = selectedHouse

            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = False
            CheckBox10.Checked = False
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If (CheckBox8.Checked = True) Then
            selectedHouse = "Cabot House"
            CurrentHouse.Text = selectedHouse

            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            CheckBox10.Checked = False
            CheckBox9.Checked = False
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If (CheckBox7.Checked = True) Then
            selectedHouse = "Quincy House"
            CurrentHouse.Text = selectedHouse

            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox10.Checked = False
            CheckBox8.Checked = False
            CheckBox9.Checked = False
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If (CheckBox6.Checked = True) Then
            selectedHouse = "Winthrop House"
            CurrentHouse.Text = selectedHouse

            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
            CheckBox10.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = False
            CheckBox9.Checked = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case (True)
            Case CheckBox1.Checked = True
                selectedHousePrice = 600
            Case CheckBox2.Checked = True
                selectedHousePrice = 550
            Case CheckBox3.Checked = True
                selectedHousePrice = 800
            Case CheckBox4.Checked = True
                selectedHousePrice = 900
            Case CheckBox5.Checked = True
                selectedHousePrice = 750
            Case CheckBox6.Checked = True
                selectedHousePrice = 450
            Case CheckBox7.Checked = True
                selectedHousePrice = 300
            Case CheckBox8.Checked = True
                selectedHousePrice = 1500
            Case CheckBox9.Checked = True
                selectedHousePrice = 850
            Case CheckBox10.Checked = True
                selectedHousePrice = 950
        End Select
        HousePrice.Text = "$" + selectedHousePrice.ToString()
    End Sub
End Class
