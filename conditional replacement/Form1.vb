Imports System.Text.RegularExpressions

Public Class conditonal
    Public Sub publix()
        Dim prefix = New ArrayList()
        Dim suffix = New ArrayList()
        Dim temp = tbArr(2).Text.split(",") 'restricted codes
        'add restricted words with algo
        For Each rCode In temp
            prefix.Add(rCode)
            suffix.Add(rCode)
        Next
        temp = tbArr(1).Text.split(",")
        For Each rWord In temp
            Dim i = 0
            While i < rWord.length - 1
                If rWord.chars(i) = tbArr(3).Text Then
                    prefix.Add(rWord.Substring(0, i))
                    suffix.Add(rWord.Substring(i + 1, rWord.length - 1 - i)) 'you look at this and tell me theres a loving god
                End If
                i += 1
            End While
        Next
        Dim raggaeMan = New Regex("(?<!" & spiner(prefix) & ")" & tbArr(3).Text & "(?!" & spiner(suffix) & ")")
        Console.WriteLine(raggaeMan.ToString())
        tbArr(5).text = raggaeMan.Replace(tbArr(0).Text, tbArr(4).Text)
    End Sub

    Public Function spiner(arr)
        Dim s = ""
        For Each x In arr
            s &= x & "|"
        Next
        s = s.TrimEnd("|")
        Return s
    End Function

    Private Sub updater()
        wrapper.Width = Me.Width
        wrapper.Height = Me.Height
    End Sub

    Dim wrapper As FlowLayoutPanel
    Private Sub conditonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'the order of this is very important
        'at this point add all the required labels and textboxes
        wrapper = New FlowLayoutPanel With {
        .Location = New Point(0, 0),
        .Width = Me.Width,
        .Height = Me.Height,
        .AutoScroll = True
        }
        tbArr = New ArrayList()
        wrapper.Controls.Add(box(100, 200, "par")) '0
        wrapper.Controls.Add(box(200, 200, "Restricted words")) '1
        wrapper.Controls.Add(box(200, 200, "Restricted codes")) '2
        wrapper.Controls.Add(box(200, 200, "letter to replace")) '3
        wrapper.Controls.Add(box(200, 200, "replacement")) '4
        wrapper.Controls.Add(box(200, 200, "output")) '5

        Dim butt = New Button With {
            .Text = "click me!",
            .Height = 200,
            .Width = 200,
            .BackColor = Color.Aquamarine
        }
        AddHandler butt.Click, AddressOf publix
        wrapper.Controls.Add(butt)

        Me.Controls.Add(wrapper)
        'me is null so me need to load first
        AddHandler Me.SizeChanged, AddressOf updater
        Dim x As String = "X"

    End Sub

    Dim tbArr As ArrayList
    Public Function box(w, h, label) As FlowLayoutPanel
        Dim temp = New FlowLayoutPanel()
        temp.FlowDirection = FlowDirection.TopDown
        setter(temp, w, h)
        'temp.BackColor = Color.Black

        Dim lb = New Label()
        lb.Text = label
        temp.Controls.Add(lb)

        Dim tb = New TextBox()
        setter(tb, w - 10, 30)

        temp.Controls.Add(tb)
        tbArr.Add(tb)
        Return temp
    End Function

    Public Sub setter(ByRef obj, w, h)
        setter(obj, w, h, "")
    End Sub

    Public Sub setter(ByRef obj, w, h, text)
        Console.WriteLine(w & ":" & h)
        Try
            obj.Width = w
            obj.Height = h
            obj.Text = text
        Catch ex As Exception
            Console.WriteLine(ex.ToString()) 'blog ur errors
        End Try
    End Sub
End Class
