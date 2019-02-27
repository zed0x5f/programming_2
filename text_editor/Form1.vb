Public Class Form1
    Dim OpenDialog
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click

        '    OpenDialog'
        OpenDialog.show()
    End Sub

    Private Sub getFile()

    End Sub


    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click

    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click

    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click

    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPreviewToolStripMenuItem.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenDialog = New Open()
        change()
    End Sub

    Private Sub change() Handles Me.Resize
        Dim what = 3
        RichTextBox1.Width = Me.Width - RichTextBox1.Left * (what + 1)
        Console.WriteLine(Me.Width & ":" & RichTextBox1.Width)
        RichTextBox1.Height = Me.Height - RichTextBox1.Top * what
    End Sub
End Class
