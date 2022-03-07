Module Module1
    Dim Numbers() As Integer = {32, 21, 7, 48, 51, 22, 9, 15, 11, 27}

    Sub Main()
        Dim Value As Integer
        Dim Choice As Char
        Dim x As Integer
        Dim y As Integer

        Console.WriteLine("Enter the value you would like to search: ")
        Value = Console.ReadLine()
        Console.WriteLine("Would you like to conduct a (L)inear or (B)inary Search?: ")
        Choice = Console.ReadLine()

        If (Choice = "L") Or (Choice = "l") Then
            x = LinearSearch(Value)
            If (x = -1) Then
                Console.WriteLine("Sorry, your number is not in the array :(")
                Console.ReadKey()
            Else
                Console.WriteLine("Your number was found at index: " & x)
                Console.ReadKey()
            End If
        ElseIf (Choice = "B") Or (Choice = "b") Then
            Bsort(Numbers)
            y = BinarySearch(Value)
            If (y = -1) Then
                Console.WriteLine("Sorry, your number is not in the array :(")
                Console.ReadKey()
            Else
                Console.WriteLine("Your number was found at index: " & y)
                Console.ReadKey()
            End If
        Else
            Console.WriteLine("Invalid choice. Program Terminated.")
            Console.ReadKey()
        End If
    End Sub

    Function LinearSearch(ByVal Num As Integer) As Integer
        Dim Found As Boolean
        Dim Count As Integer
        Found = False
        Count = 0

        Do
            If (Num = Numbers(Count)) Then
                Found = True
                Return Count
            Else
                Count = Count + 1
            End If
        Loop Until (Found = True) Or (Count = 9)
        Return -1
    End Function

    Sub Bsort(ByRef Numbers As Array)
        Dim maxsize As Integer
        Dim temp As Integer
        Dim swap As Boolean
        maxsize = 9
        swap = False

        While (swap = False)
            swap = True
            For i = 0 To (maxsize - 1)
                If Numbers(i) > Numbers(i + 1) Then
                    temp = Numbers(i)
                    Numbers(i) = Numbers(i + 1)
                    Numbers(i + 1) = temp
                    swap = False
                End If
            Next
            maxsize = maxsize - 1
        End While
    End Sub

    Function BinarySearch(ByVal num As Integer) As Integer
        Dim mid, LB, UB As Integer
        Dim found As Boolean
        found = False
        LB = 0
        UB = 9

        While (UB >= LB) And (found = False)
            mid = Int((LB + UB) / 2)
            If Numbers(mid) = num Then
                found = True
                Return mid
            ElseIf (num < Numbers(mid)) Then
                UB = mid - 1
            Else
                LB = mid + 1
            End If
        End While
        Return -1
    End Function
End Module
