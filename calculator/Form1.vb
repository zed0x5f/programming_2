Public Class Form1
    Public Class Display
        Private value As Double
        Public Sub operate(x As Double, op As String)
            operateAssign(x, value, op)
        End Sub

        Public Sub operateAssign(x As Object, y As Object, op As String)
            s(operander(x, y, op))
        End Sub
        Public Function operander(x As Object, y As Object, op As String)
            Dim value As Object
            value = Nothing
            Select Case op
                Case "&"
                    value = y & x
                Case "-"
                    value = y - x
                Case "+"
                    value = y + x
                Case "*"
                    value = y * x
                Case "/"
                    value = y / x
                Case "mod"
                    value = y Mod x
            End Select
            Return value
        End Function

        Public Function g()
            Return vget()
        End Function

        Public Function vget()
            Return value
        End Function

        Public Sub s(x As Object)
            vset(x)
        End Sub

        Public Sub vset(x As Object)
            value = x
            Form1.TextBox1.Text = value
        End Sub
        Public Sub New(x As Object)
            s(x)
        End Sub
    End Class
    Dim bucket As Double
    Dim mdisplay As Display
    Dim LastOperator As String

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button0.Click
        mdisplay.operateAssign(sender.Text, TextBox1.Text, "&")
        mdisplay.operate(1, "*")
    End Sub

    Private Sub Operator_Click(sender As Object, e As EventArgs) Handles Plus.Click, Minus.Click, Multiply.Click, Divide.Click, Modulus.Click, Equal.Click
        If LastOperator = Nothing Then
            bucket = mdisplay.g()
            mdisplay.s(0)
        Else
            bucket = mdisplay.operander(bucket, mdisplay.g(), LastOperator)
        End If

        If sender.Text = "=" Then
            mdisplay.s(bucket)
            LastOperator = ""
        Else
            mdisplay.s(0)
            LastOperator = sender.Text
        End If
    End Sub

    Private Sub Dot_Click(sender As Object, e As EventArgs) Handles Dot.Click
        If Not TextBox1.Text.Contains(".") Then 'superior dot check
            TextBox1.Text &= "."
        End If
    End Sub

    Private Sub Negator_Click(sender As Object, e As EventArgs) Handles Negator.Click
        mdisplay.operate(-1, "*")
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        If mdisplay.g() = 0 Then
            bucket = 0
            LastOperator = ""
        Else
            mdisplay.s(0)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdisplay = New Display(0)
    End Sub
End Class
