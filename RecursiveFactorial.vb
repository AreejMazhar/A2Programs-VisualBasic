Module Module1

    Sub Main()
        Dim num As Integer
        Dim Result As Integer

        Console.WriteLine("Enter the number: ")
        num = Console.ReadLine()
        Result = Factorial(num)
        Console.WriteLine("Result of the factorial is: " & Result)
        Console.ReadKey()

    End Sub

    Function Factorial(ByVal n As Integer) As Integer
        Dim x As Integer
        If n = 1 Then
            Return 1
        End If
        x = Factorial(n - 1) * n
        Return x
    End Function
End Module
