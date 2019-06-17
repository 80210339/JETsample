'Please write some object oriented code in VB.NET. The code should be made as reusable as possible. 
'It should tell Me how many letter e's are in the following sentence 
'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Eanean sodales justo et Enim ornare, a congue lacus commodo.’
'how many number 1s are in the following number 17272838119191929838299111 
'and the result of 7 + 5.”


Module Module1


    Dim CompClass As New Compare


    Sub Main()


        Console.WriteLine("1) String search for character")
        Console.WriteLine("2) Calculation")

        Select Case Console.ReadLine().Chars(0)
            Case "1"
                Console.WriteLine("Enter String to be checked")
                CompClass.TestText = Console.ReadLine()
                Console.WriteLine("Enter character to be checked for")
                CompClass.CharToBeCheckedFor = Console.ReadLine().Chars(0)
                Console.WriteLine("Number of occurrences: " & CompClass.RegExpCharCountCaseInsentive(CompClass.CharToBeCheckedFor, CompClass.TestText).ToString)
            Case "2"
                Console.WriteLine("Enter Calculation")
                CompClass.CalcString = Console.ReadLine
                Console.WriteLine(CompClass.CalcString & " = " & CompClass.CalculationString(CompClass.CalcString))
        End Select

        'Console.WriteLine(ForLoopCharCount(CharToBeCheckedFor, TestText).ToString)
        'Console.WriteLine(ForLoopCharCountCaseInsentive(CharToBeCheckedFor, TestText).ToString)

        'Console.WriteLine(ReplaceCharCount(CharToBeCheckedFor, TestText).ToString)
        'Console.WriteLine(ReplaceCharCountCaseInsentive(CharToBeCheckedFor, TestText).ToString)

        'Console.WriteLine(RegExpCharCount(CharToBeCheckedFor, TestText).ToString)
        'Console.WriteLine(RegExpCharCountCaseInsentive(CharToBeCheckedFor, TestText).ToString)

        Console.ReadKey()

    End Sub




End Module
