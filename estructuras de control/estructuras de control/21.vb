Module Module1

    Sub Main()

        Dim num1, num2 As Integer

        Console.WriteLine(" Primer Valor: ")
        num1 = Console.ReadLine

        Console.WriteLine(" Segundo Valor: ")
        num2 = Console.ReadLine

        If num1 > num2 Then
            Console.WriteLine("El Numero {0}  es Mayor al Numero {1} ", num1, num2)

        ElseIf num2 > num1 Then
            Console.WriteLine("El Numero {0}  es Mayor al Numero {1} ", num2, num1)

        Else
            Console.WriteLine("Los Numeros Ingresados son Iguales. ")
        End If





        Console.ReadKey()
    End Sub

End Module
