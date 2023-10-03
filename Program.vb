Imports System

Module Program
    Sub Main()
        Dim kal As Kalkulator = New Kalkulator

        ' Meminta pengguna untuk memasukkan angka
        Console.Write("Masukkan angka pertama: ")
        Dim angka1 As Integer = Integer.Parse(Console.ReadLine())

        Console.Write("Masukkan angka kedua: ")
        Dim angka2 As Integer = Integer.Parse(Console.ReadLine())

        ' Memanggil fungsi-fungsi kalkulator dan menampilkan hasilnya
        Console.WriteLine("Hasil Penjumlahan: " & kal.Jumlah(angka1, angka2))
        Console.WriteLine("Hasil Pengurangan: " & kal.Kurang(angka1, angka2))
        Console.WriteLine("Hasil Perkalian: " & kal.Kali(angka1, angka2))
        Console.WriteLine("Hasil Pembagian: " & kal.Bagi(angka1, angka2))
        Console.WriteLine("Hasil Modulus: " & kal.Modulus(angka1, angka2))
    End Sub


    Public Class Kalkulator
        Public Function Jumlah(x As Integer, y As Integer)
            Return x + y
        End Function
        Public Function Kurang(x As Integer, y As Integer)
            Return x - y
        End Function
        Public Function Kali(x As Integer, y As Integer)
            Return x * y
        End Function
        Public Function Bagi(x As Double, y As Double)
            Return x / y
        End Function
        Public Function Modulus(x As Integer, y As Integer)
            Return x Mod y
        End Function
    End Class
End Module
