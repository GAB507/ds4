Imports System

Module Program
    Sub Main(args As String())

        Dim M As Double
        Dim G As Double
        Dim P As Double

        G = 9.8
        Console.Write("Ingrese la masa del objeto: ")
        M = Console.ReadLine()

        'Comentario , realizar proceso
        P = M * G

        'mostrar resultados
        Console.WriteLine("Peso del objeto: {0}", P)
        Console.ReadKey()


    End Sub
End Module
