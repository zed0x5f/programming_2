Imports System.IO

Public Class Form1
    Dim file
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        change()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Me.Text = OpenFileDialog1.FileName
            Dim temp = New StreamReader(OpenFileDialog1.OpenFile())
            RichTextBox1.Text = temp.ReadToEnd()
            temp.Close()
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, True)

        End If
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PrintPreview1.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub change() Handles Me.Resize
        Dim what = 3
        RichTextBox1.Width = Me.Width - RichTextBox1.Left * (what + 1)
        Console.WriteLine(Me.Width & ":" & RichTextBox1.Width)
        RichTextBox1.Height = Me.Height - RichTextBox1.Top * what
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font1 As New Font("arial", 16, FontStyle.Regular)
        e.Graphics.DrawString(RichTextBox1.Text, font1, Brushes.Black, PrintDocument1.DefaultPageSettings.PrintableArea)
    End Sub
End Class