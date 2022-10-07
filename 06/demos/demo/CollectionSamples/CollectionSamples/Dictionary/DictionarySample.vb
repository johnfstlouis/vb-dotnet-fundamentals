Imports CollectionSamples.Common

Public Class DictionarySample
  Function LoadProducts() As Dictionary(Of String, Product)
    Dim products As New Dictionary(Of String, Product)
    Dim prod As Product

    prod = New Product() With {.ProductID = 1, .Name = "10 Speed Bike", .ProductNumber = "10-SP", .ListPrice = 1431.5D}
    products.Add(key:=prod.ProductID.ToString(), value:=prod)

    prod = New Product() With {.ProductID = 2, .Name = "Bike Helmet", .ProductNumber = "BIKE-HE", .ListPrice = 39.99D}
    products.Add(prod.ProductID.ToString(), prod)

    prod = New Product() With {.ProductID = 3, .Name = "Inner Tube", .ProductNumber = "BIKE-IN-TU", .ListPrice = 4.99D}
    products.Add(prod.ProductID.ToString(), prod)

    Return products
  End Function

  Sub Sample01()
    Dim products = LoadProducts()

    Console.WriteLine(products("1"))
    Console.WriteLine(products("2"))
    Console.WriteLine(products("3"))
  End Sub

  Sub Sample02()
    Dim products = LoadProducts()

    ' See if a specific key exists in the dictionary
    Console.WriteLine(products.ContainsKey("1"))
    Console.WriteLine(products.ContainsKey("99"))
  End Sub

  Sub Sample03()
    Dim products = LoadProducts()

    ' Display the total number of items in the dictionary
    Console.WriteLine(products.Count)

    ' Remove an item
    products.Remove("1")
    Console.WriteLine(products.Count)

    ' Remove all items
    products.Clear()
    Console.WriteLine(products.Count)
  End Sub

  Sub Sample04()
    Dim products = LoadProducts()

    ' Display the sum of all list prices
    Console.WriteLine(products.Sum(Function(p) p.Value.ListPrice).ToString("c"))

    ' Display the average of all list prices
    Console.WriteLine(products.Average(Function(p) p.Value.ListPrice).ToString("c"))

    ' Display the minimum of all list prices
    Console.WriteLine(products.Min(Function(p) p.Value.ListPrice).ToString("c"))

    ' Display the maxiumum of all list prices
    Console.WriteLine(products.Max(Function(p) p.Value.ListPrice).ToString("c"))
  End Sub
End Class
