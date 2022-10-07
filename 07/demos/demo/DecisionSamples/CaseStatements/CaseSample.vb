Imports DecisionSamples.Common

Public Class CaseSample
  Sub Sample01()
    Dim products = ProductManager.LoadProducts()

    For index As Integer = 0 To (products.Count - 1)
      Select Case products(index).Size
        Case "58"
          Console.WriteLine("Size 58: " & products(index).Name)
        Case "L"
          Console.WriteLine("Size L: " & products(index).Name)
        Case "M"
          Console.WriteLine("Size M: " & products(index).Name)
      End Select
    Next
  End Sub

  Sub Sample02()
    Dim products = ProductManager.LoadProducts()

    For index As Integer = 0 To (products.Count - 1)
      Select Case products(index).Size
        Case "58"
          Console.WriteLine("Size 58: " & products(index).Name)
        Case "L"
          Console.WriteLine("Size L: " & products(index).Name)
        Case "M"
          Console.WriteLine("Size M: " & products(index).Name)
        Case Else
          Console.WriteLine(products(index).Name & " has size " & products(index).Size)
      End Select
    Next
  End Sub
End Class
