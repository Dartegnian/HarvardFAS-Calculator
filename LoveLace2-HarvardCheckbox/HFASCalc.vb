Imports System.Reflection
Public Class HFASCalc
    Dim HClasses As New Classes
    Dim HOrgs As New Organizations
    Dim HHouses As New Houses

    Private Sub HFASCalc_Load(sender As Object, e As EventArgs) Handles Me.Load
        MainPane.Controls.Add(HClasses)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles ClassIMG.Click
        If (MainPane.Controls.Contains(HClasses) = True) Then
        Else
            MainPane.Controls.Clear()
            MainPane.Controls.Add(HClasses)

            ClassSelector.Visible = True
            OrgsSelector.Visible = False
            HouseSelector.Visible = False

            ClassLBL.BackColor = Color.FromArgb(165, 28, 48)
            ClassIMG.BackColor = Color.FromArgb(165, 28, 48)
            OrgsLBL.BackColor = Color.FromArgb(97, 16, 29)
            OrgsIMG.BackColor = Color.FromArgb(97, 16, 29)
            HouseLBL.BackColor = Color.FromArgb(97, 16, 29)
            HouseIMG.BackColor = Color.FromArgb(97, 16, 29)
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles ClassLBL.Click
        If (MainPane.Controls.Contains(HClasses) = True) Then
        Else
            MainPane.Controls.Clear()
            MainPane.Controls.Add(HClasses)

            ClassSelector.Visible = True
            OrgsSelector.Visible = False
            HouseSelector.Visible = False

            ClassLBL.BackColor = Color.FromArgb(165, 28, 48)
            ClassIMG.BackColor = Color.FromArgb(165, 28, 48)
            OrgsLBL.BackColor = Color.FromArgb(97, 16, 29)
            OrgsIMG.BackColor = Color.FromArgb(97, 16, 29)
            HouseLBL.BackColor = Color.FromArgb(97, 16, 29)
            HouseIMG.BackColor = Color.FromArgb(97, 16, 29)
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles ClassSelector.Click
        If (MainPane.Controls.Contains(HClasses) = True) Then
        Else
            MainPane.Controls.Clear()
            MainPane.Controls.Add(HClasses)

            ClassSelector.Visible = True
            OrgsSelector.Visible = False
            HouseSelector.Visible = False

            ClassLBL.BackColor = Color.FromArgb(165, 28, 48)
            ClassIMG.BackColor = Color.FromArgb(165, 28, 48)
            OrgsLBL.BackColor = Color.FromArgb(97, 16, 29)
            OrgsIMG.BackColor = Color.FromArgb(97, 16, 29)
            HouseLBL.BackColor = Color.FromArgb(97, 16, 29)
            HouseIMG.BackColor = Color.FromArgb(97, 16, 29)
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles OrgsLBL.Click
        If (MainPane.Controls.Contains(HOrgs) = True) Then
        Else
            MainPane.Controls.Clear()
            MainPane.Controls.Add(HOrgs)

            ClassSelector.Visible = False
            OrgsSelector.Visible = True
            HouseSelector.Visible = False

            ClassLBL.BackColor = Color.FromArgb(97, 16, 29)
            ClassIMG.BackColor = Color.FromArgb(97, 16, 29)
            OrgsLBL.BackColor = Color.FromArgb(165, 28, 48)
            OrgsIMG.BackColor = Color.FromArgb(165, 28, 48)
            HouseLBL.BackColor = Color.FromArgb(97, 16, 29)
            HouseIMG.BackColor = Color.FromArgb(97, 16, 29)
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles OrgsSelector.Click
        If (MainPane.Controls.Contains(HOrgs) = True) Then
        Else
            MainPane.Controls.Clear()
            MainPane.Controls.Add(HOrgs)

            ClassSelector.Visible = False
            OrgsSelector.Visible = True
            HouseSelector.Visible = False

            ClassLBL.BackColor = Color.FromArgb(97, 16, 29)
            ClassIMG.BackColor = Color.FromArgb(97, 16, 29)
            OrgsLBL.BackColor = Color.FromArgb(165, 28, 48)
            OrgsIMG.BackColor = Color.FromArgb(165, 28, 48)
            HouseLBL.BackColor = Color.FromArgb(97, 16, 29)
            HouseIMG.BackColor = Color.FromArgb(97, 16, 29)
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles OrgsIMG.Click
        If (MainPane.Controls.Contains(HOrgs) = True) Then
        Else
            MainPane.Controls.Clear()
            MainPane.Controls.Add(HOrgs)

            ClassSelector.Visible = False
            OrgsSelector.Visible = True
            HouseSelector.Visible = False

            ClassLBL.BackColor = Color.FromArgb(97, 16, 29)
            ClassIMG.BackColor = Color.FromArgb(97, 16, 29)
            OrgsLBL.BackColor = Color.FromArgb(165, 28, 48)
            OrgsIMG.BackColor = Color.FromArgb(165, 28, 48)
            HouseLBL.BackColor = Color.FromArgb(97, 16, 29)
            HouseIMG.BackColor = Color.FromArgb(97, 16, 29)
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles HouseSelector.Click
        If (MainPane.Controls.Contains(HHouses) = True) Then
        Else
            MainPane.Controls.Clear()
            MainPane.Controls.Add(HHouses)

            ClassSelector.Visible = False
            OrgsSelector.Visible = False
            HouseSelector.Visible = True

            OrgsLBL.BackColor = Color.FromArgb(97, 16, 29)
            OrgsIMG.BackColor = Color.FromArgb(97, 16, 29)
            ClassLBL.BackColor = Color.FromArgb(97, 16, 29)
            ClassIMG.BackColor = Color.FromArgb(97, 16, 29)
            HouseLBL.BackColor = Color.FromArgb(165, 28, 48)
            HouseIMG.BackColor = Color.FromArgb(165, 28, 48)
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles HouseIMG.Click
        If (MainPane.Controls.Contains(HHouses) = True) Then
        Else
            MainPane.Controls.Clear()
            MainPane.Controls.Add(HHouses)

            ClassSelector.Visible = False
            OrgsSelector.Visible = False
            HouseSelector.Visible = True

            OrgsLBL.BackColor = Color.FromArgb(97, 16, 29)
            OrgsIMG.BackColor = Color.FromArgb(97, 16, 29)
            ClassLBL.BackColor = Color.FromArgb(97, 16, 29)
            ClassIMG.BackColor = Color.FromArgb(97, 16, 29)
            HouseLBL.BackColor = Color.FromArgb(165, 28, 48)
            HouseIMG.BackColor = Color.FromArgb(165, 28, 48)
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles HouseLBL.Click
        If (MainPane.Controls.Contains(HHouses) = True) Then
        Else
            MainPane.Controls.Clear()
            MainPane.Controls.Add(HHouses)

            ClassSelector.Visible = False
            OrgsSelector.Visible = False
            HouseSelector.Visible = True

            OrgsLBL.BackColor = Color.FromArgb(97, 16, 29)
            OrgsIMG.BackColor = Color.FromArgb(97, 16, 29)
            ClassLBL.BackColor = Color.FromArgb(97, 16, 29)
            ClassIMG.BackColor = Color.FromArgb(97, 16, 29)
            HouseLBL.BackColor = Color.FromArgb(165, 28, 48)
            HouseIMG.BackColor = Color.FromArgb(165, 28, 48)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (HKeyID.Text = "dartegnian.velarde@college.harvard.edu" And HKeyPass.Text <> "") Then
            MsgBox("You are logged in as student:" & vbCrLf & "" & vbCrLf & "Dartegnian Velarde" & vbCrLf & "Class of 2021" & vbCrLf & "Computer Science" & vbCrLf & "School of Engineering and Applied Sciences", , "Successfully Logged In")

        ElseIf (HKeyID.Text = "carmina.ambrocio@fas.harvard.edu" And HKeyPass.Text <> "") Then
            MsgBox("You are logged in as professor:" & vbCrLf & "" & vbCrLf & "Carmina Ambrocio" & vbCrLf & "English Professor" & vbCrLf & "Faculty of Arts and Sciences", , "Successfully Logged In")
        Else
            MsgBox("Please check your HarvardKey ID and password." & vbCrLf & "The accepted domains are:" & vbCrLf & "" & vbCrLf & "@college.harvard.edu" & vbCrLf & "@fas.harvard.edu" & vbCrLf & "@hbs.harvard.edu" & vbCrLf & "@hms.harvard.edu" & vbCrLf & "@hls.harvard.edu" & vbCrLf & "@hds.harvard.edu" & vbCrLf & "@seas.harvard.edu", , "Failed Log In")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim classPrice As Integer = Classes.GetClassesPrice()
        Dim orgsPrice As Integer = Organizations.GetOrgsPrice()
        Dim housePrice As Integer = Houses.GetHousePrice()
        Dim HarvardTuition As Integer
        HarvardTuition = classPrice + orgsPrice + housePrice
        OverallTuition.Text = "Overall Harvard Tuition:" & vbCrLf & "$" + HarvardTuition.ToString()
    End Sub

End Class