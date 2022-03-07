Module Module1

    Sub Main()
        Dim Number As Integer
        Dim Result As Integer
        Console.WriteLine("Enter a positive integer: ")
        Number = Console.ReadLine
        Result = Addition(Number)

        Console.WriteLine("The addition of the natural numbers results to: " & Result)
        Console.ReadKey()

    End Sub

    Function Addition(ByVal num As Integer) As Integer
        If num = 0 Then
            Return num
        Else
            num = num + Addition(num - 1)
            Return num
        End If

    End Function
End Module
