Module Module1

    Structure Node
        Dim Content As String
        Dim Pointer As Integer
    End Structure
    Dim Stack(6) As Node
    Dim Freepointer, TOP, temp As Integer

    Sub Main()
        Dim choice As Integer
        InitialiseStack()
        choice = GetOption()
        While choice <> 4
            Select Case choice
                Case 1
                    Push()
                Case 2
                    Pop()
                Case 3
                    Console.WriteLine("Top Of The Stack: " & TOP)
                    Console.WriteLine("Free pointer: " & Freepointer)
                    For i = 0 To 6
                        Console.WriteLine(i & " " & Stack(i).Content & " " & Stack(i).Pointer)
                    Next
            End Select
            choice = GetOption()
        End While
    End Sub

    Function GetOption() As Integer
        Dim choice As Integer
        Console.WriteLine("1: Push a value")
        Console.WriteLine("2: Pop a value")
        Console.WriteLine("3: Output the whole stack")
        Console.WriteLine("4: Quit the program")
        Console.WriteLine("Your choice ")
        choice = Console.ReadLine()
        Return choice
    End Function

    Sub InitialiseStack()
        For i = 0 To 6
            Stack(i).Content = "*"
            Stack(i).Pointer = i + 1
        Next
        Stack(6).Pointer = -2
        Freepointer = 0
        TOP = -1
    End Sub

    Sub Push()
        Dim value As String
        If Freepointer = -1 Then
            Console.WriteLine("Error, Stack is full.")
        Else
            Console.WriteLine("Enter a value: ")
            value = Console.ReadLine()
            Stack(Freepointer).Content = value
            temp = Freepointer
            If Stack(temp).Pointer = -2 Then
                Freepointer = -1
            Else
                Freepointer = Stack(temp).Pointer
            End If
            Stack(temp).Pointer = TOP
            TOP = temp
        End If
    End Sub

    Sub Pop()
        Dim value As String

        If Freepointer = 0 Then
            Console.WriteLine("Error, Stack is empty.")
        Else
            value = Stack(TOP).Content
            Console.WriteLine("Data popped: " & value)
            Stack(TOP).Content = "*"
            temp = TOP
            TOP = Stack(temp).Pointer
            Stack(temp).Pointer = Freepointer
            Freepointer = temp
        End If
    End Sub

End Module
