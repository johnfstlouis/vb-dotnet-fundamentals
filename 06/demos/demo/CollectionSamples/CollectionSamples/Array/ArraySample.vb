Public Class ArraySample
  Sub Sample01()
    Dim products(3) As String

    products(0) = "10 Speed Bike"
    products(1) = "Bike Helmet"
    products(2) = "Inner Tube"

    Console.WriteLine(products(0))
    Console.WriteLine(products(1))
    Console.WriteLine(products(2))

    Console.WriteLine(products.Length)
  End Sub

  Sub Sample02()
    Dim products As String() = {"10 Speed Bike", "Bike Helmet", "Inner Tube"}

    Console.WriteLine(products(0))
    Console.WriteLine(products(1))
    Console.WriteLine(products(2))
  End Sub
End Class
