Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("D:\NewFile.txt", True)
        file.WriteLine("" & TextBox1.Text)
        file.WriteLine("" & TextBox2.Text)
        file.WriteLine("" & TextBox3.Text)
        file.Close()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("D:\NewFile.json", True)
        file.WriteLine("" & TextBox1.Text)
        file.WriteLine("" & TextBox2.Text)
        file.WriteLine("" & TextBox3.Text)
        file.Close()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("D:\NewFile.xml", True)
        file.WriteLine("" & TextBox1.Text)
        file.WriteLine("" & TextBox2.Text)
        file.WriteLine("" & TextBox3.Text)
        file.Close()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim frm As New Form1
        frm.Show()

        Me.Close()
    End Sub
End Class
