Public Class Student

    Protected _studentId As String
    Protected _studentName As String
    Protected _major As String
    Protected _cost As Decimal



    Protected _numberOfUnits As Integer
    Protected _costPerUnit As Decimal = 450D

    Sub New(ByVal strStudentId As String,
            ByVal strStudentName As String,
            ByVal strMajor As String,
            ByVal intUnit As String)
        _studentId = strStudentId
        _studentName = strStudentName
        _major = strMajor
        _numberOfUnits = Convert.ToInt32(intUnit)
    End Sub

    Overridable Function ComputeCost() As Double
        _cost = _numberOfUnits * _costPerUnit
        WriteRecord(New ArrayList({_studentId, _studentName, _major, _cost}))
        Return _cost
    End Function

    Public Sub WriteRecord(ByVal list As ArrayList)
        Dim file = "../../../out.txt"
        Dim writer As IO.StreamWriter = IO.File.AppendText(file)
        Try
            Dim i = 0
            While i < list.Count - 2
                writer.Write(list(i) & ", ")
                i += 1
            End While
            writer.WriteLine(list(i + 1))
            writer.Close()
        Catch ex As Exception
            MsgBox("No device alaviable")
        End Try
    End Sub
End Class
