Module Module1
    Sub modulo()



        Console.WriteLine("........................................................................................")
        Console.WriteLine(".....BIENVENIDO AL SISTEMA DE TIEMPO DISTANCIA Y CAIDA LIBRE.............................")
        Console.WriteLine(".....JUAN NUÑEZ          17-EIIN-1-031...................................................")
        Console.WriteLine(".....JEFFREY MARTINEZ    17-EIIN-1-029...................................................")
        Console.WriteLine(".....JOHHNY MOISES       16-SIIN-1-134...................................................")
        Console.WriteLine(".....LUIS ANDERSON       03-MIIN-1-024...................................................")
        Console.WriteLine(".....RAYSIRIS GARCIA     17-MIIN-1-160...................................................")
        Console.WriteLine(".....JUNIOR BELLIARD     17-EIIN-1-032...................................................")
        Console.WriteLine(".....LUISSANNY MARTE     17-EIIN-1-040...................................................")
        Console.WriteLine(".....JORGE AYBAR         14-SIIN-1-026...................................................")
        Console.WriteLine("")




        Console.WriteLine("..USO DEL PROGRAMA......ESTE PROGRAMA ESTA DISEÑADO PARA IMPRIMIR CADA DECIMA DE SEGUNDO LA DISTANCIA ENTRE EL OBJETO Y EL SUELO Y AL FINAL IMPRIMA EL TIEMPO NECESARIO EN DECIMAS DE SEGUNDO PARA QUE EL OBJETO TOQUE EL SUELO....")
        Console.WriteLine("..UN OBJETO ES DEJADO CAER A UNA ALTURA DE 100 MTS...")









    End Sub












    Sub Main()
        modulo()


        'Dim valor As Integer = Console.ReadLine()

        calcular_distancia_tiempo_decimas(100)
        Console.ReadKey()
    End Sub

    Sub calcular_distancia_tiempo_decimas(ByVal v As Integer)

        For i = v To 1 Step -1

            Console.Write("La distancia es: {0:#.##} m", 0.5 * 9.81 * Math.Sqrt(i / (0.5 * 9.81)) ^ 2)
            'Console.Write(" y el tiempo es: {0:#.###} seg", Math.Sqrt(i / (0.5 * 9.81)))
            Console.Write(" y el tiempo en decimas es: {0:#.###} seg", Math.Sqrt(i / (0.5 * 9.81)) / 60)
            Console.WriteLine()
        Next
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("                 Total del tiempo en decimas es: {0:#.###} seg", Math.Sqrt(v / (0.5 * 9.81)) / 60)
    End Sub

End Module
