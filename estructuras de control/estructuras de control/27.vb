Module _27

    Sub main()

        Console.Write("valor del angulo: ")
        Dim an As Int16 = Console.ReadLine

        Select Case an
            Case 1 To 89
                Console.WriteLine("El Angulo Ingresado es Agudo")
            Case 90
                Console.WriteLine("El Angulo Ingresado es Recto")
            Case 91 To 179
                Console.WriteLine("El Angulo Ingresado es Obstuso")
            Case 180
                Console.WriteLine("El Angulo Ingresado es Llano")
            Case 181 To 359
                Console.WriteLine("El Angulo Ingresado es Concavo")
            Case Else
                Console.WriteLine("El valor ingresado es incorrecto.! ")

        End Select

        Console.ReadKey()

    End Sub

End Module
