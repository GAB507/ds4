Imports System

Module Program
    Sub Main(args As String())

        Dim radio As Single
        Dim Area As Single
        Dim circunferencia As Single
        Const pi = 3.1415926
        Console.Write("Ingrese el radio:")
        radio = Console.ReadLine()

        Area = pi * radio
        circunferencia = pi * 2 * radio
        Console.WriteLine("El area es: {0}", Area)
        Console.WriteLine("la circunferencia es : {0}", circunferencia)

        Console.ReadKey()


    End Sub
End Module
