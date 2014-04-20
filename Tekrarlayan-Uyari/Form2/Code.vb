Public Class Form2
    Dim tiklanan_nokta As Point

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
    End Sub
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        'Farenin tiklandigi noktadaki koordinatlarini alir 
        tiklanan_nokta = New Point(e.X, e.Y)
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        'Sol tus basili olarak hareket ettiriliyorsa formu tasir 
        If e.Button = MouseButtons.Left Then
            Dim Koordinatlar As Point
            Koordinatlar = Control.MousePosition
            Koordinatlar.Offset(-tiklanan_nokta.X, -tiklanan_nokta.Y)
            Me.Location = Koordinatlar
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckStateChanged(sender As Object, e As System.EventArgs) Handles CheckBox1.CheckStateChanged
        If CheckBox1.Checked Then
            Form1.TopMost = True
            Me.TopMost = True
        Else
            Form1.TopMost = False
            Me.TopMost = False
        End If
    End Sub

    Private Sub CheckBox2_CheckStateChanged(sender As Object, e As System.EventArgs) Handles CheckBox2.CheckStateChanged
        If CheckBox2.Checked = False Then
            CheckBox6.Checked = False
        End If
    End Sub

    Private Sub CheckBox6_CheckStateChanged(sender As Object, e As System.EventArgs) Handles CheckBox6.CheckStateChanged
        If CheckBox6.Checked = True Then
            CheckBox2.Checked = True
        End If
    End Sub
End Class
