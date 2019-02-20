Imports Calculator

Public Class Form1
    Dim mdisplay As Display
    Dim root = Nothing
    Dim mode

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdisplay = New Display(0)
        'mtuple = New Tuple()
        Log.Text = "log" & ChrW(&H2081) & ChrW(&H2080) 'subscript 10
        Log2.Text = "log" & ChrW(&H2082) 'subscript 2
        If True Then
            'root.ops = New ArrayList({Fact.Text, "(", "+", ")"})
            'root.numbers = New ArrayList({"4", "1"})
            Equal.PerformClick()
        End If
    End Sub

    Public Class Display
        Private value As Double
        Public Sub operate(x As Double, op As String)
            operateAssign(x, value, op)
        End Sub

        Public Sub operateAssign(x As Object, y As Object, op As String)
            vset(Form1.Operander(x, y, op))
        End Sub

        Public Function vget()
            Return value
        End Function

        Public Sub vset(x As Object)
            value = x
            Form1.TextBox1.Text = value
        End Sub

        Public Function reset()
            Dim temp = value
            vset(0)
            Return temp
        End Function

        Public Sub New(x As Object)
            vset(x)
        End Sub
    End Class

    Public MustInherit Class Node
        Protected pemdas As Integer
        Protected op As String
        Protected prev As Node
        Protected left As Node
        Public Shared Function IsDoubleOperator(x As String)
            Select Case x
                Case Form1.Exponent.Text, Form1.Multiply.Text, Form1.Divide.Text, Form1.Plus.Text, Form1.Minus.Text
                    Return True
                Case Else
                    Return False
            End Select
        End Function

        MustOverride Function Compute()
        MustOverride Function Add(input As Node)
        MustOverride Function GetParent()
        MustOverride Function Compare(input As Node)
    End Class

    Public Class Number
        Inherits Node
        Private val As Double
        Public Sub New(daddy As Node, value As Double)
            pemdas = -1
            val = value
        End Sub
        Public Overrides Function Compute() As Object
            Return val
        End Function

        Public Overrides Function Add(input As Node) As Object
            Throw New NotImplementedException()
        End Function

        Public Overrides Function GetParent() As Object
            Throw New NotImplementedException()
        End Function

        Public Overrides Function Compare(input As Node) As Object
            Throw New NotImplementedException()
        End Function
    End Class

    Public Class Op1
        Inherits Node
        Public Sub New(op As String, prev As Node, leftValue As Node)

        End Sub
        Public Overrides Function Compute() As Object
            Throw New NotImplementedException()
        End Function

        Public Overrides Function Add(input As Node) As Object
            Throw New NotImplementedException()
        End Function

        Public Overrides Function GetParent() As Object
            Throw New NotImplementedException()
        End Function

        Public Overrides Function Compare(input As Node) As Object
            Throw New NotImplementedException()
        End Function
    End Class

    Public Class Op2
        Inherits Node
        Private right As Node
        Public Sub New(op As String, prev As Node, leftValue As Node)
            Select Case op
                Case "^"
                    pemdas = 7
                Case ""
            End Select
        End Sub
        Public Overrides Function Compute() As Object
            Throw New NotImplementedException()
        End Function

        Public Overrides Function Add(input As Node) As Object
            Throw New NotImplementedException()
        End Function

        Public Overrides Function GetParent() As Object
            Throw New NotImplementedException()
        End Function

        Public Overrides Function Compare(input As Node) As Object
            Throw New NotImplementedException()
        End Function
    End Class

    Public Class Jank
        Public Const PI = 3.14159265358979

        Public Shared Function log(x As Double, base As Double) As Double
            Return ln(x) / ln(base)
        End Function

        Public Shared Function ln(x As Double) As Double
            Dim anw As Double
            Dim fraction = (x - 1) / (x + 1)
            Dim maffs = Function(n) (2 * n + 1)
            For i = 0 To 100
                Dim quick = maffs(i)
                anw += Exp(fraction, quick) / quick
            Next
            Return 2 * anw
        End Function

        Public Shared Function Abs(x As Object)
            Return If(x < 0, 0 - x, x)
        End Function

        Public Shared Function Exponent(x As Double, y As Double)
            'turn fraction into improper fraction
            'the find gcd of nominator and denominator
            'divide both the gcd
            'do exponent then do radidcal
            Dim neg = y < 0
            y = Abs(y) 'on line baby
            'Dim exp As Long
            'exp = (y << 1 >> 53)
            'If exp < 1023 Then

            'End If
            'End If
            'End If
            Dim counter = 0
            While y <> y \ 1 'this shiz is jank
                y *= 2
                counter += 1
            End While
            counter = Exp(2, counter)
            Console.WriteLine("radical is " & counter)
            Dim gc = gcd(y, counter)
            y /= gc
            counter /= gc
            x = Radical(x, counter)
            x = Exp(x, y)
            Return If(neg, 1 / x, x) 'todo use bit hacking to flip the expoent
        End Function

        Public Shared Function Exp(a As Double, b As ULong) As Double 'todo add caching
            If b = 0 Then
                Return 1
            ElseIf b Mod 2 = 1 Then
                Return a * Exp(a, b - 1)
            Else
                Dim p = Exp(a, b / 2)
                Return p * p
            End If
        End Function

        Public Shared Function gcd(a As Long, b As Long)
            Dim temp As Long
            While b <> 0
                temp = b
                b = a Mod b
                a = temp
            End While
            Return a
        End Function

        Public Shared Function Radical(x As Double, n As Double) 'todo finish
            If n <= 1 Then
                Return x
            End If
            x = Abs(x)
            x = newton(x, 0.5, n)
            Return x
        End Function

        'lets play a guessing game
        Const acceptable = 0.00000000000001
        Public Delegate Function f(a As Double, b As Double) As Double
        Public Shared Function newton(input As Double, x0 As Double, n As Double) As Double 'x is the guess
            'or should it be abs (x1- input)?
            While Abs(Exp(x0, n) - input) > acceptable
                x0 = x0 - ((Exp(x0, n) - input) / Exp(n * x0, n - 1))
                'x0 = x0 - (f0.Invoke(x0, n) / fPrime(x0, n))
            End While
            Return x0
        End Function

        Public Shared Function Tan(value As Double) As Double
            Return Sin(value) / Cos(value)
        End Function

        Public Shared Function Sin(value As Double) As Double
            If Form1.mode = Form1.deg.Text Then
                Return Cos(value - 90)
            Else
                Return Cos(value - PI / 2)
            End If
        End Function

        Public Shared Function Cos(value As Double) As Double
            value = Abs(value)
            If Form1.mode = Form1.deg.Text Then
                value = value * PI / 180
            End If
            value = value - (value \ (2 * PI) * 2 * PI) 'optional
            Dim anw = 0.0
            Dim n = 0
            Dim temp = 0.0
            While n < 100
                temp = Exp(value, 2 * n) / Factorial(2 * n)
                If (n Mod 2) = 0 Then
                    anw += temp
                Else
                    anw -= temp
                End If
                n += 1
            End While
            anw = Math.Round(anw, 9)
            Return anw
        End Function

        Public Shared Function Factorial(value As Double) As Double
            If value > 171 Then
                Return Factorial(171) 'dont fix whats not broken
            End If
            If value < 2 Then
                Return 1
            End If
            Return value * Factorial(value - 1)
        End Function
    End Class

    Public Function Operander(x As Double, y As Object, op As String)
        Dim value As Object
        value = Nothing
        Select Case op
            Case Exponent.Text
                If cheat Then
                    value = Math.Pow(y, x)
                Else
                    'convert x to fraction
                    'divide for both operands by gcd
                    Dim neg As Boolean = x < 0
                    x = If(neg, 0 - x, x)
                    Dim dong = (&H800L Xor (x >> 52)) 'grab exponent from number 1023 is zero
                    'value = Exp(y, xp) * Radical(y, 1) 'needs to handle fraction
                    If neg Then
                        value = 1 / value
                    End If
                End If
            Case "&"
                value = y & x
            Case Minus.Text
                value = y - x
            Case Plus.Text
                value = y + x
            Case Multiply.Text
                value = y * x
            Case Divide.Text
                value = y / x
            Case Modulus.Text
                value = y Mod x
        End Select
        Return value
    End Function

    Private Sub ButtonClick(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button0.Click
        mdisplay.operateAssign(sender.Text, TextBox1.Text, "&")
        mdisplay.operate(1, "*")
    End Sub

    Private Sub DotClick(sender As Object, e As EventArgs) Handles Dot.Click
        If Not TextBox1.Text.Contains(".") Then 'superior dot check
            TextBox1.Text &= "."
        End If
    End Sub

    Private Sub NegatorClick(sender As Object, e As EventArgs) Handles Negator.Click
        mdisplay.operate(-1, "*")
    End Sub

    Public Function CheckParen()
        If root.ops.Count - 1 >= 0 Then
            If root.ops.Item(root.ops.Count - 1) = RightParen.Text Then
                Return True
            End If
        End If
        root.numbers.Add(mdisplay.vget())
        Return False
    End Function

    Private Sub Operator_Click(sender As Object, e As EventArgs) Handles Plus.Click, Minus.Click, Multiply.Click, Divide.Click, Modulus.Click, Exponent.Click
        TextBox2.Text &= If(Not CheckParen(), mdisplay.reset(), "") & If(sender.text = RightParen.Text, "", " ") & sender.text() & " " 'grab the next number unless we end with a close paren
        root.ops.Add(sender.Text)
    End Sub

    Private Sub Single_Ladies(sender As Object, e As EventArgs) Handles Fact.Click, Log.Click, Ln.Click, Tan.Click, Cos.Click, Sin.Click
        root.ops.Add(sender.Text)
        TextBox2.Text &= sender.Text
        LeftParen.PerformClick()
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        mdisplay.vset(0)
        root.Reset()
        TextBox2.Text = ""
    End Sub

    Private Sub Equal_Click(sender As Object, e As EventArgs) Handles Equal.Click
        CheckParen()
        While root.leftCount > 0
            root.Add(RightParen.Text) 'fix
            root.leftCount -= 1
        End While
        root = root.compute(root)
        mdisplay.vset(root)
        root = Nothing
        TextBox2.Text = ""
    End Sub

    Public Sub SinglesWillNotBePaired(e As Tuple, i As Integer)
        i -= 1
        If i < 0 Or i >= e.ops.Count() Then
            Return
        End If
        If Tuple.IsDouble(e.ops.Item(i)) Or e.ops.Item(i) = LeftParen.Text Then
            Return
        End If
        Dim value As Double
        value = Pull(e.numbers, e.windex)
        Select Case e.ops.Item(i)
            Case Log.Text
                value = Math.Log10(value)
            Case Ln.Text
                value = Math.Log(value)
            Case Log2.Text
                value = Math.Log(value) / Math.Log(2)
            Case Fact.Text 'what about fractions?
                value = Math.Round(value)
                value = Jank.Factorial(value)
            Case Cos.Text
                value = Math.Cos(value)
            Case Sin.Text
                value = Math.Sin(value)
            Case Tan.Text
                value = Math.Tan(value)
        End Select
        e.ops.RemoveAt(i)
        e.numbers.Insert(e.windex, value)
    End Sub

    Private Sub LeftParen_Click(sender As Object, e As EventArgs) Handles LeftParen.Click
            root.leftCount += 1
            TextBox2.Text &= sender.Text
            root.ops.Add(sender.Text)
            RightParen.Enabled = True
        End Sub

        Private Sub RightParen_Click(sender As Object, e As EventArgs) Handles RightParen.Click
            root.leftCount -= 1
            Operator_Click(sender, e)
            If root.leftCount = 0 Then
                RightParen.Enabled = False
            End If
        End Sub
    End Class
