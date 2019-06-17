Imports System.Text.RegularExpressions

Public Class CommonFunctions

    Public Function ForLoopCharCount(ByVal CharExp As Char, ByVal TextExp As String) As Integer
        Dim countr As Integer = 0
        For i As Integer = 0 To TextExp.Length - 1
            If TextExp.Chars(i) = CharExp Then
                countr += 1
            End If
        Next
        Return countr
    End Function

    Public Function ForLoopCharCountCaseInsentive(ByVal CharExp As Char, ByVal TextExp As String) As Integer
        Dim countr As Integer = 0
        For i As Integer = 0 To TextExp.Length - 1
            If TextExp.Chars(i).ToString.ToLower = CharExp.ToString.ToLower Then
                countr += 1
            End If
        Next
        Return countr
    End Function

    'Public Function RecursiveCharCount(ByVal CharExp As Char, ByVal TextExp As String) As Integer

    'Public Function RecursiveCharCountCaseInsentive(ByVal CharExp As Char, ByVal TextExp As String) As Integer

    Public Function ReplaceCharCount(ByVal CharExp As Char, ByVal TextExp As String) As Integer

        Return TextExp.Length - TextExp.Replace(CharExp, "").Length

    End Function

    Public Function ReplaceCharCountCaseInsentive(ByVal CharExp As Char, ByVal TextExp As String) As Integer

        Return TextExp.Length - TextExp.Replace(CharExp.ToString.ToUpper, "").Replace(CharExp.ToString.ToLower, "").Length

    End Function

    Public Function RegExpCharCount(ByVal CharExp As Char, ByVal TextExp As String) As Integer

        Dim exp As New Regex(CharExp)
        Dim Occurrences As Integer = exp.Matches(TextExp).Count

        Return Occurrences
    End Function

    Public Function RegExpCharCountCaseInsentive(ByVal CharExp As Char, ByVal TextExp As String) As Integer

        Dim exp As New Regex(CharExp, RegexOptions.IgnoreCase)
        Dim Occurrences As Integer = exp.Matches(TextExp).Count

        Return Occurrences
    End Function

    Public Function CalculationString(ByVal equation As String) As String

        Dim result = New DataTable().Compute(equation, Nothing)

        Return result
    End Function



End Class
