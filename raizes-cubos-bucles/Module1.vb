Option Strict On
Module Module1

    Sub Main()
        Dim i, i2, num, numn As Double
        Dim cond, cond2 As Boolean
        Console.WriteLine("Introduzca el número por el cual comenzará el cálculo")
        num = Convert.ToDouble(Console.ReadLine())

        cond = i Mod 2 = 0
        cond2 = i Mod 2 <> 0

        If cond Then
            While (num <= (numn + 10))
                num = num + 2
                i = Math.Pow(num, 2)
                i2 = Math.Pow(num, 3)
                Console.WriteLine(num & ", " & i & ", " & i2)
            End While
        Else
            If cond2 Then
                num += 1
                While (num <= (num + 10))
                    num = num + 2
                    i = Math.Pow(num, 2)
                    i2 = Math.Pow(num, 3)
                    Console.WriteLine(num & ", " & i & ", " & i2)
                End While
            End If
        End If
        Console.ReadLine()





    End Sub

End Module
