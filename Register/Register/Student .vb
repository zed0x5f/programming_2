Public Class Student

    Protected _strStudentId As String
    Protected _strStudentName As String
    Protected _strMajor As String
    Protected _intUnits As Integer
    Protected _decCost As Decimal
    Protected _decCostPerUnit As Decimal = 450D
    'Letter D is lateral, (.0)

    Sub New(ByVal strStudentId As String, ByVal strStudentName As String, ByVal strMajor As String, ByVal intUnits As String)
        _strStudentId = strStudentId
        _strStudentName = strStudentName
        _strMajor = strMajor
        _intUnits = Convert.ToInt32(intUnits)



    End Sub
End Class
