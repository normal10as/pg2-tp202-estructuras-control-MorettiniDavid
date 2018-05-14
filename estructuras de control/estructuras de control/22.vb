Module _22

    Sub main()

        Dim num1, num2, num3 As Integer

        Console.WriteLine(" El Primer Valor:  ")
        num1 = Console.ReadLine

        Console.WriteLine(" El Segundo Valor:  ")
        num2 = Console.ReadLine

        Console.WriteLine(" El Tercer Valor:  ")
        num3 = Console.ReadLine

        If num1 > num2 And num1 > num3 Then

            Console.WriteLine("El Numero {0}, es Mayor a los Numeros {1} y {2}. ", num1, num2, num3)

        ElseIf num2 > num1 And num2 > num3 Then

            Console.WriteLine("El Numero {0}, es Mayor a los Numeros {1} y {2}. ", num2, num3, num1)

        ElseIf num3 > num1 And num3 > num2 Then

            Console.WriteLine("El Numero {0}, es Mayor a los Numeros {1} y {2}. ", num3, num1, num2)

        End If

        Console.ReadKey()

    End Sub
End Module
