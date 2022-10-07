Public Class LoopingSample
  Sub Sample01()
    Dim products = ProductManager.LoadProducts()
    Dim index As Integer = 0
    Dim sum As Decimal = 0

    Do While index < (products.Count - 1)
      Console.WriteLine(products(index).ToString())
      sum += products(index).ListPrice

      index += 1
    Loop

    Console.WriteLine("Sum: " & sum.ToString("c"))
  End Sub

  Sub Sample02()
    Dim products = ProductManager.LoadProducts()
    Dim index As Integer = 0
    Dim sum As Decimal = 0

    Do
      Console.WriteLine(products(index).ToString())
      sum += products(index).ListPrice

      index += 1
    Loop While index < (products.Count)

    Console.WriteLine("Average: " & (sum / index).ToString("c"))
  End Sub

  Sub Sample03()
    Dim products = ProductManager.LoadProducts()
    Dim index As Integer = 0
    Dim min As Decimal = Decimal.MaxValue

    Do Until index > (products.Count - 1)
      Console.WriteLine(products(index).ToString())

      min = Convert.ToDecimal(IIf(products(index).ListPrice < min, products(index).ListPrice, min))

      index += 1
    Loop

    Console.WriteLine("Min: " & min.ToString("c"))
  End Sub

  Sub Sample04()
    Dim products = ProductManager.LoadProducts()
    Dim index As Integer = 0
    Dim max As Decimal = Decimal.MinValue

    Do
      Console.WriteLine(products(index).ToString())

      max = Convert.ToDecimal(IIf(products(index).ListPrice > max, products(index).ListPrice, max))

      index += 1
    Loop Until index > (products.Count - 1)

    Console.WriteLine("Max: " & max.ToString("c"))
  End Sub

  Sub Sample05()
    Dim products = ProductManager.LoadProducts()

    For index As Integer = 0 To (products.Count - 1)
      Console.WriteLine(products(index).ToString())
    Next
  End Sub

  Sub Sample06()
    Dim products = ProductManager.LoadProducts()

    For index As Integer = (products.Count - 1) To 0 Step -1
      Console.WriteLine(products(index).ToString())
    Next
  End Sub
End Class
