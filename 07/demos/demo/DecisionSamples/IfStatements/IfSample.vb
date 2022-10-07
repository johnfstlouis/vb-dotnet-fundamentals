Imports DecisionSamples.Common

Public Class IfSample
  Sub Sample01()
    Dim products = ProductManager.LoadProducts()

    For index As Integer = 0 To (products.Count - 1)
      If products(index).Color = "Red" Then
        Console.WriteLine("Red color product: " & products(index).ToString())
      End If
    Next
  End Sub

  Sub Sample02()
    Dim products = ProductManager.LoadProducts()

    For index As Integer = 0 To (products.Count - 1)
      If products(index).Color = "Red" Then
        Console.WriteLine("Red color product: " & products(index).ToString())
      Else
        Console.WriteLine("Other color product: " & products(index).ToString())
      End If
    Next
  End Sub

  Sub Sample03()
    Dim products = ProductManager.LoadProducts()

    For index As Integer = 0 To (products.Count - 1)
      If products(index).Color = "Red" Then
        Console.WriteLine("Red color product: " & products(index).ToString())
      ElseIf products(index).Color = "Black" Then
        Console.WriteLine("Black color product: " & products(index).ToString())
      Else
        Console.WriteLine("Other color product: " & products(index).ToString())
      End If
    Next
  End Sub
End Class
