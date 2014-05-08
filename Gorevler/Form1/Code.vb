Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    'Timer1 fareyle progressbar ların üstüne gelince progressbar ların doluluğunu göstermektedir
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Me.ToolTip1.SetToolTip(Me.ProgressBar1, ProgressBar1.Value)
        Me.ToolTip1.SetToolTip(Me.ProgressBar2, ProgressBar2.Value)
        Me.ToolTip1.SetToolTip(Me.ProgressBar3, ProgressBar3.Value)
        Me.ToolTip1.SetToolTip(Me.ProgressBar4, ProgressBar4.Value)
        Me.ToolTip1.SetToolTip(Me.ProgressBar5, ProgressBar5.Value)
        Me.ToolTip1.SetToolTip(Me.ProgressBar6, ProgressBar6.Value)
        Me.ToolTip1.SetToolTip(Me.ProgressBar7, ProgressBar7.Value)
        Me.ToolTip1.SetToolTip(Me.ProgressBar8, ProgressBar8.Value)
        Me.ToolTip1.SetToolTip(Me.ProgressBar9, ProgressBar9.Value)
        Me.ToolTip1.SetToolTip(Me.ProgressBar10, ProgressBar10.Value)

    End Sub
    'Deger kaç tane görev yazıldıysa o kadar görevin progressbar ortalamasını alıp genel progresbar değerini hesaplar
    Private Sub Deger()
        If TextBox9.Text = "" Then
            ProgressBar1.Value = (ProgressBar2.Value + ProgressBar3.Value + ProgressBar4.Value + ProgressBar5.Value + ProgressBar6.Value + ProgressBar7.Value + ProgressBar8.Value + ProgressBar9.Value) / 8
            If TextBox8.Text = "" Then
                ProgressBar1.Value = (ProgressBar2.Value + ProgressBar3.Value + ProgressBar4.Value + ProgressBar5.Value + ProgressBar6.Value + ProgressBar7.Value + ProgressBar8.Value) / 7
                If TextBox7.Text = "" Then
                    ProgressBar1.Value = (ProgressBar2.Value + ProgressBar3.Value + ProgressBar4.Value + ProgressBar5.Value + ProgressBar6.Value + ProgressBar7.Value) / 6
                    If TextBox6.Text = "" Then
                        ProgressBar1.Value = (ProgressBar2.Value + ProgressBar3.Value + ProgressBar4.Value + ProgressBar5.Value + ProgressBar6.Value) / 5
                        If TextBox5.Text = "" Then
                            ProgressBar1.Value = (ProgressBar2.Value + ProgressBar3.Value + ProgressBar4.Value + ProgressBar5.Value) / 4
                            If TextBox4.Text = "" Then
                                ProgressBar1.Value = (ProgressBar2.Value + ProgressBar3.Value + ProgressBar4.Value) / 3
                                If TextBox3.Text = "" Then
                                    ProgressBar1.Value = (ProgressBar2.Value + ProgressBar3.Value) / 2
                                    If TextBox2.Text = "" Then
                                        ProgressBar1.Value = ProgressBar2.Value
                                        If TextBox1.Text = "" Then
                                            ProgressBar1.Value = 0
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Else
            ProgressBar1.Value = (ProgressBar2.Value + ProgressBar3.Value + ProgressBar4.Value + ProgressBar5.Value + ProgressBar6.Value + ProgressBar7.Value + ProgressBar8.Value + ProgressBar9.Value + ProgressBar10.Value) / 9
        End If
    End Sub
    'Progressbar2 NumericUpDown1 e karşılık gelir bunun sebebi ana progressbar ın progressbar1 olmasıdır
    'Bu Bu şekilde kayma ile devameder
    'Progressbar lar değerlerini numericupdown lardan alır
    Private Sub NumericUpDown1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        ProgressBar2.Value = NumericUpDown1.Value
        Call Deger()
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NumericUpDown2.ValueChanged
        ProgressBar3.Value = NumericUpDown2.Value
        Call Deger()
    End Sub

    Private Sub NumericUpDown3_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NumericUpDown3.ValueChanged
        ProgressBar4.Value = NumericUpDown3.Value
        Call Deger()
    End Sub

    Private Sub NumericUpDown4_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NumericUpDown4.ValueChanged
        ProgressBar5.Value = NumericUpDown4.Value
        Call Deger()
    End Sub

    Private Sub NumericUpDown5_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NumericUpDown5.ValueChanged
        ProgressBar6.Value = NumericUpDown5.Value
        Call Deger()
    End Sub

    Private Sub NumericUpDown6_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NumericUpDown6.ValueChanged
        ProgressBar7.Value = NumericUpDown6.Value
        Call Deger()
    End Sub

    Private Sub NumericUpDown7_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NumericUpDown7.ValueChanged
        ProgressBar8.Value = NumericUpDown7.Value
        Call Deger()
    End Sub

    Private Sub NumericUpDown8_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NumericUpDown8.ValueChanged
        ProgressBar9.Value = NumericUpDown8.Value
        Call Deger()
    End Sub

    Private Sub NumericUpDown9_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NumericUpDown9.ValueChanged
        ProgressBar10.Value = NumericUpDown9.Value
        Call Deger()
    End Sub
    'progressbar ların değerlerinin progressbar lara tıklandıktan sonra mouse topu ile değiştirebilmek için
    'odaklanılan obje tıklanılan progressbar ın ilgili numericupdown u seçilir
    'Progressbar2 NumericUpDown1 e karşılık gelir bunun sebebi ana progressbar ın progressbar1 olmasıdır
    'Bu Bu şekilde kayma ile devameder
    Private Sub ProgressBar2_Click(sender As System.Object, e As System.EventArgs) Handles ProgressBar2.Click
        NumericUpDown1.Focus()
    End Sub

    Private Sub ProgressBar3_Click(sender As System.Object, e As System.EventArgs) Handles ProgressBar3.Click
        NumericUpDown2.Focus()
    End Sub

    Private Sub ProgressBar4_Click(sender As System.Object, e As System.EventArgs) Handles ProgressBar4.Click
        NumericUpDown3.Focus()
    End Sub

    Private Sub ProgressBar5_Click(sender As System.Object, e As System.EventArgs) Handles ProgressBar5.Click
        NumericUpDown4.Focus()
    End Sub

    Private Sub ProgressBar6_Click(sender As System.Object, e As System.EventArgs) Handles ProgressBar6.Click
        NumericUpDown5.Focus()
    End Sub

    Private Sub ProgressBar7_Click(sender As System.Object, e As System.EventArgs) Handles ProgressBar7.Click
        NumericUpDown6.Focus()
    End Sub

    Private Sub ProgressBar8_Click(sender As System.Object, e As System.EventArgs) Handles ProgressBar8.Click
        NumericUpDown7.Focus()
    End Sub

    Private Sub ProgressBar9_Click(sender As System.Object, e As System.EventArgs) Handles ProgressBar9.Click
        NumericUpDown8.Focus()
    End Sub

    Private Sub ProgressBar10_Click(sender As System.Object, e As System.EventArgs) Handles ProgressBar10.Click
        NumericUpDown9.Focus()
    End Sub
End Class
