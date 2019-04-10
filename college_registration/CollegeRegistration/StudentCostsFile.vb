Public Class StudentCostsFile
    Inherits Student

    Private _Cooper As Boolean
    Private _Craig As Boolean
    Private _Julian As Boolean

    Sub New(ByVal strStudentID As String, ByVal strStudentName As String, ByVal intUnits As String, strMajor As String, ByVal Cooper As Boolean, ByVal Craig As Boolean, ByVal Julian As Boolean)

        MyBase.New(strStudentID, strStudentName, intUnits, strMajor)
        _Cooper = Cooper
        _Craig = Craig
        _Julian = Julian

    End Sub

    Overrides Function ComputeCosts() As Decimal

        Dim HousingCost As Decimal
        Const decCooperHousingUnit As Decimal = 2900D
        Const decCraigHousingUnit As Decimal = 3400D
        Const decJulianHousingUnit As Decimal = 4000D

        If _Cooper Then
            HousingCost = decCooperHousingUnit
        ElseIf _Craig Then
            HousingCost = decCraigHousingUnit
        ElseIf _Julian Then
            HousingCost = decJulianHousingUnit
        End If

        _decCost = (_intUnits * _decCostPerUnit) + HousingCost

        Return _decCost

    End Function

End Class
