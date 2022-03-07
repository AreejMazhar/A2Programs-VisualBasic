Module Module1

    Sub Main()
        Dim Num = {74, 8, 4, 8, 1, 34, 12}
        Dim Temp, maxsize, insert As Integer

        maxsize = 7
        For count = 1 To (maxsize - 1)
            Temp = Num(count)
            insert = count
            While (insert > 0) AndAlso (Num(insert - 1) >= Temp)
                Num(insert) = Num(insert - 1)
                insert = insert - 1
            End While
            Num(insert) = Temp
        Next

        For count = 0 To (maxsize - 1)
            Console.WriteLine(count & ": " & Num(count))
        Next
        Console.ReadKey()
    End Sub

End Module
