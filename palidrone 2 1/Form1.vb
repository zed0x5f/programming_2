Imports System.Text.RegularExpressions

Public Class palindrone

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim value = TextBox1.Text
        Try
            Dim neins = New Regex("^9+$") 'all the neins
            If neins.Match(value).Length > 0 Then
                value += 1
            End If
            ListBox1.Items.Add(n(value, value))
        Catch ex As Exception
            ListBox1.Items.Add("error")
            Console.WriteLine(ex.ToString())
            Console.WriteLine(ex.StackTrace)
        End Try
    End Sub

    Public Function n(v, w) 'code galf 279 characters on par
        Dim l = Function(e) CStr(e).Length()
        Dim s = Function(z, e) CStr(w).Substring(z, e)
        Dim c = Function(e, b) Math.Ceiling((l(e) - b) / 2)
        Dim t = s(0, c(w, 0))
        t = t & StrReverse(s(0, l(t) - (l(w) Mod 2)))
        Return If(t > v, t, n(v, t + Math.Pow(10, c(t, 1))))
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            ListBox1.Items.Clear()
        Else
            TextBox1.Text = ""
        End If
    End Sub
End Class
