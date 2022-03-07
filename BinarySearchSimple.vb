Module Module1
    Dim alphabets() As Char = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}

    Sub Main()
        Dim CharSearch As Char
        Console.WriteLine("Enter the letter you would like to search")
        CharSearch = Console.ReadLine()
        If (BinaryS(CharSearch) <> -1) Then
            Console.WriteLine(CharSearch & " found at location " & BinaryS(CharSearch))
            Console.ReadKey()
        Else
            Console.WriteLine("Not in the array, sorry.")
            Console.ReadKey()
        End If


    End Sub

    Function BinaryS(ByVal value As Char) As Integer
        Dim middle, LB, UB As Integer
        Dim isFound As Boolean = False
        LB = 0
        UB = 26
        While UB >= LB And isFound = False
            middle = (LB + UB) \ 2
            If alphabets(middle) = value Then
                isFound = True
                Return middle
            ElseIf value < alphabets(middle) Then
                UB = middle - 1
            Else
                LB = middle + 1
            End If
        End While
        Return -1
    End Function

End Module
