Public Class Form1
    Dim mirage As Image
    Dim mirageGraphics As Graphics

    Dim finger As Pen
    Dim penSize = 50

    Dim gContainer As Graphics

    Dim shapeSelect As ShapeEnum = ShapeEnum.Cirlce

    Enum ShapeEnum
        Cirlce
    End Enum

    Dim MYLINETOOL As ToolEnum = ToolEnum.RegularBrush

    Enum ToolEnum
        RegularBrush
        Shape
    End Enum

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        finger = New Pen(Color.Gray)
        canvasContainer.Location = New Point(canMargin, 24 + canMargin)
        mirage = New Bitmap(10, 10) 'it must be done
        mirageGraphics = Graphics.FromImage(mirage)

        Form1_SizeChanged(Nothing, Nothing)
        Me.BackColor = Color.Black
        canvasContainer.BackColor = Color.White

        SizeUpDown.Visible = False
        SizeUpDown.Value = penSize

        AddHandler canvasContainer.MouseDown, AddressOf Moose.MooseDown
        AddHandler canvasContainer.MouseUp, AddressOf Moose.MooseUp
    End Sub


    Private Sub Foobarbaz(sender As Object, e As MouseEventArgs) Handles canvasContainer.MouseMove
        Select Case MYLINETOOL
            Case ToolEnum.RegularBrush
                MooseOnTheMove(sender, e)
        End Select
    End Sub

    Public  Class Moose
        Public Shared isMouseDown = False
        Public Shared Sub MooseUp(sender As Object, e As MouseEventArgs)
            isMouseDown = False
        End Sub

        Public Shared Sub MooseDown(sender As Object, e As MouseEventArgs)
            isMouseDown = True
        End Sub
    End Class

    Private Sub MooseOnTheMove(sender As Object, e As MouseEventArgs)
        If Not Moose.isMouseDown Then Return

        mirageGraphics.DrawEllipse(finger, New Rectangle(e.X - penSize \ 2, e.Y - penSize \ 2, penSize, penSize))


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
            mirageGraphics = Graphics.FromImage(temp)
            mirageGraphics.DrawImage(mirage, New Point(0, 0))
            mirage = temp

            gContainer = canvasContainer.CreateGraphics()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub StripMenuItem_Click(s As Object, e As EventArgs) Handles Circle.Click, ColourPicker.Click, ErraserHead.Click
        Select Case s.Text
            Case Circle.Text

            Case ColourPicker.Text
                If ColorDialog1.ShowDialog() = DialogResult.OK Then
                    finger.Color = ColorDialog1.Color
                End If
                Exit Select
            Case ErraserHead.Text

        End Select
    End Sub

    Private Sub StripHoover(s As Object, e As EventArgs) Handles SizeToolStripMenuItem1.Click
        SizeUpDown.Visible = True
        toolStuff.HideDropDown()
        SizeUpDown.Select()
    End Sub

    Private Sub StripHooverLeave(s As Object, e As EventArgs) Handles SizeUpDown.LostFocus
        SizeUpDown.Visible = False
    End Sub

    Private Sub ClickSelector(sender As Object, e As EventArgs) Handles canvasContainer.Click, MenuStrip1.ItemClicked
        sender.Select()
    End Sub

    Private Sub SizeUpDown_ValueChanged(sender As Object, e As EventArgs) Handles SizeUpDown.ValueChanged
        If finger Is Nothing Then Return
        finger.Width = SizeUpDown.Value
    End Sub
End Class
