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
End Class
