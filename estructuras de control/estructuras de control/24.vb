Module _24
    Sub main()
        Dim desc As Single
        Dim Cant, Ab, SubT As Integer

        Console.WriteLine("Ingrese Cantidad del Producto: ")
        Cant = Console.ReadLine

        Console.WriteLine("Ingres Precio Unitario del Producto: ")
        Ab = Console.ReadLine

        desc = 0

        If Cant >= 10 And Cant <= 50 Then
            desc = 0.05

        ElseIf Cant > 50 And Cant <= 250 Then
            desc = 0.1

        ElseIf Cant > 250 Then
            desc = 0.2

        End If

        SubT = Cant * Ab

        Console.WriteLine("Subtotal: " & SubT)
        Console.WriteLine("Porcentaje de Descuento aplicado: {0} %", desc * 100)
        Console.WriteLine("Total Descuento: " & SubT * desc)
        Console.WriteLine("Total A Pagar: " & SubT - (SubT * desc))

        Console.ReadKey()

    End Sub

End Module
