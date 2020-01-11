Public Class Form1
    Private Sub SplitContainer1_SplitterMoved(sender As Object, e As SplitterEventArgs)

    End Sub

    Private Sub XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MaxBtn.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub MinBtn_Click(sender As Object, e As EventArgs) Handles MinBtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CBtn_Click(sender As Object, e As EventArgs) Handles CBtn.Click
        Result.Text = "0"
    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        Result.Text = Result.Text + "0"
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Result.Text = Result.Text + "1"
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        Result.Text = Result.Text + "2"
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        Result.Text = Result.Text + "3"
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        Result.Text = Result.Text + "4"
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        Result.Text = Result.Text + "5"
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        Result.Text = Result.Text + "6"
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        Result.Text = Result.Text + "7"
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        Result.Text = Result.Text + "8"
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        Result.Text = Result.Text + "9"
    End Sub

    Private Sub Max2Btn(sender As Object, e As MouseEventArgs) Handles MaxBtn.MouseDown
        Me.WindowState = FormWindowState.Normal
    End Sub
End Class
