Public Class Form1
    Dim class_price As Integer
    Dim classes_selected As Integer
    Dim orgs_selected As Integer
    Dim orgs_price As Integer
    Dim study_price As Integer
    Dim house_selected As Integer
    Dim house_price As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (CheckBox1.Checked = True) Then
            class_price += 1000
        End If
        If (CheckBox2.Checked = True) Then
            class_price += 300
        End If
        If (CheckBox3.Checked = True) Then
            class_price += 8000
        End If
        If (CheckBox4.Checked = True) Then
            class_price += 4000
        End If
        If (CheckBox5.Checked = True) Then
            class_price += 400
        End If
        If (CheckBox6.Checked = True) Then
            class_price += 600
        End If
        If (CheckBox7.Checked = True) Then
            class_price += 3000
        End If
        If (CheckBox8.Checked = True) Then
            class_price += 4000
        End If
        If (CheckBox9.Checked = True) Then
            class_price += 200
        End If
        If (CheckBox10.Checked = True) Then
            class_price += 9000
        End If
        class_cost.Text = "$" + class_price.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (CheckBox11.Checked = True) Then
            orgs_price += 20
        End If
        If (CheckBox12.Checked = True) Then
            orgs_price += 300
        End If
        If (CheckBox13.Checked = True) Then
            orgs_price += 80
        End If
        If (CheckBox14.Checked = True) Then
            orgs_price += 200
        End If
        If (CheckBox15.Checked = True) Then
            orgs_price += 400
        End If
        If (CheckBox16.Checked = True) Then
            orgs_price += 600
        End If
        If (CheckBox17.Checked = True) Then
            orgs_price += 400
        End If
        If (CheckBox18.Checked = True) Then
            orgs_price += 90
        End If
        If (CheckBox19.Checked = True) Then
            orgs_price += 50
        End If
        If (CheckBox20.Checked = True) Then
            orgs_price += 600
        End If
        orgs_cost.Text = "$" + orgs_price.ToString()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Select Case (True)
            Case (CheckBox21.Checked = True)
                house_price = 400
            Case (CheckBox22.Checked = True)
                house_price = 800
            Case (CheckBox23.Checked = True)
                house_price = 550
            Case (CheckBox24.Checked = True)
                house_price = 200
            Case (CheckBox25.Checked = True)
                house_price = 400
            Case (CheckBox26.Checked = True)
                house_price = 150
            Case (CheckBox27.Checked = True)
                house_price = 950
            Case (CheckBox28.Checked = True)
                house_price = 650
            Case (CheckBox29.Checked = True)
                house_price = 1000
            Case (CheckBox30.Checked = True)
                house_price = 350
        End Select
        house_cost.Text = "$" + house_price.ToString()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        study_price = orgs_price + class_price + house_price
        ov_price.Text = "$" + study_price.ToString()
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If (CheckBox10.Checked = True) Then
            classes_selected += 1
        End If
        noofclasses.Text = classes_selected
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked = True) Then
            classes_selected += 1
        End If
        noofclasses.Text = classes_selected
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If (CheckBox3.Checked = True) Then
            classes_selected += 1
        End If
        noofclasses.Text = classes_selected
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If (CheckBox4.Checked = True) Then
            classes_selected += 1
        End If
        noofclasses.Text = classes_selected
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If (CheckBox5.Checked = True) Then
            classes_selected += 1
        End If
        noofclasses.Text = classes_selected
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If (CheckBox6.Checked = True) Then
            classes_selected += 1
        End If
        noofclasses.Text = classes_selected
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If (CheckBox7.Checked = True) Then
            classes_selected += 1
        End If
        noofclasses.Text = classes_selected
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If (CheckBox8.Checked = True) Then
            classes_selected += 1
        End If
        noofclasses.Text = classes_selected
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If (CheckBox9.Checked = True) Then
            classes_selected += 1
        End If
        noofclasses.Text = classes_selected
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked = True) Then
            classes_selected += 1
        End If
        noofclasses.Text = classes_selected
    End Sub

    Private Sub CheckBox21_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox21.CheckedChanged
        If (CheckBox21.Checked = True) Then
            CheckBox22.Checked = False
            CheckBox23.Checked = False
            CheckBox24.Checked = False
            CheckBox25.Checked = False
            CheckBox26.Checked = False
            CheckBox27.Checked = False
            CheckBox28.Checked = False
            CheckBox29.Checked = False
            CheckBox30.Checked = False
        End If
        currentHouse.Text = "Adams House"
    End Sub

    Private Sub CheckBox29_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox29.CheckedChanged
        If (CheckBox29.Checked = True) Then
            CheckBox22.Checked = False
            CheckBox23.Checked = False
            CheckBox24.Checked = False
            CheckBox25.Checked = False
            CheckBox26.Checked = False
            CheckBox27.Checked = False
            CheckBox28.Checked = False
            CheckBox21.Checked = False
            CheckBox30.Checked = False
        End If
        currentHouse.Text = "Lowell House"
    End Sub

    Private Sub CheckBox27_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox27.CheckedChanged
        If (CheckBox27.Checked = True) Then
            CheckBox22.Checked = False
            CheckBox23.Checked = False
            CheckBox24.Checked = False
            CheckBox25.Checked = False
            CheckBox26.Checked = False
            CheckBox21.Checked = False
            CheckBox28.Checked = False
            CheckBox29.Checked = False
            CheckBox30.Checked = False
        End If
        currentHouse.Text = "Leverett House"
    End Sub

    Private Sub CheckBox28_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox28.CheckedChanged
        If (CheckBox28.Checked = True) Then
            CheckBox22.Checked = False
            CheckBox23.Checked = False
            CheckBox24.Checked = False
            CheckBox25.Checked = False
            CheckBox26.Checked = False
            CheckBox27.Checked = False
            CheckBox21.Checked = False
            CheckBox29.Checked = False
            CheckBox30.Checked = False
        End If
        currentHouse.Text = "Currier House"
    End Sub

    Private Sub CheckBox30_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox30.CheckedChanged
        If (CheckBox30.Checked = True) Then
            CheckBox22.Checked = False
            CheckBox23.Checked = False
            CheckBox24.Checked = False
            CheckBox25.Checked = False
            CheckBox26.Checked = False
            CheckBox27.Checked = False
            CheckBox28.Checked = False
            CheckBox29.Checked = False
            CheckBox21.Checked = False
        End If
        currentHouse.Text = "Quincy House"
    End Sub

    Private Sub CheckBox25_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox25.CheckedChanged
        If (CheckBox25.Checked = True) Then
            CheckBox22.Checked = False
            CheckBox23.Checked = False
            CheckBox24.Checked = False
            CheckBox21.Checked = False
            CheckBox26.Checked = False
            CheckBox27.Checked = False
            CheckBox28.Checked = False
            CheckBox29.Checked = False
            CheckBox30.Checked = False
        End If
        currentHouse.Text = "Kirkland House"
    End Sub

    Private Sub CheckBox24_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox24.CheckedChanged
        If (CheckBox24.Checked = True) Then
            CheckBox22.Checked = False
            CheckBox23.Checked = False
            CheckBox21.Checked = False
            CheckBox25.Checked = False
            CheckBox26.Checked = False
            CheckBox27.Checked = False
            CheckBox28.Checked = False
            CheckBox29.Checked = False
            CheckBox30.Checked = False
        End If
        currentHouse.Text = "Cabot House"
    End Sub

    Private Sub CheckBox23_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox23.CheckedChanged
        If (CheckBox23.Checked = True) Then
            CheckBox22.Checked = False
            CheckBox21.Checked = False
            CheckBox24.Checked = False
            CheckBox25.Checked = False
            CheckBox26.Checked = False
            CheckBox27.Checked = False
            CheckBox28.Checked = False
            CheckBox29.Checked = False
            CheckBox30.Checked = False
        End If
        currentHouse.Text = "Mather House"
    End Sub

    Private Sub CheckBox22_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox22.CheckedChanged
        If (CheckBox22.Checked = True) Then
            CheckBox21.Checked = False
            CheckBox23.Checked = False
            CheckBox24.Checked = False
            CheckBox25.Checked = False
            CheckBox26.Checked = False
            CheckBox27.Checked = False
            CheckBox28.Checked = False
            CheckBox29.Checked = False
            CheckBox30.Checked = False
        End If
        currentHouse.Text = "Eliot House"
    End Sub

    Private Sub CheckBox26_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox26.CheckedChanged
        If (CheckBox26.Checked = True) Then
            CheckBox22.Checked = False
            CheckBox23.Checked = False
            CheckBox24.Checked = False
            CheckBox25.Checked = False
            CheckBox21.Checked = False
            CheckBox27.Checked = False
            CheckBox28.Checked = False
            CheckBox29.Checked = False
            CheckBox30.Checked = False
        End If
        currentHouse.Text = "Winthrop House"
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        If (CheckBox11.Checked = True) Then
            orgs_selected += 1
        End If
        noOfOrgs.Text = orgs_selected
    End Sub

    Private Sub CheckBox16_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox16.CheckedChanged
        If (CheckBox16.Checked = True) Then
            orgs_selected += 1
        End If
        noOfOrgs.Text = orgs_selected
    End Sub

    Private Sub CheckBox13_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox13.CheckedChanged
        If (CheckBox13.Checked = True) Then
            orgs_selected += 1
        End If
        noOfOrgs.Text = orgs_selected
    End Sub

    Private Sub CheckBox14_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox14.CheckedChanged
        If (CheckBox14.Checked = True) Then
            orgs_selected += 1
        End If
        noOfOrgs.Text = orgs_selected
    End Sub

    Private Sub CheckBox15_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox15.CheckedChanged
        If (CheckBox15.Checked = True) Then
            orgs_selected += 1
        End If
        noOfOrgs.Text = orgs_selected
    End Sub

    Private Sub CheckBox20_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox20.CheckedChanged
        If (CheckBox20.Checked = True) Then
            orgs_selected += 1
        End If
        noOfOrgs.Text = orgs_selected
    End Sub

    Private Sub CheckBox18_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox18.CheckedChanged
        If (CheckBox18.Checked = True) Then
            orgs_selected += 1
        End If
        noOfOrgs.Text = orgs_selected
    End Sub

    Private Sub CheckBox17_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox17.CheckedChanged
        If (CheckBox17.Checked = True) Then
            orgs_selected += 1
        End If
        noOfOrgs.Text = orgs_selected
    End Sub

    Private Sub CheckBox19_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox19.CheckedChanged
        If (CheckBox19.Checked = True) Then
            orgs_selected += 1
        End If
        noOfOrgs.Text = orgs_selected
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged
        If (CheckBox12.Checked = True) Then
            orgs_selected += 1
        End If
        noOfOrgs.Text = orgs_selected
    End Sub

End Class