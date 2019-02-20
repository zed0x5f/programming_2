Public Class palindrone

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim k = TextBox1.Text
        Dim l = Integer.Parse(TextBox2.Text)
        Try
            If l >= k.Length() * 2 Then
                ListBox1.Items.Add(Math.Pow(10, l - k.Length() * 2 - 1))
            Else ''not sure yet try to make a palindrome with what u are given then give 0 or 1
                ListBox1.Items.Add(If(2 * k.Length() - endian(k) <= l, 1, 0))
            End If
        Catch ex As Exception
            ListBox1.Items.Add("error")
            Console.WriteLine(ex.ToString())
            Console.WriteLine(ex.StackTrace)
        End Try
    End Sub

    Public Function endian(ByVal k As String) As Integer
        Dim i = k.Length() - 2
        Dim anw = 1
        While i >= 0
            If k.Chars(i) = k.Chars(k.Length() - 1) Then
                anw += 1
            Else
                Return anw
            End If
            i -= 1
        End While
        Return anw
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            ListBox1.Items.Clear()
        Else
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
    End Sub
End Class
