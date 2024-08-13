Imports System

Module Program
    Dim frecuencia As Double
    Dim inductancia As Double
    Dim capacitancia As Double
    Dim resistencia As Double
    Dim XL As Double
    Dim PI = 3.14159
    Dim XC As Double
    Dim PartDivXC As Double
    Dim PartDivFrecuenciaresonancia As Double
    Dim ZT As Double
    Dim TITArad As Double
    Dim TITAgrad As Double
    Dim Frecresonancia As Double
    Dim restadex As Double
    Dim Mayor As Double
    Dim Menor As Double



    Sub Main(args As String())
        Console.WriteLine("Ingres valor de frecuencia Hertz")
        frecuencia = Console.ReadLine()
        Console.WriteLine("Ingrese valor de inductancia en Henrios")
        inductancia = Console.ReadLine()
        Console.WriteLine("Ingrese valor de capacitancia en Faradios")
        capacitancia = Console.ReadLine()
        Console.WriteLine("Ingrese valor de resistencia en Homs")
        resistencia = Console.ReadLine()
        XL = 2 * PI * frecuencia * inductancia
        Console.WriteLine("Valor de XL" & XL)
        PartDivXC = (2 * PI * (frecuencia) * (capacitancia))
        XC = 1 / PartDivXC
        Console.WriteLine("Valor de XC" & XC)
        restadex = XL - XC
        ZT = Math.Sqrt((resistencia ^ 2) + (restadex ^ 2))
        Console.WriteLine("Resultado de ZT " & ZT)
        TITArad = Math.Atan(restadex / resistencia)
        TITAgrad = (TITArad * (180 / PI))
        Console.WriteLine("Resultado de TITA " & TITAgrad)
        Mayor = Math.Max(TITAgrad, 0)
        Menor = Math.Min(TITAgrad, 0)
        Console.WriteLine("Circuito inductivo " & Mayor)
        Console.WriteLine("Circuito capacitivo" & Menor)
        PartDivFrecuenciaresonancia = (2 * PI * Math.Sqrt(inductancia * capacitancia))
        Frecresonancia = 1 / PartDivFrecuenciaresonancia
        Console.WriteLine("Resultado de Frecuencia de resonancia" & Frecresonancia)

    End Sub
End Module
