Public Class Form1
    Dim finger As New SolidBrush(Color.FromArgb(50, Color.Gray))
    Dim pen As Pen
    Dim graphics As Graphics
    Dim mirage


    Dim penSize = 50

    Dim count = 0
    Private Sub Moose(sender As Object, e As MouseEventArgs) Handles canvasContainer.MouseMove
        'count += 1
        'Console.WriteLine(count)
        graphics.DrawEllipse(pen, e.X - penSize \ 2, e.Y - penSize \ 2, penSize, penSize)
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pen = New Pen(finger)
        canvasContainer.Location = New Point(canMargin, 24 + canMargin)
        graphics = canvasContainer.CreateGraphics()

        Form1_SizeChanged(Nothing, Nothing)
        Me.BackColor = Color.Black
        canvasContainer.BackColor = Color.White
    End Sub

    Dim canMargin = 8
    Dim canX = canMargin
    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged

        Try
            count += 1
            'use 4 later
            'Dim foo As Drawing2D.GraphicsContainer = graphics.BeginContainer(canvasContainer.DisplayRectangle, canvasContainer.DisplayRectangle, GraphicsUnit.Pixel)

            mirage = New Bitmap(canvasContainer.Width, canvasContainer.Height)
            canvasContainer.DrawToBitmap(mirage, canvasContainer.DisplayRectangle)


            canvasContainer.Width = Me.Width - (canX * 2 + canMargin * 2) '12 margin + form border of 4? is 32 the anwser to everything?
            canvasContainer.Height = Me.Height - (canvasContainer.Top * 2 + canMargin * 2)


            graphics = canvasContainer.CreateGraphics()
            graphics.DrawImage(mirage, New Point(0, 0))

            'mirage.save("C:\100\temp\test" & count & ".bmp")
            mirage.Dispose()
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try






    End Sub

    Private Sub ErraserToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
End Class
