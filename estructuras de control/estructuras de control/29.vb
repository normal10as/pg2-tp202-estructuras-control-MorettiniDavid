Module _29
    Sub main()
        Dim N As Int16
        Dim Cm As Int16
        Dim km As Int16
        Dim pies As Int16
        Dim pulg As Int16
        Dim Metro As Int16
        Dim yarda As Int16
        Console.Write("Ingrese  numero : ")
        N = Console.ReadLine
        Cm = N * 100
        km = N * 0.001
        pulg = N * 2.54
        pies = pulg * 12
        Metro = N * Cm
        yarda = pies * 3
        Console.Write(N & Cm & km & pulg & pies & Metro & yarda)
        Console.ReadKey()
    End Sub
End Module
