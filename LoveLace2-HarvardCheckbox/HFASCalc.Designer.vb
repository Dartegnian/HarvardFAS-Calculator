<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HFASCalc
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HFASCalc))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OverallTuition = New System.Windows.Forms.TextBox()
        Me.HouseLBL = New System.Windows.Forms.Label()
        Me.HouseIMG = New System.Windows.Forms.PictureBox()
        Me.HouseSelector = New System.Windows.Forms.PictureBox()
        Me.OrgsLBL = New System.Windows.Forms.Label()
        Me.OrgsIMG = New System.Windows.Forms.PictureBox()
        Me.OrgsSelector = New System.Windows.Forms.PictureBox()
        Me.ClassLBL = New System.Windows.Forms.Label()
        Me.ClassIMG = New System.Windows.Forms.PictureBox()
        Me.ClassSelector = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MainPane = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.HKeyID = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.HKeyPass = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.HouseIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HouseSelector, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrgsIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrgsSelector, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassSelector, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.OverallTuition)
        Me.Panel2.Controls.Add(Me.HouseLBL)
        Me.Panel2.Controls.Add(Me.HouseIMG)
        Me.Panel2.Controls.Add(Me.HouseSelector)
        Me.Panel2.Controls.Add(Me.OrgsLBL)
        Me.Panel2.Controls.Add(Me.OrgsIMG)
        Me.Panel2.Controls.Add(Me.OrgsSelector)
        Me.Panel2.Controls.Add(Me.ClassLBL)
        Me.Panel2.Controls.Add(Me.ClassIMG)
        Me.Panel2.Controls.Add(Me.ClassSelector)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(-4, 86)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(225, 574)
        Me.Panel2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(16, 422)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 34)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Compute"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'OverallTuition
        '
        Me.OverallTuition.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.OverallTuition.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OverallTuition.Font = New System.Drawing.Font("Segoe UI Light", 14.0!)
        Me.OverallTuition.ForeColor = System.Drawing.Color.White
        Me.OverallTuition.Location = New System.Drawing.Point(16, 462)
        Me.OverallTuition.Multiline = True
        Me.OverallTuition.Name = "OverallTuition"
        Me.OverallTuition.ReadOnly = True
        Me.OverallTuition.Size = New System.Drawing.Size(196, 81)
        Me.OverallTuition.TabIndex = 24
        Me.OverallTuition.Text = "Overall Harvard Tuition:"
        '
        'HouseLBL
        '
        Me.HouseLBL.AutoSize = True
        Me.HouseLBL.BackColor = System.Drawing.Color.Transparent
        Me.HouseLBL.Font = New System.Drawing.Font("Segoe UI Light", 21.0!, System.Drawing.FontStyle.Bold)
        Me.HouseLBL.ForeColor = System.Drawing.Color.White
        Me.HouseLBL.Location = New System.Drawing.Point(62, 234)
        Me.HouseLBL.Name = "HouseLBL"
        Me.HouseLBL.Size = New System.Drawing.Size(109, 38)
        Me.HouseLBL.TabIndex = 6
        Me.HouseLBL.Text = "Houses"
        '
        'HouseIMG
        '
        Me.HouseIMG.BackgroundImage = CType(resources.GetObject("HouseIMG.BackgroundImage"), System.Drawing.Image)
        Me.HouseIMG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HouseIMG.Location = New System.Drawing.Point(16, 234)
        Me.HouseIMG.Name = "HouseIMG"
        Me.HouseIMG.Size = New System.Drawing.Size(40, 40)
        Me.HouseIMG.TabIndex = 5
        Me.HouseIMG.TabStop = False
        '
        'HouseSelector
        '
        Me.HouseSelector.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.HouseSelector.Location = New System.Drawing.Point(3, 225)
        Me.HouseSelector.Name = "HouseSelector"
        Me.HouseSelector.Size = New System.Drawing.Size(225, 60)
        Me.HouseSelector.TabIndex = 9
        Me.HouseSelector.TabStop = False
        Me.HouseSelector.Visible = False
        '
        'OrgsLBL
        '
        Me.OrgsLBL.AutoSize = True
        Me.OrgsLBL.BackColor = System.Drawing.Color.Transparent
        Me.OrgsLBL.Font = New System.Drawing.Font("Segoe UI Light", 21.0!, System.Drawing.FontStyle.Bold)
        Me.OrgsLBL.ForeColor = System.Drawing.Color.White
        Me.OrgsLBL.Location = New System.Drawing.Point(62, 169)
        Me.OrgsLBL.Name = "OrgsLBL"
        Me.OrgsLBL.Size = New System.Drawing.Size(77, 38)
        Me.OrgsLBL.TabIndex = 4
        Me.OrgsLBL.Text = "Orgs"
        '
        'OrgsIMG
        '
        Me.OrgsIMG.BackgroundImage = CType(resources.GetObject("OrgsIMG.BackgroundImage"), System.Drawing.Image)
        Me.OrgsIMG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OrgsIMG.Location = New System.Drawing.Point(16, 169)
        Me.OrgsIMG.Name = "OrgsIMG"
        Me.OrgsIMG.Size = New System.Drawing.Size(40, 40)
        Me.OrgsIMG.TabIndex = 3
        Me.OrgsIMG.TabStop = False
        '
        'OrgsSelector
        '
        Me.OrgsSelector.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.OrgsSelector.Location = New System.Drawing.Point(0, 159)
        Me.OrgsSelector.Name = "OrgsSelector"
        Me.OrgsSelector.Size = New System.Drawing.Size(225, 60)
        Me.OrgsSelector.TabIndex = 8
        Me.OrgsSelector.TabStop = False
        Me.OrgsSelector.Visible = False
        '
        'ClassLBL
        '
        Me.ClassLBL.AutoSize = True
        Me.ClassLBL.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClassLBL.Font = New System.Drawing.Font("Segoe UI Light", 21.0!, System.Drawing.FontStyle.Bold)
        Me.ClassLBL.ForeColor = System.Drawing.Color.White
        Me.ClassLBL.Location = New System.Drawing.Point(62, 103)
        Me.ClassLBL.Name = "ClassLBL"
        Me.ClassLBL.Size = New System.Drawing.Size(108, 38)
        Me.ClassLBL.TabIndex = 2
        Me.ClassLBL.Text = "Classes"
        '
        'ClassIMG
        '
        Me.ClassIMG.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClassIMG.BackgroundImage = CType(resources.GetObject("ClassIMG.BackgroundImage"), System.Drawing.Image)
        Me.ClassIMG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClassIMG.Location = New System.Drawing.Point(16, 103)
        Me.ClassIMG.Name = "ClassIMG"
        Me.ClassIMG.Size = New System.Drawing.Size(40, 40)
        Me.ClassIMG.TabIndex = 1
        Me.ClassIMG.TabStop = False
        '
        'ClassSelector
        '
        Me.ClassSelector.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClassSelector.Location = New System.Drawing.Point(0, 93)
        Me.ClassSelector.Name = "ClassSelector"
        Me.ClassSelector.Size = New System.Drawing.Size(225, 60)
        Me.ClassSelector.TabIndex = 7
        Me.ClassSelector.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 28.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 51)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menu"
        '
        'MainPane
        '
        Me.MainPane.Location = New System.Drawing.Point(227, 95)
        Me.MainPane.Name = "MainPane"
        Me.MainPane.Size = New System.Drawing.Size(855, 534)
        Me.MainPane.TabIndex = 2
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(16, 17)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(262, 57)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.HKeyID)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.HKeyPass)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Location = New System.Drawing.Point(-4, -5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1103, 94)
        Me.Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 14.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(616, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 25)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "HarvardKey ID"
        '
        'HKeyID
        '
        Me.HKeyID.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.HKeyID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HKeyID.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.HKeyID.ForeColor = System.Drawing.Color.White
        Me.HKeyID.Location = New System.Drawing.Point(621, 50)
        Me.HKeyID.Multiline = True
        Me.HKeyID.Name = "HKeyID"
        Me.HKeyID.Size = New System.Drawing.Size(169, 25)
        Me.HKeyID.TabIndex = 29
        Me.HKeyID.WordWrap = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Light", 14.0!)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(799, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 25)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Password"
        '
        'HKeyPass
        '
        Me.HKeyPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.HKeyPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HKeyPass.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.HKeyPass.ForeColor = System.Drawing.Color.White
        Me.HKeyPass.Location = New System.Drawing.Point(804, 50)
        Me.HKeyPass.Multiline = True
        Me.HKeyPass.Name = "HKeyPass"
        Me.HKeyPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.HKeyPass.Size = New System.Drawing.Size(169, 25)
        Me.HKeyPass.TabIndex = 27
        Me.HKeyPass.WordWrap = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(986, 17)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 58)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Log In"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'HFASCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1094, 641)
        Me.Controls.Add(Me.MainPane)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "HFASCalc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Harvard Faculty of Arts and Sciences Student Calculator"
        Me.TopMost = True
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.HouseIMG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HouseSelector, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrgsIMG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrgsSelector, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassIMG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassSelector, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MainPane As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents HouseLBL As Label
    Friend WithEvents HouseIMG As PictureBox
    Friend WithEvents OrgsLBL As Label
    Friend WithEvents OrgsIMG As PictureBox
    Friend WithEvents ClassLBL As Label
    Friend WithEvents ClassIMG As PictureBox
    Friend WithEvents HouseSelector As PictureBox
    Friend WithEvents OrgsSelector As PictureBox
    Friend WithEvents ClassSelector As PictureBox
    Friend WithEvents OverallTuition As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents HKeyID As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents HKeyPass As TextBox
End Class
