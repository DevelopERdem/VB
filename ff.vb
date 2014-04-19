Public Class GameScreen
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Location = New Drawing.Point(300, Int(Rnd() * 184))
        Button7.SendToBack()
        Dim ykskskr, skr As String
        Label5.Text = 3
        Timer7.Start()
        Dim dicerigi As Integer = My.Computer.FileSystem.ReadAllText("C:\Users\Developer\Desktop\yuksekrekor.kp")
        ykskskr = dicerigi
        Label6.Text = ykskskr
        ' Dim a As Integer
        ' a = TextBox1.Text
        ' Do Until a > 473906
        'TextBox1.Text = a + 1
        ' a = TextBox1.Text
        ' Loop
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        'OYUNU BAŞLAT
        Dim oyunsayisi As Integer = My.Computer.FileSystem.ReadAllText("C:\Users\Developer\Desktop\oyunsayisi.kp")
        Dim os2 As Integer = My.Computer.FileSystem.ReadAllText("C:\Users\Developer\Desktop\oyunsayisi2.kp")
        Do Until oyunsayisi < os2
            PictureBox1.Location = New Drawing.Point(300, Int(Rnd() * 184))
            My.Computer.FileSystem.WriteAllText("C:\Users\Developer\Desktop\oyunsayisi2.kp", String.Intern(os2 + 1), False)
            os2 = My.Computer.FileSystem.ReadAllText("C:\Users\Developer\Desktop\oyunsayisi2.kp")
        Loop
        Timer1.Start()
        Button2.Visible = False
        Timer3.Start()
        Timer4.Start()
        Timer5.Start()
        Timer6.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        'MAVİ KUTU AŞAĞI
        Dim x, y As Integer
        x = picturebox2.Location.X
        y = picturebox2.Location.Y + 2
        PictureBox2.Location = New Drawing.Point(x, y)
        PictureBox2.Focus()
        PictureBox2.Select()
    End Sub

    Private Sub picturebox2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles PictureBox2.KeyPress
        'MAVİ YUKARI ÇIKARMA TIKLANDI
        Timer2.Start()
        Label1.Text = 0
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        'MAVİ KUTU YUKARIYA ÇIKMA
        Dim x, y, t2 As Integer
        x = picturebox2.Location.X
        y = picturebox2.Location.Y
        t2 = Label1.Text
        Label1.Text = t2 + 1
        picturebox2.Location = New Drawing.Point(x, y - 5)
        If t2 > 20 Then
            Label1.Text = 0
            Timer2.Stop()
        End If
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        ' YEŞİL KUTU YÜKSEKLİK
        If Label2.Text = 0 Then
            Dim y, x As Integer
            x = PictureBox1.Location.X
            y = PictureBox1.Location.Y - 1
            Label2.Text = y
            PictureBox1.Location = New Drawing.Point(x, y)
        End If
    End Sub

    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick
        Dim ykskskr, skr As Integer
        'YEŞİL KUTU  GERİ
        Dim y, x As Integer
        x = PictureBox1.Location.X
        y = PictureBox1.Location.Y
        PictureBox1.Location = New Drawing.Point(x - 5, y)
        If x < -10 Then                'OYUN BİTTİ
            'x = -10
            Dim oyunsayisi As Integer = My.Computer.FileSystem.ReadAllText("C:\Users\Developer\Desktop\oyunsayisi.kp")
            My.Computer.FileSystem.WriteAllText("C:\Users\Developer\Desktop\oyunsayisi.kp", String.Intern(oyunsayisi + Label3.Text), False)
            Dim dicerigi As Integer = My.Computer.FileSystem.ReadAllText("C:\Users\Developer\Desktop\yuksekrekor.kp")
            ykskskr = dicerigi
            Label6.Text = ykskskr
            skr = Label3.Text
            If ykskskr < skr Then
                My.Computer.FileSystem.WriteAllText("C:\Users\Developer\Desktop\yuksekrekor.kp", String.Intern(skr), False)
            End If
            Label7.Visible = True
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            Timer4.Stop()
            Timer5.Stop()
            Timer6.Stop()
            Timer7.Stop()
            Button7.Focus()
            Button7.Select()
            Exit Sub

            'PictureBox1.Location = New Drawing.Point(300, Int(Rnd() * 184))

            ' Dim a As Integer
            ' a = Label4.Text
            'Label4.Text = a + 1
        End If
    End Sub

    Private Sub Timer5_Tick(sender As System.Object, e As System.EventArgs) Handles Timer5.Tick
        'MAVİ, YEŞİL KONTROL
        If PictureBox2.Left - 30 < PictureBox1.Left < PictureBox2.Left + 50 Then
            If PictureBox1.Left < PictureBox2.Left + 50 Then
                If PictureBox2.Top - 30 < PictureBox1.Top Then
                    If PictureBox1.Top < PictureBox2.Top + 50 Then
                        PictureBox1.Location = New Drawing.Point(300, Int(Rnd() * 184))
                        Dim a As Integer
                        a = Label3.Text
                        Label3.Text = a + 1
                        Beep()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Timer6_Tick(sender As System.Object, e As System.EventArgs) Handles Timer6.Tick
        Dim oyunsayisi As Integer = My.Computer.FileSystem.ReadAllText("C:\Users\Developer\Desktop\oyunsayisi.kp")
        ' PictureBox1.Location = New Drawing.Point(300, Int(Rnd() * oyunsayisi))
        Dim a As Integer = 0
        If a < oyunsayisi Then
            Do Until a < oyunsayisi
                PictureBox1.Location = New Drawing.Point(300, Int(Rnd() * 184))
                a = a + 1
            Loop
        Else
            ' PictureBox1.Location = New Drawing.Point(300, Int(Rnd() * 184))
        End If
    End Sub

    Private Sub Timer7_Tick(sender As System.Object, e As System.EventArgs) Handles Timer7.Tick
        Dim a As Integer
        a = Label5.Text
        Label5.Text = a - 1
        If Label5.Text = 0 Then
            Label5.Visible = False
            Button2.Select()
            Timer6.Start()
            SendKeys.Send(" ")
            Timer7.Stop()
        End If
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        'Dim ykskskr, skr As String
        ' Dim dicerigi As String = My.Computer.FileSystem.ReadAllText("C:\Users\Developer\Desktop\yuksekrekor.txt")
        ' ykskskr = dicerigi
        'skr = Label3.Text
        ' If ykskskr < skr Then
        'My.Computer.FileSystem.WriteAllText("C:\Users\Developer\Desktop\yuksekrekor.txt", String.Intern(skr), False)
        ' End If

        Application.Restart()
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Shop.Show()
    End Sub
End Class
