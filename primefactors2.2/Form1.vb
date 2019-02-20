Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim value = Integer.Parse(TextBox1.Text)
        Dim anw = New Hashtable()
        Dim i = 2
        While i <= value
            If value Mod i = 0 Then
                value /= i
                If anw.ContainsKey(i) Then
                    anw.Item(i) += 1
                Else
                    anw.Add(i, 1)
                End If
            Else
                i += 1
            End If
        End While
        Dim keys = anw.Keys.Cast(Of Integer)().ToArray()
        Array.Sort(keys)
        ListBox1.Items.Add(
        For Each k In keys
            ListBox1.Items.Add(k & " " & anw.Item(k))
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            ListBox1.Items.Clear()
        Else
            TextBox1.Text = ""
        End If
    End Sub
End Class
