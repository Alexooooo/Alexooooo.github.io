Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer10.Enabled = False
        Button1.BackColor = Color.White
        Button2.BackColor = Color.White
        Button3.BackColor = Color.White
        Button4.BackColor = Color.White
        Button5.BackColor = Color.Red
        Button6.BackColor = Color.White
        Button7.BackColor = Color.Red
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer1.Enabled = False
        Button1.BackColor = Color.Red
        Button2.BackColor = Color.Red
        Button3.BackColor = Color.Red
        Button4.BackColor = Color.White
        Button5.BackColor = Color.Red
        Button6.BackColor = Color.Red
        Button7.BackColor = Color.White
        Timer3.Enabled = True
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer2.Enabled = False
        Button1.BackColor = Color.Red
        Button2.BackColor = Color.Red
        Button3.BackColor = Color.Red
        Button4.BackColor = Color.White
        Button5.BackColor = Color.Red
        Button6.BackColor = Color.White
        Button7.BackColor = Color.Red
        Timer4.Enabled = True
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Timer3.Enabled = False
        Button1.BackColor = Color.White
        Button2.BackColor = Color.Red
        Button3.BackColor = Color.White
        Button4.BackColor = Color.Red
        Button5.BackColor = Color.Red
        Button6.BackColor = Color.White
        Button7.BackColor = Color.Red
        Timer5.Enabled = True
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Timer4.Enabled = False
        Button1.BackColor = Color.Red
        Button2.BackColor = Color.Red
        Button3.BackColor = Color.Red
        Button4.BackColor = Color.Red
        Button5.BackColor = Color.White
        Button6.BackColor = Color.White
        Button7.BackColor = Color.Red
        Timer6.Enabled = True
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Timer5.Enabled = False
        Button1.BackColor = Color.Red
        Button2.BackColor = Color.Red
        Button3.BackColor = Color.Red
        Button4.BackColor = Color.Red
        Button5.BackColor = Color.White
        Button6.BackColor = Color.Red
        Button7.BackColor = Color.Red
        Timer7.Enabled = True
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        Timer6.Enabled = False
        Button1.BackColor = Color.Red
        Button2.BackColor = Color.White
        Button3.BackColor = Color.White
        Button4.BackColor = Color.White
        Button5.BackColor = Color.Red
        Button6.BackColor = Color.White
        Button7.BackColor = Color.Red
        Timer8.Enabled = True
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        Timer7.Enabled = False
        Button1.BackColor = Color.Red
        Button2.BackColor = Color.Red
        Button3.BackColor = Color.Red
        Button4.BackColor = Color.Red
        Button5.BackColor = Color.Red
        Button6.BackColor = Color.Red
        Button7.BackColor = Color.Red
        Timer9.Enabled = True
    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        Timer8.Enabled = False
        Button1.BackColor = Color.Red
        Button2.BackColor = Color.Red
        Button3.BackColor = Color.Red
        Button4.BackColor = Color.Red
        Button5.BackColor = Color.Red
        Button6.BackColor = Color.White
        Button7.BackColor = Color.Red
        Timer10.Enabled = True
    End Sub

    Private Sub Timer10_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick
        Timer9.Enabled = False
        Button1.BackColor = Color.Red
        Button2.BackColor = Color.Red
        Button3.BackColor = Color.Red
        Button4.BackColor = Color.Red
        Button5.BackColor = Color.Red
        Button6.BackColor = Color.White
        Button7.BackColor = Color.Red
        Timer1.Enabled = True
    End Sub
End Class
