Module _25

    Enum Meses

        Enero = 1
        Febrero
        Marzo
        Abril
        Mayo
        Junio
        Julio
        Agosto
        Septiembre
        Octubre
        Noviembre
        Diciembre

    End Enum


    Sub main()

        Console.Write("Valor para el mes: ")
        Dim a As Byte = Console.ReadLine

        Select Case a

            Case 1
                Console.WriteLine("Mes de " & Meses.Enero.ToString)
            Case 2
                Console.WriteLine("Mes de " & Meses.Febrero.ToString)
            Case 3
                Console.WriteLine("Mes de " & Meses.Marzo.ToString)
            Case 4
                Console.WriteLine("Mes de " & Meses.Abril.ToString)
            Case 5
                Console.WriteLine("Mes de " & Meses.Mayo.ToString)
            Case 6
                Console.WriteLine("Mes de " & Meses.Junio.ToString)
            Case 7
                Console.WriteLine("Mes de " & Meses.Julio.ToString)
            Case 8
                Console.WriteLine("Mes de " & Meses.Agosto.ToString)
            Case 9
                Console.WriteLine("Mes de " & Meses.Septiembre.ToString)
            Case 10
                Console.WriteLine("Mes de " & Meses.Octubre.ToString)
            Case 11
                Console.WriteLine("Mes de " & Meses.Noviembre.ToString)
            Case 12
                Console.WriteLine("Mes de " & Meses.Diciembre.ToString)

        End Select

        Console.ReadKey()


    End Sub

End Module
