Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arr = New ArrayList()
        Dim i = 2
        arr.Add(i)
        ListView1.Items.Add(2)
        While arr.Count < 1000
            i += 1
            Dim isPrime = True
            For Each x In arr
                If i Mod x = 0 Then
                    isPrime = False
                    Exit For
                End If
            Next
            If isPrime Then
                arr.Add(i)
                ListView1.Items.Add(i)
            End If
        End While

    End Sub
End Class
