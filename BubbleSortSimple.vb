Module Module1

    Sub Main()
        Dim Temp As String
        Dim Swap As Boolean
        Dim i As Integer
        Dim Maxsize As Integer
        Dim Num = {107, 179, 150, 123, 105, 134, 102, 167, 101, 100}

        Maxsize = 9
        Swap = False

        Do
            Swap = True
            For i = 0 To (Maxsize - 1)
                If Num(i) > Num(i + 1) Then
                    Temp = Num(i)
                    Num(i) = Num(i + 1)
                    Num(i + 1) = Temp
                    Swap = False
                End If
            Next
            Maxsize = Maxsize - 1
        Loop While (Swap = False)

        For i = 0 To 9
            Console.WriteLine(i & " Number: " & Num(i))
        Next
        Console.ReadKey()

    End Sub

End Module
