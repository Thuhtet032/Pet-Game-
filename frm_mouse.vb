Imports System.IO
Imports System.Reflection.Emit

Public Class frm_mouse
    Dim pet_name As String
    Dim time_interval As Integer = 2000
    Dim Hunger As Integer = 0
    Dim Energy As Integer = 100
    Dim Boredom As Integer = 0
    Dim health As Integer = 100
    Dim Selectedpet As String



    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click

        pet_name = InputBox("Enter Your Pet Name")
        If String.IsNullOrEmpty(pet_name) Then
            MessageBox.Show("Pet name cannot be empty! Please enter a valid pet name.")
            Return
        End If

        ' Set the pet name and initialize pet stats
        txt_name.Text = pet_name
        MessageBox.Show("Pet " & pet_name & " has been created!")
        txt_boredom.Text = Boredom.ToString()
        txt_hunger.Text = Hunger.ToString()
        txt_energy.Text = Energy.ToString()
        txt_health.Text = health.ToString()

        Display()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Timer1.Interval = time_interval
        time_interval = time_interval - 1
        txt_time.Text = time_interval.ToString()

        If health > 0 Then health -= 1
        If Hunger < 100 Then Hunger += 1
        If Boredom < 100 Then Boredom += 1
        If Energy > 0 Then Energy -= 1

        txt_health.Text = health.ToString()
        txt_hunger.Text = Hunger.ToString()
        txt_boredom.Text = Boredom.ToString()
        txt_energy.Text = Energy.ToString()

        ' Check Conditions
        If health <= 0 Or Energy <= 0 Then
            Timer1.Stop()
            MessageBox.Show($"Your pet {pet_name} has died!")
            MessageBox.Show("You can add new pet!")
            Form1.Show()
            Me.Hide()
            restart()
        ElseIf Hunger >= 100 Or Boredom >= 100 Then
            Timer1.Stop()
            MessageBox.Show($"Your pet {pet_name} has run away!")
            MessageBox.Show("You can add new pet!")
            Form1.Show()
            Me.Hide()
            restart()
        End If
        'energy
        If Energy = 50 Then
            MessageBox.Show("Your Pet Energy  tire!Need to sleep")
            btn_sleep.Visible = True
        End If

        'boredom
        If Boredom = 70 Then
            MessageBox.Show("Your pet is bored!")

        End If

        ' hunger
        If Hunger = 50 Then
            MessageBox.Show("Your pet is hungry!")

        End If

        '  health
        If health = 20 Then
            MessageBox.Show("Your pet is near death!")

        End If
    End Sub
    Private Sub btn_play_Click(sender As Object, e As EventArgs) Handles btn_play.Click
        If Boredom > 0 Then
            Boredom = Math.Max(0, Boredom - 10)
            txt_boredom.Text = Boredom.ToString()
        Else
            MessageBox.Show("Your pet is already happy!")
        End If

    End Sub
    Private Sub btn_feed_Click(sender As Object, e As EventArgs) Handles btn_feed.Click
        If Hunger > 0 Then
            Hunger = Math.Max(0, Hunger - 10)
            txt_hunger.Text = Hunger.ToString()
        Else
            MessageBox.Show("Your pet is not hungry!")
        End If
    End Sub
    Private Sub frm_mouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000

    End Sub
    Private Sub btn_love_Click(sender As Object, e As EventArgs) Handles btn_love.Click
        If health < 100 Then
            health = Math.Min(100, health + 10)

            txt_health.Text = health.ToString()

        Else
            MessageBox.Show("Your pet is already at full health!")
        End If
    End Sub
    Private Sub btn_sleep_Click(sender As Object, e As EventArgs) Handles btn_sleep.Click
        If Energy < 100 Then
            Energy = Math.Min(100, Energy + 10)
            health = Math.Min(100, health + 10)
            txt_energy.Text = Energy.ToString()
            txt_health.Text = health.ToString()

        End If
    End Sub
    Private Sub btn_newpet_Click(sender As Object, e As EventArgs) Handles btn_newpet.Click
        Form1.Show()
        Me.Hide()
        restart()
    End Sub
    Sub restart()
        pet_name = ""
        Hunger = 0
        Energy = 100
        Boredom = 0
        health = 100

        pb_m.Visible = True
        btn_start.Visible = True
        btn_cancel.Visible = True
        btn_load.Visible = True
        btn_sleep.Visible = False
        rtxt_menu.Visible = False
        btn_save.Visible = False
        pb_mouse.Visible = False
        btn_play.Visible = False
        btn_feed.Visible = False
        btn_love.Visible = False
        btn_newpet.Visible = False
        btn_exit.Visible = False
        lbl_boredom.Visible = False
        lbl_name.Visible = False
        lbl_hunger.Visible = False
        lbl_energy.Visible = False
        lbl_time.Visible = False
        lbl_health.Visible = False
        txt_name.Visible = False
        txt_boredom.Visible = False
        txt_hunger.Visible = False
        txt_energy.Visible = False
        txt_time.Visible = False
        txt_health.Visible = False

    End Sub
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        ' if pet_name is provided
        If String.IsNullOrEmpty(pet_name) Then
            MessageBox.Show("Please create a pet first!")
            Return
        End If

        ' select a pet type
        Dim petType As String = Form1.type


        ' Define the folder and file path 
        Dim folderPath As String = Application.StartupPath & "\PetSaves\" & petType
        Dim filePath As String = Path.Combine(folderPath, $"pet_{pet_name}.txt")

        ' Create the folder if it doesn't exist
        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
        End If

        ' Save the current pet data 
        Using writer As New StreamWriter(filePath)
            writer.WriteLine("PetType=" & petType)
            writer.WriteLine("PetName=" & pet_name)
            writer.WriteLine("Boredom=" & Boredom)
            writer.WriteLine("Hunger=" & Hunger)
            writer.WriteLine("Energy=" & Energy)
            writer.WriteLine("Health=" & health)
        End Using

        MessageBox.Show($"Pet data for {pet_name} ({petType}) saved successfully!")
    End Sub

    Private Sub btn_load_Click(sender As Object, e As EventArgs) Handles btn_load.Click

        Dim petTypeToLoad As String = Form1.type


        Dim petNameToLoad As String = InputBox("Enter the name of the pet to load:")
        If String.IsNullOrEmpty(petNameToLoad) Then
            MessageBox.Show("Please enter a valid pet name!")
            Return
        End If

        ' Define the folder and file path for the selected pet
        Dim folderPath As String = Application.StartupPath & "\PetSaves\" & petTypeToLoad
        Dim filePath As String = Path.Combine(folderPath, $"pet_{petNameToLoad}.txt")

        ' Check if the save file exists
        If File.Exists(filePath) Then
            ' Load the pet data from the file
            Using reader As New StreamReader(filePath)
                Dim isCorrectPetType As Boolean = False
                Dim isCorrectPetName As Boolean = False

                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    Dim parts As String() = line.Split("="c)
                    If parts.Length = 2 Then
                        Select Case parts(0)
                            Case "PetType"
                                isCorrectPetType = (parts(1).ToLower() = petTypeToLoad.ToLower())
                            Case "PetName"
                                isCorrectPetName = (parts(1).ToLower() = petNameToLoad.ToLower())
                                If isCorrectPetName Then pet_name = parts(1)
                            Case "Boredom"
                                Boredom = Convert.ToInt32(parts(1))
                                txt_boredom.Text = Boredom.ToString()
                            Case "Hunger"
                                Hunger = Convert.ToInt32(parts(1))
                                txt_hunger.Text = Hunger.ToString()
                            Case "Energy"
                                Energy = Convert.ToInt32(parts(1))
                                txt_energy.Text = Energy.ToString()
                            Case "Health"
                                health = Convert.ToInt32(parts(1))
                                txt_health.Text = health.ToString()
                        End Select
                    End If
                End While

                ' Ensure the pet type and name match before proceeding
                If isCorrectPetType AndAlso isCorrectPetName Then
                    txt_name.Text = pet_name
                    MessageBox.Show($"Pet data for {pet_name} ({petTypeToLoad}) loaded successfully!")
                    Display()
                Else
                    MessageBox.Show($"No matching pet found for {petNameToLoad} ({petTypeToLoad}).")
                End If
            End Using
        Else
            ' Start a new game if no save file exists
            MessageBox.Show($"No save file found for {petNameToLoad} ({petTypeToLoad}). Starting a new game.")
            btn_start.PerformClick()
        End If
    End Sub

    Private Sub pb_m_Click(sender As Object, e As EventArgs) Handles pb_m.Click

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Application.Exit()
    End Sub
    Sub Display()
        pb_m.Visible = False
        btn_start.Visible = False
        btn_cancel.Visible = False
        btn_load.Visible = False
        rtxt_menu.Visible = True
        btn_save.Visible = True
        pb_mouse.Visible = True
        btn_play.Visible = True
        btn_feed.Visible = True
        btn_love.Visible = True
        btn_newpet.Visible = True
        btn_exit.Visible = True
        'btn_sleep.Visible = True
        lbl_name.Visible = True
        lbl_boredom.Visible = True
        lbl_hunger.Visible = True
        lbl_energy.Visible = True
        lbl_time.Visible = True
        lbl_health.Visible = True
        txt_name.Visible = True
        txt_boredom.Visible = True
        txt_hunger.Visible = True
        txt_energy.Visible = True
        txt_time.Visible = True
        txt_health.Visible = True

        Timer1.Start()
    End Sub
End Class