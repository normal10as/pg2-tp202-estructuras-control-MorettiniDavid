Module _28
    Sub main()
        Dim ano As Integer
        Console.Write("Ingrese  año: ")
        ano = Console.ReadLine
        If ((ano Mod 4) = 0) And ((ano Mod 100) <> 0 Or (ano Mod 400) = 0) Then
            Console.Write("es biciesto: ")
            Console.ReadKey()

        Else
            Console.Write("no biciesto: ")
            Console.ReadKey()

        End If



    End Sub

End Module
