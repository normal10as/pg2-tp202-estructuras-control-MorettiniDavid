
Module _23


    Sub main()

        Dim numero, mayor As Integer
        Dim a As Byte

        Console.WriteLine("Ingrese El Primer Valor: ")
        numero = Console.ReadLine
        a = 1
        mayor = numero

        Console.WriteLine("Ingrese El Segundo Valor: ")
        numero = Console.ReadLine
        If numero > mayor Then
            a = 2
            mayor = numero
        End If

        Console.WriteLine("Ingrese El Tercer Valor: ")
        numero = Console.ReadLine
        If numero > mayor Then
            a = 3
            mayor = numero
        End If

        Console.WriteLine("Ingrese El Cuarto Valor: ")
        numero = Console.ReadLine
        If numero > mayor Then
            a = 4
            mayor = numero
        End If


        Console.WriteLine("Ingrese El Quinto Valor: ")
        numero = Console.ReadLine
        If numero > mayor Then
            a = 5
            mayor = numero
        End If

        Console.WriteLine("El Mayor de los Numeros Ingresados es el {0} Ingresado en la Posicion {1}", mayor, a)
        Console.ReadKey()

    End Sub




End Module
