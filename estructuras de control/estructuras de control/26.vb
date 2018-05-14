Module _26

    Sub main()
        Dim desc As Single
        Dim Cant, a, SubTotal As Integer

        Console.WriteLine("Cantidad del Producto: ")
        Cant = Console.ReadLine

        Console.WriteLine("Precio Unitario del Producto: ")
        a = Console.ReadLine

        desc = 0

        Select Case Cant
            Case 10 To 50
                desc = 0.05

            Case 51 To 250
                desc = 0.1

            Case Else
                desc = 0.2
        End Select


        SubTotal = Cant * a

        Console.WriteLine("Subtotal: " & SubTotal)
        Console.WriteLine("Porcentaje de Descuento aplicado: {0} %", desc * 100)
        Console.WriteLine("Total Descuento: " & SubTotal * desc)
        Console.WriteLine("Total A Pagar: " & SubTotal - (SubTotal * desc))

        Console.ReadKey()

    End Sub


End Module
