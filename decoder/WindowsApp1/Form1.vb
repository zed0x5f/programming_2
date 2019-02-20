Imports System.Threading

Public Class Form1
    Dim maps

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        maps = New ArrayList()
        For i = 0 To 2
            maps.Add(New Hashtable())
        Next
        For t = 0 To 255
            maps.Item(0).add(((t \ 64) * 48) + (t \ 4) + 16 * (t Mod 4), t)
            maps.Item(1).add((t Mod 16) * 16 + t \ 16, t)
            maps.Item(2).add((t Mod 4) * 64 + t \ 4, t)
        Next
        Dim x = "helloe"
        Dim encoded = Encrypt(x)
        '012345
        Console.WriteLine(MyCrypt(x) = encoded)
        Try
            Console.WriteLine(DeCrypt(encoded))
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Console.WriteLine(ex.StackTrace)
        End Try
    End Sub

    Public Function Encrypt(ByVal msg As String) As String
        Dim nmsg As String = ""
        Console.WriteLine("before")
        For I = 0 To msg.Length - 1
            Dim char0 = msg.Chars(I)
            Dim t As Integer = Asc(char0)
            Console.Write(char0 & "=" & t & ":")
            Select Case choice(I)
                Case 0
                    nmsg += Chr(255 - t)
                Case 1
                    nmsg += Chr((t \ 64) * 64 + (t - (t \ 4) * 4) * 16 + (t \ 4) - (t \ 64) * 16)
                Case 2
                    nmsg += Chr(t \ 16 + (t - (t \ 16) * 16) * 16)
                Case 3
                    nmsg += Chr((t - (t \ 4) * 4) * 64 + t \ 4)
                Case 4
                    nmsg += Chr(t)
            End Select
        Next
        Console.WriteLine()
        Return nmsg
    End Function

    Function MyCrypt(ByVal msg As String) As String
        Dim nmsg As String = ""
        Console.WriteLine("middle")
        For i = 0 To msg.Length - 1
            Dim t As Long = Asc(msg.Substring(i, 1))
            Select Case choice(i)
                Case 0
                    nmsg += Chr(-t + 255) 'is good
                Case 1
                    Dim arr = New ArrayList()
                    arr.Add(((t >> 6) * 48))
                    arr.Add((t >> 2) << 2)
                    arr.Add((t Mod 4) << 4)
                    arr.Add(0 - ((t >> 5) << 4))
                    Dim tmp = 0L
                    For Each a In arr
                        tmp += a
                    Next
                    nmsg += Chr(tmp)
                    'nmsg += Chr(((t >> 5) << 8) + (t >> 2) + ((t Mod 4) << 4) - ((t >> 5) << 4))
                Case 2
                    nmsg += Chr((t Mod 16) * 16 + t \ 16)
                Case 3
                    nmsg += Chr((t Mod 4) * 64 + t \ 4)
                Case 4
                    nmsg += Chr(t) 'good
            End Select
            Dim char0 = nmsg.Substring(i, 1)
            Console.Write(char0 & "=" & Asc(char0) & ":")
        Next
        Console.WriteLine()
        Return nmsg
    End Function

    Function choice(i)
        Return i Mod 5
        Return 0
    End Function

    Public Function DeCrypt(ByVal msg As String) As String
        Dim nmsg As String = ""
        Console.WriteLine("after")
        For i = 0 To msg.Length - 1
            Dim t As Integer = Asc(msg.Substring(i, 1)) 'the real magic begins
            Select Case choice(i)
                Case 0
                    nmsg += Chr(-t + 255) 'is good
                Case 1
                    nmsg += Chr(maps.Item(0)(t))
                Case 2
                    nmsg += Chr(maps.Item(1)(t))
                Case 3
                    nmsg += Chr(maps.Item(2)(t))
                Case 4
                    nmsg += Chr(t) 'is good
            End Select
            Dim char0 = nmsg.Chars(nmsg.Length - 1)
            Console.Write(char0 & "=" & Asc(char0) & ":")
        Next
        Console.WriteLine()
        Return nmsg
    End Function

    Private Async Sub TextBox1_TextChanged(ByVal sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim i = sender.text
        Dim stick = Task.Run(Function() bob(i)).Result
        En.Text = stick.en
        out
    End Sub

    Dim breadbox = New List(Of Task)()

    Private Async Function bob(ByVal i) As Task(Of bread)
        Thread.Sleep(1000)
        Dim foo = Encrypt(i)
        Return New bread(Encrypt(i), DeCrypt(foo))
    End Function

    Class bread
        Dim en As String = ""
        Dim out As String = ""
        Public Sub New(a, b)
            en = a
            out = b
        End Sub
    End Class
End Class
