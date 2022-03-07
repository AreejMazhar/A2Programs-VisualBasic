Module Module1

    Sub Main()
        Dim Num() As Integer = {620, 412, 1011, 313, 505, 909, 707, 820}
        Dim SearchNum As Integer
        Dim Found As Boolean
        Dim count As Integer

        count = 0

        Console.Write("Enter the number you would like to search: ")
        SearchNum = Console.ReadLine()

        Do
            If SearchNum = Num(count) Then
                Found = True
                Console.WriteLine("Your number has been found at " & count)
                Console.ReadLine()

            End If
            count = count + 1
        Loop Until (Found = True) Or (count = 8)

        If (count = 8) Then
            Console.WriteLine("Your number is not in this array.")
            Console.ReadLine()
        End If
    End Sub

End Module
