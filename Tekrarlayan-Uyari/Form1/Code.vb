Public Class Form1
    Dim ilkzaman, sonzaman As String
    Dim bipsayisi As Integer = 0
    Dim fareX, fareY As Integer
    Dim ekranX, ekranY As Integer
    Dim gorunurluk As Boolean = 1
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
                        Me.TopMost = True
                        Me.Show()
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
                                If Form2.CheckBox5.Checked = True Then 'Gerisayım başladığında beni köşeye gönder Checkbox ı
                                    Me.Location = New System.Drawing.Point(ekranX - 312, ekranY - 120)
                                End If
                            Else
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
                            Else
                                bipsayisi = 5
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        If Me.CanFocus Then
            Me.Hide()
            gorunurluk = 0
        Else
            Me.Show()
            gorunurluk = 1
            TopMost = True
            TopMost = False
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
