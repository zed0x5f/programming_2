Public Class StudentCost
    Inherits Student
    'this class is redunandt

    Sub New(ByVal studentId As String,
            ByVal studentName As String,
            ByVal major As String,
            ByVal units As Integer)
        MyBase.New(studentId, studentName, major, units)

    End Sub
End Class
