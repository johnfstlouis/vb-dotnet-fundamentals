Imports CollectionSamples.Common

Public Class ArrayListSample
  Sub Sample01()
    Dim products As New ArrayList From {
      "10 Speed Bike",
      "Bike Helmet",
      "Inner Tube"
  }

    Console.WriteLine(products(0))
    Console.WriteLine(products(1))
    Console.WriteLine(products(2))

    Console.WriteLine(products.Count)
  End Sub

  Sub Sample02()
    Dim products As New ArrayList From {
    New Product() With {.ProductID = 1, .Name = "10 Speed Bike", .ProductNumber = "10-SP"},
    New Product() With {.ProductID = 2, .Name = "Bike Helmet", .ProductNumber = "BIKE-HE"},
    New Product() With {.ProductID = 3, .Name = "Inner Tube", .ProductNumber = "BIKE-IN-TU"}
  }

    Console.WriteLine(products(0))
    Console.WriteLine(products(1))
    Console.WriteLine(products(2))
  End Sub
End Class
