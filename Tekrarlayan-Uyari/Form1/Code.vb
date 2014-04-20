Public Class Form1
    Dim ilkzaman, sonzaman As String
    Dim bipsayisi As Integer = 0
    Dim fareX, fareY As Integer
    Dim ekranX, ekranY As Integer
    Dim gorunurluk As Boolean = 1
    Dim locX As Integer = Me.Location.X
    Dim locY As Integer = Me.Location.Y
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Uygulamanın "enter" ile seçilecek butonu atandı
        Me.AcceptButton = Button1
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'Sabit ve ayarlanan saat azalan saate aktarıldı
        NumericUpDown6.Value = NumericUpDown1.Value
        NumericUpDown5.Value = NumericUpDown2.Value
        NumericUpDown4.Value = NumericUpDown3.Value
        'Timer1 başlatıldı 
        Timer1.Start()
        If Form2.CheckBox5.Checked = True Then 'Gerisayım başladığında beni köşeye gönder Checkbox ı
            fareX = MousePosition.X
            fareY = MousePosition.Y
            Cursor.Position = New System.Drawing.Point(99999, 99999)
            ekranX = MousePosition.X
            ekranY = MousePosition.Y
            Cursor.Position = New System.Drawing.Point(fareX, fareY)
            Me.Location = New System.Drawing.Point(ekranX - 312, ekranY - 120)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ilkzaman = Date.Now
        If sonzaman <> ilkzaman Then 'Her 1 saniye geçtiğinde yapılacak aksiyon
            sonzaman = ilkzaman
            If NumericUpDown4.Value > 0 Then
                NumericUpDown4.Value = NumericUpDown4.Value - 1
            Else
                If NumericUpDown5.Value > 0 Then
                    NumericUpDown5.Value = NumericUpDown5.Value - 1
                    NumericUpDown4.Value = 59
                Else
                    If NumericUpDown6.Value > 0 Then
                        NumericUpDown6.Value = NumericUpDown6.Value - 1
                        NumericUpDown5.Value = 59
                        NumericUpDown4.Value = 59
                    Else
                        'ZAMAN DOLDU
                        If Form2.CheckBox4.Checked = True Then
                            Me.Show()
                            gorunurluk = True
                        End If
                        If Form2.CheckBox6.Checked = True Then
                        Else
                            Me.Show()
                            locX = Me.Location.X
                            locY = Me.Location.Y
                        End If
                        fareX = MousePosition.X
                        fareY = MousePosition.Y
                        Cursor.Position = New System.Drawing.Point(99999, 99999)
                        ekranX = MousePosition.X
                        ekranY = MousePosition.Y
                        Cursor.Position = New System.Drawing.Point(fareX, fareY)
                        If bipsayisi >= 4 Then 'Kaç kere bipleneceği
                            bipsayisi = 0
                            If Form2.CheckBox3.Checked = True Then 'Saati otomatik kur
                                Button1.PerformClick()
                                If Form2.CheckBox6.Checked = True Then
                                Else
                                    Me.Visible = True
                                End If
                                If Form2.CheckBox5.Checked = True Then 'Gerisayım başladığında beni köşeye gönder Checkbox ı
                                    Me.Location = New System.Drawing.Point(ekranX - 312, ekranY - 120)
                                End If
                            Else
                                If Form2.CheckBox6.Checked = True Then
                                Else
                                    Me.Visible = True
                                End If
                                Timer1.Stop()
                            End If
                            If gorunurluk = 0 Then
                                Me.Hide()
                            End If
                            Me.TopMost = False
                        Else
                            If Form2.CheckBox2.Checked = True Then
                                Beep()
                                bipsayisi = bipsayisi + 1
                                If gorunurluk = 0 Then
                                    Me.Show()
                                    Me.Location = New System.Drawing.Point(99312, 999120)
                                    Me.ShowInTaskbar = False
                                End If
                            Else
                                'bipsayisi = 5
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        If Me.CanFocus = True Then
            Me.Hide()
            gorunurluk = 0
        Else
            Me.Show()
            gorunurluk = 1
            TopMost = True
            If Form2.CheckBox1.Checked = False Then
                TopMost = False
            End If
            Me.Location = New System.Drawing.Point((ekranX / 2) - 156, (ekranY / 2) - 60)
            Me.ShowInTaskbar = True
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Form2.Show()
        If Me.TopMost = True Then
            Form2.TopMost = True
        Else
            Form2.TopMost = True
            Form2.TopMost = False
        End If
    End Sub
End Class
