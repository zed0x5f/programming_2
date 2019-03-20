Public Class Form1
    Dim mirage As Image
    Dim graphics As Graphics
    Dim pen As Pen
    Dim penSize = 50

    Dim finger As New SolidBrush(Color.FromArgb(50, Color.Gray))

    Dim gContainer As Graphics

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pen = New Pen(finger)
        canvasContainer.Location = New Point(canMargin, 24 + canMargin)
        mirage = New Bitmap(10, 10) 'it must be done
        graphics = Graphics.FromImage(mirage)

        Form1_SizeChanged(Nothing, Nothing)
        Me.BackColor = Color.Black
        canvasContainer.BackColor = Color.White
    End Sub



    Private Sub MooseUp(sender As Object, e As MouseEventArgs) Handles canvasContainer.MouseUp
        isMouseDown = False
    End Sub

    Private Sub MooseDown(sender As Object, e As MouseEventArgs) Handles canvasContainer.MouseDown
        isMouseDown = True
    End Sub

    Dim isMouseDown = False
    Private Sub Moose(sender As Object, e As MouseEventArgs) Handles canvasContainer.MouseMove
        If Not isMouseDown Then
            Return
        End If
        'count += 1
        'Console.WriteLine(count)
        Dim rect = New Rectangle(e.X - penSize \ 2, e.Y - penSize \ 2, penSize, penSize)

        graphics.DrawEllipse(pen, rect)
        gContainer.DrawImage(mirage, New Point(0, 0))
    End Sub





    Dim canMargin = 8
    Dim canX = canMargin
    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Try
            'Dim foo As Drawing2D.GraphicsContainer = graphics.BeginContainer(canvasContainer.DisplayRectangle, canvasContainer.DisplayRectangle, GraphicsUnit.Pixel)

            canvasContainer.Width = Me.Width - (canX * 2 + canMargin * 2) '12 margin + form border of 4? is 32 the anwser to everything?
            canvasContainer.Height = Me.Height - (canvasContainer.Top * 2 + canMargin * 2)

            Dim temp = New Bitmap(canvasContainer.Width, canvasContainer.Height)
            graphics = Graphics.FromImage(temp)
            graphics.DrawImage(mirage, New Point(0, 0))
            mirage = temp

            gContainer = canvasContainer.CreateGraphics()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub StripMenuItem_Click(s As Object, e As EventArgs) Handles LineTool.Click
        If s Is LineTool Then

        End If
        If s Is Nothing Then

        End If

    End Sub
End Class
