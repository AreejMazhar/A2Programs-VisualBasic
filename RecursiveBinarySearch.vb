Module Module1
    Dim Numbers = {33, 47, 48, 51, 56, 77, 78, 82, 99}
    Dim Num As Integer
    Dim Check As Integer
    Dim Middle As Integer

    Sub Main()
        Console.WriteLine("Enter a number to search: ")
        Num = Console.ReadLine
        Check = BinaryS(Num, 0, 8)
        If Check = -1 Then
            Console.WriteLine("Your number is not in the array.")
        Else
            Console.WriteLine("Value found at: " & Check)
        End If
        Console.ReadKey()
    End Sub

    Function BinaryS(ByVal Value As Integer, ByVal Start As Integer, ByVal Finish As Integer) As Integer

        If Finish < Start Then
            Return -1
        Else
            Middle = (Start + Finish) / 2
            If Numbers(Middle) = Value Then
                Return Middle
            ElseIf Value > Numbers(Middle) Then
                BinaryS(Value, Middle + 1, Finish)
            Else
                BinaryS(Value, Start, Middle - 1)
            End If
        End If
        Return Middle
    End Function
End Module
