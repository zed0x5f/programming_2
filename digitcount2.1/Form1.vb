Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num
        Dim arr = New ArrayList({0, 0, 0, 0, 0, 0, 0, 0, 0, 0})
        Try
            num = CInt(TextBox1.Text)
            num = TextBox1.Text
        Catch ex As Exception
            ListBox1.Items.Add("not a valid integer")
            Return
        End Try
        ListBox1.Items.Add(CStr(num))
        For i = 0 To num.length() - 1
            Dim x = Integer.Parse(num.chars(i))
            arr.Item(x) += 1
        Next
        For x = 0 To 9
            If arr.Item(x) > 0 Then
                ListBox1.Items.Add("")
                ListBox2.Items.Add(x)
                ListBox3.Items.Add(arr.Item(x))
            End If
        Next
        Dim br = "********************************************"
        ListBox2.Items.Add(br)
        ListBox3.Items.Add(br)
    End Sub


    Public mPadding = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mPadding = ListBox1.Location.X
        Dim width = Me.Width - mPadding * 5
        width = width / 3
        ListBox1.Width = width
        adjust(ListBox1, ListBox2)
        adjust(ListBox2, ListBox3)
    End Sub
    Public Sub adjust(b0 As ListBox, b1 As ListBox) 'move b1
        b1.Width = b0.Width
        b1.Location = New Point(b0.Location.X + b0.Width + mPadding, b0.Location.Y)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
    End Sub
End Class
